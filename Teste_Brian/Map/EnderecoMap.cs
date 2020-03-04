using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Teste_Brian.Entities;

namespace Teste_Brian.Map
{
    class EnderecoMap : EntityTypeConfiguration<Endereco>
    {
        public EnderecoMap()
        {
            ToTable("Endereco");

            HasKey(x => x.Id);

            Property(x => x.Logradouro)
                .HasColumnName("Logradouro")
                .HasMaxLength(30);

            Property(x => x.TipoLogradouro)
                .HasColumnName("TipoLogradouro")
                .HasMaxLength(10);

            Property(x => x.Numero)
                .HasColumnName("Numero");

            Property(x => x.Bairro)
                .HasColumnName("Bairro")
                .HasMaxLength(15);

            Property(x => x.Cep)
                .HasColumnName("Cep")
                .HasMaxLength(8)
                .IsFixedLength();

            Property(x => x.Municipio)
                .HasColumnName("Municipio")
                .HasMaxLength(30);

            Property(x => x.Uf)
                .HasColumnName("Uf")
                .HasMaxLength(2)
                .IsFixedLength();
        }
    }
}
