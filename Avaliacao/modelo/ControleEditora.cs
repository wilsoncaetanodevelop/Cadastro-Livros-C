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
    class ControleEditora
    {

        EditoraDao editoraDao = new EditoraDao();

        public DataTable Listar()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = editoraDao.Listar();
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Salvar(Editora objeto)
        {
            try
            {
                editoraDao.Salvar(objeto);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Editar(Editora objeto)
        {
            try
            {
                editoraDao.Editar(objeto);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Excluir(Editora objeto)
        {
            try
            {
                editoraDao.Excluir(objeto);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public DataTable Buscar(Editora objeto)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = editoraDao.Buscar(objeto);
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
