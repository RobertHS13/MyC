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
    public partial class FormProveedores : Form
    {
        CN_Proveedores objetoCN = new CN_Proveedores();
        private bool Editar = false;
        private string id = null;
        Form_Mensaje_A objma;
        Form_Mensaje_E objme;

        public FormProveedores()
        {
            InitializeComponent();
            //this.FormProveedores_Load(null, null);
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            MostrarProveedores();
            MostrarDeudasProveedores();
            Llenar_Proveedor(cb_proveedor);
            cb_estado.Items.Add("Pendiente");
            cb_estado.Items.Add("Pagado");
            cb_estado.SelectedIndex = 0;
        }

        private void MostrarProveedores()
        {
            CN_Proveedores objeto = new CN_Proveedores();
            tablaProveedores.DataSource = objeto.MostrarProveedor();
        }

        private void b_guardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarProveedor(t_nombre.Text, t_direccion.Text, t_telefono.Text, t_correo.Text, t_cuidad.Text, t_agente.Text);
                    objma = new Form_Mensaje_A("Proveedor agregadó correctamente");
                    objma.Show();
                    MostrarProveedores();
                    Limpiar_Datos();
                    Llenar_Proveedor(cb_proveedor);
                }
                catch(Exception ex)
                {
                    objme = new Form_Mensaje_E("Ha ocurridó un error");
                    objme.Show();
                }
            }

            if (Editar == true)
            {
                try
                {
                    objetoCN.EditarProveedor(id, t_nombre.Text, t_direccion.Text, t_telefono.Text, t_correo.Text, t_cuidad.Text, t_agente.Text);
                    objma = new Form_Mensaje_A("Proveedor editadó correctamente");
                    objma.Show();
                    MostrarProveedores();
                    Limpiar_Datos();
                    Llenar_Proveedor(cb_proveedor);
                    Editar = false;
                }
                catch (Exception ex)
                {
                    objme = new Form_Mensaje_E("Ha Ocurridó un error de edicion");
                    objme.Show();
                }
            }
        }

        private void b_modificar_Click(object sender, EventArgs e)
        {
            if (tablaProveedores.SelectedRows.Count > 0)
            {
                Editar = true;
                id= tablaProveedores.CurrentRow.Cells["id_proveedor"].Value.ToString();
                t_nombre.Text = tablaProveedores.CurrentRow.Cells["nombre_proveedor"].Value.ToString();
                t_direccion.Text = tablaProveedores.CurrentRow.Cells["direccion_proveedor"].Value.ToString();
                t_telefono.Text = tablaProveedores.CurrentRow.Cells["telefono_proveedor"].Value.ToString();
                t_correo.Text = tablaProveedores.CurrentRow.Cells["correo_proveedor"].Value.ToString();
                t_cuidad.Text = tablaProveedores.CurrentRow.Cells["ciudad_proveedor"].Value.ToString();
                t_agente.Text = tablaProveedores.CurrentRow.Cells["nombre_agente"].Value.ToString();
            }
            else
            {
                objme = new Form_Mensaje_E("Seleccione una fila");
                objme.Show();
            }
        }

        private void b_eliminar_Click(object sender, EventArgs e)
        {
            if (tablaProveedores.SelectedRows.Count > 0)
            {
                id = tablaProveedores.CurrentRow.Cells["id_proveedor"].Value.ToString();
                objetoCN.EliminarProveedor(id);
                objma = new Form_Mensaje_A("Proveedor eliminadó correctamente");
                objma.Show();
                MostrarProveedores();
                Limpiar_Datos();
                Llenar_Proveedor(cb_proveedor);
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
            t_cuidad.Clear();
            t_agente.Clear();
        }

        private void Limpiar_Datos2()
        {
            cb_proveedor.SelectedIndex = 0;
            t_folio.Clear();
            t_cantidad.Clear();
            t_fechaV.Clear();
            cb_estado.SelectedIndex = 0;
        }

        private void cb_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        //LLenado de Combo Box Proveedores

        public void Llenar_Proveedor(ComboBox cb)
        {
            cb.Items.Clear();
            CD_Conexion conexion = new CD_Conexion();
            SqlDataReader leer;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            try
            {
                comando.CommandText = "LLenar_Proveedor";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    cb.Items.Add(leer["nombre_proveedor"].ToString());
                }
                cb.SelectedIndex = 0;
                leer.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se lleno el ComboBox: " + e.ToString());
            }
        }

        private void t_buscar_TextChanged(object sender, EventArgs e)
        {
            if (t_buscar.Text != "")
            {
                tablaProveedores.CurrentCell = null;
                foreach (DataGridViewRow r in tablaProveedores.Rows)
                {
                    r.Visible = false;
                }

                foreach (DataGridViewRow r in tablaProveedores.Rows)
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
                CN_Proveedores obj = new CN_Proveedores();
                tablaProveedores.DataSource = obj.MostrarProveedor();
            }
        }

        //Deudas Proveedores
        CN_DeudasProveedores objetoCN2 = new CN_DeudasProveedores();
        private bool Editar2 = false;
        private string id2 = null;

        private void MostrarDeudasProveedores()
        {
            CN_DeudasProveedores objeto = new CN_DeudasProveedores();
            tablaDeudas.DataSource = objeto.MostrarDProveedor();
        }

        private void b_guardar2_Click(object sender, EventArgs e)
        {
            if (Editar2 == false)
            {
                try
                {
                    objetoCN2.InsertarDProveedor(cb_proveedor.SelectedItem.ToString(), t_folio.Text, t_cantidad.Text, t_fechaV.Text, cb_estado.SelectedItem.ToString());
                    objma = new Form_Mensaje_A("Registro agregadó correctamente");
                    objma.Show();
                    MostrarDeudasProveedores();
                    Limpiar_Datos2();
                }
                catch (Exception ex)
                {
                    objme = new Form_Mensaje_E("Ha ocurridó un error");
                    objme.Show();
                }
            }

            if (Editar2 == true)
            {
                try
                {
                    objetoCN2.EditarDProveedor(id2, cb_proveedor.SelectedItem.ToString(), t_folio.Text, t_cantidad.Text, t_fechaV.Text, cb_estado.SelectedItem.ToString());
                    objma = new Form_Mensaje_A("Registro editadó correctamente");
                    objma.Show();
                    MostrarDeudasProveedores();
                    Limpiar_Datos2();
                    Editar2 = false;
                }
                catch (Exception ex)
                {
                    objme = new Form_Mensaje_E("Ha Ocurridó un error de edicion");
                    objme.Show();
                }
            }

        }

        private void b_modificar2_Click(object sender, EventArgs e)
        {
            if (tablaDeudas.SelectedRows.Count > 0)
            {
                Editar2 = true;
                id2 = tablaDeudas.CurrentRow.Cells["id_deuda_proveedor"].Value.ToString();
                //cb_proveedor.SelectedItem(tablaDeudas.CurrentRow.Cells["nombre_proveedor"].Value.ToString());
                t_folio.Text = tablaDeudas.CurrentRow.Cells["folio_factura"].Value.ToString();
                t_cantidad.Text = tablaDeudas.CurrentRow.Cells["cantidad_compra"].Value.ToString();
                t_fechaV.Text = tablaDeudas.CurrentRow.Cells["fecha_registro"].Value.ToString();
            }
            else
            {
                objme = new Form_Mensaje_E("Seleccione una fila");
                objme.Show();
            }
        }

        private void b_eliminar2_Click(object sender, EventArgs e)
        {
            if (tablaDeudas.SelectedRows.Count > 0)
            {
                id2 = tablaDeudas.CurrentRow.Cells["id_deuda_proveedor"].Value.ToString();
                objetoCN2.EliminarDProveedor(id2);
                objma = new Form_Mensaje_A("Registro eliminadó correctamente");
                objma.Show();
                MostrarDeudasProveedores();
                Limpiar_Datos2();
            }
            else
            {
                objme = new Form_Mensaje_E("Seleccione una fila");
                objme.Show();
            }
        }

        private void t_buscar_TextChanged2(object sender, EventArgs e)
        {
            if (t_buscar2.Text != "")
            {
                tablaDeudas.CurrentCell = null;
                foreach (DataGridViewRow r in tablaDeudas.Rows)
                {
                    r.Visible = false;
                }

                foreach (DataGridViewRow r in tablaDeudas.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(t_buscar2.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                var obj = new CN_DeudasProveedores();
                tablaDeudas.DataSource = obj.MostrarDProveedor();
            }
        }

    }
}
