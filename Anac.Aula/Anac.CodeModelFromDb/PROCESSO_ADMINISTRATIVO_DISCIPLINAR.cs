namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PROCESSO_ADMINISTRATIVO_DISCIPLINAR
    {
        [Key]
        public int ID_PROCESSO_ADMINISTRATIVO_DISCIPLINAR { get; set; }

        public int ID_PROCESSO { get; set; }

        [StringLength(50)]
        public string NR_PROCESSO_APOIO_COMISSAO { get; set; }

        public int? ID_ENDERECO_COMISSAO { get; set; }

        [StringLength(500)]
        public string TX_OBSERVACAO { get; set; }

        public int? ID_PROCESSO_NEGOCIO { get; set; }

        public int? ID_USUARIO_EXCLUSAO { get; set; }

        public DateTime? DT_EXCLUSAO_REGISTRO { get; set; }

        public virtual ENDERECO_COMISSAO ENDERECO_COMISSAO { get; set; }

        public virtual PROCESSO PROCESSO { get; set; }

        public virtual PROCESSO_NEGOCIO PROCESSO_NEGOCIO { get; set; }
    }
}
