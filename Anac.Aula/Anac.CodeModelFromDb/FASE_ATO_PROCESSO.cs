namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FASE_ATO_PROCESSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FASE_ATO_PROCESSO()
        {
            ANDAMENTO_PROCESSO = new HashSet<ANDAMENTO_PROCESSO>();
        }

        [Key]
        public int ID_FASE_ATO_PROCESSO { get; set; }

        public int ID_FASE_PROCESSO { get; set; }

        public int? ID_ATO_PROCESSO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ANDAMENTO_PROCESSO> ANDAMENTO_PROCESSO { get; set; }

        public virtual ATO_PROCESSO ATO_PROCESSO { get; set; }

        public virtual FASE_PROCESSO FASE_PROCESSO { get; set; }
    }
}
