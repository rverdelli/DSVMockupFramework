using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace IMOMS_Display_Mockup_Framework
{
    public partial class DisplayConfig : Form
    {
        private List<string> availableComponents;
        private BindingList<SelectedComponent> selectedComponents = new BindingList<SelectedComponent>();

        public DisplayConfig()
        {
            InitializeComponent();
            initializeComboBox();
            initializeGridView();

        }

        public DisplayConfig(string configFileFullPath)
        {
            if (!File.Exists(configFileFullPath))
            {
                MessageBox.Show("The selected config file does not exist", "ERROR");
                return;
            }

            InitializeComponent();
            checkCompFolderExistence();

            StreamReader sr = new StreamReader(configFileFullPath);

            string displayUniqueIdentifier = sr.ReadLine();
            displayUniqueIdentifierTextBox.Text = displayUniqueIdentifier;

            sr.ReadLine();

            for(int i = 1; !sr.EndOfStream; i++)
            {
                string line = sr.ReadLine();
                selectedComponents.Add(new SelectedComponent(i, line));
            }
            sr.Close();

            initializeComboBox();
            initializeGridView();
        }

        private void checkCompFolderExistence()
        {
            if (!Directory.Exists(Config.compFolder))
            {
                MessageBox.Show("Components folder not found, please create the folder " + Config.compFolder + " and put components images in it.", "ERROR");
                Environment.Exit(-1);
            }
        }

        private void initializeComboBox()
        {
            availableComponents = Directory.GetFiles(Config.compFolder, "*.png").ToList();

            for (int i = 0; i < availableComponents.Count; i++)
                availableComponents[i] = Path.GetFileNameWithoutExtension(availableComponents[i]);

            List<string> componentsNotAvailable = new List<string>();
            for(int i = 0; i < selectedComponents.Count;)
            {
                bool imageAvailable = false;
                for(int j = 0; j < availableComponents.Count;j++)
                {
                    if (selectedComponents[i].ComponentId.Equals(availableComponents[j]))
                    {
                        imageAvailable = true;
                        availableComponents.RemoveAt(j);
                        break;
                    }
                }

                if (!imageAvailable)
                {
                    componentsNotAvailable.Add(selectedComponents[i].ComponentId);
                    selectedComponents.RemoveAt(i);
                }
                else
                    i++;

            }

            updateAvailableComponentsComboBox();

            if (componentsNotAvailable.Count > 0)
                MessageBox.Show("The following components were not found in the components image folder and they were removed from the display:\n\n - " + componentsNotAvailable.Aggregate((i, j) => i + "\n - " + j) + "\n\nSaving this new configuration will exclude these components from the display, these operation is not revertable.");
        }

        private void initializeGridView()
        {
            selectedComponentsGridView.AutoGenerateColumns = false;
            selectedComponentsGridView.DataSource = selectedComponents;

            selectedComponentsGridView.Columns[Config.OrderIdColumnIndex].DataPropertyName = "OrderID";
            selectedComponentsGridView.Columns[Config.ComponentIdColumnIndex].DataPropertyName = "ComponentId";
            selectedComponentsGridView.Columns[Config.MoveUpColumnIndex].DataPropertyName = "MoveUp";
            selectedComponentsGridView.Columns[Config.MoveDownColumnIndex].DataPropertyName = "MoveDown";
            selectedComponentsGridView.Columns[Config.RemoveColumnIndex].DataPropertyName = "Remove";
        }

        private void addComponentsCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedComponentId = addComponentsCB.Text;

            //Clear combo box selecte value and refresh selectable componenents list
            addComponentsCB.Text = "";
            addComponentsCB.Items.Clear();
            availableComponents = availableComponents.Where(x => !x.Equals(selectedComponentId)).ToList();
            addComponentsCB.Items.AddRange(availableComponents.ToArray());

            SelectedComponent sc = new SelectedComponent(selectedComponents.Count+1, selectedComponentId);
            selectedComponents.Add(sc);

            selectedComponentsGridView.Update();
        }

        private void selectedComponentsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
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

            string aux = selectedComponents[rowIndex].ComponentId;
            selectedComponents[rowIndex].ComponentId = selectedComponents[rowIndex - 1].ComponentId;
            selectedComponents[rowIndex - 1].ComponentId = aux;

            selectedComponentsGridView.Update();
            selectedComponentsGridView.Refresh();

            return;
        }

        private void MoveRowDown(int rowIndex)
        {
            if (rowIndex == selectedComponents.Count - 1)
                return;

            string aux = selectedComponents[rowIndex].ComponentId;
            selectedComponents[rowIndex].ComponentId = selectedComponents[rowIndex + 1].ComponentId;
            selectedComponents[rowIndex + 1].ComponentId = aux;

            selectedComponentsGridView.Update();
            selectedComponentsGridView.Refresh();

            return;
        }

        private void RemoveRow(int rowIndex)
        {
            availableComponents.Add(selectedComponents[rowIndex].ComponentId);
            availableComponents.OrderBy(x => x.ToString());
            updateAvailableComponentsComboBox();

            selectedComponents.RemoveAt(rowIndex);
            for (int i = 0; i < selectedComponents.Count; i++)
                selectedComponents[i].OrderID = i+1;

            selectedComponentsGridView.Update();
            selectedComponentsGridView.Refresh();

            return;
        }

        private void updateAvailableComponentsComboBox()
        {
            addComponentsCB.Items.Clear();
            addComponentsCB.Items.AddRange(availableComponents.ToArray());
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string displayUniqueIdentifier = displayUniqueIdentifierTextBox.Text;
            if (displayUniqueIdentifier == "")
                MessageBox.Show("Display unique identifier cannot be blank", "ERROR");

            if (selectedComponents.Count == 0)
                MessageBox.Show("No components selected, please select at least one component", "ERROR");

            string displayConfigFilesFolder = ConfigurationManager.AppSettings["DisplayConfigFilesFolder"]; ;
            string configFileFullPath = displayConfigFilesFolder + "\\" + displayUniqueIdentifier + ".csv";

            if (!Directory.Exists(displayConfigFilesFolder))
                Directory.CreateDirectory(displayConfigFilesFolder);

            if (File.Exists(configFileFullPath))
            {
                DialogResult dr = MessageBox.Show("Display unique identifier already exists, the file will be overwritten", "Prompt", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.Cancel)
                    return;
            }

            File.Create(configFileFullPath).Close();
            StreamWriter sw = new StreamWriter(configFileFullPath);

            sw.WriteLine(displayUniqueIdentifier);
            sw.WriteLine();

            for (int i = 0; i < selectedComponents.Count; i++)
            {
                if(i == selectedComponents.Count - 1)
                    sw.Write(selectedComponents[i].ComponentId);
                else
                    sw.WriteLine(selectedComponents[i].ComponentId);
            }

            sw.Close();
            this.Close();

            DsvDisplay.createDisplayFromConfiguration(configFileFullPath);
            Process.Start("explorer.exe", ConfigurationManager.AppSettings["DisplayFolder"]);
        }
    }
}
