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
    public partial class imomsDisplayMockupFramework : Form
    {
        List<string> availableDisplays = new List<string>();
        List<string> availableDashboards = new List<string>();
        private string compFolder = ConfigurationManager.AppSettings["CompFolder"];
        private string displayFolder = ConfigurationManager.AppSettings["DisplayFolder"];
        private string dashboardFolder = ConfigurationManager.AppSettings["DashboardFolder"];
        private string displayConfigFolder = ConfigurationManager.AppSettings["DisplayConfigFilesFolder"];
        private string dashboardConfigFolder = ConfigurationManager.AppSettings["DashboardConfigFilesFolder"];

        public imomsDisplayMockupFramework()
        {
            InitializeComponent();

            refreshDisplaysList();
            refreshDashboardsList();
        }

        public void refreshDisplaysList()
        {
            availableDisplays = Directory.GetFiles(displayConfigFolder).ToList();

            for (int i = 0; i < availableDisplays.Count; i++)
                availableDisplays[i] = Path.GetFileNameWithoutExtension(availableDisplays[i]);

            loadDisplayComboBox.Items.Clear();
            loadDisplayComboBox.Items.AddRange(availableDisplays.ToArray());
            loadDisplayComboBox.Text = "";
        }
        public void refreshDashboardsList()
        {
            availableDashboards = Directory.GetFiles(dashboardConfigFolder).ToList();

            for (int i = 0; i < availableDashboards.Count; i++)
                availableDashboards[i] = Path.GetFileNameWithoutExtension(availableDashboards[i]);

            loadDashboardComboBox.Items.Clear();
            loadDashboardComboBox.Items.AddRange(availableDashboards.ToArray());
            loadDashboardComboBox.Text = "";
        }

        private string folderPicker(string startingFolder)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = startingFolder;
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    return fbd.SelectedPath;

                return "";
            }
        }

        private void newDisplay_Click(object sender, EventArgs e)
        {
            new DisplayConfig().Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new ImagePreview();
            f2.Show();
        }

        private void loadDisplayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            new DisplayConfig(displayConfigFolder + "\\" + loadDisplayComboBox.Text + ".csv").Show();
        }

        private void loadDashboardComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            new DashboardConfig(dashboardConfigFolder + "\\" + loadDashboardComboBox.Text + ".csv").Show();
        }

        private void refreshDisplayListButton_Click(object sender, EventArgs e)
        {
            refreshDisplaysList();
        }

        private void refreshDashboardListButton_Click(object sender, EventArgs e)
        {
            refreshDashboardsList();
        }

        private void regenerateDisplaysAndDashboardsButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("This will regenerate all displays images based on displays' config files, proceed?", "PROMPT", MessageBoxButtons.OKCancel);

            if (dr == DialogResult.Cancel)
                return;

            refreshDisplaysList();
            foreach(string displayConfigFile in availableDisplays)
                DsvDisplay.createDisplayFromConfiguration(displayConfigFolder + "\\" + displayConfigFile + ".csv.");

            Process.Start("explorer.exe", ConfigurationManager.AppSettings["DisplayFolder"]);
        }

        private void createDashboardButton_Click(object sender, EventArgs e)
        {
            new DashboardConfig().Show();
        }

        private void openDashboardsFolderButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", dashboardFolder);
        }

        private void openDisplaysFolderButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", displayFolder); 
        }

        private void openComponentsFolderButton_Click_1(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", compFolder);
        }

        private void openDisplayConfigFilesFolderButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", displayConfigFolder);
        }

        private void openDashboardConfigFilesFolderButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", dashboardConfigFolder);
        }

        private void componentsFolderEditPathButton_Click(object sender, EventArgs e)
        {
            string newFolder = folderPicker(compFolder);

            if (string.IsNullOrWhiteSpace(newFolder))
                return;

            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["CompFolder"].Value = newFolder;
            config.Save(ConfigurationSaveMode.Modified);
            compFolder = newFolder;
        }

        private void displaysFolderEditPathButton_Click(object sender, EventArgs e)
        {
            string newFolder = folderPicker(displayFolder);

            if (string.IsNullOrWhiteSpace(newFolder))
                return;

            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["DisplayFolder"].Value = newFolder;
            config.Save(ConfigurationSaveMode.Modified);
            displayFolder = newFolder;
        }

        private void dashboardsFolderEditPathButton_Click(object sender, EventArgs e)
        {
            string newFolder = folderPicker(dashboardFolder);

            if (string.IsNullOrWhiteSpace(newFolder))
                return;

            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["DashboardFolder"].Value = newFolder;
            config.Save(ConfigurationSaveMode.Modified);
            dashboardFolder = newFolder;
        }

        private void displayConfigFolderEditPathButton_Click(object sender, EventArgs e)
        {
            string newFolder = folderPicker(displayConfigFolder);

            if (string.IsNullOrWhiteSpace(newFolder))
                return;

            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["DisplayConfigFilesFolder"].Value = newFolder;
            config.Save(ConfigurationSaveMode.Modified);
            displayConfigFolder = newFolder;
        }

        private void dashboardsConfigFolderEditPathButton_Click(object sender, EventArgs e)
        {
            string newFolder = folderPicker(dashboardConfigFolder);

            if (string.IsNullOrWhiteSpace(newFolder))
                return;

            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["DashboardConfigFilesFolder"].Value = newFolder;
            config.Save(ConfigurationSaveMode.Modified);
            dashboardConfigFolder = newFolder;
        }
    }
}
