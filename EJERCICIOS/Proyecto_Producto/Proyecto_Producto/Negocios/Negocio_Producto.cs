using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Producto.Interfaces;
using Proyecto_Producto.Negocios.Entidades;
using Proyecto_Producto.Persistencia;
namespace Proyecto_Producto.Negocios
{
    public class Negocio_Producto:ICRUD<Producto>
    {
        Persistir_Producto persistir_producto = new Persistir_Producto();

        public bool Create(Producto entidad)
        {
            return persistir_producto.Create(entidad);
        }

        public List<Producto> ReadAll()
        {
            return persistir_producto.ReadAll();
        }

        public Producto? Read(object id)
        {
            return persistir_producto.Read(id);
        }

        public bool Update(Producto entidad)
        {
            return persistir_producto.Update(entidad);
        }

        public bool Delete(Producto entidad)
        {
            return persistir_producto.Delete(entidad);
        }
    }
}