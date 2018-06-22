namespace ComprasWeb
{
    partial class Cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Pesquisar = new System.Windows.Forms.Button();
            this.Pesquisa = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.thaisdbDataSet = new ComprasWeb.thaisdbDataSet();
            this.thaisdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thaisdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thaisdbDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.Pesquisa);
            this.groupBox1.Controls.Add(this.Pesquisar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(466, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inserir";
            // 
            // Pesquisar
            // 
            this.Pesquisar.Location = new System.Drawing.Point(367, 36);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(75, 23);
            this.Pesquisar.TabIndex = 0;
            this.Pesquisar.Text = "Pesquisar";
            this.Pesquisar.UseVisualStyleBackColor = true;
            this.Pesquisar.Click += new System.EventHandler(this.Pesquisar_Click);
            // 
            // Pesquisa
            // 
            this.Pesquisa.Location = new System.Drawing.Point(6, 36);
            this.Pesquisa.Name = "Pesquisa";
            this.Pesquisa.Size = new System.Drawing.Size(355, 20);
            this.Pesquisa.TabIndex = 1;
            this.Pesquisa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.thaisdbDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(436, 355);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // thaisdbDataSet
            // 
            this.thaisdbDataSet.DataSetName = "thaisdbDataSet";
            this.thaisdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thaisdbDataSetBindingSource
            // 
            this.thaisdbDataSetBindingSource.DataSource = this.thaisdbDataSet;
            this.thaisdbDataSetBindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thaisdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thaisdbDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Pesquisar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Pesquisa;
        private System.Windows.Forms.BindingSource thaisdbDataSetBindingSource;
        private thaisdbDataSet thaisdbDataSet;
        private System.Windows.Forms.Label label1;
    }
}