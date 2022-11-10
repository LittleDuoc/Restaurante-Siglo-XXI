using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocio
{
    public class Pedido
    {
        public string Id_pedido { get; set; }
        public Atencion Atencion { get; set; }
        public Mesa Mesa { get; set; }
        public Preparacion Preparacion { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Total { get; set; }

        public Pedido()
        {

        }

    }
}
