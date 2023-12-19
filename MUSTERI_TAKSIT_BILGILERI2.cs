namespace TahsilatUyg_
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MUSTERI_TAKSIT_BILGILERI2
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
    }
}
