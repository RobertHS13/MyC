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
    public class CD_Proveedores
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProveedores";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(string nombre, string direccion, string telefono, string correo, string cuidad, string agente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarProveedores";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("nombre_proveedor", nombre);
            comando.Parameters.AddWithValue("direccion_proveedor", direccion);
            comando.Parameters.AddWithValue("telefono_proveedor", telefono);
            comando.Parameters.AddWithValue("correo_proveedor", correo);
            comando.Parameters.AddWithValue("ciudad_proveedor", cuidad);
            comando.Parameters.AddWithValue("nombre_agente", agente);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar(int id, string nombre, string direccion, string telefono, string correo, string cuidad, string agente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarProveedores";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("id_proveedor", id);
            comando.Parameters.AddWithValue("nombre_proveedor", nombre);
            comando.Parameters.AddWithValue("direccion_proveedor", direccion);
            comando.Parameters.AddWithValue("telefono_proveedor", telefono);
            comando.Parameters.AddWithValue("correo_proveedor", correo);
            comando.Parameters.AddWithValue("ciudad_proveedor", cuidad);
            comando.Parameters.AddWithValue("nombre_agente", agente);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarProveedores";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("id_proveedor", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
