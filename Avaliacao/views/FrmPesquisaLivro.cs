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
    public partial class FrmPesquisaLivro : Form
    {

        ControleLivro Cmodel = new ControleLivro();

        public FrmPesquisaLivro()
        {
            InitializeComponent();
        }

        private void FrmPesquisaLivro_Load(object sender, EventArgs e)
        {
            Listar();
        }

        public void Listar()
        {
            try
            {
                this.dgvDadosLivros.DataSource = Cmodel.Listar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error ao listar os dados - " + e.Message);
            }
        }

        private void txt_Livro_Nome_TextChanged(object sender, EventArgs e)
        {
            Livros objeto = new Livros();
            BuscarNome(objeto);
            // Listar();
            if (txt_Livro_Nome.Text == "")
            {
                Listar();
                return;
            }

        }


        private void BuscarNome(Livros objeto)
        {
            try
            {
                objeto.NomeLivro = txt_Livro_Nome.Text;
                this.dgvDadosLivros.DataSource = Cmodel.BuscarNome(objeto);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error ao listar os dados " + e.Message);
            }
        }

        private void txt_livro_codigo_TextChanged(object sender, EventArgs e)
        {
            Livros objeto = new Livros();
            BuscarId(objeto);
            // Listar();
            if (txt_livro_codigo.Text == "")
            {
                Listar();
                return;
            }
        }

        private void BuscarId(Livros objeto)
        {
            try
            {
                objeto.Id = Convert.ToInt32(txt_livro_codigo.Text);
                this.dgvDadosLivros.DataSource = Cmodel.BuscarId(objeto);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error ao listar os dados " + e.Message);
            }
        }
    }
}
