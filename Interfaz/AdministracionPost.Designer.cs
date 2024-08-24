
namespace Interfaz
{
    partial class AdministracionPost
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
            this.BtnEliminarPost = new System.Windows.Forms.Button();
            this.BtnEditarPost = new System.Windows.Forms.Button();
            this.TboxPublicacion = new System.Windows.Forms.TextBox();
            this.DgridComentarios = new System.Windows.Forms.DataGridView();
            this.BtnEliminarComentario = new System.Windows.Forms.Button();
            this.BtnEditarComentario = new System.Windows.Forms.Button();
            this.TboxComentarios = new System.Windows.Forms.TextBox();
            this.BtnPublicacionResuelta = new System.Windows.Forms.Button();
            this.BtnMostrarMultimedia = new System.Windows.Forms.Button();
            this.LbUserId = new System.Windows.Forms.Label();
            this.LbIdPost = new System.Windows.Forms.Label();
            this.LbNumeroDeReports = new System.Windows.Forms.Label();
            this.LbFechaDePost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgridComentarios)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEliminarPost
            // 
            this.BtnEliminarPost.BackColor = System.Drawing.Color.Red;
            this.BtnEliminarPost.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarPost.Location = new System.Drawing.Point(106, 159);
            this.BtnEliminarPost.Name = "BtnEliminarPost";
            this.BtnEliminarPost.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminarPost.TabIndex = 34;
            this.BtnEliminarPost.Text = "Eliminar";
            this.BtnEliminarPost.UseVisualStyleBackColor = false;
            // 
            // BtnEditarPost
            // 
            this.BtnEditarPost.Location = new System.Drawing.Point(12, 159);
            this.BtnEditarPost.Name = "BtnEditarPost";
            this.BtnEditarPost.Size = new System.Drawing.Size(75, 23);
            this.BtnEditarPost.TabIndex = 33;
            this.BtnEditarPost.Text = "Editar";
            this.BtnEditarPost.UseVisualStyleBackColor = true;
            // 
            // TboxPublicacion
            // 
            this.TboxPublicacion.Location = new System.Drawing.Point(12, 41);
            this.TboxPublicacion.Multiline = true;
            this.TboxPublicacion.Name = "TboxPublicacion";
            this.TboxPublicacion.Size = new System.Drawing.Size(169, 112);
            this.TboxPublicacion.TabIndex = 32;
            // 
            // DgridComentarios
            // 
            this.DgridComentarios.AllowUserToAddRows = false;
            this.DgridComentarios.AllowUserToDeleteRows = false;
            this.DgridComentarios.AllowUserToResizeColumns = false;
            this.DgridComentarios.AllowUserToResizeRows = false;
            this.DgridComentarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgridComentarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgridComentarios.Location = new System.Drawing.Point(12, 216);
            this.DgridComentarios.Name = "DgridComentarios";
            this.DgridComentarios.Size = new System.Drawing.Size(169, 129);
            this.DgridComentarios.TabIndex = 37;
            // 
            // BtnEliminarComentario
            // 
            this.BtnEliminarComentario.BackColor = System.Drawing.Color.Red;
            this.BtnEliminarComentario.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarComentario.Location = new System.Drawing.Point(106, 441);
            this.BtnEliminarComentario.Name = "BtnEliminarComentario";
            this.BtnEliminarComentario.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminarComentario.TabIndex = 43;
            this.BtnEliminarComentario.Text = "Eliminar";
            this.BtnEliminarComentario.UseVisualStyleBackColor = false;
            // 
            // BtnEditarComentario
            // 
            this.BtnEditarComentario.Location = new System.Drawing.Point(12, 441);
            this.BtnEditarComentario.Name = "BtnEditarComentario";
            this.BtnEditarComentario.Size = new System.Drawing.Size(75, 23);
            this.BtnEditarComentario.TabIndex = 42;
            this.BtnEditarComentario.Text = "Editar";
            this.BtnEditarComentario.UseVisualStyleBackColor = true;
            // 
            // TboxComentarios
            // 
            this.TboxComentarios.Location = new System.Drawing.Point(12, 351);
            this.TboxComentarios.Multiline = true;
            this.TboxComentarios.Name = "TboxComentarios";
            this.TboxComentarios.Size = new System.Drawing.Size(169, 84);
            this.TboxComentarios.TabIndex = 41;
            // 
            // BtnPublicacionResuelta
            // 
            this.BtnPublicacionResuelta.Location = new System.Drawing.Point(106, 483);
            this.BtnPublicacionResuelta.Name = "BtnPublicacionResuelta";
            this.BtnPublicacionResuelta.Size = new System.Drawing.Size(75, 26);
            this.BtnPublicacionResuelta.TabIndex = 44;
            this.BtnPublicacionResuelta.Text = "Resuelto";
            this.BtnPublicacionResuelta.UseVisualStyleBackColor = true;
            // 
            // BtnMostrarMultimedia
            // 
            this.BtnMostrarMultimedia.Location = new System.Drawing.Point(12, 188);
            this.BtnMostrarMultimedia.Name = "BtnMostrarMultimedia";
            this.BtnMostrarMultimedia.Size = new System.Drawing.Size(75, 23);
            this.BtnMostrarMultimedia.TabIndex = 45;
            this.BtnMostrarMultimedia.Text = "Multimedia";
            this.BtnMostrarMultimedia.UseVisualStyleBackColor = true;
            // 
            // LbUserId
            // 
            this.LbUserId.AutoSize = true;
            this.LbUserId.Location = new System.Drawing.Point(12, 9);
            this.LbUserId.Name = "LbUserId";
            this.LbUserId.Size = new System.Drawing.Size(46, 13);
            this.LbUserId.TabIndex = 46;
            this.LbUserId.Text = "User ID:";
            // 
            // LbIdPost
            // 
            this.LbIdPost.AutoSize = true;
            this.LbIdPost.Location = new System.Drawing.Point(139, 9);
            this.LbIdPost.Name = "LbIdPost";
            this.LbIdPost.Size = new System.Drawing.Size(42, 13);
            this.LbIdPost.TabIndex = 47;
            this.LbIdPost.Text = "Post ID";
            // 
            // LbNumeroDeReports
            // 
            this.LbNumeroDeReports.AutoSize = true;
            this.LbNumeroDeReports.Location = new System.Drawing.Point(12, 490);
            this.LbNumeroDeReports.Name = "LbNumeroDeReports";
            this.LbNumeroDeReports.Size = new System.Drawing.Size(72, 13);
            this.LbNumeroDeReports.TabIndex = 48;
            this.LbNumeroDeReports.Text = "N° de reports:";
            // 
            // LbFechaDePost
            // 
            this.LbFechaDePost.AutoSize = true;
            this.LbFechaDePost.Location = new System.Drawing.Point(12, 25);
            this.LbFechaDePost.Name = "LbFechaDePost";
            this.LbFechaDePost.Size = new System.Drawing.Size(99, 13);
            this.LbFechaDePost.TabIndex = 49;
            this.LbFechaDePost.Text = "Fecha de creacion:";
            // 
            // AdministracionPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 521);
            this.Controls.Add(this.LbFechaDePost);
            this.Controls.Add(this.LbNumeroDeReports);
            this.Controls.Add(this.LbIdPost);
            this.Controls.Add(this.LbUserId);
            this.Controls.Add(this.BtnMostrarMultimedia);
            this.Controls.Add(this.BtnPublicacionResuelta);
            this.Controls.Add(this.BtnEliminarComentario);
            this.Controls.Add(this.BtnEditarComentario);
            this.Controls.Add(this.TboxComentarios);
            this.Controls.Add(this.DgridComentarios);
            this.Controls.Add(this.BtnEliminarPost);
            this.Controls.Add(this.BtnEditarPost);
            this.Controls.Add(this.TboxPublicacion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministracionPost";
            this.Text = "AdministracionPost";
            ((System.ComponentModel.ISupportInitialize)(this.DgridComentarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEliminarPost;
        private System.Windows.Forms.Button BtnEditarPost;
        private System.Windows.Forms.TextBox TboxPublicacion;
        private System.Windows.Forms.DataGridView DgridComentarios;
        private System.Windows.Forms.Button BtnEliminarComentario;
        private System.Windows.Forms.Button BtnEditarComentario;
        private System.Windows.Forms.TextBox TboxComentarios;
        private System.Windows.Forms.Button BtnPublicacionResuelta;
        private System.Windows.Forms.Button BtnMostrarMultimedia;
        private System.Windows.Forms.Label LbUserId;
        private System.Windows.Forms.Label LbIdPost;
        private System.Windows.Forms.Label LbNumeroDeReports;
        private System.Windows.Forms.Label LbFechaDePost;
    }
}