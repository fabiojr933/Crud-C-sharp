using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMSQL.Entidades
{
    public class Produtos
    {
        int id;
        String descricao;
        String referencia;
        String marca;
        String ncm;
        String codigoean;
        String estoque;
        Decimal preco;

        public int Id { get => id; set => id = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Ncm { get => ncm; set => ncm = value; }
        public string Codigoean { get => codigoean; set => codigoean = value; }
        public string Estoque { get => estoque; set => estoque = value; }
        public string Referencia { get => referencia; set => referencia = value; }
        public decimal Preco { get => preco; set => preco = value; }
    }
}
