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
            ControlCuenta.CrearCuenta(TestingTboxUsername.Text, TestingTboxEmail.Text, TestingTboxContraseña.Text);
            DialogResult Hecho = MessageBox.Show(
    $"Usuario creado, quiere limipar las cajas de texto?",
    "",
    MessageBoxButtons.YesNo);

            if (Hecho.ToString() == "Yes")
            {
                TestingTboxUsername.Clear();
                TestingTboxEmail.Clear();
                TestingTboxContraseña.Clear();
            }
        }

        private void TestingBtnPub_Click(object sender, EventArgs e)
        {
            ControlPosts.CrearPost(TestingTboxPub.Text,TestingTboxIdUser.Text);
        }

        private void TestingBtnPuliComentario_Click(object sender, EventArgs e)
        {
            ControlComentarios.CrearComentario(TestingTboxIdUserComent.Text,TestingTboxIdPub.Text, TestingTboxComentario.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TestingBtnCrearGrupo_Click(object sender, EventArgs e)
        {
            string banner = "Banner";
            ControlGrupo.CrearGrupo(TestingTboxAddUserID.Text,TestingTboxNombreGrupo.Text,TestingTboxDescripcion.Text,TestingChBoxGrupoPrivado.Checked.ToString(),banner);
        }

        private void TestingBtnAgregarGrupo_Click(object sender, EventArgs e)
        {
            ControlGrupo.AgregarCuentaEnGrupo(TestingComboBxRolGrupo.ToString(),TestingTboxAddGrupoID.Text, TestingTboxAddUserID.Text);
        }
    }
}
