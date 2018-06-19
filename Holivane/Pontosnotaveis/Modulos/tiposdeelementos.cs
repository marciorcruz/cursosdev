using Pontosnotaveis.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pontosnotaveis.Modulos
{
    public partial class tiposdeelementos : Form
    {

        dbcptmEntities db = new dbcptmEntities();
        private tipodeelemento obj;

        public tiposdeelementos()
        {
            InitializeComponent();
        }

        private void lista()
        {
            string find = this.textfiltro.Text.ToString().Trim();
            List<tipodeelemento> lista = db.tipodeelemento.Where(t => t.nome.Contains(find)).ToList();
            if (lista != null)
            {
                this.dgvlista.DataSource = new BindingList<tipodeelemento>(lista);
                this.dgvlista.Update();
            }

        }
        private void clear()
        {
            obj = null;
            this.textnome.Text = String.Empty;
        }
        private void btnsalvar_Click(object sender, EventArgs e)
        {

            tipodeelemento check = new tipodeelemento();
            string nome = this.textnome.Text.ToString().Trim();
            check = db.tipodeelemento.Where(t => t.nome.Equals(nome)).FirstOrDefault();


            if (obj == null)
            {
                if(check.id == 0)
                {
                    obj = new tipodeelemento();
                    obj.nome = this.textnome.Text.Trim();
                    db.tipodeelemento.Add(obj);
                }
                else
                {
                    MessageBox.Show("Esse cadastro já existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
            }
            else
            {
                obj.nome = this.textnome.Text.Trim();
            }
            db.SaveChanges();
            this.lista();
            this.clear();

        }

        private void tiposdeelementos_Load(object sender, EventArgs e)
        {
            this.lista();
        }

        private void btnprocurar_Click(object sender, EventArgs e)
        {
            this.lista();
        }

        private void dgvlista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.clear();
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = this.dgvlista.Rows[e.RowIndex];
                obj = new tipodeelemento();
                int id = Convert.ToInt32(row.Cells[0].Value);
                obj = db.tipodeelemento.Where(t => t.id.Equals(id)).FirstOrDefault();
                this.textnome.Text = obj.nome;
            }            
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            db.tipodeelemento.Remove(obj);
            db.SaveChanges();
            this.lista();
            this.clear();
        }
    }
}
