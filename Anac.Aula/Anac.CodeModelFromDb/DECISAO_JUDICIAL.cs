namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DECISAO_JUDICIAL
    {
        [Key]
        public int ID_DECISAO_JUDICIAL { get; set; }

        public int ID_PROCESSO { get; set; }

        public int ID_TIPO_DECISAO { get; set; }

        public int ID_CONTEUDO_DECISAO { get; set; }

        public int ID_ORGAO_PROLATOR { get; set; }

        [Required]
        public string DS_DECISAO_JUDICIAL { get; set; }

        public DateTime DT_INTIMACAO { get; set; }

        public DateTime? DT_EXCLUSAO_REGISTRO { get; set; }

        public int? ID_USUARIO_EXCLUSAO { get; set; }

        public virtual CONTEUDO_DECISAO CONTEUDO_DECISAO { get; set; }

        public virtual ORGAO_PROLATOR ORGAO_PROLATOR { get; set; }

        public virtual PROCESSO PROCESSO { get; set; }

        public virtual TIPO_DECISAO TIPO_DECISAO { get; set; }
    }
}
