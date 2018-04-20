using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new ImagePreview();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fRob = new DisplayConfig(@"C:\DSVMockupFramework\DisplayConfigFilesFolder\qwe.csv");
            fRob.Show();
        }
    }
}
