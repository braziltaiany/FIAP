using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LacosRepeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTabuada_Click(object sender, EventArgs e)
        {
            //lstTabuada.Items.Clear(); //utilizado para limpar a lit box
            int num, res;
            num = int.Parse(txtNum.Text);

            //Exemplo1

            res = num * 1;
            lstTabuada.Items.Add(res.ToString()); // Inserindo valor a list box
           
            res = num * 2;
            lstTabuada.Items.Add(res.ToString());
            
            res = num * 3;
            lstTabuada.Items.Add(res.ToString());
            
            res = num * 4;
            lstTabuada.Items.Add(res.ToString());
            
            res = num * 5;
            lstTabuada.Items.Add(res.ToString());
            
            res = num * 6;
            lstTabuada.Items.Add(res.ToString());
            
            res = num * 7;
            lstTabuada.Items.Add(res.ToString());
            
            res = num * 8;
            lstTabuada.Items.Add(res.ToString());
            
            res = num * 9;
            lstTabuada.Items.Add(res.ToString());
            
            res = num * 10;
            lstTabuada.Items.Add(res.ToString());
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            lstTabuada.Items.Clear(); //utilizado para limpar a lit box
            int num, res;
            int cont = 1;

            num = int.Parse(txtNum.Text);

            //Exemplo 2

            while (cont <= 10)
            {
                res = num * cont;
                lstTabuada.Items.Add(res.ToString());
                cont++; //adicionando 1 ao contador
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            lstTabuada.Items.Clear(); //utilizado para limpar a lit box
            int num, res;
            int cont = 1;

            num = int.Parse(txtNum.Text);

            //Exemplo 3
            //DoWhile ele faz por pelo menos uma vez
            do
            {
                res = num * cont;
                lstTabuada.Items.Add(res.ToString());
                cont++; //adicionando 1 ao contador
            } 
            while (cont <= 10);
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            lstTabuada.Items.Clear(); //utilizado para limpar a lit box
            int num, res, cont;          

            num = int.Parse(txtNum.Text);
            
            for (cont = 1; cont <= 10; cont++)
            {
                res = num * cont;
                lstTabuada.Items.Add(res.ToString());                 
            }

        }
    }
}
