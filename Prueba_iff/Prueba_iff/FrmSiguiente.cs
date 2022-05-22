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
    public partial class FrmSiguiente : Form
    {
        public FrmSiguiente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            FormInicial FormInicio = new FormInicial();
            FormInicio.ShowDialog();
        }
    }
}
