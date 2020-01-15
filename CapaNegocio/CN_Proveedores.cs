using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Proveedores
    {
        private CD_Proveedores objetoCD = new CD_Proveedores();

        public DataTable MostrarProveedor()
        {
            DataTable tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarProveedor(string nombre, string direccion, string telefono, string correo, string cuidad, string agente)
        {
            objetoCD.Insertar(nombre, direccion, telefono, correo, cuidad, agente);
        }

        public void EditarProveedor(string id, string nombre, string direccion, string telefono, string correo, string cuidad, string agente)
        {
            objetoCD.Editar(Convert.ToInt32(id), nombre, direccion, telefono, correo, cuidad, agente);
        }

        public void EliminarProveedor(String id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}
