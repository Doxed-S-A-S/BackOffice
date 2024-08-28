﻿using System;
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
    public partial class AdminUsuario : UserControl
    {
        public AdminUsuario()
        {
            InitializeComponent();
        }

        private void AdminUsuario_Load(object sender, EventArgs e)
        {
            refrescarTablaDePublicaciones();
        }

        public void CargarUsuario(string id)
        {
            if (id != null)
            {
                LbIdUsuario.Text = ControlCuenta.BuscarUsuario(id)["id_usuario"].ToString();
                LbUsername.Text = ControlCuenta.BuscarUsuario(id)["nombre_usuario"].ToString();
                LbNombreCompelto.Text = GenerarNombreCompleto(id);
                // estado
                LbNumReportes.Text = ControlCuenta.BuscarUsuario(id)["reports"].ToString();
                TboxModificarCorreo.Text = ControlCuenta.BuscarUsuario(id)["email"].ToString();
                TboxModificarBiografia.Text = ControlCuenta.BuscarUsuario(id)["biografia"].ToString();
            }
        }

        public string GenerarNombreCompleto(string id)
        {
            string nombreCompleto = ControlCuenta.BuscarUsuario(id)["nombre"].ToString();
            nombreCompleto += " ";
            nombreCompleto += ControlCuenta.BuscarUsuario(id)["apellido1"].ToString();
            nombreCompleto += " ";
            nombreCompleto += ControlCuenta.BuscarUsuario(id)["apellido2"].ToString();

            return nombreCompleto;
        }



        /********************************************Publicaciones***************************************************************/
        private int IndexPublicacion()
        {
            int i = DgridPublicaciones.CurrentCell.RowIndex;
            return i;
        }

        private void refrescarTablaDePublicaciones()
        {
            DgridPublicaciones.Refresh();
            DgridPublicaciones.DataSource = ControlPosts.Listar(LbIdUsuario.Text);
            DgridPublicaciones.Columns["Id_post"].Visible = false;
        }

        private void DgridPublicaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TboxContenido.Text = DgridPublicaciones.Rows[IndexPublicacion()].Cells["Contenido"].Value.ToString();
            refrescarTablaDeComentarios();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string id = DgridPublicaciones.Rows[IndexPublicacion()].Cells["Id_post"].Value.ToString();
            ControlPosts.ModificarPost(id, TboxContenido.Text);
            MessageBox.Show("Se modifico el contenido");
            refrescarTablaDePublicaciones();
        }

        private void BtnEliminarPost_Click(object sender, EventArgs e)
        {
            string id_post = DgridPublicaciones.Rows[IndexPublicacion()].Cells["Id_Post"].Value.ToString();
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

        private void BtnModificarCorreo_Click(object sender, EventArgs e)
        {
            DialogResult seguro = MessageBox.Show(
                $"Esta seguro que desea modificar el Email del usuario {LbUsername.Text}?",
                "Esta seguro?",
                MessageBoxButtons.YesNo);

            if (seguro.ToString()== "Yes")
            {
                ControlCuenta.ModificarCorreo(LbIdUsuario.Text, TboxModificarCorreo.Text);
            }
        }

        /********************************************Comentarios***************************************************************/
        private int IndexComentario()
        {
            int i = DgridComentarios.CurrentCell.RowIndex;
            return i;
        }

        private void refrescarTablaDeComentarios()
        {
            DgridComentarios.Refresh();
            DgridComentarios.DataSource = ControlComentarios.ListarComentarios(DgridPublicaciones.Rows[IndexPublicacion()].Cells["Id_post"].Value.ToString());
            DgridComentarios.Columns["IdComentario"].Visible = false;
            DgridComentarios.Columns["idPost"].Visible = false;
        }


        private void DgridComentarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TboxComentarios.Text = DgridComentarios.Rows[IndexComentario()].Cells["Comentario"].Value.ToString();
        }

        private void BtnEditarComentario_Click(object sender, EventArgs e)
        {
            string id = DgridComentarios.Rows[IndexComentario()].Cells["IdComentario"].Value.ToString();
            ControlComentarios.ModificarComentario(id, TboxComentarios.Text);
            MessageBox.Show("Se modifico el comentario");
            refrescarTablaDeComentarios();
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
                refrescarTablaDeComentarios();
                MessageBox.Show("Comentario eliminado");
            }
        }

        private void BtnActualizarDatosCuenta_Click(object sender, EventArgs e)
        {
            refrescarTablaDePublicaciones();
            DgridComentarios.Refresh();
            refrescarTablaDeComentarios();
        }

        private void BtnEliminarCuenta_Click(object sender, EventArgs e)
        {
            if(TboxVerificarUsername.Text.Length == 0)
            {
                MessageBox.Show("Introduzca debajo del boton el nombre de usuario para verificar");
                TboxVerificarUsername.Show();
                return;
            }

            DialogResult resultado = MessageBox.Show(
                $"Esta seguro que quiere eliminar el usuario {LbUsername.Text}?",
                "Esta seguro?",
                MessageBoxButtons.YesNo);
                
            if (resultado.ToString() == "Yes")
            {
                ControlCuenta.EliminarCuenta(LbIdUsuario.Text,TboxVerificarUsername.Text);
                refrescarTablaDeComentarios();
                MessageBox.Show("Comentario eliminado");
            }
            TboxVerificarUsername.Hide();
        }
    }
}
