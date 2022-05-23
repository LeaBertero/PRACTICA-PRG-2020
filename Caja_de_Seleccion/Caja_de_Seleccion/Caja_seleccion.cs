using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja_de_Seleccion
{
    public partial class Caja_seleccion : Form
    {
        public Caja_seleccion()
        {
            InitializeComponent();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Negrita_CheckedChanged(object sender, EventArgs e)
        {
            this.LblEstilo.Font = new Font(this.label1.Font.FontFamily,
            this.LblEstilo.Font.Size, this.LblEstilo.Font.Style ^ FontStyle.Bold);
        }
    }
}

