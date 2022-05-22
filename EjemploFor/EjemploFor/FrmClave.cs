using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploFor
{
    public partial class FrmClave : Form
    {
        
        string Clave = "Usuario";

        public FrmClave()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (TxtClave.Text != Clave)
            {
                MessageBox.Show("clave incorrecta");
                TxtClave.Clear();
                TxtClave.Focus();
                return;
            }
            else
            {
                TxtClave.Clear();
                EjemploFor EjemploFor = new EjemploFor();
                EjemploFor.ShowDialog();

            }

            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }




        //private void BtnUsuario_Click(object sender, EventArgs e)
        //{
        //    if (TxtClave.Text != Usuario)
        //    {
        //        MessageBox.Show("Usuario incorrecto");
        //        TxtUsuario.Clear();
        //        TxtUsuario.Focus();
        //        return;
        //    }
        //    else
        //    {
        //        TxtUsuario.Clear();
        //        EjemploFor EjemploFor = new EjemploFor();
        //        EjemploFor.Show();


        //    }

        //}
    }
}         








        




