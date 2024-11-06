
namespace Interfaz
{
    partial class PanelDeEventos
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
            this.StaticLbEvetnos = new System.Windows.Forms.Label();
            this.DgridEventosGrupo = new System.Windows.Forms.DataGridView();
            this.LbNombreGrupo = new System.Windows.Forms.Label();
            this.TboxEventoNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TboxEventoDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TboxEventoContenido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TboxEventoMultimedia = new System.Windows.Forms.TextBox();
            this.BtnModificadDatosEvento = new System.Windows.Forms.Button();
            this.BtnEliminarEvento = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.LbEventoId = new System.Windows.Forms.Label();
            this.LbEventoPostId = new System.Windows.Forms.Label();
            this.ChBoxEliminarImg = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LbEventoUsuarioCreador = new System.Windows.Forms.Label();
            this.LbIdGrupo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgridEventosGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // StaticLbEvetnos
            // 
            this.StaticLbEvetnos.AutoSize = true;
            this.StaticLbEvetnos.Location = new System.Drawing.Point(12, 9);
            this.StaticLbEvetnos.Name = "StaticLbEvetnos";
            this.StaticLbEvetnos.Size = new System.Drawing.Size(96, 13);
            this.StaticLbEvetnos.TabIndex = 90;
            this.StaticLbEvetnos.Text = "Eventos del grupo:";
            // 
            // DgridEventosGrupo
            // 
            this.DgridEventosGrupo.AllowUserToAddRows = false;
            this.DgridEventosGrupo.AllowUserToDeleteRows = false;
            this.DgridEventosGrupo.AllowUserToResizeColumns = false;
            this.DgridEventosGrupo.AllowUserToResizeRows = false;
            this.DgridEventosGrupo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgridEventosGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgridEventosGrupo.Location = new System.Drawing.Point(12, 25);
            this.DgridEventosGrupo.Name = "DgridEventosGrupo";
            this.DgridEventosGrupo.Size = new System.Drawing.Size(338, 561);
            this.DgridEventosGrupo.TabIndex = 89;
            // 
            // LbNombreGrupo
            // 
            this.LbNombreGrupo.AutoSize = true;
            this.LbNombreGrupo.Location = new System.Drawing.Point(114, 9);
            this.LbNombreGrupo.Name = "LbNombreGrupo";
            this.LbNombreGrupo.Size = new System.Drawing.Size(0, 13);
            this.LbNombreGrupo.TabIndex = 91;
            // 
            // TboxEventoNombre
            // 
            this.TboxEventoNombre.Location = new System.Drawing.Point(356, 121);
            this.TboxEventoNombre.Name = "TboxEventoNombre";
            this.TboxEventoNombre.Size = new System.Drawing.Size(208, 20);
            this.TboxEventoNombre.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "Modificar nombre del evento:";
            // 
            // TboxEventoDescripcion
            // 
            this.TboxEventoDescripcion.Location = new System.Drawing.Point(356, 295);
            this.TboxEventoDescripcion.Multiline = true;
            this.TboxEventoDescripcion.Name = "TboxEventoDescripcion";
            this.TboxEventoDescripcion.Size = new System.Drawing.Size(208, 98);
            this.TboxEventoDescripcion.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 13);
            this.label2.TabIndex = 95;
            this.label2.Text = "Modificar descripcion del evento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "Modificar contenido:";
            // 
            // TboxEventoContenido
            // 
            this.TboxEventoContenido.Location = new System.Drawing.Point(356, 167);
            this.TboxEventoContenido.Multiline = true;
            this.TboxEventoContenido.Name = "TboxEventoContenido";
            this.TboxEventoContenido.Size = new System.Drawing.Size(208, 98);
            this.TboxEventoContenido.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 99;
            this.label4.Text = "Modificar multimedia:";
            // 
            // TboxEventoMultimedia
            // 
            this.TboxEventoMultimedia.Location = new System.Drawing.Point(356, 420);
            this.TboxEventoMultimedia.Name = "TboxEventoMultimedia";
            this.TboxEventoMultimedia.Size = new System.Drawing.Size(208, 20);
            this.TboxEventoMultimedia.TabIndex = 98;
            // 
            // BtnModificadDatosEvento
            // 
            this.BtnModificadDatosEvento.Location = new System.Drawing.Point(356, 563);
            this.BtnModificadDatosEvento.Name = "BtnModificadDatosEvento";
            this.BtnModificadDatosEvento.Size = new System.Drawing.Size(97, 33);
            this.BtnModificadDatosEvento.TabIndex = 101;
            this.BtnModificadDatosEvento.Text = "Modificar datos";
            this.BtnModificadDatosEvento.UseVisualStyleBackColor = true;
            this.BtnModificadDatosEvento.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnEliminarEvento
            // 
            this.BtnEliminarEvento.BackColor = System.Drawing.Color.Red;
            this.BtnEliminarEvento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnEliminarEvento.Location = new System.Drawing.Point(467, 563);
            this.BtnEliminarEvento.Name = "BtnEliminarEvento";
            this.BtnEliminarEvento.Size = new System.Drawing.Size(97, 33);
            this.BtnEliminarEvento.TabIndex = 102;
            this.BtnEliminarEvento.Text = "Eliminar evento";
            this.BtnEliminarEvento.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 103;
            this.label6.Text = "Id del evento:";
            // 
            // LbEventoId
            // 
            this.LbEventoId.AutoSize = true;
            this.LbEventoId.Location = new System.Drawing.Point(447, 25);
            this.LbEventoId.Name = "LbEventoId";
            this.LbEventoId.Size = new System.Drawing.Size(53, 13);
            this.LbEventoId.TabIndex = 104;
            this.LbEventoId.Text = "Id Evento";
            // 
            // LbEventoPostId
            // 
            this.LbEventoPostId.AutoSize = true;
            this.LbEventoPostId.Location = new System.Drawing.Point(447, 49);
            this.LbEventoPostId.Name = "LbEventoPostId";
            this.LbEventoPostId.Size = new System.Drawing.Size(40, 13);
            this.LbEventoPostId.TabIndex = 105;
            this.LbEventoPostId.Text = "Id Post";
            this.LbEventoPostId.Visible = false;
            // 
            // ChBoxEliminarImg
            // 
            this.ChBoxEliminarImg.AutoSize = true;
            this.ChBoxEliminarImg.Location = new System.Drawing.Point(411, 540);
            this.ChBoxEliminarImg.Name = "ChBoxEliminarImg";
            this.ChBoxEliminarImg.Size = new System.Drawing.Size(105, 17);
            this.ChBoxEliminarImg.TabIndex = 106;
            this.ChBoxEliminarImg.Text = "Eliminar imagen?";
            this.ChBoxEliminarImg.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 107;
            this.label5.Text = "Id del post:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 108;
            this.label7.Text = "Id del usuario:";
            // 
            // LbEventoUsuarioCreador
            // 
            this.LbEventoUsuarioCreador.AutoSize = true;
            this.LbEventoUsuarioCreador.Location = new System.Drawing.Point(447, 72);
            this.LbEventoUsuarioCreador.Name = "LbEventoUsuarioCreador";
            this.LbEventoUsuarioCreador.Size = new System.Drawing.Size(53, 13);
            this.LbEventoUsuarioCreador.TabIndex = 109;
            this.LbEventoUsuarioCreador.Text = "Id Cuenta";
            this.LbEventoUsuarioCreador.Visible = false;
            // 
            // LbIdGrupo
            // 
            this.LbIdGrupo.AutoSize = true;
            this.LbIdGrupo.Location = new System.Drawing.Point(516, 9);
            this.LbIdGrupo.Name = "LbIdGrupo";
            this.LbIdGrupo.Size = new System.Drawing.Size(48, 13);
            this.LbIdGrupo.TabIndex = 110;
            this.LbIdGrupo.Text = "Id Grupo";
            this.LbIdGrupo.Visible = false;
            // 
            // PanelDeEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 601);
            this.Controls.Add(this.LbIdGrupo);
            this.Controls.Add(this.LbEventoUsuarioCreador);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ChBoxEliminarImg);
            this.Controls.Add(this.LbEventoPostId);
            this.Controls.Add(this.LbEventoId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnEliminarEvento);
            this.Controls.Add(this.BtnModificadDatosEvento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TboxEventoMultimedia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TboxEventoContenido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TboxEventoDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TboxEventoNombre);
            this.Controls.Add(this.LbNombreGrupo);
            this.Controls.Add(this.StaticLbEvetnos);
            this.Controls.Add(this.DgridEventosGrupo);
            this.Name = "PanelDeEventos";
            this.Text = "PanelDeEventos";
            ((System.ComponentModel.ISupportInitialize)(this.DgridEventosGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StaticLbEvetnos;
        private System.Windows.Forms.DataGridView DgridEventosGrupo;
        private System.Windows.Forms.Label LbNombreGrupo;
        private System.Windows.Forms.TextBox TboxEventoNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TboxEventoDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TboxEventoContenido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TboxEventoMultimedia;
        private System.Windows.Forms.Button BtnModificadDatosEvento;
        private System.Windows.Forms.Button BtnEliminarEvento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LbEventoId;
        private System.Windows.Forms.Label LbEventoPostId;
        private System.Windows.Forms.CheckBox ChBoxEliminarImg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LbEventoUsuarioCreador;
        private System.Windows.Forms.Label LbIdGrupo;
    }
}