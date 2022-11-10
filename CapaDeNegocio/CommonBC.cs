using CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocio
{
    internal class CommonBC
    {
        private static Restaurante_Siglo_XXIEntities _modelo;
        public static Restaurante_Siglo_XXIEntities Modelo
        {
            get
            {
                if (_modelo == null)
                    _modelo = new Restaurante_Siglo_XXIEntities();
                return _modelo;
            }
        }
    }// singleton
}
