using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_iff
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int edad = System.Convert.ToInt32(TxtIngreso.Text);

            if (edad < 12)
            {
                LblResultado.Text = "NIÑO";
            }
            else if (edad >= 12 && edad < 18)
            {
                LblResultado.Text = "ADOLESCENTE";
            }
            else if (edad>= 18 && edad < 60)
            {
                LblResultado.Text = "ADULTO";
            }
            else
            {
                LblResultado.Text = "ADULTO MAYOR";
            }
        }
    }
}
