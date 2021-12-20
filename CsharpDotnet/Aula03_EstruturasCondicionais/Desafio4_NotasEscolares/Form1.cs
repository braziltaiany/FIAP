using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio4_NotasEscolares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double media, nota1, nota2, frequencia, aulasDadas, aulasAssistidas;   

            nota1 = double.Parse(textNota1.Text);
            nota2 = double.Parse(textNota2.Text);
            aulasAssistidas = double.Parse(textAulasAssistidas.Text);
            aulasDadas = double.Parse(textAulasDadas.Text);     

            media = (nota1 + nota2) / 2.0;
            frequencia =  (aulasAssistidas / aulasDadas) * 100.0;
            
            if(media >= 7.0 && frequencia >= 75.0)
            {
                MessageBox.Show($"Você foi aprovado! 👏  \n \n Média: {media.ToString("F2")} \n Frequência: {frequencia.ToString("F2")}%");
            }
            else
            {
                MessageBox.Show($"Você foi reprovado! 😥  \n \n Média: {media.ToString("F2")} \n Frequência: {frequencia.ToString("F2")}%");
            }



        }
    }
}
