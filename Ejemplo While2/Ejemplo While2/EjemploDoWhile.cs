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
    public partial class EjemploDoWhile : Form
    {
        public EjemploDoWhile()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnWhile_Click(object sender, EventArgs e)
        {
            EjemploWhile primerform = new EjemploWhile();
            primerform.ShowDialog();
        }
    }
}
