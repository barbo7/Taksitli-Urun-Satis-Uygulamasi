namespace TahsilatUyg_
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class URUN_TAKSIT
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int taksit_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(60)]
        public string urun_ad { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int musteri_id { get; set; }
    }
}
