namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Email",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Endereco = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Entidade", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Entidade",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 50),
                        Cpf = c.String(maxLength: 11, fixedLength: true),
                        Cnpj = c.String(maxLength: 14, fixedLength: true),
                        DtNasc = c.DateTime(nullable: false),
                        DtCadastro = c.DateTime(nullable: false),
                        PessoaFisica = c.Boolean(nullable: false),
                        Identificador = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Logradouro = c.String(maxLength: 30),
                        TipoLogradouro = c.String(maxLength: 10),
                        Numero = c.Int(nullable: false),
                        Bairro = c.String(maxLength: 15),
                        Cep = c.String(maxLength: 8, fixedLength: true),
                        Municipio = c.String(maxLength: 30),
                        Uf = c.String(maxLength: 2, fixedLength: true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Entidade", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Telefone",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Ddd = c.String(maxLength: 2, fixedLength: true),
                        Numero = c.String(maxLength: 9),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Entidade", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Telefone", "Id", "dbo.Entidade");
            DropForeignKey("dbo.Endereco", "Id", "dbo.Entidade");
            DropForeignKey("dbo.Email", "Id", "dbo.Entidade");
            DropIndex("dbo.Telefone", new[] { "Id" });
            DropIndex("dbo.Endereco", new[] { "Id" });
            DropIndex("dbo.Email", new[] { "Id" });
            DropTable("dbo.Telefone");
            DropTable("dbo.Endereco");
            DropTable("dbo.Entidade");
            DropTable("dbo.Email");
        }
    }
}
