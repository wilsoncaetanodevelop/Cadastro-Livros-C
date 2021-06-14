using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Avaliacao.views;


namespace Avaliacao.views
{
    public partial class BemVindo : Form
    {
        public BemVindo()
        {
            InitializeComponent();
        }

        private void btn_pesquisa_B_Click(object sender, EventArgs e)
        {
            views.FrmPesquisaLivro form = new views.FrmPesquisaLivro();
            form.ShowDialog();
        }

        private void btn_cadastro_B_Click(object sender, EventArgs e)
        {
            views.FrmCadastroLivro form = new views.FrmCadastroLivro();
            form.ShowDialog();
        }

        private void btn_Editora_Click(object sender, EventArgs e)
        {
            views.FrmCadastroEditora form = new views.FrmCadastroEditora();
            form.ShowDialog();
        }
    }
}
