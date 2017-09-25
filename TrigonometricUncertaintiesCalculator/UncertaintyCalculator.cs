using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrigonometricUncertaintiesCalculator
{
    class UncertaintyCalculator
    {
        private readonly Font _printFont = new Font("Segoe UI", 30, FontStyle.Italic);
        
        public enum Mode {Sine, Cosine}

        /// <summary>
        /// Generate the output of the calculator based on the given paramaters
        /// </summary>
        /// <param name="mode">Sine or Cosine mode</param>
        /// <param name="x">x value</param>
        /// <param name="u">uncertainty</param>
        /// <param name="smallU">Whether or not the uncertainty is small enough to omit cos(u)</param>
        /// <param name="radians">Radians mode</param>
        /// <returns></returns>
        public void GenerateOutput(Mode mode, double x, double u, bool smallU, bool radians)
        {
            switch(mode)
            {
                case Mode.Sine:
                    Print(_printFont, GenerateOutputSine(x, u, smallU, radians));
                    break;
                case Mode.Cosine:
                    Print(_printFont, GenerateOutputCosine(x, u, smallU, radians));
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Returns detailed calculations for trig uncertainties using Sine function
        /// </summary>
        /// <param name="x">x variable / data</param>
        /// <param name="u">Uncertainty</param>
        /// <param name="smallU">Whether or not the uncertainty is small enough to omit cos(u)</param>
        /// <param name="radians">Radians or degrees mode</param>
        /// <returns></returns>
        public string GenerateOutputSine(double x, double u, bool smallU, bool radians)
        {
            var xInRadians = radians ? x : (x * Math.PI / 180);
            var uInRadians = radians ? u : (u * Math.PI / 180);

            var sinX = Math.Round(Math.Sin(xInRadians), 3);
            var cosX = Math.Round(Math.Cos(xInRadians), 3);

            var sinU = Math.Round(Math.Sin(uInRadians), 3);
            var cosU = Math.Round(Math.Cos(uInRadians), 3);

            switch (smallU)
            {
                case false:
                    return $"y = sin({x})cos({u}) ± cos({x})sin({u})\n" +
                           $"y = ({sinX})({cosU}) ± ({cosX})({sinU})\n\n" +
                           $"y = {Math.Round(sinX * cosU, 3)} ± {Math.Round(cosX * sinU, 3)} or\n" +
                           $"y = {Math.Round(sinX * cosU, 3)} ± {PercentOf(sinX * cosU, cosX * sinU)}%";
                case true:
                    return $"y = sin({x}) ± cos({x})sin({u})\n" +
                           $"y = ({sinX}) ± ({cosX})({sinU})\n\n" +
                           $"y = ({sinX}) ± {Math.Round(cosX * sinU, 3)} or\n" +
                           $"y = ({sinX}) ± {PercentOf(sinX, cosX * sinU)}%";

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public string GenerateOutputCosine(double x, double u, bool smallU, bool radians)
        {
            var xInRadians = radians ? Math.Round(x, 3) : Math.Round((x * Math.PI / 180), 3);
            var uInRadians = radians ? Math.Round(u, 3) : Math.Round((u * Math.PI / 180), 3);

            var sinX = Math.Round(Math.Sin(xInRadians), 3);
            var cosX = Math.Round(Math.Cos(xInRadians), 3);

            var sinU = Math.Round(Math.Sin(uInRadians), 3);
            var cosU = Math.Round(Math.Cos(uInRadians), 3);

            switch(smallU)
            {
                case false:
                    return $"y = cos({x})cos({u}) ± sin({x})sin({u})\n" +
                           $"y = ({cosX})({cosU}) ± ({sinX})({sinU})\n\n" +
                           $"y = {Math.Round(cosX * cosU, 3)} ± {Math.Round(sinX * sinU, 3)} or\n" +
                           $"y = {Math.Round(cosX * cosU, 3)} ± {PercentOf(cosX * cosU, sinX * sinU)}%";
                case true:
                    return null;
                default:
                    throw new ArgumentOutOfRangeException();
            }

        }

        /// <summary>
        /// Prints the Sine uncertainty formulas in the case of the user leaving the 'x' and 'u' fields blank
        /// </summary>
        /// <param name="radians">Whether to print radians or degrees formula</param>
        /// <param name="small">Whether to print small uncertainty formula or not</param>
        public void PrintFormulaSine(bool radians, bool small)
        {
            if(radians) Print(_printFont, small ? "\nsin(x) ± u•cos(x)" : "\ny = sin(x)cos(u) ± cos(x)sin(u)");
            else Print(_printFont, small ? "\nsin(x) ± cos(x)sin(u)" : "\ny = sin(x)cos(u) ± cos(x)sin(u)");

        }

        /// <summary>
        /// Prints the Cosine uncertainty formulas in the case of the user leaving the 'x' and 'u' fields blank
        /// </summary>
        /// <param name="radians">Whether to print radians or degrees formula</param>
        /// <param name="small">Whether to print small uncertainty formula or not</param>
        public void PrintFormulaCosine(bool radians, bool small)
        {
            if (radians) Print(_printFont, small ? "\ncos(x) ± u•sin(x)" : "\ny = cos(x)cos(u) ± sin(x)sin(u)");
            else Print(_printFont, small ? "\ncos(x) ± sin(x)sin(u)" : "\ny = cos(x)cos(u) ± sin(x)sin(u)");
        }

        /// <summary>
        /// Prints to the results box of the main form
        /// </summary>
        /// <param name="font">Font to be used</param>
        /// <param name="text">Text to print into the results box</param>
        private void Print(Font font, string text) => Program.MainWindowForm.PrintToResultTextBox(font, text);

        private double PercentOf(double primary, double secondary)
        {
            var percent = (secondary / primary) * 100;
            return Math.Round(percent, 1);
        }
    }
}
