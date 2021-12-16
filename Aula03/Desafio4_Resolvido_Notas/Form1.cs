using System;
using System.Windows.Forms;

namespace Desafio4_Resolvido_Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            frmMedia fMedia = frmMedia();
            fMedia.Show();
            this.Hide();
        }
    }
}
