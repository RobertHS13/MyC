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
    public class CN_Ventas
    {
        private CD_Ventas objetoCD = new CD_Ventas();

        public DataTable MostrarProductosVen()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarProdVen();
            return tabla;
        }

        public void InsertarVentas(string total, string pago, string cambio)
        {
            objetoCD.InsertarVen(Convert.ToDouble(total), Convert.ToDouble(pago), Convert.ToDouble(cambio));
        }

        public void InsertarDetalleVentas(string id, string descripcion, string cantidad, string precio)
        {
            objetoCD.InsertarDetalleVen(Convert.ToInt32(id), descripcion, Convert.ToInt32(cantidad), Convert.ToDouble(precio));
        }

        public void ActualizarProducto(string descripcion, string cantidad)
        {
            objetoCD.ActualizarProd(descripcion, Convert.ToInt32(cantidad));
        }

        public void InsertarMovimiento(string descripcion, string ganancia, string cantidad)
        {
            objetoCD.InsertarMov(descripcion, Convert.ToDouble(ganancia), Convert.ToInt32(cantidad));
        }
    }
}
