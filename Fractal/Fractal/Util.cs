using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Fractal
{
	public class Util
	{
		public static Color ParseColor(String colorString)
		{
			ColorConverter colorConverter = new ColorConverter();

			// case 1: "Color [A=255, R=0, G=255, B=64]"
			// case 2: "Color [Red]"
			if (colorString.Contains("Color"))
			{
				bool case1 = false;
				for(int i = 0; i < colorString.Length; i++)
				{
					if (char.IsDigit(colorString[i]))
					{
						case1 = true;
						break;
					}
				}

				// if case 1, e.g., "Color [A=255, R=0, G=255, B=64]"
				if (case1)
				{
					int pos = colorString.IndexOf("[");
					String inner2 = colorString.Substring(pos + 1);
					String[] rgbs = inner2.Split(new Char[] { ' ' });

					int pos2 = rgbs[1].IndexOf("=");
					int pos3 = rgbs[1].IndexOf(",");
					String red = rgbs[1].Substring(pos2 + 1, pos3 - pos2 - 1);
					int iRed = Int32.Parse(red);

					pos2 = rgbs[2].IndexOf("=");
					pos3 = rgbs[2].IndexOf(",");
					String green = rgbs[2].Substring(pos2 + 1, pos3 - pos2 - 1);
					int iGreen = Int32.Parse(green);

					pos2 = rgbs[3].IndexOf("=");
					pos3 = rgbs[3].IndexOf("]");
					String blue = rgbs[3].Substring(pos2 + 1, pos3 - pos2 - 1);
					int iBlue = Int32.Parse(blue);

					Color col = Color.FromArgb(iRed, iGreen, iBlue);
					return col;
				}
				// else case2, e.g., "Color [Red]"
				else
				{
					int pos2 = colorString.IndexOf("[");
					int pos3 = colorString.IndexOf("]");
					String colorString2 = colorString.Substring(pos2 + 1, pos3 - pos2 - 1);
					Color col;
					try
					{
						col = (Color)colorConverter.ConvertFromString(colorString2);
					}
					catch (Exception ex)
					{
						throw new Exception(String.Format("Error: {0} is not recognized as a color ({1})", colorString, ex.Message));
					}
					return col;
				}
			}
			else
			{
				ColorConverter.StandardValuesCollection svc = (ColorConverter.StandardValuesCollection)colorConverter.GetStandardValues();
				foreach (Color color in svc)
				{
					if (color.Name.Equals(colorString, StringComparison.OrdinalIgnoreCase))
					{
						Color col = (Color)colorConverter.ConvertFromString(colorString);
						return col;
					}
				}
				throw new Exception(String.Format("Error: {0} is not recognized as a color", colorString));
			}
		}
	}
}
