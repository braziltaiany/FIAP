using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariaveisNumericas
{
    public partial class Form1 : Form
    {
        //declaração de variável em escopo global
        double n1, n2, res;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            //leitura de valores
            lerValores();

            //cálculo
            res = n1 + n2;

            //saída
            lblRes.Text = res.ToString("F2");
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            lerValores();

            res = n1 - n2;

            lblRes.Text = res.ToString("F2");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            lerValores();

            res = n1 * n2;

            lblRes.Text = res.ToString("F2");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            lerValores();
            res = n1 / n2;

            lblRes.Text = res.ToString("F2");
        }

        private void lerValores()
        {
            n1 = Convert.ToDouble(textNum1.Text);
            n2 = Convert.ToDouble(textNum2.Text);
        }
    }
}
