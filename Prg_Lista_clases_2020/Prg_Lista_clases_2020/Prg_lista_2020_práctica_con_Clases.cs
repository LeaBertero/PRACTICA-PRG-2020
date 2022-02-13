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

namespace Prg_Lista_clases_2020
{
    public partial class Prg_lista_2020_práctica_con_Clases : Form
    {
        
        public Persona[] personas { get; set; } = new Persona[2];    //Propiedad de la clase persona

        public Prg_lista_2020_práctica_con_Clases()
        {
            InitializeComponent();
        }

        private void BtIngreso_Click(object sender, EventArgs e)
        {
            Persona personas = new Persona();

            personas.Nombre = TxIngreso.Text;


            Persona[0] = personas;
        }

        private void BtVer_Click(object sender, EventArgs e)
        {
            lbLista.Text = "Lista: \r\n";

            foreach (Persona Item in personas)
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


