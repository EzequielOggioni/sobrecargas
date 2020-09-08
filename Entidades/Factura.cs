using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        static int cantidadFacturas;
        int numero;
        string cliente;
        ItemFactura[] itemFacturas;
        double total;

        static Factura()
        {
            cantidadFacturas = 0;
        }

        public Factura()
        {
            cantidadFacturas++;
            this.numero = cantidadFacturas;
            this.itemFacturas = new ItemFactura[20];
        }

        public Factura(string cliente) :this()
        {
            this.cliente = cliente;
        }



        /// <summary>
        /// Agrega el item a la factura y recalcula el total, si ya existe, la aumenta la cantidad 
        /// </summary>
        /// <param name="factura"></param>
        /// <param name="itemFac"></param>
        /// <returns></returns>
        public static bool operator +(Factura factura, ItemFactura itemFac)
        {
            bool salida = false;

            if (factura == itemFac)
            {
                for (int i = 0; i < factura.itemFacturas.Length; i++)
                {
                    if (factura.itemFacturas[i] == itemFac)
                    {
                        factura.itemFacturas[i].SetCantidad(factura.itemFacturas[i].GetCantidad()+ itemFac.GetCantidad()) ;
                        salida = true;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < factura.itemFacturas.Length; i++)
                {
                    if (factura.itemFacturas[i] == null)
                    {
                        factura.itemFacturas[i] = itemFac;
                        salida = true;
                        break;
                    }
                }
            }

            factura.calcularTotal();
            return salida;
        }

        private void calcularTotal()
        {
            this.total = 0;
            foreach (ItemFactura item in this.itemFacturas)
            {
                if (item != null)
                    this.total += (item.GetPrecio() * item.GetCantidad());
            }
        }

        public static bool operator ==(Factura factura, ItemFactura itemFactura)
        {
            foreach (ItemFactura item in factura.itemFacturas)
            {
                if (item == itemFactura)
                    return true;
            }

            return false;
        }
        public static bool operator !=(Factura factura, ItemFactura itemFactura)
        {
            !(factura == itemFactura);
        }


    )


    }
}
