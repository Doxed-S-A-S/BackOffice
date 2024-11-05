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
    public partial class PanelDeEventos : Form
    {
        public PanelDeEventos()
        {
            InitializeComponent();
        }

        public void CargarEventoDeGrupo(string idGrupo, string nombreDelGrupo)
        {
            if (idGrupo != null)
            {
                refrescarTablaDeEventosDelGrupo(idGrupo);
                LbNombreGrupo.Text = nombreDelGrupo;
            }
        }

        private void refrescarTablaDeEventosDelGrupo(string idGrupo)
        {
            DgridEventosGrupo.Refresh();
            DgridEventosGrupo.DataSource = ControlPosts.ListarEventosDeGrupo(idGrupo);
            DgridEventosGrupo.Columns["Id_Post"].Visible = false;
            DgridEventosGrupo.Columns["Id_Evento"].Visible = false;
        }


    }
}
