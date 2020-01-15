using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Clientes
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(string nombre, string direccion, string telelfono, string correo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("nombre_cliente", nombre);
            comando.Parameters.AddWithValue("direccion_cliente", direccion);
            comando.Parameters.AddWithValue("telefono_cliente", telelfono);
            comando.Parameters.AddWithValue("correo_cliente", correo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar(int id, string nombre, string direccion, string telelfono, string correo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ModificarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("id_clientes", id);
            comando.Parameters.AddWithValue("nombre_cliente", nombre);
            comando.Parameters.AddWithValue("direccion_cliente", direccion);
            comando.Parameters.AddWithValue("telefono_cliente", telelfono);
            comando.Parameters.AddWithValue("correo_cliente", correo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("id_clientes", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
