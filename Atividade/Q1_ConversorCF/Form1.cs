namespace Q1_ConversorCF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            int celsius, fahrenheit;

            celsius = Convert.ToInt32(txtCelsius.Text);

            fahrenheit = (celsius * 9 / 5) + 32;

            lblResultado.Text = fahrenheit.ToString();

        }
    }
}
