using ExemploEF6.Domain;
using ExemploEF6.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEF6.Services
{
    public class ContatoService : IContatoService
    {
        private readonly IContatoApplication application;

        public ContatoService(IContatoApplication application)
        {
            this.application = application;
        }

        public async Task Atualizar(Contato contato)
        {
            try
            {
                await application.Atualizar(contato);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task Cadastrar(Contato contato)
        {
            try
            {
                await application.Cadastrar(contato);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task Excluir(int codigo)
        {
            try
            {
                await application.Excluir(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Contato> Listar()
        {
            try
            {
                var result = application.Listar();
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Contato PesquisarPeloCodigo(int codigo)
        {
            try
            {
                var result = application.PesquisarPeloCodigo(codigo);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Contato> PesquisarPeloNome(string nome)
        {
            try
            {
                var result = application.PesquisarPeloNome(nome);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
