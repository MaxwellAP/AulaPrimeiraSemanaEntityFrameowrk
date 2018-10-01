namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ATIVIDADE")]
    public partial class ATIVIDADE
    {
        [Key]
        public int ID_ATIVIDADE { get; set; }

        public int ID_TIPO_ATIVIDADE { get; set; }

        public DateTime DT_CRIACAO_ATIVIDADE { get; set; }

        public DateTime? DT_RECEBIMENTO_ATIVIDADE { get; set; }

        public int ID_USUARIO { get; set; }
    }
}
