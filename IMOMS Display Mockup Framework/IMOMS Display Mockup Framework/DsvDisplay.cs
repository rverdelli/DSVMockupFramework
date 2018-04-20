using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Configuration;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace IMOMS_Display_Mockup_Framework
{
    class IMOMSGlobalCongigs
    {
        //Configurable parameters here
        public static Size ComponentSize = new Size(int.Parse(ConfigurationManager.AppSettings["CompHeight"]), int.Parse(ConfigurationManager.AppSettings["CompWidth"]));
        public static Size DisplaySize = new Size(int.Parse(ConfigurationManager.AppSettings["DispHeight"]), int.Parse(ConfigurationManager.AppSettings["DispHeight"]));

    }
    class DsvDisplay
    {
        //Configurable parameters here
        public static Size ComponentSize = new Size(int.Parse(ConfigurationManager.AppSettings["CompHeight"]), int.Parse(ConfigurationManager.AppSettings["CompWidth"]));
        public static Size DisplaySize = new Size(int.Parse(ConfigurationManager.AppSettings["DispWidth"]), int.Parse(ConfigurationManager.AppSettings["DispHeight"]));

        //Methods here:
        [Obsolete("this Method should be avoided, Quality Impact Warning ")]
        public static Bitmap resizeToComponentSize(Bitmap source) => new Bitmap(source, IMOMSGlobalCongigs.ComponentSize);

        public static void createDisplayFromConfiguration(string filename)
        {
            //Read configuration and prepare the arguments for createDisplay
            string path = ConfigurationManager.AppSettings["CompFolder"];
            String Config = File.ReadAllText(filename);
            List<string> lines = new List<string>(Config.Split(new[] { Environment.NewLine },StringSplitOptions.None));
            lines.RemoveAt(1);
            for (int i = 1; i < lines.Count; i++)
            {
                lines[i] = path + "\\" + lines[i] + ".png";
            }
            //call createDisplay with componentsPath\fullname.png and displayName
            createDisplay(lines.GetRange(1, lines.Count-1), lines.ElementAt(0));
        }

        [Description("Create the displays Images from a list on n components")]
        public static int createDisplay(List<string> components, string displayName)
        {
            Queue<Bitmap> compCallReady = new Queue<Bitmap>();

            int slideNumber = 1;
            string fileName;
            Bitmap Display;
            //Render images in groups of 6 components 
            while (components.Count > 6)
            {
                List<string> compDisplay = components.GetRange(0, 6);
                components.RemoveRange(0, 6);
                for (int i = 0; i < compDisplay.Count; i++)
                {
                    //for #Size #Quality issue please double check this
                    try
                    {
                        compCallReady.Enqueue(new Bitmap(Image.FromFile(compDisplay.ElementAt(i)), ComponentSize));
                    }
                    catch (System.IO.FileNotFoundException ex)
                    {
                        MessageBox.Show("File: " + compDisplay.ElementAt(i) + " was not found", "Error :(");
                    }
                    
                }
                
                Display = setComponents(compCallReady);
                fileName = ConfigurationManager.AppSettings["DisplayResult"] + "\\" + displayName + "\\" + displayName + slideNumber.ToString() + ".png";

                Directory.CreateDirectory(ConfigurationManager.AppSettings["DisplayResult"] + "\\" + displayName);
                Display.Save(fileName); //maybe MISSING FORMAT 

                slideNumber++;
                compCallReady.Clear();//reset
            }
            //Remaining component in quantity < 6
            for (int i = 0; i < components.Count; i++)
            {
                try
                {
                    compCallReady.Enqueue(new Bitmap(Image.FromFile(components.ElementAt(i)), ComponentSize));
                }
                catch
                {
                    MessageBox.Show("File: " + components.ElementAt(i) + "was not found", "Error :(");
                }
            }
            Display = setComponents(compCallReady);
            fileName = ConfigurationManager.AppSettings["DisplayResult"] + "\\" + displayName + "\\" + displayName + slideNumber.ToString() + ".png";

            Directory.CreateDirectory(ConfigurationManager.AppSettings["DisplayResult"] + "\\" + displayName);
            Display.Save(fileName); //maybe MISSING FORMAT 

            slideNumber++;
            compCallReady.Clear();//reset
            return 1;
        }

        //Set this to private once the setComponents(List<String>) will be available
        public static Bitmap setComponents(Queue<Bitmap> Components)
        {
            Bitmap BackgroundIMOMS = new Bitmap(ConfigurationManager.AppSettings["BackgorundImage"]);            
            Bitmap ResultImage = new Bitmap(DisplaySize.Width, DisplaySize.Height);//Size from config (DispHeight, DispWindth)

            int[] cols = new int[3];
            cols[0] = int.Parse(ConfigurationManager.AppSettings["Col1"]);
            cols[1] = int.Parse(ConfigurationManager.AppSettings["Col2"]);
            cols[2] = int.Parse(ConfigurationManager.AppSettings["Col3"]);

            int[] rows = new int[2];
            rows[0] = int.Parse(ConfigurationManager.AppSettings["Row1"]);
            rows[1] = int.Parse(ConfigurationManager.AppSettings["Row2"]);

            using (Graphics gr = Graphics.FromImage(ResultImage))
            {
                gr.DrawImage((Image)BackgroundIMOMS, 0,0, DisplaySize.Width, DisplaySize.Height);
                for (int r = 0; r < rows.Length && (Components.Count > 0); r++)
                {
                    for (int c = 0; c < cols.Length && (Components.Count > 0); c++)
                    {
                        if (Components.Count > 0)
                        {
                            gr.DrawImage((Image)Components.Dequeue(), cols[c], rows[r], int.Parse(ConfigurationManager.AppSettings["CompWidth"]), int.Parse(ConfigurationManager.AppSettings["CompHeight"]));
                        }
                    }
                }
               // gr.DrawImage(, new Point(50, 50));
            }
            ResultImage.Save("dentro metodo.png");
            return ResultImage;
        }
    }
}


/*
 * public void Resize(int newWidth, int newHeight)
{
    	if (newWidth != 0 && newHeight != 0)
             {
                 Bitmap temp = (Bitmap)_currentBitmap;
             Bitmap bmap = new Bitmap(newWidth, newHeight, temp.PixelFormat);

                    double nWidthFactor = (double)temp.Width / (double)newWidth;
                    double nHeightFactor = (double)temp.Height / (double)newHeight;

                    double fx, fy, nx, ny;
                    int cx, cy, fr_x, fr_y;
                    Color color1 = new Color();
                    Color color2 = new Color();
                    Color color3 = new Color();
                    Color color4 = new Color();
                    byte nRed, nGreen, nBlue;

                    byte bp1, bp2;

                    for (int x = 0; x < bmap.Width; ++x)
                    {
                          for (int y = 0; y < bmap.Height; ++y)
                        {

                                fr_x = (int)Math.Floor(x * nWidthFactor);
                                fr_y = (int)Math.Floor(y * nHeightFactor);
                                cx = fr_x + 1;
                                if (cx >= temp.Width) cx = fr_x;
                                cy = fr_y + 1;
                                if (cy >= temp.Height) cy = fr_y;
                                fx = x * nWidthFactor - fr_x;
                                fy = y * nHeightFactor - fr_y;
                                nx = 1.0 - fx;
                                ny = 1.0 - fy;

                                color1 = temp.GetPixel(fr_x, fr_y);
                                color2 = temp.GetPixel(cx, fr_y);
                                color3 = temp.GetPixel(fr_x, cy);
                                color4 = temp.GetPixel(cx, cy);

                                // Blue
                                bp1 = (byte)(nx * color1.B + fx * color2.B);

                                bp2 = (byte)(nx * color3.B + fx * color4.B);

                                nBlue = (byte)(ny * (double)(bp1) + fy * (double)(bp2));

                                // Green
                                bp1 = (byte)(nx * color1.G + fx * color2.G);

                                bp2 = (byte)(nx * color3.G + fx * color4.G);

                                nGreen = (byte)(ny * (double)(bp1) + fy * (double)(bp2));

                                // Red
                                bp1 = (byte)(nx * color1.R + fx * color2.R);

                                bp2 = (byte)(nx * color3.R + fx * color4.R);

                                nRed = (byte)(ny * (double)(bp1) + fy * (double)(bp2));

                                bmap.SetPixel(x, y, System.Drawing.Color.FromArgb
						(255, nRed, nGreen, nBlue));
                        }
                }
                _currentBitmap = (Bitmap)bmap.Clone();
       }
}

    METODO 2
    public static Bitmap ResizeImage(Image image, int width, int height)
{
    var destRect = new Rectangle(0, 0, width, height);
    var destImage = new Bitmap(width, height);

    destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

    using (var graphics = Graphics.FromImage(destImage))
    {
        graphics.CompositingMode = CompositingMode.SourceCopy;
        graphics.CompositingQuality = CompositingQuality.HighQuality;
        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
        graphics.SmoothingMode = SmoothingMode.HighQuality;
        graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

        using (var wrapMode = new ImageAttributes())
        {
            wrapMode.SetWrapMode(WrapMode.TileFlipXY);
            graphics.DrawImage(image, destRect, 0, 0, image.Width,image.Height, GraphicsUnit.Pixel, wrapMode);
        }
    }

    return destImage;
}


    METODO EASY

    public static Image resizeImage(Image imgToResize, Size size)
    {
       return (Image)(new Bitmap(imgToResize, size));
    }

    yourImage = resizeImage(yourImage, new Size(50,50));
 */
