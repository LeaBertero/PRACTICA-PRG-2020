using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_For
{
    public partial class PruebaFor : Form
    {
        public PruebaFor()
        {
            InitializeComponent();
        }

        //MessageBox.Show("Debe ingresar un valor ");
        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            
            int desplazamiento = Convert.ToInt32(TxtValInicial.Text);

           
            for (int inical = desplazamiento; inical < 659; inical++)
            {
                LblRojo.Left = inical;
                this.Refresh();
                Task.Delay(1000);

            }

           
            for (int inical = desplazamiento; inical < 659; inical++)
            {
                Lblamarillo.Left = inical;
                this.Refresh();
                Task.Delay(1000);
            }

           
            for (int inical = desplazamiento; inical < 659; inical++)
            {
                LblVerde.Left = inical;
                this.Refresh();
                //Task.Delay(1000);
            }

            LblFin.Visible = true;
        }


        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnEjemplo2_Click(object sender, EventArgs e)
        {
            Ejemplo2 segundoEj = new Ejemplo2();
            segundoEj.ShowDialog();
        }
    }
}

       
