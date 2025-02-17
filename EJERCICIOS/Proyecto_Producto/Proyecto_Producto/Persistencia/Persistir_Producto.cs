using Proyecto_Producto.Interfaces;
using Proyecto_Producto.Negocios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Producto.Persistencia
{
    //Create Read ReadAll Update Delete

    public class Persistir_Producto : ICRUD<Producto>
    {
        List<Producto> productos=new List<Producto>();

        public bool Create(Producto entidad)
        {
            bool estado = false;

            if (entidad != null)
            {
                productos.Add(entidad);
                estado = true;
            }
            return estado;
        }

        public bool Delete(Producto entidad)
        {
            bool estado = false;

            Producto? productoEnviado = entidad;
            Producto? productoBuscado = Read(productoEnviado.Id);
            if (productoBuscado != null)
            {
                productos.Remove(productoBuscado);
                estado = true;
            }

            return estado;
        }

        public Producto? Read(object Id)
        {
            Producto? productoObtenido = null;

            for (int i = 0; i < productos.Count; i++)
            {
                if (productos[i].Id == (int)Id)
                {
                    productoObtenido = productos[i];
                    break;
                }
            }
            return productoObtenido;
        }

        public List<Producto> ReadAll()
        {
            return productos;
        }

        public bool Update(Producto entidad)
        {
            bool estado = false;

            Producto? productoEnviado = entidad;

            Producto? productoBuscado = (Producto?)Read(productoEnviado.Id);
            if (productoBuscado != null)
            {
                productoBuscado = productoEnviado;
                estado = true;
            }

            return estado;
        }
    }
}