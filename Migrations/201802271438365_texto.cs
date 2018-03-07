namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class texto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pessoas", "texto", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pessoas", "texto");
        }
    }
}
