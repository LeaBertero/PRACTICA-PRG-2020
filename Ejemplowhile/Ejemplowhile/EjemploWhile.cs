using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplowhile
{
    public partial class EjemploWhile : Form
    {
        public EjemploWhile()
        {
            InitializeComponent();
        }

        private void BtnSegEjemplo_Click(object sender, EventArgs e)
        {
            EjemploDoWhile SegundoForulario = new EjemploDoWhile();
            SegundoForulario.ShowDialog();
        }

        private void BtNSalir_Click(object sender, EventArgs e)
        {
            Close();

        }  
        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            int Anchoformulario = this.Width;
            int ancholabel = LblMovimiento.Width;
            int anchoborde = 20;
            int x = 0;
            int paso = 1;


            //for (int x = 0; x < Anchoformulario - ancholabel - anchoborde; x++)
            //{
            //    LblMovimiento.Left = x;
            //    this.Refresh();
            //}

            while (x < Anchoformulario - ancholabel - anchoborde)
            {
                LblMovimiento.Left = x;
                //LblMovimiento.Top = x;
                this.Refresh();
                x = x + paso;
            }

        }

    }
}

          

           
     