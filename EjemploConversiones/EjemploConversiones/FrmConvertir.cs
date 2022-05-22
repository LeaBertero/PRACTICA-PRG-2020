using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploConversiones
{
    public partial class FrmConvertir : Form
    {
        public FrmConvertir()
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
                decimal numero1 = System.Convert.ToDecimal(TxtNum1.Text);
                decimal numero2 = System.Convert.ToDecimal(TxtNum2.Text);

                decimal resultado = numero1 + numero2;

                LblRes.Text = resultado.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Error fatal");
            }
            
        }

        
    }
}
