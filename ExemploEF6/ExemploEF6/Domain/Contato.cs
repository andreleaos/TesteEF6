using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEF6.Domain
{
    public class Contato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public Contato()
        {

        }

        public Contato(int id, string nome, string email)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
        }

        public Contato(string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;
        }
    }
}
