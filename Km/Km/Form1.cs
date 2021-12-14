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
            double painel, viagem, media, litros;

            painel = Convert.ToDouble(textPainel.Text);
            viagem = Convert.ToDouble(textViagem.Text);
            litros = Convert.ToDouble(textLitros.Text);

            media = (viagem - painel) / litros;

            lblResultado.Text = $" A autonomia deste veículo é de {media.ToString("F2")} km por litro";
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
