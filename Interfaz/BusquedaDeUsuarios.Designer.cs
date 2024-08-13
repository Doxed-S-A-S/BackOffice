
namespace Interfaz
{
    partial class BusquedaDeUsuarios
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
            this.DgridPublicaciones = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ChBoxReportados = new System.Windows.Forms.CheckBox();
            this.ChBoxTutores = new System.Windows.Forms.CheckBox();
            this.ChBoxSuspendidos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgridPublicaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // DgridPublicaciones
            // 
            this.DgridPublicaciones.AllowUserToAddRows = false;
            this.DgridPublicaciones.AllowUserToDeleteRows = false;
            this.DgridPublicaciones.AllowUserToResizeColumns = false;
            this.DgridPublicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgridPublicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgridPublicaciones.Location = new System.Drawing.Point(27, 99);
            this.DgridPublicaciones.MultiSelect = false;
            this.DgridPublicaciones.Name = "DgridPublicaciones";
            this.DgridPublicaciones.Size = new System.Drawing.Size(363, 528);
            this.DgridPublicaciones.TabIndex = 36;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Buscar usuario:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.button1.Location = new System.Drawing.Point(426, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 43);
            this.button1.TabIndex = 39;
            this.button1.Text = "Seleccionar usuario";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.3F);
            this.button2.Location = new System.Drawing.Point(426, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 43);
            this.button2.TabIndex = 40;
            this.button2.Text = " Seleccionar usuario  (Ventana emergente)";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Filtros:";
            // 
            // ChBoxReportados
            // 
            this.ChBoxReportados.AutoSize = true;
            this.ChBoxReportados.Location = new System.Drawing.Point(95, 76);
            this.ChBoxReportados.Name = "ChBoxReportados";
            this.ChBoxReportados.Size = new System.Drawing.Size(81, 17);
            this.ChBoxReportados.TabIndex = 42;
            this.ChBoxReportados.Text = "Reportados";
            this.ChBoxReportados.UseVisualStyleBackColor = true;
            // 
            // ChBoxTutores
            // 
            this.ChBoxTutores.AutoSize = true;
            this.ChBoxTutores.Location = new System.Drawing.Point(27, 76);
            this.ChBoxTutores.Name = "ChBoxTutores";
            this.ChBoxTutores.Size = new System.Drawing.Size(62, 17);
            this.ChBoxTutores.TabIndex = 43;
            this.ChBoxTutores.Text = "Tutores";
            this.ChBoxTutores.UseVisualStyleBackColor = true;
            // 
            // ChBoxSuspendidos
            // 
            this.ChBoxSuspendidos.AutoSize = true;
            this.ChBoxSuspendidos.Location = new System.Drawing.Point(182, 76);
            this.ChBoxSuspendidos.Name = "ChBoxSuspendidos";
            this.ChBoxSuspendidos.Size = new System.Drawing.Size(87, 17);
            this.ChBoxSuspendidos.TabIndex = 44;
            this.ChBoxSuspendidos.Text = "Suspendidos";
            this.ChBoxSuspendidos.UseVisualStyleBackColor = true;
            // 
            // BusquedaDeUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ChBoxSuspendidos);
            this.Controls.Add(this.ChBoxTutores);
            this.Controls.Add(this.ChBoxReportados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DgridPublicaciones);
            this.Name = "BusquedaDeUsuarios";
            this.Size = new System.Drawing.Size(1012, 648);
            ((System.ComponentModel.ISupportInitialize)(this.DgridPublicaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgridPublicaciones;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ChBoxReportados;
        private System.Windows.Forms.CheckBox ChBoxTutores;
        private System.Windows.Forms.CheckBox ChBoxSuspendidos;
    }
}
