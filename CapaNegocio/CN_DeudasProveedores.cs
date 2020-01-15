using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_DeudasProveedores
    {
        private CD_DeudasProveedores objetoCD = new CD_DeudasProveedores();

        public DataTable MostrarDProveedor()
        {
            DataTable tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarDProveedor(string proveedor, string folio, string cantidad, string fecha, string estado)
        {
            objetoCD.Insertar(proveedor, folio, Convert.ToDouble(cantidad), fecha, estado);
        }

        public void EditarDProveedor(string id, string proveedor, string folio, string cantidad, string fecha, string estado)
        {
            objetoCD.Editar(Convert.ToInt32(id), proveedor, folio, Convert.ToDouble(cantidad), fecha, estado);
        }

        public void EliminarDProveedor(String id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}
