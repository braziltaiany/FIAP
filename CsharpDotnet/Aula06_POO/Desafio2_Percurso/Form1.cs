using System;
using System.Windows.Forms;

namespace Viagem
{
    public partial class Form1 : Form
    {
        //Instanciando como globais
        Percurso p = new Percurso();
        Custos c = new Custos();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {           

            p.valorPedagio = double.Parse(txtPedagios.Text);
            p.valorCombustivel = double.Parse(txtVComb.Text);
            p.kmPecorrida = double.Parse(txtKMPecorrida.Text);

            c.calcularViagem(p);

            MessageBox.Show($"O custo total da viagem foi: R${c.totalPercurso.ToString("F2")}");
            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            //Listando os percursos
            p.listarPercurso();
        }
    }
}
