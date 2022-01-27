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
        public FormCargaPers()
        {
            InitializeComponent();
        }

        public void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona Mostrar = new Persona();

                Mostrar.Nombre = TxtNombre.Text;
                Mostrar.Apellido = TxtApellido.Text;
                Mostrar.Edad = Convert.ToInt32(TxtEdad.Text);
               

                LblistaMostrar.Text = Mostrar.Nombre + "  " + Mostrar.Apellido + "  " + Mostrar.Edad;

                LblistaMostrar.Text = Mostrar.NombreCompleto();
                     

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
            TxtApellido.Text = null;
            TxtEdad.Text = null;
        }

        private void BtCleanLista_Click(object sender, EventArgs e)
        {
            LblistaMostrar.Text = null;
        }
    }
}
