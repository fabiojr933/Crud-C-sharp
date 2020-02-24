using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaMSQL.DAO;
using SistemaMSQL.Entidades;
     

namespace SistemaMSQL.Model
{
   public class LoginModel
    {
        public bool tem;
        public String mensagem = "";

        public bool logar(String login, String senha)
        {
            try
            {
                LoginDAO loginDAO = new LoginDAO();
                tem = loginDAO.Logar(login, senha);
                if (!loginDAO.mensagem.Equals(""))
                {
                    this.mensagem = loginDAO.mensagem;
                }
                return tem;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public LoginUsuario logar2(LoginUsuario login)
        {
            LoginDAO dao = new LoginDAO();
            try
            {
             return dao.login2(login);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
