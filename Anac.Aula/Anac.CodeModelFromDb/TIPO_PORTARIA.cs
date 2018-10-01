namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_PORTARIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_PORTARIA()
        {
            PROCESSO_PORTARIA = new HashSet<PROCESSO_PORTARIA>();
        }

        [Key]
        public int ID_TIPO_PORTARIA { get; set; }

        [Required]
        [StringLength(30)]
        public string DS_TIPO_PORTARIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROCESSO_PORTARIA> PROCESSO_PORTARIA { get; set; }
    }
}
