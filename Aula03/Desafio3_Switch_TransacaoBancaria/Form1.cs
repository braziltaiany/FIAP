using System;
using System.Windows.Forms;

namespace Desafio3_Switch_TransacaoBancaria
{
    public partial class Form1 : Form
    {
        double saldo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double valor;

            valor = double.Parse(textValor.Text);

            switch (cmbOperacao.SelectedIndex)
            {
                case 0:
                    saldo = saldo + valor;
                    MessageBox.Show("Seu deposito foi efetuado");
                    break;
                case 1:                    
                    saldo = saldo - valor;
                    MessageBox.Show("Seu saque foi efetuado");
                    break;
                case 2:
                    MessageBox.Show($"Seu saldo é: {saldo}");
                    break;
                default:
                    MessageBox.Show("Escolha uma operação");
                    break;

            }

        }
    }
}
