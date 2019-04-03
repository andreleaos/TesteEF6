using ExemploEF6.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEF6.Infrastructure.Mappings
{
    public class ContatoMapping : EntityTypeConfiguration<Contato>
    {
        public ContatoMapping()
        {
            HasKey(p => p.Id);

            Property(p => p.Id)
                .HasColumnOrder(0)
                .HasColumnType("int")
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(p => p.Nome)
                .HasColumnOrder(1)
                .HasColumnType("varchar")
                .IsRequired();

            Property(p => p.Email)
                .HasColumnOrder(2)
                .HasColumnType("varchar")
                .IsRequired();
        }
    }
}
