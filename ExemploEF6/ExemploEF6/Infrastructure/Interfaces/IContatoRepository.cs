using ExemploEF6.Domain;
using ExemploEF6.Infrastructure.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEF6.Infrastructure.Interfaces
{
    public interface IContatoRepository
    {
        void Cadastrar(Contato contato);
        void Atualizar(Contato contato);
        void Excluir(int codigo);
        List<Contato> Listar();
        Contato PesquisarPeloCodigo(int codigo);
        List<Contato> PesquisarPeloNome(string nome);

        IUnitOfWork UnitOfWork { get; }

    }
}
