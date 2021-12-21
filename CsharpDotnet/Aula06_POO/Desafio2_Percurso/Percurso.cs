using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2_Percurso
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

        }
    }
}
