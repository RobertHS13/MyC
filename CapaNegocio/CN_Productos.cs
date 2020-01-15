using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Productos
    {
        private CD_Productos objetoCD = new CD_Productos();

        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarProd(string id, string descripcion, string existencia, string precio_costo, string precio_venta, string cantidad_minima, string folio_factura)
        {
            objetoCD.Insertar(id, descripcion, Convert.ToInt32(existencia), Convert.ToDouble(precio_costo), Convert.ToDouble(precio_venta), Convert.ToInt32(cantidad_minima), folio_factura);
        }

        public void EditarProd(string id, string descripcion, string existencia, string precio_costo, string precio_venta, string cantidad_minima)
        {
            objetoCD.Editar(id, descripcion, Convert.ToInt32(existencia), Convert.ToDouble(precio_costo), Convert.ToDouble(precio_venta), Convert.ToInt32(cantidad_minima));
        }

        public void EliminarProd(string id)
        {
            objetoCD.Eliminar(id);
        }
    }
}
