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
        private UncertaintyCalculator _calculator = new UncertaintyCalculator();

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
                _calculator.PrintFormulaSine(RadiansToolStripMenuItem.Checked, SmallUToolStripMenuItem.Checked);
            }
        }

        private void CosineModeGoButton_Click(object sender, EventArgs e)
        {
            if (XValueSetterTextBox.TextLength == 0 && UValueSetterTextBox.TextLength == 0)
            {
                _calculator.PrintFormulaCosine(RadiansToolStripMenuItem.Checked, SmallUToolStripMenuItem.Checked);
            }
        }

        private void ResultClearButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = "";
            XValueSetterTextBox.Text = "";
            UValueSetterTextBox.Text = "";
        }

        private void RadiansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RadiansToolStripMenuItem.Checked = !RadiansToolStripMenuItem.Checked;
        }

        private void SmallUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SmallUToolStripMenuItem.Checked = !SmallUToolStripMenuItem.Checked;
        }

        #endregion
        
        public void PrintToResultTextBox(Font font, string text)
        {
            ResultTextBox.SelectionAlignment = HorizontalAlignment.Center;
            ResultTextBox.Font = font;
            ResultTextBox.Text = text;
        }

    }
}
