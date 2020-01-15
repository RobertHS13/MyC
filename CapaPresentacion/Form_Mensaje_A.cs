using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form_Mensaje_A : Form
    {
        public Form_Mensaje_A(String msg)
        {
            InitializeComponent();
            lb_mensajeA.Text = msg;
        }

        private void Form_Mensaje_A_Load(object sender, EventArgs e)
        {

        }

        private void lb_mensajeA_Click(object sender, EventArgs e)
        {

        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
