using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocio
{
    public class Mesa
    {
        public string Id_mesa { get; set; }
        public Usuario Usuario { get; set; }
        public Estado_mesa  Estado_Mesa { get; set; }

        public Mesa()
        {

        }
    }
}
