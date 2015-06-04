namespace MyWebPageForPWI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Zdjecies",
                c => new
                    {
                        IdZdjecie = c.Int(nullable: false, identity: true),
                        Tytul = c.String(),
                        Opis = c.String(),
                    })
                .PrimaryKey(t => t.IdZdjecie);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Zdjecies");
        }
    }
}
