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

       
        string Nombre = "Leandro";

        public FormInicial()
        {
            string Saludo = "¿Que tal?";
            InitializeComponent();
            NomSaludo.Text = "Hola" + " " + Nombre + " " + Saludo ;
        }

        

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            string TercerVariable = "¿Como te va?";

            NomSaludo.Text = "Hola" + Nombre + TercerVariable; //+ SegundaVariable ;(No se puede usar en este ambito por la vida de las variables)
        }

       
    } 
}
       


        

       

       

       
