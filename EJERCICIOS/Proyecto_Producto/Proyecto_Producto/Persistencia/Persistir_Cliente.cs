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

    public class Persistir_Cliente : ICRUD<Cliente>
    {
        List<Cliente> clientes = new List<Cliente>();

        public bool Create(Cliente entidad)
        {
            bool estado = false;

            if (entidad != null)
            {
                clientes.Add(entidad);
                estado = true;
            }
            return estado;
        }

        public bool Delete(Cliente entidad)
        {
            bool estado = false;

            Cliente? clienteEnviado = entidad;
            Cliente? clienteBuscado = Read(clienteEnviado.Id);
            if (clienteBuscado != null)
            {
                clientes.Remove(clienteBuscado);
                estado = true;
            }

            return estado;
        }

        public Cliente? Read(object Id)
        {
            Cliente? clienteObtenido = null;

            for (int i = 0; i < clientes.Count; i++)
            {
                if (clientes[i].Id == (int)Id)
                {
                    clienteObtenido = clientes[i];
                    break;
                }
            }
            return clienteObtenido;
        }

        public List<Cliente> ReadAll()
        {
            return clientes;
        }

        public bool Update(Cliente entidad)
        {
            bool estado = false;

            Cliente? clienteEnviado = entidad;

            Cliente? clienteBuscado = (Cliente?)Read(clienteEnviado.Id);
            if (clienteBuscado != null)
            {
                clienteBuscado = clienteEnviado;
                estado = true;
            }

            return estado;
        }
    }
}