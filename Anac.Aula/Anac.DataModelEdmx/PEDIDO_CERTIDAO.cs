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
    
    public partial class PEDIDO_CERTIDAO
    {
        public int ID_PEDIDO_CERTIDAO { get; set; }
        public Nullable<int> ID_PROCESSO { get; set; }
        public int ID_SERVIDOR_INTERESSADO { get; set; }
        public int ID_SETOR_SOLICITANTE { get; set; }
        public System.DateTime DT_RECEBIMENTO { get; set; }
        public Nullable<System.DateTime> DT_ATENDIMENTO { get; set; }
        public Nullable<int> ID_USUARIO_EXCLUSAO { get; set; }
        public Nullable<System.DateTime> DT_EXCLUSAO_REGISTRO { get; set; }
    
        public virtual PROCESSO PROCESSO { get; set; }
    }
}