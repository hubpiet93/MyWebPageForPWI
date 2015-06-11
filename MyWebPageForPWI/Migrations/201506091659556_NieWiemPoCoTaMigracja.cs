namespace MyWebPageForPWI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NieWiemPoCoTaMigracja : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Zdjecies", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Zdjecies", "UserId");
            AddForeignKey("dbo.Zdjecies", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Zdjecies", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Zdjecies", new[] { "UserId" });
            DropColumn("dbo.Zdjecies", "UserId");
        }
    }
}
