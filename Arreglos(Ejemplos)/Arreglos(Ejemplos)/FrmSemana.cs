using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreglos_Ejemplos_
{
    public partial class FrmSemana : Form
    {

        string[] Dias = new string[7];

        public FrmSemana()
        {
            InitializeComponent();
        }
        private void BtnLunes_Click_1(object sender, EventArgs e)
        {
            Dias[0] = "Lunes";
            LbLunes.Text = Dias[0];
        }
        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BtnMartes_Click(object sender, EventArgs e)
        {
            Dias[1] = "Martes";
            LbMartes.Text = Dias[1];
        }
        private void BtnMiercoles_Click(object sender, EventArgs e)
        {
            Dias[2] = "Miércoles";
            LbMiercoles.Text = Dias[2];
        }
        private void BtnJueves_Click(object sender, EventArgs e)
        {
            Dias[3] = "Jueves";
            LbJueves.Text = Dias[3];
        }
        private void BtnViernes_Click(object sender, EventArgs e)
        {
            Dias[4] = "Viernes";
            LbViernes.Text = Dias[4];
        }
            
            


        private void BtnSabado_Click(object sender, EventArgs e)
        {
            Dias[5] = "Sábado";
            LbSabado.Text = Dias[5];
        }
        private void BtnDomingo_Click(object sender, EventArgs e)
        {
            Dias[6] = "Domingo";
            LbDomingo.Text = Dias[6];
        }


        private void BtLimpiarSemana_Click(object sender, EventArgs e)
        {
            LbLunes.Text = null;
            LbMartes.Text = null;
            LbMiercoles.Text = null;
            LbJueves.Text = null;
            LbViernes.Text = null;
            LbSabado.Text = null;
            LbDomingo.Text = null;
        }
        private void BtSupLun_Click(object sender, EventArgs e)
        {
            LbLunes.Text = null;
        }

        private void BtSupMa_Click(object sender, EventArgs e)
        {
            LbMartes.Text = null;
        }

        private void BtSupMi_Click(object sender, EventArgs e)
        {
            LbMiercoles.Text = null;
        }

        private void BtSupJu_Click(object sender, EventArgs e)
        {
            LbJueves.Text = null;
        }

        private void BtSupVie_Click(object sender, EventArgs e)
        {
            LbViernes.Text = null;
        }

        private void BtSupSa_Click(object sender, EventArgs e)
        {
            LbSabado.Text = null;
        }

        private void BtSupDom_Click(object sender, EventArgs e)
        {
            LbDomingo.Text = null;
        }
    }
}
            

        

            



            
            



           
            



            


            
            





            
