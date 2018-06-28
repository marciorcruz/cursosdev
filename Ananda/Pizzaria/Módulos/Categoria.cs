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
    public partial class Categoria : Form
    {
        db_PizzariaEntities db = new db_PizzariaEntities();

        public Categoria()
        {
            InitializeComponent();
        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            ListaCategorias();
        }

        private void ListaCategorias()
        {
            var lista = db.Categoria.ToList();
            this.dgvLista.DataSource = new BindingList<Models.Categoria>(lista);
            this.dgvLista.Update();
        }
    }
}
