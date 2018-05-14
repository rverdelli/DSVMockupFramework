using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMOMS_Display_Mockup_Framework.Forms
{
    public partial class SearchComponentForm : Form
    {
        private List<string> availableComponents;
        private BindingList<SelectedComponent> selectedComponents = new BindingList<SelectedComponent>();

        public SearchComponentForm()
        {
            InitializeComponent();
            initializeComboBox();
        }

        private void updateAvailableComponentsComboBox()
        {
            addComponentsCB.Items.Clear();
            addComponentsCB.Items.AddRange(availableComponents.ToArray());
        }

        private void initializeComboBox()
        {
            availableComponents = Directory.GetFiles(Config.compFolder, "*.png").ToList();

            for (int i = 0; i < availableComponents.Count; i++)
                availableComponents[i] = Path.GetFileNameWithoutExtension(availableComponents[i]);

            List<string> componentsNotAvailable = new List<string>();
            for (int i = 0; i < selectedComponents.Count;)
            {
                bool imageAvailable = false;
                for (int j = 0; j < availableComponents.Count; j++)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedComponentId = addComponentsCB.Text;
            List<string> foundDisplays = new List<string>();
            List<string> foundDashboards = new List<string>();

            foreach (string sourceFile in Directory.GetFiles(Config.displayConfigFolder, "*.csv", SearchOption.AllDirectories))
            {
                String Configuration = File.ReadAllText(sourceFile);
                List<string> componentsNames = new List<string>(Configuration.Split(new[] { Environment.NewLine }, StringSplitOptions.None));

                if (componentsNames.Contains(selectedComponentId))
                    foundDisplays.Add(Path.GetFileNameWithoutExtension(sourceFile));//add display name to be shown
            }

            listBox1.DataSource = foundDisplays;

            foreach (string sourceFile in Directory.GetFiles(Config.dashboardConfigFolder,"*.csv", SearchOption.AllDirectories))
            {
                String Configuration = File.ReadAllText(sourceFile);
                List<string> displayNames = new List<string>(Configuration.Split(new[] { Environment.NewLine }, StringSplitOptions.None));

                foreach (string involvedDisplay in foundDisplays)
                {
                    if (displayNames.Contains(involvedDisplay) && !(foundDashboards.Contains(Path.GetFileNameWithoutExtension(sourceFile))))
                        foundDashboards.Add(Path.GetFileNameWithoutExtension(sourceFile));
                }
            }
            listBox2.DataSource = foundDashboards;
            
        }
    }
}
