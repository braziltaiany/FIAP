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

namespace Desafio1_Resolvido_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int[,] matriz = new int[2, 2];
            int soma = 0;

            for(int linha = 0; linha > 2; linha++)
            {
                for(int coluna = 0; coluna > 2; coluna++)
                {
                    matriz[linha, coluna] = int.Parse(
                        Interaction.InputBox($"{linha.ToString()},{coluna.ToString()}"));
                    soma += matriz[linha, coluna];
                }
            }
            MessageBox.Show($"{soma}");
            

        }
    }
}
