﻿
namespace Interfaz
{
    partial class TestingWindow
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
            this.TestingButtonCrearUsr = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TestingTboxEmail = new System.Windows.Forms.TextBox();
            this.TestingTboxUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TestingTboxIdPub = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TestingTboxComReacciones = new System.Windows.Forms.TextBox();
            this.TestingBtnPuliComentario = new System.Windows.Forms.Button();
            this.TestingTboxComentario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TestingTboxReacciones = new System.Windows.Forms.TextBox();
            this.TestingBtnPub = new System.Windows.Forms.Button();
            this.TestingTboxPub = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TestingTboxIdUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TestingButtonCrearUsr
            // 
            this.TestingButtonCrearUsr.Location = new System.Drawing.Point(112, 121);
            this.TestingButtonCrearUsr.Name = "TestingButtonCrearUsr";
            this.TestingButtonCrearUsr.Size = new System.Drawing.Size(75, 23);
            this.TestingButtonCrearUsr.TabIndex = 54;
            this.TestingButtonCrearUsr.Text = "Crear usuario";
            this.TestingButtonCrearUsr.UseVisualStyleBackColor = true;
            this.TestingButtonCrearUsr.Click += new System.EventHandler(this.TestingButtonCrearUsr_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "E-mail";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Username";
            // 
            // TestingTboxEmail
            // 
            this.TestingTboxEmail.Location = new System.Drawing.Point(15, 95);
            this.TestingTboxEmail.Name = "TestingTboxEmail";
            this.TestingTboxEmail.Size = new System.Drawing.Size(172, 20);
            this.TestingTboxEmail.TabIndex = 51;
            // 
            // TestingTboxUsername
            // 
            this.TestingTboxUsername.Location = new System.Drawing.Point(15, 53);
            this.TestingTboxUsername.Name = "TestingTboxUsername";
            this.TestingTboxUsername.Size = new System.Drawing.Size(172, 20);
            this.TestingTboxUsername.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "ID de la publicacion";
            // 
            // TestingTboxIdPub
            // 
            this.TestingTboxIdPub.Location = new System.Drawing.Point(520, 181);
            this.TestingTboxIdPub.Name = "TestingTboxIdPub";
            this.TestingTboxIdPub.Size = new System.Drawing.Size(46, 20);
            this.TestingTboxIdPub.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Likes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Comentario ( max 255 chars )";
            // 
            // TestingTboxComReacciones
            // 
            this.TestingTboxComReacciones.Location = new System.Drawing.Point(466, 155);
            this.TestingTboxComReacciones.Name = "TestingTboxComReacciones";
            this.TestingTboxComReacciones.Size = new System.Drawing.Size(100, 20);
            this.TestingTboxComReacciones.TabIndex = 45;
            // 
            // TestingBtnPuliComentario
            // 
            this.TestingBtnPuliComentario.Location = new System.Drawing.Point(491, 216);
            this.TestingBtnPuliComentario.Name = "TestingBtnPuliComentario";
            this.TestingBtnPuliComentario.Size = new System.Drawing.Size(75, 23);
            this.TestingBtnPuliComentario.TabIndex = 44;
            this.TestingBtnPuliComentario.Text = "PublicarCom";
            this.TestingBtnPuliComentario.UseVisualStyleBackColor = true;
            this.TestingBtnPuliComentario.Click += new System.EventHandler(this.TestingBtnPuliComentario_Click);
            // 
            // TestingTboxComentario
            // 
            this.TestingTboxComentario.Location = new System.Drawing.Point(394, 53);
            this.TestingTboxComentario.Multiline = true;
            this.TestingTboxComentario.Name = "TestingTboxComentario";
            this.TestingTboxComentario.Size = new System.Drawing.Size(172, 96);
            this.TestingTboxComentario.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Likes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Publicacion ( Max 100 chars )";
            // 
            // TestingTboxReacciones
            // 
            this.TestingTboxReacciones.Location = new System.Drawing.Point(276, 155);
            this.TestingTboxReacciones.Name = "TestingTboxReacciones";
            this.TestingTboxReacciones.Size = new System.Drawing.Size(100, 20);
            this.TestingTboxReacciones.TabIndex = 40;
            // 
            // TestingBtnPub
            // 
            this.TestingBtnPub.Location = new System.Drawing.Point(301, 216);
            this.TestingBtnPub.Name = "TestingBtnPub";
            this.TestingBtnPub.Size = new System.Drawing.Size(75, 23);
            this.TestingBtnPub.TabIndex = 39;
            this.TestingBtnPub.Text = "Publicar";
            this.TestingBtnPub.UseVisualStyleBackColor = true;
            this.TestingBtnPub.Click += new System.EventHandler(this.TestingBtnPub_Click);
            // 
            // TestingTboxPub
            // 
            this.TestingTboxPub.Location = new System.Drawing.Point(204, 53);
            this.TestingTboxPub.Multiline = true;
            this.TestingTboxPub.Name = "TestingTboxPub";
            this.TestingTboxPub.Size = new System.Drawing.Size(172, 96);
            this.TestingTboxPub.TabIndex = 38;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(78, 13);
            this.Label1.TabIndex = 37;
            this.Label1.Text = "AreaDeTesting";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 56;
            this.label9.Text = "ID del usuario";
            // 
            // TestingTboxIdUser
            // 
            this.TestingTboxIdUser.Location = new System.Drawing.Point(330, 181);
            this.TestingTboxIdUser.Name = "TestingTboxIdUser";
            this.TestingTboxIdUser.Size = new System.Drawing.Size(46, 20);
            this.TestingTboxIdUser.TabIndex = 55;
            // 
            // TestingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TestingTboxIdUser);
            this.Controls.Add(this.TestingButtonCrearUsr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TestingTboxEmail);
            this.Controls.Add(this.TestingTboxUsername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TestingTboxIdPub);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TestingTboxComReacciones);
            this.Controls.Add(this.TestingBtnPuliComentario);
            this.Controls.Add(this.TestingTboxComentario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TestingTboxReacciones);
            this.Controls.Add(this.TestingBtnPub);
            this.Controls.Add(this.TestingTboxPub);
            this.Controls.Add(this.Label1);
            this.Name = "TestingWindow";
            this.Text = "TestingWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TestingButtonCrearUsr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TestingTboxEmail;
        private System.Windows.Forms.TextBox TestingTboxUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TestingTboxIdPub;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TestingTboxComReacciones;
        private System.Windows.Forms.Button TestingBtnPuliComentario;
        private System.Windows.Forms.TextBox TestingTboxComentario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TestingTboxReacciones;
        private System.Windows.Forms.Button TestingBtnPub;
        private System.Windows.Forms.TextBox TestingTboxPub;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TestingTboxIdUser;
    }
}