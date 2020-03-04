using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Teste_Brian.Entities;

namespace Teste_Brian.Map
{
    class EntidadeMap : EntityTypeConfiguration<Entidade>
    {
        public EntidadeMap()
        {
            ToTable("Entidade");

            HasKey(x => x.Id);

            Property(x => x.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(50);

            Property(x => x.Cpf)
                .HasColumnName("Cpf")
                .HasMaxLength(11)
                .IsFixedLength();

            Property(x => x.Cnpj)
                .HasColumnName("Cnpj")
                .HasMaxLength(14)
                .IsFixedLength();

            Property(x => x.DtNasc)
                .HasColumnName("DtNasc");

            Property(x => x.DtCadastro)
                .HasColumnName("DtCadastro");

            Property(x => x.PessoaFisica)
                .HasColumnName("PessoaFisica");

            Property(x => x.Identificador)
                .HasColumnName("Identificador");

            HasOptional(x => x.Email)
                .WithRequired(x => x.Entidade);

            HasOptional(x => x.Telefone)
                .WithRequired(x => x.Entidade);

            HasOptional(x => x.Endereco)
                .WithRequired(x => x.Entidade);
        }
    }
}
