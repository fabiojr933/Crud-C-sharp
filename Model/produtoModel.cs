using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaMSQL.Entidades;
using SistemaMSQL.DAO;
using System.Data;

namespace SistemaMSQL.Model
{
    public class ProdutoModel
    {
        Produtos Produto = new Produtos();
        produtoDAO dao = new produtoDAO();

        public void cadastrarProduto(Produtos produto)   // cadastrar produto
        {
            try
            {
                dao.cadastrarProdutos(produto);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable listarProduto()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.BuscarDados();
                return dt;
            }
            catch (Exception)
            {

                throw;
            } 
        }
        public void atualizarProdutos(Produtos produto)
        {
            dao.AtualizarProdutos(produto);
        }
        public void deletarProduto(Produtos produto)
        {
            try
            {
                dao.DeletarProduto(produto);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public object pesquisarProduto(Produtos produto)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.PesquisarProduto(produto);
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
