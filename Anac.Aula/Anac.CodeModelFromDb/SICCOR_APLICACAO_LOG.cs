namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SICCOR_APLICACAO_LOG
    {
        [Key]
        public int ID_APPLOG { get; set; }

        public DateTime DT_OCORRENCIA { get; set; }

        [Required]
        [StringLength(255)]
        public string DS_PONTO_OCORRENCIA { get; set; }

        [Required]
        [StringLength(50)]
        public string DS_NIVEL_OCORRENCIA { get; set; }

        [Required]
        [StringLength(255)]
        public string DS_USUARIO_LOGIN { get; set; }

        [Required]
        public string DS_MENSAGEM { get; set; }

        public string DS_EXCECAO { get; set; }
    }
}
