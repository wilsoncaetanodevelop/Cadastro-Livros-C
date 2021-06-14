
namespace Avaliacao.views
{
    partial class FrmPesquisaLivro
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
            this.dgvDadosLivros = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoPublicacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtlivro2 = new System.Windows.Forms.Label();
            this.txt_Livro_Nome = new System.Windows.Forms.TextBox();
            this.txtlivro = new System.Windows.Forms.Label();
            this.txt_livro_codigo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDadosLivros
            // 
            this.dgvDadosLivros.AutoGenerateColumns = false;
            this.dgvDadosLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeLivroDataGridViewTextBoxColumn,
            this.nomeAutorDataGridViewTextBoxColumn,
            this.anoPublicacaoDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn});
            this.dgvDadosLivros.DataSource = this.livrosBindingSource;
            this.dgvDadosLivros.Location = new System.Drawing.Point(111, 129);
            this.dgvDadosLivros.Name = "dgvDadosLivros";
            this.dgvDadosLivros.RowHeadersVisible = false;
            this.dgvDadosLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDadosLivros.Size = new System.Drawing.Size(396, 139);
            this.dgvDadosLivros.TabIndex = 11;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomeLivroDataGridViewTextBoxColumn
            // 
            this.nomeLivroDataGridViewTextBoxColumn.DataPropertyName = "NomeLivro";
            this.nomeLivroDataGridViewTextBoxColumn.HeaderText = "NomeLivro";
            this.nomeLivroDataGridViewTextBoxColumn.Name = "nomeLivroDataGridViewTextBoxColumn";
            // 
            // nomeAutorDataGridViewTextBoxColumn
            // 
            this.nomeAutorDataGridViewTextBoxColumn.DataPropertyName = "NomeAutor";
            this.nomeAutorDataGridViewTextBoxColumn.HeaderText = "NomeAutor";
            this.nomeAutorDataGridViewTextBoxColumn.Name = "nomeAutorDataGridViewTextBoxColumn";
            // 
            // anoPublicacaoDataGridViewTextBoxColumn
            // 
            this.anoPublicacaoDataGridViewTextBoxColumn.DataPropertyName = "AnoPublicacao";
            this.anoPublicacaoDataGridViewTextBoxColumn.HeaderText = "AnoPublicacao";
            this.anoPublicacaoDataGridViewTextBoxColumn.Name = "anoPublicacaoDataGridViewTextBoxColumn";
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataSource = typeof(Avaliacao.entidades.Livros);
            // 
            // txtlivro2
            // 
            this.txtlivro2.AutoSize = true;
            this.txtlivro2.Location = new System.Drawing.Point(40, 47);
            this.txtlivro2.Name = "txtlivro2";
            this.txtlivro2.Size = new System.Drawing.Size(90, 13);
            this.txtlivro2.TabIndex = 13;
            this.txtlivro2.Text = "Pesquisar Nome :";
            // 
            // txt_Livro_Nome
            // 
            this.txt_Livro_Nome.Location = new System.Drawing.Point(130, 47);
            this.txt_Livro_Nome.Name = "txt_Livro_Nome";
            this.txt_Livro_Nome.Size = new System.Drawing.Size(128, 20);
            this.txt_Livro_Nome.TabIndex = 12;
            this.txt_Livro_Nome.TextChanged += new System.EventHandler(this.txt_Livro_Nome_TextChanged);
            // 
            // txtlivro
            // 
            this.txtlivro.AutoSize = true;
            this.txtlivro.Location = new System.Drawing.Point(284, 47);
            this.txtlivro.Name = "txtlivro";
            this.txtlivro.Size = new System.Drawing.Size(95, 13);
            this.txtlivro.TabIndex = 15;
            this.txtlivro.Text = "Pesquisar Codigo :";
            // 
            // txt_livro_codigo
            // 
            this.txt_livro_codigo.Location = new System.Drawing.Point(379, 47);
            this.txt_livro_codigo.Name = "txt_livro_codigo";
            this.txt_livro_codigo.Size = new System.Drawing.Size(128, 20);
            this.txt_livro_codigo.TabIndex = 14;
            this.txt_livro_codigo.TextChanged += new System.EventHandler(this.txt_livro_codigo_TextChanged);
            // 
            // FrmPesquisaLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 430);
            this.Controls.Add(this.txtlivro);
            this.Controls.Add(this.txt_livro_codigo);
            this.Controls.Add(this.txtlivro2);
            this.Controls.Add(this.txt_Livro_Nome);
            this.Controls.Add(this.dgvDadosLivros);
            this.Name = "FrmPesquisaLivro";
            this.Text = "Pesquisa De Livro";
            this.Load += new System.EventHandler(this.FrmPesquisaLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDadosLivros;
        private System.Windows.Forms.Label txtlivro2;
        private System.Windows.Forms.TextBox txt_Livro_Nome;
        private System.Windows.Forms.Label txtlivro;
        private System.Windows.Forms.TextBox txt_livro_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLivroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoPublicacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource livrosBindingSource;
    }
}