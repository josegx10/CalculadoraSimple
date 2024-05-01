namespace CalculadoraSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtOperacion.Text += "0";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            txtOperacion.Text += "/";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtOperacion.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtOperacion.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtOperacion.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtOperacion.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtOperacion.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtOperacion.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtOperacion.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtOperacion.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtOperacion.Text += "9";
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            txtOperacion.Text += "+";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            txtOperacion.Text += "-";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            txtOperacion.Text += "*";
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (txtOperacion.Text.Length > 0)
            {
                txtOperacion.Text = txtOperacion.Text.Remove(txtOperacion.Text.Length - 1, 1);
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }
    }
}
