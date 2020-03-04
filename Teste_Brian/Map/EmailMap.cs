using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Teste_Brian.Entities;

namespace Teste_Brian.Map
{
    class EmailMap : EntityTypeConfiguration<Email>
    {
        public EmailMap()
        {
            ToTable("Email");

            HasKey(x => x.Id);

            Property(x => x.Endereco)
                .HasColumnName("Endereco")
                .HasMaxLength(20);
        }
    }
}
