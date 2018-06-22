namespace Estacas
{
    partial class Form_Tables
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.text_table_description = new System.Windows.Forms.TextBox();
            this.btnC_tItem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.text_table_greatness = new System.Windows.Forms.TextBox();
            this.dGV_table = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_tItem_description = new System.Windows.Forms.TextBox();
            this.text_tItem_Value = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dGV_items = new System.Windows.Forms.DataGridView();
            this.btnC_table = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lista = new System.Windows.Forms.GroupBox();
            this.btn_find = new System.Windows.Forms.Button();
            this.text_find = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_items)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Lista.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // text_table_description
            // 
            this.text_table_description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_table_description.Location = new System.Drawing.Point(87, 24);
            this.text_table_description.Name = "text_table_description";
            this.text_table_description.Size = new System.Drawing.Size(176, 22);
            this.text_table_description.TabIndex = 1;
            // 
            // btnC_tItem
            // 
            this.btnC_tItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnC_tItem.Location = new System.Drawing.Point(6, 172);
            this.btnC_tItem.Name = "btnC_tItem";
            this.btnC_tItem.Size = new System.Drawing.Size(257, 23);
            this.btnC_tItem.TabIndex = 2;
            this.btnC_tItem.Text = "Adicionar Item";
            this.btnC_tItem.UseVisualStyleBackColor = true;
            this.btnC_tItem.Click += new System.EventHandler(this.btn_tItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grandeza:";
            // 
            // text_table_greatness
            // 
            this.text_table_greatness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_table_greatness.Location = new System.Drawing.Point(87, 55);
            this.text_table_greatness.Name = "text_table_greatness";
            this.text_table_greatness.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.text_table_greatness.Size = new System.Drawing.Size(176, 22);
            this.text_table_greatness.TabIndex = 4;
            // 
            // dGV_table
            // 
            this.dGV_table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_table.Location = new System.Drawing.Point(6, 54);
            this.dGV_table.Name = "dGV_table";
            this.dGV_table.RowTemplate.Height = 24;
            this.dGV_table.Size = new System.Drawing.Size(470, 471);
            this.dGV_table.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Itens";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descrição:";
            // 
            // text_tItem_description
            // 
            this.text_tItem_description.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_tItem_description.Location = new System.Drawing.Point(87, 114);
            this.text_tItem_description.Name = "text_tItem_description";
            this.text_tItem_description.Size = new System.Drawing.Size(176, 22);
            this.text_tItem_description.TabIndex = 9;
            // 
            // text_tItem_Value
            // 
            this.text_tItem_Value.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_tItem_Value.Location = new System.Drawing.Point(87, 144);
            this.text_tItem_Value.Name = "text_tItem_Value";
            this.text_tItem_Value.Size = new System.Drawing.Size(176, 22);
            this.text_tItem_Value.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Valor:";
            // 
            // dGV_items
            // 
            this.dGV_items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_items.Location = new System.Drawing.Point(6, 201);
            this.dGV_items.Name = "dGV_items";
            this.dGV_items.RowTemplate.Height = 24;
            this.dGV_items.Size = new System.Drawing.Size(257, 296);
            this.dGV_items.TabIndex = 12;
            // 
            // btnC_table
            // 
            this.btnC_table.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.btnC_table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnC_table.Location = new System.Drawing.Point(6, 503);
            this.btnC_table.Name = "btnC_table";
            this.btnC_table.Size = new System.Drawing.Size(257, 23);
            this.btnC_table.TabIndex = 13;
            this.btnC_table.Text = "Adicionar Tabela";
            this.btnC_table.UseVisualStyleBackColor = true;
            this.btnC_table.Click += new System.EventHandler(this.btn_table_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnC_table);
            this.groupBox1.Controls.Add(this.text_table_description);
            this.groupBox1.Controls.Add(this.dGV_items);
            this.groupBox1.Controls.Add(this.btnC_tItem);
            this.groupBox1.Controls.Add(this.text_table_greatness);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.text_tItem_Value);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.text_tItem_description);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 532);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova Tabela de Parâmentros";
            // 
            // Lista
            // 
            this.Lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lista.Controls.Add(this.btn_find);
            this.Lista.Controls.Add(this.text_find);
            this.Lista.Controls.Add(this.label4);
            this.Lista.Controls.Add(this.dGV_table);
            this.Lista.Location = new System.Drawing.Point(288, 13);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(482, 531);
            this.Lista.TabIndex = 6;
            this.Lista.TabStop = false;
            this.Lista.Text = "Dados";
            // 
            // btn_find
            // 
            this.btn_find.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_find.Location = new System.Drawing.Point(400, 20);
            this.btn_find.Name = "btn_find";
            this.btn_find.Size = new System.Drawing.Size(75, 23);
            this.btn_find.TabIndex = 8;
            this.btn_find.Text = "Buscar";
            this.btn_find.UseVisualStyleBackColor = true;
            this.btn_find.Click += new System.EventHandler(this.btn_find_Click);
            // 
            // text_find
            // 
            this.text_find.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_find.Location = new System.Drawing.Point(106, 21);
            this.text_find.Name = "text_find";
            this.text_find.Size = new System.Drawing.Size(288, 22);
            this.text_find.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Procurar por:";
            // 
            // Form_Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Tables";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_items)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Lista.ResumeLayout(false);
            this.Lista.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_table_description;
        private System.Windows.Forms.Button btnC_tItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_table_greatness;
        private System.Windows.Forms.DataGridView dGV_table;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_tItem_description;
        private System.Windows.Forms.TextBox text_tItem_Value;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dGV_items;
        private System.Windows.Forms.Button btnC_table;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Lista;
        private System.Windows.Forms.Button btn_find;
        private System.Windows.Forms.TextBox text_find;
        private System.Windows.Forms.Label label4;
    }
}

