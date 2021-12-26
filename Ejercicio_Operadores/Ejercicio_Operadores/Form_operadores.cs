using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Operadores
{
    public partial class Form_operadores : Form
    {
        public Form_operadores()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnRes_Click(object sender, EventArgs e)
        {

            try
            {
                int numero1;
                int numero2;
                int resultado;

                numero1 = Convert.ToInt32(TxtOper1.Text);
                numero2 = Convert.ToInt32(TxtOper2.Text);

                resultado = numero1 + numero2;

                LblRes.Text = (resultado).ToString();
            }
            catch (Exception)
            {
                LblRes.Text = "debe ingresar numeros para sumar";
                
            }
        }

    }
}

        

            


            
            

