using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaMSQL.Conexao;
using SistemaMSQL.Entidades;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace SistemaMSQL.DAO
{
    public class VendasDAO
    {
        MySqlCommand sql;
        ConectaBanco con = new ConectaBanco();

        public void salvarVenda(Venda venda)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("insert into vendas (data, valor, id_cliente) values(@data, @valor, @id_cliente)", con.con);
                sql.Parameters.AddWithValue("@data", venda.Data);
                sql.Parameters.AddWithValue("@valor", venda.Valor);
                sql.Parameters.AddWithValue("@id_cliente", venda.Id_cliente);
                sql.ExecuteNonQuery();
                con.fecharConexao();
                MessageBox.Show("Venda salvo com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ocorreu um erro ao inseri a venda");
            } 
        }
        public DataTable listarVendas()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("select * from vendas", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void EditarVenda(Venda venda)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("update vendas set data = @data, valor = @valor, id_cliente = @id_cliente where id = @id", con.con);
                sql.Parameters.AddWithValue("@data", venda.Data);
                sql.Parameters.AddWithValue("@valor", venda.Valor);
                sql.Parameters.AddWithValue("@id_cliente", venda.Id_cliente);
                sql.Parameters.AddWithValue("@id", venda.Id);
                sql.ExecuteNonQuery();
                con.fecharConexao();
                MessageBox.Show("Editado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro " + ex.Message);
                throw;
            }
        }
        public void ExcluirVenda(Venda venda)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("delete from vendas where id = @id", con.con);
                sql.Parameters.AddWithValue("@id", venda.Id);
                sql.ExecuteNonQuery();
                con.fecharConexao();
                MessageBox.Show("Excluido com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro " + ex.Message);
                throw;
            }
        }
        public DataTable Buscar(Venda venda)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("select * from vendas where id_cliente = @id_cliente", con.con);
                sql.Parameters.AddWithValue("@id_clientes", venda.Id_cliente);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sql;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
