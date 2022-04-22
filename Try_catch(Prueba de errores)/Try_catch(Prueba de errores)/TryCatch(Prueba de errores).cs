using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Try_catch_Prueba_de_errores_
{
    public partial class TryCatch_Prueba_de_errores_ : Form
    {
        public TryCatch_Prueba_de_errores_()
        {
            InitializeComponent();
        }

       
        private void BtnSuma_Click_1(object sender, EventArgs e)
        {

            TxtSum1.Text = null;
            TxtSum2.Text = null;

            try
            {

                LblresSuma.Text = (Convert.ToInt32(TxtSum1.Text)
                     + Convert.ToInt32(TxtSum2.Text)).ToString();
                

            }
            catch (Exception)
            {
                
                MessageBox.Show("imposible sumar, debe agregar dos numeros");
                
            }

        }


        

        private void BtnResta_Click(object sender, EventArgs e)
        {

            TxtRes1.Text = null;
            TxtRes2.Text = null;

            try
            {

                LblResResta.Text = (Convert.ToInt32(TxtRes1.Text)
                     - Convert.ToInt32(TxtRes2.Text)).ToString();

            }
            catch (Exception)
            {
                
                MessageBox.Show("imposible restar, debe agregar dos numeros");
                
            }
        }



        private void Btnclean_Click(object sender, EventArgs e)
        {
            TxtSum1.Text = null;
            TxtSum2.Text = null;
            TxtRes1.Text = null;
            TxtRes2.Text = null;
        }

        private void BtnCleanRes_Click(object sender, EventArgs e)
        {
            LblresSuma.Text = null;
            LblResResta.Text = null;
        }

        
            
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
        
}


       
        










        




                

