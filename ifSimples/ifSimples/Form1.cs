using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            byte idade;

            idade = Convert.ToByte(textIdade.Text);

            if(idade >= 12)
            {
                MessageBox.Show("Você pode jogar! 😀", "Jogo - Contra as Drogas",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
    }
}
