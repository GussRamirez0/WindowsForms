namespace Calculadora_de_Combustible
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2;
            if (!double.TryParse(txtDistanciaRecorrida.Text, out num1) || !double.TryParse(txtRendimiento.Text, out num2))
            {
                return;
            }

            txtresult.Text = (num1 / num2).ToString();
        }
    }
}