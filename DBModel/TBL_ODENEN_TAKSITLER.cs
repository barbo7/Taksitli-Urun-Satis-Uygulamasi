namespace TahsilatUyg_.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_ODENEN_TAKSITLER
    {
        [Key]
        public int odenen_id { get; set; }

        public int? taksit_id { get; set; }

        public decimal? odenen_miktar { get; set; }

        [Column(TypeName = "date")]
        public DateTime? tarih { get; set; }

        public decimal? eksik_miktar { get; set; }
    }
}
