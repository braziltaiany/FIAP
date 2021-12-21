using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Viagem
{
    class Percurso
    {
        public double kmPecorrida { get; set; }
        public double valorPedagio { get; set; }
        public double valorCombustivel { get; set; }

        public Percurso(double kmPecorrida, double valorPedagio, double valorCombustivel)
        {
            this.kmPecorrida = kmPecorrida;
            this.valorPedagio = valorPedagio;
            this.valorCombustivel = valorCombustivel;
        }
        public Percurso()
        {
            this.kmPecorrida = 0;
            this.valorPedagio = 0;
            this.valorCombustivel = 0;
        }
        public void cadastrarPercurso()
        {
            //adcionando o cadastro do percurso e inutilizando os campos do formulário
            this.kmPecorrida = double.Parse(Interaction.InputBox("Digite a km percorrida"));
            this.valorCombustivel = double.Parse(Interaction.InputBox("Digite o valor do combustivel"));
            this.valorPedagio = double.Parse(Interaction.InputBox("Digite o valor do pedagio"));

            MessageBox.Show("Percurso cadastrado");
        }
        public void listarPercurso()
        {
            MessageBox.Show($"Dados do percurso cadastrado: \n\n" +
                $"KM Pecorrida {this.kmPecorrida.ToString()}\n" +
                $"Pedágios: R${this.valorPedagio.ToString("F2")}\n" +
                $"Combustível: R${this.valorCombustivel.ToString("F2")}\n");
        }
    }
}
