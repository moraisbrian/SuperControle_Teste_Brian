using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Teste_Brian.Map;
using Teste_Brian.Entities;

namespace Teste_Brian.Context
{
    class SystemContext : DbContext
    {
        public SystemContext() : base("connDB") { }

        public DbSet<Entidade> Entidade { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Email> Email { get; set; }
        public DbSet<Telefone> Telefone { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<SystemContext>(null);
            modelBuilder.Configurations.Add(new EntidadeMap());
            modelBuilder.Configurations.Add(new EnderecoMap());
            modelBuilder.Configurations.Add(new TelefoneMap());
            modelBuilder.Configurations.Add(new EmailMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
