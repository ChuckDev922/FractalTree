using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Fractal
{
	class Settings
	{
		/// <summary>
		/// recursion depth
		/// </summary>
		public int Depth { get; set; }

		/// <summary>
		/// branch angle, degrees
		/// </summary>
		public int Angle { get; set; }
		public int Length { get; set; }
		public int Randomness { get; set; }
		public bool EndLeaves { get; set; }
		public Color EndLeavesColor { get; set; }
		public bool ThreeBranches { get; set; }
		public bool RandomThirdBranch { get; set; }


		public Settings(int Depth, int Angle, int Length, int Randomness, bool EndLeaves, Color EndLeavesColor, bool ThreeBranches, bool RandomThirdBranch)
		{
			this.Depth = Depth;
			this.Angle = Angle;
			this.Length = Length;
			this.Randomness = Randomness;
			this.EndLeaves = EndLeaves;
			this.EndLeavesColor = EndLeavesColor;
			this.ThreeBranches = ThreeBranches;
			this.RandomThirdBranch = RandomThirdBranch;
		}
	}
}
