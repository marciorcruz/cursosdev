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
        private db_PizzariaEntities db = new db_PizzariaEntities();
        private Models.Categoria obj = new Models.Categoria();

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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!this.txtNomeCat.Text.Trim().Equals(""))
            {
                obj.Nome = this.txtNomeCat.Text.Trim();
                db.Categoria.Add(obj);
            }

            db.SaveChanges();
            ListaCategorias();
            clear();
        }

        private void clear()
        {
            obj = null;
            this.txtNomeCat.Text = String.Empty;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void dgvLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            clear();
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = this.dgvLista.Rows[e.RowIndex];
                obj = new Models.Categoria();
                int id = Convert.ToInt32(row.Cells[0].Value);
                obj = db.Categoria.Where(t => t.id.Equals(id)).FirstOrDefault();
                if (obj != null)
                {
                    this.txtNomeCat.Text = obj.Nome;
                }
                else
                {
                    clear();
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clear();
            ListaCategorias();            
        }
    }
}
