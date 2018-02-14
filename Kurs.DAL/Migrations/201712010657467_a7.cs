namespace Kurs.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Urunler", "UrunBarkod", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Urunler", "UrunBarkod");
        }
    }
}
