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
                posicion = posicion + 1;
                TxtIngreso.Focus();
                TxtIngreso.SelectAll();
            }
            catch (Exception)
            {

                LblError.Text = "Carga completa - Imposible seguir";
            }
        }

        private void BtDim_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = Convert.ToInt32(TxtDim.Text);
                Nombres = new string[cantidad];

                LblError.Text = "Carga correcta";
            }
            catch (Exception)
            {

                LblError.Text = "Debe ingresar una cantidad expresada en numeros de personas a cargar";
            }
        }

        private void BtErrores_Click(object sender, EventArgs e)
        {
            LblError.Text = null;
        }

        private void BtFinalizar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
