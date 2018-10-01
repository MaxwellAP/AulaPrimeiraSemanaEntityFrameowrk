namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMISSAO_DISCIPLINAR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COMISSAO_DISCIPLINAR()
        {
            COMISSAO_DISCIPLINAR_PROCESSO = new HashSet<COMISSAO_DISCIPLINAR_PROCESSO>();
        }

        [Key]
        public int ID_COMISSAO_DISCIPLINAR { get; set; }

        public int ID_LOCAL_ORGAO { get; set; }

        [Required]
        [StringLength(2)]
        public string SG_UF { get; set; }

        [Required]
        [StringLength(100)]
        public string DS_ENDERECO { get; set; }

        [Required]
        [StringLength(20)]
        public string NR_TELEFONE { get; set; }

        [StringLength(100)]
        public string DS_EMAIL { get; set; }

        [StringLength(100)]
        public string DS_UNIDADE_SEI { get; set; }

        public DateTime? DT_EXCLUSAO_REGISTRO { get; set; }

        public int? ID_USUARIO_EXCLUSAO { get; set; }

        public virtual LOCAL_ORGAO LOCAL_ORGAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMISSAO_DISCIPLINAR_PROCESSO> COMISSAO_DISCIPLINAR_PROCESSO { get; set; }
    }
}
