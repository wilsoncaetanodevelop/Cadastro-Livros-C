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
    public partial class FrmCadastro : Form
    {

        Controle controle = new Controle();

        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btncadas_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            Cadastro(usuario);
            limparCampos();

        }


        private void Cadastro(Usuario objeto)
        {
            if (txtemailC.Text.Equals("") && txtsenhaC.Text.Equals(""))
            {
                MessageBox.Show("Informe as suas credenciais para Cadastro!!!");
            }
            else
            {
                objeto.Email = txtemailC.Text;
                objeto.Senha = txtsenhaC.Text;

                controle.cadastar(objeto);


            }
        }

        public void limparCampos()
        {
             txtemailC.Text = "";
             txtsenhaC.Text = "";
        }

        
    }
}
