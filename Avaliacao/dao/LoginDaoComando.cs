using Avaliacao.entidades;
using Avaliacao.views;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao.dao
{
    class LoginDaoComando
    {

        bool tem = false;
        public String mensagem = "";

        MySqlCommand sql;
        string sqlStr = "";
        Conexao conexao = new Conexao();

       
        public void verificaLogin(Usuario objeto)
        {
            // comando sql se tem no banco 
            
            try{
                conexao.AbrirConexao();
                sqlStr = $"select * from usuario WHERE email = '{objeto.Email}' AND senha ='{objeto.Senha}'";
                sql = new MySqlCommand(sqlStr, conexao.con);
                MySqlDataReader dr = sql.ExecuteReader();
               
                if (dr.Read() == tem)
                {
                    MessageBox.Show("Dados incorretos!");
                   
                    

                }
                else
                {
                    BemVindo principal = new BemVindo();
                    principal.Show();
                    MessageBox.Show("Logado com sucesso. Sejam bem-vindo!");

                }
            }

            catch (MySqlException erro)

            {

                MessageBox.Show(erro + "Na conexão com o banco de dados");
            }

            finally
            {
                conexao.Fecharconexao();


            }
        }


        public void cadastrarDao(Usuario objeto)
        {
            //cadastra no banco
            try
            {
                conexao.AbrirConexao();
                sqlStr = $"INSERT INTO  usuario (email, senha) VALUES  ('{objeto.Email}', '{objeto.Senha}')";
                sql = new MySqlCommand(sqlStr, conexao.con);
                sql.ExecuteNonQuery();
                conexao.Fecharconexao();
                MessageBox.Show("Parabéns Usuario cadastrado com sucesso. Sejam bem-vindo!!");
            }
            catch (Exception e)
            {
                throw (e);
            }
        }


        public void RedefinirSenhaDao(Usuario objeto)
        {
            try
            {
                conexao.AbrirConexao();
                sqlStr = $"UPDATE usuario SET senha ='{objeto.Senha}' WHERE email ='{objeto.Email}'";
                sql = new MySqlCommand(sqlStr, conexao.con);
                sql.ExecuteNonQuery();
                conexao.Fecharconexao();
                MessageBox.Show("Parabéns Senha redefinida com sucesso!!");
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

    }  
}
