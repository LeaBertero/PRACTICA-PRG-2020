using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contador
{
    public partial class Contador : Form
    {
        int numero;

        public Contador()
        {
            InitializeComponent();
        }

        private void BtnContar_Click(object sender, EventArgs e)
        {
            ++numero;
            Lblcontador.Text = System.Convert.ToString(numero);
        }
    }
}
