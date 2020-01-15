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
    public class CNUsuarios
    {
        private CDUsuarios objDato = new CDUsuarios();
        private string _Usuario;
        private string _Contraseña;

        public string Usuario
        {
            set {
                if (value == "USUARIO")
                {
                    _Usuario = "No ha ingresado un usuario";
                }
                else
                    _Usuario = value;
            }
            get { return _Usuario; }
        }

        public string Contraseña
        {
            set {
                if (value == "CONTRASEÑA")
                    _Contraseña = "Ingrese su cotraseña";
                else
                    _Contraseña = value;
            }
            get { return _Contraseña; }
        }

        public CNUsuarios(){ }

        public SqlDataReader IniciarSesion()
        {
            SqlDataReader Loguear;
            Loguear = objDato.iniciarSesion(Usuario, Contraseña);
            return Loguear;
        }
    }
}
