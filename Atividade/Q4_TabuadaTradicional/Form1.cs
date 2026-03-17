namespace Q4_TabuadaTradicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            int numero, tabuada;
            numero = Convert.ToInt32(txtNumero.Text);

            for (int i = 1; i <= 10; i++)
            {
                tabuada = numero * i;
                lstTabuada.Items.Add($"{numero} X {i} = {tabuada}");
            }
        }
    }
}
