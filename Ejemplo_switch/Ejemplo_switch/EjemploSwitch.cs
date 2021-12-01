using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_switch
{
    public partial class EjemploSwitch : Form
    {
        public EjemploSwitch()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int Nota = System.Convert.ToInt32(TxtNota.Text);

                switch (Nota)
                {
                    case 1:
                        LblRes.Text = "Aplazado";
                        break;

                    case 2:
                        LblRes.Text = "Aplazado";
                        break;

                    case 3:
                        LblRes.Text = "Aplazado";
                        break;

                    case 4:
                        LblRes.Text = "Promocionado";
                        break;

                    case 5:
                        LblRes.Text = "Promocionado";
                        break;


                    default:
                        LblRes.Text = "Nota no valida";
                        break;

                }

            }
            catch (Exception)
            {
                LblRes.Text = "ERROR FATAL";
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EjemploSwitch2 Ejemplo2 = new EjemploSwitch2();
            Ejemplo2.Show();
        }
    }
}






