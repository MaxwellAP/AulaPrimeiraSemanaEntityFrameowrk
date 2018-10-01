namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OBJETO_TIPO_PROCESSO
    {
        [Key]
        public int ID_OBJETO_TIPO_PROCESSO { get; set; }

        public int ID_OBJETO { get; set; }

        public int ID_TIPO_PROCESSO { get; set; }

        public virtual OBJETO OBJETO { get; set; }

        public virtual TIPO_PROCESSO TIPO_PROCESSO { get; set; }
    }
}
