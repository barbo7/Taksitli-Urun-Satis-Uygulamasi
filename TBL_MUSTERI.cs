namespace TahsilatUyg_
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_MUSTERI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_MUSTERI()
        {
            TBL_KEFIL = new HashSet<TBL_KEFIL>();
            TBL_TAKSITLER = new HashSet<TBL_TAKSITLER>();
        }

        [Key]
        public int musteri_id { get; set; }

        [Required]
        [StringLength(30)]
        public string ad_soyad { get; set; }

        [Required]
        [StringLength(11)]
        public string tc { get; set; }

        [StringLength(10)]
        public string vergi_kimlik_no { get; set; }

        [Required]
        [StringLength(11)]
        public string telno { get; set; }

        [StringLength(100)]
        public string adres { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_KEFIL> TBL_KEFIL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_TAKSITLER> TBL_TAKSITLER { get; set; }
    }
}
