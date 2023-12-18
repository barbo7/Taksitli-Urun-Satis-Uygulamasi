namespace TahsilatUyg_.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_ODEME_TAMAMLANAN
    {
        [Key]
        public int tamamlanan_id { get; set; }

        public int? taksit_id { get; set; }

        public int? musteri_id { get; set; }

        public int? urun_id { get; set; }

        public decimal? fiyat { get; set; }
    }
}
