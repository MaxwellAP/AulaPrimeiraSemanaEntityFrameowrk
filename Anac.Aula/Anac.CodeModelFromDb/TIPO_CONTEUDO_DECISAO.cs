namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TIPO_CONTEUDO_DECISAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_CONTEUDO_DECISAO()
        {
            CONTEUDO_DECISAO = new HashSet<CONTEUDO_DECISAO>();
        }

        [Key]
        public int ID_TIPO_CONTEUDO_DECISAO { get; set; }

        [Required]
        [StringLength(30)]
        public string DS_TIPO_CONTEUDO_DECISAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTEUDO_DECISAO> CONTEUDO_DECISAO { get; set; }
    }
}
