using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace OperaoesComVetores
{
    public partial class Form1 : Form
    {
        //declaração de array como global
        string[] cores = {"branco", "amarelo", "verde", "preto", "laranja"};
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTamanho_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Seu vetor tem capacidade para {cores.Length.ToString()} elementos");
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();
            Array.Sort(cores);// não utilizar o sort no vetor original, pois uma vez ordenado e ficará ordenado e perderá o original.
            //Array.Reverse(cores);// inverte a ordem original, mas como coloquei o sort primeiro ele colocar em ordem alfabética
            for(int i = 0; i < cores.Length; i++)
            {
                lstResultado.Items.Add(cores[i].ToString());
            }
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();
            
            Array.Reverse(cores);
            
            for (int i = 0; i < cores.Length; i++)
            {
                lstResultado.Items.Add(cores[i].ToString());
            }
        }

        private void btnBuscaBinaria_Click(object sender, EventArgs e)
        {
            //só funciona com listas ordenadas
            //ele vai eliminando e dividindo o total do vetor por 2
            
            lstResultado.Items.Clear();
            
            Array.Sort(cores);
            
            object corEscolhita = "amarelo";//pode receber um valor de qualquer tipo - ser int, double,string,objeto/ desvantagem alto consumo de memória
            
            int indice = Array.BinarySearch(cores, corEscolhita);
            
            if (indice >= 0)
            {
                MessageBox.Show($"Achei o elemento no indice {indice.ToString()}");
            }
            else
            {
                MessageBox.Show("Não achei o elemento");
            }           

        }

        private void btnIndice_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();

            string busca = Interaction.InputBox("Digite uma cor: ");
            int resultado = Array.IndexOf(cores, busca);

            MessageBox.Show($"O indice onde o elemento está é o {resultado.ToString()}");

        }
    }
}
