using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploFor
{
    public partial class EjemploFor : Form
    {
        public EjemploFor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {


            for (int incremento = Convert.ToInt32(TxtIngreso1.Text); //primer textbox
                incremento <= Convert.ToInt32(TxtIngreso2.Text); //Segundo textbox
                incremento = incremento + Convert.ToInt32(TxtIngreso3.Text)) //tercer textbox
            
            {

                LblRes.Text = incremento.ToString();
                this.Refresh();

            }
        }
    }
}

       
