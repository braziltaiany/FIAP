using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace MatrizPares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int[,] valores = new int[3, 2]; // 3 linhas e 2 colunas dependendo de como for estruturar a matriz
            int quantidadePares = 0;
            //ENTRADA
            for (int linha = 0; linha < 3; linha++) //lenght conta 6
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    valores[linha, coluna] = int.Parse(
                        Interaction.InputBox($"Digiteo elemento da posição {linha.ToString()},{coluna.ToString()} da matriz"));
                }
            }
            //PECORRENDO UM VETOR
            for (int linha = 0; linha < 3; linha++) //lenght conta 6
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                   if(valores[linha,coluna] % 2 == 0)
                    {
                        quantidadePares++;//==quantidadePares + 1;
                    }
                }
            }

            //SAIDA
            MessageBox.Show($"Quantidade de números pares:{quantidadePares.ToString()}");


        }
    }
}
