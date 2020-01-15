using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Productos
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(string id, string descripcion, int existencia, double precio_costo, double precio_venta, int cantidad_minima, string folio_factura)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("id_producto", id);
            comando.Parameters.AddWithValue("descripcion_producto", descripcion);
            comando.Parameters.AddWithValue("existencia", existencia);
            comando.Parameters.AddWithValue("precio_costo", precio_costo);
            comando.Parameters.AddWithValue("precio_venta", precio_venta);
            comando.Parameters.AddWithValue("cantidad_minima", cantidad_minima);
            comando.Parameters.AddWithValue("folio_factura", folio_factura);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar(string id, string descripcion, int existencia, double precio_costo, double precio_venta, int cantidad_minima)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("id_producto", id);
            comando.Parameters.AddWithValue("descripcion_producto", descripcion);
            comando.Parameters.AddWithValue("existencia", existencia);
            comando.Parameters.AddWithValue("precio_costo", precio_costo);
            comando.Parameters.AddWithValue("precio_venta", precio_venta);
            comando.Parameters.AddWithValue("cantidad_minima", cantidad_minima);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Eliminar(String id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarProductos";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("id_producto", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}