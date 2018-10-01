namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INTERESSADO")]
    public partial class INTERESSADO
    {
        [Key]
        public int ID_INTERESSADO { get; set; }

        public int ID_PROCESSO { get; set; }

        [Required]
        [StringLength(1)]
        public string TP_INTERESSADO { get; set; }

        [StringLength(1)]
        public string TP_ORGAO { get; set; }

        public int? ID_ORGAO_INTERESSADO { get; set; }

        public int? ID_UNIDADE_REGIONAL_ANAC { get; set; }

        public int? ID_SERVIDOR { get; set; }

        public int? ID_USUARIO_EXCLUSAO { get; set; }

        public DateTime? DT_EXCLUSAO_REGISTRO { get; set; }

        public virtual PROCESSO PROCESSO { get; set; }
    }
}
