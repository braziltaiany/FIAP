using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Vendedor calcular = new Vendedor();

            lblRes.Text = $"O vendedor(a): {txtNome.Text} \nReceberá com a comissão o total de : R${calcular.calculoComissao(double.Parse(txtSalario.Text)).ToString()}";

        }
    }
}
