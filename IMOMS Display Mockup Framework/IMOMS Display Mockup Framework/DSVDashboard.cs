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
        public static Size RibbonSize = new Size(int.Parse(ConfigurationManager.AppSettings["RibbonWidth"]), int.Parse(ConfigurationManager.AppSettings["RibbonHeight"]));
    }
    class DsvDashboard
    {
        
        private static List<string> readConfig(string fileName)
        {
            String configuration="";
            try
            {
                configuration = File.ReadAllText(fileName);
            }
            catch (Exception e)
            {
                MessageBox.Show("impossible read: " + fileName + " due to " + e.Message + "DsvDashboard class", "Error :( ");
            }
            
            List<string> lines = new List<string>(configuration.Split(new[] { Environment.NewLine }, StringSplitOptions.None));
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
                DisplayListPath[i] = Config.displayFolder + "\\" + DisplayListPath[i];
            }            

            //Create DisplayFolder related to the current dashboard
            string dashboardPath = Config.dashboardFolder + "\\" + dashName;
            //Best practice approach to avoid directoryNotFoundException 
            Directory.CreateDirectory(dashboardPath);
            Directory.Delete(dashboardPath, true);
            Directory.CreateDirectory(dashboardPath);
            
            //for each display
            int ctr = 0;
            foreach (string disp in DisplayList)
            {
                string fName = Config.displayFolder + "\\" + disp + ".png";//nome display
   
                foreach (string sourceFile in Directory.GetFiles(disp, "*", SearchOption.AllDirectories))
                {
                    try
                    {
                        //apro immagine display
                        Bitmap img = new Bitmap(sourceFile);
                        //aggiungo ribbon
                        img = applyRibbon(img, dashName); //applico ribbon
                        //salvo nella cartella della dashboard
                        ctr++;
                        string dashbName = dashboardPath + "\\" + ctr + " " + sourceFile.Substring(sourceFile.LastIndexOf('\\') + 1);
                        img.Save(dashbName);
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show("Error applying the ribbon for dashboard " + dashName + ", file path " + filePath + ": " + e.Message);
                    }
                }
            }
        }

        public static Bitmap applyRibbon(Bitmap img, string nomeDashboard)
        {
            //get the Ribbon Path
            string ribbonPath = Config.ribbonFolder + "\\" + nomeDashboard + ".png";
            
            //Load the ribbon image
            Image ribbon = Image.FromFile(ribbonPath);

            using (Graphics gr = Graphics.FromImage(img))
            {
                gr.SmoothingMode = SmoothingMode.HighQuality;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                gr.DrawImage(ribbon, 0, 0, LocalConfig.RibbonSize.Width, LocalConfig.RibbonSize.Height);//CHANGE HERE
            }

            return img;
        }
    }
}
