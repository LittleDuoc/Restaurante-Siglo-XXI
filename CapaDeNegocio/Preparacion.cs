using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocio
{
    public class Preparacion
    {
        public string Id_preparacion { get; set; }
        public string Nombre_receta { get; set; }
        public decimal Precio { get; set; }
        public Categoria Categoria { get; set; }

        public Preparacion()
        {

        }

    }
}
