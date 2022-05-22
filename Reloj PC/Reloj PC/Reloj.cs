using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reloj_PC
{
    public partial class Reloj : Form
    {

        public Reloj()
        {
            InitializeComponent();
        }

        private void timer1Reloj_Tick(object sender, EventArgs e)
        {
            //Lblrel.Text = DateTime.Now.ToLongTimeString();

            LblReloj.Text = DateTime.Now.ToString("HH:mm:ss");


        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
            
}

        

