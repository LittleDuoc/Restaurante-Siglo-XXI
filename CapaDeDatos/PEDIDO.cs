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
    
    public partial class PEDIDO
    {
        public string id_atencion { get; set; }
        public string id_mesa { get; set; }
        public string id_preparacion { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<decimal> cantidad { get; set; }
        public Nullable<decimal> total { get; set; }
        public string id_pedido { get; set; }
    
        public virtual ATENCION ATENCION { get; set; }
        public virtual PREPARACION PREPARACION { get; set; }
    }
}