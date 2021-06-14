using Avaliacao.entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao.dao
{
    class LivroDao
    {

        MySqlCommand sql;
        string sqlStr = "";
        Conexao conexao = new Conexao();

        public DataTable Listar()
        {
            try
            {
                conexao.AbrirConexao();
                sqlStr = "SELECT * FROM livros";
                sql = new MySqlCommand(sqlStr, conexao.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;


            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public void Salvar(Livros objeto)
        {
            try
            {
                conexao.AbrirConexao();
                sqlStr = $"INSERT INTO  livros (nomeLivro, nomeAutor, titulo, anoPublicacao,idEditora) VALUES  ('{objeto.NomeLivro}', '{objeto.NomeAutor}','{objeto.Titulo}','{objeto.AnoPublicacao.ToString("yyyy-MM-dd")}','{objeto.IdEditora}')";
                sql = new MySqlCommand(sqlStr, conexao.con);
                sql.ExecuteNonQuery();
                conexao.Fecharconexao();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public void Excluir(Livros objeto)
        {

            try
            {
                conexao.AbrirConexao();
                sqlStr = $"DELETE FROM livros WHERE id='{objeto.Id}'";
                sql = new MySqlCommand(sqlStr, conexao.con);
                sql.ExecuteNonQuery();
                conexao.Fecharconexao();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public void Editar(Livros objeto)
        {

            try
            {
                conexao.AbrirConexao();
                sqlStr = $"UPDATE livros SET nomeLivro='{objeto.NomeLivro}', nomeAutor='{objeto.NomeAutor}', titulo='{objeto.Titulo}', anoPublicacao='{objeto.AnoPublicacao.ToString("yyyy-MM-dd")}', idEditora='{objeto.IdEditora}'  WHERE  id='{objeto.Id}'";
                sql = new MySqlCommand(sqlStr, conexao.con);
                sql.ExecuteNonQuery();
                conexao.Fecharconexao();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }


        public DataTable BuscarNomeDao(Livros objeto)
        {
            try
            {
                conexao.AbrirConexao();
                sqlStr = $"SELECT * FROM livros WHERE nomeLivro LIKE '{objeto.NomeLivro}'";
                sql = new MySqlCommand(sqlStr, conexao.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }


        public DataTable BuscarIdDao(Livros objeto)
        {
            try
            {
                conexao.AbrirConexao();
                sqlStr = $"SELECT * FROM livros WHERE id LIKE '{objeto.Id}'";
                sql = new MySqlCommand(sqlStr, conexao.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public DataTable Buscar(Livros objeto)
        {
            try
            {
                conexao.AbrirConexao();
                sqlStr = $"SELECT * FROM livros WHERE nomeLivro LIKE '{objeto.NomeLivro}'";
                sql = new MySqlCommand(sqlStr, conexao.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                throw (e);
            }
        }


        public DataTable EditoraNome()
        {
            try
            {
                conexao.AbrirConexao();
                sqlStr = "SELECT * FROM editora";
                sql = new MySqlCommand(sqlStr, conexao.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;


            }
            catch (Exception e)
            {
                throw (e);
            }
        }

    }
}
