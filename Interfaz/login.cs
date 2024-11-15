using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Interfaz
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Dictionary<string,string> resultado = (ControlCuenta.AutenticarMod(TboxUsrLogin.Text, TboxPassLogin.Text));


            if (resultado["resultado"] == "true")
            {
                this.Hide();
                var MainInterface = new MainBackoffice();
                MainInterface.TipoUsuario(resultado["super"]);
                MainInterface.Closed += (s, args) => this.Close();
                MainInterface.Show();
            }
            StaticLbErrorMsg.Text = "Credenciales incorrectas verifique";
        }

        private void login_Load(object sender, EventArgs e)
        {
            MakeCircularPictureBox(PboxLogin);
        }

        public void MakeCircularPictureBox(PictureBox pictureBox2)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, pictureBox2.Width, pictureBox2.Height);
            pictureBox2.Region = new Region(path);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
