namespace TahsilatUyg_.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TAKSIT_DOKUMENTE
    {
        public decimal? odenen_miktar { get; set; }

        [Column(TypeName = "date")]
        public DateTime? tarih { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int musteri_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(60)]
        public string urun_ad { get; set; }
    }
}
