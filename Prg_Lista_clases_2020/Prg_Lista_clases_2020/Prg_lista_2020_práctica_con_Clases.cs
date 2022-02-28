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

        public Persona[] personas { get; set; }   
        //public int Posicion = -1;


        public Prg_lista_2020_práctica_con_Clases()
        {
            InitializeComponent();
        }

        private void BtIngreso_Click(object sender, EventArgs e)
        {
            try
            {
                Persona persona = new Persona();

                persona.Nombre = TxtNombre.Text;

                if (personas == null)
                {

                }

                //Posicion = Posicion + 1;

                personas[personas.Length -1] = persona;

                TxtNombre.Focus();

                TxtNombre.SelectAll();
            }
            catch (Exception)
            {

                MessageBox.Show("Carga completa");
            }
            
        }

       


        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            Lblista.Text = null;
            TxtNombre.Text = null;
        }
        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtMostrar_Click(object sender, EventArgs e)
        {
            Lblista.Text = "Lista: \r\n";
            foreach (Persona elemento in personas)
            {
                //lbLista.Text = lbLista.Text + elemento.Nombre + "\r\n";

                // cualquiera de estos dos casos funciona igual
                
                /*Caso 1:*/ /*Lblista.Text += elemento.Nombre + "\r\n";*/

                /*Caso 2:*/ Lblista.Text = Lblista.Text + elemento.Nombre + "\r\n";

            }
        }
    }
}


       





