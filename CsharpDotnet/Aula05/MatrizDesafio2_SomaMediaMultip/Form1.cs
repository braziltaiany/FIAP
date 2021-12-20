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

namespace MatrizDesafio2_SomaMediaMultip
{
    public partial class Form1 : Form
    {
        int[,] numeros = new int[4, 4];

        public Form1()
        {
            InitializeComponent();
        }
        private void btnMatriz_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();

            for (int linha = 0; linha < 4; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    numeros[linha, coluna] = int.Parse(
                        Interaction.InputBox($"Digite o elemento na posição{linha},{coluna} da matriz"));
                }
            }

            for (int linha = 0; linha < 4; linha++) //lenght conta 6
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    lstResultado.Items.Add($"{numeros[linha, coluna]}");
                }
            }
        }
        private void btnSoma_Click(object sender, EventArgs e)
        {
            int soma = 0;

            for (int coluna = 0; coluna < 4; coluna++)
            {
                numeros[0, coluna] = int.Parse(
                    Interaction.InputBox($"Digite o elemento na posição{0},{coluna} da matriz"));

                soma = soma + numeros[0, coluna];
            }

            MessageBox.Show($"A soma total dos elementos da primeira linha é: {soma}");
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double media, soma = 0;

            lstResultado.Items.Clear();

            for (int coluna = 0; coluna < 4; coluna++)
            {
                numeros[1, coluna] = int.Parse(
                    Interaction.InputBox($"Digite o elemento{1},{coluna} da matriz"));
                soma = (double)soma + numeros[1, coluna];
            }

            media = (double)soma / 4.0;

            lstResultado.Items.Add($"Soma total dos elementos da segunda linha é: {soma}");
            lstResultado.Items.Add($"A media da segunda linha é: {media.ToString("F2")}");
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();

            int multip, a, b;

            for (int linha = 0; linha < 4; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    numeros[linha, coluna] = int.Parse(
                    Interaction.InputBox($"Digite o elemento{linha},{coluna} da matriz"));
                    
                    if (linha == 2 || linha == 3)
                    {
                        a = numeros[2, coluna];
                        b = numeros[3, coluna];

                        multip = a * b;
                        lstResultado.Items.Add($"{a} X {b} = {multip}");
                        
                    }
                }
            }
        }
    }
}
