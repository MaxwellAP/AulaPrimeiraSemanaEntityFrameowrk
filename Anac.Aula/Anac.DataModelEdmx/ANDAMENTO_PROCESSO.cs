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
    
    public partial class ANDAMENTO_PROCESSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ANDAMENTO_PROCESSO()
        {
            this.DISTRIBUICAO_PROCESSO = new HashSet<DISTRIBUICAO_PROCESSO>();
        }
    
        public int ID_ANDAMENTO_PROCESSO { get; set; }
        public int ID_PROCESSO { get; set; }
        public int ID_FASE_ATO_PROCESSO { get; set; }
        public Nullable<System.DateTime> DT_INICIO_PRAZO { get; set; }
        public Nullable<System.DateTime> DT_VENCIMENTO_PRAZO { get; set; }
        public Nullable<System.DateTime> DT_EXECUCAO { get; set; }
        public Nullable<System.DateTime> DT_EVENTO { get; set; }
        public Nullable<System.DateTime> DT_EXCLUSAO_REGISTRO { get; set; }
        public Nullable<int> ID_USUARIO_EXCLUSAO { get; set; }
    
        public virtual FASE_ATO_PROCESSO FASE_ATO_PROCESSO { get; set; }
        public virtual PROCESSO PROCESSO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DISTRIBUICAO_PROCESSO> DISTRIBUICAO_PROCESSO { get; set; }
    }
}