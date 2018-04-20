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

            addComponentsCB.Items.AddRange(availableComponents.ToArray());

            /*Initialize grid view configurations*/
            selectedComponentsGridView.AutoGenerateColumns = false;
            selectedComponentsGridView.DataSource = selectedComponents;

            selectedComponentsGridView.Columns[0].DataPropertyName = "OrderID";
            selectedComponentsGridView.Columns[1].DataPropertyName = "ComponentId";
            selectedComponentsGridView.Columns[2].DataPropertyName = "MoveUp";
            selectedComponentsGridView.Columns[3].DataPropertyName = "MoveDown";
            selectedComponentsGridView.Columns[4].DataPropertyName = "Remove";

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
    }
}
