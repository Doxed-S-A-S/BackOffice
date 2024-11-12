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

        private void BtnEliminarPost_Click(object sender, EventArgs e)
        {
            string id_post = LbIdPost.Text;
            DialogResult resultado = MessageBox.Show(
                $"Esta seguro que quiere eliminar el post {id_post}?",
                "Esta seguro?",
                MessageBoxButtons.YesNo);

            if (resultado.ToString() == "Yes")
            {
                ControlPosts.ElimiarPost(id_post);
                MessageBox.Show("Post eliminado");
            }
            this.Close();
        }

        private void BtnEditarPost_Click(object sender, EventArgs e)
        {
            string id = LbIdPost.Text;
            ControlPosts.ModificarTodoElPost(id, TboxPublicacion.Text,TboxUrlMultimedia.Text);
            MessageBox.Show("Se modifico el contenido");
        }

        private void BtnEditarComentario_Click(object sender, EventArgs e)
        {
            string id = DgridComentarios.Rows[IndexComentario()].Cells["IdComentario"].Value.ToString();
            ControlComentarios.ModificarComentario(id, TboxComentarios.Text);
            MessageBox.Show("Se modifico el comentario");
            RefrescarDgridComentariosAdminPost();
        }

        private void BtnEliminarComentario_Click(object sender, EventArgs e)
        {
            string id = DgridComentarios.Rows[IndexComentario()].Cells["IdComentario"].Value.ToString();
            DialogResult resultado = MessageBox.Show(
                $"Esta seguro que quiere eliminar el comentario selecionado?",
                "Esta seguro?",
                MessageBoxButtons.YesNo);

            if (resultado.ToString() == "Yes")
            {
                ControlComentarios.EliminarComentario(id);
                RefrescarDgridComentariosAdminPost();
                MessageBox.Show("Comentario eliminado");
                TboxComentarios.Clear();
            }
        }
    }
}
