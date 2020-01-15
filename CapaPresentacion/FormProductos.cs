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
    public partial class FormProductos : Form
    {
        CN_Productos objetoCN = new CN_Productos();
        private bool Editar = false;
        Form_Mensaje_A objma;
        Form_Mensaje_E objme;

        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            Llenar_FolioFactura(cb_foliofactura);
            MostrarProductos();
        }

        private void MostrarProductos()
        {
            CN_Productos objeto = new CN_Productos();
            dataGridView1.DataSource = objeto.MostrarProd();
        }


        private void b_guardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarProd(t_id.Text, t_descripcion.Text, t_existencia.Text, t_preciocosto.Text, t_precioventa.Text, t_cantidadminima.Text, cb_foliofactura.SelectedItem.ToString());
                    objma = new Form_Mensaje_A("Producto agregadó correctamente");
                    objma.Show();
                    MostrarProductos();
                    Limpiar_Datos();
                }
                catch(Exception ex)
                {
                    objme = new Form_Mensaje_E("Ha ocurridó un error");
                    objme.Show();
                }
            }
            if(Editar == true)
            {
                try
                {
                    objetoCN.EditarProd(t_id.Text, t_descripcion.Text, t_existencia.Text, t_preciocosto.Text, t_precioventa.Text, t_cantidadminima.Text);
                    objma = new Form_Mensaje_A("Producto editadó correctamente");
                    objma.Show();
                    MostrarProductos();
                    Limpiar_Datos();
                    Editar = false;
                }
                catch(Exception ex)
                {
                    objme = new Form_Mensaje_E("Ha Ocurridó un error");
                    objme.Show();
                }
            }
        }

        private void b_modificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                t_id.Text = dataGridView1.CurrentRow.Cells["id_producto"].Value.ToString();
                t_descripcion.Text = dataGridView1.CurrentRow.Cells["descripcion_producto"].Value.ToString();
                t_existencia.Text = dataGridView1.CurrentRow.Cells["existencia"].Value.ToString();
                t_preciocosto.Text = dataGridView1.CurrentRow.Cells["precio_costo"].Value.ToString();
                t_precioventa.Text = dataGridView1.CurrentRow.Cells["precio_venta"].Value.ToString();
                t_cantidadminima.Text = dataGridView1.CurrentRow.Cells["cantidad_minima"].Value.ToString();
            }
            else
            {
                objme = new Form_Mensaje_E("Seleccione una fila");
                objme.Show();
            }
        }

        private void b_eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                t_id.Text = dataGridView1.CurrentRow.Cells["id_producto"].Value.ToString();
                objetoCN.EliminarProd(t_id.Text);
                objma = new Form_Mensaje_A("Producto eliminadó correctamente");
                objma.Show();
                MostrarProductos();
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
            t_id.Clear();
            t_descripcion.Clear();
            t_existencia.Clear();
            t_preciocosto.Clear();
            t_precioventa.Clear();
            t_cantidadminima.Clear();
            cb_foliofactura.SelectedIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void t_buscar_TextChanged(object sender, EventArgs e)
        {
            if (t_buscar.Text != "")
            {
                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    r.Visible = false;
                }

                foreach (DataGridViewRow r in dataGridView1.Rows)
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
                CN_Productos obj = new CN_Productos();
                dataGridView1.DataSource = obj.MostrarProd();
            }
        }

        //LLenado de Combo Box Folio Factura

        public void Llenar_FolioFactura(ComboBox cb)
        {
            CD_Conexion conexion = new CD_Conexion();
            SqlDataReader leer;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            try
            {
                comando.CommandText = "LLenar_FolioFactura";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    cb.Items.Add(leer["folio_factura"].ToString());
                }
                cb.SelectedIndex = 0;
                leer.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se lleno el ComboBox: "+ e.ToString());
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
