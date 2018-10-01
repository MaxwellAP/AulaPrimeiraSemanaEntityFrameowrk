namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PEDIDO_CERTIDAO
    {
        [Key]
        public int ID_PEDIDO_CERTIDAO { get; set; }

        public int? ID_PROCESSO { get; set; }

        public int ID_SERVIDOR_INTERESSADO { get; set; }

        public int ID_SETOR_SOLICITANTE { get; set; }

        public DateTime DT_RECEBIMENTO { get; set; }

        public DateTime? DT_ATENDIMENTO { get; set; }

        public int? ID_USUARIO_EXCLUSAO { get; set; }

        public DateTime? DT_EXCLUSAO_REGISTRO { get; set; }

        public virtual PROCESSO PROCESSO { get; set; }
    }
}
