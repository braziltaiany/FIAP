using System.Windows.Forms;

namespace LivrariaHeranca
{
    public class DVD : Produto
    {
        public string diretor { get; set; }
        public string duracao { get; set; }
        public string censura { get; set; }

        public DVD(string diretor, string duracao, string censura, string descricao, string genero, int estoqueDisponivel, double precoCusto)
            : base(descricao, genero, estoqueDisponivel, precoCusto)
        {
            this.diretor = diretor;
            this.duracao = duracao;
            this.censura = censura;
        }

        public DVD()
        {
            diretor = "";
            duracao = "";
            censura = "";
            genero = "";
            descricao = "";
            estoqueDisponivel = 0;
            precoCusto = 0;
        }
        public void listarProduto()
        {
            MessageBox.Show($"Dados do DVD cadastrado:\n\n" +
                $"Descrição: {descricao}\n" +
                $"Gênero: {genero}\n" +
                $"Estoque: {estoqueDisponivel}\n" +
                $"Preço de custo: {precoCusto:f2}\n" +
                $"Autor: {diretor}\n" +
                $"Editora: {duracao}\n" +
                $"Edição: {censura}\n");
        }
    }
}
