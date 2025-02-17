using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_Cliente_3_Capas.Negocio.Entidades;
using Gestion_Cliente_3_Capas.Persistencia;

namespace Gestion_Cliente_3_Capas.Negocio
{
    public class Operaciones_Clientes
    {
        Persistencia_Cliente persistencia_cliente = new Persistencia_Cliente();
        public bool Agregar_Cliente(Cliente cliente)
        {
            return persistencia_cliente.Agregar_Cliente(cliente);
        }
        public Cliente[] Listar_Clientes()
        {
            return persistencia_cliente.Listar_Clientes();
        }
    }
}
