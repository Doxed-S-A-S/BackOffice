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
    public partial class TestingWindow : Form
    {
        public TestingWindow()
        {
            InitializeComponent();
        }

        private void TestingButtonCrearUsr_Click(object sender, EventArgs e)
        {
            ControlCuenta.CrearCuenta(TestingTboxUsername.Text, TestingTboxEmail.Text);
        }

        private void TestingBtnPub_Click(object sender, EventArgs e)
        {
            ControlPosts.CrearPost(TestingTboxPub.Text, TestingTboxReacciones.Text); // agregar id del usr que la crea
        }

        private void TestingBtnPuliComentario_Click(object sender, EventArgs e)
        {
            ControlComentarios.CrearComentario(TestingTboxIdPub.Text, TestingTboxComentario.Text, TestingTboxComReacciones.Text);
        }
    }
}
