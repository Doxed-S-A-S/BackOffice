
namespace Interfaz
{
    partial class AdminGrupo
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnActualizarDatosCuenta = new System.Windows.Forms.Button();
            this.LbIdGrupo = new System.Windows.Forms.Label();
            this.BtnModificarDatos = new System.Windows.Forms.Button();
            this.TboxModificarDescripcion = new System.Windows.Forms.TextBox();
            this.StaticLbBiografia = new System.Windows.Forms.Label();
            this.LbNumReportes = new System.Windows.Forms.Label();
            this.StaticLbComentarios = new System.Windows.Forms.Label();
            this.BtnEliminarComentario = new System.Windows.Forms.Button();
            this.BtnEditarComentario = new System.Windows.Forms.Button();
            this.TboxComentarios = new System.Windows.Forms.TextBox();
            this.DgridComentarios = new System.Windows.Forms.DataGridView();
            this.DgridPublicaciones = new System.Windows.Forms.DataGridView();
            this.BtnEliminarPost = new System.Windows.Forms.Button();
            this.BtnEditarPost = new System.Windows.Forms.Button();
            this.TboxContenido = new System.Windows.Forms.TextBox();
            this.StaticLbPublicacion = new System.Windows.Forms.Label();
            this.LbGrupoPrivado = new System.Windows.Forms.Label();
            this.StaticLbRolUsr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StaticLbReportes = new System.Windows.Forms.Label();
            this.StaticLbResponsables = new System.Windows.Forms.Label();
            this.StaticLbEstado = new System.Windows.Forms.Label();
            this.StaticLbUsername = new System.Windows.Forms.Label();
            this.StaticLbImgProfile = new System.Windows.Forms.Label();
            this.DgridUsuariosDeGrupo = new System.Windows.Forms.DataGridView();
            this.StaticLbUsuariosGrupo = new System.Windows.Forms.Label();
            this.DgridResponsables = new System.Windows.Forms.DataGridView();
            this.BtnSeleccionarUsuario = new System.Windows.Forms.Button();
            this.TboxVerificarNombreGrupo = new System.Windows.Forms.TextBox();
            this.BtnEliminarGrupo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TboxNombreGrupo = new System.Windows.Forms.TextBox();
            this.LbNombreGrupo = new System.Windows.Forms.Label();
            this.BtnVerEventos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgridComentarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgridPublicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgridUsuariosDeGrupo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgridResponsables)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnActualizarDatosCuenta
            // 
            this.BtnActualizarDatosCuenta.Location = new System.Drawing.Point(54, 612);
            this.BtnActualizarDatosCuenta.Name = "BtnActualizarDatosCuenta";
            this.BtnActualizarDatosCuenta.Size = new System.Drawing.Size(117, 33);
            this.BtnActualizarDatosCuenta.TabIndex = 81;
            this.BtnActualizarDatosCuenta.Text = "Actualizar datos";
            this.BtnActualizarDatosCuenta.UseVisualStyleBackColor = true;
            // 
            // LbIdGrupo
            // 
            this.LbIdGrupo.AutoSize = true;
            this.LbIdGrupo.Location = new System.Drawing.Point(13, 0);
            this.LbIdGrupo.Name = "LbIdGrupo";
            this.LbIdGrupo.Size = new System.Drawing.Size(13, 13);
            this.LbIdGrupo.TabIndex = 80;
            this.LbIdGrupo.Text = "0";
            // 
            // BtnModificarDatos
            // 
            this.BtnModificarDatos.Location = new System.Drawing.Point(16, 413);
            this.BtnModificarDatos.Name = "BtnModificarDatos";
            this.BtnModificarDatos.Size = new System.Drawing.Size(201, 23);
            this.BtnModificarDatos.TabIndex = 78;
            this.BtnModificarDatos.Text = "Modificar datos del grupo";
            this.BtnModificarDatos.UseVisualStyleBackColor = true;
            this.BtnModificarDatos.Click += new System.EventHandler(this.BtnModificarDescripcion_Click);
            // 
            // TboxModificarDescripcion
            // 
            this.TboxModificarDescripcion.Location = new System.Drawing.Point(16, 256);
            this.TboxModificarDescripcion.Multiline = true;
            this.TboxModificarDescripcion.Name = "TboxModificarDescripcion";
            this.TboxModificarDescripcion.Size = new System.Drawing.Size(201, 151);
            this.TboxModificarDescripcion.TabIndex = 77;
            // 
            // StaticLbBiografia
            // 
            this.StaticLbBiografia.AutoSize = true;
            this.StaticLbBiografia.Location = new System.Drawing.Point(13, 240);
            this.StaticLbBiografia.Name = "StaticLbBiografia";
            this.StaticLbBiografia.Size = new System.Drawing.Size(66, 13);
            this.StaticLbBiografia.TabIndex = 76;
            this.StaticLbBiografia.Text = "Descripcion:";
            // 
            // LbNumReportes
            // 
            this.LbNumReportes.AutoSize = true;
            this.LbNumReportes.Location = new System.Drawing.Point(70, 218);
            this.LbNumReportes.Name = "LbNumReportes";
            this.LbNumReportes.Size = new System.Drawing.Size(100, 13);
            this.LbNumReportes.TabIndex = 72;
            this.LbNumReportes.Text = "Numero de reportes";
            // 
            // StaticLbComentarios
            // 
            this.StaticLbComentarios.AutoSize = true;
            this.StaticLbComentarios.Location = new System.Drawing.Point(238, 443);
            this.StaticLbComentarios.Name = "StaticLbComentarios";
            this.StaticLbComentarios.Size = new System.Drawing.Size(174, 13);
            this.StaticLbComentarios.TabIndex = 71;
            this.StaticLbComentarios.Text = "Comentarios del post seleccionado:";
            // 
            // BtnEliminarComentario
            // 
            this.BtnEliminarComentario.BackColor = System.Drawing.Color.Red;
            this.BtnEliminarComentario.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnEliminarComentario.Location = new System.Drawing.Point(704, 597);
            this.BtnEliminarComentario.Name = "BtnEliminarComentario";
            this.BtnEliminarComentario.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminarComentario.TabIndex = 70;
            this.BtnEliminarComentario.Text = "Eliminar";
            this.BtnEliminarComentario.UseVisualStyleBackColor = false;
            this.BtnEliminarComentario.Click += new System.EventHandler(this.BtnEliminarComentario_Click);
            // 
            // BtnEditarComentario
            // 
            this.BtnEditarComentario.Location = new System.Drawing.Point(610, 597);
            this.BtnEditarComentario.Name = "BtnEditarComentario";
            this.BtnEditarComentario.Size = new System.Drawing.Size(75, 23);
            this.BtnEditarComentario.TabIndex = 69;
            this.BtnEditarComentario.Text = "Editar";
            this.BtnEditarComentario.UseVisualStyleBackColor = true;
            this.BtnEditarComentario.Click += new System.EventHandler(this.BtnEditarComentario_Click);
            // 
            // TboxComentarios
            // 
            this.TboxComentarios.Location = new System.Drawing.Point(610, 479);
            this.TboxComentarios.Multiline = true;
            this.TboxComentarios.Name = "TboxComentarios";
            this.TboxComentarios.Size = new System.Drawing.Size(169, 112);
            this.TboxComentarios.TabIndex = 68;
            // 
            // DgridComentarios
            // 
            this.DgridComentarios.AllowUserToAddRows = false;
            this.DgridComentarios.AllowUserToDeleteRows = false;
            this.DgridComentarios.AllowUserToResizeColumns = false;
            this.DgridComentarios.AllowUserToResizeRows = false;
            this.DgridComentarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgridComentarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgridComentarios.Location = new System.Drawing.Point(241, 459);
            this.DgridComentarios.Name = "DgridComentarios";
            this.DgridComentarios.ReadOnly = true;
            this.DgridComentarios.Size = new System.Drawing.Size(363, 186);
            this.DgridComentarios.TabIndex = 67;
            this.DgridComentarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgridComentarios_CellClick);
            // 
            // DgridPublicaciones
            // 
            this.DgridPublicaciones.AllowUserToAddRows = false;
            this.DgridPublicaciones.AllowUserToDeleteRows = false;
            this.DgridPublicaciones.AllowUserToResizeColumns = false;
            this.DgridPublicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgridPublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgridPublicaciones.Location = new System.Drawing.Point(241, 30);
            this.DgridPublicaciones.MultiSelect = false;
            this.DgridPublicaciones.Name = "DgridPublicaciones";
            this.DgridPublicaciones.ReadOnly = true;
            this.DgridPublicaciones.Size = new System.Drawing.Size(363, 391);
            this.DgridPublicaciones.TabIndex = 66;
            this.DgridPublicaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgridPublicaciones_CellClick);
            // 
            // BtnEliminarPost
            // 
            this.BtnEliminarPost.BackColor = System.Drawing.Color.Red;
            this.BtnEliminarPost.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnEliminarPost.Location = new System.Drawing.Point(704, 167);
            this.BtnEliminarPost.Name = "BtnEliminarPost";
            this.BtnEliminarPost.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminarPost.TabIndex = 65;
            this.BtnEliminarPost.Text = "Eliminar";
            this.BtnEliminarPost.UseVisualStyleBackColor = false;
            this.BtnEliminarPost.Click += new System.EventHandler(this.BtnEliminarPost_Click);
            // 
            // BtnEditarPost
            // 
            this.BtnEditarPost.Location = new System.Drawing.Point(610, 167);
            this.BtnEditarPost.Name = "BtnEditarPost";
            this.BtnEditarPost.Size = new System.Drawing.Size(75, 23);
            this.BtnEditarPost.TabIndex = 64;
            this.BtnEditarPost.Text = "Editar";
            this.BtnEditarPost.UseVisualStyleBackColor = true;
            this.BtnEditarPost.Click += new System.EventHandler(this.BtnEditarPost_Click);
            // 
            // TboxContenido
            // 
            this.TboxContenido.Location = new System.Drawing.Point(610, 49);
            this.TboxContenido.Multiline = true;
            this.TboxContenido.Name = "TboxContenido";
            this.TboxContenido.Size = new System.Drawing.Size(169, 112);
            this.TboxContenido.TabIndex = 63;
            // 
            // StaticLbPublicacion
            // 
            this.StaticLbPublicacion.AutoSize = true;
            this.StaticLbPublicacion.Location = new System.Drawing.Point(238, 11);
            this.StaticLbPublicacion.Name = "StaticLbPublicacion";
            this.StaticLbPublicacion.Size = new System.Drawing.Size(76, 13);
            this.StaticLbPublicacion.TabIndex = 62;
            this.StaticLbPublicacion.Text = "Publicaciones:";
            // 
            // LbGrupoPrivado
            // 
            this.LbGrupoPrivado.AutoSize = true;
            this.LbGrupoPrivado.Location = new System.Drawing.Point(70, 203);
            this.LbGrupoPrivado.Name = "LbGrupoPrivado";
            this.LbGrupoPrivado.Size = new System.Drawing.Size(81, 13);
            this.LbGrupoPrivado.TabIndex = 61;
            this.LbGrupoPrivado.Text = "Abierto/Privado";
            // 
            // StaticLbRolUsr
            // 
            this.StaticLbRolUsr.AutoSize = true;
            this.StaticLbRolUsr.Location = new System.Drawing.Point(13, 203);
            this.StaticLbRolUsr.Name = "StaticLbRolUsr";
            this.StaticLbRolUsr.Size = new System.Drawing.Size(60, 13);
            this.StaticLbRolUsr.TabIndex = 60;
            this.StaticLbRolUsr.Text = "Privacidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Activo/Bloqueado";
            // 
            // StaticLbReportes
            // 
            this.StaticLbReportes.AutoSize = true;
            this.StaticLbReportes.Location = new System.Drawing.Point(13, 218);
            this.StaticLbReportes.Name = "StaticLbReportes";
            this.StaticLbReportes.Size = new System.Drawing.Size(53, 13);
            this.StaticLbReportes.TabIndex = 56;
            this.StaticLbReportes.Text = "Reportes:";
            // 
            // StaticLbResponsables
            // 
            this.StaticLbResponsables.AutoSize = true;
            this.StaticLbResponsables.Location = new System.Drawing.Point(17, 443);
            this.StaticLbResponsables.Name = "StaticLbResponsables";
            this.StaticLbResponsables.Size = new System.Drawing.Size(124, 13);
            this.StaticLbResponsables.TabIndex = 55;
            this.StaticLbResponsables.Text = "Responsables del grupo:";
            // 
            // StaticLbEstado
            // 
            this.StaticLbEstado.AutoSize = true;
            this.StaticLbEstado.Location = new System.Drawing.Point(13, 187);
            this.StaticLbEstado.Name = "StaticLbEstado";
            this.StaticLbEstado.Size = new System.Drawing.Size(43, 13);
            this.StaticLbEstado.TabIndex = 54;
            this.StaticLbEstado.Text = "Estado:";
            // 
            // StaticLbUsername
            // 
            this.StaticLbUsername.AutoSize = true;
            this.StaticLbUsername.Location = new System.Drawing.Point(13, 164);
            this.StaticLbUsername.Name = "StaticLbUsername";
            this.StaticLbUsername.Size = new System.Drawing.Size(39, 13);
            this.StaticLbUsername.TabIndex = 53;
            this.StaticLbUsername.Text = "Grupo:";
            // 
            // StaticLbImgProfile
            // 
            this.StaticLbImgProfile.AutoSize = true;
            this.StaticLbImgProfile.Location = new System.Drawing.Point(62, 74);
            this.StaticLbImgProfile.Name = "StaticLbImgProfile";
            this.StaticLbImgProfile.Size = new System.Drawing.Size(93, 13);
            this.StaticLbImgProfile.TabIndex = 52;
            this.StaticLbImgProfile.Text = "( imagen de perfil )";
            // 
            // DgridUsuariosDeGrupo
            // 
            this.DgridUsuariosDeGrupo.AllowUserToAddRows = false;
            this.DgridUsuariosDeGrupo.AllowUserToDeleteRows = false;
            this.DgridUsuariosDeGrupo.AllowUserToResizeColumns = false;
            this.DgridUsuariosDeGrupo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgridUsuariosDeGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgridUsuariosDeGrupo.Location = new System.Drawing.Point(787, 30);
            this.DgridUsuariosDeGrupo.MultiSelect = false;
            this.DgridUsuariosDeGrupo.Name = "DgridUsuariosDeGrupo";
            this.DgridUsuariosDeGrupo.ReadOnly = true;
            this.DgridUsuariosDeGrupo.Size = new System.Drawing.Size(257, 391);
            this.DgridUsuariosDeGrupo.TabIndex = 82;
            this.DgridUsuariosDeGrupo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgridUsuariosDeGrupo_CellClick);
            // 
            // StaticLbUsuariosGrupo
            // 
            this.StaticLbUsuariosGrupo.AutoSize = true;
            this.StaticLbUsuariosGrupo.Location = new System.Drawing.Point(784, 14);
            this.StaticLbUsuariosGrupo.Name = "StaticLbUsuariosGrupo";
            this.StaticLbUsuariosGrupo.Size = new System.Drawing.Size(119, 13);
            this.StaticLbUsuariosGrupo.TabIndex = 83;
            this.StaticLbUsuariosGrupo.Text = "Usuarios en este grupo:";
            // 
            // DgridResponsables
            // 
            this.DgridResponsables.AllowUserToAddRows = false;
            this.DgridResponsables.AllowUserToDeleteRows = false;
            this.DgridResponsables.AllowUserToResizeColumns = false;
            this.DgridResponsables.AllowUserToResizeRows = false;
            this.DgridResponsables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgridResponsables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgridResponsables.Location = new System.Drawing.Point(16, 462);
            this.DgridResponsables.Name = "DgridResponsables";
            this.DgridResponsables.ReadOnly = true;
            this.DgridResponsables.Size = new System.Drawing.Size(201, 144);
            this.DgridResponsables.TabIndex = 84;
            this.DgridResponsables.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgridResponsables_CellClick);
            // 
            // BtnSeleccionarUsuario
            // 
            this.BtnSeleccionarUsuario.Location = new System.Drawing.Point(1050, 30);
            this.BtnSeleccionarUsuario.Name = "BtnSeleccionarUsuario";
            this.BtnSeleccionarUsuario.Size = new System.Drawing.Size(108, 23);
            this.BtnSeleccionarUsuario.TabIndex = 87;
            this.BtnSeleccionarUsuario.Text = "Seleccionar usuario";
            this.BtnSeleccionarUsuario.UseVisualStyleBackColor = true;
            this.BtnSeleccionarUsuario.Click += new System.EventHandler(this.BtnSeleccionarUsuario_Click);
            // 
            // TboxVerificarNombreGrupo
            // 
            this.TboxVerificarNombreGrupo.Location = new System.Drawing.Point(1050, 625);
            this.TboxVerificarNombreGrupo.Name = "TboxVerificarNombreGrupo";
            this.TboxVerificarNombreGrupo.Size = new System.Drawing.Size(117, 20);
            this.TboxVerificarNombreGrupo.TabIndex = 90;
            this.TboxVerificarNombreGrupo.Visible = false;
            // 
            // BtnEliminarGrupo
            // 
            this.BtnEliminarGrupo.BackColor = System.Drawing.Color.Red;
            this.BtnEliminarGrupo.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarGrupo.Location = new System.Drawing.Point(1050, 586);
            this.BtnEliminarGrupo.Name = "BtnEliminarGrupo";
            this.BtnEliminarGrupo.Size = new System.Drawing.Size(117, 33);
            this.BtnEliminarGrupo.TabIndex = 89;
            this.BtnEliminarGrupo.Text = "Eliminar este grupo";
            this.BtnEliminarGrupo.UseVisualStyleBackColor = false;
            this.BtnEliminarGrupo.Click += new System.EventHandler(this.BtnEliminarGrupo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 91;
            this.label1.Text = "Editar publicacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(610, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "Editar comentario:";
            // 
            // TboxNombreGrupo
            // 
            this.TboxNombreGrupo.Location = new System.Drawing.Point(73, 161);
            this.TboxNombreGrupo.Name = "TboxNombreGrupo";
            this.TboxNombreGrupo.Size = new System.Drawing.Size(144, 20);
            this.TboxNombreGrupo.TabIndex = 93;
            // 
            // LbNombreGrupo
            // 
            this.LbNombreGrupo.AutoSize = true;
            this.LbNombreGrupo.Location = new System.Drawing.Point(32, 0);
            this.LbNombreGrupo.Name = "LbNombreGrupo";
            this.LbNombreGrupo.Size = new System.Drawing.Size(0, 13);
            this.LbNombreGrupo.TabIndex = 94;
            this.LbNombreGrupo.Visible = false;
            // 
            // BtnVerEventos
            // 
            this.BtnVerEventos.Location = new System.Drawing.Point(864, 506);
            this.BtnVerEventos.Name = "BtnVerEventos";
            this.BtnVerEventos.Size = new System.Drawing.Size(116, 48);
            this.BtnVerEventos.TabIndex = 95;
            this.BtnVerEventos.Text = "Ver eventos del grupo";
            this.BtnVerEventos.UseVisualStyleBackColor = true;
            this.BtnVerEventos.Click += new System.EventHandler(this.BtnVerEventos_Click);
            // 
            // AdminGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnVerEventos);
            this.Controls.Add(this.LbNombreGrupo);
            this.Controls.Add(this.TboxNombreGrupo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TboxVerificarNombreGrupo);
            this.Controls.Add(this.BtnEliminarGrupo);
            this.Controls.Add(this.BtnSeleccionarUsuario);
            this.Controls.Add(this.DgridResponsables);
            this.Controls.Add(this.StaticLbUsuariosGrupo);
            this.Controls.Add(this.DgridUsuariosDeGrupo);
            this.Controls.Add(this.BtnActualizarDatosCuenta);
            this.Controls.Add(this.LbIdGrupo);
            this.Controls.Add(this.BtnModificarDatos);
            this.Controls.Add(this.TboxModificarDescripcion);
            this.Controls.Add(this.StaticLbBiografia);
            this.Controls.Add(this.LbNumReportes);
            this.Controls.Add(this.StaticLbComentarios);
            this.Controls.Add(this.BtnEliminarComentario);
            this.Controls.Add(this.BtnEditarComentario);
            this.Controls.Add(this.TboxComentarios);
            this.Controls.Add(this.DgridComentarios);
            this.Controls.Add(this.DgridPublicaciones);
            this.Controls.Add(this.BtnEliminarPost);
            this.Controls.Add(this.BtnEditarPost);
            this.Controls.Add(this.TboxContenido);
            this.Controls.Add(this.StaticLbPublicacion);
            this.Controls.Add(this.LbGrupoPrivado);
            this.Controls.Add(this.StaticLbRolUsr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StaticLbReportes);
            this.Controls.Add(this.StaticLbResponsables);
            this.Controls.Add(this.StaticLbEstado);
            this.Controls.Add(this.StaticLbUsername);
            this.Controls.Add(this.StaticLbImgProfile);
            this.Name = "AdminGrupo";
            this.Size = new System.Drawing.Size(1206, 648);
            this.Load += new System.EventHandler(this.AdminGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgridComentarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgridPublicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgridUsuariosDeGrupo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgridResponsables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnActualizarDatosCuenta;
        private System.Windows.Forms.Label LbIdGrupo;
        private System.Windows.Forms.Button BtnModificarDatos;
        private System.Windows.Forms.TextBox TboxModificarDescripcion;
        private System.Windows.Forms.Label StaticLbBiografia;
        private System.Windows.Forms.Label LbNumReportes;
        private System.Windows.Forms.Label StaticLbComentarios;
        private System.Windows.Forms.Button BtnEliminarComentario;
        private System.Windows.Forms.Button BtnEditarComentario;
        private System.Windows.Forms.TextBox TboxComentarios;
        private System.Windows.Forms.DataGridView DgridComentarios;
        private System.Windows.Forms.DataGridView DgridPublicaciones;
        private System.Windows.Forms.Button BtnEliminarPost;
        private System.Windows.Forms.Button BtnEditarPost;
        private System.Windows.Forms.TextBox TboxContenido;
        private System.Windows.Forms.Label StaticLbPublicacion;
        private System.Windows.Forms.Label LbGrupoPrivado;
        private System.Windows.Forms.Label StaticLbRolUsr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label StaticLbReportes;
        private System.Windows.Forms.Label StaticLbResponsables;
        private System.Windows.Forms.Label StaticLbEstado;
        private System.Windows.Forms.Label StaticLbUsername;
        private System.Windows.Forms.Label StaticLbImgProfile;
        private System.Windows.Forms.DataGridView DgridUsuariosDeGrupo;
        private System.Windows.Forms.Label StaticLbUsuariosGrupo;
        private System.Windows.Forms.DataGridView DgridResponsables;
        private System.Windows.Forms.Button BtnSeleccionarUsuario;
        private System.Windows.Forms.TextBox TboxVerificarNombreGrupo;
        private System.Windows.Forms.Button BtnEliminarGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TboxNombreGrupo;
        private System.Windows.Forms.Label LbNombreGrupo;
        private System.Windows.Forms.Button BtnVerEventos;
    }
}
