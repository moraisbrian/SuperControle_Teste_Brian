using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Teste_Brian.Entities;

namespace Teste_Brian.Map
{
    class TelefoneMap : EntityTypeConfiguration<Telefone>
    {
        public TelefoneMap()
        {
            ToTable("Telefone");

            HasKey(x => x.Id);

            Property(x => x.Ddd)
                .HasColumnName("Ddd")
                .HasMaxLength(2)
                .IsFixedLength();

            Property(x => x.Numero)
                .HasColumnName("Numero")
                .HasMaxLength(9);
        }
    }
}
