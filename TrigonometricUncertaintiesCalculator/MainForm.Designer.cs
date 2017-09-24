namespace TrigonometricUncertaintiesCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SineModeLabel = new System.Windows.Forms.Label();
            this.CosineModeLabel = new System.Windows.Forms.Label();
            this.TipsLabel = new System.Windows.Forms.Label();
            this.SineModeGoButton = new System.Windows.Forms.Button();
            this.CosineModeGoButton = new System.Windows.Forms.Button();
            this.XValueSetterLabel = new System.Windows.Forms.Label();
            this.UValueSetterLabel = new System.Windows.Forms.Label();
            this.UValueSetterTextBox = new System.Windows.Forms.RichTextBox();
            this.XValueSetterTextBox = new System.Windows.Forms.RichTextBox();
            this.ResultTextBox = new System.Windows.Forms.RichTextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RadiansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SmallUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResultClearButton = new System.Windows.Forms.Button();
            this.ResultClearButtonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SineModeLabel
            // 
            this.SineModeLabel.AutoSize = true;
            this.SineModeLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SineModeLabel.Location = new System.Drawing.Point(12, 24);
            this.SineModeLabel.Name = "SineModeLabel";
            this.SineModeLabel.Size = new System.Drawing.Size(135, 40);
            this.SineModeLabel.TabIndex = 0;
            this.SineModeLabel.Text = "sin(x ± u)";
            // 
            // CosineModeLabel
            // 
            this.CosineModeLabel.AutoSize = true;
            this.CosineModeLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CosineModeLabel.Location = new System.Drawing.Point(12, 64);
            this.CosineModeLabel.Name = "CosineModeLabel";
            this.CosineModeLabel.Size = new System.Drawing.Size(140, 40);
            this.CosineModeLabel.TabIndex = 1;
            this.CosineModeLabel.Text = "cos(x ± u)";
            // 
            // TipsLabel
            // 
            this.TipsLabel.AutoSize = true;
            this.TipsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipsLabel.Location = new System.Drawing.Point(311, 24);
            this.TipsLabel.Name = "TipsLabel";
            this.TipsLabel.Size = new System.Drawing.Size(373, 100);
            this.TipsLabel.TabIndex = 2;
            this.TipsLabel.Text = "Let u = your uncertainty.\r\nLeaving the \'x\' and \'u\' fields blank will \r\ngive the g" +
    "eneral formula for trigonometric \r\nuncertainties.\r\n";
            // 
            // SineModeGoButton
            // 
            this.SineModeGoButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SineModeGoButton.Location = new System.Drawing.Point(153, 34);
            this.SineModeGoButton.Name = "SineModeGoButton";
            this.SineModeGoButton.Size = new System.Drawing.Size(135, 30);
            this.SineModeGoButton.TabIndex = 3;
            this.SineModeGoButton.Text = "Calculate";
            this.SineModeGoButton.UseVisualStyleBackColor = true;
            this.SineModeGoButton.Click += new System.EventHandler(this.SineModeGoButton_Click);
            // 
            // CosineModeGoButton
            // 
            this.CosineModeGoButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CosineModeGoButton.Location = new System.Drawing.Point(153, 74);
            this.CosineModeGoButton.Name = "CosineModeGoButton";
            this.CosineModeGoButton.Size = new System.Drawing.Size(135, 30);
            this.CosineModeGoButton.TabIndex = 4;
            this.CosineModeGoButton.Text = "Calculate";
            this.CosineModeGoButton.UseVisualStyleBackColor = true;
            this.CosineModeGoButton.Click += new System.EventHandler(this.CosineModeGoButton_Click);
            // 
            // XValueSetterLabel
            // 
            this.XValueSetterLabel.AutoSize = true;
            this.XValueSetterLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XValueSetterLabel.Location = new System.Drawing.Point(12, 104);
            this.XValueSetterLabel.Name = "XValueSetterLabel";
            this.XValueSetterLabel.Size = new System.Drawing.Size(66, 40);
            this.XValueSetterLabel.TabIndex = 5;
            this.XValueSetterLabel.Text = "x = ";
            // 
            // UValueSetterLabel
            // 
            this.UValueSetterLabel.AutoSize = true;
            this.UValueSetterLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UValueSetterLabel.Location = new System.Drawing.Point(12, 144);
            this.UValueSetterLabel.Name = "UValueSetterLabel";
            this.UValueSetterLabel.Size = new System.Drawing.Size(89, 40);
            this.UValueSetterLabel.TabIndex = 6;
            this.UValueSetterLabel.Text = "u = ±";
            // 
            // UValueSetterTextBox
            // 
            this.UValueSetterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UValueSetterTextBox.Location = new System.Drawing.Point(107, 154);
            this.UValueSetterTextBox.Multiline = false;
            this.UValueSetterTextBox.Name = "UValueSetterTextBox";
            this.UValueSetterTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.UValueSetterTextBox.Size = new System.Drawing.Size(181, 30);
            this.UValueSetterTextBox.TabIndex = 7;
            this.UValueSetterTextBox.Text = "";
            // 
            // XValueSetterTextBox
            // 
            this.XValueSetterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XValueSetterTextBox.Location = new System.Drawing.Point(84, 114);
            this.XValueSetterTextBox.Multiline = false;
            this.XValueSetterTextBox.Name = "XValueSetterTextBox";
            this.XValueSetterTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.XValueSetterTextBox.Size = new System.Drawing.Size(204, 30);
            this.XValueSetterTextBox.TabIndex = 8;
            this.XValueSetterTextBox.Text = "";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(12, 264);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ResultTextBox.Size = new System.Drawing.Size(681, 335);
            this.ResultTextBox.TabIndex = 11;
            this.ResultTextBox.Text = "";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(308, 221);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(104, 40);
            this.ResultLabel.TabIndex = 12;
            this.ResultLabel.Text = "Result:";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RadiansToolStripMenuItem,
            this.SmallUToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // RadiansToolStripMenuItem
            // 
            this.RadiansToolStripMenuItem.Checked = true;
            this.RadiansToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RadiansToolStripMenuItem.Name = "RadiansToolStripMenuItem";
            this.RadiansToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.RadiansToolStripMenuItem.Text = "Radians";
            this.RadiansToolStripMenuItem.Click += new System.EventHandler(this.RadiansToolStripMenuItem_Click);
            // 
            // SmallUToolStripMenuItem
            // 
            this.SmallUToolStripMenuItem.Name = "SmallUToolStripMenuItem";
            this.SmallUToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.SmallUToolStripMenuItem.Text = "Small \'u\'";
            this.SmallUToolStripMenuItem.Click += new System.EventHandler(this.SmallUToolStripMenuItem_Click);
            // 
            // ResultClearButton
            // 
            this.ResultClearButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultClearButton.Location = new System.Drawing.Point(617, 235);
            this.ResultClearButton.Name = "ResultClearButton";
            this.ResultClearButton.Size = new System.Drawing.Size(75, 23);
            this.ResultClearButton.TabIndex = 14;
            this.ResultClearButton.Text = "Clear";
            this.ResultClearButtonToolTip.SetToolTip(this.ResultClearButton, "(Ctrl+D)");
            this.ResultClearButton.UseVisualStyleBackColor = true;
            this.ResultClearButton.Click += new System.EventHandler(this.ResultClearButton_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 611);
            this.Controls.Add(this.ResultClearButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.XValueSetterTextBox);
            this.Controls.Add(this.UValueSetterTextBox);
            this.Controls.Add(this.UValueSetterLabel);
            this.Controls.Add(this.XValueSetterLabel);
            this.Controls.Add(this.CosineModeGoButton);
            this.Controls.Add(this.SineModeGoButton);
            this.Controls.Add(this.TipsLabel);
            this.Controls.Add(this.CosineModeLabel);
            this.Controls.Add(this.SineModeLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Trigonometric Uncertainties Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SineModeLabel;
        private System.Windows.Forms.Label CosineModeLabel;
        private System.Windows.Forms.Label TipsLabel;
        private System.Windows.Forms.Button SineModeGoButton;
        private System.Windows.Forms.Button CosineModeGoButton;
        private System.Windows.Forms.Label XValueSetterLabel;
        private System.Windows.Forms.Label UValueSetterLabel;
        private System.Windows.Forms.RichTextBox UValueSetterTextBox;
        private System.Windows.Forms.RichTextBox XValueSetterTextBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.RichTextBox ResultTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button ResultClearButton;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RadiansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SmallUToolStripMenuItem;
        private System.Windows.Forms.ToolTip ResultClearButtonToolTip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

