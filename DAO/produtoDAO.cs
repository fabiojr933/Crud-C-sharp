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
    public class produtoDAO
    {
        MySqlCommand sql;
        ConectaBanco con = new ConectaBanco();

        public void cadastrarProdutos(Produtos produto)    // cadastrar produto
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("INSERT INTO PRODUTO(descricao, referencia, marca, ncm, codigoean, estoque, preco) VALUES(@descricao, @referencia, @marca, @ncm, @codigoean, @estoque, @preco)", con.con);
                sql.Parameters.AddWithValue("@descricao", produto.Descricao);
                sql.Parameters.AddWithValue("@referencia", produto.Referencia);
                sql.Parameters.AddWithValue("@marca", produto.Marca);
                sql.Parameters.AddWithValue("@ncm", produto.Ncm);
                sql.Parameters.AddWithValue("@codigoean", produto.Codigoean);
                sql.Parameters.AddWithValue("@estoque", produto.Estoque);
                sql.Parameters.AddWithValue("@preco", produto.Preco);
                sql.ExecuteNonQuery();
                con.fecharConexao();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops! ocorreu um erro ao cadastrar produto");
            }
        }
        public DataTable BuscarDados()
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("select * from produto", con.con);
                MySqlDataAdapter buscar = new MySqlDataAdapter();
                buscar.SelectCommand = sql;
                DataTable dt = new DataTable();
                buscar.Fill(dt);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AtualizarProdutos(Produtos produto)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("update produto set descricao = @descricao, referencia = @referencia, marca = @marca, ncm = @ncm, codigoean = @codigoean, estoque = @estoque, preco = @preco where id = @id", con.con);
                sql.Parameters.AddWithValue("@descricao", produto.Descricao);
                sql.Parameters.AddWithValue("@referencia", produto.Referencia);
                sql.Parameters.AddWithValue("@marca", produto.Marca);
                sql.Parameters.AddWithValue("@ncm", produto.Ncm);
                sql.Parameters.AddWithValue("@codigoean", produto.Codigoean);
                sql.Parameters.AddWithValue("@estoque", produto.Estoque);
                sql.Parameters.AddWithValue("@preco", produto.Preco);
                sql.Parameters.AddWithValue("@id", produto.Id);
                sql.ExecuteNonQuery();
                con.fecharConexao();
                MessageBox.Show("Produto atualizado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops! ocorreu um erro ao ATUALIZAR produtos" + ex.Message);
            }
        }
        public void DeletarProduto(Produtos produto)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("delete from produto where id = @id", con.con);
                sql.Parameters.AddWithValue("@id", produto.Id);
                sql.ExecuteNonQuery();
                con.fecharConexao();
                MessageBox.Show("Produto deletado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops! ocorreu um erro ao deletar Produto " + ex.Message);
            }
        }
        public DataTable PesquisarProduto(Produtos produto)
        {
            try
            {
                con.AbrirConexao();
                sql = new MySqlCommand("select * from produto where descricao LIKE @descricao", con.con);
                sql.Parameters.AddWithValue("@descricao", produto.Descricao+"%");
                MySqlDataAdapter dt = new MySqlDataAdapter();
                dt.SelectCommand = sql;
                DataTable da = new DataTable();
                dt.Fill(da);
                return da;                
            }
            catch (Exception )
            {
                throw;
            }

        }
    }
}
