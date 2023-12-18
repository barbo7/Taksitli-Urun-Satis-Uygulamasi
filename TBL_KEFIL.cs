namespace TahsilatUyg_
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_KEFIL
    {
        [Key]
        public int kefil_id { get; set; }

        public int? musteri_id { get; set; }

        [StringLength(60)]
        public string kefil_ad_soyad { get; set; }

        [StringLength(11)]
        public string telno { get; set; }

        [StringLength(11)]
        public string tc { get; set; }

        public virtual TBL_MUSTERI TBL_MUSTERI { get; set; }
    }
}
