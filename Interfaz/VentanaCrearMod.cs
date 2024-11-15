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
    public partial class VentanaCrearMod : Form
    {
        public VentanaCrearMod()
        {
            InitializeComponent();
        }

        private void BtnCrearMod_Click(object sender, EventArgs e)
        {
            try
            {
                bool resultado = ControlCuenta.CrearModerador(TboxNombreMod.Text, TboxPassMod.Text, ChBoxSuperMod.Checked.ToString());
                if (resultado)
                {
                    MessageBox.Show("Moderador creado");
                    this.Close();
                }

                if (!resultado)
                    MessageBox.Show("Error, verifique los datos");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void refrescarTablaMods()
        {
            DgridModeradores.Refresh();
            DgridModeradores.DataSource = ControlCuenta.ListarMods();
            PanelEliminarMod.Visible = true;
            this.DgridModeradores.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void BtnCancelarEliminarMod_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEliminarMod_Click(object sender, EventArgs e)
        {
            try
            {
                string user = DgridModeradores.Rows[DgridModeradores.CurrentCell.RowIndex].Cells["nombre"].Value.ToString();
                DialogResult resultado = MessageBox.Show(
                    $"Esta seguro que quiere eliminar el moderador {user}?",
                    "Esta seguro?",
                    MessageBoxButtons.YesNo);

                if (resultado.ToString() == "Yes")
                {
                    ControlCuenta.EliminarMod(user);
                    MessageBox.Show("Moderador eliminado");
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
