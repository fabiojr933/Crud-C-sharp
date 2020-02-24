using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaMSQL.DAO;
using SistemaMSQL.Entidades;

namespace SistemaMSQL.Model
{
    public class ClienteModel  //metedo para listar cliente na Datagrid
    {
        ClienteDAO dao = new ClienteDAO();

        public DataTable listar()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.buscarDados();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void salvarCliente(Clientes dados)   //metedo para salvar cliente 
        {
            try
            {
                dao.salvarCliente(dados);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void editarClientes(Clientes dados) // metedo editar cliente
        {
            try
            {
                dao.editarCliente(dados);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void excluirCliente(Clientes dados)
        {
            try
            {
                dao.excluirCliente(dados);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public object Pesquisar(Clientes dados)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.Pesquisar(dados);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
