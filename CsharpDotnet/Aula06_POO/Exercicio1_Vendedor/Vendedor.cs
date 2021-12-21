namespace Exercicio1_Vendedor
{
    class Vendedor
    {
        //ATRIBUTOS
        public string nome { get; set; }
        public double salarioBase { get; set; }

        //CONSTRUTORES
        //Iniciando com variáveis zeradas e sem parametros
        public Vendedor()
        {
            this.nome = "";
            this.salarioBase = 0;
        }

        //Iniciando com parametros
        public Vendedor(string nome, double salarioBase)
        {
            this.nome = nome;
            this.salarioBase = salarioBase;
        }
        
        //MÉTODOS DA CLASSE
        public double calculoComissao(double valorVendido)
        {
            return valorVendido * 10.00;
        }

    }
}
