using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Fractal
{
	public partial class Fractal : Form
	{
		private const double DegreesPerRadian = 180.0 / Math.PI;
		private const double RadiansPerDegree = Math.PI / 180.0;
		private const float XOffset = 15.0f;
		private const float YOffset = 15.0f;
		private const float Length = 150.0f;
		private const float scaledLength = 0.75f;

		private Settings settings;
		private Pen endLeavesPen = new Pen(Color.LightGreen);
		private bool initializing;
		private bool clearSettings = false;
		private bool confirmReset = true;

		private Pen treeTrunkPen;
		private int[] treeTrunkWidths = { 0, 1, 2, 3, 4, 6, 9, 11, 14, 17 };

		private Graphics graphics;
		private float initBranchAngle = 90.0f; // assume tree starts vertical

		private float randomnessRightHandSide;
		private float randomnessLeftHandSide;
		private Random random;
		private Random randomMiddleBranch;

		// transformation and scroll stuff
		private Matrix transformation;
		private float xTranslate, yTranslate;
		private float vertScrollTranslateUnit;
		private float horizScrollTranslateUnit;
		private float scrollMax;

		public Fractal()
		{
			InitializeComponent();

			treeTrunkPen = new Pen(Color.SaddleBrown);
			this.picBoxCanvas.BackColor = Color.FromArgb(200, 255, 255);

			initializing = true;
			btnReset_Click(null, null);
			nudRecursionDepth.Maximum = treeTrunkWidths.Length - 1;
		}

		private void pnlFractal_Paint(object sender, PaintEventArgs e)
		{
			if (transformation == null) return;
			e.Graphics.Transform = transformation;
			Graphics graphics = e.Graphics;
			this.graphics = graphics;
			DrawScene();
		}

		private void DrawScene()
		{
			float y0 = 0.0f;
			float height = this.picBoxCanvas.Height;
			float width = this.picBoxCanvas.Width;

			float xloc0 = width / 2.0f;
			float yloc0 = (y0 + height) - YOffset;

			float xloc1 = xloc0;
			float yloc1 = yloc0 - Length;

			DrawBranch(settings.Depth, xloc0, yloc0, settings.Length, initBranchAngle, scaledLength, settings.Angle);
		}

		/// <summary>
		/// Recursively draws branches of fractal tree. See original Rod Stephens VB at http://www.vb-helper.com/howto_fractal_binary_tree.html
		/// </summary>
		/// <param name="depth">Recursion Depth</param>
		/// <param name="X">X origin of line representing branch</param>
		/// <param name="Y">Y origin of line representing branch</param>
		/// <param name="length">length of line representing branch</param>
		/// <param name="theta">angle of line representing branch</param>
		/// <param name="scaledLength">amount successive branches are scaled by</param>
		/// <param name="deltaTheta">change in angle for successive branches</param>
		private void DrawBranch(int depth, float X, float Y, float length, float theta, float scaledLength, float deltaTheta)
		{
			float x1;
			float y1;

			// calculate end of branch x1, y1
			// sine theta equals opposite over hypotenuse, cosine theta equals adjacent over hypotenuse (length is hypotenuse)
			x1 = X + length * (float)Math.Cos(theta * RadiansPerDegree); // increasing x (left to right)
			y1 = Y - length * (float)Math.Sin(theta * RadiansPerDegree); // decreasing y (down to up)

			treeTrunkPen.Width = treeTrunkWidths[depth];
			graphics.DrawLine(treeTrunkPen, X, Y, x1, y1);

			// if not the top branch, draw the attached branches
			if (depth > 1)
			{
				// recursive call - draw right-hand side  (note +deltaTheta)
				DrawBranch(depth - 1, x1, y1, (length * scaledLength) + randomnessRightHandSide, (theta + deltaTheta) + randomnessRightHandSide, scaledLength, deltaTheta);

				if (settings.RandomThirdBranch)
				{
					int drawMiddleBranch = randomMiddleBranch.Next(0, 2);
					if (drawMiddleBranch == 0)
					{
						// draw middle
						DrawBranch(depth - 1, x1, y1, (length * scaledLength) + randomnessLeftHandSide, theta + randomnessLeftHandSide, scaledLength, deltaTheta);
					}
				}
				else if (settings.ThreeBranches)
				{
					// draw middle
					DrawBranch(depth - 1, x1, y1, (length * scaledLength) + randomnessLeftHandSide, theta + randomnessLeftHandSide, scaledLength, deltaTheta);
				}

				// recursive call - draw left-hand side (note -deltaTheta)
				DrawBranch(depth - 1, x1, y1, (length * scaledLength) + randomnessLeftHandSide, (theta - deltaTheta) + randomnessLeftHandSide, scaledLength, deltaTheta);
			}
			// else top branch
			else if (depth == 1)
			{
				if (settings.EndLeaves)
				{
					// end leaves are just a circle for now (bitmap might be a nice addition)
					graphics.DrawArc(endLeavesPen, x1 - 2, y1 - 2, 6, 6, 0, 360);
					graphics.DrawArc(endLeavesPen, x1 - 2, y1 - 2, 4, 4, 0, 360);
				}
			}
		}

		#region UI
		private void nudRecursionDepth_ValueChanged(object sender, EventArgs e)
		{
			settings.Depth = Convert.ToInt32(nudRecursionDepth.Value);
			this.picBoxCanvas.Invalidate();
		}

		private void nudAngle_ValueChanged(object sender, EventArgs e)
		{
			settings.Angle = Convert.ToInt32(nudAngle.Value);
			this.picBoxCanvas.Invalidate();
		}

		private void nudLength_ValueChanged(object sender, EventArgs e)
		{
			settings.Length = Convert.ToInt32(nudLength.Value);
			this.picBoxCanvas.Invalidate();
		}

		private void nudRandom_ValueChanged(object sender, EventArgs e)
		{
			settings.Randomness = Convert.ToInt32(nudRandom.Value);
			randomnessRightHandSide = random.Next(-settings.Randomness / 2, settings.Randomness / 2);
			randomnessLeftHandSide = random.Next(-settings.Randomness / 2, settings.Randomness / 2);
			this.picBoxCanvas.Invalidate();
		}

		private void cbLeaves_CheckedChanged(object sender, EventArgs e)
		{
			if (!initializing)
			{
				settings.EndLeaves = !settings.EndLeaves;
				this.btnColor.Enabled = settings.EndLeaves;
				this.picBoxCanvas.Invalidate();
			}
		}

		private void rbTwoLeaves_CheckedChanged(object sender, EventArgs e)
		{
			RadioButtons();
		}

		private void rbThreeBranches_CheckedChanged(object sender, EventArgs e)
		{
			RadioButtons();
		}

		private void rbRandomThirdBranch_CheckedChanged(object sender, EventArgs e)
		{
			RadioButtons();
		}

		private void RadioButtons()
		{
			if (initializing)
			{
				return;
			}

			if (rbTwoLeaves.Checked == true)
			{
				settings.ThreeBranches = false;
				settings.RandomThirdBranch = false;
			}
			else if (rbThreeBranches.Checked == true)
			{
				settings.ThreeBranches = true;
				settings.RandomThirdBranch = false;
			}
			else if (rbRandomThirdBranch.Checked == true)
			{
				settings.ThreeBranches = false;
				settings.RandomThirdBranch = true;
			}

			this.picBoxCanvas.Invalidate();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = DialogResult.Yes;
			if (!initializing && confirmReset)
			{
				dialogResult = MessageBox.Show("Do you really want to Reset?", "Confirm Reset", MessageBoxButtons.YesNo);
			}

			if (dialogResult == DialogResult.Yes)
			{
				random = new Random(42);
				randomMiddleBranch = new Random(42);
				RetrieveSettings();

				xTranslate = 0.0f;
				yTranslate = 0.0f;
				scrollMax = vscrPan.Maximum - 9; // assume horizontal and vertical scroll max are the same (see also http://csharphelper.com/blog/2013/10/let-the-user-select-a-scroll-bars-largest-value-in-c/ )
				vscrPan.Value = ((int)scrollMax) / 2;
				hscrPan.Value = ((int)scrollMax) / 2;
				vertScrollTranslateUnit = picBoxCanvas.Height / scrollMax;
				horizScrollTranslateUnit = picBoxCanvas.Width / scrollMax;
				SetTransformationMatrix();								

				this.picBoxCanvas.Invalidate();
			}
		}

		/// <summary>
		/// Clears the settings in  %userprofile%\appdata\local to default values (also calls btnReset_Click to init variables)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnClearSettings_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Do you really want to Clear Settings?", "Confirm Clear", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				Properties.Settings.Default.Reset();
				clearSettings = true;
				confirmReset = false;
				btnReset_Click(null, null);
				confirmReset = true;

				this.picBoxCanvas.Invalidate();
			}
		}

		private void btnColor_Click(object sender, EventArgs e)
		{
			this.colorDialog1.ShowDialog();
			settings.EndLeavesColor = this.colorDialog1.Color;
			endLeavesPen.Color = settings.EndLeavesColor;
			btnColor.BackColor = settings.EndLeavesColor;
			this.picBoxCanvas.Invalidate();
		}
		#endregion

		#region utility
		private void SetUIControls()
		{
			this.nudRecursionDepth.Value = settings.Depth;
			this.nudAngle.Value = (decimal)settings.Angle;
			this.nudLength.Value = (decimal)settings.Length;
			this.nudRandom.Value = settings.Randomness;
			this.cbLeaves.Checked = settings.EndLeaves;
			this.rbThreeBranches.Checked = settings.ThreeBranches;
			this.rbRandomThirdBranch.Checked = settings.RandomThirdBranch;
			this.btnColor.BackColor = settings.EndLeavesColor;
			this.btnColor.Enabled = settings.EndLeaves;
			if ((settings.ThreeBranches) || (settings.RandomThirdBranch))
			{
				this.rbTwoLeaves.Checked = false;
			}
			else
			{
				this.rbTwoLeaves.Checked = true;
			}

			endLeavesPen = new Pen(settings.EndLeavesColor);
		}
		#endregion

		#region transformation
		private void SetTransformationMatrix()
		{
			transformation = new Matrix();
			transformation.Translate(xTranslate, yTranslate, MatrixOrder.Append);
		}

		private void hscrPan_Scroll(object sender, ScrollEventArgs e)
		{
			if (e.NewValue == e.OldValue) return; // this callback gets called twice immediately on a click

			int val = e.NewValue;

			// diff > 0 if moving scroll bar to right
			int diff = (val - e.OldValue);
			xTranslate -= (horizScrollTranslateUnit * (float)diff);
			SetTransformationMatrix();
			picBoxCanvas.Invalidate();
		}

		private void vscrPan_Scroll(object sender, ScrollEventArgs e)
		{
			if (e.NewValue == e.OldValue) return; // this callback gets called twice immediately on a click

			int val = e.NewValue;

			// diff > 0 if moving scroll bar down
			int diff = (val - e.OldValue);
			yTranslate -= (vertScrollTranslateUnit * (float)diff);
			SetTransformationMatrix();
			picBoxCanvas.Invalidate();
		}
		#endregion

		#region toolStrip
		private void SaveAsXMLToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveFileDialog1.Filter = "XML files (*.xml)|*.xml";
			saveFileDialog1.DefaultExt = "xml";
			saveFileDialog1.Title = "Save as XML file";
			saveFileDialog1.ShowDialog();

			string filename = saveFileDialog1.FileName;
			if (!String.IsNullOrEmpty(filename))
			{
				FileManager fileManager = new FileManager();
				fileManager.SaveFileAsXML(filename, settings);
			}
		}

		private void SaveAsBitmapToolStripMenuItem_Click(object sender, EventArgs e)
		{
			saveFileDialog1.Filter = "Image Files(*.bmp;*.jpg;*.gif;*.png)|*.bmp;*.jpg;*.gif;*.png";
			saveFileDialog1.DefaultExt = "jpg";
			saveFileDialog1.Title = "Save as image file";
			saveFileDialog1.ShowDialog();

			string filename = saveFileDialog1.FileName;
			if (!String.IsNullOrEmpty(filename))
			{
				FileManager fileManager = new FileManager();
				fileManager.SaveFileAsBitmap(this.picBoxCanvas, filename);
			}
		}

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.openFileDialog1.Filter = "XML files (*.xml)|*.xml";
			openFileDialog1.DefaultExt = "xml";
			this.openFileDialog1.ShowDialog();
			string filename = this.openFileDialog1.FileName;
			if (!String.IsNullOrEmpty(filename))
			{
				FileManager fileManager = new FileManager();
				Settings newSettings = new Settings(0, 0, 0, 0, false, Color.AliceBlue, false, false);
				try
				{
					fileManager.OpenFileAsXML(filename, ref newSettings);
				}
				catch(Exception ex)
				{
					MessageBox.Show(String.Format("Error opening file {0} {1}", filename, ex.Message), "Error");
					return;
				}
				settings = newSettings;

				SetUIControls();
				this.picBoxCanvas.Invalidate();
			}
		}

		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			HelpDialog help = new HelpDialog();
			help.Show();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
			Environment.Exit(0);
		}
		#endregion

		#region SaveAndRestore
		/// <summary>
		/// Retrieve from %userprofile%\appdata\local  user.config
		/// </summary>
		private void RetrieveSettings()
		{
			// todo if they are invalid values, use good defaults

			initializing = true;
			settings = new Settings(
				Properties.Settings.Default.Depth,
				Properties.Settings.Default.Angle,
				Properties.Settings.Default.Length,
				Properties.Settings.Default.Randomness,
				Properties.Settings.Default.EndLeaves,
				Properties.Settings.Default.EndLeavesColor,
				Properties.Settings.Default.ThreeBranches,
				Properties.Settings.Default.RandomThirdBranch
			);

			SetUIControls();
			initializing = false;
		}

		private void Fractal_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveSettings();
		}

		/// <summary>
		/// Called from FormClosing
		/// </summary>
		private void SaveSettings()
		{
			if (!clearSettings)
			{
				Properties.Settings.Default.Depth = settings.Depth;
				Properties.Settings.Default.Angle = settings.Angle;
				Properties.Settings.Default.Randomness = settings.Randomness;
				Properties.Settings.Default.Length = settings.Length;
				Properties.Settings.Default.EndLeaves = settings.EndLeaves;
				Properties.Settings.Default.EndLeavesColor = settings.EndLeavesColor;
				Properties.Settings.Default.ThreeBranches = settings.ThreeBranches;
				Properties.Settings.Default.RandomThirdBranch = settings.RandomThirdBranch;

				Properties.Settings.Default.Save();
			}
		}
		#endregion
	}
}
