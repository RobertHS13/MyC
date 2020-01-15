using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Ventas
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarProdVen()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProductosVentas";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarVen(double total, double pago, double cambio)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarVentas";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("total_venta", total);
            comando.Parameters.AddWithValue("pagocon", pago);
            comando.Parameters.AddWithValue("cambio", cambio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void InsertarDetalleVen(int id, string descripcion, int cantidad, double precio)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarDetalleVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("id_venta", id);
            comando.Parameters.AddWithValue("descripcion", descripcion);
            comando.Parameters.AddWithValue("cantidad", cantidad);
            comando.Parameters.AddWithValue("precio", precio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void ActualizarProd(string descripcion, int cantidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarCantidadProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("descripcion_producto", descripcion);
            comando.Parameters.AddWithValue("existencia", cantidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void InsertarMov(string descripcion, double ganancia, int cantidad)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarMovimiento";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("descripcion_movimiento ", descripcion);
            comando.Parameters.AddWithValue("ganancia_movimiento",ganancia);
            comando.Parameters.AddWithValue("cantidad_movimiento", cantidad);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
