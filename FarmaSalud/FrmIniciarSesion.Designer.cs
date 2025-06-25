namespace FarmaSalud
{
    partial class FrmIniciarSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIniciarSesion));
            this.labTituloPass = new System.Windows.Forms.Label();
            this.tboxContraseña = new System.Windows.Forms.TextBox();
            this.labTituloUsuario = new System.Windows.Forms.Label();
            this.labLogoInicio = new System.Windows.Forms.Label();
            this.pboxInicio = new System.Windows.Forms.PictureBox();
            this.tboxUsuario = new System.Windows.Forms.TextBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pboxInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // labTituloPass
            // 
            this.labTituloPass.AutoSize = true;
            this.labTituloPass.BackColor = System.Drawing.Color.Transparent;
            this.labTituloPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTituloPass.ForeColor = System.Drawing.Color.Black;
            this.labTituloPass.Location = new System.Drawing.Point(126, 266);
            this.labTituloPass.Name = "labTituloPass";
            this.labTituloPass.Size = new System.Drawing.Size(76, 16);
            this.labTituloPass.TabIndex = 16;
            this.labTituloPass.Text = "Contraseña";
            // 
            // tboxContraseña
            // 
            this.tboxContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxContraseña.Location = new System.Drawing.Point(87, 285);
            this.tboxContraseña.Name = "tboxContraseña";
            this.tboxContraseña.Size = new System.Drawing.Size(147, 22);
            this.tboxContraseña.TabIndex = 15;
            this.tboxContraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxContraseña_KeyDown);
            // 
            // labTituloUsuario
            // 
            this.labTituloUsuario.AutoSize = true;
            this.labTituloUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labTituloUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTituloUsuario.ForeColor = System.Drawing.Color.Black;
            this.labTituloUsuario.Location = new System.Drawing.Point(137, 222);
            this.labTituloUsuario.Name = "labTituloUsuario";
            this.labTituloUsuario.Size = new System.Drawing.Size(54, 16);
            this.labTituloUsuario.TabIndex = 14;
            this.labTituloUsuario.Text = "Usuario";
            // 
            // labLogoInicio
            // 
            this.labLogoInicio.AutoSize = true;
            this.labLogoInicio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labLogoInicio.Font = new System.Drawing.Font("Myanmar Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labLogoInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.labLogoInicio.Location = new System.Drawing.Point(68, 164);
            this.labLogoInicio.Name = "labLogoInicio";
            this.labLogoInicio.Size = new System.Drawing.Size(184, 51);
            this.labLogoInicio.TabIndex = 13;
            this.labLogoInicio.Text = "FarmaSalud";
            // 
            // pboxInicio
            // 
            this.pboxInicio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pboxInicio.Image = ((System.Drawing.Image)(resources.GetObject("pboxInicio.Image")));
            this.pboxInicio.Location = new System.Drawing.Point(87, 20);
            this.pboxInicio.Name = "pboxInicio";
            this.pboxInicio.Size = new System.Drawing.Size(147, 141);
            this.pboxInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxInicio.TabIndex = 12;
            this.pboxInicio.TabStop = false;
            // 
            // tboxUsuario
            // 
            this.tboxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxUsuario.Location = new System.Drawing.Point(87, 241);
            this.tboxUsuario.Name = "tboxUsuario";
            this.tboxUsuario.Size = new System.Drawing.Size(147, 22);
            this.tboxUsuario.TabIndex = 10;
            this.tboxUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxUsuario_KeyDown);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(87, 326);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(147, 32);
            this.btnIniciarSesion.TabIndex = 9;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(34, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 203);
            this.panel1.TabIndex = 17;
            // 
            // FrmIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(328, 383);
            this.Controls.Add(this.labTituloPass);
            this.Controls.Add(this.tboxContraseña);
            this.Controls.Add(this.labTituloUsuario);
            this.Controls.Add(this.labLogoInicio);
            this.Controls.Add(this.pboxInicio);
            this.Controls.Add(this.tboxUsuario);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FarmaSalud";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmIniciarSesion_FormClosed);
            this.Load += new System.EventHandler(this.FrmIniciarSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTituloPass;
        private System.Windows.Forms.TextBox tboxContraseña;
        private System.Windows.Forms.Label labTituloUsuario;
        private System.Windows.Forms.Label labLogoInicio;
        private System.Windows.Forms.PictureBox pboxInicio;
        private System.Windows.Forms.TextBox tboxUsuario;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Panel panel1;
    }
}

