using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            Calculadora calc = new Calculadora();
            calc.n1 = double.Parse(txtN1.Text);
            calc.n2 = double.Parse(txtN2.Text);

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
