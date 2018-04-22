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
using System.Threading;

namespace IMOMS_Display_Mockup_Framework
{
    class LocalConfig
    {
        public static string getDashboardConfig => ConfigurationManager.AppSettings["DashboardConfigFilesFolder"];
        public static string getDashboardFolder => ConfigurationManager.AppSettings["DashboardFolder"];
        public static string getDisplayFolder => ConfigurationManager.AppSettings["DisplayFolder"];

        public static Size RibbonSize = new Size(int.Parse(ConfigurationManager.AppSettings["RibbonWidth"]), int.Parse(ConfigurationManager.AppSettings["RibbonHeight"]));
    }
    class DsvDashboard
    {
        
        private static List<string> readConfig(string fileName)
        {
            String config="";
            try
            {
                config = File.ReadAllText(fileName);
            }
            catch (Exception e)
            {
                MessageBox.Show("impossible read: " + fileName + " due to " + e.Message + "DsvDashboard class", "Error :( ");
            }
            
            //string path = ConfigurationManager.AppSettings["CompFolder"];
            List<string> lines = new List<string>(config.Split(new[] { Environment.NewLine }, StringSplitOptions.None));
            //remove the title and the blank space from the read
            lines.RemoveRange(0, 2);
            return lines;
        }

        public static void CopyFolderContents(string sourceFolder, string destinationFolder)
        {
            if (Directory.Exists(sourceFolder))
            {
                //int ctr = 1;
                foreach (string sourceFile in Directory.GetFiles(sourceFolder, "*", SearchOption.AllDirectories))
                {
                    string destinationFile = sourceFile.Replace(sourceFolder, destinationFolder);
                    File.Copy(sourceFile, destinationFile, true);//if need #Rename file here
                }
            }
        }

        public static void generateDashboard(string filePath, string dashName)
        {
            //read config file
            List<string> DisplayList = readConfig(filePath);
            List<string> DisplayListPath = DisplayList;
            //add the full path
            for (int i = 0; i < DisplayListPath.Count; i++)
            {
                DisplayListPath[i] = LocalConfig.getDisplayFolder + DisplayListPath[i];
            }            

            //Create DisplayFolder related to the current dashboard
            string dashboardPath = LocalConfig.getDashboardFolder + "\\" + dashName;
            Directory.CreateDirectory(dashboardPath);

            string displayPath = LocalConfig.getDisplayFolder;
            //for each display
            int ctr = 0;
            foreach (string disp in DisplayList)
            {
                string fName = displayPath + "\\" + disp + ".png";//nome display


                        //apro immagine display
                        Bitmap img = new Bitmap(fName);
                        //aggiungo ribbon
                        img = applyRibbon(img, dashName); //applico ribbon
                        //salvo nella cartella della dashboard
                        ctr++;
                        string dashbName = dashboardPath + "\\" + ctr + " " + fName.Substring(fName.LastIndexOf('\\')+1);
                        img.Save(dashbName);
                    
                
            }
            //applyRibbon
            //int ctr = 1;
            foreach (string file in Directory.GetFiles(dashboardPath, "*", SearchOption.AllDirectories))
            {
                Bitmap img = new Bitmap(file);
                //applica ribbon
                img = applyRibbon(img, dashName);

                //File.Delete(file);
                string fName = file.Replace(".png", "-new.png");
                //if (File.Exists(fName))
                    //File.Delete(fName);
                img.Save(fName);//#rename here
            }


        }

        public static Bitmap applyRibbon(Bitmap img, string nomeDashboard)
        {
            //get the Ribbon Path
            string ribbonPath = ConfigurationManager.AppSettings["RibbonFolder"] + "\\" + nomeDashboard + ".png";
            Image ribbon= (Image)new Bitmap(10,10);
            //Load the ribbon image
            try
            {
                ribbon = Image.FromFile(ribbonPath);
            }
            catch
            {
                MessageBox.Show("oops someting went wrong loading the ribbon ");
            }

            using (Graphics gr = Graphics.FromImage(img))
            {
                //gr.DrawImage((Image)BackgroundIMOMS, 0, 0, DisplaySize.Width, DisplaySize.Height);
                gr.SmoothingMode = SmoothingMode.HighQuality;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                gr.DrawImage((Image)ribbon, 0, 0, LocalConfig.RibbonSize.Width, LocalConfig.RibbonSize.Height);//CHANGE HERE
            }
           
            return img;
        }
    }
}
