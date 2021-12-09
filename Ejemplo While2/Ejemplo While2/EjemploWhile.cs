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
    public partial class EjemploWhile : Form
    {
        public EjemploWhile()
        {
            InitializeComponent();
        }

        private void BtnArranque_Click(object sender, EventArgs e)
        {
            int anchoformulario = this.Width;
            int ancholabel = Lblrojo.Width;
            int anchoborde = 20;
            int X = 0;
            int paso = 2;

            //for (int x = 0; x < anchoformulario - ancholabel - anchoborde; x++)
            //{
            //    Lblrojo.Left = x;
            //    this.Refresh();

            //}

            while (X < anchoformulario - ancholabel - anchoborde)
            {
                Lblrojo.Left = X;
                //Lblrojo.Top = X;
                this.Refresh();
                X = X + paso;
            }
        }
        private void BtnEjDw_Click(object sender, EventArgs e)
        {
            EjemploDoWhile segundoformulario = new EjemploDoWhile();
            segundoformulario.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
                






