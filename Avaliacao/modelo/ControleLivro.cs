using Avaliacao.dao;
using Avaliacao.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao.modelo
{
    class ControleLivro
    {

        LivroDao livroDao = new LivroDao();

        public DataTable Listar()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = livroDao.Listar();
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public DataTable BuscarNome(Livros objeto)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = livroDao.BuscarNomeDao(objeto);
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public DataTable BuscarId(Livros objeto)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = livroDao.BuscarIdDao(objeto);
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Salvar(Livros objeto)
        {
            try
            {
                livroDao.Salvar(objeto);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Livros objeto)
        {
            try
            {
                livroDao.Excluir(objeto);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Editar(Livros objeto)
        {
            try
            {
                livroDao.Editar(objeto);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public DataTable Buscar(Livros objeto)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = livroDao.Buscar(objeto);
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public DataTable EditoraNome()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = livroDao.EditoraNome();
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
