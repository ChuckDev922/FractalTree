namespace Fractal
{
    partial class Fractal
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
			this.gbFractal = new System.Windows.Forms.GroupBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.asXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.asBitmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hscrPan = new System.Windows.Forms.HScrollBar();
			this.vscrPan = new System.Windows.Forms.VScrollBar();
			this.picBoxCanvas = new System.Windows.Forms.PictureBox();
			this.lblAngle = new System.Windows.Forms.Label();
			this.nudAngle = new System.Windows.Forms.NumericUpDown();
			this.lblRandom = new System.Windows.Forms.Label();
			this.nudRandom = new System.Windows.Forms.NumericUpDown();
			this.lblDebug = new System.Windows.Forms.Label();
			this.nudRecursionDepth = new System.Windows.Forms.NumericUpDown();
			this.lblRecursionDepth = new System.Windows.Forms.Label();
			this.cbLeaves = new System.Windows.Forms.CheckBox();
			this.gbControls = new System.Windows.Forms.GroupBox();
			this.gbEndLeaves = new System.Windows.Forms.GroupBox();
			this.btnColor = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbRandomThirdBranch = new System.Windows.Forms.RadioButton();
			this.rbThreeBranches = new System.Windows.Forms.RadioButton();
			this.rbTwoLeaves = new System.Windows.Forms.RadioButton();
			this.lblLength = new System.Windows.Forms.Label();
			this.nudLength = new System.Windows.Forms.NumericUpDown();
			this.tbDebug = new System.Windows.Forms.TextBox();
			this.gbDebug = new System.Windows.Forms.GroupBox();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.btnClearSettings = new System.Windows.Forms.Button();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gbFractal.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picBoxCanvas)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudAngle)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudRandom)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudRecursionDepth)).BeginInit();
			this.gbControls.SuspendLayout();
			this.gbEndLeaves.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
			this.gbDebug.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbFractal
			// 
			this.gbFractal.BackColor = System.Drawing.SystemColors.Control;
			this.gbFractal.Controls.Add(this.menuStrip1);
			this.gbFractal.Controls.Add(this.hscrPan);
			this.gbFractal.Controls.Add(this.vscrPan);
			this.gbFractal.Controls.Add(this.picBoxCanvas);
			this.gbFractal.Location = new System.Drawing.Point(12, 12);
			this.gbFractal.Name = "gbFractal";
			this.gbFractal.Size = new System.Drawing.Size(623, 791);
			this.gbFractal.TabIndex = 0;
			this.gbFractal.TabStop = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(3, 16);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(617, 24);
			this.menuStrip1.TabIndex = 11;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asXMLToolStripMenuItem,
            this.asBitmapToolStripMenuItem});
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.saveToolStripMenuItem.Text = "Save";
			// 
			// asXMLToolStripMenuItem
			// 
			this.asXMLToolStripMenuItem.Name = "asXMLToolStripMenuItem";
			this.asXMLToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.asXMLToolStripMenuItem.Text = "As XML File";
			this.asXMLToolStripMenuItem.Click += new System.EventHandler(this.SaveAsXMLToolStripMenuItem_Click);
			// 
			// asBitmapToolStripMenuItem
			// 
			this.asBitmapToolStripMenuItem.Name = "asBitmapToolStripMenuItem";
			this.asBitmapToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.asBitmapToolStripMenuItem.Text = "As Image File";
			this.asBitmapToolStripMenuItem.Click += new System.EventHandler(this.SaveAsBitmapToolStripMenuItem_Click);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// hscrPan
			// 
			this.hscrPan.Location = new System.Drawing.Point(10, 765);
			this.hscrPan.Maximum = 109;
			this.hscrPan.Name = "hscrPan";
			this.hscrPan.Size = new System.Drawing.Size(575, 17);
			this.hscrPan.TabIndex = 2;
			this.hscrPan.Value = 50;
			this.hscrPan.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hscrPan_Scroll);
			// 
			// vscrPan
			// 
			this.vscrPan.Location = new System.Drawing.Point(588, 16);
			this.vscrPan.Maximum = 109;
			this.vscrPan.Name = "vscrPan";
			this.vscrPan.Size = new System.Drawing.Size(17, 742);
			this.vscrPan.TabIndex = 1;
			this.vscrPan.Value = 50;
			this.vscrPan.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vscrPan_Scroll);
			// 
			// picBoxCanvas
			// 
			this.picBoxCanvas.BackColor = System.Drawing.SystemColors.Control;
			this.picBoxCanvas.Location = new System.Drawing.Point(10, 49);
			this.picBoxCanvas.Name = "picBoxCanvas";
			this.picBoxCanvas.Size = new System.Drawing.Size(575, 710);
			this.picBoxCanvas.TabIndex = 0;
			this.picBoxCanvas.TabStop = false;
			this.picBoxCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFractal_Paint);
			// 
			// lblAngle
			// 
			this.lblAngle.AutoSize = true;
			this.lblAngle.Location = new System.Drawing.Point(4, 67);
			this.lblAngle.Name = "lblAngle";
			this.lblAngle.Size = new System.Drawing.Size(87, 13);
			this.lblAngle.TabIndex = 3;
			this.lblAngle.Text = "Branch Angle (°):";
			// 
			// nudAngle
			// 
			this.nudAngle.Location = new System.Drawing.Point(92, 64);
			this.nudAngle.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
			this.nudAngle.Name = "nudAngle";
			this.nudAngle.Size = new System.Drawing.Size(56, 20);
			this.nudAngle.TabIndex = 5;
			this.nudAngle.ValueChanged += new System.EventHandler(this.nudAngle_ValueChanged);
			// 
			// lblRandom
			// 
			this.lblRandom.AutoSize = true;
			this.lblRandom.Location = new System.Drawing.Point(19, 141);
			this.lblRandom.Name = "lblRandom";
			this.lblRandom.Size = new System.Drawing.Size(72, 13);
			this.lblRandom.TabIndex = 7;
			this.lblRandom.Text = "Randomness:";
			// 
			// nudRandom
			// 
			this.nudRandom.Location = new System.Drawing.Point(92, 137);
			this.nudRandom.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.nudRandom.Name = "nudRandom";
			this.nudRandom.Size = new System.Drawing.Size(56, 20);
			this.nudRandom.TabIndex = 8;
			this.nudRandom.ValueChanged += new System.EventHandler(this.nudRandom_ValueChanged);
			// 
			// lblDebug
			// 
			this.lblDebug.AutoSize = true;
			this.lblDebug.Location = new System.Drawing.Point(14, 28);
			this.lblDebug.Name = "lblDebug";
			this.lblDebug.Size = new System.Drawing.Size(31, 13);
			this.lblDebug.TabIndex = 9;
			this.lblDebug.Text = "       .";
			// 
			// nudRecursionDepth
			// 
			this.nudRecursionDepth.Location = new System.Drawing.Point(92, 31);
			this.nudRecursionDepth.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
			this.nudRecursionDepth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudRecursionDepth.Name = "nudRecursionDepth";
			this.nudRecursionDepth.Size = new System.Drawing.Size(56, 20);
			this.nudRecursionDepth.TabIndex = 2;
			this.nudRecursionDepth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudRecursionDepth.ValueChanged += new System.EventHandler(this.nudRecursionDepth_ValueChanged);
			// 
			// lblRecursionDepth
			// 
			this.lblRecursionDepth.AutoSize = true;
			this.lblRecursionDepth.Location = new System.Drawing.Point(1, 34);
			this.lblRecursionDepth.Name = "lblRecursionDepth";
			this.lblRecursionDepth.Size = new System.Drawing.Size(90, 13);
			this.lblRecursionDepth.TabIndex = 1;
			this.lblRecursionDepth.Text = "Recursion Depth:";
			// 
			// cbLeaves
			// 
			this.cbLeaves.AutoSize = true;
			this.cbLeaves.Location = new System.Drawing.Point(37, 25);
			this.cbLeaves.Name = "cbLeaves";
			this.cbLeaves.Size = new System.Drawing.Size(83, 17);
			this.cbLeaves.TabIndex = 10;
			this.cbLeaves.Text = "End Leaves";
			this.cbLeaves.UseVisualStyleBackColor = true;
			this.cbLeaves.CheckedChanged += new System.EventHandler(this.cbLeaves_CheckedChanged);
			// 
			// gbControls
			// 
			this.gbControls.Controls.Add(this.btnClearSettings);
			this.gbControls.Controls.Add(this.gbEndLeaves);
			this.gbControls.Controls.Add(this.btnReset);
			this.gbControls.Controls.Add(this.groupBox1);
			this.gbControls.Controls.Add(this.lblRecursionDepth);
			this.gbControls.Controls.Add(this.nudRecursionDepth);
			this.gbControls.Controls.Add(this.nudRandom);
			this.gbControls.Controls.Add(this.lblAngle);
			this.gbControls.Controls.Add(this.lblRandom);
			this.gbControls.Controls.Add(this.lblLength);
			this.gbControls.Controls.Add(this.nudLength);
			this.gbControls.Controls.Add(this.nudAngle);
			this.gbControls.Location = new System.Drawing.Point(641, 12);
			this.gbControls.Name = "gbControls";
			this.gbControls.Size = new System.Drawing.Size(163, 429);
			this.gbControls.TabIndex = 11;
			this.gbControls.TabStop = false;
			// 
			// gbEndLeaves
			// 
			this.gbEndLeaves.Controls.Add(this.cbLeaves);
			this.gbEndLeaves.Controls.Add(this.btnColor);
			this.gbEndLeaves.Location = new System.Drawing.Point(6, 163);
			this.gbEndLeaves.Name = "gbEndLeaves";
			this.gbEndLeaves.Size = new System.Drawing.Size(148, 97);
			this.gbEndLeaves.TabIndex = 14;
			this.gbEndLeaves.TabStop = false;
			// 
			// btnColor
			// 
			this.btnColor.BackColor = System.Drawing.Color.LightGreen;
			this.btnColor.Location = new System.Drawing.Point(29, 58);
			this.btnColor.Name = "btnColor";
			this.btnColor.Size = new System.Drawing.Size(82, 23);
			this.btnColor.TabIndex = 13;
			this.btnColor.Text = "Color";
			this.btnColor.UseVisualStyleBackColor = false;
			this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(51, 361);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 23);
			this.btnReset.TabIndex = 12;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbRandomThirdBranch);
			this.groupBox1.Controls.Add(this.rbThreeBranches);
			this.groupBox1.Controls.Add(this.rbTwoLeaves);
			this.groupBox1.Location = new System.Drawing.Point(6, 261);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(148, 94);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			// 
			// rbRandomThirdBranch
			// 
			this.rbRandomThirdBranch.AutoSize = true;
			this.rbRandomThirdBranch.Location = new System.Drawing.Point(11, 66);
			this.rbRandomThirdBranch.Name = "rbRandomThirdBranch";
			this.rbRandomThirdBranch.Size = new System.Drawing.Size(129, 17);
			this.rbRandomThirdBranch.TabIndex = 2;
			this.rbRandomThirdBranch.TabStop = true;
			this.rbRandomThirdBranch.Text = "Random Third Branch";
			this.rbRandomThirdBranch.UseVisualStyleBackColor = true;
			this.rbRandomThirdBranch.CheckedChanged += new System.EventHandler(this.rbRandomThirdBranch_CheckedChanged);
			// 
			// rbThreeBranches
			// 
			this.rbThreeBranches.AutoSize = true;
			this.rbThreeBranches.Location = new System.Drawing.Point(10, 42);
			this.rbThreeBranches.Name = "rbThreeBranches";
			this.rbThreeBranches.Size = new System.Drawing.Size(101, 17);
			this.rbThreeBranches.TabIndex = 1;
			this.rbThreeBranches.TabStop = true;
			this.rbThreeBranches.Text = "Three Branches";
			this.rbThreeBranches.UseVisualStyleBackColor = true;
			this.rbThreeBranches.CheckedChanged += new System.EventHandler(this.rbThreeBranches_CheckedChanged);
			// 
			// rbTwoLeaves
			// 
			this.rbTwoLeaves.AutoSize = true;
			this.rbTwoLeaves.Checked = true;
			this.rbTwoLeaves.Location = new System.Drawing.Point(10, 19);
			this.rbTwoLeaves.Name = "rbTwoLeaves";
			this.rbTwoLeaves.Size = new System.Drawing.Size(94, 17);
			this.rbTwoLeaves.TabIndex = 0;
			this.rbTwoLeaves.TabStop = true;
			this.rbTwoLeaves.Text = "Two Branches";
			this.rbTwoLeaves.UseVisualStyleBackColor = true;
			this.rbTwoLeaves.CheckedChanged += new System.EventHandler(this.rbTwoLeaves_CheckedChanged);
			// 
			// lblLength
			// 
			this.lblLength.AutoSize = true;
			this.lblLength.Location = new System.Drawing.Point(11, 102);
			this.lblLength.Name = "lblLength";
			this.lblLength.Size = new System.Drawing.Size(80, 13);
			this.lblLength.TabIndex = 4;
			this.lblLength.Text = "Branch Length:";
			// 
			// nudLength
			// 
			this.nudLength.Location = new System.Drawing.Point(92, 100);
			this.nudLength.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
			this.nudLength.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.nudLength.Name = "nudLength";
			this.nudLength.Size = new System.Drawing.Size(56, 20);
			this.nudLength.TabIndex = 6;
			this.nudLength.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.nudLength.ValueChanged += new System.EventHandler(this.nudLength_ValueChanged);
			// 
			// tbDebug
			// 
			this.tbDebug.Location = new System.Drawing.Point(10, 61);
			this.tbDebug.Multiline = true;
			this.tbDebug.Name = "tbDebug";
			this.tbDebug.ReadOnly = true;
			this.tbDebug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbDebug.Size = new System.Drawing.Size(136, 158);
			this.tbDebug.TabIndex = 12;
			// 
			// gbDebug
			// 
			this.gbDebug.Controls.Add(this.tbDebug);
			this.gbDebug.Controls.Add(this.lblDebug);
			this.gbDebug.Location = new System.Drawing.Point(641, 464);
			this.gbDebug.Name = "gbDebug";
			this.gbDebug.Size = new System.Drawing.Size(160, 234);
			this.gbDebug.TabIndex = 13;
			this.gbDebug.TabStop = false;
			this.gbDebug.Text = "Debug";
			this.gbDebug.Visible = false;
			// 
			// btnClearSettings
			// 
			this.btnClearSettings.Location = new System.Drawing.Point(43, 390);
			this.btnClearSettings.Name = "btnClearSettings";
			this.btnClearSettings.Size = new System.Drawing.Size(88, 23);
			this.btnClearSettings.TabIndex = 15;
			this.btnClearSettings.Text = "Clear Settings";
			this.btnClearSettings.UseVisualStyleBackColor = true;
			this.btnClearSettings.Click += new System.EventHandler(this.btnClearSettings_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
			// 
			// Fractal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(823, 815);
			this.Controls.Add(this.gbDebug);
			this.Controls.Add(this.gbControls);
			this.Controls.Add(this.gbFractal);
			this.Name = "Fractal";
			this.Text = "Fractal Tree";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Fractal_FormClosing);
			this.gbFractal.ResumeLayout(false);
			this.gbFractal.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picBoxCanvas)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudAngle)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudRandom)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudRecursionDepth)).EndInit();
			this.gbControls.ResumeLayout(false);
			this.gbControls.PerformLayout();
			this.gbEndLeaves.ResumeLayout(false);
			this.gbEndLeaves.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
			this.gbDebug.ResumeLayout(false);
			this.gbDebug.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFractal;
        private System.Windows.Forms.PictureBox picBoxCanvas;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.NumericUpDown nudAngle;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.NumericUpDown nudRandom;
        private System.Windows.Forms.Label lblDebug;
        private System.Windows.Forms.NumericUpDown nudRecursionDepth;
        private System.Windows.Forms.Label lblRecursionDepth;
        private System.Windows.Forms.CheckBox cbLeaves;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRandomThirdBranch;
        private System.Windows.Forms.RadioButton rbThreeBranches;
        private System.Windows.Forms.RadioButton rbTwoLeaves;
		private System.Windows.Forms.TextBox tbDebug;
		private System.Windows.Forms.GroupBox gbDebug;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.GroupBox gbEndLeaves;
		private System.Windows.Forms.Button btnColor;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.HScrollBar hscrPan;
		private System.Windows.Forms.VScrollBar vscrPan;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ToolStripMenuItem asXMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem asBitmapToolStripMenuItem;
		private System.Windows.Forms.Button btnClearSettings;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
	}
}

