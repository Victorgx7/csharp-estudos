using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsVictorG
{
    public partial class FormCalculadora : Form
    {
      //  ================== VARIÁVEIS DE CLASSE ========================= //
        double primeiroNumero = 0;   // guarda o primeiro número digitado
        string operacao = "";        // guarda a operação: "+", "-", "*" ou "/"
        bool novoNumero = true;      // true = o próximo dígito começa um número novo


        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void AdicionarNumero(string digito)
        {
            if (novoNumero == true || txtVisor.Text == "0")
            {
                txtVisor.Text = digito;      // troca o que está no visor
                novoNumero = false;
            }
            else
            {
                txtVisor.Text = txtVisor.Text + digito;   // coloca o dígito no final
            }
        }

        private void AdicionarVirgula()
        {
            if (novoNumero == true)
            {
                txtVisor.Text = "0,";
                novoNumero = false;
            }
            else if (txtVisor.Text.Contains(",") == false)
            {
                txtVisor.Text = txtVisor.Text + ",";
            }
        }

        private void LimparTudo()
        {
            txtVisor.Text = "0";
            primeiroNumero = 0;
            operacao = "";
            novoNumero = true;
        }

        private void LimparEntrada()
        {
            txtVisor.Text = "0";
            novoNumero = true;
        }

        private void Apagar()
        {
            int tamanho = txtVisor.Text.Length;

            if (tamanho > 1)
            {
                txtVisor.Text = txtVisor.Text.Substring(0, tamanho - 1);
            }
            else
            {
                txtVisor.Text = "0";
            }

            if (txtVisor.Text == "-")
            {
                txtVisor.Text = "0";
            }
        }

        private void InverterSinal()
        {
            bool negativo = txtVisor.Text.StartsWith("-");

            if (txtVisor.Text == "0")
            {
                return;   // zero não tem sinal, então sai do método
            }

            if (negativo == true)
            {
                txtVisor.Text = txtVisor.Text.Substring(1);   // tira o "-" do começo
            }
            else
            {
                txtVisor.Text = "-" + txtVisor.Text;          // coloca o "-" no começo
            }
        }

        private void EscolherOperacao(string simbolo)
        {
            primeiroNumero = double.Parse(txtVisor.Text);   // guarda o que está no visor
            operacao = simbolo;                              // guarda a operação
            novoNumero = true;                               // próximo dígito começa do zero
        }

        private void Calcular()
        {
            if (operacao == "")
            {
                return;   // não tem operação escolhida, então não faz nada
            }

            double segundoNumero = double.Parse(txtVisor.Text);
            double resultado = 0;

            if (operacao == "+")
            {
                resultado = primeiroNumero + segundoNumero;
            }
            else if (operacao == "-")
            {
                resultado = primeiroNumero - segundoNumero;
            }
            else if (operacao == "*")
            {
                resultado = primeiroNumero * segundoNumero;
            }
            else if (operacao == "/")
            {
                if (segundoNumero == 0)
                {
                    MessageBox.Show("Não é possível dividir por zero!");
                    LimparTudo();   // chamando outro método!
                    return;
                }
                resultado = primeiroNumero / segundoNumero;
            }

            txtVisor.Text = resultado.ToString();
            operacao = "";
            novoNumero = true;
        }

        private void FormCalculadora_Load(object sender, System.EventArgs e)
        {
           
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            AdicionarNumero("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AdicionarNumero("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AdicionarNumero("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AdicionarNumero("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AdicionarNumero("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AdicionarNumero("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AdicionarNumero("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AdicionarNumero("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AdicionarNumero("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AdicionarNumero("9");
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            EscolherOperacao("+");
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            EscolherOperacao("-");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            EscolherOperacao("*");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            EscolherOperacao("/");
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            AdicionarVirgula();
        }

        private void btnInverterSinal_Click(object sender, EventArgs e)
        {
            InverterSinal();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            Apagar();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            LimparTudo();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            LimparEntrada();
        }
    }
}
