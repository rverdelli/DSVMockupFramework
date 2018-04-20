using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;

namespace IMOMS_Display_Mockup_Framework
{
    public partial class DisplayConfig : Form
    {
        private List<string> availableComponents;
        private BindingList<SelectedComponent> selectedComponents = new BindingList<SelectedComponent>();

        public DisplayConfig()
        {
            InitializeComponent();

            /*Get components list*/
            string compFolder = ConfigurationManager.AppSettings["CompFolder"];

            if(!Directory.Exists(compFolder))
            {
                MessageBox.Show("Components folder not found, please create the folder " + compFolder + " and put components images in it.", "ERROR");
                Environment.Exit(-1);
            }

            availableComponents = Directory.GetFiles(compFolder).ToList();

            /*Populate combo box*/
            for(int i = 0; i < availableComponents.Count; i++)
                availableComponents[i] = Path.GetFileNameWithoutExtension(availableComponents[i]);

            updateAvailableComponentsComboBox();

            /*Initialize grid view configurations*/
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
                MessageBox.Show("Display unique identified cannot be blank", "ERROR");

            string displayConfigFilesFolder = ConfigurationManager.AppSettings["DisplayConfigFilesFolder"]; ;
            string configFileFullPath = displayConfigFilesFolder + "\\" + displayUniqueIdentifier + ".csv";

            if (!Directory.Exists(displayConfigFilesFolder))
                Directory.CreateDirectory(displayConfigFilesFolder);

            if(File.Exists(configFileFullPath))
                MessageBox.Show("Display unique identifier already exists: " + configFileFullPath, "ERROR");

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
        }
    }
}
