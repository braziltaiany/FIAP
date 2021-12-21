using System;
using System.Windows.Forms;

namespace LivrariaHeranca
{
    public partial class Form1 : Form
    {
        Livro liv = new Livro();
        CD cd = new CD();
        DVD dvd = new DVD();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            liv.descricao = txtDesc.Text;
            liv.autor = txtAutor.Text;
            liv.edicao = txtEdicao.Text;
            liv.editora = txtEditora.Text;
            liv.estoqueDisponivel = int.Parse(txtEstoque.Text);
            liv.genero = txtGenero.Text;
            liv.precoCusto = double.Parse(txtPreco.Text);

            MessageBox.Show("Livro cadastrado com sucesso!");
        }

        private void BtnCadastrarCD_Click(object sender, EventArgs e)
        {
            cd.artista = txtArtista.Text;
            cd.gravadora = txtGravadora.Text;
            cd.paisOrigem = txtOrigem.Text;
            cd.descricao = txtDesc.Text;
            cd.estoqueDisponivel = int.Parse(txtEstoque.Text);
            cd.genero = txtGenero.Text;
            cd.precoCusto = double.Parse(txtPreco.Text);

            MessageBox.Show("CD cadastrado com sucesso!");
        }

        private void btnCadastrarDVD_Click(object sender, EventArgs e)
        {
            dvd.diretor = txtDiretor.Text;
            dvd.duracao = txtDuracao.Text;
            dvd.censura = txtCensura.Text;
            dvd.descricao = txtDesc.Text;
            dvd.estoqueDisponivel = int.Parse(txtEstoque.Text);
            dvd.genero = txtGenero.Text;
            dvd.precoCusto = double.Parse(txtPreco.Text);

            MessageBox.Show("CD cadastrado com sucesso!");
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(txtCompraVenda.Text);
            liv.comprar(quantidade);

            MessageBox.Show("Compra de livro confirmada!");
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(txtCompraVenda.Text);
            liv.vender(quantidade);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            liv.listarProduto();
        }
        private void btnComprarCD_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(txtCompraVenda.Text);
            cd.comprar(quantidade);

            MessageBox.Show("Compra de CD confirmada!");
        }
        private void btnComprarDVD_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(txtCompraVenda.Text);
            dvd.comprar(quantidade);

            MessageBox.Show("Compra de DVD confirmada!");
        }

        private void btnVenderCD_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(txtCompraVenda.Text);
            cd.vender(quantidade);

            MessageBox.Show("Venda de CD confirmada!");
        }

        private void btnVenderDVD_Click(object sender, EventArgs e)
        {
            int quantidade = int.Parse(txtCompraVenda.Text);
            dvd.vender(quantidade);

            MessageBox.Show("Venda de DVD confirmada!");
        }

        private void btnListarCD_Click(object sender, EventArgs e)
        {
            cd.listarProduto();
        }

        private void btnListarDVD_Click(object sender, EventArgs e)
        {
            dvd.listarProduto();
        }
    }
}
