namespace GradosCelciusAFarenheitViceversa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            TxTemp.Text = null;
            TxRes.Text = null;
        }


        private void BtFar_Click(object sender, EventArgs e)
        {
            double gcentigrados, ct1;
            ct1 = Convert.ToDouble(TxTemp.Text);
            gcentigrados = (ct1 - 32.0) / 1.8;
            TxRes.Text = String.Format("{0:F3}", gcentigrados);
        }
        private void BtCelcius_Click(object sender, EventArgs e)
        {
            double gfarenheit, ct1;
            ct1 = Convert.ToDouble(TxTemp.Text);
            gfarenheit = ct1 * 1.8 + 32.0;
            TxRes.Text = String.Format("{0:F3}", gfarenheit);
        }
    }
}