using CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocio
{
    public class Medio_de_Pago
    {
        public string Id_medio_pago { get; set; }
        public string Tipo_de_pago { get; set; }

        public Medio_de_Pago()
        {
            Id_medio_pago = "";
            Tipo_de_pago = "";
        }

        /*   public int Create()
           {
               try
               {
                   CapaDeDatos.Medio_de_pago b = new CapaDeDatos.Medio_de_pago();
                   b.Cod_Pago = this.Cod_Pago;
                   b.Tipo_de_pago = this.Tipo_de_pago;

                   CommonBC.Modelo.Medio_de_pago.Add(b);
                   CommonBC.Modelo.SaveChanges();
                   return 1;
               }
               catch (Exception ex)
               {
                   Console.WriteLine(ex.Message);
                   return -1;
               }
           }
           public int Read()
           {
               try
               {
                   CapaDeDatos.Medio_de_pago b = CommonBC.Modelo.Medio_de_pago.First(x => x.Cod_Pago == this.Cod_Pago);
                   this.Cod_Pago = b.Cod_Pago;
                   this.Tipo_de_pago = b.Tipo_de_pago;

                   return 1;
               }
               catch (Exception ex)
               {
                   Console.WriteLine(ex.Message);
                   return -1;
               }

           }
           public int Update()
           {
               try
               {
                   CapaDeDatos.Boleta b = CommonBC.Modelo.Boleta.First(x => x.Cod_Pago == this.Cod_Pago);
                   Exchange.Sincronizar(this, b);
                   CommonBC.Modelo.SaveChanges();
                   return 1;
               }

               catch (Exception ex)
               {
                   Console.WriteLine(ex.Message);
                   return -1;
               }

           }
           public int Delete()
           {
               try
               {
                   CapaDeDatos.Boleta b = CommonBC.Modelo.Boleta.First(x => x.IdBoleta == IdBoleta);
                   CommonBC.Modelo.Boleta.Remove(b);
                   return CommonBC.Modelo.SaveChanges();
               }
               catch (Exception ex)
               {
                   Console.WriteLine(ex.Message);
                   return -1;
               }

           }*/
    }
}
