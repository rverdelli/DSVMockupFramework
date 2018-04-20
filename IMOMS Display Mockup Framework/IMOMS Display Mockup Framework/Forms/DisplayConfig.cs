using System;
using System.Configuration;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMOMS_Display_Mockup_Framework
{
    public partial class DisplayConfig : Form
    {
        public DisplayConfig()
        {
            InitializeComponent();
            string compFolder = ConfigurationManager.AppSettings["CompFolder"];

            if(!Directory.Exists(compFolder))
            {
                MessageBox.Show("Component folder not found");
                Environment.Exit(-1);
            }

        }
    }
}
