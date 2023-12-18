namespace TahsilatUyg_.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MUSTERI_TAKSIT_BILGILERI
    {
        [Key]
        [Column("Müşteri Id", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Müşteri_Id { get; set; }

        [Key]
        [Column("Ad Soyad", Order = 1)]
        [StringLength(30)]
        public string Ad_Soyad { get; set; }

        [Column("Toplam Borç")]
        public decimal? Toplam_Borç { get; set; }

        [Column("Toplam Ödenen")]
        public decimal? Toplam_Ödenen { get; set; }

        [Column("Toplam Kalan")]
        public decimal? Toplam_Kalan { get; set; }

        [Column("Müşteri Notu")]
        [StringLength(100)]
        public string Müşteri_Notu { get; set; }

        [Column("Maksimum Taksit Miktarı")]
        public int? Maksimum_Taksit_Miktarı { get; set; }
    }
}
