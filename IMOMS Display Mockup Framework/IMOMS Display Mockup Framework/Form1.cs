using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMOMS_Display_Mockup_Framework
{
    public partial class Form1 : Form
    {
        List<string> availableDisplays = new List<string>();
        private string displayConfigFolder = ConfigurationManager.AppSettings["DisplayConfigFilesFolder"];

        public Form1()
        {
            InitializeComponent();

            refreshDisplaysList();
        }

        public void refreshDisplaysList()
        {
            availableDisplays = Directory.GetFiles(displayConfigFolder).ToList();

            for (int i = 0; i < availableDisplays.Count; i++)
                availableDisplays[i] = Path.GetFileNameWithoutExtension(availableDisplays[i]);

            loadDisplayComboBox.Items.Clear();
            loadDisplayComboBox.Items.AddRange(availableDisplays.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new ImagePreview();
            f2.Show();
        }

        private void newDisplay_Click(object sender, EventArgs e)
        {
            new DisplayConfig().Show();
        }

        private void loadDisplayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            new DisplayConfig(displayConfigFolder + "\\" + loadDisplayComboBox.Text + ".csv").Show();
        }

        private void refreshDisplayListButton_Click(object sender, EventArgs e)
        {
            refreshDisplaysList();
        }

        private void regenerateDisplaysButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("This will regenerate all displays images based on displays' config files, proceed?", "PROMPT", MessageBoxButtons.OKCancel);

            if (dr == DialogResult.Cancel)
                return;

            refreshDisplaysList();
            foreach(string displayConfigFile in availableDisplays)
                DsvDisplay.createDisplayFromConfiguration(displayConfigFolder + "\\" + displayConfigFile + ".csv.");

            Process.Start("explorer.exe", ConfigurationManager.AppSettings["DisplayResult"]);
        }
    }
}
