using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Km
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double painel, viagem, total, media, litros;

            painel = Convert.ToDouble(textPainel.Text);
            viagem = Convert.ToDouble(textViagem.Text);
            litros = Convert.ToDouble(textLitros.Text);


            total = viagem - painel;
            media = total / litros;

            lblResultado.Text = media.ToString("F2");
        }
    }
}
