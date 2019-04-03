using ExemploEF6.Domain;
using ExemploEF6.Infrastructure.Mappings;
using ExemploEF6.Infrastructure.SeedWork;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExemploEF6.Infrastructure.Contexts
{
    public class ContatoContext : DbContext, IUnitOfWork
    {
        public ContatoContext()
            : base("name=dbCadastro")
        {

        }

        public DbSet<Contato> Contatos { get; set; }

        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            await base.SaveChangesAsync();

            return true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new ContatoMapping());


            base.OnModelCreating(modelBuilder);
        }
    }
}
