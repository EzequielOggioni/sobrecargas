using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Inventario
    {
        static Producto[] productos;
        static Factura[] facturas;
        static Inventario()
        {
            productos = new Producto[12];
            facturas = new Factura[300];
        }

        public static Producto[] GetProductos()
        {
            return productos;
        }

        public static Producto BuscarProductoPorId(int Id)
        {
            foreach (Producto item in productos)
            {
                if(item == Id)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
