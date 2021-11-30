using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba_1
{
    public partial class FormInicial : Form
    {

       
        string PrimerVariable = "Leandro";

        public FormInicial()
        {
            string SegundaVarible = "¿Que tal?";
            InitializeComponent();
            label1.Text = "Hola" + " " + PrimerVariable + " " + SegundaVarible ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            string TercerVariable = "¿Como te va?";

            label1.Text = "Hola" + PrimerVariable + TercerVariable ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //NUEVOFORMULARIO FormSiguiente = new NUEVOFORMULARIO();
            //FormSiguiente.Show();
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {

        }
    }
}

       

       
