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
    public partial class SubMenuPorValor : Form
    {
        public SubMenuPorValor()
        {
            InitializeComponent();
        }

        private void btncuatro_Click(object sender, EventArgs e)
        {
            PorValor f = new PorValor();
            f.ShowDialog();
        }

        private void btncinco_Click(object sender, EventArgs e)
        {
            PorValorCin f = new PorValorCin();
            f.ShowDialog();
        }
    }
}
