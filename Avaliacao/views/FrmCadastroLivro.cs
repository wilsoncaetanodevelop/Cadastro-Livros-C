using Avaliacao.entidades;
using Avaliacao.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao.views
{
    public partial class FrmCadastroLivro : Form
    {

        ControleLivro Cmodel = new ControleLivro();

        public FrmCadastroLivro()
        {
            InitializeComponent();
        }

        private void FrmCadastroLivro_Load(object sender, EventArgs e)
        {
            Listar();
            EditoraNome();
        }

        public void Listar()
        {
            try
            {
                this.dgvDadosCadastro.DataSource = Cmodel.Listar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error ao listar os dados - " + e.Message);
            }
        }

        public void habilitarCampos()
        {
            txtCodigoCadastro.Enabled = true;
            txtNomeCadastro.Enabled = true;
            txtAutorCadastro.Enabled = true;
            dtpDataPublicacao.Enabled = true;
            txtTituloCadastro.Enabled = true;
            comboBoxEditora.Enabled = true;
        }

        public void desabilitarCampos()
        {
            txtCodigoCadastro.Enabled = false;
            txtNomeCadastro.Enabled = false;
            txtAutorCadastro.Enabled = false;
            dtpDataPublicacao.Enabled = false;
            txtTituloCadastro.Enabled = false;
            comboBoxEditora.Enabled = false;
        }

        public void limparCampos()
        {
            txtCodigoCadastro.Text = "";
            txtNomeCadastro.Text = "";
            txtAutorCadastro.Text = "";
            dtpDataPublicacao.Text = "";
            txtTituloCadastro.Text = "";
            comboBoxEditora.Text = "";

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Livros objeto = new Livros();
            Salvar(objeto);
            Listar();
            limparCampos();
            desabilitarCampos();
        }

        private void Salvar(Livros objeto)
        {
            try
            {
                //objeto.Id = Convert.ToInt32(txtCodigoCadastro.Text);
                objeto.NomeLivro = txtNomeCadastro.Text;
                objeto.NomeAutor = txtAutorCadastro.Text;
                objeto.Titulo = txtTituloCadastro.Text;
                objeto.AnoPublicacao = Convert.ToDateTime(dtpDataPublicacao.Text);
                objeto.IdEditora = Convert.ToInt32(comboBoxEditora.SelectedValue);
         
                Cmodel.Salvar(objeto);
                MessageBox.Show("Salvo com Sucesso");

            }
            catch (Exception e)
            {
                MessageBox.Show("Error ao salvar " + e.Message);
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            limparCampos();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (txtCodigoCadastro.Text == "")
            {
                MessageBox.Show("Selecionar um registro para excluir");
                return;
            }

            if (MessageBox.Show("Deseja excluir o regstro selecionado? ", " Alerta ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

            Livros objeto = new Livros();
            Excluir(objeto);
            Listar();
            limparCampos();
            desabilitarCampos();
        }

        private void Excluir(Livros objeto)
        {
            try
            {
                objeto.Id = Convert.ToInt32(txtCodigoCadastro.Text);

                Cmodel.Excluir(objeto);
                MessageBox.Show("Excluido com secesso");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error ao Excluir " + e.Message);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (txtCodigoCadastro.Text == "")
            {
                MessageBox.Show("Selecione um registro para Edição");
                return;
            }

            Livros objeto = new Livros();
            Editar(objeto);
            Listar();
            limparCampos();
            desabilitarCampos();
        }


        private void Editar(Livros objeto)
        {
            try
            {
                objeto.Id = Convert.ToInt32(txtCodigoCadastro.Text);
                objeto.AnoPublicacao = Convert.ToDateTime(dtpDataPublicacao.Text);
                objeto.NomeLivro = txtNomeCadastro.Text;
                objeto.NomeAutor = txtTituloCadastro.Text;
                objeto.Titulo = txtTituloCadastro.Text;
                objeto.IdEditora = Convert.ToInt32(comboBoxEditora.SelectedValue);

                Cmodel.Editar(objeto);
                MessageBox.Show("Editado com sucesso");
            }
            catch (Exception e)
            {
                MessageBox.Show("Erra ao Editar " + e.Message);
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            Livros objeto = new Livros();
            Buscar(objeto);
            if (txtPesquisar.Text == "")
            {
                Listar();
                return;
            }

        }

        private void Buscar(Livros objeto)
        {
            try
            {
                objeto.NomeLivro = txtPesquisar.Text;
                this.dgvDadosCadastro.DataSource = Cmodel.Buscar(objeto);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error ao listar os dados " + e.Message);
            }
        }

        private void EditoraNome()
        {
            try
            {
                this.comboBoxEditora.ValueMember = "id";
                this.comboBoxEditora.DisplayMember = "nome";
                this.comboBoxEditora.DataSource = Cmodel.EditoraNome();


            }
            catch (Exception e)
            {
                MessageBox.Show("Error ao listar os dados - " + e.Message);
            }
        }
    }
}
