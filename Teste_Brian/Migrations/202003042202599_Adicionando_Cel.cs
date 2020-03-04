namespace App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adicionando_Cel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Telefone", "Cel", c => c.String(maxLength: 9));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Telefone", "Cel", c => c.String());
        }
    }
}
