namespace Kurs.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a8 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Urunler", "SatistaMi", c => c.Boolean(nullable: false));
            DropColumn("dbo.Urunler", "BirimFiyat");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Urunler", "BirimFiyat", c => c.Decimal(precision: 18, scale: 2));
            DropColumn("dbo.Urunler", "SatistaMi");
        }
    }
}
