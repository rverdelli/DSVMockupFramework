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
    public partial class ImagePreview : Form
    {
        public ImagePreview()
        {
            InitializeComponent();
            List<string> list= new List<string>();
            list.Add("haa");
            list.Add("gaa");
            list.Add("faa");
            list.Add("eaa");
            list.Add("daa");
            list.Add("caa");
            list.Add("baa");
            DsvDisplay.createDisplay(list, "NomeDashboard");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {   
            //Create an image list START 
            Bitmap img_overlay = new Bitmap("Components/comp01.png");
            img_overlay = DsvDisplay.resizeToComponentSize(img_overlay);
            Queue<Bitmap> prova = new Queue<Bitmap>();
            prova.Enqueue(img_overlay);
            prova.Enqueue(img_overlay);
            prova.Enqueue(img_overlay);

            // Create a list END

            Bitmap Result = DsvDisplay.setComponents(prova);
            pictureBox1.Image = (Image)Result;
        }
    }
}
