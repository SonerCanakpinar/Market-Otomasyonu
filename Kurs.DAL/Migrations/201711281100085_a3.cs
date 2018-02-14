namespace Kurs.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Satislar", "MusteriID", c => c.Int(nullable: false));
            CreateIndex("dbo.Satislar", "MusteriID");
            AddForeignKey("dbo.Satislar", "MusteriID", "dbo.Müsteriler", "MusteriID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Satislar", "MusteriID", "dbo.Müsteriler");
            DropIndex("dbo.Satislar", new[] { "MusteriID" });
            DropColumn("dbo.Satislar", "MusteriID");
        }
    }
}
