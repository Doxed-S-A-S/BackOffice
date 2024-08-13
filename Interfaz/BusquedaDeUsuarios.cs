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
    public partial class BusquedaDeUsuarios : UserControl
    {
        public BusquedaDeUsuarios()
        {
            InitializeComponent();
        }

        private void BusquedaDeUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void refrescarTablaDeUsuarios()
        {
            DgridUsuarios.Refresh();
            DgridUsuarios.DataSource = ControlCuenta.ListarCuentas();
            DgridUsuarios.Columns["id_cuenta"].Visible = false;
        }
    }
}
