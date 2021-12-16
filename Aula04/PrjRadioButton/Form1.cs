using System;
using System.Windows.Forms;

namespace PrjRadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(rdbFem.Checked == true)// == (rdbFem.Checked)
            {
                MessageBox.Show("Selecionado o sexo feminino!");
            }
            else
            {
                MessageBox.Show("Selecionado o sexo masculino!");
            }
        }
    }
}
