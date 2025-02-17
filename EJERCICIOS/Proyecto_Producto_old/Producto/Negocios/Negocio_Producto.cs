using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Producto.Negocios.Entidades;
using Proyecto_Producto.Persistencia;

namespace Proyecto_Producto.Negocios
{
    public class Negocio_Producto
    {
        Persistir_Producto persistir_producto = new Persistir_Producto();
        public bool GuardarProducto(Producto producto)
        {
            return persistir_producto.GuardarProducto(producto);    
        }
        public Producto[] ListarProductos()
        {
            return persistir_producto.ListarProductos();
        }

        public Producto BuscarProducto(int id)
        {
            return persistir_producto.BuscarProducto(id);
        }
    }
}
