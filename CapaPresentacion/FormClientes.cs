using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using CapaNegocio;
using CapaDatos;


namespace CapaPresentacion
{
    public partial class FormClientes : Form
    {
        CN_Clientes objetoCN = new CN_Clientes();
        private bool Editar = false;
        private string id = null;
        Form_Mensaje_A objma;
        Form_Mensaje_E objme;

        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void MostrarClientes()
        {
            CN_Clientes objeto = new CN_Clientes();
            tabla_clientes.DataSource = objeto.MostrarCliente();
        }

        private void b_guardar_Click(object sender, EventArgs e)
        {
            if (t_nombre.Text == string.Empty || t_direccion.Text == string.Empty || t_telefono.Text == string.Empty || t_correo.Text == string.Empty)
            {
                error.SetError(this.b_guardar, "Campos Vacios");
            }
            else
            {
                error.Clear();
                if (Editar == false)
                {
                    try
                    {
                        objetoCN.InsertarClientes(t_nombre.Text, t_direccion.Text, t_telefono.Text, t_correo.Text);
                        objma = new Form_Mensaje_A("Cliente agregadó correctamente");
                        objma.Show();
                        MostrarClientes();
                        Limpiar_Datos();
                    }
                    catch (Exception ex)
                    {
                        objme = new Form_Mensaje_E("Ha ocurridó un error");
                        objme.Show();
                    }
                }
                if (Editar == true)
                {
                    try
                    {
                        objetoCN.EditarClientes(id, t_nombre.Text, t_direccion.Text, t_telefono.Text, t_correo.Text);
                        objma = new Form_Mensaje_A("Cliente editadó correctamente");
                        objma.Show();
                        MostrarClientes();
                        Limpiar_Datos();
                        Editar = false;
                    }
                    catch (Exception ex)
                    {
                        objme = new Form_Mensaje_E("Ha Ocurridó un error de edicion");
                        objme.Show();
                    }
                }
            }
        }

        private void b_modificar_Click(object sender, EventArgs e)
        {
            if (tabla_clientes.SelectedRows.Count > 0)
            {
                Editar = true;
                id = tabla_clientes.CurrentRow.Cells["id_clientes"].Value.ToString();
                t_nombre.Text = tabla_clientes.CurrentRow.Cells["nombre_cliente"].Value.ToString();
                t_direccion.Text = tabla_clientes.CurrentRow.Cells["direccion_cliente"].Value.ToString();
                t_telefono.Text = tabla_clientes.CurrentRow.Cells["telefono_cliente"].Value.ToString();
                t_correo.Text = tabla_clientes.CurrentRow.Cells["correo_cliente"].Value.ToString();
            }
            else
            {
                objme = new Form_Mensaje_E("Seleccione una fila");
                objme.Show();
            }
        }

        private void b_eliminar_Click(object sender, EventArgs e)
        {
            if (tabla_clientes.SelectedRows.Count > 0)
            {
                id = tabla_clientes.CurrentRow.Cells["id_clientes"].Value.ToString();
                objetoCN.EliminarClientes(id);
                objma = new Form_Mensaje_A("Cliente eliminadó correctamente");
                objma.Show();
                MostrarClientes();
                Limpiar_Datos();
            }
            else
            {
                objme = new Form_Mensaje_E("Seleccione una fila");
                objme.Show();
            }
        }

        private void Limpiar_Datos()
        {
            t_nombre.Clear();
            t_direccion.Clear();
            t_telefono.Clear();
            t_correo.Clear();
        }

        private void t_buscar_TextChanged(object sender, EventArgs e)
        {
            if (t_buscar.Text != "")
            {
                tabla_clientes.CurrentCell = null;
                foreach (DataGridViewRow r in tabla_clientes.Rows)
                {
                    r.Visible = false;
                }

                foreach (DataGridViewRow r in tabla_clientes.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(t_buscar.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                CN_Clientes obj = new CN_Clientes();
                tabla_clientes.DataSource = obj.MostrarCliente();
            }
        }
    }
}
