using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Desafio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double[] notas = new double[5];
            double media, somaNotas = 0;

            for(int i = 0; i < notas.Length; i++)
            {
                notas[i] = double.Parse(Interaction.InputBox($"Digite a nota{i + 1}"));
                somaNotas = somaNotas + notas[i];
            }

            media = somaNotas / notas.Length;
            MessageBox.Show($"Media da turma: {media.ToString("F2")}");
        }
    }
}
