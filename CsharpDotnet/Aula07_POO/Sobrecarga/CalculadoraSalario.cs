namespace Sobrecarga
{
    class CalculadoraSalario
    {
        public double valorHora { get; set; }
        public double qtdeHora { get; set; }

        public CalculadoraSalario()
        {
            this.valorHora = 0;
            this.qtdeHora = 0;
        }

        public double CalcularSalario()
        {
            return this.valorHora * this.qtdeHora;
        }
        public double CalcularSalario(double cotacaoDolar)
        {
            return (this.valorHora * this.qtdeHora) * cotacaoDolar;
        }
    }
}
