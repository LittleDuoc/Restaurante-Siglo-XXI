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
    
    public partial class Restaurante_reserva
    {
        public long id { get; set; }
        public string nombre_cliente { get; set; }
        public System.DateTime fecha { get; set; }
        public string telefono { get; set; }
        public long estado { get; set; }
        public long id_mesa { get; set; }
    
        public virtual Restaurante_estadoreserva Restaurante_estadoreserva { get; set; }
        public virtual Restaurante_mesa Restaurante_mesa { get; set; }
    }
}
