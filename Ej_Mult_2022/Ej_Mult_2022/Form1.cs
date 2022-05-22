namespace Ej_Mult_2022
{
    public partial class Form1 : Form
    {
        double control1, control2;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtLimpiar_Click(object sender, EventArgs e)
        {
            TxOp1.Text = null;
            TxOp2.Text = null;
            TxRes.Text = null;
        }

        private void BtMult_Click(object sender, EventArgs e)
        {
            control1 = Convert.ToDouble(TxOp1.Text);
            control2 = Convert.ToDouble(TxOp2.Text);

            TxRes.Text = String.Format("{0:F2}",control1*control2);
        }
    }
}