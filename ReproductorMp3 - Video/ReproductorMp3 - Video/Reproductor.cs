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
    public partial class Reproductor : Form
    {
        private string Ruta = "";


        public Reproductor()
        {
            InitializeComponent();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                Ruta = openFileDialog1.FileName;
                LblMensaje.Text = Ruta;
                MessageBox.Show("Carga correcta"); 
            }
            //else
            //{
            //    MessageBox.Show("Carga incorrecta - no se detectaron archivos Mp3");
            //}
        }

        private void BtnRep_Click(object sender, EventArgs e)
        {
            WinMedaP.URL = Ruta;
            WinMedaP.Ctlcontrols.play();

            //try
            //{
               
            //    //mensajeError.Text = "Debe cargar un archivo de audio / video";
            //}
            //catch (Exception)
            //{
                
            //    //MessageBox.Show("Debe cargar un archivo de audio / video");
               
                
            //}

        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            WinMedaP.Ctlcontrols.stop();
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            WinMedaP.Ctlcontrols.pause();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
