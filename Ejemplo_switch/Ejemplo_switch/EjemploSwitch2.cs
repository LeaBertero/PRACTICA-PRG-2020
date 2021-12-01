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
    public partial class EjemploSwitch2 : Form
    {
        public EjemploSwitch2()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnClick_Click(object sender, EventArgs e)
        {
            int Nota = System.Convert.ToInt32(TxtNota.Text.Trim());

            switch (TxtNota.Text)
            {
                case "1":
                    LblRes.Text = "Aplazado";
                    break;

                case "2":
                    LblRes.Text = "Aplazado";
                    break;

                case "3":
                    LblRes.Text = "Aplazado";
                    break;

                case "4":
                    LblRes.Text = "Promocionado";
                    break;

                case "5":
                    LblRes.Text = "Promocionado";
                    break;


                default:
                    LblRes.Text = "Nota no valida";
                    break;
            }
        }

       
    }
}

