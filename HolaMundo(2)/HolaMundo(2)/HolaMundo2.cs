using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundo_2_
{
    public partial class HolaMundo2 : Form
    {
        public HolaMundo2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMostrarMateria_Click(object sender, EventArgs e)
        {
            LblMensaje.Text = "Hola gete de la materia " + TxtMateria.Text;
            
        }
    }
}
