using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaNegocio;
using CapaDatos;
using System.Data.SqlClient;
using System.Data;
using DGVPrinterHelper;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonAmpliar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            botonAmpliar.Visible = false;
            botonRestaurar.Visible = true;
        }

        private void botonRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            botonRestaurar.Visible = false;
            botonAmpliar.Visible = true;
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void botonReportes_Click(object sender, EventArgs e)
        {
            panelSubmenu.Visible = true;
        }

        //Movimientos
        

        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        private void botonReporteVentas_Click(object sender, EventArgs e)
        {
            GenerarReporteMovimientos();
            /*comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarMovimientos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            conexion.CerrarConexion();*/
        }

        public DataTable MostrarMov()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarMovimientos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarMov2()
        {
            DataTable tabla = new DataTable();
            tabla = MostrarMov();
            return tabla;
        }

        public void GenerarReporteMovimientos()
        {
            tabla_movimientos.DataSource = MostrarMov2();

            DGVPrinter printer = new DGVPrinter();
            String HORA, FECHA;
            HORA = DateTime.Now.ToLongTimeString();
            FECHA = DateTime.Now.ToLongDateString();



            printer.Title = "REGISTRO DE MOVIMIENTOS\n";

            //printer.SubTitle = "HORA: " + HORA + " \nFECHA: " + FECHA + "\n\n Venta #" + ultimo;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = false; //comunmente va true
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            //printer.Footer = "\n\n\n\nMonto total: " + TXTTOTAL.Text + "$";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(tabla_movimientos);
            tabla_movimientos.Refresh();
        }

        private void botonReporteCompras_Click(object sender, EventArgs e)
        {
            panelSubmenu.Visible = false;
        }

        private void botonReportePagos_Click(object sender, EventArgs e)
        {
            panelSubmenu.Visible = false;
        }

        private void botonVentas_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormVentas());
        }

        private void AbrirFormHijo(object formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void botonProductos_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormProductos());
        }

        private void botonProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormProveedores());
        }

        private void botonClientes_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormClientes());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormVentas());
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSubmenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
