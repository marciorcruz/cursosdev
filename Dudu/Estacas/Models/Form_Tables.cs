using Estacas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacas
{
    public partial class Form_Tables : Form
    {
        private dbent db = new dbent();
        private List<Table_Items> L_TI = new List<Table_Items>();
        public Form_Tables()
        {
            InitializeComponent();
        }

        private void btn_tItem_Click(object sender, EventArgs e)
        {
            Table_Items TI = new Table_Items();
            TI.Description = this.text_tItem_description.Text;
            TI.Value = decimal.Parse(this.text_tItem_Value.Text);
            this.L_TI.Add(TI);
            this.dGV_items.DataSource = new BindingList<Table_Items>(this.L_TI);
            this.text_tItem_description.Text = "";
            this.text_tItem_Value.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listar();
        }

        public void listar()
        {
            this.dGV_table.DataSource = new BindingList<Tables>(db.Tables.Where(my => my.Description.Contains(this.text_find.Text) || my.Greatness.ToString().Contains(this.text_find.Text)).ToList());
        }

        private void btn_table_Click(object sender, EventArgs e)
        {
            Tables obj = new Tables();
            obj.Description = this.text_table_description.Text;
            obj.Greatness = this.text_table_greatness.Text;
            foreach (Table_Items fTI in this.L_TI)
            {
                obj.Table_Items.Add(fTI);
            }
            db.Tables.Add(obj);
            db.SaveChanges();
            listar();
            cls();
        }

        public void cls(){
            this.text_table_description.Text = "";
            this.text_table_greatness.Text = "";
            this.text_tItem_description.Text = "";
            this.text_tItem_Value.Text = "";
            this.L_TI = new List<Table_Items>();
            this.dGV_items.DataSource = new BindingList<Table_Items>(this.L_TI);
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            listar();
        }
    }
}
