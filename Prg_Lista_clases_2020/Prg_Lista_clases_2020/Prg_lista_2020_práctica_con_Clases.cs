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
        //Clase persona esta instsnciada
        //public Persona[] personas { get; set; }

        public ListaPersonas Lista { get; set; } = new ListaPersonas();

        //lugar por donde arranca la ejecución del programa

        public Prg_lista_2020_práctica_con_Clases()
        {
            InitializeComponent();
        }


        private void BtCargar_Click(object sender, EventArgs e)
        {
            {
                //Persona persona = new Persona();

                //persona.Nombre = TxtNombre.Text;

                //Lista.personas[Lista.personas.Length - 1] = persona;

                //persona.AñoNacimiento = Convert.ToInt32(TxtAño.Text);

                //Lista.Redimensionar(); /* Este método se utiliza para agregar cierta cantidad 
                //                  * de elementos establecidos por el usuario */

                //TxtNombre.Focus();

                //TxtNombre.SelectAll();

                //Lblista.Text = null;

                if( !Lista.AddPersona(TxtNombre.Text, TxtAño.Text))
                {

                    Lblista.Text = "Persona no valida";
                
                }
                else
                {

                    Lblista.Text = "Ingreso válido";

                }
                
            }
        }
            
        private void BtMostrar_Click(object sender, EventArgs e)
        {
            //Lblista.Text = "Lista: \r\n";
            //foreach (Persona elemento in Lista.personas)
            //{
            //    Lblista.Text = Lblista.Text + elemento.AñoNacimiento + " - " + elemento.Nombre + "\r\n";
            //}

            Lblista.Text = Lista.ToString();

        }

        //private void Redimensionar() /*Método Redimensionar*/
        //{
        //    if (personas == null)
        //    {

        //        personas = new Persona[1];

        //    }
        //    else
        //    {

        //        Persona[] ArregloAuxiliar = new Persona[personas.Length + 1];

        //        for (int contador = 0; contador < personas.Length; contador++)
        //        {
        //            ArregloAuxiliar[contador] = personas[contador];
        //        }

        //        personas = ArregloAuxiliar;

        //    }
        //}

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            Lblista.Text = null;
            TxtNombre.Text = null;
            TxtAño.Text = null;
        }
    } 
}
        
        
       











        






           



       
            

       





       





