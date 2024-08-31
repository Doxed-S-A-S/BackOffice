
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
            this.LbIdUsuario = new System.Windows.Forms.Label();
            this.BtnModificarDescripcion = new System.Windows.Forms.Button();
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
            this.LbNombreGrupo = new System.Windows.Forms.Label();
            this.LboxResponsablesGrupo = new System.Windows.Forms.ListBox();
            this.StaticLbReportes = new System.Windows.Forms.Label();
            this.StaticLbResponsables = new System.Windows.Forms.Label();
            this.StaticLbEstado = new System.Windows.Forms.Label();
            this.StaticLbUsername = new System.Windows.Forms.Label();
            this.StaticLbImgProfile = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StaticLbUsuariosGrupo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgridComentarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgridPublicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // LbIdUsuario
            // 
            this.LbIdUsuario.AutoSize = true;
            this.LbIdUsuario.Location = new System.Drawing.Point(13, 0);
            this.LbIdUsuario.Name = "LbIdUsuario";
            this.LbIdUsuario.Size = new System.Drawing.Size(13, 13);
            this.LbIdUsuario.TabIndex = 80;
            this.LbIdUsuario.Text = "0";
            // 
            // BtnModificarDescripcion
            // 
            this.BtnModificarDescripcion.Location = new System.Drawing.Point(16, 413);
            this.BtnModificarDescripcion.Name = "BtnModificarDescripcion";
            this.BtnModificarDescripcion.Size = new System.Drawing.Size(116, 23);
            this.BtnModificarDescripcion.TabIndex = 78;
            this.BtnModificarDescripcion.Text = "Modificar descripcion";
            this.BtnModificarDescripcion.UseVisualStyleBackColor = true;
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
            this.LbNumReportes.Location = new System.Drawing.Point(70, 210);
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
            this.StaticLbComentarios.Size = new System.Drawing.Size(68, 13);
            this.StaticLbComentarios.TabIndex = 71;
            this.StaticLbComentarios.Text = "Comentarios:";
            // 
            // BtnEliminarComentario
            // 
            this.BtnEliminarComentario.Location = new System.Drawing.Point(704, 577);
            this.BtnEliminarComentario.Name = "BtnEliminarComentario";
            this.BtnEliminarComentario.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminarComentario.TabIndex = 70;
            this.BtnEliminarComentario.Text = "Eliminar";
            this.BtnEliminarComentario.UseVisualStyleBackColor = true;
            // 
            // BtnEditarComentario
            // 
            this.BtnEditarComentario.Location = new System.Drawing.Point(610, 577);
            this.BtnEditarComentario.Name = "BtnEditarComentario";
            this.BtnEditarComentario.Size = new System.Drawing.Size(75, 23);
            this.BtnEditarComentario.TabIndex = 69;
            this.BtnEditarComentario.Text = "Editar";
            this.BtnEditarComentario.UseVisualStyleBackColor = true;
            // 
            // TboxComentarios
            // 
            this.TboxComentarios.Location = new System.Drawing.Point(610, 459);
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
            this.DgridComentarios.Size = new System.Drawing.Size(363, 186);
            this.DgridComentarios.TabIndex = 67;
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
            this.DgridPublicaciones.Size = new System.Drawing.Size(363, 391);
            this.DgridPublicaciones.TabIndex = 66;
            // 
            // BtnEliminarPost
            // 
            this.BtnEliminarPost.Location = new System.Drawing.Point(704, 148);
            this.BtnEliminarPost.Name = "BtnEliminarPost";
            this.BtnEliminarPost.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminarPost.TabIndex = 65;
            this.BtnEliminarPost.Text = "Eliminar";
            this.BtnEliminarPost.UseVisualStyleBackColor = true;
            // 
            // BtnEditarPost
            // 
            this.BtnEditarPost.Location = new System.Drawing.Point(610, 148);
            this.BtnEditarPost.Name = "BtnEditarPost";
            this.BtnEditarPost.Size = new System.Drawing.Size(75, 23);
            this.BtnEditarPost.TabIndex = 64;
            this.BtnEditarPost.Text = "Editar";
            this.BtnEditarPost.UseVisualStyleBackColor = true;
            // 
            // TboxContenido
            // 
            this.TboxContenido.Location = new System.Drawing.Point(610, 30);
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
            this.LbGrupoPrivado.Location = new System.Drawing.Point(70, 195);
            this.LbGrupoPrivado.Name = "LbGrupoPrivado";
            this.LbGrupoPrivado.Size = new System.Drawing.Size(81, 13);
            this.LbGrupoPrivado.TabIndex = 61;
            this.LbGrupoPrivado.Text = "Abierto/Privado";
            // 
            // StaticLbRolUsr
            // 
            this.StaticLbRolUsr.AutoSize = true;
            this.StaticLbRolUsr.Location = new System.Drawing.Point(13, 195);
            this.StaticLbRolUsr.Name = "StaticLbRolUsr";
            this.StaticLbRolUsr.Size = new System.Drawing.Size(60, 13);
            this.StaticLbRolUsr.TabIndex = 60;
            this.StaticLbRolUsr.Text = "Privacidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Activo/Bloqueado";
            // 
            // LbNombreGrupo
            // 
            this.LbNombreGrupo.AutoSize = true;
            this.LbNombreGrupo.Location = new System.Drawing.Point(70, 164);
            this.LbNombreGrupo.Name = "LbNombreGrupo";
            this.LbNombreGrupo.Size = new System.Drawing.Size(49, 13);
            this.LbNombreGrupo.TabIndex = 58;
            this.LbNombreGrupo.Text = "(ejemplo)";
            // 
            // LboxResponsablesGrupo
            // 
            this.LboxResponsablesGrupo.FormattingEnabled = true;
            this.LboxResponsablesGrupo.Location = new System.Drawing.Point(16, 459);
            this.LboxResponsablesGrupo.Name = "LboxResponsablesGrupo";
            this.LboxResponsablesGrupo.Size = new System.Drawing.Size(201, 147);
            this.LboxResponsablesGrupo.TabIndex = 57;
            // 
            // StaticLbReportes
            // 
            this.StaticLbReportes.AutoSize = true;
            this.StaticLbReportes.Location = new System.Drawing.Point(13, 210);
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
            this.StaticLbEstado.Location = new System.Drawing.Point(13, 179);
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(803, 30);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(257, 615);
            this.dataGridView1.TabIndex = 82;
            // 
            // StaticLbUsuariosGrupo
            // 
            this.StaticLbUsuariosGrupo.AutoSize = true;
            this.StaticLbUsuariosGrupo.Location = new System.Drawing.Point(800, 14);
            this.StaticLbUsuariosGrupo.Name = "StaticLbUsuariosGrupo";
            this.StaticLbUsuariosGrupo.Size = new System.Drawing.Size(51, 13);
            this.StaticLbUsuariosGrupo.TabIndex = 83;
            this.StaticLbUsuariosGrupo.Text = "Usuarios:";
            // 
            // AdminGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StaticLbUsuariosGrupo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnActualizarDatosCuenta);
            this.Controls.Add(this.LbIdUsuario);
            this.Controls.Add(this.BtnModificarDescripcion);
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
            this.Controls.Add(this.LbNombreGrupo);
            this.Controls.Add(this.LboxResponsablesGrupo);
            this.Controls.Add(this.StaticLbReportes);
            this.Controls.Add(this.StaticLbResponsables);
            this.Controls.Add(this.StaticLbEstado);
            this.Controls.Add(this.StaticLbUsername);
            this.Controls.Add(this.StaticLbImgProfile);
            this.Name = "AdminGrupo";
            this.Size = new System.Drawing.Size(1076, 648);
            ((System.ComponentModel.ISupportInitialize)(this.DgridComentarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgridPublicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnActualizarDatosCuenta;
        private System.Windows.Forms.Label LbIdUsuario;
        private System.Windows.Forms.Button BtnModificarDescripcion;
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
        private System.Windows.Forms.Label LbNombreGrupo;
        private System.Windows.Forms.ListBox LboxResponsablesGrupo;
        private System.Windows.Forms.Label StaticLbReportes;
        private System.Windows.Forms.Label StaticLbResponsables;
        private System.Windows.Forms.Label StaticLbEstado;
        private System.Windows.Forms.Label StaticLbUsername;
        private System.Windows.Forms.Label StaticLbImgProfile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label StaticLbUsuariosGrupo;
    }
}
