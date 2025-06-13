
namespace UI
{
    partial class formInicio
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formInicio));
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.tboxIngreseUsuario = new System.Windows.Forms.TextBox();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.pboxInicio = new System.Windows.Forms.PictureBox();
            this.labLogoInicio = new System.Windows.Forms.Label();
            this.labTituloUsuario = new System.Windows.Forms.Label();
            this.labTituloPass = new System.Windows.Forms.Label();
            this.tboxIngresePass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(70, 322);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(147, 32);
            this.btnIniciarSesion.TabIndex = 1;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // tboxIngreseUsuario
            // 
            this.tboxIngreseUsuario.Location = new System.Drawing.Point(70, 246);
            this.tboxIngreseUsuario.Name = "tboxIngreseUsuario";
            this.tboxIngreseUsuario.Size = new System.Drawing.Size(147, 20);
            this.tboxIngreseUsuario.TabIndex = 2;
            this.tboxIngreseUsuario.TextChanged += new System.EventHandler(this.tboxIngreseUsuario_TextChanged);
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Location = new System.Drawing.Point(70, 360);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(147, 32);
            this.btnCrearUsuario.TabIndex = 3;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            // 
            // pboxInicio
            // 
            this.pboxInicio.Image = ((System.Drawing.Image)(resources.GetObject("pboxInicio.Image")));
            this.pboxInicio.Location = new System.Drawing.Point(70, 34);
            this.pboxInicio.Name = "pboxInicio";
            this.pboxInicio.Size = new System.Drawing.Size(147, 141);
            this.pboxInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxInicio.TabIndex = 4;
            this.pboxInicio.TabStop = false;
            // 
            // labLogoInicio
            // 
            this.labLogoInicio.AutoSize = true;
            this.labLogoInicio.Font = new System.Drawing.Font("Myanmar Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLogoInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.labLogoInicio.Location = new System.Drawing.Point(51, 178);
            this.labLogoInicio.Name = "labLogoInicio";
            this.labLogoInicio.Size = new System.Drawing.Size(184, 51);
            this.labLogoInicio.TabIndex = 5;
            this.labLogoInicio.Text = "FarmaSalud";
            // 
            // labTituloUsuario
            // 
            this.labTituloUsuario.AutoSize = true;
            this.labTituloUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labTituloUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTituloUsuario.ForeColor = System.Drawing.Color.Black;
            this.labTituloUsuario.Location = new System.Drawing.Point(122, 237);
            this.labTituloUsuario.Name = "labTituloUsuario";
            this.labTituloUsuario.Size = new System.Drawing.Size(43, 13);
            this.labTituloUsuario.TabIndex = 6;
            this.labTituloUsuario.Text = "Usuario";
            // 
            // labTituloPass
            // 
            this.labTituloPass.AutoSize = true;
            this.labTituloPass.BackColor = System.Drawing.Color.Transparent;
            this.labTituloPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTituloPass.ForeColor = System.Drawing.Color.Black;
            this.labTituloPass.Location = new System.Drawing.Point(113, 269);
            this.labTituloPass.Name = "labTituloPass";
            this.labTituloPass.Size = new System.Drawing.Size(61, 13);
            this.labTituloPass.TabIndex = 8;
            this.labTituloPass.Text = "Contraseña";
            // 
            // tboxIngresePass
            // 
            this.tboxIngresePass.Location = new System.Drawing.Point(70, 278);
            this.tboxIngresePass.Name = "tboxIngresePass";
            this.tboxIngresePass.Size = new System.Drawing.Size(147, 20);
            this.tboxIngresePass.TabIndex = 7;
            this.tboxIngresePass.TextChanged += new System.EventHandler(this.tboxIngresePass_TextChanged);
            // 
            // formInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.labTituloPass);
            this.Controls.Add(this.tboxIngresePass);
            this.Controls.Add(this.labTituloUsuario);
            this.Controls.Add(this.labLogoInicio);
            this.Controls.Add(this.pboxInicio);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.tboxIngreseUsuario);
            this.Controls.Add(this.btnIniciarSesion);
            this.Name = "formInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.formInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.TextBox tboxIngreseUsuario;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.PictureBox pboxInicio;
        private System.Windows.Forms.Label labLogoInicio;
        private System.Windows.Forms.Label labTituloUsuario;
        private System.Windows.Forms.Label labTituloPass;
        private System.Windows.Forms.TextBox tboxIngresePass;
    }
}

