namespace Kurs.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a5 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Satislar", "UrunID");
            AddForeignKey("dbo.Satislar", "UrunID", "dbo.Urunler", "UrunID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Satislar", "UrunID", "dbo.Urunler");
            DropIndex("dbo.Satislar", new[] { "UrunID" });
        }
    }
}
