using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafiosDia2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota, nota2, nota3, media;
            string mensagem;
            MessageBoxIcon teste;

            nota = Convert.ToDouble(textNota1.Text);
            nota2 = Convert.ToDouble(textNota2.Text);
            nota3 = Convert.ToDouble(textNota3.Text);

            media = (nota + nota2 + nota3) / 3;

            if (media < 4)
            {
                mensagem = "Reprovado";
                teste = MessageBoxIcon.Error;
            }
            else if (media < 7)
            {
                mensagem = "Em prova final";
                teste = MessageBoxIcon.Warning;
            }
            else
            {
                mensagem = "Aprovado";
                teste = MessageBoxIcon.Information;
            }

            MessageBox.Show(mensagem, "Média final do aluno", MessageBoxButtons.OK, teste);
        }
    }
}
