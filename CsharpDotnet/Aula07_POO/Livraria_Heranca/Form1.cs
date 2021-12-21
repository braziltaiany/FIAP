using System;
using System.Windows.Forms;

namespace Livraria_Heranca
{
    public partial class Form1 : Form
    {
        Livro liv = new Livro();
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
    }
}
