using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_For
{
    public partial class Ejemplo2 : Form
    {

        public Ejemplo2()
        {
            InitializeComponent();
        }

        

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            
            int x = Convert.ToInt32(TxtValInicial.Text);

            for ( ; x < 750; )
            {
                LblRojo.Left = x;
                x = x + 2;
                this.Refresh();
            }
        }
    }
}
