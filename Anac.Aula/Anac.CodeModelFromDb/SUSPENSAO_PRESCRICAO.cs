namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SUSPENSAO_PRESCRICAO
    {
        [Key]
        public int ID_SUSPENSAO_PRESCRICAO { get; set; }

        public int ID_PROCESSO { get; set; }

        public DateTime DT_INICIO_SUSPENSAO_PRESCRICAO { get; set; }

        public DateTime? DT_FIM_SUSPENSAO_PRESCRICAO { get; set; }

        public DateTime? DT_ADVERTENCIA { get; set; }

        public DateTime? DT_SUSPENSAO { get; set; }

        public DateTime? DT_DEMISSAO { get; set; }

        public string DS_SUSPENSAO_PRESCRICAO { get; set; }

        public int ID_USUARIO_RESPONSAVEL { get; set; }

        public DateTime DT_CADASTRAMENTO_SUSPENSAO { get; set; }

        public int? ID_USUARIO_EXCLUSAO { get; set; }

        public DateTime? DT_EXCLUSAO_REGISTRO { get; set; }

        public virtual PROCESSO PROCESSO { get; set; }
    }
}
