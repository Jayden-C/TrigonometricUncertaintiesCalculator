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
    /// <inheritdoc />
    /// <summary>
    /// Main window of application
    /// </summary>
    public partial class MainForm : Form
    {
        private static double x;
        private static double u;
        private static bool _noX;

        private readonly UncertaintyCalculator _calculator = new UncertaintyCalculator();
        private readonly AboutForm _aboutForm = new AboutForm();

        /// <inheritdoc />
        /// <summary>
        /// Constructor for MainForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
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
                ResultTextBoxAlign(HorizontalAlignment.Center);
                _calculator.PrintFormulaSine(RadiansToolStripMenuItem.Checked, SmallUToolStripMenuItem.Checked);
            }
            else
            {
                SetXandUValues();
                ResultTextBoxAlign(HorizontalAlignment.Left);
                _calculator.GenerateOutput(UncertaintyCalculator.Mode.Sine, x, u,SmallUToolStripMenuItem.Checked, RadiansToolStripMenuItem.Checked);
            }
        }

        private void CosineModeGoButton_Click(object sender, EventArgs e)
        {
            if (XValueSetterTextBox.TextLength == 0 && UValueSetterTextBox.TextLength == 0)
            {
                ResultTextBoxAlign(HorizontalAlignment.Center);
                _calculator.PrintFormulaCosine(RadiansToolStripMenuItem.Checked, SmallUToolStripMenuItem.Checked);
            }
            else
            {
                SetXandUValues();
                ResultTextBoxAlign(HorizontalAlignment.Left);
                _calculator.GenerateOutput(UncertaintyCalculator.Mode.Cosine, x, u, SmallUToolStripMenuItem.Checked, RadiansToolStripMenuItem.Checked);
            }
        }

        private void ResultClearButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = "";
            XValueSetterTextBox.Text = "";
            UValueSetterTextBox.Text = "";
            _noX = true;
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
            switch(e.KeyCode)
            {
                case Keys.D:
                    if (e.Control) ResultClearButton_Click(null, null);
                    break;
                case Keys.F:
                    if (e.Control) ResultTextBox.SelectAll();
                    break;
                default:
                    break;
            }

            //if (e.Control && e.KeyCode == Keys.D) ResultClearButton_Click(null, null);
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

        private void testButtonPloxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ResultTextBox.SelectionAlignment = HorizontalAlignment.Left;
            // _calculator.GenerateOutputBigU(UncertaintyCalculator.Mode.Sine, 55, 5, false);
        }

        /// <summary>
        /// Gets the values from the x and u text boxes and stores them in variables.
        /// </summary>
        private void SetXandUValues()
        {
            ResultTextBox.Text = "";
            if (XValueSetterTextBox.TextLength == 0) _noX = true;
            else
            {
                _noX = false;
                x = Convert.ToDouble(XValueSetterTextBox.Text);
            }

            if(UValueSetterTextBox.TextLength == 0 && XValueSetterTextBox.TextLength != 0)
            {
                MessageBox.Show("Please input a value for the uncertainty.");
            }
            else
            {
                u = Convert.ToDouble(UValueSetterTextBox.Text);
            }
        }

        private void ResultTextBoxAlign(HorizontalAlignment align)
        {
            ResultTextBox.SelectAll();
            ResultTextBox.SelectionAlignment = align;
            ResultTextBox.DeselectAll();
        }

        private void ClearXandUValues()
        {
            x = 0;
            u = 0;
            _noX = true;
        }
    }
}
