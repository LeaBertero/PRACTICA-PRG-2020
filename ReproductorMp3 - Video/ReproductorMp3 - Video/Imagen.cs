using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReproductorMp3___Video
{
    public partial class FrmImagen : Form
    {
        public FrmImagen()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileD = new OpenFileDialog();

            OpenFileD.Filter = "Imagenes|*.jpg;*.png;";
            OpenFileD.Title = "Abrir imagen";

            if (OpenFileD.ShowDialog()==DialogResult.OK)
            {

                string Url_archivo = OpenFileD.FileName;
                string nombre = OpenFileD.FileName;


                this.Text = nombre;


                PicImage.SizeMode = PictureBoxSizeMode.CenterImage;
                PicImage.SizeMode = PictureBoxSizeMode.Zoom;
                PicImage.Load(Url_archivo);


            }
        }
    }
}
