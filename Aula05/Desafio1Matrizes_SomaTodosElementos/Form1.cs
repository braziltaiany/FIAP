using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Desafio1Matrizes_SomaTodosElementos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            int[,] numeros = new int[2, 2];
            int soma = 0;
            
            for(int linha = 0; linha < 2; linha++)
            {
                for(int coluna =0; coluna < 2; coluna++)
                {
                    numeros[linha, coluna] = int.Parse(
                        Interaction.InputBox($"Digite o elemento na posição{linha},{coluna} da matriz"));                   
                }
            }

            for (int linha = 0; linha < 2; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    soma = soma + numeros[linha, coluna];
                }
            }
          

            MessageBox.Show($"A soma total dos elementos é: {soma}");
            
            
        }
    }
}
