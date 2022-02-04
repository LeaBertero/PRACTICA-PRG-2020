using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargaDePersonas
{


    public partial class FormCargaPers : Form
    {
        //Propiedad definida a nivel del formulario, para que se pueda ver/ usar en todo el programa
        //Varaible definida a nivel global
       
        Persona Mostrar = new Persona();


        public FormCargaPers()
        {
            InitializeComponent();
        }

        public void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
               
                Mostrar.Nombre = TxtNombre.Text;
                //Mostrar.Apellido = TxtApellido.Text;
                Mostrar.Edad = Convert.ToInt32(TxtEdad.Text);
               

                LblMostrarLista.Text = Mostrar.Nombre + "  " + Mostrar.Apellido + "  " + Mostrar.Edad;

                LblMostrarLista.Text = Mostrar.NombreCompleto();

                Mostrar = null;
                Mostrar = new Persona();

            }
            catch (Exception)
            {
                LblError.Text = "Imposible Cargar -  debe completar con datos correctos";
            }

        }

            
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LblError.Text = null;
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BtBorrar_Click(object sender, EventArgs e)
        {
            TxtNombre.Text = null;
            //TxtApellido.Text = null;
            TxtEdad.Text = null;
            TxtInsMateria.Text = null;
            TxtAñoMateria.Text = null;
        }

        private void BtCleanLista_Click(object sender, EventArgs e)
        {
            LblMostrarLista.Text = null;
            LblInsMateria.Text = null;

        }
        private void BtnInscripcion_Click(object sender, EventArgs e)
        {
            try
            {

                Materia InscripcionMateria = new Materia();

                InscripcionMateria.Nombre = TxtInsMateria.Text;
                InscripcionMateria.Año = Convert.ToInt32(TxtAñoMateria.Text);

                Mostrar.MateriaCursada = InscripcionMateria;

                LblInsMateria.Text = Mostrar.MateriaCursada.Nombre + " - " + "Año " + Mostrar.MateriaCursada.Año.ToString(); 
                
                
            }
            catch (Exception)
            {
                LblError.Text = "Imposible Cargar -  debe completar con datos correctos";
            }


        }
    }
}


            
           




