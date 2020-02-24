using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMSQL.Entidades
{
    public class Clientes
    {
        int id;
        String nome, sexo;
        DateTime nascimento;
        int idade;
        String celular;
        String endereco;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime Nascimento { get => nascimento; set => nascimento = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Idade { get => idade; set => idade = value; }
        public string Celular { get => celular; set => celular = value; }
        public string Endereco { get => endereco; set => endereco = value; }
    }
}
