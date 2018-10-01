namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PROCESSO_ADMINISTRATIVO_GERAL
    {
        [Key]
        public int ID_PROCESSO_ADMINISTRATIVO_GERAL { get; set; }

        public int ID_PROCESSO { get; set; }

        [Required]
        [StringLength(1)]
        public string TP_INTERESSADO { get; set; }

        [StringLength(500)]
        public string DS_ASSUNTO { get; set; }

        public DateTime DT_RECEBIMENTO { get; set; }

        public int? ID_USUARIO_EXCLUSAO { get; set; }

        public DateTime? DT_EXCLUSAO_REGISTRO { get; set; }

        public virtual PROCESSO PROCESSO { get; set; }
    }
}
