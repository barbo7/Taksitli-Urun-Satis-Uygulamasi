namespace TahsilatUyg_.DBModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_URUNLER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_URUNLER()
        {
            TBL_TAKSITLER = new HashSet<TBL_TAKSITLER>();
        }

        [Key]
        public int urun_id { get; set; }

        [Required]
        [StringLength(60)]
        public string urun_ad { get; set; }

        public decimal fiyat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_TAKSITLER> TBL_TAKSITLER { get; set; }
    }
}
