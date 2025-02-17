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
    public class Negocio_Cliente:ICRUD<Cliente>
    {
        Persistir_Cliente persistir_cliente = new Persistir_Cliente();

        public bool Create(Cliente entidad)
        {
            return persistir_cliente.Create(entidad);
        }

        public List<Cliente> ReadAll()
        {
            return persistir_cliente.ReadAll();
        }

        public Cliente? Read(object id)
        {
            return persistir_cliente.Read(id);
        }

        public bool Update(Cliente entidad)
        {
            return persistir_cliente.Update(entidad);
        }

        public bool Delete(Cliente entidad)
        {
            return persistir_cliente.Delete(entidad);
        }
    }
}