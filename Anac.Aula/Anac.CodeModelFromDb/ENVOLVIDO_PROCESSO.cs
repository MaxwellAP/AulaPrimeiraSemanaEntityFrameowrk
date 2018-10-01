namespace Anac.CodeModelFromDb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ENVOLVIDO_PROCESSO
    {
        [Key]
        public int ID_ENVOLVIDO_PROCESSO { get; set; }

        public int? ID_PESSOA_ENVOLVIDA { get; set; }

        public int ID_TIPO_ENVOLVIMENTO { get; set; }

        public int? ID_PROCESSO { get; set; }

        public int? ID_PROCESSO_PORTARIA { get; set; }

        public bool FG_ENVOLVIDO_IDENTIFICADO { get; set; }

        public bool? FG_ESTAGIO_PROBATORIO { get; set; }

        public bool FG_REGISTRO_EXCLUIDO { get; set; }

        public DateTime? DT_EXCLUSAO_REGISTRO { get; set; }

        public int? ID_USUARIO_EXCLUSAO { get; set; }

        public virtual PROCESSO PROCESSO { get; set; }

        public virtual PROCESSO_PORTARIA PROCESSO_PORTARIA { get; set; }

        public virtual TIPO_ENVOLVIMENTO TIPO_ENVOLVIMENTO { get; set; }
    }
}
