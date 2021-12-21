using System.Windows.Forms;

namespace LivrariaHeranca
{
    public class Produto
    {
        public string descricao { get; set; }
        public string genero { get; set; }
        public int estoqueDisponivel { get; set; }
        public double precoCusto { get; set; }

        public Produto(string descricao, string genero, int estoqueDisponivel, double precoCusto)
        {
            this.descricao = descricao;
            this.genero = genero;
            this.estoqueDisponivel = estoqueDisponivel;
            this.precoCusto = precoCusto;
        }
        public Produto()
        {
            descricao = "";
            genero = "";
            estoqueDisponivel = 0;
            precoCusto = 0;
        }

        public void comprar(int quantidade)
        {
            estoqueDisponivel += quantidade;
        }
        public void vender(int quantidade)
        {

            if (quantidade > estoqueDisponivel)
            {
                MessageBox.Show("Quantidade em estoque indisponivel \nVenda cancelada");
            }
            else
            {
                estoqueDisponivel -= quantidade;
                MessageBox.Show("Venda de livro confirmada!");
            }
        }
    }
}
