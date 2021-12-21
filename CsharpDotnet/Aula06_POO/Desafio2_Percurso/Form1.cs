using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio2_Percurso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Percurso p = new Percurso();
            Custos c = new Custos();

            p.valorPedagio = double.Parse(txtPedagios.Text);
            p.valorCombustivel = double.Parse(txtVComb.Text);
            p.kmPecorrida = double.Parse(txtKMPecorrida.Text);

            c.calcularViagem(p);

            MessageBox.Show($"O custo total da viagem foi: R${c.totalPercurso.ToString("F2")}");
            
        }
    }
}
