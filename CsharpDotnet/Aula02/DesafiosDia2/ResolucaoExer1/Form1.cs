using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResolucaoExer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, media;
            string situacao;

            n1 = double.Parse(textNota1.Text);
            n2 = double.Parse(textNota2.Text);
            n3 = double.Parse(textNota3.Text);

            media = (n1 + n2 + n3) / 3.0;

            if (media < 4)
            {
                situacao = "Reprovado";
            }
            else if(media < 7)
            {
                situacao = "Em prova final";
            }
            else
            {
                situacao = "Aprovado";
            }

            MessageBox.Show($"Média: {media.ToString("F2")} \n Situação: {situacao}", "Média Escolar", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
