using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;

namespace IMOMS_Display_Mockup_Framework
{
    public partial class DashboardConfig : Form
    {
        private List<string> availableDisplays;
        private BindingList<SelectedDisplay> selectedDisplays = new BindingList<SelectedDisplay>();

        public DashboardConfig()
        {
            InitializeComponent();
            initializeComboBox();
            initializeGridView();
        }

        public DashboardConfig(string configFileFullPath)
        {
            if (!File.Exists(configFileFullPath))
            {
                MessageBox.Show("The selected config file does not exist", "ERROR");
                return;
            }

            InitializeComponent();
            checkDisplayFolderExistence();

            StreamReader sr = new StreamReader(configFileFullPath);

            string dashboardUniqueIdentifier = sr.ReadLine();
            dashboardUniqueIdentifierTextBox.Text = dashboardUniqueIdentifier;

            sr.ReadLine();

            for(int i = 1; !sr.EndOfStream; i++)
            {
                string line = sr.ReadLine();
                selectedDisplays.Add(new SelectedDisplay(i, line));
            }
            sr.Close();

            initializeComboBox();
            initializeGridView();
        }

        private void checkDisplayFolderExistence()
        {
            if (!Directory.Exists(Config.displayFolder))
            {
                MessageBox.Show("Displays folder not found, please make sure your displays images are in the folder " + Config.displayFolder, "ERROR");
                Environment.Exit(-1);
            }
        }

        private void initializeComboBox()
        {
            availableDisplays = Directory.GetDirectories(Config.displayFolder).ToList();
            
            for (int i = 0; i < availableDisplays.Count; i++)
                availableDisplays[i] = Path.GetFileNameWithoutExtension(availableDisplays[i]);

            List<string> displaysNotAvailable = new List<string>();
            for(int i = 0; i < selectedDisplays.Count;)
            {
                bool displayAvailable = false;
                for(int j = 0; j < availableDisplays.Count;j++)
                {
                    if (selectedDisplays[i].DisplayId.Equals(availableDisplays[j]))
                    {
                        displayAvailable = true;
                        availableDisplays.RemoveAt(j);
                        break;
                    }
                }

                if (!displayAvailable)
                {
                    displaysNotAvailable.Add(selectedDisplays[i].DisplayId);
                    selectedDisplays.RemoveAt(i);
                }
                else
                    i++;

            }

            updateAvailableDisplaysComboBox();

            if (displaysNotAvailable.Count > 0)
                MessageBox.Show("The following Displays were not found in the Displays image folder and they were removed from the display:\n\n - " + displaysNotAvailable.Aggregate((i, j) => i + "\n - " + j) + "\n\nSaving this new configuration will exclude these Displays from the display, these operation is not revertable.");
        }

        private void initializeGridView()
        {
            selectedDisplaysGridView.AutoGenerateColumns = false;
            selectedDisplaysGridView.DataSource = selectedDisplays;

            selectedDisplaysGridView.Columns[Config.OrderIdColumnIndex].DataPropertyName = "OrderID";
            selectedDisplaysGridView.Columns[Config.DisplayIdColumnIndex].DataPropertyName = "DisplayId";
            selectedDisplaysGridView.Columns[Config.MoveUpColumnIndex].DataPropertyName = "MoveUp";
            selectedDisplaysGridView.Columns[Config.MoveDownColumnIndex].DataPropertyName = "MoveDown";
            selectedDisplaysGridView.Columns[Config.RemoveColumnIndex].DataPropertyName = "Remove";
        }

        private void addDisplaysCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDisplayId = addDisplaysCB.Text;

            //Clear combo box selecte value and refresh selectable componenents list
            addDisplaysCB.Text = "";
            addDisplaysCB.Items.Clear();
            availableDisplays = availableDisplays.Where(x => !x.Equals(selectedDisplayId)).ToList();
            addDisplaysCB.Items.AddRange(availableDisplays.ToArray());

            SelectedDisplay sc = new SelectedDisplay(selectedDisplays.Count+1, selectedDisplayId);
            selectedDisplays.Add(sc);

            selectedDisplaysGridView.Update();
        }

        private void selectedDisplaysGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case Config.MoveUpColumnIndex:
                    MoveRowUp(e.RowIndex);
                    break;

                case Config.MoveDownColumnIndex:
                    MoveRowDown(e.RowIndex);
                    break;

                case Config.RemoveColumnIndex:
                    RemoveRow(e.RowIndex);
                    break;

                default:
                    break;

            }
        }

        private void MoveRowUp(int rowIndex)
        {
            if (rowIndex == 0)
                return;

            string aux = selectedDisplays[rowIndex].DisplayId;
            selectedDisplays[rowIndex].DisplayId = selectedDisplays[rowIndex - 1].DisplayId;
            selectedDisplays[rowIndex - 1].DisplayId = aux;

            selectedDisplaysGridView.Update();
            selectedDisplaysGridView.Refresh();

            return;
        }

        private void MoveRowDown(int rowIndex)
        {
            if (rowIndex == selectedDisplays.Count - 1)
                return;

            string aux = selectedDisplays[rowIndex].DisplayId;
            selectedDisplays[rowIndex].DisplayId = selectedDisplays[rowIndex + 1].DisplayId;
            selectedDisplays[rowIndex + 1].DisplayId = aux;

            selectedDisplaysGridView.Update();
            selectedDisplaysGridView.Refresh();

            return;
        }

        private void RemoveRow(int rowIndex)
        {
            availableDisplays.Add(selectedDisplays[rowIndex].DisplayId);
            availableDisplays.OrderBy(x => x.ToString());
            updateAvailableDisplaysComboBox();

            selectedDisplays.RemoveAt(rowIndex);
            for (int i = 0; i < selectedDisplays.Count; i++)
                selectedDisplays[i].OrderID = i+1;

            selectedDisplaysGridView.Update();
            selectedDisplaysGridView.Refresh();

            return;
        }

        private void updateAvailableDisplaysComboBox()
        {
            addDisplaysCB.Items.Clear();
            addDisplaysCB.Items.AddRange(availableDisplays.ToArray());
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string dashboardUniqueIdentifier = dashboardUniqueIdentifierTextBox.Text;
            if (dashboardUniqueIdentifier == "")
                MessageBox.Show("Dashboard unique identifier cannot be blank", "ERROR");

            if (selectedDisplays.Count == 0)
                MessageBox.Show("No Displays selected, please select at least one display", "ERROR");

            string dashboardConfigFilesFolder = ConfigurationManager.AppSettings["DashboardConfigFilesFolder"]; ;
            string configFileFullPath = dashboardConfigFilesFolder + "\\" + dashboardUniqueIdentifier + ".csv";

            if (!Directory.Exists(dashboardConfigFilesFolder))
                Directory.CreateDirectory(dashboardConfigFilesFolder);

            if (File.Exists(configFileFullPath))
            {
                DialogResult dr = MessageBox.Show("Dashboard unique identifier already exists, the file will be overwritten", "Prompt", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.Cancel)
                    return;
            }

            File.Create(configFileFullPath).Close();
            StreamWriter sw = new StreamWriter(configFileFullPath);

            sw.WriteLine(dashboardUniqueIdentifier);
            sw.WriteLine();

            for (int i = 0; i < selectedDisplays.Count; i++)
            {
                if(i == selectedDisplays.Count - 1)
                    sw.Write(selectedDisplays[i].DisplayId);
                else
                    sw.WriteLine(selectedDisplays[i].DisplayId);
            }

            sw.Close();
            this.Close();

            //DsvDisplay.createDisplayFromConfiguration(configFileFullPath);
            Process.Start("explorer.exe", ConfigurationManager.AppSettings["DashboardFolder"]);

            DsvDashboard.generateDashboard(configFileFullPath);
            //Bitmap b = new Bitmap("C:\\DsvMockupFramework\\Display\\Il display di simo\\Il display di simo1.png");
            //DsvDashboard.applyRibbon(b,  "dashboard ribbon");
        }

        private void dashboardUniqueIdentifierTextBox_TextChanged(object sender, EventArgs e)
        {
            string dashboardName = dashboardUniqueIdentifierTextBox.Text;

            List<string> ribbonFiles = Directory.GetFiles(Config.ribbonFolder, "*.png")
                                                .Select(x => Path.GetFileName(x))
                                                .ToList();

            //Checking if file exists
            ribbonFiles = ribbonFiles.Where(x => Path.GetFileNameWithoutExtension(x).Equals(dashboardName, StringComparison.CurrentCultureIgnoreCase)).ToList();

            if (ribbonFiles.Count == 1)
            {
                ribbonFileTextBox.Text = ribbonFiles[0];
                saveButton.Enabled = true;
            }
            else
            {
                ribbonFileTextBox.Text = "<Not found>";
                saveButton.Enabled = false;
            }
        }
    }
}
