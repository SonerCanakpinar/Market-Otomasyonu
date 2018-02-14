namespace Kurs.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategoriler", "KDV", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kategoriler", "KDV");
        }
    }
}
