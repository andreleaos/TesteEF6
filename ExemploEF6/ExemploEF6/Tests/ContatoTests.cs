using ExemploEF6.Domain;
using ExemploEF6.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEF6.Tests
{
    public class ContatoTests
    {
        private readonly IContatoService service;

        public ContatoTests(IContatoService service)
        {
            this.service = service;
        }

        public async Task Cadastrar()
        {
            var contatos = new List<Contato>();

            var contato = new Contato { Nome = "André Leão", Email = "andreleao@estudos.com.br" };
            contatos.Add(contato);
            contato = new Contato { Nome = "Maria Oliveira", Email = "maria.oliveira@testes.com.br" };
            contatos.Add(contato);
            contato = new Contato { Nome = "Sivaldo Muniz", Email = "sivaldo.muniz@hotmail.com" };
            contatos.Add(contato);
            contato = new Contato { Nome = "Giovana Muniz", Email = "gi.muniz@gmail.com" };
            contatos.Add(contato);

            foreach (var item in contatos)
            {
                await service.Cadastrar(item);
            }

        }

        public void Listar()
        {
            var contatos = service.Listar();
        }

        public void PesquisarPeloId()
        {
            var codigo = 2;
            var result = service.PesquisarPeloCodigo(codigo);
        }

        public void PesquisarPeloNome()
        {
            var nome = "André";
            var result = service.PesquisarPeloNome(nome);
        }

        public async Task Atualizar()
        {
            var codigo = 1;
            var contato = service.PesquisarPeloCodigo(codigo);
            contato.Nome = "André Leão da Silva";
            await service.Atualizar(contato);
        }

        public async Task Excluir()
        {
            var codigo = 4;
            await service.Excluir(codigo);
        }
    }
}
