using Prg_Lista_clases_2020.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prg_Lista_clases_2020;

namespace Prg_Lista_clases_2020
{
    public partial class Prg_lista_2020_práctica_con_Clases : Form
    {
        
        public Persona[] individuo { get; set; } /*= new Persona[2];*/    //Propiedad de la clase persona

        public Prg_lista_2020_práctica_con_Clases()
        {
            InitializeComponent();
        }

        private void BtIngreso_Click(object sender, EventArgs e)
        {
            Persona individuo = new Persona();

            individuo.Nombre = TxIngreso.Text;

            individuo.Edad = TxtEdad.Text;

            //Persona[0] = individuo;

            //Persona[] = individuo;
        }


        private void BtVer_Click(object sender, EventArgs e)
        {
            lbLista.Text = "Lista: \r\n";

            foreach (Persona Item in individuo)
            {
                lbLista.Text = lbLista.Text + Item.Nombre + "\r\n";
                
            }
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            lbLista.Text = null;
        }
    }
}


