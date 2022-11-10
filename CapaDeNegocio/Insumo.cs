using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocio
{
    public class Insumo
    {
        public string Id_insumo { get; set; }
        public string Nombre { get; set; }
        public decimal Stock { get; set; }
        public DateTime fecha_abastecimiento { get; set; }
        public Proveedor Proveedor { get; set; }
        public Marca Marca { get; set; }

        public Insumo()
        {
            Stock = 0;
            Proveedor = new Proveedor();
            Marca = new Marca();
        }
    }
}
