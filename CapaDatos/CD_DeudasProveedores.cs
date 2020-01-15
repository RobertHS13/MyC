using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDatos;

namespace CapaDatos
{
    public class CD_DeudasProveedores
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarDeudasProveedores";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(string proveedor, string folio, double cantidad, string fecha, string estado)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarDeudasProveedores";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("proveedor", proveedor);
            comando.Parameters.AddWithValue("folio_factura", folio);
            comando.Parameters.AddWithValue("cantidad_compra", cantidad);
            comando.Parameters.AddWithValue("fecha_registro", fecha);
            comando.Parameters.AddWithValue("estado", estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar(int id, string proveedor, string folio, double cantidad, string fecha, string estado)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ModificarDeudasProveedores";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("id_deuda_proveedor", id);
            comando.Parameters.AddWithValue("proveedor", proveedor);
            comando.Parameters.AddWithValue("folio_factura", folio);
            comando.Parameters.AddWithValue("cantidad_compra", cantidad);
            comando.Parameters.AddWithValue("fecha_registro", fecha);
            comando.Parameters.AddWithValue("estado", estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarDeudasProveedores";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("id_deuda_proveedor", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
