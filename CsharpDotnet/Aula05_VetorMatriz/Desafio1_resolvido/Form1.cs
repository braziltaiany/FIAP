using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Desafio1_resolvido
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
            double[] a = new double[15];
            double[] b = new double[15];
            int i2 = a.Length - 1;

            for(int i = 0; i < a.Length; i++)
            {
                a[i] = double.Parse(Interaction.InputBox($"Digite o numero {(i+1)}"));
                b[i2] = a[i];
                i2--;

            }
            for (int i = 0; i < b.Length; i++)
            {
                lslVetorB.Items.Add(b[i].ToString());
            }
        }
    }
}
