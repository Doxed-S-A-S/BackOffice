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

        public void CargarDatosDePublicacion(string idPost)
        {
            TboxPublicacion.Text = ControlPosts.ObtenerPost(idPost)["contenido"];
            LbFechaDePost.Text = ControlPosts.ObtenerPost(idPost)["fecha"];
            LbIdPost.Text = ControlPosts.ObtenerPost(idPost)["id Post"];
            LbNumeroDeReports.Text = ControlPosts.ObtenerPost(idPost)["reports"];
            LbUserId.Text = ControlPosts.ObtenerPost(idPost)["id_cuenta"];
            TboxUrlMultimedia.Text = ControlPosts.ObtenerPost(idPost)["url_contenido"];
            RefrescarDgridComentariosAdminPost();
        }

        private void RefrescarDgridComentariosAdminPost()
        {
            DgridComentarios.Refresh();
            DgridComentarios.DataSource = ControlComentarios.ListarComentarios(LbIdPost.Text);
            DgridComentarios.Columns["IdComentario"].Visible = false;
            DgridComentarios.Columns["idPost"].Visible = false;
        }

        private int IndexComentario()
        {
            int i = DgridComentarios.CurrentCell.RowIndex;
            return i;
        }

        private void DgridComentarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TboxComentarios.Text = DgridComentarios.Rows[IndexComentario()].Cells["Comentario"].Value.ToString();
        }


    }
}
