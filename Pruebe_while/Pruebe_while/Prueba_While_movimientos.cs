using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebe_while
{
    public partial class Prueba_While_movimientos : Form
    {
        

        public Prueba_While_movimientos()
        {
            InitializeComponent();
        }


        private void BtnMovCoyote_Click(object sender, EventArgs e)
        {
            while (true)
            {
                PicCoyote.Left = PicCoyote.Left + 5;
                this.Refresh();

                PicBeep.Left = PicBeep.Left - 5;
                this.Refresh();

                if ((PicCoyote.Left + PicCoyote.Width) == PicBeep.Left)
                {
                    break;
                }

                if ((PicBeep.Left - PicBeep.Width) == PicCoyote.Left)
                {
                    break;
                }

            }

            LblMensaje.Text = "Correcaminos: La dinamita ACME no funciona con migo xD";
            LblMensaje.Visible = true;


        }
        
        private void BtnAparecer_Click(object sender, EventArgs e)
        {
            PicCoyote.Visible = true;
            

        }
        
        private void BtnReac_Click(object sender, EventArgs e)
        {
            PicCoyote.Top = 150;
            this.Refresh();
            
            PicBeep.Top = 150;
            this.Refresh();

            PicCoyote.Left = 50;
            PicBeep.Left = 1030;

            LblMensaje.Visible = false;
        }

        private void BntAparecer2_Click(object sender, EventArgs e)
        {
            PicBeep.Visible = true;
        }

        private void BtnBorrarPers1_Click(object sender, EventArgs e)
        {
            PicCoyote.Visible = false;
        }

        private void BtnBorrarPers2_Click(object sender, EventArgs e)
        {
            PicBeep.Visible = false;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
                    
}


           

        


       
        
                


       


        
            
            

           


        




