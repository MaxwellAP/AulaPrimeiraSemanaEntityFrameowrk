namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ATO_PRATICADO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ATO_PRATICADO()
        {
            PROCESSO_PORTARIA = new HashSet<PROCESSO_PORTARIA>();
        }

        [Key]
        public int ID_ATO_PRATICADO { get; set; }

        [Required]
        [StringLength(100)]
        public string DS_ATO_PRATICADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROCESSO_PORTARIA> PROCESSO_PORTARIA { get; set; }
    }
}
