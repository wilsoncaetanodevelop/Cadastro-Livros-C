using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao.dao
{
    class Conexao
    {

        String conexao = "Server=localhost;Database=sistema_livros;Uid=root;Pwd=1234567";

        public MySqlConnection con = null;

        public void AbrirConexao()
        {

            try
            {
                con = new MySqlConnection(conexao);
                con.Open();

            }
            catch (MySqlException e)
            {
                throw (e);
            }
        }

        public void Fecharconexao()
        {

            try
            {
                con = new MySqlConnection(conexao);
                con.Close();

            }
            catch (MySqlException e)
            {
                throw (e);
            }

        }

    }
}

