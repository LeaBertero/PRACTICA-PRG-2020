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

        

        private void BtnMovMicMic_Click(object sender, EventArgs e)
        {
            while (true)
            {
                PicBeep.Left = PicBeep.Left + 1;
                this.Refresh();
                LblMensaje.Text = "Beep, Beep";
                LblMensaje.Visible = true;
            }

        }

        private void BtnReac_Click(object sender, EventArgs e)
        {
            PicCoyote.Top = 70;
            this.Refresh();
            
            PicBeep.Top = 70;
            this.Refresh();
            
        }

            

           

        private void BtnMovCoyote_Click(object sender, EventArgs e)
        {
            while (true)
            {
                PicCoyote.Left = PicCoyote.Left + 1;
                this.Refresh();

                if ((PicCoyote.Left + PicCoyote.Width) == PicBeep.Left )
                {
                    break;
                }
                
            }

            LblMensaje.Text = "Te atrapé";
            LblMensaje.Visible = true;

        }

        private void PicCoyote_Click(object sender, EventArgs e)
        {

            while (true)
            {
                PicBeep.Left = PicBeep.Left -1;
                this.Refresh();
            }

        }
    }
}
