namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ANDAMENTO_PROCESSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ANDAMENTO_PROCESSO()
        {
            DISTRIBUICAO_PROCESSO = new HashSet<DISTRIBUICAO_PROCESSO>();
        }

        [Key]
        public int ID_ANDAMENTO_PROCESSO { get; set; }

        public int ID_PROCESSO { get; set; }

        public int ID_FASE_ATO_PROCESSO { get; set; }

        public DateTime? DT_INICIO_PRAZO { get; set; }

        public DateTime? DT_VENCIMENTO_PRAZO { get; set; }

        public DateTime? DT_EXECUCAO { get; set; }

        public DateTime? DT_EVENTO { get; set; }

        public DateTime? DT_EXCLUSAO_REGISTRO { get; set; }

        public int? ID_USUARIO_EXCLUSAO { get; set; }

        public virtual FASE_ATO_PROCESSO FASE_ATO_PROCESSO { get; set; }

        public virtual PROCESSO PROCESSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DISTRIBUICAO_PROCESSO> DISTRIBUICAO_PROCESSO { get; set; }
    }
}
