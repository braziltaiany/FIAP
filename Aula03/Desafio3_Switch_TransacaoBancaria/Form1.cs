using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio3_Switch_TransacaoBancaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double saque, deposito, saldo;

            saldo = 0;


            switch (cmbOperacao.SelectedIndex)
            {
                case 0:
                    deposito = double.Parse(textValor.Text);
                    saldo = saldo + deposito;
                    MessageBox.Show($"Seu deposito é: {deposito} e seu saldo total é: {saldo}");
                    break;
                case 1:
                    saque = double.Parse(textValor.Text);
                    saldo = saldo - saque;
                    MessageBox.Show($"Seu saque foi de: {saque} e seu saldo total é: {saldo}");
                    break;
                case 2:                    
                    saldo = double.Parse(textValor.Text);
                    MessageBox.Show($"Seu saldo é: {saldo}");
                    break;
                default:
                    MessageBox.Show("Escolha uma operação");
                    break;

            }

        }
    }
}
