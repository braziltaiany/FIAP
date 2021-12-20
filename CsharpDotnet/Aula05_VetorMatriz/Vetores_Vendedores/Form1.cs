using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vetores_Vendedores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Exemplo 1
            //double v1, v2, v3, v4, v5, total;

            //v1 = double.Parse(txtV1.Text);
            //v2 = double.Parse(txtV2.Text);
            //v3 = double.Parse(txtV3.Text);
            //v4 = double.Parse(txtV4.Text);
            //v5 = double.Parse(txtV5.Text);

            //total = v1 + v2 + v3 + v4 + v5;

            //MessageBox.Show($" Total das vendas: R${total.ToString("F2")}");


            //Exemplo 2

            double total;
            double[] v = new double[5];//vetor definindo tamanho

            v[0] = double.Parse(txtV1.Text);
            v[1] = double.Parse(txtV2.Text);
            v[2] = double.Parse(txtV3.Text);
            v[3] = double.Parse(txtV4.Text);
            v[4] = double.Parse(txtV5.Text);

            total = v[1] + v[2] + v[3] + v[4] + v[0];


            MessageBox.Show($" Total das vendas: R${total.ToString("F2")}");
        }
    }
}
