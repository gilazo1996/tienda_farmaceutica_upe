﻿
namespace FarmaSalud
{
    partial class FrmVendedor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMiPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarMiPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGenerarVenta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.perfilToolStripMenuItem,
            this.sesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verMiPerfilToolStripMenuItem,
            this.editarMiPerfilToolStripMenuItem,
            this.modificarContraseñaToolStripMenuItem});
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // verMiPerfilToolStripMenuItem
            // 
            this.verMiPerfilToolStripMenuItem.Name = "verMiPerfilToolStripMenuItem";
            this.verMiPerfilToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.verMiPerfilToolStripMenuItem.Text = "Ver mi perfil";
            // 
            // editarMiPerfilToolStripMenuItem
            // 
            this.editarMiPerfilToolStripMenuItem.Name = "editarMiPerfilToolStripMenuItem";
            this.editarMiPerfilToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.editarMiPerfilToolStripMenuItem.Text = "Editar mi perfil";
            // 
            // modificarContraseñaToolStripMenuItem
            // 
            this.modificarContraseñaToolStripMenuItem.Name = "modificarContraseñaToolStripMenuItem";
            this.modificarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.modificarContraseñaToolStripMenuItem.Text = "Modificar contraseña";
            // 
            // sesiónToolStripMenuItem
            // 
            this.sesiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem});
            this.sesiónToolStripMenuItem.Name = "sesiónToolStripMenuItem";
            this.sesiónToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sesiónToolStripMenuItem.Text = "Sesión";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            // 
            // btnGenerarVenta
            // 
            this.btnGenerarVenta.Location = new System.Drawing.Point(27, 274);
            this.btnGenerarVenta.Name = "btnGenerarVenta";
            this.btnGenerarVenta.Size = new System.Drawing.Size(117, 30);
            this.btnGenerarVenta.TabIndex = 6;
            this.btnGenerarVenta.Text = "Generar venta";
            this.btnGenerarVenta.UseVisualStyleBackColor = true;
            this.btnGenerarVenta.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(465, 274);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 30);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGenerarVenta);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmVendedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio - Vendedor";
            this.Load += new System.EventHandler(this.FrmVendedor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMiPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarMiPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.Button btnGenerarVenta;
        private System.Windows.Forms.Button btnSalir;
    }
}