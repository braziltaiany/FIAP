using System;
using System.Windows.Forms;

namespace Desafio1_resolvido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num, fat = 1, cont = 1;

            num = int.Parse(txtNum.Text);

            while(cont <= num)
            {
                fat = fat * cont;
                cont++;
            }
            
            lblFatorial.Text = fat.ToString();

        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            //EXEMPLO 1
            //int num, fat = 1, cont;

            //num = int.Parse(txtNum.Text);
            //cont = num;

            //while (cont >= 1)//(cont != 1) nesse caso que é multiplicação não interfere ou (cont > 1) pra n dar volta atoa
            //{
            //    fat = fat * cont;
            //    cont--;
            //}

            //lblFatorial.Text = fat.ToString();

            //EXEMPLO 2
            int num, fat = 1;

            num = int.Parse(txtNum.Text);            

            while (num > 1)
            {
                fat = fat * num;
                num--;
            }

            lblFatorial.Text = fat.ToString();
        }
    }
}
