using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viagem
{
    class Custos
    {
        public double totalPercurso { get; set; }

        public Custos()
        {
            this.totalPercurso = 0;
        }
        public void calcularViagem(Percurso p)
        {
            totalPercurso = p.valorCombustivel + p.valorPedagio;
        }
    }
}
