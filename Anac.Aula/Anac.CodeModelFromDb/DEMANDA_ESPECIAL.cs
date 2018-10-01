namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DEMANDA_ESPECIAL
    {
        [Key]
        public int ID_DEMANDA_ESPECIAL { get; set; }

        public int ID_PROCESSO { get; set; }

        public int? ID_OBJETO { get; set; }

        [Required]
        [StringLength(1)]
        public string TP_INTERESSADO { get; set; }

        public DateTime DT_RECEBIMENTO { get; set; }

        public DateTime? DT_EXCLUSAO_REGISTRO { get; set; }

        public int? ID_USUARIO_EXCLUSAO { get; set; }

        public virtual OBJETO OBJETO { get; set; }

        public virtual PROCESSO PROCESSO { get; set; }
    }
}
