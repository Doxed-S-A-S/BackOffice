using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string admin = "admin";
            if (TboxUsrLogin.Text == admin && TboxPassLogin.Text == admin)
            {
                this.Hide();
                var MainInterface = new MainBackoffice();
                MainInterface.Closed += (s, args) => this.Close();
                MainInterface.Show();
            }
            StaticLbErrorMsg.Text = "Credenciales incorrectas (admin en los 2 campos)";
        }
    }
}
