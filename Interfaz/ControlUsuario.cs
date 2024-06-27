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
            string id_post = DgridPublicaciones.SelectedRows[0].Cells["Id_Post"].Value.ToString();
            DialogResult resultado = MessageBox.Show(
                $"Esta seguro que quiere eliminar el post {id_post}?",
                "Esta seguro?",
                MessageBoxButtons.YesNo);

            if (resultado.ToString() == "Yes")
            {
                ControlPosts.ElimiarPost(id_post);
                refrescarTablaDePublicaciones();
                MessageBox.Show("Post eliminado");
            }
        }

        private void refrescarTablaDePublicaciones()
        {
            DgridPublicaciones.Refresh();
            DgridPublicaciones.DataSource = ControlPosts.Listar();
            DgridPublicaciones.Columns["Id_post"].Visible = false;
        }

        private void refrescarTablaDeComentarios()
        {
            DgridComentarios.Refresh();
            DgridComentarios.DataSource = ControlComentarios.ListarComentarios(DgridPublicaciones.SelectedRows[0].Cells["Id_post"].Value.ToString());
            //DgridComentarios.Columns["Id_post"].Visible = false;
        }

        private void BtnActualizarPub_Click(object sender, EventArgs e)
        {
            refrescarTablaDePublicaciones();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string id = DgridPublicaciones.SelectedRows[0].Cells["Id_post"].Value.ToString();
            ControlPosts.ModificarPost(id, TboxContenido.Text);
            MessageBox.Show("Se modifico el contenido");
            refrescarTablaDePublicaciones();
        }

        private void DgridPublicaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TboxContenido.Text = DgridPublicaciones.SelectedRows[0].Cells["Contenido"].Value.ToString();
        }

        private void BtnEditarComentario_Click(object sender, EventArgs e)
        {
            string id = DgridComentarios.SelectedRows[0].Cells["IdComentario"].Value.ToString();
            ControlComentarios.ModificarComentario(id, TboxComentarios.Text);
            MessageBox.Show("Se modifico el comentario");
            refrescarTablaDeComentarios();
        }

        private void BtnActualizarComentarios_Click(object sender, EventArgs e)
        {
            refrescarTablaDeComentarios();
        }

        private void DgridComentarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TboxComentarios.Text = DgridComentarios.SelectedRows[0].Cells["Comentario"].Value.ToString();
        }

        private void BtnEliminarComentario_Click(object sender, EventArgs e)
        {
            string id = DgridComentarios.SelectedRows[0].Cells["IdComentario"].Value.ToString();
            DialogResult resultado = MessageBox.Show(
                $"Esta seguro que quiere eliminar el comentario selecionado?",
                "Esta seguro?",
                MessageBoxButtons.YesNo);

            if (resultado.ToString() == "Yes")
            {
                ControlComentarios.EliminarComentario(id);
                refrescarTablaDeComentarios();
                MessageBox.Show("Comentario eliminado");
            }
        }
    }
}
