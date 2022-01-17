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
            }

        }

        private void BtnReac_Click(object sender, EventArgs e)
        {
            PicCoyote.Top = 70;
            //PicCoyote.Visible = true;
            this.Refresh();
            //LblTexto.Text = "Por fin te he atrapado !!";

            PicBeep.Top = 70;
            //PicBeep.Visible = true;
            this.Refresh();

           
        }

        private void BtnMovCoyote_Click(object sender, EventArgs e)
        {
            while (true)
            {
                PicCoyote.Left = PicCoyote.Left + 1;
                this.Refresh();
            }
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
