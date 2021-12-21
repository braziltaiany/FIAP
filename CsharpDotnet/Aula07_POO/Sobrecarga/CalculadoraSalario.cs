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

        //virtual: permitindo que o metodo seja subscrito na minha sublasse 
        public virtual double CalcularSalario()
        {
            return this.valorHora * this.qtdeHora;
        }


    }
}
