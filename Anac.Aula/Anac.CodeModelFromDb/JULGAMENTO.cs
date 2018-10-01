namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JULGAMENTO")]
    public partial class JULGAMENTO
    {
        [Key]
        public int ID_JULGAMENTO { get; set; }

        public int ID_PROCESSO { get; set; }

        public int ID_TIPO_JULGAMENTO { get; set; }

        public int? ID_AUTORIDADE { get; set; }

        public int ID_MEIO_PUBLICACAO { get; set; }

        public int ID_CONTEUDO_DECISAO { get; set; }

        public int? NR_SECAO { get; set; }

        public int? NR_PAGINA { get; set; }

        public int? NR_VOLUME { get; set; }

        public int? NR_NUMERO { get; set; }

        [Required]
        public string DS_DETALHAMENTO { get; set; }

        public DateTime DT_PUBLICACAO { get; set; }

        public int? ID_USUARIO_EXCLUSAO { get; set; }

        public DateTime? DT_EXCLUSAO_REGISTRO { get; set; }

        public virtual AUTORIDADE AUTORIDADE { get; set; }

        public virtual CONTEUDO_DECISAO CONTEUDO_DECISAO { get; set; }

        public virtual MEIO_PUBLICACAO MEIO_PUBLICACAO { get; set; }

        public virtual PROCESSO PROCESSO { get; set; }

        public virtual TIPO_JULGAMENTO TIPO_JULGAMENTO { get; set; }
    }
}
