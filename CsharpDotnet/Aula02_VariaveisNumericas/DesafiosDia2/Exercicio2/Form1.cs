using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double saldo, credito;
            string mensagem;
            saldo = Convert.ToDouble(textSaldo.Text);
            
            MessageBoxIcon teste;
            teste = MessageBoxIcon.Information;


            if (saldo >= 0.0 && saldo <= 200.0)
            {
                mensagem = $"Seu saldo médio é {saldo} e você não pussui nenhum crédito";
                teste = MessageBoxIcon.Exclamation;
            }
            else if(saldo >= 201.0 && saldo <= 400.0)
            {
                credito = saldo * 0.20;
                mensagem = $"Seu saldo médio é {saldo} e você tem R$ {credito} crédito";                
            }
            else if (saldo >= 401.0 && saldo <= 600.0)
            {
                credito = saldo * 0.30;
                mensagem = $"Seu saldo médio é {saldo} e você tem R$ {credito} crédito";
            }
            else
            {
                credito = saldo * 0.40;
                mensagem = $"Seu saldo médio é {saldo} e você tem R$ {credito} crédito";
               
            }

            MessageBox.Show(mensagem, "Crédito especial", MessageBoxButtons.OK, teste);
        }
    }
}
