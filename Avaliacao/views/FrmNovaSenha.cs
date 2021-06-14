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
    public partial class FrmNovaSenha : Form
    {

        Controle controle = new Controle();
        public FrmNovaSenha()
        {
            InitializeComponent();
        }

        private void btnRedefinir_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            RedefinirSenha(usuario);
        }

        private void RedefinirSenha(Usuario objeto)
        {
            if (txtemailN.Text.Equals("") && txtsenhaN.Text.Equals(""))
            {
                MessageBox.Show("Informe as suas credenciais para Login!");
            }
            else
            {

                objeto.Email = txtemailN.Text;
                objeto.Senha = txtsenhaN.Text;

                controle.RedefinirSenha(objeto);
                limparCampos();


            }
        }


        public void limparCampos()
        {
            txtemailN.Text = "";
            txtsenhaN.Text = "";
        }
    }
}
