namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PROCESSO_RELACIONADO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_PROCESSO_PRINCIPAL { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_PROCESSO_RELACIONADO { get; set; }

        [Required]
        [StringLength(1)]
        public string TP_RELACIONAMENTO { get; set; }

        public int? ID_USUARIO_EXCLUSAO { get; set; }

        public DateTime? DT_EXCLUSAO_REGISTRO { get; set; }

        public virtual PROCESSO PROCESSO { get; set; }

        public virtual PROCESSO PROCESSO1 { get; set; }
    }
}
