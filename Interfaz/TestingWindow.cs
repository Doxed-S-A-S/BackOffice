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
            ControlPosts.CrearPost(TestingTboxPub.Text,TestingTboxIdUser.Text);
        }

        private void TestingBtnPuliComentario_Click(object sender, EventArgs e)
        {
            ControlComentarios.CrearComentario(TestingTboxIdUserComent.Text,TestingTboxIdPub.Text, TestingTboxComentario.Text);
        }
    }
}