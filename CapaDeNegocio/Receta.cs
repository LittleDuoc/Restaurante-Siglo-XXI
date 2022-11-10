using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocio
{
    public class Receta
    {
        public string Id_receta { get; set; }
        public Preparacion Preparacion { get; set; }
        public Insumo Insumo { get; set; }
        public decimal Porcion { get; set; }
        public string U_medida { get; set; }

        public Receta()
        {

        }

    }
}
