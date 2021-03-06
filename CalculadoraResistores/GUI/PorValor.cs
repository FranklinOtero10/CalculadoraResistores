using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraResistores.GUI
{
    public partial class PorValor : Form
    {
        public PorValor()
        {
            InitializeComponent();
        }

        public void ValorTolerancia()
        {
            switch (cbbTolerancia.SelectedIndex)
            {
                case 0:
                    btn4.BackColor = Color.Maroon;
                    break;
                case 1:
                    btn4.BackColor = Color.Red;
                    break;
                case 2:
                    btn4.BackColor = Color.Green;
                    break;
                case 3:
                    btn4.BackColor = Color.Blue;
                    break;
                case 4:
                    btn4.BackColor = Color.Violet;
                    break;
                case 5:
                    btn4.BackColor = Color.Gray;
                    break;
                case 6:
                    btn4.BackColor = Color.Gold;
                    break;
                case 7:
                    btn4.BackColor = Color.Silver;
                    break;
                default:
                    break;
            }
        }

        public void ValorIntroducido()
        {
            String valor = txbValor.Text;
            char primera;
            char segunda;
            String multiplicador;

            primera = valor[0];

            segunda = valor[1];

            multiplicador = valor.Substring(valor.IndexOf("0"));

            switch (primera)
            {
                case '1':
                    btn1.BackColor = Color.Maroon;
                    break;
                case '2':
                    btn1.BackColor = Color.Red;
                    break;
                case '3':
                    btn1.BackColor = Color.Orange;
                    break;
                case '4':
                    btn1.BackColor = Color.Yellow;
                    break;
                case '5':
                    btn1.BackColor = Color.Green;
                    break;
                case '6':
                    btn1.BackColor = Color.Blue;
                    break;
                case '7':
                    btn1.BackColor = Color.Violet;
                    break;
                case '8':
                    btn1.BackColor = Color.Gray;
                    break;
                case '9':
                    btn1.BackColor = Color.White;
                    break;
                default:
                    MessageBox.Show("Digite un valor válido");
                    break;
            }

            switch (segunda)
            {
                case '0':
                    btn2.BackColor = Color.Black;
                    break;
                case '1':
                    btn2.BackColor = Color.Maroon;
                    break;
                case '2':
                    btn2.BackColor = Color.Red;
                    break;
                case '3':
                    btn2.BackColor = Color.Orange;
                    break;
                case '4':
                    btn2.BackColor = Color.Yellow;
                    break;
                case '5':
                    btn2.BackColor = Color.Green;
                    break;
                case '6':
                    btn2.BackColor = Color.Blue;
                    break;
                case '7':
                    btn2.BackColor = Color.Violet;
                    break;
                case '8':
                    btn2.BackColor = Color.Gray;
                    break;
                case '9':
                    btn2.BackColor = Color.White;
                    break;
                default:
                    MessageBox.Show("Digite un valor válido");
                    break;
            }

            switch (multiplicador)
            {
                case "0":
                    btn3.BackColor = Color.Maroon;
                    break;
                case "00":
                    btn3.BackColor = Color.Red;
                    break;
                case "000":
                    btn3.BackColor = Color.Orange;
                    break;
                case "0000":
                    btn3.BackColor = Color.Yellow;
                    break;
                case "00000":
                    btn3.BackColor = Color.Green;
                    break;
                case "000000":
                    btn3.BackColor = Color.Blue;
                    break;
                case "0000000":
                    btn3.BackColor = Color.Violet;
                    break;
                case "00000000":
                    btn3.BackColor = Color.Gray;
                    break;
                case "000000000":
                    btn3.BackColor = Color.White;
                    break;
                default:
                    MessageBox.Show("Digite un valor válido para el multiplicador");
                    break;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PorValor_Load(object sender, EventArgs e)
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbValor.Clear();
            cbbTolerancia.SelectedIndex = -1;
            btn1.BackColor = Color.Transparent;
            btn2.BackColor = Color.Transparent;
            btn3.BackColor = Color.Transparent;
            btn4.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ValorIntroducido();
            ValorTolerancia();
        }
    }
}
