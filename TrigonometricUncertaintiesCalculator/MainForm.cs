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
    public partial class MainForm : Form
    {
        private readonly UncertaintyCalculator _calculator = new UncertaintyCalculator();
        private readonly AboutForm _aboutForm = new AboutForm();

        public MainForm()
        {
            InitializeComponent();
            ResultTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        #region Auto-generated Methods

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.D) ResultClearButton_Click(null, null);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _aboutForm.ShowDialog();
        }

        #endregion

        /// <summary>
        /// Sets the font and text of the result text box. To be used primarily by external classes.
        /// </summary>
        /// <param name="font">Font to be used</param>
        /// <param name="text">Text to be printed in the result box</param>
        public void PrintToResultTextBox(Font font, string text)
        {
            ResultTextBox.Font = font;
            ResultTextBox.Text = text;
        }

    }
}
