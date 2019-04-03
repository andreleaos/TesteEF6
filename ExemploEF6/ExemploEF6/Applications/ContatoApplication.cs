using ExemploEF6.Domain;
using ExemploEF6.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEF6.Applications
{
    public class ContatoApplication : IContatoApplication
    {
        private readonly IContatoRepository repository;

        public ContatoApplication(IContatoRepository repository)
        {
            this.repository = repository;
        }

        public async Task Atualizar(Contato contato)
        {
            repository.Atualizar(contato);
            await repository.UnitOfWork.SaveChangesAsync();

        }

        public async Task Cadastrar(Contato contato)
        {
            repository.Cadastrar(contato);
            await repository.UnitOfWork.SaveChangesAsync();

        }

        public async Task Excluir(int codigo)
        {
            repository.Excluir(codigo);
            await repository.UnitOfWork.SaveChangesAsync();
        }

        public List<Contato> Listar()
        {
            var result = repository.Listar();
            return result;
        }

        public Contato PesquisarPeloCodigo(int codigo)
        {
            var result = repository.PesquisarPeloCodigo(codigo);
            return result;
        }

        public List<Contato> PesquisarPeloNome(string nome)
        {
            var result = repository.PesquisarPeloNome(nome);
            return result;
        }
    }
}
