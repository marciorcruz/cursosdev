using Pizzaria.Models;
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
    public partial class Produtos : Form
    {
        db_PizzariaEntities db = new db_PizzariaEntities();

        public Produtos()
        {
            InitializeComponent();
        }

        private void Produtos_Load(object sender, EventArgs e)
        {
            ListaProdutos();
        }

        private void ListaProdutos()
        {
            var lista = db.Produtos.ToList();
            this.dgvLista.DataSource = new BindingList<Models.Produtos>(lista);
            this.dgvLista.Update();
        }
    }
}
