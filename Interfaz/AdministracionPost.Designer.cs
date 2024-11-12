
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
            this.LbUserId = new System.Windows.Forms.Label();
            this.LbIdPost = new System.Windows.Forms.Label();
            this.LbNumeroDeReports = new System.Windows.Forms.Label();
            this.LbFechaDePost = new System.Windows.Forms.Label();
            this.TboxUrlMultimedia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgridComentarios)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEliminarPost
            // 
            this.BtnEliminarPost.BackColor = System.Drawing.Color.Red;
            this.BtnEliminarPost.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarPost.Location = new System.Drawing.Point(177, 226);
            this.BtnEliminarPost.Name = "BtnEliminarPost";
            this.BtnEliminarPost.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminarPost.TabIndex = 34;
            this.BtnEliminarPost.Text = "Eliminar";
            this.BtnEliminarPost.UseVisualStyleBackColor = false;
            this.BtnEliminarPost.Click += new System.EventHandler(this.BtnEliminarPost_Click);
            // 
            // BtnEditarPost
            // 
            this.BtnEditarPost.Location = new System.Drawing.Point(12, 226);
            this.BtnEditarPost.Name = "BtnEditarPost";
            this.BtnEditarPost.Size = new System.Drawing.Size(75, 23);
            this.BtnEditarPost.TabIndex = 33;
            this.BtnEditarPost.Text = "Modificar";
            this.BtnEditarPost.UseVisualStyleBackColor = true;
            this.BtnEditarPost.Click += new System.EventHandler(this.BtnEditarPost_Click);
            // 
            // TboxPublicacion
            // 
            this.TboxPublicacion.Location = new System.Drawing.Point(12, 54);
            this.TboxPublicacion.Multiline = true;
            this.TboxPublicacion.Name = "TboxPublicacion";
            this.TboxPublicacion.Size = new System.Drawing.Size(239, 88);
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
            this.DgridComentarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DgridComentarios.Location = new System.Drawing.Point(12, 281);
            this.DgridComentarios.Name = "DgridComentarios";
            this.DgridComentarios.ReadOnly = true;
            this.DgridComentarios.Size = new System.Drawing.Size(239, 85);
            this.DgridComentarios.TabIndex = 37;
            this.DgridComentarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgridComentarios_CellClick);
            // 
            // BtnEliminarComentario
            // 
            this.BtnEliminarComentario.BackColor = System.Drawing.Color.Red;
            this.BtnEliminarComentario.ForeColor = System.Drawing.Color.White;
            this.BtnEliminarComentario.Location = new System.Drawing.Point(176, 466);
            this.BtnEliminarComentario.Name = "BtnEliminarComentario";
            this.BtnEliminarComentario.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminarComentario.TabIndex = 43;
            this.BtnEliminarComentario.Text = "Eliminar";
            this.BtnEliminarComentario.UseVisualStyleBackColor = false;
            // 
            // BtnEditarComentario
            // 
            this.BtnEditarComentario.Location = new System.Drawing.Point(12, 466);
            this.BtnEditarComentario.Name = "BtnEditarComentario";
            this.BtnEditarComentario.Size = new System.Drawing.Size(75, 23);
            this.BtnEditarComentario.TabIndex = 42;
            this.BtnEditarComentario.Text = "Modificar";
            this.BtnEditarComentario.UseVisualStyleBackColor = true;
            // 
            // TboxComentarios
            // 
            this.TboxComentarios.Location = new System.Drawing.Point(12, 372);
            this.TboxComentarios.Multiline = true;
            this.TboxComentarios.Name = "TboxComentarios";
            this.TboxComentarios.Size = new System.Drawing.Size(240, 88);
            this.TboxComentarios.TabIndex = 41;
            // 
            // BtnPublicacionResuelta
            // 
            this.BtnPublicacionResuelta.Location = new System.Drawing.Point(176, 513);
            this.BtnPublicacionResuelta.Name = "BtnPublicacionResuelta";
            this.BtnPublicacionResuelta.Size = new System.Drawing.Size(75, 26);
            this.BtnPublicacionResuelta.TabIndex = 44;
            this.BtnPublicacionResuelta.Text = "Resuelto";
            this.BtnPublicacionResuelta.UseVisualStyleBackColor = true;
            // 
            // LbUserId
            // 
            this.LbUserId.AutoSize = true;
            this.LbUserId.Location = new System.Drawing.Point(54, 5);
            this.LbUserId.Name = "LbUserId";
            this.LbUserId.Size = new System.Drawing.Size(18, 13);
            this.LbUserId.TabIndex = 46;
            this.LbUserId.Text = "ID";
            // 
            // LbIdPost
            // 
            this.LbIdPost.AutoSize = true;
            this.LbIdPost.Location = new System.Drawing.Point(173, 5);
            this.LbIdPost.Name = "LbIdPost";
            this.LbIdPost.Size = new System.Drawing.Size(18, 13);
            this.LbIdPost.TabIndex = 47;
            this.LbIdPost.Text = "ID";
            // 
            // LbNumeroDeReports
            // 
            this.LbNumeroDeReports.AutoSize = true;
            this.LbNumeroDeReports.Location = new System.Drawing.Point(81, 521);
            this.LbNumeroDeReports.Name = "LbNumeroDeReports";
            this.LbNumeroDeReports.Size = new System.Drawing.Size(15, 13);
            this.LbNumeroDeReports.TabIndex = 48;
            this.LbNumeroDeReports.Text = "N";
            // 
            // LbFechaDePost
            // 
            this.LbFechaDePost.AutoSize = true;
            this.LbFechaDePost.Location = new System.Drawing.Point(12, 22);
            this.LbFechaDePost.Name = "LbFechaDePost";
            this.LbFechaDePost.Size = new System.Drawing.Size(99, 13);
            this.LbFechaDePost.TabIndex = 49;
            this.LbFechaDePost.Text = "Fecha de creacion:";
            // 
            // TboxUrlMultimedia
            // 
            this.TboxUrlMultimedia.Location = new System.Drawing.Point(11, 167);
            this.TboxUrlMultimedia.Name = "TboxUrlMultimedia";
            this.TboxUrlMultimedia.Size = new System.Drawing.Size(240, 20);
            this.TboxUrlMultimedia.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Contenido del post:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Contenido multimedia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Comentarios del post:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 54;
            this.button1.Text = "Ver imagen del post";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "User ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Post ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 520);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "N° de reports:";
            // 
            // AdministracionPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 542);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TboxUrlMultimedia);
            this.Controls.Add(this.LbFechaDePost);
            this.Controls.Add(this.LbNumeroDeReports);
            this.Controls.Add(this.LbIdPost);
            this.Controls.Add(this.LbUserId);
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
        private System.Windows.Forms.Label LbUserId;
        private System.Windows.Forms.Label LbIdPost;
        private System.Windows.Forms.Label LbNumeroDeReports;
        private System.Windows.Forms.Label LbFechaDePost;
        private System.Windows.Forms.TextBox TboxUrlMultimedia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}