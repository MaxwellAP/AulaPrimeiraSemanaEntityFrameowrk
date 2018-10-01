namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MEIO_PUBLICACAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MEIO_PUBLICACAO()
        {
            JULGAMENTOes = new HashSet<JULGAMENTO>();
        }

        [Key]
        public int ID_MEIO_PUBLICACAO { get; set; }

        [Required]
        [StringLength(50)]
        public string DS_MEIO_PUBLICACAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JULGAMENTO> JULGAMENTOes { get; set; }
    }
}
