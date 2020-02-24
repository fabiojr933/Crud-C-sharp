using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMSQL.Entidades
{
    public class Venda
    {
        int id;
        DateTime data;
        decimal valor;
        int id_cliente;

        public int Id { get => id; set => id = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public DateTime Data { get => data; set => data = value; }
    }
}
