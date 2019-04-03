using ExemploEF6.Domain;
using ExemploEF6.Infrastructure.Contexts;
using ExemploEF6.Infrastructure.Interfaces;
using ExemploEF6.Infrastructure.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEF6.Infrastructure.Repositories
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly ContatoContext context;

        public IUnitOfWork UnitOfWork => context;


        public ContatoRepository(ContatoContext context)
        {
            this.context = context;
        }

        public void Atualizar(Contato contato)
        {
            var modificado = PesquisarPeloCodigo(contato.Id);

            context.Entry(modificado);
            context.Entry(modificado).CurrentValues["Nome"] = contato.Nome;
            context.Entry(modificado).CurrentValues["Email"] = contato.Email;
        }

        public void Cadastrar(Contato contato)
        {
            context.Contatos.Add(contato);
        }

        public void Excluir(int codigo)
        {
            var contato = PesquisarPeloCodigo(codigo);
            context.Contatos.Remove(contato);
        }

        public List<Contato> Listar()
        {
            var contatos = context.Contatos.ToList();
            return contatos;
        }

        public Contato PesquisarPeloCodigo(int codigo)
        {
            var contato = context.Contatos.SingleOrDefault(p => p.Id == codigo);
            return contato;
        }

        public List<Contato> PesquisarPeloNome(string nome)
        {
            var contato = context.Contatos.Where(p => p.Nome.Contains(nome)).ToList();
            return contato;
        }
    }
}
