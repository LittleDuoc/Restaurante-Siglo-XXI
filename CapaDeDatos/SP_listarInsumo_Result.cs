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
    
    public partial class SP_listarInsumo_Result
    {
        public long id { get; set; }
        public string nombre { get; set; }
        public Nullable<int> stock { get; set; }
        public Nullable<System.DateTime> fecha_abastecimiento { get; set; }
        public long id_categoria { get; set; }
        public Nullable<long> id_marca { get; set; }
        public Nullable<long> id_prov { get; set; }
    }
}