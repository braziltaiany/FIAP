using System.Windows.Forms;

namespace IntroducaoOO
{
    public class Usuario
    {
        //Atributos
        public string nome { get; set; }
        public string email { get; set; }
        public string login { get; set; }
        public string senha { get; set; }        

        //CONSTRUTOR
        //Método que é executado quando um objeto é instanciado
        public Usuario()
        {
            this.nome = "";
            this.email = "";
            this.login = "";
            this.senha = "";
        }

        public void provarExistencia()
        {
            MessageBox.Show($"Bem vindo {this.nome}!");
        }
    }
}
