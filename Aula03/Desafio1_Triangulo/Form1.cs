using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1_Triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double x, y, z;

            x = double.Parse(textLado1.Text);
            y = double.Parse(textLado2.Text);
            z = double.Parse(textLado3.Text);

            if(x < (y + z) && y < (x + z) && z < (x + y) )
            {
                if( x == y && x == z)
                {
                    MessageBox.Show("Triangulo equilatero");
                }
                else if(x == y || x == z || y == z)
                {
                    MessageBox.Show("Triangulo isosceles");
                }
                else if (x != y && x != z && y != z)
                {
                    MessageBox.Show("Triangulo escaleno");
                }
            }
            else
            {
                MessageBox.Show("Não forma um triangulo");
            }



        }
    }
}
