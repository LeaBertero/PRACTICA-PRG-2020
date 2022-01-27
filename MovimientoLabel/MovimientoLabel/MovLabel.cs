using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovimientoLabel
{
    public partial class MovLabel : Form
    {
        


        public MovLabel()
        {
            InitializeComponent();
        }

        private void BtIniciar_Click(object sender, EventArgs e)
        {

            int SentidoV = 1;
            int SentidoH = 1;
            int PasoV = 1;
            int PasoH = 1;

            Random RandomPaso = new Random();
            Random RandomSentido = new Random();

            for (int Movimiento = 0; Movimiento < 150; Movimiento++)
            {
               

                PasoH = RandomSentido.Next(-1,2);
                PasoV = RandomSentido.Next(-1,2);

                PasoH = RandomPaso.Next(0,5);
                PasoV = RandomSentido.Next(0,5);

                LbMov1.Left = LbMov1.Left + (PasoH *SentidoH);
                LbMov1.Top = LbMov1.Top + (PasoV * SentidoV);
                this.Refresh();

                RandomSentido = null;

            }

        }
    }
}
