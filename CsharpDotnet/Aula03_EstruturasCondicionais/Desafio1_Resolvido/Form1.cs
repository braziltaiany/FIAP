using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1_Resolvido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int lado1, lado2, lado3;
            string mensagem;

            lado1 = int.Parse(textLado1.Text);
            lado2 = int.Parse(textLado2.Text);
            lado3 = int.Parse(textLado3.Text);

            if (lado1 < (lado2 + lado3) && lado2 < (lado1 + lado3) && lado3 < (lado2 + lado1))
            {
                if(lado1 == lado2 && lado1 == lado3)
                {
                    mensagem = "Equilátero";
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    mensagem = "Isósceles";
                }
                else
                {
                    mensagem = "Escaleno";
                }
                
                MessageBox.Show($"O triangulo é: {mensagem}", "Triângulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("🚨 Não forma um triângulo!!", "Não forma um triângulo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
