using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Desafio4_Resolvido_Notas
{
    public partial class frmMedia : Form
    {
        public frmMedia()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, media, freq;
            int assistidas, totalAulas;

            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);
            
            assistidas = int.Parse(txtAssistidas.Text);
            totalAulas = int.Parse(txtTotalAulas.Text);

            media = (n1 + n2) / 2.0;
            freq = ((double) assistidas / (double) totalAulas) * 100.0;

            if (media >= 7.0 && freq >= 75.0)
            {
                lblRes.ForeColor = Color.Blue;
                lblRes.Text = $"Você foi aprovado! 👏  \n \n Média: {media.ToString("F2")} \n Frequência: {freq.ToString("F2")}%";

            }
            else
            {
                lblRes.ForeColor = Color.Red;
                lblRes.Text = $"Você foi reprovado! 😥  \n \n Média: {media.ToString("F2")} \n Frequência: {freq.ToString("F2")}%";
            }
        }
    }
}
