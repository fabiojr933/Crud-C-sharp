using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SistemaMSQL.Conexao
{
    class ConectaBanco
    {
        String conexao = "SERVER=localhost; DATABASE=sistemamysql; UID=root; PWD=;";
       public MySqlConnection con = null;
       

        public void AbrirConexao()
        {
            try
            {
                con = new MySqlConnection(conexao);
                con.Open();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void fecharConexao()
        {
            try
            {
                con = new MySqlConnection(conexao);
                con.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
