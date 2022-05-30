using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_checkbob
{
    public partial class Prg_Checkbox : Form
    {
        //Variable privada para las filas del DataGridView
        private int Fila = 0;


        public Prg_Checkbox()
        {
            InitializeComponent();
        }


        //Seleccion de opciones de chexbox
        private void BtAceptar_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked == false)
            {
                label1.Text = "No se ha seleccionado -  por favor elija una";
            }
            if (checkBox1.Checked == true)
            {
                label1.Text = "Ha seleccionado, Hombre - ingrese sus datos personales";
            }
            if (checkBox2.Checked == true)
            {
                label1.Text = "Ha seleccionado, Mujer - Ingrese sus datos personale";
            }
            if (checkBox1.Checked && checkBox2.Checked == true)
            {
                label1.Text = "Error - Debe seleccionar solo una de las opciones, intente nuevamente";
            }
        }
            
        //Boton para limpiar datos ingresados en los controles texbox
        private void Btlimpiar_Click(object sender, EventArgs e)
        {
            label1.Text = null;
        }


        //Boton de cerrar programa
        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }


        //Datos de texbox
        private void BtAgregar_Click(object sender, EventArgs e)
        {
            int Fila = DgDatosPersonles.Rows.Add();

            DgDatosPersonles.Rows[Fila].Cells[0].Value = TxNomApellido.Text;
            DgDatosPersonles.Rows[Fila].Cells[1].Value = TxDirección.Text;
            DgDatosPersonles.Rows[Fila].Cells[4].Value = TxTel.Text;
            DgDatosPersonles.Rows[Fila].Cells[3].Value = TxEdad.Text;
            DgDatosPersonles.Rows[Fila].Cells[2].Value = TxDocu.Text;

            //Limpieza de controles de los datos personales

            TxNomApellido.Text = null;
            TxDirección.Text = null;
            TxTel.Text = null;
            TxEdad.Text = null;
            TxDocu.Text = null;

            TxNomApellido.Focus();
            TxDirección.Focus();
            TxTel.Focus();
            TxEdad.Focus();
            TxDocu.Focus();

            TxNomApellido.SelectAll();
            TxDirección.SelectAll();
            TxTel.SelectAll();
            TxEdad.Focus();
            TxDocu.SelectAll();
                
        }
        //Boton que elimina finas de datos cargados
        private void Btborrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Fila != -1)
                {
                    DgDatosPersonles.Rows.RemoveAt(Fila);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Imposible seguir borrando");
            }
        }
        //Filas del data , donde se cargan los datos personales
        private void Carga_datos_personales(object sender, DataGridViewCellEventArgs e)
        {
            Fila = e.RowIndex;

            if (Fila != -1)
            {
                LbInfo.Text = (string)DgDatosPersonles.Rows[Fila].Cells[1].Value;
            }
        }
        //Limpiar controles de datos
        private void BtLimp_Click(object sender, EventArgs e)
        {
            LbInfo.Text = null;
        }
    }
}
                
            
            
            






           
            
           

               
            
