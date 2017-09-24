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

        public void PrintFormulaSine(bool radians, bool small)
        {
            if(radians) Print(_printFont, small ? "\nsin(x) ± u•cos(x)" : "\ny = sin(x)cos(u) ± cos(x)sin(u)");
            else Print(_printFont, small ? "\nsin(x) ± cos(x)sin(u)" : "\ny = sin(x)cos(u) ± cos(x)sin(u)");

        }

        public void PrintFormulaCosine(bool radians, bool small)
        {
            if (radians) Print(_printFont, small ? "\ncos(x) ± u•sin(x)" : "\ny = cos(x)cos(u) ± sin(x)sin(u)");
            else Print(_printFont, small ? "\ncos(x) ± sin(x)sin(u)" : "\ny = cos(x)cos(u) ± sin(x)sin(u)");
        }

        private void Print(Font font, string text) => Program.MainWindowForm.PrintToResultTextBox(font, text);
    }
}
