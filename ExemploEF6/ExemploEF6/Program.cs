using ExemploEF6.Applications;
using ExemploEF6.Infrastructure.Contexts;
using ExemploEF6.Infrastructure.Interfaces;
using ExemploEF6.Infrastructure.Repositories;
using ExemploEF6.Services;
using ExemploEF6.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEF6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Task callTask = Task.Run(() => ExecuteTest());
                //callTask.Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }

        static async Task ExecuteTest()
        {
            var service = SetConfig();
            var teste = new ContatoTests(service);

            await teste.Cadastrar();
            teste.PesquisarPeloId();
            teste.PesquisarPeloNome();
            await teste.Atualizar();
            await teste.Excluir();
        }


        static IContatoService SetConfig()
        {
            var context = new ContatoContext();
            IContatoRepository repository = new ContatoRepository(context);
            IContatoApplication app = new ContatoApplication(repository);
            IContatoService service = new ContatoService(app);
            return service;
        }
    }
}

