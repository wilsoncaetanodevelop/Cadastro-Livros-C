
namespace Avaliacao.views
{
    partial class FrmCadastroLivro
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
            this.dtpDataPublicacao = new System.Windows.Forms.MaskedTextBox();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.dgvDadosCadastro = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoPublicacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEditoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_nasc = new System.Windows.Forms.Label();
            this.nome_cli = new System.Windows.Forms.Label();
            this.sexo = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.Label();
            this.txtNomeCadastro = new System.Windows.Forms.TextBox();
            this.txtCodigoCadastro = new System.Windows.Forms.TextBox();
            this.txtAutorCadastro = new System.Windows.Forms.TextBox();
            this.txtTituloCadastro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.comboBoxEditora = new System.Windows.Forms.ComboBox();
            this.editoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosCadastro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDataPublicacao
            // 
            this.dtpDataPublicacao.Location = new System.Drawing.Point(415, 126);
            this.dtpDataPublicacao.Mask = "00/00/0000";
            this.dtpDataPublicacao.Name = "dtpDataPublicacao";
            this.dtpDataPublicacao.Size = new System.Drawing.Size(128, 20);
            this.dtpDataPublicacao.TabIndex = 24;
            this.dtpDataPublicacao.ValidatingType = typeof(System.DateTime);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(446, 386);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_excluir.TabIndex = 22;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(345, 386);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 21;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(249, 386);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 20;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(149, 386);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(75, 23);
            this.btn_novo.TabIndex = 19;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // dgvDadosCadastro
            // 
            this.dgvDadosCadastro.AutoGenerateColumns = false;
            this.dgvDadosCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosCadastro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeLivroDataGridViewTextBoxColumn,
            this.nomeAutorDataGridViewTextBoxColumn,
            this.anoPublicacaoDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.idEditoraDataGridViewTextBoxColumn});
            this.dgvDadosCadastro.DataSource = this.livrosBindingSource;
            this.dgvDadosCadastro.Location = new System.Drawing.Point(110, 217);
            this.dgvDadosCadastro.Name = "dgvDadosCadastro";
            this.dgvDadosCadastro.RowHeadersVisible = false;
            this.dgvDadosCadastro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDadosCadastro.Size = new System.Drawing.Size(452, 139);
            this.dgvDadosCadastro.TabIndex = 23;
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
            this.nomeLivroDataGridViewTextBoxColumn.HeaderText = "Nome Livro";
            this.nomeLivroDataGridViewTextBoxColumn.Name = "nomeLivroDataGridViewTextBoxColumn";
            // 
            // nomeAutorDataGridViewTextBoxColumn
            // 
            this.nomeAutorDataGridViewTextBoxColumn.DataPropertyName = "NomeAutor";
            this.nomeAutorDataGridViewTextBoxColumn.HeaderText = "Nome Autor";
            this.nomeAutorDataGridViewTextBoxColumn.Name = "nomeAutorDataGridViewTextBoxColumn";
            // 
            // anoPublicacaoDataGridViewTextBoxColumn
            // 
            this.anoPublicacaoDataGridViewTextBoxColumn.DataPropertyName = "AnoPublicacao";
            this.anoPublicacaoDataGridViewTextBoxColumn.HeaderText = "Ano Publicacao";
            this.anoPublicacaoDataGridViewTextBoxColumn.Name = "anoPublicacaoDataGridViewTextBoxColumn";
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            // 
            // idEditoraDataGridViewTextBoxColumn
            // 
            this.idEditoraDataGridViewTextBoxColumn.DataPropertyName = "IdEditora";
            this.idEditoraDataGridViewTextBoxColumn.HeaderText = "Id Editora";
            this.idEditoraDataGridViewTextBoxColumn.Name = "idEditoraDataGridViewTextBoxColumn";
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataSource = typeof(Avaliacao.entidades.Livros);
            // 
            // data_nasc
            // 
            this.data_nasc.AutoSize = true;
            this.data_nasc.Location = new System.Drawing.Point(305, 130);
            this.data_nasc.Name = "data_nasc";
            this.data_nasc.Size = new System.Drawing.Size(105, 13);
            this.data_nasc.TabIndex = 18;
            this.data_nasc.Text = "Ano Da Publicação :";
            // 
            // nome_cli
            // 
            this.nome_cli.AutoSize = true;
            this.nome_cli.Location = new System.Drawing.Point(321, 94);
            this.nome_cli.Name = "nome_cli";
            this.nome_cli.Size = new System.Drawing.Size(79, 13);
            this.nome_cli.TabIndex = 15;
            this.nome_cli.Text = "Nome do Livro:";
            // 
            // sexo
            // 
            this.sexo.AutoSize = true;
            this.sexo.Location = new System.Drawing.Point(107, 126);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(69, 13);
            this.sexo.TabIndex = 17;
            this.sexo.Text = "Nome Autor :";
            // 
            // codigo
            // 
            this.codigo.AutoSize = true;
            this.codigo.Location = new System.Drawing.Point(126, 94);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(43, 13);
            this.codigo.TabIndex = 13;
            this.codigo.Text = "Código:";
            // 
            // txtNomeCadastro
            // 
            this.txtNomeCadastro.Location = new System.Drawing.Point(415, 87);
            this.txtNomeCadastro.Name = "txtNomeCadastro";
            this.txtNomeCadastro.Size = new System.Drawing.Size(128, 20);
            this.txtNomeCadastro.TabIndex = 14;
            // 
            // txtCodigoCadastro
            // 
            this.txtCodigoCadastro.Location = new System.Drawing.Point(176, 87);
            this.txtCodigoCadastro.Name = "txtCodigoCadastro";
            this.txtCodigoCadastro.Size = new System.Drawing.Size(121, 20);
            this.txtCodigoCadastro.TabIndex = 12;
            // 
            // txtAutorCadastro
            // 
            this.txtAutorCadastro.Location = new System.Drawing.Point(176, 123);
            this.txtAutorCadastro.Name = "txtAutorCadastro";
            this.txtAutorCadastro.Size = new System.Drawing.Size(121, 20);
            this.txtAutorCadastro.TabIndex = 25;
            // 
            // txtTituloCadastro
            // 
            this.txtTituloCadastro.Location = new System.Drawing.Point(176, 164);
            this.txtTituloCadastro.Name = "txtTituloCadastro";
            this.txtTituloCadastro.Size = new System.Drawing.Size(121, 20);
            this.txtTituloCadastro.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Titulo :";
            // 
            // buscar
            // 
            this.buscar.AutoSize = true;
            this.buscar.Location = new System.Drawing.Point(314, 34);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(95, 13);
            this.buscar.TabIndex = 29;
            this.buscar.Text = "Buscar por Nome :";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(415, 27);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(128, 20);
            this.txtPesquisar.TabIndex = 28;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // comboBoxEditora
            // 
            this.comboBoxEditora.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.livrosBindingSource, "IdEditora", true));
            this.comboBoxEditora.DataSource = this.editoraBindingSource;
            this.comboBoxEditora.DisplayMember = "Nome";
            this.comboBoxEditora.FormattingEnabled = true;
            this.comboBoxEditora.Location = new System.Drawing.Point(415, 164);
            this.comboBoxEditora.Name = "comboBoxEditora";
            this.comboBoxEditora.Size = new System.Drawing.Size(128, 21);
            this.comboBoxEditora.TabIndex = 30;
            this.comboBoxEditora.ValueMember = "Id";
            // 
            // editoraBindingSource
            // 
            this.editoraBindingSource.DataSource = typeof(Avaliacao.entidades.Editora);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Editora : ";
            // 
            // FrmCadastroLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 519);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEditora);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTituloCadastro);
            this.Controls.Add(this.txtAutorCadastro);
            this.Controls.Add(this.dtpDataPublicacao);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.dgvDadosCadastro);
            this.Controls.Add(this.data_nasc);
            this.Controls.Add(this.nome_cli);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.txtNomeCadastro);
            this.Controls.Add(this.txtCodigoCadastro);
            this.Name = "FrmCadastroLivro";
            this.Text = "Cadastro Livro";
            this.Load += new System.EventHandler(this.FrmCadastroLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosCadastro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox dtpDataPublicacao;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.DataGridView dgvDadosCadastro;
        private System.Windows.Forms.Label data_nasc;
        private System.Windows.Forms.Label nome_cli;
        private System.Windows.Forms.Label sexo;
        private System.Windows.Forms.Label codigo;
        private System.Windows.Forms.TextBox txtNomeCadastro;
        private System.Windows.Forms.TextBox txtCodigoCadastro;
        private System.Windows.Forms.TextBox txtAutorCadastro;
        private System.Windows.Forms.TextBox txtTituloCadastro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label buscar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.ComboBox comboBoxEditora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource editoraBindingSource;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLivroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoPublicacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEditoraDataGridViewTextBoxColumn;
    }
}