using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_Swuitch_____Segun_
{
    public partial class Ejercicio_Switch_Segun_ : Form
    {

        decimal numSuma1;
        decimal numSuma2;
        
        decimal numResta1;
        decimal numResta2;
        
        decimal numMult1;
        decimal numMult2;
        
        decimal numDiv1;
        decimal numDiv2;

        decimal ResultadoSuma;
        decimal ResultadoResta;
        decimal ResultadMult;
        decimal ResultadoDiv;


        public Ejercicio_Switch_Segun_()
        {
            InitializeComponent();
        }

        private void BtnRes_Click(object sender, EventArgs e)
        {
            TxtRes.Visible = true;

            if ((TxtSigno.Text) == "+")
            {

                numSuma1 = Convert.ToInt32(TxtOper1.Text);
                
                numSuma2 = Convert.ToInt32(TxtOper2.Text);

                ResultadoSuma = numSuma1 + numSuma2;

                TxtRes.Text = Convert.ToString(ResultadoSuma);

            }
            else
            {
                lblError.Text = "Debe ingresar un signo para operar";
            }

            //MessageBox.Show("debe ingresar un signo de operacion");


            if ((TxtSigno.Text) == "-")
            {

                numResta1 = Convert.ToInt32(TxtOper1.Text);

                numResta2 = Convert.ToInt32(TxtOper2.Text);

                ResultadoResta = numResta1 - numResta2;

                TxtRes.Text = Convert.ToString(ResultadoResta);

            }
            else
            {
                lblError.Text = "Debe ingresar un signo para operar";
            }

            if ((TxtSigno.Text) == "*")
            {

                numMult1 = Convert.ToInt32(TxtOper1.Text);

                numMult2 = Convert.ToInt32(TxtOper2.Text);

                ResultadMult = numMult1 * numMult2;

                TxtRes.Text = Convert.ToString(ResultadMult);

            }
            else
            {
                lblError.Text = "Debe ingresar un signo para operar";
            }

            if ((TxtSigno.Text) == "/")
            {

                numDiv1 = Convert.ToInt32(TxtOper1.Text);

                numDiv2 = Convert.ToInt32(TxtOper2.Text);

                ResultadoDiv = numDiv1 / numDiv2;

                TxtRes.Text = Convert.ToString(ResultadoDiv);

            }
            else
            {
                lblError.Text = "Debe ingresar un signo para operar";
            }
        }

        

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
