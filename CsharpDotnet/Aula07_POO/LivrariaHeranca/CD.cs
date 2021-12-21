using System.Windows.Forms;

namespace LivrariaHeranca
{
    public class CD : Produto
    {
        public string artista { get; set; }
        public string gravadora { get; set; }
        public string paisOrigem { get; set; }
        public CD()
        {
            artista = "";
            gravadora = "";
            paisOrigem = "";
            genero = "";
            descricao = "";
            estoqueDisponivel = 0;
            precoCusto = 0;
        }

        public CD(string artista, string gravadora, string paisOrigem, string descricao, string genero, int estoqueDisponivel, double precoCusto)
            : base(descricao, genero, estoqueDisponivel, precoCusto)
        {
            this.artista = artista;
            this.gravadora = gravadora;
            this.paisOrigem = paisOrigem;
        }
        
        public void listarProduto()
        {
            MessageBox.Show($"Dados do CD cadastrado:\n\n" +
                $"Descrição: {descricao}\n" +
                $"Gênero: {genero}\n" +
                $"Estoque: {estoqueDisponivel}\n" +
                $"Preço de custo: {precoCusto:f2}\n" +
                $"Autor: {artista}\n" +
                $"Editora: {gravadora}\n" +
                $"Edição: {paisOrigem}\n");
        }
    }
}
