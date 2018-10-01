namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ENDERECO_COMISSAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ENDERECO_COMISSAO()
        {
            PROCESSO_ADMINISTRATIVO_DISCIPLINAR = new HashSet<PROCESSO_ADMINISTRATIVO_DISCIPLINAR>();
        }

        [Key]
        public int ID_ENDERECO_COMISSAO { get; set; }

        [Required]
        [StringLength(50)]
        public string DS_ENDERECO_COMISSAO { get; set; }

        public DateTime DT_INICIO_VIGENCIA { get; set; }

        public DateTime? DT_FIM_VIGENCIA { get; set; }

        [Required]
        [StringLength(1)]
        public string SN_REGISTRO_ATIVO { get; set; }

        public DateTime? DT_EXCLUSAO_REGISTRO { get; set; }

        public int? ID_USUARIO_EXCLUSAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROCESSO_ADMINISTRATIVO_DISCIPLINAR> PROCESSO_ADMINISTRATIVO_DISCIPLINAR { get; set; }
    }
}
