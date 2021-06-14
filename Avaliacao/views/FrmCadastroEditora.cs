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
    public partial class FrmCadastroEditora : Form
    {

        ControleEditora Cmodel = new ControleEditora();

        public FrmCadastroEditora()
        {
            InitializeComponent();
        }

        private void FrmCadastroEditora_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            try
            {
                this.dgvDadosEditora.DataSource = Cmodel.Listar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error ao listar os dados - " + e.Message);
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            limparCampos();
        }

        public void habilitarCampos()
        {
            txtCodigoEditora.Enabled = true;
            txtNomeEditora.Enabled = true;
            txtEdicaoEditora.Enabled = true;
          
        }

        public void desabilitarCampos()
        {
            txtCodigoEditora.Enabled = false;
            txtNomeEditora.Enabled = false;
            txtEdicaoEditora.Enabled = false;
        }

        public void limparCampos()
        {
            txtCodigoEditora.Text = "";
            txtNomeEditora.Text = "";
            txtEdicaoEditora.Text = "";
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Editora objeto = new Editora();
            Salvar(objeto);
            Listar();
            limparCampos();
            desabilitarCampos();
        }

        private void Salvar(Editora objeto)
        {
            try
            {
              //  objeto.Id = Convert.ToInt32(txtCodigoEditora.Text);
                objeto.Nome = txtNomeEditora.Text;
                objeto.Edicao = txtEdicaoEditora.Text;

                Cmodel.Salvar(objeto);
                MessageBox.Show("Salvo com Sucesso");

            }
            catch (Exception e)
            {
                MessageBox.Show("Error ao salvar " + e.Message);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (txtCodigoEditora.Text == "")
            {
                MessageBox.Show("Selecione um registro para Edição");
                return;
            }

            Editora objeto = new Editora();
            Editar(objeto);
            Listar();
            limparCampos();
            desabilitarCampos();
        }

        private void Editar(Editora objeto)
        {
            try
            {
                objeto.Id = Convert.ToInt32(txtCodigoEditora.Text);
                objeto.Nome = txtNomeEditora.Text;
                objeto.Edicao = txtEdicaoEditora.Text;

                Cmodel.Editar(objeto);
                MessageBox.Show("Editado com sucesso");
            }
            catch (Exception e)
            {
                MessageBox.Show("Erra ao Editar " + e.Message);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (txtCodigoEditora.Text == "")
            {
                MessageBox.Show("Selecionar um registro para excluir");
                return;
            }

            if (MessageBox.Show("Deseja excluir o regstro selecionado? ", " Alerta ", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

            Editora objeto = new Editora();
            Excluir(objeto);
            Listar();
            limparCampos();
            desabilitarCampos();
        }

        private void Excluir(Editora objeto)
        {
            try
            {
                objeto.Id = Convert.ToInt32(txtCodigoEditora.Text);

                Cmodel.Excluir(objeto);
                MessageBox.Show("Excluido com secesso");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error ao Excluir " + e.Message);
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            Editora objeto = new Editora();
            Buscar(objeto);
            if (txtPesquisar.Text == "")
            {
                Listar();
                return;
            }
        }

        private void Buscar(Editora objeto)
        {
            try
            {
                objeto.Nome = txtPesquisar.Text;
                this.dgvDadosEditora.DataSource = Cmodel.Buscar(objeto);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error ao listar os dados " + e.Message);
            }
        }
    }
}
