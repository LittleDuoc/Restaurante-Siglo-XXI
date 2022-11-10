using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocio
{
    public class Usuario
    {
        public string Id_usuario { get; set; }
        public string Rut { get; set; }
        public string Nombre { get; set; }
        public string Apellido_p { get; set; }
        public string Apellido_m { get; set; }
        public Rol Rol { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Password { get; set; }

        public Usuario()
        {

        }
    }
}
