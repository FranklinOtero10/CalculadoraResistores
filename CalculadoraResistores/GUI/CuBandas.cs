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
    public partial class CuBandas : Form
    {
        public CuBandas()
        {
            InitializeComponent();
        }

        public void Habilitar()
        {
            cbbPrimera.Enabled = true;
            cbbSegunda.Enabled = true;
            cbbMultiplicador.Enabled = true;
            cbbTolerancia.Enabled = true;
        }

        public void Limpiar()
        {
            txbValor.Clear();
            cbbPrimera.SelectedIndex = -1;
            cbbSegunda.SelectedIndex = -1;
            cbbMultiplicador.SelectedIndex = -1;
            cbbTolerancia.SelectedIndex = -1;
        }

        public void LimpiarColores()
        {
            btn1.BackColor = Color.Transparent;
            btn2.BackColor = Color.Transparent;
            btn3.BackColor = Color.Transparent;
            btn4.BackColor = Color.Transparent;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void CuBandas_Load(object sender, EventArgs e)
        {
            cbbSegunda.Enabled = false;
            cbbMultiplicador.Enabled = false;
            cbbTolerancia.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            cbbPrimera.Focus();
        }

        private void cbbPrimera_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbPrimera.SelectedIndex)
            {
                case 0:
                    txbValor.Text = "";
                    btn1.BackColor = Color.Black;
                    break;
                case 1:
                    txbValor.Text = "1";
                    btn1.BackColor = Color.Maroon;
                    break;
                case 2:
                    txbValor.Text = "2";
                    btn1.BackColor = Color.Red;
                    break;
                case 3:
                    txbValor.Text = "3";
                    btn1.BackColor = Color.Orange;
                    break;
                case 4:
                    txbValor.Text = "4";
                    btn1.BackColor = Color.Yellow;
                    break;
                case 5:
                    txbValor.Text = "5";
                    btn1.BackColor = Color.Green;
                    break;
                case 6:
                    txbValor.Text = "6";
                    btn1.BackColor = Color.Blue;
                    break;
                case 7:
                    txbValor.Text = "7";
                    btn1.BackColor = Color.Violet;
                    break;
                case 8:
                    txbValor.Text = "8";
                    btn1.BackColor = Color.Gray;
                    break;
                case 9:
                    txbValor.Text = "9";
                    btn1.BackColor = Color.White;
                    break;
                default:
                    break;
            }

            cbbPrimera.Enabled = false;
            cbbSegunda.Enabled = true;
            cbbSegunda.Focus();
        }

        private void cbbSegunda_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbSegunda.SelectedIndex)
            {
                case 0:
                    txbValor.Text += "0";
                    btn2.BackColor = Color.Black;
                    break;
                case 1:
                    txbValor.Text += "1";
                    btn2.BackColor = Color.Maroon;
                    break;
                case 2:
                    txbValor.Text += "2";
                    btn2.BackColor = Color.Red;
                    break;
                case 3:
                    txbValor.Text += "3";
                    btn2.BackColor = Color.Orange;
                    break;
                case 4:
                    txbValor.Text += "4";
                    btn2.BackColor = Color.Yellow;
                    break;
                case 5:
                    txbValor.Text += "5";
                    btn2.BackColor = Color.Green;
                    break;
                case 6:
                    txbValor.Text += "6";
                    btn2.BackColor = Color.Blue;
                    break;
                case 7:
                    txbValor.Text += "7";
                    btn2.BackColor = Color.Violet;
                    break;
                case 8:
                    txbValor.Text += "8";
                    btn2.BackColor = Color.Gray;
                    break;
                case 9:
                    txbValor.Text += "9";
                    btn2.BackColor = Color.White;
                    break;
                default:
                    break;
            }

            cbbSegunda.Enabled = false;
            cbbMultiplicador.Enabled = true;
            cbbMultiplicador.Focus();
        }

        private void cbbMultiplicador_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbMultiplicador.SelectedIndex)
            {
                case 0:
                    btn3.BackColor = Color.Black;
                    break;
                case 1:
                    txbValor.Text += "0";
                    btn3.BackColor = Color.Maroon;
                    break;
                case 2:
                    txbValor.Text += "00";
                    btn3.BackColor = Color.Red;
                    break;
                case 3:
                    txbValor.Text += "000";
                    btn3.BackColor = Color.Orange;
                    break;
                case 4:
                    txbValor.Text += "0000";
                    btn3.BackColor = Color.Yellow;
                    break;
                case 5:
                    txbValor.Text += "00000";
                    btn3.BackColor = Color.Green;
                    break;
                case 6:
                    txbValor.Text += "000000";
                    btn3.BackColor = Color.Blue;
                    break;
                case 7:
                    txbValor.Text += "0000000";
                    btn3.BackColor = Color.Violet;
                    break;
                case 8:
                    txbValor.Text += "00000000";
                    btn3.BackColor = Color.Gray;
                    break;
                case 9:
                    txbValor.Text += "000000000";
                    btn3.BackColor = Color.White;
                    break;
                case 10:
                    double val = Convert.ToDouble(txbValor.Text);
                    txbValor.Text = Convert.ToString(val / 10);
                    btn3.BackColor = Color.Gold;
                    break;
                case 11:
                    double valo = Convert.ToDouble(txbValor.Text);
                    txbValor.Text = Convert.ToString(valo / 100);
                    btn3.BackColor = Color.Silver;
                    break;
                default:
                    break;
            }

            cbbMultiplicador.Enabled = false;
            cbbTolerancia.Enabled = true;
            cbbTolerancia.Focus();
        }

        private void cbbTolerancia_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbTolerancia.SelectedIndex)
            {
                case 0:
                    btn4.BackColor = Color.Maroon;
                    txbValor.Text += " Ω ± 1%";
                    break;
                case 1:
                    btn4.BackColor = Color.Red;
                    txbValor.Text += " Ω ± 2%";
                    break;
                case 2:
                    btn4.BackColor = Color.Green;
                    txbValor.Text += " Ω ± 0.5%";
                    break;
                case 3:
                    btn4.BackColor = Color.Blue;
                    txbValor.Text += " Ω ± 0.25%";
                    break;
                case 4:
                    btn4.BackColor = Color.Violet;
                    txbValor.Text += " Ω ± 0.1%";
                    break;
                case 5:
                    btn4.BackColor = Color.Gray;
                    txbValor.Text += " Ω ± 0.05%";
                    break;
                case 6:
                    btn4.BackColor = Color.Gold;
                    txbValor.Text += " Ω ± 5%";
                    break;
                case 7:
                    btn4.BackColor = Color.Silver;
                    txbValor.Text += " Ω ± 10%";
                    break;
                default:
                    break;
            }

            cbbTolerancia.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            LimpiarColores();
            Habilitar();
        }

    }
}
