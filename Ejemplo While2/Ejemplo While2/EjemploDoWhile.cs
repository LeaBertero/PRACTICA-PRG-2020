using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_While2
{
    public partial class EjemploDoWhile : Form
    {
        public EjemploDoWhile()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnWhile_Click(object sender, EventArgs e)
        {
            EjemploWhile primerform = new EjemploWhile();
            primerform.ShowDialog();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            int anchoform2 ;
            int ancholabel2;
            int anchoborde2;
            int X2;
            int Paso2;
            int repeticion2 = 0;
            int Totalrepeticion2 = 3;

            do
            {
                anchoform2 = this.Width;
                ancholabel2 = this.Width;
                anchoborde2 = 20;
                X2 = 0;
                Paso2 = 1;
                repeticion2 = repeticion2 + 1;

                while (X2 < (anchoform2 - anchoborde2 - ancholabel2))
                {
                    LblRiv.Left = X2;
                    this.Refresh();
                    X2 = X2 + Paso2;
                }

            } while (repeticion2 < Totalrepeticion2);


           
        }
    }
}



