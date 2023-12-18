namespace TahsilatUyg_
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SATIS_TUTANAGI
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string ad_soyad { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(60)]
        public string urun_ad { get; set; }

        public decimal? odenen_miktar { get; set; }

        [Column(TypeName = "date")]
        public DateTime? tarih { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int musteri_id { get; set; }

        [Column("Eksik Tutar")]
        public decimal? Eksik_Tutar { get; set; }
    }
}
