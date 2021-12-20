using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora
    {
        //atributos
        public double n1 { get; set; }
        public double n2 { get; set; }
        public double resultado { get; set; }

        //construtor
        public Calculadora()
        {
            this.n1 = 0;
            this.n2 = 0;
            this.resultado = 0;
        }

        public void somar()
        {
            resultado = n1 + n2;
        }
        public void subtrair()
        {
            resultado = n1 - n2;
        }
        public void multiplicar()
        {
            resultado = n1 * n2;
        }
        public void dividir()
        {
            resultado = n1 / n2;
        }

    }
}
