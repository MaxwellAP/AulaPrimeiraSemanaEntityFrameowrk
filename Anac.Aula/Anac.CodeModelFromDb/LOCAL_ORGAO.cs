namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LOCAL_ORGAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOCAL_ORGAO()
        {
            COMISSAO_DISCIPLINAR = new HashSet<COMISSAO_DISCIPLINAR>();
        }

        [Key]
        public int ID_LOCAL_ORGAO { get; set; }

        [Required]
        [StringLength(20)]
        public string DS_LOCAL_ORGAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMISSAO_DISCIPLINAR> COMISSAO_DISCIPLINAR { get; set; }
    }
}
