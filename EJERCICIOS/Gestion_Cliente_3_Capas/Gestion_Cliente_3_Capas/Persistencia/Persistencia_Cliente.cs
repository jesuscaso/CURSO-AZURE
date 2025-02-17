using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_Cliente_3_Capas.Negocio.Entidades;

namespace Gestion_Cliente_3_Capas.Persistencia
{
    public class Persistencia_Cliente
    {
        Cliente[] clientes = new Cliente[3];
        int pos = 0;
        public bool Agregar_Cliente(Cliente cliente)
        {
            bool estado = false;
            if (pos < clientes.Length)
            {
                clientes[pos] = cliente;
                pos++;
                estado = true;
            }
            return estado;
        }

        public Cliente[] Listar_Clientes()
        {
            return clientes;
        }

    }
}
