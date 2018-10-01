namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DISTRIBUICAO_PROCESSO
    {
        [Key]
        public int ID_DISTRIBUICAO_PROCESSO { get; set; }

        public int ID_ANDAMENTO_PROCESSO { get; set; }

        public int ID_SERVIDOR { get; set; }

        public int QT_DIA_PRAZO { get; set; }

        public DateTime DT_DISTRIBUICAO { get; set; }

        public DateTime DT_PREVISAO_ENTREGA { get; set; }

        public DateTime? DT_CONCLUSAO { get; set; }

        public DateTime? DT_ENCAMINHAMENTO_RESPOSTA { get; set; }

        public DateTime? DT_EXCLUSAO_REGISTRO { get; set; }

        public int? ID_USUARIO_EXCLUSAO { get; set; }

        public virtual ANDAMENTO_PROCESSO ANDAMENTO_PROCESSO { get; set; }
    }
}
