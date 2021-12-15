using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio2_Switch_MesAno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {
            switch (cmbMes.SelectedIndex)
            {
                case 0:
                    MessageBox.Show($"Você selecionou o {cmbMes.SelectedItem.ToString()}");
                    break;
                case 1:
                    MessageBox.Show($"Você selecionou o {cmbMes.SelectedItem.ToString()}");
                    break;
                case 2:
                    MessageBox.Show($"Você selecionou o {cmbMes.SelectedItem.ToString()}");
                    break;
                case 3:
                    MessageBox.Show($"Você selecionou o {cmbMes.SelectedItem.ToString()}");
                    break;
                case 4:
                    MessageBox.Show($"Você selecionou o {cmbMes.SelectedItem.ToString()}");
                    break;
                case 5:
                    MessageBox.Show($"Você selecionou o {cmbMes.SelectedItem.ToString()}");
                    break;
                case 6:
                    MessageBox.Show($"Você selecionou o {cmbMes.SelectedItem.ToString()}");
                    break;
                case 7:
                    MessageBox.Show($"Você selecionou o {cmbMes.SelectedItem.ToString()}");
                    break;
                case 8:
                    MessageBox.Show($"Você selecionou o {cmbMes.SelectedItem.ToString()}");
                    break;
                case 9:
                    MessageBox.Show($"Você selecionou o {cmbMes.SelectedItem.ToString()}");
                    break;
                case 10:
                    MessageBox.Show($"Você selecionou o {cmbMes.SelectedItem.ToString()}");
                    break;
                case 11:
                    MessageBox.Show($"Você selecionou o {cmbMes.SelectedItem.ToString()}");
                    break;
                default:
                    MessageBox.Show("Escolha um mês válido");
                    break;
            }
        }
    }
}
