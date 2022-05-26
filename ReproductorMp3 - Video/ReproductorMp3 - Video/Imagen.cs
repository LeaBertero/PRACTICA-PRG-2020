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
            //Se crea una Instancia
            OpenFileDialog OpenFileD = new OpenFileDialog();
            
            //*Tipo de archivos que van a a ser cargados
            OpenFileD.Filter = "Imagenes|*.jpg;*.png;";
            
            //*Titulo de la ventana emergente
            OpenFileD.Title = "Abrir imagen";


            //* Abriendo archivos
            if (OpenFileD.ShowDialog()==DialogResult.OK)
            {
                //*Buscando la direccion del archivo (por ubicacion)
                string Url_archivo = OpenFileD.FileName;
                
                //*Buscando por nombre de archivo
                string nombre = OpenFileD.FileName;


                this.Text = nombre; //*Titulo de la ventana

                //*PROPIEDADES
                PicImage.Load(Url_archivo); //* En este caso el picture box, tomaria la direccion del archivo para ser visualizado en pantalla
                PicImage.SizeMode = PictureBoxSizeMode.CenterImage; //* (Esta propiedad centraria la imagen en el picturebox)
                PicImage.SizeMode = PictureBoxSizeMode.Zoom; //* (Agrandar la imagen)

                
            }
        }

        
    }
}
