using System;
using System.Windows.Forms;

namespace Exercicio1_Vendedor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Instanciando objeto com parametro
            Vendedor v = new Vendedor(txtNome.Text, double.Parse(txtSalario.Text));
            
            lblRes.Text = $"Comissão: R${v.calculoComissao(double.Parse(txtVendas.Text))}";
        }
    }
}
