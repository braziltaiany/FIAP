using System.Windows.Forms;

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
