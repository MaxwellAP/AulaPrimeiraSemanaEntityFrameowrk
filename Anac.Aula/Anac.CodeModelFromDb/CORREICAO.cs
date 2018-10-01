namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CORREICAO")]
    public partial class CORREICAO
    {
        [Key]
        public int ID_CORREICAO { get; set; }

        [Column("ID_PROCESSO")]
        public int IdProcesso { get; set; }

        [Required]
        [StringLength(1)]
        public string TP_ESPECIE_CORREICAO { get; set; }

        public int ID_UNIDADE_CORREICIONADA { get; set; }

        public int ID_OBJETO { get; set; }

        public DateTime? DT_INICIO_CORREICAO { get; set; }

        public DateTime? DT_FIM_CORREICAO { get; set; }

        [Required]
        [StringLength(400)]
        public string NR_PORTATIA { get; set; }

        public DateTime DT_PUBLICACAO_PORTARIA { get; set; }

        public DateTime? DT_EXCLUSAO_REGISTRO { get; set; }

        public int? ID_USUARIO_EXCLUSAO { get; set; }

        public virtual OBJETO OBJETO { get; set; }

        public virtual PROCESSO PROCESSO { get; set; }
    }
}
