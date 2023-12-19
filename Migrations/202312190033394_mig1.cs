namespace TahsilatUyg_.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MUSTERI_TAKSIT_BILGILERI",
                c => new
                    {
                        MüşteriId = c.Int(name: "Müşteri Id", nullable: false),
                        AdSoyad = c.String(name: "Ad Soyad", nullable: false, maxLength: 30, unicode: false),
                        ToplamBorç = c.Decimal(name: "Toplam Borç", precision: 38, scale: 2),
                        ToplamÖdenen = c.Decimal(name: "Toplam Ödenen", precision: 38, scale: 2),
                        ToplamKalan = c.Decimal(name: "Toplam Kalan", precision: 38, scale: 2),
                        MüşteriNotu = c.String(name: "Müşteri Notu", maxLength: 100, unicode: false),
                        MaksimumTaksitMiktarı = c.Int(name: "Maksimum Taksit Miktarı"),
                    })
                .PrimaryKey(t => new { t.MüşteriId, t.AdSoyad });
            
            CreateTable(
                "dbo.MUSTERI_TAKSIT_BILGILERI2",
                c => new
                    {
                        MüşteriId = c.Int(name: "Müşteri Id", nullable: false),
                        AdSoyad = c.String(name: "Ad Soyad", nullable: false, maxLength: 30, unicode: false),
                        ToplamBorç = c.Decimal(name: "Toplam Borç", precision: 38, scale: 2),
                        ToplamÖdenen = c.Decimal(name: "Toplam Ödenen", precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.MüşteriId, t.AdSoyad });
            
            CreateTable(
                "dbo.SATIS_TUTANAGI",
                c => new
                    {
                        ad_soyad = c.String(nullable: false, maxLength: 30, unicode: false),
                        urun_ad = c.String(nullable: false, maxLength: 60, unicode: false),
                        musteri_id = c.Int(nullable: false),
                        odenen_miktar = c.Decimal(precision: 18, scale: 2),
                        tarih = c.DateTime(storeType: "date"),
                        EksikTutar = c.Decimal(name: "Eksik Tutar", precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.ad_soyad, t.urun_ad, t.musteri_id });
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
            CreateTable(
                "dbo.TAKSIT_DOKUMENTE",
                c => new
                    {
                        musteri_id = c.Int(nullable: false),
                        urun_ad = c.String(nullable: false, maxLength: 60, unicode: false),
                        odenen_miktar = c.Decimal(precision: 18, scale: 2),
                        tarih = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => new { t.musteri_id, t.urun_ad });
            
            CreateTable(
                "dbo.TARIH_BILGI",
                c => new
                    {
                        ADSOYAD = c.String(name: "AD SOYAD", nullable: false, maxLength: 30, unicode: false),
                        ÜrünAdı = c.String(name: "Ürün Adı", nullable: false, maxLength: 60, unicode: false),
                        KalanTutar = c.Decimal(name: "Kalan Tutar", nullable: false, precision: 18, scale: 2),
                        musteri_id = c.Int(nullable: false),
                        AlışTarihi = c.DateTime(name: "Alış Tarihi", storeType: "date"),
                        AylıkTaksitTutarı = c.Decimal(name: "Aylık Taksit Tutarı", precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.ADSOYAD, t.ÜrünAdı, t.KalanTutar, t.musteri_id });
            
            CreateTable(
                "dbo.TBL_KEFIL",
                c => new
                    {
                        kefil_id = c.Int(nullable: false, identity: true),
                        musteri_id = c.Int(),
                        kefil_ad_soyad = c.String(maxLength: 60, unicode: false),
                        telno = c.String(maxLength: 11, fixedLength: true),
                        tc = c.String(maxLength: 11, fixedLength: true),
                    })
                .PrimaryKey(t => t.kefil_id)
                .ForeignKey("dbo.TBL_MUSTERI", t => t.musteri_id)
                .Index(t => t.musteri_id);
            
            CreateTable(
                "dbo.TBL_MUSTERI",
                c => new
                    {
                        musteri_id = c.Int(nullable: false, identity: true),
                        ad_soyad = c.String(nullable: false, maxLength: 30, unicode: false),
                        tc = c.String(nullable: false, maxLength: 11, fixedLength: true),
                        vergi_kimlik_no = c.String(maxLength: 10, fixedLength: true),
                        telno = c.String(nullable: false, maxLength: 11, fixedLength: true),
                        adres = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.musteri_id);
            
            CreateTable(
                "dbo.TBL_TAKSITLER",
                c => new
                    {
                        taksit_id = c.Int(nullable: false, identity: true),
                        musteri_id = c.Int(nullable: false),
                        urun_id = c.Int(nullable: false),
                        toplam_fiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        kac_taksit = c.Int(nullable: false),
                        odenen = c.Decimal(nullable: false, precision: 18, scale: 2),
                        kalan = c.Decimal(nullable: false, precision: 18, scale: 2),
                        musteri_not = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.taksit_id)
                .ForeignKey("dbo.TBL_URUNLER", t => t.urun_id)
                .ForeignKey("dbo.TBL_MUSTERI", t => t.musteri_id)
                .Index(t => t.musteri_id)
                .Index(t => t.urun_id);
            
            CreateTable(
                "dbo.TBL_URUNLER",
                c => new
                    {
                        urun_id = c.Int(nullable: false, identity: true),
                        urun_ad = c.String(nullable: false, maxLength: 60, unicode: false),
                        fiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.urun_id);
            
            CreateTable(
                "dbo.TBL_ODEME_TAMAMLANAN",
                c => new
                    {
                        tamamlanan_id = c.Int(nullable: false, identity: true),
                        taksit_id = c.Int(),
                        musteri_id = c.Int(),
                        urun_id = c.Int(),
                        fiyat = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.tamamlanan_id);
            
            CreateTable(
                "dbo.TBL_ODENEN_TAKSITLER",
                c => new
                    {
                        odenen_id = c.Int(nullable: false, identity: true),
                        taksit_id = c.Int(),
                        odenen_miktar = c.Decimal(precision: 18, scale: 2),
                        tarih = c.DateTime(storeType: "date"),
                        eksik_miktar = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.odenen_id);
            
            CreateTable(
                "dbo.TBL_TAKSIT_TARIH",
                c => new
                    {
                        taksit_tarih_id = c.Int(nullable: false, identity: true),
                        taksit_id = c.Int(),
                        eklenme_tarihi = c.DateTime(storeType: "date"),
                        taksit_tutar = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.taksit_tarih_id);
            
            CreateTable(
                "dbo.URUN_TAKSIT",
                c => new
                    {
                        taksit_id = c.Int(nullable: false),
                        urun_ad = c.String(nullable: false, maxLength: 60, unicode: false),
                        musteri_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.taksit_id, t.urun_ad, t.musteri_id });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TBL_TAKSITLER", "musteri_id", "dbo.TBL_MUSTERI");
            DropForeignKey("dbo.TBL_TAKSITLER", "urun_id", "dbo.TBL_URUNLER");
            DropForeignKey("dbo.TBL_KEFIL", "musteri_id", "dbo.TBL_MUSTERI");
            DropIndex("dbo.TBL_TAKSITLER", new[] { "urun_id" });
            DropIndex("dbo.TBL_TAKSITLER", new[] { "musteri_id" });
            DropIndex("dbo.TBL_KEFIL", new[] { "musteri_id" });
            DropTable("dbo.URUN_TAKSIT");
            DropTable("dbo.TBL_TAKSIT_TARIH");
            DropTable("dbo.TBL_ODENEN_TAKSITLER");
            DropTable("dbo.TBL_ODEME_TAMAMLANAN");
            DropTable("dbo.TBL_URUNLER");
            DropTable("dbo.TBL_TAKSITLER");
            DropTable("dbo.TBL_MUSTERI");
            DropTable("dbo.TBL_KEFIL");
            DropTable("dbo.TARIH_BILGI");
            DropTable("dbo.TAKSIT_DOKUMENTE");
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.SATIS_TUTANAGI");
            DropTable("dbo.MUSTERI_TAKSIT_BILGILERI2");
            DropTable("dbo.MUSTERI_TAKSIT_BILGILERI");
        }
    }
}
