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
            controlUsuario1.Show();
            controlUsuario1.BringToFront();
        }

        private void TestingBtnPub_Click(object sender, EventArgs e)
        {
            ControlPosts.CrearPost(TestingTboxPub.Text, TestingTboxReacciones.Text);

        }

        private void TestingBtnPuliComentario_Click(object sender, EventArgs e)
        {
            ControlComentarios.CrearComentario(TestingTboxIdPub.Text, TestingTboxComentario.Text, TestingTboxComReacciones.Text);
        }
    }
}
