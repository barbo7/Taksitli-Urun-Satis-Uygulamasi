namespace TahsilatUyg_.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_TAKSITLER
    {
        [Key]
        public int taksit_id { get; set; }

        public int musteri_id { get; set; }

        public int urun_id { get; set; }

        public decimal toplam_fiyat { get; set; }

        public int kac_taksit { get; set; }

        public decimal odenen { get; set; }

        public decimal kalan { get; set; }

        [StringLength(100)]
        public string musteri_not { get; set; }

        public virtual TBL_MUSTERI TBL_MUSTERI { get; set; }

        public virtual TBL_URUNLER TBL_URUNLER { get; set; }
    }
}
