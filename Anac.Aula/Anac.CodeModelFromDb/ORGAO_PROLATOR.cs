namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ORGAO_PROLATOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ORGAO_PROLATOR()
        {
            DECISAO_JUDICIAL = new HashSet<DECISAO_JUDICIAL>();
        }

        [Key]
        public int ID_ORGAO_PROLATOR { get; set; }

        [Required]
        [StringLength(100)]
        public string DS_ORGAO_PROLATOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DECISAO_JUDICIAL> DECISAO_JUDICIAL { get; set; }
    }
}
