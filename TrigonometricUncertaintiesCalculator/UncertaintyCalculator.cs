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
        /// <param name="radians">Radians mode</param>
        /// <returns></returns>
        public void GenerateOutputBigU(Mode mode, double x, double u, bool radians)
        {
            switch(mode)
            {
                case Mode.Sine:
                    Print(_printFont, GenerateOutputSine(x, u, false, radians));
                    break;
                case Mode.Cosine:
                    //return GenerateOutputCosine();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

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

                default:
                    throw new NotImplementedException();
            }
        }

        public string GenerateOutputCosine()
        {
            throw new NotImplementedException();
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
