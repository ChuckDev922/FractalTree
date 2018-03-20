using System;
using System.Collections.Generic;
using System.Text;

namespace Fractal
{
	class HelpDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox tbHelp;

		public HelpDialog()
		{
			this.Width = 510;
			this.Height = 650;
			this.Text = "Help";
			this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
			this.MaximumSize = new System.Drawing.Size(this.Width, this.Height);

			tbHelp = new System.Windows.Forms.TextBox();
			tbHelp.Multiline = true;
			tbHelp.ReadOnly = true;
			tbHelp.WordWrap = true;
			tbHelp.Width = this.Width - 15;
			tbHelp.Height = this.Height - 470;
			tbHelp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			tbHelp.Text =
				" Create realistic fractal trees by recursively drawing branches." + Environment.NewLine +
				" Use Recursion Depth for the number of recursion levels," + Environment.NewLine +
				" Branch Angle for the number of degrees between the branches," + Environment.NewLine +
				" Branch Length for the length of the inital branch," + Environment.NewLine +
				" Randomness for the degree of randomness in drawing branches," + Environment.NewLine +
				" End Leaves and Color to specify if there are leaves at the end of the branches," + Environment.NewLine +
				" Two Branches, Three Branches or Random Third Branch for the number of branches at each level." + Environment.NewLine +
				" You can save the settings (Depth, Length, etc) as an XML file and then open it again later." + Environment.NewLine +
				" You can save the image as a bmp, jpg, gif or png file." + Environment.NewLine +
				" Your settings are saved automatically if you don't specify an XML file, and restored when you" + Environment.NewLine +
				@"  start the program. (The settings are stored in %userprofile%\appdata\local)" + Environment.NewLine +
				@" Reset retrieves the last settings from %userprofile%\appdata\local," + Environment.NewLine +
				@" Clear Settings sets the fractal tree to the default settings and clears the settings in" + Environment.NewLine +
				@" %userprofile%\appdata\local."
			;
			tbHelp.Select(0, 0);

			System.Windows.Forms.PictureBox pbExample = new System.Windows.Forms.PictureBox();
			pbExample.Size = new System.Drawing.Size(418, 425);
			pbExample.Image = global::Fractal.Properties.Resources.FractalTreeScreenShot;

			pbExample.Location = new System.Drawing.Point(25, tbHelp.Height);
			pbExample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;

			this.Controls.Add(tbHelp);
			this.Controls.Add(pbExample);
		}
	}
}
