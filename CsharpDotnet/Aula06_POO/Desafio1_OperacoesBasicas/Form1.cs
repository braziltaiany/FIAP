using System;
using System.Windows.Forms;

namespace Desafio1_OperacoesBasicas
{
    public partial class Form1 : Form
    {
        Operacoes operacoes = new Operacoes();        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            operacoes.entrada1 = int.Parse(txtNum1.Text);
            operacoes.entrada2 = int.Parse(txtNum2.Text);

            operacoes.Soma();
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            operacoes.entrada1 = int.Parse(txtNum1.Text);
            operacoes.entrada2 = int.Parse(txtNum2.Text);

            operacoes.Subtracao();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operacoes.entrada1 = int.Parse(txtNum1.Text);
            operacoes.entrada2 = int.Parse(txtNum2.Text);

            operacoes.Multiplicacao();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            operacoes.entrada1 = int.Parse(txtNum1.Text);
            operacoes.entrada2 = int.Parse(txtNum2.Text);

            operacoes.Divisao();
        }
    }
}
