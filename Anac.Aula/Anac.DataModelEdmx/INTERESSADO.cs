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
    
    public partial class INTERESSADO
    {
        public int ID_INTERESSADO { get; set; }
        public int ID_PROCESSO { get; set; }
        public string TP_INTERESSADO { get; set; }
        public string TP_ORGAO { get; set; }
        public Nullable<int> ID_ORGAO_INTERESSADO { get; set; }
        public Nullable<int> ID_UNIDADE_REGIONAL_ANAC { get; set; }
        public Nullable<int> ID_SERVIDOR { get; set; }
        public Nullable<int> ID_USUARIO_EXCLUSAO { get; set; }
        public Nullable<System.DateTime> DT_EXCLUSAO_REGISTRO { get; set; }
    
        public virtual PROCESSO PROCESSO { get; set; }
    }
}