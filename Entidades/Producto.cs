using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        int codigo;
        string descripcion;
        float precio;
        int UStock;
        int UVedidas;

        public float GetPrecio()
        {
            return this.precio;
        }

        public static bool operator == (Producto producto, int codigo)
        {
            return producto.codigo == codigo;
        }

        public static bool operator !=(Producto producto, int codigo)
        {
            return !(producto == codigo);
        }

        public string MostrarProducto()
        {
            return this.codigo.ToString() + " - " + this.descripcion;
        }

        
    }
}
