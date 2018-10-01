namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PROCESSO_PORTARIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROCESSO_PORTARIA()
        {
            ENVOLVIDO_PROCESSO = new HashSet<ENVOLVIDO_PROCESSO>();
        }

        [Key]
        public int ID_PROCESSO_PORTARIA { get; set; }

        public int ID_PROCESSO { get; set; }

        public int? ID_ORGAO_EXTERNO { get; set; }

        public int? ID_TIPO_PORTARIA { get; set; }

        [Required]
        [StringLength(50)]
        public string NR_PORTARIA { get; set; }

        public DateTime DT_PORTARIA { get; set; }

        [Required]
        [StringLength(1)]
        public string SN_PORTARIA_INSTAURACAO { get; set; }

        public DateTime? DT_PUBLICACAO { get; set; }

        [StringLength(1)]
        public string TP_MEIO_PUBLICACAO { get; set; }

        [StringLength(10)]
        public string NR_SECAO_DIARIO_OFICIAL { get; set; }

        [StringLength(10)]
        public string NR_PAGINA_DIARIO_OFICIAL { get; set; }

        [StringLength(10)]
        public string NR_VOLUME_BOLETIM_PESSOAL_SERVICO { get; set; }

        [StringLength(10)]
        public string NR_BOLETIM_PESSOAL_SERVICO { get; set; }

        public DateTime? DT_PRAZO_ENCERRAMENTO { get; set; }

        public int? ID_ATO_PRATICADO { get; set; }

        public int? ID_USUARIO_EXCLUSAO { get; set; }

        public DateTime? DT_EXCLUSAO_REGISTRO { get; set; }

        public virtual ATO_PRATICADO ATO_PRATICADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENVOLVIDO_PROCESSO> ENVOLVIDO_PROCESSO { get; set; }

        public virtual ORGAO_EXTERNO ORGAO_EXTERNO { get; set; }

        public virtual PROCESSO PROCESSO { get; set; }

        public virtual TIPO_PORTARIA TIPO_PORTARIA { get; set; }
    }
}
