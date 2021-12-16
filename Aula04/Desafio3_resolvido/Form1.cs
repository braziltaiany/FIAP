using System;
using System.Windows.Forms;

namespace Desafio3_resolvido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPares_Click(object sender, EventArgs e)
        {
            // EXEMPLO 1

            /*double n1, n2, quantidadePares = 0, cont;
            
            lblRes.Text = "";

            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);

            cont = n1 + 1;

            if(n1 < n2)
            {
                do
                {
                    if(cont % 2 == 0)
                    {
                        quantidadePares++;
                    }
                    cont++;

                } while (cont <= n2);
                
                lblRes.Text = quantidadePares.ToString();
            }
            else
            {
                MessageBox.Show(" O primeiro número deve ser menor que o segundo");
            }*/


            int n1, n2, quantidadePares = 0;

            lblRes.Text = "";

            n1 = int.Parse(txtN1.Text);
            n2 = int.Parse(txtN2.Text);

            if (n1 < n2)
            {
                do
                {
                    if (n1 % 2 == 0)
                    {
                        quantidadePares++;
                    }
                    n1++;

                } while (n1 < n2);

                lblRes.Text = quantidadePares.ToString();
            }
            else
            {
                MessageBox.Show(" O primeiro número deve ser menor que o segundo");
            }


        }
    }
}
