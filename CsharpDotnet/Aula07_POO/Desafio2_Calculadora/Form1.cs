using System;
using System.Windows.Forms;

namespace Desafio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calculadora2 calc = new Calculadora2(double.Parse(txtN1.Text), double.Parse(txtN2.Text));
          

            switch (cmbOperacoes.SelectedIndex)
            {
                case 0:
                    calc.somar();
                    break;
                case 1:
                    calc.subtrair();
                    break;
                case 2:
                    calc.multiplicar();
                    break;
                case 3:
                    calc.dividir();
                    break;
                default:
                    MessageBox.Show("selecione uma operação");
                    break;

            }

            lblRes.Text = calc.resultado.ToString();
        }
    }
}
