

namespace Calculadora
{
    public partial class Form1 : Form

    {

        decimal resultado;
        decimal valor;

        private Operacao OperacaoSelecionada {  get; set; }
        private enum Operacao
        {
            soma,
            subtraçao,
            multiplicaçao,
            divisao,

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(",")){
                txtResultado.Text += ",";
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.soma;
            valor = Convert.ToDecimal(txtResultado.Text);
                txtResultado.Text = "";
                lblOperaçao.Text = "+";
        
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.subtraçao;
            valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperaçao.Text = "-";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.multiplicaçao;
            valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperaçao.Text = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.divisao;
            valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperaçao.Text = "/";
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperaçao.Text = "";
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            lblOperaçao.Text = "=";
            switch (OperacaoSelecionada)
            {
                case Operacao.soma:
                    resultado = valor + Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.subtraçao:
                    resultado = valor - Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.multiplicaçao:
                    resultado = valor * Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.divisao:

                    decimal divisor = Convert.ToDecimal(txtResultado.Text);

                    if (divisor == 0)
                    {
                        MessageBox.Show("Não é possível dividir por zero.");
                        return;
                    }
                    
                    resultado = valor / divisor;
                    break;

            }

            txtResultado.Text = Convert.ToString(resultado);
        }
       
    }
}
