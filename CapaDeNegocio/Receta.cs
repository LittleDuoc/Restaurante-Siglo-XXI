using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaDeNegocio;
using CapaDeDatos;

namespace CapaDeNegocio
{
    public class Receta
    {
        public string Id_receta { get; set; }
        public Preparacion Preparacion { get; set; }
        public Insumo Insumo { get; set; }
        public decimal Porcion { get; set; }
        public string U_medida { get; set; }

        public void  crear_receta()
        {
            Id_receta = "";
            Preparacion = new Preparacion();
            Insumo = new Insumo();
            Porcion = 0;
            Porcion= 0;
            U_medida = "";
        }
        public int Create()
        {
            try
            {
                CapaDeDatos.RECETA b = new CapaDeDatos.RECETA();
                b.id_receta = this.Id_receta;
                b.porcion = this.Porcion;
                b.u_medida = this.U_medida;

                CommonBC.Modelo.RECETA.Add(b);
                CommonBC.Modelo.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -1;
            }
        }

    }
}
