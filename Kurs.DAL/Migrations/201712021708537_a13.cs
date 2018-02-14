namespace Kurs.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a13 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Urunler", "StokMiktari", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Urunler", "StokMiktari");
        }
    }
}
