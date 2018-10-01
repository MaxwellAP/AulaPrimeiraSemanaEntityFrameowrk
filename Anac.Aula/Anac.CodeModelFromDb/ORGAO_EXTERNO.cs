namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ORGAO_EXTERNO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ORGAO_EXTERNO()
        {
            COMISSAO_DISCIPLINAR_PROCESSO = new HashSet<COMISSAO_DISCIPLINAR_PROCESSO>();
            PROCESSO_PORTARIA = new HashSet<PROCESSO_PORTARIA>();
        }

        [Key]
        public int ID_ORGAO_EXTERNO { get; set; }

        [Required]
        [StringLength(100)]
        public string NM_ORGAO_EXTERNO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMISSAO_DISCIPLINAR_PROCESSO> COMISSAO_DISCIPLINAR_PROCESSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROCESSO_PORTARIA> PROCESSO_PORTARIA { get; set; }
    }
}
