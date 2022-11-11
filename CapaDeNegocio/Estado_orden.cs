using CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocio
{
    public class Estado_orden
    {
        public string estado { get; set; }


        public Estado_orden()
        {
            estado = "";
        }
        /*   public int Create()
           {
               try
               {
                   CapaDeDatos.Estado_orden b = new CapaDeDatos.Estado_orden();
                   b.Cod_Pago = this.estado;

                   CommonBC.Modelo.estado.Add(b);
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
                   CapaDeDatos.Estado_orden b = CommonBC.Modelo.Estado_orden.First(x => x.estado == this.estado);
                   this.estado = b.estado;

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
