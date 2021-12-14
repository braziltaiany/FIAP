using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doacao
{
    public partial class Form1 : Form
    {
        double doacao, dolar, conversao;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConversao_Click(object sender, EventArgs e)
        {
            doacao = Convert.ToDouble(textDoacao.Text);
            dolar = Convert.ToDouble(textDolar.Text);

            conversao = doacao * dolar;

            lblConversao.Text = "R$ " + conversao.ToString("F2");
        }

        
    }
}
