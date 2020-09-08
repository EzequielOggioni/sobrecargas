using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace ProductosInventario
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcion = 0;
            while (opcion != 7)
            {
                opcion = MostrarMenu();
                switch (opcion)
                {

                    case 3:
                        
                        break;
                    case 8:
                        CrearFactura();
                        break;
                }
            }
        }

        static int MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("3 - Nuevo Producto");
            Console.WriteLine("8 -  Crear Factura");
            string salida = Console.ReadLine();
            int opcion;
            while(!int.TryParse(salida, out opcion)  ||  opcion > 8 || opcion < 1 {
                Console.WriteLine("Error Reingrese");
                salida = Console.ReadLine();
            }
        }

        static void CrearFactura()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del cliente: ");
            string cliente = Console.ReadLine();
            
            //Creo la factura
            Factura miFactura = new Factura(cliente);

            // muestro los productos
            foreach (Producto item in Inventario.GetProductos())
            {
                Console.WriteLine(item.MostrarProducto());
            }
            Console.WriteLine("Ingrese el código de producto: ");

            string auxInt = Console.ReadLine();
            int codigoProducto;
            while (!int.TryParse(auxInt, out codigoProducto) || Inventario.BuscarProductoPorId(codigoProducto) == null {
                Console.WriteLine("Error Reingrese");
                auxInt = Console.ReadLine();
            }

            //pido la cantidad
            auxInt = Console.ReadLine();
            int cantidad;
            while (!int.TryParse(auxInt, out cantidad) || cantidad < 1 {
                Console.WriteLine("Error Reingrese");
                auxInt = Console.ReadLine();
            }
            ItemFactura itemFac = Inventario.BuscarProductoPorId(codigoProducto);
            itemFac.SetCantidad(cantidad);

            //Agrego el producto a la factura
            if (miFactura + itemFac)
                Console.WriteLine("Error ingresando el item");


        }
    }
}
