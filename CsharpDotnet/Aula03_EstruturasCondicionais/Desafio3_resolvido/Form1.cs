using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio3_resolvido
{
    public partial class Form1 : Form
    {
        double saldo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            double valor = 0;

            //valor = double.Parse(textValor.Text); ou com tratamento de erro
            if (!(cmbOpcao.SelectedIndex == 2))//quando a comboBox for igual a "ver saldo" mostre o saldo, mas se for diferente verificar o tryParse
            {
                if (double.TryParse(textValor.Text, out valor) == false)
                {
                    MessageBox.Show("Digite um valor válido!!!");
                    textValor.Clear();
                    textValor.Focus();
                    return;
                }
            }

            switch (cmbOpcao.SelectedIndex)
            {
                case 0:
                    saldo = saldo + valor;
                    MessageBox.Show("Depósito efetuado!");
                    break;
                case 1:
                    saldo = saldo - valor;
                    MessageBox.Show("Saque efetuado!");
                    break;
                case 2:                 
                    MessageBox.Show($"Seu saldo é de R${saldo.ToString("F2")}");
                    break;
                default:                    
                    MessageBox.Show("Digite um valor válido!");
                    break;
            }

        }
    }
}
