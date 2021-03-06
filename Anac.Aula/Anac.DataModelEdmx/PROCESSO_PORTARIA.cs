//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Anac.DataModelEdmx
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROCESSO_PORTARIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROCESSO_PORTARIA()
        {
            this.ENVOLVIDO_PROCESSO = new HashSet<ENVOLVIDO_PROCESSO>();
        }
    
        public int ID_PROCESSO_PORTARIA { get; set; }
        public int ID_PROCESSO { get; set; }
        public Nullable<int> ID_ORGAO_EXTERNO { get; set; }
        public Nullable<int> ID_TIPO_PORTARIA { get; set; }
        public string NR_PORTARIA { get; set; }
        public System.DateTime DT_PORTARIA { get; set; }
        public string SN_PORTARIA_INSTAURACAO { get; set; }
        public Nullable<System.DateTime> DT_PUBLICACAO { get; set; }
        public string TP_MEIO_PUBLICACAO { get; set; }
        public string NR_SECAO_DIARIO_OFICIAL { get; set; }
        public string NR_PAGINA_DIARIO_OFICIAL { get; set; }
        public string NR_VOLUME_BOLETIM_PESSOAL_SERVICO { get; set; }
        public string NR_BOLETIM_PESSOAL_SERVICO { get; set; }
        public Nullable<System.DateTime> DT_PRAZO_ENCERRAMENTO { get; set; }
        public Nullable<int> ID_ATO_PRATICADO { get; set; }
        public Nullable<int> ID_USUARIO_EXCLUSAO { get; set; }
        public Nullable<System.DateTime> DT_EXCLUSAO_REGISTRO { get; set; }
    
        public virtual ATO_PRATICADO ATO_PRATICADO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENVOLVIDO_PROCESSO> ENVOLVIDO_PROCESSO { get; set; }
        public virtual ORGAO_EXTERNO ORGAO_EXTERNO { get; set; }
        public virtual PROCESSO PROCESSO { get; set; }
        public virtual TIPO_PORTARIA TIPO_PORTARIA { get; set; }
    }
}
