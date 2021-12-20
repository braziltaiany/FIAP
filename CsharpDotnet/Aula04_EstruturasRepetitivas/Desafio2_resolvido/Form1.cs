using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio2_resolvido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int n1, n2, soma, cont;

            soma = 0;

            n1 = int.Parse(txtN1.Text);
            n2 = int.Parse(txtN2.Text);

            lblRes.Text = " ";

            // Exemplo 1 - incluindo extremos
            //cont = n1;

            if (n1 < n2)
            {
                //while(cont <= n2)
                //{
                //    soma = soma + cont;
                //} ou pelo for
                
                for(cont = n1; cont <= n2; cont++)//(cont = n1; cont < n2; cont++) sem pegar a ultima extremidade
                {
                    soma = soma + cont;
                }
                lblRes.Text = soma.ToString();

            }
            else
            {
                MessageBox.Show("O primeiro número deve ser menor que o segundo!");
            }
        }
    }
}
