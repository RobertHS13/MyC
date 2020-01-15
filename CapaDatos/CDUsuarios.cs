using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace CapaDatos
{
    public class CDUsuarios { 
        private CD_Conexion conexion = new CD_Conexion();
        private SqlDataReader leer;

        public SqlDataReader iniciarSesion(string user, string pass)
        {
            string sql = "select * from Usuarios where identificador_usuario='"+user+"' and contraseña_usuario='"+pass+"'";
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = sql;
            leer = comando.ExecuteReader();
            return leer;
        }
    
    }
}
