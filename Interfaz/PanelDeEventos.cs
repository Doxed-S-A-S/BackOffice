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
                LbIdGrupo.Text = idGrupo;
            }
        }

        private int IndexEvento()
        {
            int i = DgridEventosGrupo.CurrentCell.RowIndex;
            return i;
        }

        private void refrescarTablaDeEventosDelGrupo(string idGrupo)
        {
            DgridEventosGrupo.Refresh();
            DgridEventosGrupo.DataSource = ControlPosts.ListarEventosDeGrupo(idGrupo);
            DgridEventosGrupo.Columns["Id_Post"].Visible = false;
            DgridEventosGrupo.Columns["Id_Evento"].Visible = false;
            DgridEventosGrupo.Columns["Url multimedia"].Visible = false;
            DgridEventosGrupo.Columns["Url de la imagen"].Visible = false;
            DgridEventosGrupo.Columns["Descripcion del evento"].Visible = false;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string imagenUrl = "urlTest";

            if (ChBoxEliminarImg.Checked == true)
                imagenUrl = "null";


            DialogResult resultado = MessageBox.Show(
               $"Esta seguro que quiere modificar el contenido de este evento?",
               "Esta seguro?",
               MessageBoxButtons.YesNo);

            if (resultado.ToString() == "Yes")
            {
                ControlPosts.ModificarEvento(LbEventoPostId.Text, LbEventoId.Text, TboxEventoMultimedia.Text, TboxEventoContenido.Text,
TboxEventoNombre.Text, imagenUrl, TboxEventoDescripcion.Text, LbEventoUsuarioCreador.Text);
                refrescarTablaDeEventosDelGrupo(LbIdGrupo.Text);
                MessageBox.Show("Evento modificado");
            }



        }

        private void DgridEventosGrupo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LbEventoPostId.Text = DgridEventosGrupo.Rows[IndexEvento()].Cells["Id_Post"].Value.ToString();
            LbEventoId.Text = DgridEventosGrupo.Rows[IndexEvento()].Cells["Id_Evento"].Value.ToString();
            TboxEventoMultimedia.Text = DgridEventosGrupo.Rows[IndexEvento()].Cells["Url multimedia"].Value.ToString();
            TboxEventoContenido.Text = DgridEventosGrupo.Rows[IndexEvento()].Cells["Contenido"].Value.ToString();
            TboxEventoNombre.Text = DgridEventosGrupo.Rows[IndexEvento()].Cells["Nombre del evento"].Value.ToString();
            // url imagen ( Url de la imagen )
            TboxEventoDescripcion.Text = DgridEventosGrupo.Rows[IndexEvento()].Cells["Descripcion del evento"].Value.ToString();
            LbEventoPostId.Text = DgridEventosGrupo.Rows[IndexEvento()].Cells["Id_Post"].Value.ToString();

        }
    }
}
