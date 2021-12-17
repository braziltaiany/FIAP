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

namespace ExibirMatrizTabela
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
            string saida = "";
           
            //ENTRADA
            for (int linha = 0; linha < 3; linha++) //lenght conta 6
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    valores[linha, coluna] = int.Parse(
                        Interaction.InputBox($"Digiteo elemento da posição {linha.ToString()},{coluna.ToString()} da matriz"));
                }
            }
            
            //Exibir uma matriz
            for (int linha = 0; linha < 3; linha++) //lenght conta 6
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    saida = saida + $"{valores[linha, coluna]}\t";
                }
                saida = saida + "\n";
            }

            //SAIDA
            MessageBox.Show(saida);
        }
    }
}
