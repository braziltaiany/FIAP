namespace Exercicio1_Vendedor
{
    class Vendedor
    {
        public string nome { get; set; }
        public double salarioBase { get; set; }

        public Vendedor()
        {
            this.nome = "";
            this.salarioBase = 0;
        }

        public Vendedor(string nome, double salarioBase)
        {
            this.nome = nome;
            this.salarioBase = salarioBase;
        }

        public double calculoComissao(double valorVendido)
        {
            return valorVendido * 10.00;
        }

    }
}
