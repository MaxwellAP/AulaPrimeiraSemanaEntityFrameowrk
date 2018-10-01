namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PROCESSO_NEGOCIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROCESSO_NEGOCIO()
        {
            PROCESSO_ADMINISTRATIVO_DISCIPLINAR = new HashSet<PROCESSO_ADMINISTRATIVO_DISCIPLINAR>();
        }

        [Key]
        public int ID_PROCESSO_NEGOCIO { get; set; }

        [Required]
        [StringLength(100)]
        public string NM_PROCESSO_NEGOCIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROCESSO_ADMINISTRATIVO_DISCIPLINAR> PROCESSO_ADMINISTRATIVO_DISCIPLINAR { get; set; }
    }
}
