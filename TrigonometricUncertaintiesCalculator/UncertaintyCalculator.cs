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

        public string GenerateOutput(Mode mode, double x, double u)
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
    }
}
