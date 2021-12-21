using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria_Heranca
{
    class Livro:Produto
    {
        //atributos especificos da classe livro
        public string autor { get; set; }
        public string editora { get; set; }
        public string edicao { get; set; }

        //construtores
        public Livro()
        {
            this.autor = autor;
            this.editora = editora;
            this.edicao = edicao;
        }

        public Livro(string autor, string editora, string edicao, string descricao, string genero,
            int estoqueDisponivel, double precoCusto) : base(descricao, genero, estoqueDisponivel, precoCusto)
        {
            this.autor = autor;
            this.editora = editora;
            this.edicao = edicao;
        }
        // erro ta aqui
        public Livro()
        {
            this.autor = "";
            this.editora = "";
            this.edicao = "";
            this.descricao = "";
            this.estoqueDisponivel = 0;
            this.precoCusto = 0;

        }
    }
}
