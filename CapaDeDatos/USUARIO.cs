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
    
    public partial class USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIO()
        {
            this.MESA = new HashSet<MESA>();
        }
    
        public string id_usuario { get; set; }
        public string rut { get; set; }
        public string nombre { get; set; }
        public string apellido_p { get; set; }
        public string apellido_m { get; set; }
        public string id_rol { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
        public string password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MESA> MESA { get; set; }
        public virtual ROL ROL { get; set; }
    }
}
