using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace Fractal
{
	class FileManager
	{
		#region sampleXMLfile
		/*
		 sample xml file
<?xml version="1.0" encoding="utf-8"?>
<configuration>
    <userSettings>
        <Fractal.Properties.Settings>
            <setting name="Depth" serializeAs="String">
                <value>6</value>
            </setting>
            <setting name="Angle" serializeAs="String">
                <value>19</value>
            </setting>
            <setting name="Length" serializeAs="String">
                <value>160</value>
            </setting>
            <setting name="Randomness" serializeAs="String">
                <value>19</value>
            </setting>
            <setting name="EndLeaves" serializeAs="String">
                <value>True</value>
            </setting>
            <setting name="EndLeavesColor" serializeAs="String">
                <value>Color [Red]</value>
            </setting>
            <setting name="ThreeBranches" serializeAs="String">
                <value>False</value>
            </setting>
            <setting name="RandomThirdBranch" serializeAs="String">
                <value>True</value>
            </setting>
        </Fractal.Properties.Settings>
    </userSettings>
</configuration>
*/
		#endregion

		public void SaveFileAsXML(String filename, Settings settings)
		{
			XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
			xmlWriterSettings.Indent = true;
			xmlWriterSettings.NewLineOnAttributes = true;

			XmlWriter xmlWriter = XmlWriter.Create(filename, xmlWriterSettings);
			xmlWriter.WriteStartDocument();
			xmlWriter.WriteStartElement("configuration"); // config
			{
				xmlWriter.WriteStartElement("userSettings"); // user
				{
					xmlWriter.WriteStartElement("Fractal.Properties.Settings"); // fractal
					{
						xmlWriter.WriteStartElement("setting");
						{
							xmlWriter.WriteAttributeString("name", "Depth");
							xmlWriter.WriteAttributeString("serializeAs", "String");
							xmlWriter.WriteStartElement("value");
							xmlWriter.WriteString(settings.Depth.ToString());
							xmlWriter.WriteEndElement();
						}
						xmlWriter.WriteEndElement();

						xmlWriter.WriteStartElement("setting");
						{
							xmlWriter.WriteAttributeString("name", "Angle");
							xmlWriter.WriteAttributeString("serializeAs", "String");
							xmlWriter.WriteStartElement("value");
							xmlWriter.WriteString(settings.Angle.ToString());
							xmlWriter.WriteEndElement();
						}
						xmlWriter.WriteEndElement();

						xmlWriter.WriteStartElement("setting");
						{
							xmlWriter.WriteAttributeString("name", "Length");
							xmlWriter.WriteAttributeString("serializeAs", "String");
							xmlWriter.WriteStartElement("value");
							xmlWriter.WriteString(settings.Length.ToString());
							xmlWriter.WriteEndElement();
						}
						xmlWriter.WriteEndElement();

						xmlWriter.WriteStartElement("setting");
						{
							xmlWriter.WriteAttributeString("name", "Randomness");
							xmlWriter.WriteAttributeString("serializeAs", "String");
							xmlWriter.WriteStartElement("value");
							xmlWriter.WriteString(settings.Randomness.ToString());
							xmlWriter.WriteEndElement();
						}
						xmlWriter.WriteEndElement();

						xmlWriter.WriteStartElement("setting");
						{
							xmlWriter.WriteAttributeString("name", "EndLeaves");
							xmlWriter.WriteAttributeString("serializeAs", "String");
							xmlWriter.WriteStartElement("value");
							xmlWriter.WriteString(settings.EndLeaves.ToString());
							xmlWriter.WriteEndElement();
						}
						xmlWriter.WriteEndElement();

						xmlWriter.WriteStartElement("setting");
						{
							xmlWriter.WriteAttributeString("name", "EndLeavesColor");
							xmlWriter.WriteAttributeString("serializeAs", "String");
							xmlWriter.WriteStartElement("value");
							xmlWriter.WriteString(settings.EndLeavesColor.ToString());
							xmlWriter.WriteEndElement();
						}
						xmlWriter.WriteEndElement();

						xmlWriter.WriteStartElement("setting");
						{
							xmlWriter.WriteAttributeString("name", "ThreeBranches");
							xmlWriter.WriteAttributeString("serializeAs", "String");
							xmlWriter.WriteStartElement("value");
							xmlWriter.WriteString(settings.ThreeBranches.ToString());
							xmlWriter.WriteEndElement();
						}
						xmlWriter.WriteEndElement();

						xmlWriter.WriteStartElement("setting");
						{
							xmlWriter.WriteAttributeString("name", "RandomThirdBranch");
							xmlWriter.WriteAttributeString("serializeAs", "String");
							xmlWriter.WriteStartElement("value");
							xmlWriter.WriteString(settings.RandomThirdBranch.ToString());
							xmlWriter.WriteEndElement();
						}
						xmlWriter.WriteEndElement();
					}
					xmlWriter.WriteEndElement(); // fractal
				}
				xmlWriter.WriteEndElement(); // user
			}
			xmlWriter.WriteEndElement(); // config

			xmlWriter.WriteEndDocument();
			xmlWriter.Close();
		}

		public void OpenFileAsXML(String filename, ref Settings settings)
		{
			XmlReader xmlReader = XmlReader.Create(filename);
			String settingName = "EMPTY";

			while (xmlReader.Read())
			{
				if (xmlReader.NodeType == XmlNodeType.Element)
				{
					switch (xmlReader.Name)
					{
						case "setting":
							if (xmlReader.HasAttributes)
							{
								for (int i = 0; i < xmlReader.AttributeCount; i++)
								{
									xmlReader.MoveToAttribute(i);
									if (xmlReader.Name.Equals("name"))
									{
										settingName = xmlReader.Value;
									}
								}
							}
							break;

						case "value":
							string innerXml = xmlReader.ReadInnerXml();

							try
							{
								switch (settingName)
								{
									case "Depth":
										settings.Depth = Int32.Parse(innerXml);
										break;
									case "Angle":
										settings.Angle = Int32.Parse(innerXml);
										break;
									case "Length":
										settings.Length = Int32.Parse(innerXml);
										break;
									case "Randomness":
										settings.Randomness = Int32.Parse(innerXml);
										break;
									case "EndLeaves":
										settings.EndLeaves = Boolean.Parse(innerXml);
										break;
									case "EndLeavesColor":
										try
										{
											settings.EndLeavesColor = Util.ParseColor(innerXml);
										}
										catch(Exception ex)
										{
											throw new Exception(String.Format("Error getting color: {0} {1}", innerXml, ex.Message));
										}
										break;
									case "ThreeBranches":
										settings.ThreeBranches = Boolean.Parse(innerXml);
										break;
									case "RandomThirdBranch":
										settings.RandomThirdBranch = Boolean.Parse(innerXml);
										break;
									default:
										throw new Exception(String.Format("Error: Unknown setting {0}", settingName));
								}
							}
							catch (Exception ex)
							{
								throw new Exception(String.Format("Error reading innerXML: {0} {1}", innerXml, ex.Message));
							}
							break;

						default:
							break;
					}
				}
			}
		}

		public void SaveFileAsBitmap(System.Windows.Forms.PictureBox picBoxCanvas, String filename)
		{
			using (var bitmap = new Bitmap(picBoxCanvas.Width, picBoxCanvas.Height))
			{
				picBoxCanvas.DrawToBitmap(bitmap, picBoxCanvas.ClientRectangle);
				ImageFormat imageFormat = null;

				var extension = Path.GetExtension(filename);
				switch (extension)
				{
					case ".bmp":
						imageFormat = ImageFormat.Bmp;
						break;
					case ".png":
						imageFormat = ImageFormat.Png;
						break;
					case ".jpeg":
					case ".jpg":
						imageFormat = ImageFormat.Jpeg;
						break;
					case ".gif":
						imageFormat = ImageFormat.Gif;
						break;
					default:
						throw new NotSupportedException(String.Format("File extension {0} is not supported", extension));
				}

				bitmap.Save(filename, imageFormat);
			}
		}
	}
}
