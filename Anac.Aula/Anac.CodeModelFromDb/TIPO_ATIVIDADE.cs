namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_ATIVIDADE
    {
        [Key]
        public int ID_TIPO_ATIVIDADE { get; set; }

        [Required]
        [StringLength(500)]
        public string DS_ATIVIDADE { get; set; }
    }
}
