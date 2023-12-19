namespace TahsilatUyg_
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TARIH_BILGI
    {
        [Key]
        [Column("AD SOYAD", Order = 0)]
        [StringLength(30)]
        public string AD_SOYAD { get; set; }

        [Key]
        [Column("Ürün Adı", Order = 1)]
        [StringLength(60)]
        public string Ürün_Adı { get; set; }

        [Column("Alış Tarihi", TypeName = "date")]
        public DateTime? Alış_Tarihi { get; set; }

        [Key]
        [Column("Kalan Tutar", Order = 2)]
        public decimal Kalan_Tutar { get; set; }

        [Column("Aylık Taksit Tutarı")]
        public decimal? Aylık_Taksit_Tutarı { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int musteri_id { get; set; }
    }
}
