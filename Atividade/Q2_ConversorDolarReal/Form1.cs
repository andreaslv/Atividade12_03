namespace Q2_ConversorDolarReal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double R, D, cotacao;

            cotacao = Convert.ToDouble(txtCotacao.Text);

            D = Convert.ToDouble(txtDolares.Text);

            R = D * cotacao;

            lblResultado.Text = "R$" + R.ToString();

        }
    }
}
