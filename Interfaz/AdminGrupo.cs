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
                RefrescarTodo();
            }
        }

        private void RefrescarTodo()
        {
            refrescarTablaDeIntegrantes();
            refrescarTablaDePublicacionesGrupo();
            refrescarTablaDeResponsables();

        }
        private void refrescarTablaDePublicacionesGrupo()
        {
            DgridPublicaciones.Refresh();
            DgridPublicaciones.DataSource = ControlGrupo.PostDeGrupo(LbIdGrupo.Text);
        }
        private void refrescarTablaDeComentariosGrupo()
        {
            DgridComentarios.Refresh();
            string id = DgridPublicaciones.Rows[IndexPublicacion()].Cells["Id_post"].Value.ToString();
            DgridComentarios.DataSource = ControlComentarios.ListarComentarios(id);
        }
        private void refrescarTablaDeIntegrantes()
        {
            DgridUsuariosDeGrupo.Refresh();
            DgridUsuariosDeGrupo.DataSource = ControlGrupo.ObtenerIntegrantesDeGrupo(LbIdGrupo.Text);
        }
        private void refrescarTablaDeResponsables()
        {
            DgridResponsables.Refresh();
            DgridResponsables.DataSource = ControlGrupo.ObtenerResponsablesDeGrupo(LbIdGrupo.Text);
            DgridResponsables.Columns["id_cuenta"].Visible = false;
        }

        private void BtnModificarDescripcion_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show(
                $"Esta seguro que desea modificar la Descripcion del grupo {LbNombreGrupo.Text}?",
                "Esta seguro?",
                MessageBoxButtons.YesNo);

            if (check.ToString() == "Yes")
            {
                ControlGrupo.ModificarDescripcionGrupo(LbIdGrupo.Text, TboxModificarDescripcion.Text);
            }

            
        }
        private int IndexPublicacion()
        {
            int i = DgridPublicaciones.CurrentCell.RowIndex;
            return i;
        }
        private void DgridPublicaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TboxContenido.Text = DgridPublicaciones.Rows[IndexPublicacion()].Cells["Contenido"].Value.ToString();
            refrescarTablaDeComentariosGrupo();
        }

        private void BtnEditarPost_Click(object sender, EventArgs e)
        {
            string id = DgridPublicaciones.Rows[IndexPublicacion()].Cells["Id_post"].Value.ToString();
            ControlPosts.ModificarPost(id, TboxContenido.Text);
            MessageBox.Show("Se modifico el contenido");
            refrescarTablaDePublicacionesGrupo();
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
                refrescarTablaDePublicacionesGrupo();
                MessageBox.Show("Post eliminado");
            }
        }

        private void BtnEditarComentario_Click(object sender, EventArgs e)
        {
            string id = DgridComentarios.Rows[IndexComentario()].Cells["IdComentario"].Value.ToString();
            ControlComentarios.ModificarComentario(id, TboxComentarios.Text);
            MessageBox.Show("Se modifico el comentario");
            refrescarTablaDeComentariosGrupo();
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
                refrescarTablaDeComentariosGrupo();
                MessageBox.Show("Comentario eliminado");
            }
        }
    }
}
