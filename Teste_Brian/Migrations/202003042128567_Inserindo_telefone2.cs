namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inserindo_telefone2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Telefone", "Ddd1", c => c.String(maxLength: 2, fixedLength: true));
            AddColumn("dbo.Telefone", "Numero1", c => c.String(maxLength: 9));
            AddColumn("dbo.Telefone", "Ddd2", c => c.String(maxLength: 2, fixedLength: true));
            AddColumn("dbo.Telefone", "Numero2", c => c.String(maxLength: 9));
            AddColumn("dbo.Telefone", "Cel", c => c.String());
            AlterColumn("dbo.Endereco", "Numero", c => c.Int());
            DropColumn("dbo.Telefone", "Ddd");
            DropColumn("dbo.Telefone", "Numero");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Telefone", "Numero", c => c.String(maxLength: 9));
            AddColumn("dbo.Telefone", "Ddd", c => c.String(maxLength: 2, fixedLength: true));
            AlterColumn("dbo.Endereco", "Numero", c => c.Int(nullable: false));
            DropColumn("dbo.Telefone", "Cel");
            DropColumn("dbo.Telefone", "Numero2");
            DropColumn("dbo.Telefone", "Ddd2");
            DropColumn("dbo.Telefone", "Numero1");
            DropColumn("dbo.Telefone", "Ddd1");
        }
    }
}
