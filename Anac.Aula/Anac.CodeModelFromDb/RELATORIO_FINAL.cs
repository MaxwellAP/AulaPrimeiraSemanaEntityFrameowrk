namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RELATORIO_FINAL
    {
        [Key]
        public int ID_RELATORIO_FINAL { get; set; }

        public int ID_PROCESSO { get; set; }

        public int ID_TIPO_DECISAO { get; set; }

        [Required]
        public string DS_DETALHAMENTO { get; set; }

        public DateTime DT_RELATORIO_FINAL { get; set; }

        public int? ID_USUARIO_EXCLUSAO { get; set; }

        public DateTime? DT_EXCLUSAO_REGISTRO { get; set; }

        public virtual CONTEUDO_DECISAO CONTEUDO_DECISAO { get; set; }

        public virtual PROCESSO PROCESSO { get; set; }
    }
}
