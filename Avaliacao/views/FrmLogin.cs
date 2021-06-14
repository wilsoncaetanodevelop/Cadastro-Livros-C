using Avaliacao.entidades;
using Avaliacao.modelo;
using Avaliacao.views;
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

namespace Avaliacao
{
    public partial class frmLogin : Form
    {

        Controle controle = new Controle();

        public frmLogin()
        {
            InitializeComponent();
        }

      

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            Entrar(usuario);
            
        }

        private void Entrar(Usuario objeto)
        {
            if (txtlogin.Text.Equals("") && txtsenha.Text.Equals("")) {
                MessageBox.Show("Informe as suas credenciais para Login!");
            }else{

            objeto.Email = txtlogin.Text;
            objeto.Senha = txtsenha.Text;

            controle.acessar(objeto);
            limparCampos();


            }
           
        }

        private void btncadastroLogin_Click(object sender, EventArgs e)
        {
            views.FrmCadastro cad = new views.FrmCadastro();
            // cad.Show();
            cad.ShowDialog();
        }

        public void limparCampos()
        {
            txtlogin.Text = "";
            txtsenha.Text = "";
        }

        private void btnNovaSenha_Click(object sender, EventArgs e)
        {
            views.FrmNovaSenha nova = new views.FrmNovaSenha();
            nova.ShowDialog();
        }
    }
}
