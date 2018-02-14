namespace Kurs.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Urunler", "UrunResim", c => c.Binary());
            DropColumn("dbo.Urunler", "Discounted");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Urunler", "Discounted", c => c.Byte(nullable: false));
            DropColumn("dbo.Urunler", "UrunResim");
        }
    }
}
