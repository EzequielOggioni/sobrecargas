using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ItemFactura
    {
        Producto producto;
        int cantidad;
        double precio;

        public double GetPrecio()
        {
            return this.precio;
        }

        public int GetCantidad()
        {
            return this.cantidad;
                 
        }
        
        public static bool operator ==(ItemFactura factura, ItemFactura facturaCompara)
        {
            return factura.producto == facturaCompara.producto;
        }

        public static bool operator !=(ItemFactura factura, ItemFactura facturaCompara)
        {
            return !(factura == facturaCompara);
        }

        public static implicit operator ItemFactura(Producto productoACastear)
        {
            ItemFactura itemFactura = new ItemFactura();
            itemFactura.producto = productoACastear;
            itemFactura.precio = productoACastear.GetPrecio();
            itemFactura.cantidad = 1;
            return itemFactura;
        }

        public void SetCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }
    }
}
