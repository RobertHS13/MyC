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
using System.Data.SqlClient;
using System.Data;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void t_usuario_Enter(object sender, EventArgs e)
        {
            if(t_usuario.Text == "USUARIO")
            {
                t_usuario.Text = "";
                t_usuario.ForeColor = Color.White;
            }
        }

        private void t_contraseña_Leave(object sender, EventArgs e)
        {
            if (t_contraseña.Text == "")
            {
                t_contraseña.Text = "CONTRASEÑA";
                t_contraseña.ForeColor = Color.LightGray;
                t_contraseña.UseSystemPasswordChar = false;
            }
        }

        private void t_contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void t_contraseña_Enter(object sender, EventArgs e)
        {
            if (t_contraseña.Text == "CONTRASEÑA")
            {
                t_contraseña.Text = "";
                t_contraseña.ForeColor = Color.White;
                t_contraseña.UseSystemPasswordChar = true;
            }
        }

        private void t_usuario_Leave(object sender, EventArgs e)
        {
            if (t_usuario.Text == "")
            {
                t_usuario.Text = "USUARIO";
                t_usuario.ForeColor = Color.LightGray;
            }
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void botonAcceder_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void botonAcceder_Click(object sender, EventArgs e)
        {
            CNUsuarios objUsuario = new CapaNegocio.CNUsuarios();
            SqlDataReader Loguear;
            objUsuario.Usuario = t_usuario.Text;
            objUsuario.Contraseña = t_contraseña.Text;
            if (objUsuario.Usuario == t_usuario.Text)
            {
                l_Usuario.Visible = false;

                if (objUsuario.Contraseña == t_contraseña.Text)
                {
                    l_Contraseña.Visible = false;

                    Loguear = objUsuario.IniciarSesion();
                    if (Loguear.Read() == true)
                    {
                        this.Hide();
                        Form1 objF1 = new Form1();
                        objF1.Show();
                    }
                    else
                    {
                        l_Login.Text = "Usuario o contraseña incorrectas, intente de nuevo";
                        l_Login.Visible = true;
                        t_contraseña.Text = "";
                        t_contraseña_Leave(null, e);
                        t_usuario.Focus();
                    }
                }
                else {
                    l_Contraseña.Text = objUsuario.Contraseña;
                    l_Contraseña.Visible = true;
                }
            }
            else
            {
                l_Usuario.Text = objUsuario.Usuario;
                l_Usuario.Visible = true;
            }
        }
    }
}
