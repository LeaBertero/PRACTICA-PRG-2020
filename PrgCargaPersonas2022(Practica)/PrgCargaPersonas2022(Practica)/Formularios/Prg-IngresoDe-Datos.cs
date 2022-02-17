using PrgCargaPersonas2022_Practica_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrgCargaPersonas2022_Practica_
{
    public partial class Prg_IngresoDe_Datos : Form
    {

        public Persona[] personas { get; set; } = new Persona[2];
        
        

        string[] Nombres;

        

        public Prg_IngresoDe_Datos()
        {
            InitializeComponent();
        }

        public void BtnCargar_Click(object sender, EventArgs e)
        {

            try
            {
                Persona persona = new Persona();

                persona.NombreCompleto = TxtNombre.Text;

                personas[0] = persona;
            }
            catch (Exception)
            {

                MessageBox.Show("Imposible cargar - debe completar con datos correctos");
            }




        }





        private void BtDim_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = Convert.ToInt32(TxtDim.Text);
                Nombres = new string[cantidad];

                //LblError.Text = "Carga correcta";
                MessageBox.Show("Carga correcta");
            }
            catch (Exception)
            {

                //LblError.Text = "Debe ingresar una cantidad expresada en numeros de personas a cargar";
                MessageBox.Show("Debe ingresar una cantidad expresada en numeros");
            }
        }
           
       

        private void BtFinalizar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtDatosKill_Click(object sender, EventArgs e)
        {
            TxtNombre.Text = null;
            TxtDim.Text = null;
            LblMostrar.Text = null;
        }

        private void BtMostrar_Click(object sender, EventArgs e)
        {
            LblMostrar.Text = "Lista: = \r\n";

            foreach (Persona item in personas)
            {
                LblMostrar.Text = LblMostrar.Text + Nombres + "Lista: \r\n";

            }
        }

                

        public void BtEdad_Click(object sender, EventArgs e)
        {
            try
            {

                Persona persona = new Persona();
                persona.Edad = Convert.ToInt32(TxtEdad.Text);

            }
            catch (Exception)
            {

                MessageBox.Show("Ingrese la edad por favor");
            }

        }
    }
}






