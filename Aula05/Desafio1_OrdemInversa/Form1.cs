using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Desafio1_OrdemInversa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            double[] a = new double[15];
            double[] b = new double[15];
            

            for(int i = 0; i < a.Length; i++)
            {
                a[i] = double.Parse(Interaction.InputBox($"Digite o valor {i + 1}"));
                
                b[(a.Length - 1) - i] = a[i];

            }
            for(int i = 0; i < b.Length; i++)
            {
                lstVetorB.Items.Add(b[i].ToString());
            }
           

        }
    }
}
