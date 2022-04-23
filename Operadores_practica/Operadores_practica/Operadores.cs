using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operadores_practica
{
    public partial class Operadores : Form
    {
        
        //int variable = 0;
        //bool resultado;

        int sumador = 0;
        
        public Operadores()
        {
            InitializeComponent();
           
        }


        //si la variable numero es cero la operacion logica es false
        //Si la variable numero es distinto de 0 es true


        private void BtnEjecutar_Click(object sender, EventArgs e)
        {

            //numero++;
            //LblContador.Text = Convert.ToString(numero);
            
            ++sumador;
            LblContador.Text = Convert.ToString(sumador);

            //LblContador.Visible = true;

            //variable = ++numero;
            //LblContador.Text = (variable).ToString();

            //variable = numero++;
            //LblContador.Text = (variable).ToString();

        }

        private void Bt_op_log_Click(object sender, EventArgs e)
        {
            bool resultado;

            resultado = sumador == 0;

            LblResultado.Text = resultado.ToString();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtCorto_Click(object sender, EventArgs e)
        {

            bool resultado;
            int numerador = 10;
            int Divisor = 2;

            resultado = (Divisor != 0) & ((numerador / Divisor) > 0);

            LblResOpLog.Text = resultado.ToString();

        }
    }
}



       
