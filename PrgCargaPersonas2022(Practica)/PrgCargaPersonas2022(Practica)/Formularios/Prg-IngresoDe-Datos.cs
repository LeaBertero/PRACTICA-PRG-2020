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
       
        public  PrgCargaPersonas2022_Practica_Clases.Persona Persona{  get; set; }
        
        string[] Nombres;
        int posicion = 0;

        public Prg_IngresoDe_Datos()
        {
            InitializeComponent();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            
            try
            {
                Nombres[posicion] = TxtIngreso.Text;
                posicion = posicion - 1;
                TxtIngreso.Focus();
                TxtIngreso.SelectAll();

            }
            catch (Exception)
            {
                MessageBox.Show("Carga completa - use una nueva dimension");
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
            TxtIngreso.Text = null;
            TxtDim.Text = null;
            LbLista.Text = null;
        }

        private void BtMostrar_Click(object sender, EventArgs e)
        {
            LbLista.Text = null;

            foreach (string Nombres in Nombres)
            {
                LbLista.Text = LbLista.Text + Nombres + "\r\n";
            }
        }
    }
}






