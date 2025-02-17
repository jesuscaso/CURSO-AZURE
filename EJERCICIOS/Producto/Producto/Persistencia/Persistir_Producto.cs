using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Producto.Negocios.Entidades;

namespace Proyecto_Producto.Persistencia
{
    public class Persistir_Producto
    {
        // Producto[] productos = new Producto[3];
        List<Producto> productos = new List<Producto>();
        int pos = 0;
        public bool GuardarProducto(Producto producto)
        {
            bool estado = false;
            //if (pos < 3)
            if (producto != null) {
            {
                //productos[pos] = producto;
                //pos++;
                productos.Add(producto);
                estado = true;
            }
            return estado;
        }

        //public Producto[] ListarProductos()
        public List<Producto> ListarProductos() {
        {
            return productos;
        }
    }
}
