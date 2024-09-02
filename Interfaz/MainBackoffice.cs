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
    public partial class MainBackoffice : Form
    {
        public MainBackoffice()
        {
            InitializeComponent();
        }

        private void OcultarUserControll()
        {

            AdministracionDeUsuarios.Hide();
        }
        private void CerrarChildren()
        {
            while (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }


        private void BtnContUsuarios_Click(object sender, EventArgs e)
        {
            OcultarUserControll();
            AdministracionDeUsuarios.Show();
            AdministracionDeUsuarios.BringToFront();
        }


        private void BtnBusquedaUsuarios_Click(object sender, EventArgs e)
        {
            OcultarUserControll();
            CerrarChildren();
            CerrarPaneles();
            PanelBusquedaUsuario.Show();
            refrescarTablaDeUsuarios();
        }

        private void MainBackoffice_Load(object sender, EventArgs e)
        {

        }

        public void CambioDeVentana()
        {
            OcultarUserControll();
            CerrarChildren();
            AdministracionDeUsuarios.Show();
            AdministracionDeUsuarios.BringToFront();
        }

        private void abrirVentanaDeTestingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestingWindow Twin = new TestingWindow();
            Twin.Show();
            Twin.BringToFront();
        }

        private void BtnBuscarPublicaciones_Click(object sender, EventArgs e)
        {
            OcultarUserControll();
            CerrarPaneles();
            CerrarChildren();
            PanelBusquedaPost.Show();
        }

        private void TestingBtnCerrar_Click(object sender, EventArgs e)
        {
            OcultarUserControll();
            CerrarChildren();
            CerrarPaneles();
        }

        private void CerrarPaneles()
        {
            PanelBusquedaPost.Hide();
            PanelBusquedaUsuario.Hide();
            PanelBusquedaGrupo.Hide();
        }

        private void DgridListarPulicaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int i = DgridListarPulicaciones.CurrentCell.RowIndex;
            string idPost = DgridListarPulicaciones.Rows[i].Cells["Contenido"].Value.ToString();
        }

        private void refrescarTablaDePublicacionReportada()
        {
            DgridListarPulicaciones.Refresh();
            DgridListarPulicaciones.DataSource = ControlPosts.ListarReportados();
        }

        // Busqueda de usuarios

        private int IndexUsuario()
        {
            int i = DgridUsuarios.CurrentCell.RowIndex;
            return i;
        }

        private void refrescarTablaDeUsuarios()
        {
            DgridUsuarios.Refresh();
            DgridUsuarios.DataSource = ControlCuenta.ListarCuentas();
            DgridUsuarios.Columns["id_cuenta"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idCuenta = DgridUsuarios.Rows[IndexUsuario()].Cells["id_cuenta"].Value.ToString();
            CerrarChildren();
            CerrarPaneles();
            OcultarUserControll();
            AdministracionDeUsuarios.CargarUsuario(idCuenta);
            AdministracionDeUsuarios.Show();
            AdministracionDeUsuarios.BringToFront();
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            AdministracionPost AdminPost = new AdministracionPost();
            AdminPost.MdiParent = this;
            AdminPost.Show();
        }

        private void BtnBuscarGrupo_Click(object sender, EventArgs e)
        {
            CerrarChildren();
            CerrarPaneles();
            OcultarUserControll();
            PanelBusquedaGrupo.Show();
            PanelBusquedaGrupo.BringToFront();
            ActualizarListaDeGrupos();
        }

        private void ActualizarListaDeGrupos()
        {
            DgridBuscarGrupo.Refresh();
            DgridBuscarGrupo.DataSource = ControlGrupo.ObtenerGrupos();
        }
        private void BtnSeleccionarGrupo_Click(object sender, EventArgs e)
        {
            string idGrupo = DgridBuscarGrupo.Rows[IndexGrupo()].Cells["id_grupo"].Value.ToString();
            CerrarChildren();
            CerrarPaneles();
            OcultarUserControll();
            adminGrupo1.CargarGrupo(idGrupo);
            adminGrupo1.Show();
            adminGrupo1.BringToFront();
        }
        private int IndexGrupo()
        {
            int i = DgridBuscarGrupo.CurrentCell.RowIndex;
            return i;
        }

        private void DgridBuscarGrupo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TboxGrupoDescripcion.Text = DgridBuscarGrupo.Rows[IndexGrupo()].Cells["descripcion"].Value.ToString();
        }
    }
}
