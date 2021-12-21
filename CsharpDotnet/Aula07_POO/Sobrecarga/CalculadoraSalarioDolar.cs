namespace Sobrecarga
{
    //SOBRESCRITA
    class CalculadoraSalarioDolar:CalculadoraSalario
    {
        public double cotacao { get; set; }

        public CalculadoraSalarioDolar()
        {
            this.cotacao = 0;
        }

        //PEGANDOO METODO DA CLASSE CALCULADORAALARIO COM PEQUENAS MODIFICAÇOES
        //adicionando override
        public override double CalcularSalario()
        {
            return (this.valorHora * this.qtdeHora) * this.cotacao;
        }
    }
}
