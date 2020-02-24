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
    public class VendasModel
    {
        VendasDAO dao = new VendasDAO();
        public void salvarVenda(Venda venda)
        {
            try
            {
                dao.salvarVenda(venda);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public object ListarVendas(Venda venda)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.listarVendas();
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
                dao.EditarVenda(venda);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void ExcluirVenda(Venda venda)
        {
            try
            {
                dao.ExcluirVenda(venda);              
            }
            catch (Exception)
            {

                throw;
            }
        }
        public object BucarVendas(Venda venda)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = dao.Buscar(venda);
                return dt;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
