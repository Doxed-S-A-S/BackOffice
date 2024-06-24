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

        }

        private void ActualizarTablaPost()
        {
            DataTable tabla = ControlPosts.Listar();


            foreach (DataRow row in tabla.Rows)
            {
                LboxPublicaciones.Items.Add($"Id_Post: {row["Id_Post"]}");
                LboxPublicaciones.Items.Add($"Contenido: {row["Contenido"]}");
                LboxPublicaciones.Items.Add($"Reaccion: {row["Reaccion"]}");
                LboxPublicaciones.Items.Add(""); // Add an empty line to separate rows
            }
            /*LboxPublicaciones.Refresh();
            LboxPublicaciones.DataSource = ControlPosts.Listar();*/
        }

        private void BtnActualizarPub_Click(object sender, EventArgs e)
        {
            ActualizarTablaPost();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
