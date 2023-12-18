namespace TahsilatUyg_
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_TAKSIT_TARIH
    {
        [Key]
        public int taksit_tarih_id { get; set; }

        public int? taksit_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? eklenme_tarihi { get; set; }

        public decimal? taksit_tutar { get; set; }
    }
}
