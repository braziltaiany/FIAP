using System.Windows.Forms;

namespace Desafio1_OperacoesBasicas
{
    class Operacoes
    {
        public int entrada1 { get; set; }
        public int entrada2 { get; set; }

        public Operacoes()
        {
            this.entrada1 = entrada1;
            this.entrada2 = entrada2;
        }

        public void Soma()
        {
            MessageBox.Show($"Soma: {this.entrada1 + this.entrada2}");
        }
        public void Subtracao()
        {
            MessageBox.Show($"Subtração: {this.entrada1 - this.entrada2}");
        }
        public void Multiplicacao()
        {
            MessageBox.Show($"Multiplicação: {this.entrada1 * this.entrada2}");
        }
        public void Divisao()
        {
            MessageBox.Show($"Divisão: {this.entrada1 / this.entrada2}");
        }
    }
}
