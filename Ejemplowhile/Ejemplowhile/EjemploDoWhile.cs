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
    public partial class EjemploDoWhile : Form
    {
        public EjemploDoWhile()
        {
            InitializeComponent();
        }

       

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            int repeticion = 0;
            int totalrepeticion = 5;

            do
            {

                int Anchoformulario = this.Width;
                int ancholabel = LblMovimiento.Width;
                int anchoborde = 20;
                int x = 0;
                int paso = 1;
                repeticion = repeticion + 1;


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
                    this.Refresh();
                }


            } while (repeticion <totalrepeticion);

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {

            EjemploWhile SegundoForulario = new EjemploWhile();
            SegundoForulario.Show();
        }
    }
}


            

            

           

