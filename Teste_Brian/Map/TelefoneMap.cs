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

            Property(x => x.Ddd1)
                .HasColumnName("Ddd1")
                .HasMaxLength(2)
                .IsFixedLength();

            Property(x => x.Numero1)
                .HasColumnName("Numero1")
                .HasMaxLength(9);

            Property(x => x.Ddd2)
                .HasColumnName("Ddd2")
                .HasMaxLength(2)
                .IsFixedLength();

            Property(x => x.Numero2)
                .HasColumnName("Numero2")
                .HasMaxLength(9);

            Property(x => x.Cel)
                .HasColumnName("Cel")
                .HasMaxLength(9);
        }
    }
}
