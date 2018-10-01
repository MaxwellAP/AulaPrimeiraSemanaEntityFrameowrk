namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_ENVOLVIMENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_ENVOLVIMENTO()
        {
            ENVOLVIDO_PROCESSO = new HashSet<ENVOLVIDO_PROCESSO>();
        }

        [Key]
        public int ID_TIPO_ENVOLVIMENTO { get; set; }

        [Required]
        [StringLength(50)]
        public string DS_TIPO_ENVOLVIMENTO { get; set; }

        public DateTime DT_INICIO_VIGENCIA { get; set; }

        public DateTime? DT_FIM_VIGENCIA { get; set; }

        [Required]
        [StringLength(1)]
        public string SN_REGISTRO_ATIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENVOLVIDO_PROCESSO> ENVOLVIDO_PROCESSO { get; set; }
    }
}
