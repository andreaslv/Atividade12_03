namespace Q3_PassagemPorDistancia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double km, preco;

            km = Convert.ToDouble(txtDistancia.Text);

            if (km > 200)

            {

                preco = 0.45;

                lblResultado.Text = preco.ToString();

            }

            else

            {

                preco = 0.50;

                lblResultado.Text = preco.ToString();

            }

        }
    }
}
