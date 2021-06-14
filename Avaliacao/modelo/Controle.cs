using Avaliacao.dao;
using Avaliacao.entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao.modelo
{
    class Controle
    {

        LoginDaoComando loginDao = new LoginDaoComando();

      

        public void acessar (Usuario objeto)
        {
            loginDao.verificaLogin(objeto);
               
            
        }

        public void cadastar(Usuario objeto)
        {
            try
            {
                loginDao.cadastrarDao(objeto);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

       public void RedefinirSenha(Usuario objeto)
        {
            try
            {
                loginDao.RedefinirSenhaDao(objeto);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
