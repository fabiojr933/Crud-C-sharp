using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SistemaMSQL.Conexao;
using SistemaMSQL.Entidades;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaMSQL.DAO
{
    public class LoginDAO
    {
        public bool tem = false;
        public String mensagem = "";
        MySqlDataReader dr;
        MySqlCommand sql;
        ConectaBanco con = new ConectaBanco();

        public bool Logar(String login, String senha)
        {
            try
            {
                tem = false;
                con.AbrirConexao();
                sql = new MySqlCommand("select * from login where usuario = @usuario and senha = @senha", con.con);
                sql.Parameters.AddWithValue("@usuario", login);
                sql.Parameters.AddWithValue("@senha", senha);
                dr = sql.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                    con.fecharConexao();
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tantar encontrar usuario e senha"  + ex.Message);
            }
            return tem;
        }
        public LoginUsuario login2(LoginUsuario login)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("select * from login where usuario = @usuario and senha = @senha", con.con);
                sql.Parameters.AddWithValue("@usuario", login.Usuario);
                sql.Parameters.AddWithValue("@senha", login.Senha);
                MySqlDataReader dr;
                dr = sql.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        login.Usuario = Convert.ToString(dr["usuario"]);
                        login.Senha = Convert.ToString(dr["senha"]);
                    }

                }
                else
                {
                    login.Usuario = null;
                }
                return login;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
