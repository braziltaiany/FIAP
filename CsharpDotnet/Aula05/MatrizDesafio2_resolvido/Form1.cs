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

namespace MatrizDesafio2_resolvido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int[,] matriz = new int[4, 4];
            int soma = 0;
            int media = 0;
            int multiplicar;
            string sMult = "";

            for (int linha =0; linha < 4; linha++)
            {
                for(int coluna = 0; coluna < 4; coluna++)
                {
                    matriz[linha, coluna] = int.Parse(Interaction.InputBox(
                        $"Digite o valor para a posição[{linha},{coluna}] da matriz"));
                
                    if(linha == 0)
                    {
                        soma += matriz[0, coluna];
                    }
                    if (linha == 1)
                    {
                        media += (matriz[1, coluna]);                        
                    }
                    
                    if (linha == 3)
                    {
                        multiplicar = (matriz[2, coluna]) * (matriz[3, coluna]);
                        sMult += multiplicar + " - ";
                    }


                }
                    media = media / 4;
                    MessageBox.Show($"Soma: {soma} \n" +
                        $"Media: {media} \n" +
                        $"Multiplicação:{sMult}")
                    ;

                
            }
        }
    }
}
