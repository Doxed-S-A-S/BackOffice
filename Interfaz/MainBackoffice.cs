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
            BusquedaDeUsuarios.Hide();
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
            BusquedaDeUsuarios.Show();
            BusquedaDeUsuarios.BringToFront();
            
        }

        private void MainBackoffice_Load(object sender, EventArgs e)
        {

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
            AdministracionPost AdminPost = new AdministracionPost();
            AdminPost.MdiParent = this;
            AdminPost.Show();
        }

        private void TestingBtnCerrar_Click(object sender, EventArgs e)
        {
            OcultarUserControll();
            CerrarChildren();
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
    }
}
