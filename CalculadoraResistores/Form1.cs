using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraResistores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn4bandas_Click(object sender, EventArgs e)
        {
            GUI.CuBandas f = new GUI.CuBandas();
            f.ShowDialog();
        }

        private void btn5Bandas_Click(object sender, EventArgs e)
        {
            GUI.CiBandas f = new GUI.CiBandas();
            f.ShowDialog();

        }

        private void btnValor_Click(object sender, EventArgs e)
        {
            GUI.PorValor f = new GUI.PorValor();
            f.ShowDialog();
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            GUI.AcercaDe f = new GUI.AcercaDe();
            f.ShowDialog();

        }

        private void btnValor_Click_1(object sender, EventArgs e)
        {
            GUI.SubMenuPorValor f = new GUI.SubMenuPorValor();
            f.ShowDialog();
        }
    }
}
