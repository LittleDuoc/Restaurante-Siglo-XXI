using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocio
{
    public class Categoria
    {
        public string Id_categoria { get; set; }
        public string Descripcion { get; set; }
        public Preparacion Preparacion { get; set; }

        public Categoria()
        {
            Id_categoria = "";
            Descripcion = "";
            Preparacion = new Preparacion();
        }

    }
}
