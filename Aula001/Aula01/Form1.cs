using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula01
{
    public partial class frmAula01 : Form
    {
        public frmAula01()
        {
            InitializeComponent();
        }

        private void btnBoasVindas_Click(object sender, EventArgs e)
        {
            string nomeUsuario;// Declaração de variavel do tipo string

            nomeUsuario = textNome.Text; // coloca nome do usuario dentro da variavel

            MessageBox.Show("Bem vindo ao C# " + nomeUsuario, "Olá", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblMensagem.Text = "Bem vindo ao C# " + nomeUsuario;
            
            //MessageBox.Show($"Bem vindo ao C#  {nomeUsuario}", "Olá", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //lblMensagem.Text = $"Bem vindo ao C#  {nomeUsuario}";


        }
    }
}
