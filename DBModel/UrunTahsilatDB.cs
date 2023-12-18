using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TahsilatUyg_.DBModel
{
    public partial class UrunTahsilatDB : DbContext
    {
        public UrunTahsilatDB()
            : base("name=UrunTahsilatDBConnectionString")
        {
        }

        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TBL_KEFIL> TBL_KEFIL { get; set; }
        public virtual DbSet<TBL_MUSTERI> TBL_MUSTERI { get; set; }
        public virtual DbSet<TBL_ODENEN_TAKSITLER> TBL_ODENEN_TAKSITLER { get; set; }
        public virtual DbSet<TBL_TAKSIT_TARIH> TBL_TAKSIT_TARIH { get; set; }
        public virtual DbSet<TBL_TAKSITLER> TBL_TAKSITLER { get; set; }
        public virtual DbSet<TBL_URUNLER> TBL_URUNLER { get; set; }
        public virtual DbSet<TBL_ODEME_TAMAMLANAN> TBL_ODEME_TAMAMLANAN { get; set; }
        public virtual DbSet<MUSTERI_TAKSIT_BILGILERI> MUSTERI_TAKSIT_BILGILERI { get; set; }
        public virtual DbSet<MUSTERI_TAKSIT_BILGILERI2> MUSTERI_TAKSIT_BILGILERI2 { get; set; }
        public virtual DbSet<SATIS_TUTANAGI> SATIS_TUTANAGI { get; set; }
        public virtual DbSet<TAKSIT_DOKUMENTE> TAKSIT_DOKUMENTE { get; set; }
        public virtual DbSet<TARIH_BILGI> TARIH_BILGI { get; set; }
        public virtual DbSet<URUN_TAKSIT> URUN_TAKSIT { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TBL_KEFIL>()
                .Property(e => e.kefil_ad_soyad)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_KEFIL>()
                .Property(e => e.telno)
                .IsFixedLength();

            modelBuilder.Entity<TBL_KEFIL>()
                .Property(e => e.tc)
                .IsFixedLength();

            modelBuilder.Entity<TBL_MUSTERI>()
                .Property(e => e.ad_soyad)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_MUSTERI>()
                .Property(e => e.tc)
                .IsFixedLength();

            modelBuilder.Entity<TBL_MUSTERI>()
                .Property(e => e.vergi_kimlik_no)
                .IsFixedLength();

            modelBuilder.Entity<TBL_MUSTERI>()
                .Property(e => e.telno)
                .IsFixedLength();

            modelBuilder.Entity<TBL_MUSTERI>()
                .Property(e => e.adres)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_MUSTERI>()
                .HasMany(e => e.TBL_TAKSITLER)
                .WithRequired(e => e.TBL_MUSTERI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TBL_TAKSITLER>()
                .Property(e => e.musteri_not)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_URUNLER>()
                .Property(e => e.urun_ad)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_URUNLER>()
                .HasMany(e => e.TBL_TAKSITLER)
                .WithRequired(e => e.TBL_URUNLER)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MUSTERI_TAKSIT_BILGILERI>()
                .Property(e => e.Ad_Soyad)
                .IsUnicode(false);

            modelBuilder.Entity<MUSTERI_TAKSIT_BILGILERI>()
                .Property(e => e.Toplam_Borç)
                .HasPrecision(38, 2);

            modelBuilder.Entity<MUSTERI_TAKSIT_BILGILERI>()
                .Property(e => e.Toplam_Ödenen)
                .HasPrecision(38, 2);

            modelBuilder.Entity<MUSTERI_TAKSIT_BILGILERI>()
                .Property(e => e.Toplam_Kalan)
                .HasPrecision(38, 2);

            modelBuilder.Entity<MUSTERI_TAKSIT_BILGILERI>()
                .Property(e => e.Müşteri_Notu)
                .IsUnicode(false);

            modelBuilder.Entity<MUSTERI_TAKSIT_BILGILERI2>()
                .Property(e => e.Ad_Soyad)
                .IsUnicode(false);

            modelBuilder.Entity<MUSTERI_TAKSIT_BILGILERI2>()
                .Property(e => e.Toplam_Borç)
                .HasPrecision(38, 2);

            modelBuilder.Entity<SATIS_TUTANAGI>()
                .Property(e => e.ad_soyad)
                .IsUnicode(false);

            modelBuilder.Entity<SATIS_TUTANAGI>()
                .Property(e => e.urun_ad)
                .IsUnicode(false);

            modelBuilder.Entity<TAKSIT_DOKUMENTE>()
                .Property(e => e.urun_ad)
                .IsUnicode(false);

            modelBuilder.Entity<TARIH_BILGI>()
                .Property(e => e.AD_SOYAD)
                .IsUnicode(false);

            modelBuilder.Entity<TARIH_BILGI>()
                .Property(e => e.Ürün_Adı)
                .IsUnicode(false);

            modelBuilder.Entity<URUN_TAKSIT>()
                .Property(e => e.urun_ad)
                .IsUnicode(false);
        }
    }
}
