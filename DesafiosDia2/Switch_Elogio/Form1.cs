using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Elogio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            byte codigo;

            if(byte.TryParse(textCodigo.Text, out codigo)== false)
            {
                MessageBox.Show("Digite um código válido");
                textCodigo.Clear();
                textCodigo.Focus();
                return;
            }

            switch (codigo)
            {
                case 1:
                    MessageBox.Show("Elogio profissional");
                    break;
                case 2:
                    MessageBox.Show("Elogio Físico");
                    break;
                case 3:
                    MessageBox.Show("Elogio Pessoal");
                    break;
                default:
                    MessageBox.Show("Coloque um código válido");
                    break;

            }
        }
    }
}
