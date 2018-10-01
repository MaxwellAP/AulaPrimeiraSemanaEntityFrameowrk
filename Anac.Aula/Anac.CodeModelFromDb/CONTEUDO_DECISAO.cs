namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CONTEUDO_DECISAO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONTEUDO_DECISAO()
        {
            DECISAO_JUDICIAL = new HashSet<DECISAO_JUDICIAL>();
            JULGAMENTOes = new HashSet<JULGAMENTO>();
            RELATORIO_FINAL = new HashSet<RELATORIO_FINAL>();
        }

        [Key]
        public int ID_CONTEUDO_DECISAO { get; set; }

        public int ID_TIPO_CONTEUDO_DECISAO { get; set; }

        [Required]
        [StringLength(50)]
        public string DS_CONTEUDO_DECISAO { get; set; }

        public virtual TIPO_CONTEUDO_DECISAO TIPO_CONTEUDO_DECISAO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DECISAO_JUDICIAL> DECISAO_JUDICIAL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JULGAMENTO> JULGAMENTOes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RELATORIO_FINAL> RELATORIO_FINAL { get; set; }
    }
}
