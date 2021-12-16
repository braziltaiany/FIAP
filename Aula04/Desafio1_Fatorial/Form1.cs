using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio1_Fatorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFatorial_Click(object sender, EventArgs e)
        {
            int num,fatorial, cont;                      

            num = int.Parse(txtNum.Text);
            cont = 1;            
            fatorial = 1;
            

            while(cont < num)
            {
                fatorial += fatorial * cont;                
                cont++;                
            }
            
            MessageBox.Show($"{fatorial}");           


        }
    }
}
