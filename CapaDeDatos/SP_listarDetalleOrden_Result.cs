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
    
    public partial class SP_listarDetalleOrden_Result
    {
        public long id { get; set; }
        public int cantidad { get; set; }
        public string u_medida { get; set; }
        public Nullable<int> precio_unitario { get; set; }
        public int monto_total { get; set; }
        public long estado { get; set; }
        public long id_insumo { get; set; }
        public long id_orden { get; set; }
    }
}
