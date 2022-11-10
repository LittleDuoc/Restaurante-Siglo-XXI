using CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocio
{
    public class Atencion
    {
        public string Id_atencion { get; set; }
        public System.DateTime Fecha { get; set; }
        public Boleta Boleta { get; set; }
        public Pedido Pedido { get; set; }

        public Atencion()
        {
            this.Id_atencion = "";
            this.Fecha = DateTime.Now;
            this.Boleta = new Boleta();
            this.Pedido = new Pedido();
            
        }
    }
}
