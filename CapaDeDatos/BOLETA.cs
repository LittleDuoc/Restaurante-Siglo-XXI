//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDeDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class BOLETA
    {
        public string id_boleta { get; set; }
        public string id_medio_de_pago { get; set; }
        public Nullable<System.DateTime> fecha_emision { get; set; }
        public string id_atencion { get; set; }
        public Nullable<decimal> valor_total { get; set; }
    
        public virtual ATENCION ATENCION { get; set; }
        public virtual MEDIO_DE_PAGO MEDIO_DE_PAGO { get; set; }
    }
}
