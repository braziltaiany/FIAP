using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_Vendedor
{
    class Vendedor
    {
        public string nome { get; set; }
        public double salarioBase { get; set; }

        public Vendedor()
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
