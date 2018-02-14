namespace Kurs.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        KategoriID = c.Int(nullable: false, identity: true),
                        KategoriAdi = c.String(nullable: false, maxLength: 30),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.KategoriID);
            
            CreateTable(
                "dbo.Urunler",
                c => new
                    {
                        UrunID = c.Int(nullable: false, identity: true),
                        UrunAdi = c.String(nullable: false, maxLength: 40),
                        BirimFiyat = c.Decimal(precision: 18, scale: 2),
                        KategoriID = c.Int(nullable: false),
                        TedarikciID = c.Int(nullable: false),
                        Discounted = c.Byte(nullable: false),
                        AlisTarihi = c.DateTime(nullable: false),
                        SatisTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UrunID)
                .ForeignKey("dbo.Kategoriler", t => t.KategoriID, cascadeDelete: true)
                .ForeignKey("dbo.Tedarikcis", t => t.TedarikciID, cascadeDelete: true)
                .Index(t => t.KategoriID)
                .Index(t => t.TedarikciID);
            
            CreateTable(
                "dbo.Tedarikcis",
                c => new
                    {
                        TedarikciID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false, maxLength: 40),
                        ContactName = c.String(nullable: false, maxLength: 40),
                        Adres = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => t.TedarikciID);
            
            CreateTable(
                "dbo.Müsteriler",
                c => new
                    {
                        MusteriID = c.Int(nullable: false, identity: true),
                        MusteriAdi = c.String(nullable: false, maxLength: 40),
                        Adres = c.String(nullable: false, maxLength: 40),
                        Telefon = c.String(),
                    })
                .PrimaryKey(t => t.MusteriID);
            
            CreateTable(
                "dbo.Satislar",
                c => new
                    {
                        SatisID = c.Int(nullable: false, identity: true),
                        UrunID = c.Int(nullable: false),
                        UrunAdi = c.String(),
                        Adet = c.Short(nullable: false),
                        BirimFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.SatisID);
            
            CreateTable(
                "dbo.SiparisDetaylari",
                c => new
                    {
                        SiparisID = c.Int(nullable: false),
                        UrunID = c.Int(nullable: false),
                        BirimFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Adet = c.Short(nullable: false),
                        Discount = c.Single(nullable: false),
                    })
                .PrimaryKey(t => new { t.SiparisID, t.UrunID })
                .ForeignKey("dbo.Siparis", t => t.SiparisID, cascadeDelete: true)
                .ForeignKey("dbo.Urunler", t => t.UrunID, cascadeDelete: true)
                .Index(t => t.SiparisID)
                .Index(t => t.UrunID);
            
            CreateTable(
                "dbo.Siparis",
                c => new
                    {
                        SiparisID = c.Int(nullable: false, identity: true),
                        SiparisTarihi = c.DateTime(),
                        TeslimTarihi = c.DateTime(),
                        Freight = c.Decimal(precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Discount = c.Single(nullable: false),
                        Customer = c.String(),
                        Shipper = c.String(),
                    })
                .PrimaryKey(t => t.SiparisID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SiparisDetaylari", "UrunID", "dbo.Urunler");
            DropForeignKey("dbo.SiparisDetaylari", "SiparisID", "dbo.Siparis");
            DropForeignKey("dbo.Urunler", "TedarikciID", "dbo.Tedarikcis");
            DropForeignKey("dbo.Urunler", "KategoriID", "dbo.Kategoriler");
            DropIndex("dbo.SiparisDetaylari", new[] { "UrunID" });
            DropIndex("dbo.SiparisDetaylari", new[] { "SiparisID" });
            DropIndex("dbo.Urunler", new[] { "TedarikciID" });
            DropIndex("dbo.Urunler", new[] { "KategoriID" });
            DropTable("dbo.Siparis");
            DropTable("dbo.SiparisDetaylari");
            DropTable("dbo.Satislar");
            DropTable("dbo.Müsteriler");
            DropTable("dbo.Tedarikcis");
            DropTable("dbo.Urunler");
            DropTable("dbo.Kategoriler");
        }
    }
}
