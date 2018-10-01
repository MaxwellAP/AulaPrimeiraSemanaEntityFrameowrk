namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PROCESSO")]
    public partial class PROCESSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROCESSO()
        {
            ANDAMENTO_PROCESSO = new HashSet<ANDAMENTO_PROCESSO>();
            COMISSAO_DISCIPLINAR_PROCESSO = new HashSet<COMISSAO_DISCIPLINAR_PROCESSO>();
            CORREICAOs = new HashSet<CORREICAO>();
            DECISAO_JUDICIAL = new HashSet<DECISAO_JUDICIAL>();
            DEMANDA_ESPECIAL = new HashSet<DEMANDA_ESPECIAL>();
            ENVOLVIDO_PROCESSO = new HashSet<ENVOLVIDO_PROCESSO>();
            INTERESSADOes = new HashSet<INTERESSADO>();
            JULGAMENTOes = new HashSet<JULGAMENTO>();
            PEDIDO_CERTIDAO = new HashSet<PEDIDO_CERTIDAO>();
            PROCESSO_ADMINISTRATIVO_DISCIPLINAR = new HashSet<PROCESSO_ADMINISTRATIVO_DISCIPLINAR>();
            PROCESSO_ADMINISTRATIVO_GERAL = new HashSet<PROCESSO_ADMINISTRATIVO_GERAL>();
            PROCESSO_PORTARIA = new HashSet<PROCESSO_PORTARIA>();
            PROCESSO_RELACIONADO = new HashSet<PROCESSO_RELACIONADO>();
            PROCESSO_RELACIONADO1 = new HashSet<PROCESSO_RELACIONADO>();
            RELATORIO_FINAL = new HashSet<RELATORIO_FINAL>();
            SUSPENSAO_PRESCRICAO = new HashSet<SUSPENSAO_PRESCRICAO>();
        }

        [Key]
        public int ID_PROCESSO { get; set; }

        public int ID_TIPO_PROCESSO { get; set; }

        [Required]
        [StringLength(50)]
        public string NR_PROCESSO { get; set; }

        public int? ID_OBJETO { get; set; }

        public int? ID_ESPECIE { get; set; }

        [StringLength(1)]
        public string TP_ARMAZENAMENTO { get; set; }

        public DateTime? DT_RECEBIMENTO { get; set; }

        public DateTime? DT_CONHECIMENTO_FATO { get; set; }

        public DateTime? DT_INSTAURACAO { get; set; }

        public DateTime? DT_ADVERTENCIA { get; set; }

        public DateTime? DT_SUSPENSAO { get; set; }

        public DateTime? DT_DEMISSAO { get; set; }

        public DateTime? DT_CONCLUSAO { get; set; }

        public DateTime DT_INICIO_VIGENCIA { get; set; }

        public DateTime? DT_FIM_VIGENCIA { get; set; }

        [Required]
        [StringLength(1)]
        public string SN_REGISTRO_ATIVO { get; set; }

        public int? ID_USUARIO_EXCLUSAO { get; set; }

        public DateTime? DT_EXCLUSAO_REGISTRO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ANDAMENTO_PROCESSO> ANDAMENTO_PROCESSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMISSAO_DISCIPLINAR_PROCESSO> COMISSAO_DISCIPLINAR_PROCESSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CORREICAO> CORREICAOs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DECISAO_JUDICIAL> DECISAO_JUDICIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEMANDA_ESPECIAL> DEMANDA_ESPECIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENVOLVIDO_PROCESSO> ENVOLVIDO_PROCESSO { get; set; }

        public virtual ESPECIE ESPECIE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INTERESSADO> INTERESSADOes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JULGAMENTO> JULGAMENTOes { get; set; }

        public virtual OBJETO OBJETO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PEDIDO_CERTIDAO> PEDIDO_CERTIDAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROCESSO_ADMINISTRATIVO_DISCIPLINAR> PROCESSO_ADMINISTRATIVO_DISCIPLINAR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROCESSO_ADMINISTRATIVO_GERAL> PROCESSO_ADMINISTRATIVO_GERAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROCESSO_PORTARIA> PROCESSO_PORTARIA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROCESSO_RELACIONADO> PROCESSO_RELACIONADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROCESSO_RELACIONADO> PROCESSO_RELACIONADO1 { get; set; }

        public virtual TIPO_PROCESSO TIPO_PROCESSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RELATORIO_FINAL> RELATORIO_FINAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUSPENSAO_PRESCRICAO> SUSPENSAO_PRESCRICAO { get; set; }
    }
}
