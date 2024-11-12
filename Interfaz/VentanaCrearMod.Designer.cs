
namespace Interfaz
{
    partial class VentanaCrearMod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TboxNombreMod = new System.Windows.Forms.TextBox();
            this.TboxPassMod = new System.Windows.Forms.TextBox();
            this.ChBoxSuperMod = new System.Windows.Forms.CheckBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnCrearMod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelEliminarMod = new System.Windows.Forms.FlowLayoutPanel();
            this.DgridModeradores = new System.Windows.Forms.DataGridView();
            this.BtnEliminarMod = new System.Windows.Forms.Button();
            this.BtnCancelarEliminarMod = new System.Windows.Forms.Button();
            this.PanelEliminarMod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgridModeradores)).BeginInit();
            this.SuspendLayout();
            // 
            // TboxNombreMod
            // 
            this.TboxNombreMod.Location = new System.Drawing.Point(12, 56);
            this.TboxNombreMod.Name = "TboxNombreMod";
            this.TboxNombreMod.Size = new System.Drawing.Size(196, 20);
            this.TboxNombreMod.TabIndex = 2;
            // 
            // TboxPassMod
            // 
            this.TboxPassMod.Location = new System.Drawing.Point(12, 105);
            this.TboxPassMod.Name = "TboxPassMod";
            this.TboxPassMod.Size = new System.Drawing.Size(196, 20);
            this.TboxPassMod.TabIndex = 3;
            // 
            // ChBoxSuperMod
            // 
            this.ChBoxSuperMod.AutoSize = true;
            this.ChBoxSuperMod.Location = new System.Drawing.Point(12, 141);
            this.ChBoxSuperMod.Name = "ChBoxSuperMod";
            this.ChBoxSuperMod.Size = new System.Drawing.Size(107, 17);
            this.ChBoxSuperMod.TabIndex = 4;
            this.ChBoxSuperMod.Text = "Super moderador";
            this.ChBoxSuperMod.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Red;
            this.BtnCancelar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCancelar.Location = new System.Drawing.Point(133, 185);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnCrearMod
            // 
            this.BtnCrearMod.Location = new System.Drawing.Point(15, 185);
            this.BtnCrearMod.Name = "BtnCrearMod";
            this.BtnCrearMod.Size = new System.Drawing.Size(75, 23);
            this.BtnCrearMod.TabIndex = 6;
            this.BtnCrearMod.Text = "Crear";
            this.BtnCrearMod.UseVisualStyleBackColor = true;
            this.BtnCrearMod.Click += new System.EventHandler(this.BtnCrearMod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cracion de usuario moderador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contraseña:";
            // 
            // PanelEliminarMod
            // 
            this.PanelEliminarMod.Controls.Add(this.DgridModeradores);
            this.PanelEliminarMod.Controls.Add(this.BtnCancelarEliminarMod);
            this.PanelEliminarMod.Controls.Add(this.BtnEliminarMod);
            this.PanelEliminarMod.Location = new System.Drawing.Point(0, 0);
            this.PanelEliminarMod.Name = "PanelEliminarMod";
            this.PanelEliminarMod.Size = new System.Drawing.Size(220, 217);
            this.PanelEliminarMod.TabIndex = 9;
            this.PanelEliminarMod.Visible = false;
            // 
            // DgridModeradores
            // 
            this.DgridModeradores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DgridModeradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgridModeradores.Location = new System.Drawing.Point(3, 3);
            this.DgridModeradores.Name = "DgridModeradores";
            this.DgridModeradores.ReadOnly = true;
            this.DgridModeradores.Size = new System.Drawing.Size(205, 150);
            this.DgridModeradores.TabIndex = 0;
            // 
            // BtnEliminarMod
            // 
            this.BtnEliminarMod.BackColor = System.Drawing.Color.Red;
            this.BtnEliminarMod.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnEliminarMod.Location = new System.Drawing.Point(3, 188);
            this.BtnEliminarMod.Name = "BtnEliminarMod";
            this.BtnEliminarMod.Size = new System.Drawing.Size(205, 23);
            this.BtnEliminarMod.TabIndex = 1;
            this.BtnEliminarMod.Text = "Eliminar moderador seleccionado";
            this.BtnEliminarMod.UseVisualStyleBackColor = false;
            this.BtnEliminarMod.Click += new System.EventHandler(this.BtnEliminarMod_Click);
            // 
            // BtnCancelarEliminarMod
            // 
            this.BtnCancelarEliminarMod.Location = new System.Drawing.Point(3, 159);
            this.BtnCancelarEliminarMod.Name = "BtnCancelarEliminarMod";
            this.BtnCancelarEliminarMod.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelarEliminarMod.TabIndex = 2;
            this.BtnCancelarEliminarMod.Text = "Cancelar";
            this.BtnCancelarEliminarMod.UseVisualStyleBackColor = true;
            this.BtnCancelarEliminarMod.Click += new System.EventHandler(this.BtnCancelarEliminarMod_Click);
            // 
            // VentanaCrearMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 220);
            this.Controls.Add(this.PanelEliminarMod);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCrearMod);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.ChBoxSuperMod);
            this.Controls.Add(this.TboxPassMod);
            this.Controls.Add(this.TboxNombreMod);
            this.Controls.Add(this.label1);
            this.Name = "VentanaCrearMod";
            this.Text = "VentanaCrearMod";
            this.PanelEliminarMod.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgridModeradores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TboxNombreMod;
        private System.Windows.Forms.TextBox TboxPassMod;
        private System.Windows.Forms.CheckBox ChBoxSuperMod;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnCrearMod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel PanelEliminarMod;
        private System.Windows.Forms.DataGridView DgridModeradores;
        private System.Windows.Forms.Button BtnEliminarMod;
        private System.Windows.Forms.Button BtnCancelarEliminarMod;
    }
}