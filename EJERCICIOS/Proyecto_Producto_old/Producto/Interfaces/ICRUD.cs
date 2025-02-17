using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Producto.Interfaces
{
    public interface ICRUD
    {
        bool Create(object entidad);
        object Read(object Id);
        List<object> ReadAll();
        bool Update(object entidad);
        bool Delete(object entidad);
    }
}
