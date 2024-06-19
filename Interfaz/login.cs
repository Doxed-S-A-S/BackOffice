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
            string ad = "admin";
            if (TboxUsrLogin.Text == ad && TboxPassLogin.Text == ad)
            {
                this.Hide();
                var MBO = new MainBackoffice();
                MBO.Closed += (s, args) => this.Close();
                MBO.Show();

                // añadir boton de enter automatico para login
            }
        }
    }
}
