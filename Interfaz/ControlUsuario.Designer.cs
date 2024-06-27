
namespace Interfaz
{
    partial class ControlUsuario
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
            this.StaticLbPublicacion = new System.Windows.Forms.Label();
            this.LbRolUsr = new System.Windows.Forms.Label();
            this.StaticLbRolUsr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LbUsername = new System.Windows.Forms.Label();
            this.LboxReportes = new System.Windows.Forms.ListBox();
            this.LboxGrupos = new System.Windows.Forms.ListBox();
            this.StaticLbReportes = new System.Windows.Forms.Label();
            this.StaticLbGrupos = new System.Windows.Forms.Label();
            this.StaticLbEstado = new System.Windows.Forms.Label();
            this.StaticLbUsername = new System.Windows.Forms.Label();
            this.StaticLbImgProfile = new System.Windows.Forms.Label();
            this.TboxContenido = new System.Windows.Forms.TextBox();
            this.BtnEditarPost = new System.Windows.Forms.Button();
            this.BtnEliminarPost = new System.Windows.Forms.Button();
            this.BtnActualizarPub = new System.Windows.Forms.Button();
            this.DgridPublicaciones = new System.Windows.Forms.DataGridView();
            this.DgridComentarios = new System.Windows.Forms.DataGridView();
            this.TboxComentarios = new System.Windows.Forms.TextBox();
            this.BtnActualizarComentarios = new System.Windows.Forms.Button();
            this.BtnEliminarComentario = new System.Windows.Forms.Button();
            this.BtnEditarComentario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgridPublicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgridComentarios)).BeginInit();
            this.SuspendLayout();
            // 
            // StaticLbPublicacion
            // 
            this.StaticLbPublicacion.AutoSize = true;
            this.StaticLbPublicacion.Location = new System.Drawing.Point(238, 11);
            this.StaticLbPublicacion.Name = "StaticLbPublicacion";
            this.StaticLbPublicacion.Size = new System.Drawing.Size(76, 13);
            this.StaticLbPublicacion.TabIndex = 28;
            this.StaticLbPublicacion.Text = "Publicaciones:";
            // 
            // LbRolUsr
            // 
            this.LbRolUsr.AutoSize = true;
            this.LbRolUsr.Location = new System.Drawing.Point(62, 197);
            this.LbRolUsr.Name = "LbRolUsr";
            this.LbRolUsr.Size = new System.Drawing.Size(127, 13);
            this.LbRolUsr.TabIndex = 26;
            this.LbRolUsr.Text = "Usuario/Profesor/Alumno";
            // 
            // StaticLbRolUsr
            // 
            this.StaticLbRolUsr.AutoSize = true;
            this.StaticLbRolUsr.Location = new System.Drawing.Point(13, 197);
            this.StaticLbRolUsr.Name = "StaticLbRolUsr";
            this.StaticLbRolUsr.Size = new System.Drawing.Size(26, 13);
            this.StaticLbRolUsr.TabIndex = 25;
            this.StaticLbRolUsr.Text = "Rol:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Activo/Bloqueado";
            // 
            // LbUsername
            // 
            this.LbUsername.AutoSize = true;
            this.LbUsername.Location = new System.Drawing.Point(62, 164);
            this.LbUsername.Name = "LbUsername";
            this.LbUsername.Size = new System.Drawing.Size(49, 13);
            this.LbUsername.TabIndex = 23;
            this.LbUsername.Text = "(ejemplo)";
            // 
            // LboxReportes
            // 
            this.LboxReportes.FormattingEnabled = true;
            this.LboxReportes.Location = new System.Drawing.Point(12, 459);
            this.LboxReportes.Name = "LboxReportes";
            this.LboxReportes.Size = new System.Drawing.Size(201, 186);
            this.LboxReportes.TabIndex = 22;
            // 
            // LboxGrupos
            // 
            this.LboxGrupos.FormattingEnabled = true;
            this.LboxGrupos.Location = new System.Drawing.Point(12, 235);
            this.LboxGrupos.Name = "LboxGrupos";
            this.LboxGrupos.Size = new System.Drawing.Size(201, 186);
            this.LboxGrupos.TabIndex = 21;
            // 
            // StaticLbReportes
            // 
            this.StaticLbReportes.AutoSize = true;
            this.StaticLbReportes.Location = new System.Drawing.Point(13, 443);
            this.StaticLbReportes.Name = "StaticLbReportes";
            this.StaticLbReportes.Size = new System.Drawing.Size(53, 13);
            this.StaticLbReportes.TabIndex = 20;
            this.StaticLbReportes.Text = "Reportes:";
            // 
            // StaticLbGrupos
            // 
            this.StaticLbGrupos.AutoSize = true;
            this.StaticLbGrupos.Location = new System.Drawing.Point(13, 219);
            this.StaticLbGrupos.Name = "StaticLbGrupos";
            this.StaticLbGrupos.Size = new System.Drawing.Size(44, 13);
            this.StaticLbGrupos.TabIndex = 19;
            this.StaticLbGrupos.Text = "Grupos:";
            // 
            // StaticLbEstado
            // 
            this.StaticLbEstado.AutoSize = true;
            this.StaticLbEstado.Location = new System.Drawing.Point(13, 181);
            this.StaticLbEstado.Name = "StaticLbEstado";
            this.StaticLbEstado.Size = new System.Drawing.Size(43, 13);
            this.StaticLbEstado.TabIndex = 18;
            this.StaticLbEstado.Text = "Estado:";
            // 
            // StaticLbUsername
            // 
            this.StaticLbUsername.AutoSize = true;
            this.StaticLbUsername.Location = new System.Drawing.Point(13, 164);
            this.StaticLbUsername.Name = "StaticLbUsername";
            this.StaticLbUsername.Size = new System.Drawing.Size(46, 13);
            this.StaticLbUsername.TabIndex = 17;
            this.StaticLbUsername.Text = "Usuario:";
            // 
            // StaticLbImgProfile
            // 
            this.StaticLbImgProfile.AutoSize = true;
            this.StaticLbImgProfile.Location = new System.Drawing.Point(62, 50);
            this.StaticLbImgProfile.Name = "StaticLbImgProfile";
            this.StaticLbImgProfile.Size = new System.Drawing.Size(93, 13);
            this.StaticLbImgProfile.TabIndex = 16;
            this.StaticLbImgProfile.Text = "( imagen de perfil )";
            // 
            // TboxContenido
            // 
            this.TboxContenido.Location = new System.Drawing.Point(610, 59);
            this.TboxContenido.Multiline = true;
            this.TboxContenido.Name = "TboxContenido";
            this.TboxContenido.Size = new System.Drawing.Size(169, 112);
            this.TboxContenido.TabIndex = 29;
            // 
            // BtnEditarPost
            // 
            this.BtnEditarPost.Location = new System.Drawing.Point(610, 177);
            this.BtnEditarPost.Name = "BtnEditarPost";
            this.BtnEditarPost.Size = new System.Drawing.Size(75, 23);
            this.BtnEditarPost.TabIndex = 30;
            this.BtnEditarPost.Text = "Editar";
            this.BtnEditarPost.UseVisualStyleBackColor = true;
            this.BtnEditarPost.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnEliminarPost
            // 
            this.BtnEliminarPost.Location = new System.Drawing.Point(704, 177);
            this.BtnEliminarPost.Name = "BtnEliminarPost";
            this.BtnEliminarPost.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminarPost.TabIndex = 31;
            this.BtnEliminarPost.Text = "Eliminar";
            this.BtnEliminarPost.UseVisualStyleBackColor = true;
            this.BtnEliminarPost.Click += new System.EventHandler(this.BtnEliminarPost_Click);
            // 
            // BtnActualizarPub
            // 
            this.BtnActualizarPub.Location = new System.Drawing.Point(610, 30);
            this.BtnActualizarPub.Name = "BtnActualizarPub";
            this.BtnActualizarPub.Size = new System.Drawing.Size(169, 23);
            this.BtnActualizarPub.TabIndex = 34;
            this.BtnActualizarPub.Text = "Actualizar lista de post";
            this.BtnActualizarPub.UseVisualStyleBackColor = true;
            this.BtnActualizarPub.Click += new System.EventHandler(this.BtnActualizarPub_Click);
            // 
            // DgridPublicaciones
            // 
            this.DgridPublicaciones.AllowUserToAddRows = false;
            this.DgridPublicaciones.AllowUserToDeleteRows = false;
            this.DgridPublicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DgridPublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgridPublicaciones.Location = new System.Drawing.Point(241, 30);
            this.DgridPublicaciones.MultiSelect = false;
            this.DgridPublicaciones.Name = "DgridPublicaciones";
            this.DgridPublicaciones.Size = new System.Drawing.Size(363, 391);
            this.DgridPublicaciones.TabIndex = 35;
            this.DgridPublicaciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgridPublicaciones_CellClick);
            // 
            // DgridComentarios
            // 
            this.DgridComentarios.AllowUserToAddRows = false;
            this.DgridComentarios.AllowUserToDeleteRows = false;
            this.DgridComentarios.AllowUserToResizeColumns = false;
            this.DgridComentarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgridComentarios.Location = new System.Drawing.Point(241, 459);
            this.DgridComentarios.Name = "DgridComentarios";
            this.DgridComentarios.Size = new System.Drawing.Size(363, 186);
            this.DgridComentarios.TabIndex = 36;
            this.DgridComentarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgridComentarios_CellClick);
            // 
            // TboxComentarios
            // 
            this.TboxComentarios.Location = new System.Drawing.Point(610, 488);
            this.TboxComentarios.Multiline = true;
            this.TboxComentarios.Name = "TboxComentarios";
            this.TboxComentarios.Size = new System.Drawing.Size(169, 112);
            this.TboxComentarios.TabIndex = 37;
            // 
            // BtnActualizarComentarios
            // 
            this.BtnActualizarComentarios.Location = new System.Drawing.Point(610, 459);
            this.BtnActualizarComentarios.Name = "BtnActualizarComentarios";
            this.BtnActualizarComentarios.Size = new System.Drawing.Size(169, 23);
            this.BtnActualizarComentarios.TabIndex = 38;
            this.BtnActualizarComentarios.Text = "Actualizar lista de comentarios";
            this.BtnActualizarComentarios.UseVisualStyleBackColor = true;
            this.BtnActualizarComentarios.Click += new System.EventHandler(this.BtnActualizarComentarios_Click);
            // 
            // BtnEliminarComentario
            // 
            this.BtnEliminarComentario.Location = new System.Drawing.Point(704, 606);
            this.BtnEliminarComentario.Name = "BtnEliminarComentario";
            this.BtnEliminarComentario.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminarComentario.TabIndex = 40;
            this.BtnEliminarComentario.Text = "Eliminar";
            this.BtnEliminarComentario.UseVisualStyleBackColor = true;
            this.BtnEliminarComentario.Click += new System.EventHandler(this.BtnEliminarComentario_Click);
            // 
            // BtnEditarComentario
            // 
            this.BtnEditarComentario.Location = new System.Drawing.Point(610, 606);
            this.BtnEditarComentario.Name = "BtnEditarComentario";
            this.BtnEditarComentario.Size = new System.Drawing.Size(75, 23);
            this.BtnEditarComentario.TabIndex = 39;
            this.BtnEditarComentario.Text = "Editar";
            this.BtnEditarComentario.UseVisualStyleBackColor = true;
            this.BtnEditarComentario.Click += new System.EventHandler(this.BtnEditarComentario_Click);
            // 
            // ControlUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnEliminarComentario);
            this.Controls.Add(this.BtnEditarComentario);
            this.Controls.Add(this.BtnActualizarComentarios);
            this.Controls.Add(this.TboxComentarios);
            this.Controls.Add(this.DgridComentarios);
            this.Controls.Add(this.DgridPublicaciones);
            this.Controls.Add(this.BtnActualizarPub);
            this.Controls.Add(this.BtnEliminarPost);
            this.Controls.Add(this.BtnEditarPost);
            this.Controls.Add(this.TboxContenido);
            this.Controls.Add(this.StaticLbPublicacion);
            this.Controls.Add(this.LbRolUsr);
            this.Controls.Add(this.StaticLbRolUsr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbUsername);
            this.Controls.Add(this.LboxReportes);
            this.Controls.Add(this.LboxGrupos);
            this.Controls.Add(this.StaticLbReportes);
            this.Controls.Add(this.StaticLbGrupos);
            this.Controls.Add(this.StaticLbEstado);
            this.Controls.Add(this.StaticLbUsername);
            this.Controls.Add(this.StaticLbImgProfile);
            this.Name = "ControlUsuario";
            this.Size = new System.Drawing.Size(1012, 648);
            ((System.ComponentModel.ISupportInitialize)(this.DgridPublicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgridComentarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StaticLbPublicacion;
        private System.Windows.Forms.Label LbRolUsr;
        private System.Windows.Forms.Label StaticLbRolUsr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LbUsername;
        private System.Windows.Forms.ListBox LboxReportes;
        private System.Windows.Forms.ListBox LboxGrupos;
        private System.Windows.Forms.Label StaticLbReportes;
        private System.Windows.Forms.Label StaticLbGrupos;
        private System.Windows.Forms.Label StaticLbEstado;
        private System.Windows.Forms.Label StaticLbUsername;
        private System.Windows.Forms.Label StaticLbImgProfile;
        private System.Windows.Forms.TextBox TboxContenido;
        private System.Windows.Forms.Button BtnEditarPost;
        private System.Windows.Forms.Button BtnEliminarPost;
        private System.Windows.Forms.Button BtnActualizarPub;
        private System.Windows.Forms.DataGridView DgridPublicaciones;
        private System.Windows.Forms.DataGridView DgridComentarios;
        private System.Windows.Forms.TextBox TboxComentarios;
        private System.Windows.Forms.Button BtnActualizarComentarios;
        private System.Windows.Forms.Button BtnEliminarComentario;
        private System.Windows.Forms.Button BtnEditarComentario;
    }
}
