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
    public partial class AdministracionPost : Form
    {
        public AdministracionPost()
        {
            InitializeComponent();
        }

        private void CargarDatosDePublicacion(string idPost)
        {
            TboxPublicacion.Text = ControlPosts.ObtenerPost(idPost)["contenido"];
            //fecha
            //n°reports
            //urlContenido
            //idCuenta
        }
    }
}
