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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bitmap BackgroundIMOMS = new Bitmap("background/IMOMS.png");
            pictureBox1.Image = (Image)BackgroundIMOMS;
            
            Bitmap img_overlay = new Bitmap("Components/comp01.png");
            img_overlay = DsvDisplay.resizeToComponentSize(img_overlay);
            MessageBox.Show("img_overlay dimention is:" + img_overlay.Size.ToString());//debug without breackpoint :)

            List<Bitmap> prova = new List<Bitmap>();
            prova.Add(img_overlay);
            Bitmap Result = DsvDisplay.setComponents(prova);
            pictureBox1.Image = (Image)Result;

        }
    }
}
