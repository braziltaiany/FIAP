using System.Windows.Forms;

namespace LivrariaHeranca
{
    class Livro : Produto
    {
        //atributos especificos da classe livro
        public string autor { get; set; }
        public string editora { get; set; }
        public string edicao { get; set; }

        //construtores        
        public Livro(string autor, string editora, string edicao, string descricao, string genero,
            int estoqueDisponivel, double precoCusto) : base(descricao, genero, estoqueDisponivel, precoCusto)
        {
            this.autor = autor;
            this.editora = editora;
            this.edicao = edicao;
        }
        public Livro()
        {
            this.autor = "";
            this.editora = "";
            this.edicao = "";
            this.descricao = "";
            this.estoqueDisponivel = 0;
            this.precoCusto = 0;

        }

        //METODO
        public void listarProduto()
        {
            MessageBox.Show($"Dados do livro cadastrado:\n\n" +
                $"Descrição: {this.descricao}\n" +
                $"Gênero: {this.genero}\n" +
                $"Estoque: {this.estoqueDisponivel}\n" +
                $"Preço de custo: {this.precoCusto:f2}\n" +
                $"Autor: {this.autor}\n" +
                $"Editora: {this.editora}\n" +
                $"Edição: {this.edicao}\n");
        }
    }
}
