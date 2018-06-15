using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDM.Modulos;

namespace MDM
{
    public partial class Principal : Form
    {
        private int childFormNumber = 0;

        public Principal()
        {
            InitializeComponent();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void tipoDeEquipamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipodeEquipamento obj = new TipodeEquipamento();
            obj.MdiParent = this;
            obj.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void equipamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipamento obj = new Equipamento();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
