namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_PROCESSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_PROCESSO()
        {
            OBJETO_TIPO_PROCESSO = new HashSet<OBJETO_TIPO_PROCESSO>();
            PROCESSOes = new HashSet<PROCESSO>();
        }

        [Key]
        public int ID_TIPO_PROCESSO { get; set; }

        [Required]
        [StringLength(100)]
        public string DS_TIPO_PROCESSO { get; set; }

        public DateTime DT_INICIO_VIGENCIA { get; set; }

        public DateTime? DT_FIM_VIGENCIA { get; set; }

        [Required]
        [StringLength(1)]
        public string SN_REGISTRO_ATIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OBJETO_TIPO_PROCESSO> OBJETO_TIPO_PROCESSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROCESSO> PROCESSOes { get; set; }
    }
}
