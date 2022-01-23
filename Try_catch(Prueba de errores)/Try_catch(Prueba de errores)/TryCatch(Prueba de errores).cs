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

            try
            {

                LblresSuma.Text = (Convert.ToInt32(TxtSum1.Text)
                     + Convert.ToInt32(TxtSum2.Text)).ToString();

            }
            catch (Exception)
            {
                LblError.Text = "imposible sumar, debe agregar dos numeros";
                //LblError.Text = Error.Message;
                //MessageBox.Show("imposible sumar, debe agregar dos numeros");
            }

        }


        private void BtnResta_Click(object sender, EventArgs e)
        {
            try
            {

                LblResResta.Text = (Convert.ToInt32(TxtRes1.Text)
                     - Convert.ToInt32(TxtRes2.Text)).ToString();

            }
            catch (Exception)
            {
                LblError.Text = "imposible restar, debe agregar dos numeros";
                //LblError.Text = Error.Message;
                //MessageBox.Show("imposible sumar, debe agregar dos numeros");
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

        private void BtnCleanError_Click(object sender, EventArgs e)
        {
            LblError.Text = null;
        }
            

        //private void TxtNum1_KeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {

        //        LblError.Text = "Imposible sumar letras";

        //    }
        //}

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
        
}










        




                

