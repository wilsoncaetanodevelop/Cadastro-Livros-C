
namespace Avaliacao.views
{
    partial class FrmCadastroEditora
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
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.dgvDadosEditora = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edicaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buscar = new System.Windows.Forms.Label();
            this.nome_cli = new System.Windows.Forms.Label();
            this.sexo = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.Label();
            this.txtNomeEditora = new System.Windows.Forms.TextBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.txtCodigoEditora = new System.Windows.Forms.TextBox();
            this.txtEdicaoEditora = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosEditora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(380, 379);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 23;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(279, 379);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 22;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(183, 379);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 21;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(83, 379);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(75, 23);
            this.btn_novo.TabIndex = 20;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // dgvDadosEditora
            // 
            this.dgvDadosEditora.AutoGenerateColumns = false;
            this.dgvDadosEditora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosEditora.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.edicaoDataGridViewTextBoxColumn});
            this.dgvDadosEditora.DataSource = this.editoraBindingSource;
            this.dgvDadosEditora.Location = new System.Drawing.Point(121, 203);
            this.dgvDadosEditora.Name = "dgvDadosEditora";
            this.dgvDadosEditora.RowHeadersVisible = false;
            this.dgvDadosEditora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDadosEditora.Size = new System.Drawing.Size(304, 139);
            this.dgvDadosEditora.TabIndex = 25;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // edicaoDataGridViewTextBoxColumn
            // 
            this.edicaoDataGridViewTextBoxColumn.DataPropertyName = "Edicao";
            this.edicaoDataGridViewTextBoxColumn.HeaderText = "Edicao";
            this.edicaoDataGridViewTextBoxColumn.Name = "edicaoDataGridViewTextBoxColumn";
            // 
            // editoraBindingSource
            // 
            this.editoraBindingSource.DataSource = typeof(Avaliacao.entidades.Editora);
            // 
            // buscar
            // 
            this.buscar.AutoSize = true;
            this.buscar.Location = new System.Drawing.Point(299, 51);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(40, 13);
            this.buscar.TabIndex = 24;
            this.buscar.Text = "Buscar";
            // 
            // nome_cli
            // 
            this.nome_cli.AutoSize = true;
            this.nome_cli.Location = new System.Drawing.Point(251, 133);
            this.nome_cli.Name = "nome_cli";
            this.nome_cli.Size = new System.Drawing.Size(89, 13);
            this.nome_cli.TabIndex = 16;
            this.nome_cli.Text = "Nome da Editora:";
            // 
            // sexo
            // 
            this.sexo.AutoSize = true;
            this.sexo.Location = new System.Drawing.Point(56, 165);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(46, 13);
            this.sexo.TabIndex = 18;
            this.sexo.Text = "Edição :";
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Location = new System.Drawing.Point(56, 133);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(43, 13);
            this.codigo.TabIndex = 13;
            this.codigo.Text = "Código:";
            // 
            // txtNomeEditora
            // 
            this.txtNomeEditora.Location = new System.Drawing.Point(345, 126);
            this.txtNomeEditora.Name = "txtNomeEditora";
            this.txtNomeEditora.Size = new System.Drawing.Size(128, 20);
            this.txtNomeEditora.TabIndex = 14;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(345, 48);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(128, 20);
            this.txtPesquisar.TabIndex = 15;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // txtCodigoEditora
            // 
            this.txtCodigoEditora.Location = new System.Drawing.Point(106, 126);
            this.txtCodigoEditora.Name = "txtCodigoEditora";
            this.txtCodigoEditora.Size = new System.Drawing.Size(121, 20);
            this.txtCodigoEditora.TabIndex = 12;
            // 
            // txtEdicaoEditora
            // 
            this.txtEdicaoEditora.Location = new System.Drawing.Point(106, 158);
            this.txtEdicaoEditora.Name = "txtEdicaoEditora";
            this.txtEdicaoEditora.Size = new System.Drawing.Size(121, 20);
            this.txtEdicaoEditora.TabIndex = 26;
            // 
            // FrmCadastroEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 450);
            this.Controls.Add(this.txtEdicaoEditora);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.dgvDadosEditora);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.nome_cli);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.txtNomeEditora);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.txtCodigoEditora);
            this.Name = "FrmCadastroEditora";
            this.Text = "Cadastro Editora";
            this.Load += new System.EventHandler(this.FrmCadastroEditora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosEditora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.DataGridView dgvDadosEditora;
        private System.Windows.Forms.Label buscar;
        private System.Windows.Forms.Label nome_cli;
        private System.Windows.Forms.Label sexo;
        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.TextBox txtNomeEditora;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.TextBox txtCodigoEditora;
        private System.Windows.Forms.TextBox txtEdicaoEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeEditoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edicaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource editoraBindingSource;
    }
}