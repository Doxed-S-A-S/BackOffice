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

        private void refrescarTablaDeDatos()
        {
            DgridPublicaciones.Refresh();
            DgridPublicaciones.DataSource = ControlPosts.Listar();
            DgridPublicaciones.Columns["Id_post"].Visible = false;
        }

        private void BtnActualizarPub_Click(object sender, EventArgs e)
        {
            refrescarTablaDeDatos();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }

        private void ControlUsuario_Load(object sender, EventArgs e)
        {
            refrescarTablaDeDatos();
        }
    }
}
