namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_DECISAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_DECISAO()
        {
            DECISAO_JUDICIAL = new HashSet<DECISAO_JUDICIAL>();
        }

        [Key]
        public int ID_TIPO_DECISAO { get; set; }

        [Required]
        [StringLength(50)]
        public string DS_TIPO_DECISAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DECISAO_JUDICIAL> DECISAO_JUDICIAL { get; set; }
    }
}
