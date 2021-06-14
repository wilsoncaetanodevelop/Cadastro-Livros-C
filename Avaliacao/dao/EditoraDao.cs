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
    class EditoraDao
    {

        MySqlCommand sql;
        string sqlStr = "";
        Conexao conexao = new Conexao();

        public DataTable Listar()
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

        public void Salvar(Editora objeto)
        {
            try
            {
                conexao.AbrirConexao();
                sqlStr = $"INSERT INTO  editora (nome, edicao) VALUES  ('{objeto.Nome}', '{objeto.Edicao}')";
                sql = new MySqlCommand(sqlStr, conexao.con);
                sql.ExecuteNonQuery();
                conexao.Fecharconexao();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public void Editar(Editora objeto)
        {
            try
            {
                conexao.AbrirConexao();
                sqlStr = $"UPDATE editora SET nome='{objeto.Nome}', edicao='{objeto.Edicao}'  WHERE  id='{objeto.Id}'";
                sql = new MySqlCommand(sqlStr, conexao.con);
                sql.ExecuteNonQuery();
                conexao.Fecharconexao();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public void Excluir(Editora objeto)
        {

            try
            {
                conexao.AbrirConexao();
                sqlStr = $"DELETE FROM editora WHERE id='{objeto.Id}'";
                sql = new MySqlCommand(sqlStr, conexao.con);
                sql.ExecuteNonQuery();
                conexao.Fecharconexao();
            }
            catch (Exception e)
            {
                throw (e);
            }
        }

        public DataTable Buscar(Editora objeto)
        {
            try
            {
                conexao.AbrirConexao();
                sqlStr = $"SELECT * FROM editora WHERE nome LIKE '{objeto.Nome}'";
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
