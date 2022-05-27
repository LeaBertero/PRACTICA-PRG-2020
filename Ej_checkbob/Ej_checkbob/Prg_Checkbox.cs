using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_checkbob
{
    public partial class Prg_Checkbox : Form
    {
        public Prg_Checkbox()
        {
            InitializeComponent();
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked == false)
            {
                label1.Text = "Seleccione una de las opciones";
            }
            if (checkBox1.Checked == true)
            {
                label1.Text = "Hombre - ingrese sus datos";
            }
            if (checkBox2.Checked == true)
            {
                label1.Text = "Mujer - Ingrese sus datos";
            }
            if (checkBox1.Checked && checkBox2.Checked == true)
            {
                label1.Text = "Error - Debe selecciona solo una de las opciones";
            }
            
            
            
        }

        private void Btlimpiar_Click(object sender, EventArgs e)
        {
            label1.Text = null;
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
           
            
           

               
            
