using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Clientes
    {
        private CD_Clientes objetoCD = new CD_Clientes();

        public DataTable MostrarCliente()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarClientes(string nombre, string direccion, string telelfono, string correo)
        {
            objetoCD.Insertar(nombre, direccion, telelfono, correo);
        }

        public void EditarClientes(string id, string nombre, string direccion, string telelfono, string correo)
        {
            objetoCD.Editar(Convert.ToInt32(id), nombre, direccion, telelfono, correo);
        }

        public void EliminarClientes(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}
