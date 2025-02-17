using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Producto.Negocios.Entidades;

namespace Proyecto_Producto.Persistencia
{
    public class Persistir_Producto
    {
        Producto[] productos = new Producto[3];
        int pos = 0;
        public bool GuardarProducto(Producto producto)
        {
            bool estado = false;
            if (pos < 3)
            {
                productos[pos] = producto;
                pos++;
                estado = true;
            }
            return estado;
        }

        public Producto[] ListarProductos()
        {
            return productos;
        }

        public Producto? BuscarProducto(int id)
        {
            Producto? producto = null;

            for (int i = 0; i < productos.Length; i++)
            {
                if (productos[i].Id == id)
                {
                    producto = productos[i];
                    break;
                }
            }
            return producto;
        }
    }
}
