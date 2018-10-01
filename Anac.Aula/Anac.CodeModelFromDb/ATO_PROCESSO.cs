namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ATO_PROCESSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ATO_PROCESSO()
        {
            FASE_ATO_PROCESSO = new HashSet<FASE_ATO_PROCESSO>();
        }

        [Key]
        public int ID_ATO_PROCESSO { get; set; }

        [Required]
        [StringLength(100)]
        public string DS_ATO_PROCESSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FASE_ATO_PROCESSO> FASE_ATO_PROCESSO { get; set; }
    }
}
