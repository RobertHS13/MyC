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
    public partial class Form_Mensaje_E : Form
    {
        public Form_Mensaje_E(String msg)
        {
            InitializeComponent();
            lb_mensajeE.Text = msg;
        }

        private void b_aceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
