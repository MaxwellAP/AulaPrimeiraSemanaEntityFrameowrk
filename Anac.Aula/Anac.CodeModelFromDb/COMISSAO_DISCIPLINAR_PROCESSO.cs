namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COMISSAO_DISCIPLINAR_PROCESSO
    {
        [Key]
        public int ID_COMISSAO_DISCIPLINAR_PROCESSO { get; set; }

        public int ID_COMISSAO_DISCIPLINAR { get; set; }

        public int ID_PROCESSO { get; set; }

        public int? ID_ORGAO_EXTERNO { get; set; }

        public DateTime DT_INSTAURACAO { get; set; }

        [Required]
        [StringLength(1)]
        public string SN_REGISTRO_ATIVO { get; set; }

        public DateTime? DT_EXCLUSAO_REGISTRO { get; set; }

        public int? ID_USUARIO_EXCLUSAO { get; set; }

        public virtual COMISSAO_DISCIPLINAR COMISSAO_DISCIPLINAR { get; set; }

        public virtual ORGAO_EXTERNO ORGAO_EXTERNO { get; set; }

        public virtual PROCESSO PROCESSO { get; set; }
    }
}
