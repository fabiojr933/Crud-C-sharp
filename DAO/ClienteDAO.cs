using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaMSQL.Conexao;
using SistemaMSQL.Entidades;


namespace SistemaMSQL.DAO
{
    public class ClienteDAO
    {
        //   String conexao = "SERVER=localhost; DATABASE=sistemamysql; UID=root; PWD=;";
        //   MySqlConnection con = null;

        MySqlCommand sql;
        ConectaBanco con = new ConectaBanco();

        public DataTable buscarDados()   //metedo para buscar datos da tabela Clientes
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("select * from clientes", con.con);
                MySqlDataAdapter buscar = new MySqlDataAdapter();
                buscar.SelectCommand = sql;
                DataTable dt = new DataTable();
                buscar.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void salvarCliente(Clientes dados)  //metedo salvar cliente
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("insert into clientes(nome, sexo, nascimento, idade, celular, endereco) values(@nome, @sexo, @nascimento, @idade, @celular, @endereco)", con.con);
                sql.Parameters.AddWithValue("@nome", dados.Nome);
                sql.Parameters.AddWithValue("@sexo", dados.Sexo);
                sql.Parameters.AddWithValue("@nascimento", dados.Nascimento);
                sql.Parameters.AddWithValue("@idade", dados.Idade);
                sql.Parameters.AddWithValue("@celular", dados.Celular);
                sql.Parameters.AddWithValue("@endereco", dados.Endereco);
                sql.ExecuteNonQuery();
                con.fecharConexao();
            }
            catch (Exception)
            {
                MessageBox.Show("Ops! Ocorreu uma falha ao salvar dados");
            }
        }
        public void editarCliente(Clientes dados)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("update clientes set nome = @nome, sexo = @sexo, nascimento = @nascimento, idade = @idade, celular = @celular, endereco = @endereco where id = @id", con.con);
                sql.Parameters.AddWithValue("@nome", dados.Nome);
                sql.Parameters.AddWithValue("@sexo", dados.Sexo);
                sql.Parameters.AddWithValue("@nascimento", dados.Nascimento);
                sql.Parameters.AddWithValue("@idade", dados.Idade);
                sql.Parameters.AddWithValue("@celular", dados.Celular);
                sql.Parameters.AddWithValue("@endereco", dados.Endereco);
                sql.Parameters.AddWithValue("@id", dados.Id);
                sql.ExecuteNonQuery();
                con.fecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops! ocorreu um erro ao EDITAR um cliente " + ex.Message);
            }
        }
        public void excluirCliente(Clientes dados)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("delete from clientes where id = @id", con.con);
                sql.Parameters.AddWithValue("@id", dados.Id);
                sql.ExecuteNonQuery();
                con.fecharConexao();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ops! ocorreu um erro ao excluir o cliente " + ex.Message);
            }
        }
        public DataTable Pesquisar(Clientes dados)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("select * from clientes where nome like @nome", con.con);
                sql.Parameters.AddWithValue("@nome", dados.Nome+"%");
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
