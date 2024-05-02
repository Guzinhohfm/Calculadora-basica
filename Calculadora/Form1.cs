namespace Calculadora
{
    public partial class Form1 : Form
    {
        private decimal resultado { get; set; }

        private decimal valor { get; set; }

        private Operacao operacaoSelecionada { get; set; }

        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + '0';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + '1';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + '2';
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + '3';
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + '4';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + '5';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + '6';
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + '7';
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + '8';
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + '9';
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.Adicao;
            valor = Convert.ToDecimal(txtResult.Text);
            txtResult.Text = "";

        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.Subtracao;
            valor = Convert.ToDecimal(txtResult.Text);
            txtResult.Text = "";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.Multiplicacao;
            valor = Convert.ToDecimal(txtResult.Text);
            txtResult.Text = "";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            operacaoSelecionada = Operacao.Divisao;
            valor = Convert.ToDecimal(txtResult.Text);
            txtResult.Text = "";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            switch (operacaoSelecionada)
            {
                case Operacao.Adicao:
                    resultado = valor + Convert.ToDecimal(txtResult.Text);

                    break;
                case Operacao.Subtracao:
                    resultado = valor - Convert.ToDecimal(txtResult.Text);
                    break;
                case Operacao.Multiplicacao:
                    resultado = valor * Convert.ToDecimal(txtResult.Text);
                    break;
                case Operacao.Divisao:
                    resultado = valor / Convert.ToDecimal(txtResult.Text);
                    break;

            }

            txtResult.Text = resultado.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }
    }
}
