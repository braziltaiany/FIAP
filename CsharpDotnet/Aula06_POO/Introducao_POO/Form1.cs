using System;
using System.Windows.Forms;

namespace IntroducaoOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //instanciar um objeto da classe usuario
            Usuario user = new Usuario();

            //Inserir dsdos nos atributos
            user.nome = txtNome.Text;
            user.email = txtEmail.Text;
            user.login = txtLogin.Text;
            user.senha = txtSenha.Text;


            //executando o método
            user.provarExistencia();
        }
    }
}
