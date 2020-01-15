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
using DGVPrinterHelper;

namespace CapaPresentacion
{
    public partial class FormVentas : Form
    {
        public double total = 0, cambio;
        public float inicio;
        public string idObtenida = "";

        CN_Ventas objetoCN = new CN_Ventas();
        Form_Mensaje_A objma;
        Form_Mensaje_E objme;

        public FormVentas()
        {
            InitializeComponent();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            MostrarProductosVentas();
        }

        public void MostrarProductosVentas()
        {
            CN_Ventas objeto = new CN_Ventas();
            tabla_productos.DataSource = objeto.MostrarProductosVen();
        }

        private void b_agregar_Click(object sender, EventArgs e)
        {

        }

        private void t_buscar_TextChanged(object sender, EventArgs e)
        {
            if (t_buscar.Text != "")
            {
                tabla_productos.CurrentCell = null;
                foreach (DataGridViewRow r in tabla_productos.Rows)
                {
                    r.Visible = false;
                }

                foreach (DataGridViewRow r in tabla_productos.Rows)
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
                CN_Ventas obj = new CN_Ventas();
                tabla_productos.DataSource = obj.MostrarProductosVen();
            }
        }

        private void LlenarDetalleVenta()
        {
            try
            {
                string descrip, cant, precioV, descu;
                double precioNeto, cantidad, precioVenta, descuento;
                descrip = tabla_productos.CurrentRow.Cells["descripcion_producto"].Value.ToString();
                cant = t_cantidad.Text;
                descu = t_descuento.Text;
                precioV = tabla_productos.CurrentRow.Cells["precio_venta"].Value.ToString();

                cantidad = Convert.ToInt32(cant);
                descuento = Convert.ToInt32(descu);
                precioVenta = Convert.ToDouble(precioV);


                if (descuento > 0)
                {
                    descuento = descuento / 100;
                    precioVenta = precioVenta - (precioVenta * descuento);
                    precioNeto = cantidad * precioVenta;
                    tabla_venta.Rows.Add(descrip, cant, Convert.ToString(precioNeto));
                }
                else
                {
                    precioNeto = cantidad * precioVenta;
                    tabla_venta.Rows.Add(descrip, cant, Convert.ToString(precioNeto));
                }
            }
            catch (Exception ex)
            {
                objme = new Form_Mensaje_E("Ha Ocurridó un error");
                objme.Show();
            }
        }

        private void b_agregar_Click_1(object sender, EventArgs e)
        {
            if (tabla_productos.SelectedRows.Count > 0)
            {
                string cant, existencia;
                cant = t_cantidad.Text;
                existencia = tabla_productos.CurrentRow.Cells["existencia"].Value.ToString();
                if (Convert.ToInt32(cant) <= Convert.ToInt32(existencia))
                {
                    LlenarDetalleVenta();
                    error.Clear();
                }
                else
                {
                    error.SetError(this.t_cantidad, "No hay suficientes");
                }
            }
            else
            {
                error.SetError(this.b_agregar, "No seleccionó una fila");
            }  
        }

        private void b_agregarServicio_Click(object sender, EventArgs e)
        {
            if(t_descripcionServicio.Text == string.Empty)
            {
                error.SetError(this.t_descripcionServicio, "Campo Vacio");
            }
            else
            {
                error.Clear();
                if (t_costoServicio.Text == string.Empty)
                {
                    error.SetError(this.t_costoServicio, "Campo Vacio");
                }
                else
                {
                    tabla_venta.Rows.Add(t_descripcionServicio.Text, "1", t_costoServicio.Text);
                    t_descripcionServicio.Clear();
                    t_costoServicio.Clear();
                    error.Clear();
                }
            }
        }

        private void b_eliminar_Click(object sender, EventArgs e)
        {
            if (tabla_venta.Rows.Count == 0)
            {
                error.SetError(this.b_eliminar, "Seleccione una fila");
                return;
            }

                if (tabla_productos.SelectedRows.Count > 0)
            {
                tabla_venta.Rows.RemoveAt(tabla_venta.CurrentRow.Index);
                error.Clear();
            }
            else
            {
                error.SetError(this.b_eliminar, "Seleccione una fila");
            }
        }

        private void b_cobrar_Click(object sender, EventArgs e)
        {
            try
            {
                string t;
                double t2, totalaux = 0;
                for (int i = 0; i < tabla_venta.Rows.Count; i++)
                {
                    t = tabla_venta.Rows[i].Cells[2].Value.ToString();
                    t2 = Convert.ToDouble(t);
                    totalaux = totalaux + t2;
                }
                t = totalaux.ToString();

                total = totalaux;

                if (total == 0)
                {
                    error.SetError(this.b_cobrar, "No ha comprado");
                }
                else
                {
                    lb_total.Text = String.Format("Total = ${0}", t);
                    lb_total.Visible = true;
                    error.Clear();
                }
            }
            catch (Exception ex)
            {
                objme = new Form_Mensaje_E("Ha Ocurridó un error");
                objme.Show();
            }
        }

        private void b_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (t_pago.Text == string.Empty || Convert.ToDouble(t_pago.Text) < total || Convert.ToDouble(t_pago.Text) < 0)
                {
                    error.SetError(this.t_pago, "Cantidad incorrecta");
                }
                else
                {
                    error.Clear();
                    if (total == 0)
                    {
                        error.SetError(this.b_cobrar, "No ha comprado");
                    }
                    else
                    {
                        cambio = Convert.ToDouble(t_pago.Text) - total;
                        string t = total.ToString();
                        objetoCN.InsertarVentas(t, t_pago.Text, Convert.ToString(cambio));
                        InsertarEnDetalleVenta();
                        ActulizarLosProductos();
                        InsertarNuevoMovimiento();
                        error.Clear();
                        MostrarProductosVentas();
                        //tabla_venta.Rows.Clear();
                        Imprimir();
                    }
                }
            }
            catch (Exception ex)
            {
                objme = new Form_Mensaje_E("Ha Ocurridó un error");
                objme.Show();
            }
        }

        public void Imprimir()
        {
            DGVPrinter printer = new DGVPrinter();
            String HORA, FECHA;
            HORA = DateTime.Now.ToLongTimeString();
            FECHA = DateTime.Now.ToLongDateString();



            printer.Title = "Molduras y Cortineros\n";

            printer.SubTitle = "HORA: " + HORA + " \nFECHA: " + FECHA + "\n\n Venta #" + idObtenida + "\nCAJERO: Roberto Carlos Hernández García";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = false; //comunmente va true
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "\n\nTOTAL: $" + total + "\nPAGO CON: $" + t_pago.Text.ToString() + "\nSU CAMBIO: $" + cambio + "\n\nGRACIAS POR SU COMPRA";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(tabla_venta);
            tabla_venta.Rows.Clear();
            tabla_venta.Refresh();
            t_pago.Text = "";
            total = 0;
            cambio = 0;
        }

        public void InsertarEnDetalleVenta()
        {
            idObtenida = ObtenerIDVen();
            string descrip, cantidad, precio;
            for (int i = 0; i < tabla_venta.Rows.Count; i++)
            {
                descrip = tabla_venta.Rows[i].Cells[0].Value.ToString();
                cantidad = tabla_venta.Rows[i].Cells[1].Value.ToString();
                precio = tabla_venta.Rows[i].Cells[2].Value.ToString();
                objetoCN.InsertarDetalleVentas(idObtenida, descrip, cantidad, precio);
            }
        }

        public string ObtenerIDVen()
        {
            string id ="";
            CD_Conexion conexion = new CD_Conexion();
            SqlDataReader leer;
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            try
            {
                comando.CommandText = "ObtenerVentaID";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    id = leer["id_venta"].ToString();
                }
                
                leer.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error: " + e.ToString());
            }

            return id;
        }

        public void ActulizarLosProductos()
        {
            string cantidad, descrip;
            for (int i = 0; i < tabla_venta.Rows.Count; i++)
            {
                descrip = tabla_venta.Rows[i].Cells[0].Value.ToString();
                cantidad = tabla_venta.Rows[i].Cells[1].Value.ToString();
                objetoCN.ActualizarProducto(descrip, cantidad);
            }
        }  
        
        public void InsertarNuevoMovimiento()
        {
            string cantidad, descrip, ganancia;
            for (int i = 0; i < tabla_venta.Rows.Count; i++)
            {
                descrip = tabla_venta.Rows[i].Cells[0].Value.ToString();
                cantidad = tabla_venta.Rows[i].Cells[1].Value.ToString();
                ganancia = tabla_venta.Rows[i].Cells[2].Value.ToString();
                objetoCN.InsertarMovimiento(descrip, ganancia, cantidad);
            }
        }
    }
}
