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

        private void BtnRes_Click(object sender, EventArgs e)
        {

            try
            {

                Lblres.Text = (Convert.ToInt32(TxtNum1.Text)
                     + Convert.ToInt32(TxtNum2.Text)).ToString();

            }
            catch (Exception )
            {
                LblError.Text = "imposible sumar, debe agregar dos numeros";
                //LblError.Text = Error.Message;
                //MessageBox.Show("imposible sumar, debe agregar dos numeros");
            }

        }
           


        private void Btnclean_Click(object sender, EventArgs e)
        {
            TxtNum1.Text = null;
            TxtNum2.Text = null;
        }

        private void BtnCleanRes_Click(object sender, EventArgs e)
        {
            Lblres.Text = null;
        }

        private void BtnCleanError_Click(object sender, EventArgs e)
        {
            LblError.Text = null;
        }

        private void TxtNum1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                LblError.Text = "Imposible sumar letras";

            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
        
}










        




                

