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
    public partial class AdminGrupo : UserControl
    {
        public AdminGrupo()
        {
            InitializeComponent();
        }

        private void AdminGrupo_Load(object sender, EventArgs e)
        {

        }

        public void CargarGrupo(string id)
        {
            if (id != null)
            {
                LbIdGrupo.Text = ControlGrupo.BuscarGrupo(id)["id"].ToString();
                LbNombreGrupo.Text = ControlGrupo.BuscarGrupo(id)["nombre_grupo"];
                TboxModificarDescripcion.Text = ControlGrupo.BuscarGrupo(id)["descripcion"];
                LbNumReportes.Text = ControlGrupo.BuscarGrupo(id)["reports"];
                // privado
            }
        }
        private void refrescarTablaDePublicacionesGrupo()
        {
            DgridPublicaciones.Refresh();
            DgridPublicaciones.DataSource = ControlGrupo.PostDeGrupo(LbIdGrupo.Text);
        }

        // tabla de comentarios por grupo
        private void refrescarTablaDeIntegrantes()
        {
            DgridUsuariosDeGrupo.Refresh();
            DgridUsuariosDeGrupo.DataSource = ControlGrupo.ObtenerIntegrantesDeGrupo(LbIdGrupo.Text);
        }
        private void refrescarTablaDeResponsables()
        {
            DgridResponsables.Refresh();
            DgridResponsables.DataSource = ControlGrupo.ObtenerResponsablesDeGrupo(LbIdGrupo.Text);
        }
    }
}
