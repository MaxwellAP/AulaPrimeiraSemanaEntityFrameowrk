namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AUTORIDADE")]
    public partial class AUTORIDADE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AUTORIDADE()
        {
            JULGAMENTOes = new HashSet<JULGAMENTO>();
        }

        [Key]
        public int ID_AUTORIDADE { get; set; }

        [Required]
        [StringLength(100)]
        public string DS_AUTORIDADE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JULGAMENTO> JULGAMENTOes { get; set; }
    }
}
