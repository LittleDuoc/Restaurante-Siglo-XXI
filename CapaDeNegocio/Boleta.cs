using CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocio
{
    public class Boleta
    {
        public string Id_boleta { get; set; }
        public Medio_de_Pago Medio_de_pago { get; set; }
        public System.DateTime Fecha_emision { get; set; }
        public Atencion Atencion { get; set; }
        public decimal Valor_total { get; set; }


        public Boleta()
        {
            Id_boleta = "";
            Medio_de_pago = new Medio_de_Pago();
            Fecha_emision = DateTime.Now;
            Atencion = new Atencion();
            Valor_total = 0;
        }
/*
 
        public int Create()
        {
            try
            {
                CapaDeDatos.Boleta b = new CapaDeDatos.Boleta();
                b.Cod_Boleta = this.CodBoleta;
                b.Cod_Pedido= this.Cod_Pedido;
                b.Cod_Pago= this.Cod_Pago;
                b.MontoDescontado = this.MontoDescontado;
                b.MontoDescuento = this.MontoDescuento;
                b.Descuento = this.Descuento;
                b.IdTipoPago = this.IdTipoPago;

                CommonBC.Modelo.Boleta.Add(b);
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
                CapaDeDatos.Boleta b = CommonBC.Modelo.Boleta.First(x => x.IdBoleta == this.IdBoleta);
                this.IdBoleta = b.IdBoleta;
                this.FechaEmision = b.FechaEmision;
                this.IdTipoEntrega = b.IdTipoEntrega;
                this.MontoTotal = b.MontoTotal;
                this.MontoDescontado = b.MontoDescontado;
                this.MontoDescuento = b.MontoDescuento;
                this.Descuento = b.Descuento;

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
                CapaDeDatos.Boleta b = CommonBC.Modelo.Boleta.First(x => x.IdBoleta == this.IdBoleta);
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
        }
*/
    }
}
