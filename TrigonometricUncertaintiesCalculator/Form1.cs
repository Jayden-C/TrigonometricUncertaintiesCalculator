using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TrigonometricUncertaintiesCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Auto-generated Methods

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SineModeGoButton_Click(object sender, EventArgs e)
        {
            if (XValueSetterTextBox.TextLength == 0 && UValueSetterTextBox.TextLength == 0)
            {
                PrintFormulaSine();
            }
        }

        private void CosineModeGoButton_Click(object sender, EventArgs e)
        {
            if (XValueSetterTextBox.TextLength == 0 && UValueSetterTextBox.TextLength == 0)
            {
                PrintFormulaCosine();
            }
        }

        private void ResultClearButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = "";
        }

        private void uInRadiansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uInRadiansToolStripMenuItem.Checked = !uInRadiansToolStripMenuItem.Checked;
        }

        private void SmallUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SmallUToolStripMenuItem.Checked = !SmallUToolStripMenuItem.Checked;
        }

        #endregion

        #region Custom Methods

        private void PrintSingleLineCenter(string toPrint)
        {
            ResultTextBox.SelectionAlignment = HorizontalAlignment.Center;
            ResultTextBox.Font = new Font("Segoe UI", 30, FontStyle.Italic);
            ResultTextBox.Text = $"\n{toPrint}";
        }

        private void PrintFormulaSine()
        {
            if (!uInRadiansToolStripMenuItem.Checked)
            {
                PrintSingleLineCenter(SmallUToolStripMenuItem.Checked
                    ? "y = sin(x) ± cos(x)sin(u)"
                    : "y = sin(x)cos(u) ± cos(x)sin(u)");
            }
            else
            {
                PrintSingleLineCenter(SmallUToolStripMenuItem.Checked
                    ? "y = sin(x) ± u•cos(x)"
                    : "y = sin(x)cos(u) ± cos(x)sin(u)");
            }
        }

        private void PrintFormulaCosine()
        {
            if (!uInRadiansToolStripMenuItem.Checked)
            {
                PrintSingleLineCenter(SmallUToolStripMenuItem.Checked
                    ? "y = cos(x) ± sin(x)sin(u)"
                    : "y = cos(x)cos(u) ± sin(x)sin(u)");
            }
            else
            {
                PrintSingleLineCenter(SmallUToolStripMenuItem.Checked
                    ? "y = cos(x) ± u•sin(x)"
                    : "y = cos(x)cos(u) ± sin(x)sin(u)");
            }
        }

        #endregion

    }
}
