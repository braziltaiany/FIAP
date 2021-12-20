using System;
using System.Windows.Forms;

namespace Desafio3_doWhile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1, num2, somaPares;

            num1 = int.Parse(txtNum1.Text);
            num2 = int.Parse(txtNum2.Text);

            somaPares = 0;

            if (num1 < num2)
            {
                do
                {
                    if (num1 % 2 == 0)
                    {
                        somaPares++;
                    }
                    num1++;

                } while (num1 <= num2);

                MessageBox.Show($"{somaPares}");
            }
            else
            {
                do
                {
                    if (num2 % 2 == 0)
                    {
                        somaPares++;
                    }
                    num2++;

                } while (num2 <= num1);

                MessageBox.Show($"{somaPares}");
            }

        }
    }
}


