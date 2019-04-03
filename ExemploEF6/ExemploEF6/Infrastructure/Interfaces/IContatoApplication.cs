using ExemploEF6.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEF6.Infrastructure.Interfaces
{
    public interface IContatoApplication
    {
        Task Cadastrar(Contato contato);
        Task Atualizar(Contato contato);
        Task Excluir(int codigo);
        List<Contato> Listar();
        Contato PesquisarPeloCodigo(int codigo);
        List<Contato> PesquisarPeloNome(string nome);
    }
}
