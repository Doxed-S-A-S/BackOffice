using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Controlador;

namespace Interfaz
{
    public partial class ControlUsuario : UserControl
    {
        public ControlUsuario()
        {
            InitializeComponent();
        }

        private void BtnEliminarPost_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarTablaPost()
        {
            LboxPublicaciones.Refresh();
            LboxPublicaciones.DataSource = ControlPosts.Listar();
        }

        private void BtnActualizarPub_Click(object sender, EventArgs e)
        {
            ActualizarTablaPost();
        }
    }
}
