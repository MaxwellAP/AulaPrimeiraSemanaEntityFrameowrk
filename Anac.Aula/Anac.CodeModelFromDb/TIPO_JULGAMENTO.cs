namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_JULGAMENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_JULGAMENTO()
        {
            JULGAMENTOes = new HashSet<JULGAMENTO>();
        }

        [Key]
        public int ID_TIPO_JULGAMENTO { get; set; }

        [Required]
        [StringLength(50)]
        public string DS_TIPO_JULGAMENTO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JULGAMENTO> JULGAMENTOes { get; set; }
    }
}
