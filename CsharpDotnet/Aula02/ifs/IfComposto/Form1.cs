using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfComposto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInvestimento_Click(object sender, EventArgs e)
        {
            double investir, doacao;

            doacao = Convert.ToDouble(textDoacao.Text);

            if(doacao <= 1000)
            {
                investir = doacao * 0.05;
            }
            else
            {
                investir = doacao * 0.15;
            }

            MessageBox.Show($"O valor do investimento deverá ser de R$ {investir.ToString("F2")}",
                "Doação - ONG", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
