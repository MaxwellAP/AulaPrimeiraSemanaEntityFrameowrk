namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ORGAO")]
    public partial class ORGAO
    {
        [Key]
        public int ID_ORGAO { get; set; }

        [Required]
        [StringLength(100)]
        public string NM_ORGAO { get; set; }
    }
}
