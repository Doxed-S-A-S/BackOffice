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

        private void BtnContUsuarios_Click(object sender, EventArgs e)
        {
            BusquedaDeUsuarios.Hide();
            AdministracionDeUsuarios.Show();
            AdministracionDeUsuarios.BringToFront();
        }


        private void BtnBusquedaUsuarios_Click(object sender, EventArgs e)
        {
            AdministracionDeUsuarios.Hide();
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
    }
}
