namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OBJETO")]
    public partial class OBJETO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OBJETO()
        {
            CORREICAOs = new HashSet<CORREICAO>();
            DEMANDA_ESPECIAL = new HashSet<DEMANDA_ESPECIAL>();
            OBJETO_TIPO_PROCESSO = new HashSet<OBJETO_TIPO_PROCESSO>();
            PROCESSOes = new HashSet<PROCESSO>();
        }

        [Key]
        public int ID_OBJETO { get; set; }

        [Required]
        [StringLength(500)]
        public string DS_OBJETO { get; set; }

        public DateTime DT_INICIO_VIGENCIA { get; set; }

        public DateTime? DT_FIM_VIGENCIA { get; set; }

        [Required]
        [StringLength(1)]
        public string SN_REGISTRO_ATIVO { get; set; }

        public int? ID_USUARIO_EXCLUSAO { get; set; }

        public DateTime? DT_EXCLUSAO_REGISTRO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CORREICAO> CORREICAOs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEMANDA_ESPECIAL> DEMANDA_ESPECIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OBJETO_TIPO_PROCESSO> OBJETO_TIPO_PROCESSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROCESSO> PROCESSOes { get; set; }
    }
}
