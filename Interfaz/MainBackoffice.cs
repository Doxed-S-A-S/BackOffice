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
            adminGrupo1.Hide();
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
            TboxMostrarContenidoPost.Text = DgridListarPulicaciones.Rows[i].Cells["Contenido"].Value.ToString();
            LbCuentaPostId.Text = DgridListarPulicaciones.Rows[i].Cells["ID de cuenta"].Value.ToString();
        }

        private void refrescarTablaDePublicacionReportada()
        {
            DgridListarPulicaciones.Refresh();
            DgridListarPulicaciones.DataSource = ControlPosts.ListarReportados();
        }


        private int IndexUsuario()
        {
            int i = DgridUsuarios.CurrentCell.RowIndex;
            return i;
        }

        private int IndexPost()
        {
            int i = DgridListarPulicaciones.CurrentCell.RowIndex;
            return i;
        }

        private void refrescarTablaDeUsuarios()
        {
            DgridUsuarios.Refresh();
            DgridUsuarios.DataSource = ControlCuenta.ListarCuentas();
            DgridUsuarios.Columns["ID"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idCuenta = DgridUsuarios.Rows[IndexUsuario()].Cells["ID"].Value.ToString();
            CerrarChildren();
            CerrarPaneles();
            OcultarUserControll();
            AdministracionDeUsuarios.CargarUsuario(idCuenta);
            AdministracionDeUsuarios.Show();
            AdministracionDeUsuarios.BringToFront();
        }


        int mdiX = 500;
        int mdiY = 0;

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            AdministracionPost AdminPost = new AdministracionPost();
            AdminPost.MdiParent = this;
            AdminPost.CargarDatosDePublicacion(DgridListarPulicaciones.Rows[IndexPost()].Cells["ID del post"].Value.ToString());
            AdminPost.Show();
            AdminPost.BringToFront();
            AdminPost.Location = new Point(mdiX, mdiY);
            this.mdiY = mdiY + 20;
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
            DgridBuscarGrupo.Columns["Descripcion"].Visible = false;
            this.DgridBuscarGrupo.Columns["ID del grupo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DgridBuscarGrupo.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void BtnSeleccionarGrupo_Click(object sender, EventArgs e)
        {
            string idGrupo = DgridBuscarGrupo.Rows[IndexGrupo()].Cells["ID del grupo"].Value.ToString();
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
            TboxGrupoDescripcion.Text = DgridBuscarGrupo.Rows[IndexGrupo()].Cells["Descripcion"].Value.ToString();
        }

        private void TboxBuscarGrupo_TextChanged(object sender, EventArgs e)
        {
            (DgridBuscarGrupo.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Nombre] LIKE '{0}%'", TboxBuscarGrupo.Text);
        }

        private void TboxBuscarIdGrupo_TextChanged(object sender, EventArgs e)
        {
            if (TboxBuscarIdGrupo.Text.Length == 0 || int.TryParse(TboxBuscarIdGrupo.Text, out int parse))
            {
                (DgridBuscarGrupo.DataSource as DataTable).DefaultView.RowFilter = string.Format("CONVERT([ID del grupo], 'System.String') LIKE '{0}%'", TboxBuscarIdGrupo.Text);
                LbGrupoIdMensaje.Text = "";
                return;
            }
            LbGrupoIdMensaje.Text = "Solo se permiten numeros sin espacios en este filtro";
            return;
        }

        private void BtnGrupoLimpiarFiltro_Click(object sender, EventArgs e)
        {
            TboxBuscarGrupo.Clear();
            TboxBuscarIdGrupo.Clear();
        }

        private void TboxBuscarIdGrupo_MouseClick(object sender, MouseEventArgs e)
        {
            TboxBuscarGrupo.Clear();
        }

        private void TboxBuscarGrupo_MouseClick(object sender, MouseEventArgs e)
        {
            TboxBuscarIdGrupo.Clear();
        }

        private void BtnBuscarPost_Click(object sender, EventArgs e)
        {
            if(TboxFiltroPublicacion.Text.Length > 0 && int.TryParse(TboxFiltroPublicacion.Text, out int parse))
            {
                LbPostMensaje.Text = "";
                refrescarTablaDePost(TboxFiltroPublicacion.Text);
                return;
            }
            LbPostMensaje.Text = "Solo se permiten numeros sin espacios en este filtro";
            return;
        }

        private void refrescarTablaDePost(string idPost)
        {
            DgridListarPulicaciones.Refresh();
            DgridListarPulicaciones.DataSource = ControlPosts.ListarPostEspecificos(idPost);
            DgridListarPulicaciones.Columns["ID de cuenta"].Visible = false;
            this.DgridListarPulicaciones.Columns["ID del post"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DgridListarPulicaciones.Columns["Contenido"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void BtnMostrarTodosLosPost_Click(object sender, EventArgs e)
        {
            DgridListarPulicaciones.Refresh();
            DgridListarPulicaciones.DataSource = ControlPosts.ListarTodos();
            DgridListarPulicaciones.Columns["ID de cuenta"].Visible = false;
            this.DgridListarPulicaciones.Columns["ID del post"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DgridListarPulicaciones.Columns["Contenido"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
