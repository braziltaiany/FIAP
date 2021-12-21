using System;
using System.Windows.Forms;

namespace Sobrecarga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {            
            CalculadoraSalario cs = new CalculadoraSalario();
            double cotacao = double.Parse(txtDolar.Text);            
            cs.valorHora= double.Parse(txtHora.Text);
            cs.qtdeHora = double.Parse(txtTotalHoras.Text);
            
            CalculadoraSalarioDolar csDolar = new CalculadoraSalarioDolar();
            csDolar.valorHora = double.Parse(txtHora.Text);
            csDolar.qtdeHora = double.Parse(txtTotalHoras.Text);
            csDolar.cotacao = double.Parse(txtDolar.Text);

            if (cotacao == 0)
            {
                MessageBox.Show($"Total a recerber: R${cs.CalcularSalario():f2}");
            }
            else
            {
                MessageBox.Show($"Total a recerber: R${csDolar.CalcularSalario():f2}");
            }
        }
    }
}
