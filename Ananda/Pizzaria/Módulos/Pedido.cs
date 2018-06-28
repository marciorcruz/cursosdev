using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria.Módulos
{
    public partial class Pedido : Form
    {
        public Pedido()
        {
            InitializeComponent();
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            Produtos obj = new Produtos();
            obj.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();
            obj.ShowDialog();
        }
    }
}
