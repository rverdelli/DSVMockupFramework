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
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace IMOMS_Display_Mockup_Framework
{
    class DsvDisplay
    {

        //Configurable parameters here
        public static Size ComponentSize = new Size(int.Parse(ConfigurationManager.AppSettings["CompHeight"]), int.Parse(ConfigurationManager.AppSettings["CompWidth"]));
        public static Size DisplaySize = new Size(int.Parse(ConfigurationManager.AppSettings["DispWidth"]), int.Parse(ConfigurationManager.AppSettings["DispHeight"]));


        //Methods here:
        [Obsolete("this Method should be avoided, Quality Impact Warning ")]
        public static Bitmap resizeToComponentSize(Bitmap source) => new Bitmap(source, ComponentSize);

        public static void createDisplayFromConfiguration(string filename)
        {
            //Read configuration and prepare the arguments for createDisplay
            String Configuration = File.ReadAllText(filename);
            List<string> componentsFullPaths = new List<string>(Configuration.Split(new[] { Environment.NewLine },StringSplitOptions.None));
            componentsFullPaths.RemoveAt(1);
            for (int i = 1; i < componentsFullPaths.Count; i++)
            {
                componentsFullPaths[i] = Config.compFolder + "\\" + componentsFullPaths[i] + ".png";
            }
            //call createDisplay with componentsPath\fullname.png and displayName
            createDisplay(componentsFullPaths.GetRange(1, componentsFullPaths.Count-1), componentsFullPaths.ElementAt(0));
        }

        [Description("Create the displays Images from a list on n components")]
        private static int createDisplay(List<string> components, string displayName)
        {
            Queue<string> compCallReady = new Queue<string>();

            //split the display in more images if the components are more than 6
            int slideNumber = 1;
            int SlideMaxNumber = (components.Count()-1) / 6 + 1;
            string fileName;
            Bitmap Display;
            string dirName= Config.displayFolder + "\\" + displayName;

            //Best practice approach to avoid directoryNotFoundException 
            Directory.CreateDirectory(dirName);
            Directory.Delete(dirName, true);
            Directory.CreateDirectory(dirName);

            //Render images FOR GROUPS > 6 ONLY
            while (components.Count > 6)
            {
                List<string> compDisplay = components.GetRange(0, 6);
                components.RemoveRange(0, 6);
                for (int i = 0; i < compDisplay.Count; i++)
                {
                    //for #Size #Quality issue please double check this
                    try
                    {
                        compCallReady.Enqueue(compDisplay.ElementAt(i));
                    }
                    catch (System.IO.FileNotFoundException ex)
                    {
                        MessageBox.Show("File: " + compDisplay.ElementAt(i) + " was not found", "Error :(");
                    }
                    
                }
                
                Display = setComponents(compCallReady, slideNumber, SlideMaxNumber);
                fileName = Config.displayFolder + "\\" + displayName + "\\" + displayName + slideNumber.ToString() + ".png";

                Directory.CreateDirectory(dirName);
                Display.Save(fileName); //maybe MISSING FORMAT 

                slideNumber++;
                compCallReady.Clear();//reset
            }

            //Remaining component in quantity < 6 ONLY
            for (int i = 0; i < components.Count; i++)
            {
                try
                {
                    compCallReady.Enqueue(components.ElementAt(i));
                }
                catch
                {
                    MessageBox.Show("File: " + components.ElementAt(i) + "was not found", "Error :(");
                }
            }
            Display = setComponents(compCallReady, slideNumber, SlideMaxNumber);
            fileName = Config.displayFolder + "\\" + displayName + "\\" + displayName + slideNumber.ToString() + ".png";

            Directory.CreateDirectory(dirName);
            Display.Save(fileName); //maybe MISSING FORMAT 
            //Display.Dispose();

            slideNumber++;
            compCallReady.Clear();//reset
            return 1;
        }

       
        private static Bitmap setComponents(Queue<string> Components)
        {
            Bitmap ResultImage = new Bitmap(DisplaySize.Width, DisplaySize.Height);
            using (Bitmap BackgroundIMOMS = new Bitmap(ConfigurationManager.AppSettings["BackgorundImage"]))
            {

                int[] cols = new int[3];//From config File to array 
                cols[0] = int.Parse(ConfigurationManager.AppSettings["Col1"]);
                cols[1] = int.Parse(ConfigurationManager.AppSettings["Col2"]);
                cols[2] = int.Parse(ConfigurationManager.AppSettings["Col3"]);

                int[] rows = new int[2];//From config File to array 
                rows[0] = int.Parse(ConfigurationManager.AppSettings["Row1"]);
                rows[1] = int.Parse(ConfigurationManager.AppSettings["Row2"]);

                using (Graphics gr = Graphics.FromImage(ResultImage))
                {
                    //#scale #quality
                    gr.SmoothingMode = SmoothingMode.HighQuality;
                    gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    gr.DrawImage((Image)BackgroundIMOMS, 0, 0, DisplaySize.Width, DisplaySize.Height);
                    for (int r = 0; r < rows.Length && (Components.Count > 0); r++)
                    {
                        for (int c = 0; c < cols.Length && (Components.Count > 0); c++)
                        {
                            if (Components.Count > 0)
                            {
                                //#scale #quality
                                using (Image component = Image.FromFile(Components.Dequeue()))
                                    gr.DrawImage(component, cols[c], rows[r], int.Parse(ConfigurationManager.AppSettings["CompWidth"]), int.Parse(ConfigurationManager.AppSettings["CompHeight"]));
                            }
                        }
                    }
                }

            }
            //ResultImage.Dispose();
            return ResultImage;
        }

        private static Bitmap setComponents(Queue<string> Components, int pagNum, int pagMax)
        {
            Bitmap ResultImage = new Bitmap(DisplaySize.Width, DisplaySize.Height);

            if (pagMax == 2)
            {
                #region PagMax=2 Code
                using (Bitmap BackgroundIMOMS1 = new Bitmap(ConfigurationManager.AppSettings["BackgorundFolderScroll2Pag"] + "\\IMOMS1.png"))
                using (Bitmap BackgroundIMOMS2 = new Bitmap(ConfigurationManager.AppSettings["BackgorundFolderScroll2Pag"] + "\\IMOMS2.png"))
                {
                    int[] cols = new int[3];//From config File to array 
                    cols[0] = int.Parse(ConfigurationManager.AppSettings["Col1"]);
                    cols[1] = int.Parse(ConfigurationManager.AppSettings["Col2"]);
                    cols[2] = int.Parse(ConfigurationManager.AppSettings["Col3"]);

                    int[] rows = new int[2];//From config File to array 
                    rows[0] = int.Parse(ConfigurationManager.AppSettings["Row1"]);
                    rows[1] = int.Parse(ConfigurationManager.AppSettings["Row2"]);

                    using (Graphics gr = Graphics.FromImage(ResultImage))
                    {
                        //#scale #quality
                        gr.SmoothingMode = SmoothingMode.HighQuality;
                        gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        gr.PixelOffsetMode = PixelOffsetMode.HighQuality;

                        if (pagNum == 1)
                            gr.DrawImage((Image)BackgroundIMOMS1, 0, 0, DisplaySize.Width, DisplaySize.Height);
                        else
                            gr.DrawImage((Image)BackgroundIMOMS2, 0, 0, DisplaySize.Width, DisplaySize.Height);

                        for (int r = 0; r < rows.Length && (Components.Count > 0); r++)
                        {
                            for (int c = 0; c < cols.Length && (Components.Count > 0); c++)
                            {
                                if (Components.Count > 0)
                                {
                                    //#scale #quality
                                    using (Image component = Image.FromFile(Components.Dequeue()))
                                        gr.DrawImage(component, cols[c], rows[r], int.Parse(ConfigurationManager.AppSettings["CompWidth"]), int.Parse(ConfigurationManager.AppSettings["CompHeight"]));
                                }
                            }
                        }
                    }
                }
                #endregion
            }
            else if (pagMax == 3)
            {
                #region pagMax=3 Code
                using (Bitmap BackgroundIMOMS1 = new Bitmap(ConfigurationManager.AppSettings["BackgorundFolderScroll3Pag"] + "\\IMOMS1.png"))
                using (Bitmap BackgroundIMOMS2 = new Bitmap(ConfigurationManager.AppSettings["BackgorundFolderScroll3Pag"] + "\\IMOMS2.png"))
                using (Bitmap BackgroundIMOMS3 = new Bitmap(ConfigurationManager.AppSettings["BackgorundFolderScroll3Pag"] + "\\IMOMS3.png"))
                {
                    int[] cols = new int[3];//From config File to array 
                    cols[0] = int.Parse(ConfigurationManager.AppSettings["Col1"]);
                    cols[1] = int.Parse(ConfigurationManager.AppSettings["Col2"]);
                    cols[2] = int.Parse(ConfigurationManager.AppSettings["Col3"]);

                    int[] rows = new int[2];//From config File to array 
                    rows[0] = int.Parse(ConfigurationManager.AppSettings["Row1"]);
                    rows[1] = int.Parse(ConfigurationManager.AppSettings["Row2"]);

                    using (Graphics gr = Graphics.FromImage(ResultImage))
                    {
                        //#scale #quality
                        gr.SmoothingMode = SmoothingMode.HighQuality;
                        gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        gr.PixelOffsetMode = PixelOffsetMode.HighQuality;

                        if (pagNum == 1)
                            gr.DrawImage((Image)BackgroundIMOMS1, 0, 0, DisplaySize.Width, DisplaySize.Height);
                        else if (pagNum == 2 )
                            gr.DrawImage((Image)BackgroundIMOMS2, 0, 0, DisplaySize.Width, DisplaySize.Height);
                        else
                            gr.DrawImage((Image)BackgroundIMOMS3, 0, 0, DisplaySize.Width, DisplaySize.Height);

                        for (int r = 0; r < rows.Length && (Components.Count > 0); r++)
                        {
                            for (int c = 0; c < cols.Length && (Components.Count > 0); c++)
                            {
                                if (Components.Count > 0)
                                {
                                    //#scale #quality
                                    using (Image component = Image.FromFile(Components.Dequeue()))
                                        gr.DrawImage(component, cols[c], rows[r], int.Parse(ConfigurationManager.AppSettings["CompWidth"]), int.Parse(ConfigurationManager.AppSettings["CompHeight"]));
                                }
                            }
                        }
                    }
                }
                #endregion
            }
            else
            {
                using (Bitmap BackgroundIMOMS = new Bitmap(ConfigurationManager.AppSettings["BackgorundImage"]))
                {

                    int[] cols = new int[3];//From config File to array 
                    cols[0] = int.Parse(ConfigurationManager.AppSettings["Col1"]);
                    cols[1] = int.Parse(ConfigurationManager.AppSettings["Col2"]);
                    cols[2] = int.Parse(ConfigurationManager.AppSettings["Col3"]);

                    int[] rows = new int[2];//From config File to array 
                    rows[0] = int.Parse(ConfigurationManager.AppSettings["Row1"]);
                    rows[1] = int.Parse(ConfigurationManager.AppSettings["Row2"]);

                    using (Graphics gr = Graphics.FromImage(ResultImage))
                    {
                        //#scale #quality
                        gr.SmoothingMode = SmoothingMode.HighQuality;
                        gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                        gr.DrawImage((Image)BackgroundIMOMS, 0, 0, DisplaySize.Width, DisplaySize.Height);
                        for (int r = 0; r < rows.Length && (Components.Count > 0); r++)
                        {
                            for (int c = 0; c < cols.Length && (Components.Count > 0); c++)
                            {
                                if (Components.Count > 0)
                                {
                                    //#scale #quality
                                    using (Image component = Image.FromFile(Components.Dequeue()))
                                        gr.DrawImage(component, cols[c], rows[r], int.Parse(ConfigurationManager.AppSettings["CompWidth"]), int.Parse(ConfigurationManager.AppSettings["CompHeight"]));
                                }
                            }
                        }
                    }

                }
            }
            //ResultImage.Dispose();
            return ResultImage;
        }
    }
}