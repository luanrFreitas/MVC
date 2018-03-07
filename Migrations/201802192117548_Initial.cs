namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Cpf = c.String(nullable: false, maxLength: 11),
                        Nome = c.String(nullable: false, maxLength: 20),
                        Sobrenome = c.String(maxLength: 20),
                        DataNascimento = c.DateTime(nullable: false),
                        Email = c.String(),
                        Telefone = c.String(),
                    })
                .PrimaryKey(t => t.Codigo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pessoas");
        }
    }
}
