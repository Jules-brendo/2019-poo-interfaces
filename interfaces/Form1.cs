using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array
{
    public partial class Form1 : Form
    {
        private Conta[] c;
        private int numeroDeContas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // criando o array para guardar as contas
            c = new Conta[10];

            //Conta c1 = new Conta();
            Conta c1 = new ContaPoupanca();
            c1.Titular = new Cliente("victor");
            c1.Numero = 1;
            this.AdicionaConta(c1);

            Conta c2 = new ContaPoupanca();
            c2.Titular = new Cliente("mauricio");
            c2.Numero = 2;
            this.AdicionaConta(c2);

            Conta c3 = new ContaCorrente();
            c3.Titular = new Cliente("osni");
            c3.Numero = 3;
            this.AdicionaConta(c3);

            //foreach (Conta conta in c)
            // {
            //  comboContas.Items.Add(conta.Titular.Nome);
            // comboDestinoTransferencia.Items.Add(conta.Titular.Nome);
            //}
            

        }
        public void AdicionaConta(Conta c)
        {
            Conta[] novo = new Conta[this.numeroDeContas * 2];
            if (this.numeroDeContas == this.c.Length)
            {
                for (int i = 0; i < this.numeroDeContas; i++)
                {
                    novo[i] = this.c[i];
                }

            }
            this.c[this.numeroDeContas] = c;
            this.numeroDeContas++;
            comboContas.Items.Add("titular: " + c.Titular.Nome);
        }

        
        private void BotaoBusca_Click(object sender, EventArgs e)
        {
            //int indice = Convert.ToInt32(textoIndice.Text);
            int indice = comboDestinoTransferencia.SelectedIndex;

            Conta selecionada = this.c[indice];

            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void BotaoDeposito_Click(object sender, EventArgs e)
        {
            // primeiro precisamos recuperar o índice da conta selecionada
            int indice = comboContas.SelectedIndex;

            //int indice = Convert.ToInt32(textoIndice.Text);

            // e depois precisamos ler a posição correta do array.
            Conta selecionada = this.c[indice];

            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Deposita(valor);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void BotaoSaque_Click(object sender, EventArgs e)
        {
            //int indice = Convert.ToInt32(textoIndice.Text);
            int indice = comboContas.SelectedIndex;

            Conta selecionada = this.c[indice];

            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Saca(valor);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void ComboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int indice = comboContas.SelectedIndex;
            Conta selecionada = c[indice];
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            textoNumero.Text = Convert.ToString(selecionada.Numero);

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            int indiceOrigem = comboContas.SelectedIndex;
            Conta contaOrigem = this.c[indiceOrigem];
            
            int indiceDaContaDestino = comboDestinoTransferencia.SelectedIndex;
            Conta contaDestino = this.c[indiceDaContaDestino];
           
            double valorTransferencia = Convert.ToDouble(textoValor.Text);
            
            contaOrigem.Transfere(contaDestino, valorTransferencia);

        }

        private void TextoIndice_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboDestinoTransferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboDestinoTransferencia.SelectedIndex;
            Conta selecionadaDestinoTransferencia = c[indice];
        }

        private void BotaoNovaConta_Click(object sender, EventArgs e)
        {

            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog();
        }

        private void BotaoImpostos_Click(object sender, EventArgs e)
        {
            //questão 7
            ContaCorrente conta = new ContaCorrente();
            conta.Deposita(200.0);

            SeguroDeVida sv = new SeguroDeVida();

            TotalizadorDeTributos totalizador = new TotalizadorDeTributos();
            totalizador.Acumula(conta);
            MessageBox.Show("Total: " + totalizador.Total);

            totalizador.Acumula(sv);
            MessageBox.Show("Total: " + totalizador.Total);

            //questão 6
            //ContaCorrente conta = new ContaCorrente();
            //conta.Deposita(200.0);

            //MessageBox.Show("imposto da conta corrente = " + conta.CalculaTributo());
            //ITributavel t = conta;

            //MessageBox.Show("imposto da conta pela interface = " + t.CalculaTributo());

            //SeguroDeVida sv = new SeguroDeVida();
            //MessageBox.Show("imposto do seguro = " + sv.CalculaTributo());

            //t = sv;
            //MessageBox.Show("imposto do seguro pela interface" + t.CalculaTributo());
        }
    }
}
