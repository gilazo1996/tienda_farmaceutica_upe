
namespace UI
{
    partial class FormFarmaceu
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMiPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarMiPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarFarmacoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verListaProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verListaFarmacoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockPorFarmacoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido al panel de Farmaceutico";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.proveedorToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.perfilToolStripMenuItem,
            this.sesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarPerfilToolStripMenuItem,
            this.cargarFarmacoToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.gestionToolStripMenuItem.Text = "Farmacos";
            // 
            // buscarPerfilToolStripMenuItem
            // 
            this.buscarPerfilToolStripMenuItem.Name = "buscarPerfilToolStripMenuItem";
            this.buscarPerfilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buscarPerfilToolStripMenuItem.Text = "Buscar farmaco";
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
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarProveedorToolStripMenuItem,
            this.nuevoProveedorToolStripMenuItem,
            this.verListaProveedorToolStripMenuItem});
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verListaFarmacoToolStripMenuItem,
            this.stockPorFarmacoToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // cargarFarmacoToolStripMenuItem
            // 
            this.cargarFarmacoToolStripMenuItem.Name = "cargarFarmacoToolStripMenuItem";
            this.cargarFarmacoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cargarFarmacoToolStripMenuItem.Text = "Cargar farmaco";
            // 
            // buscarProveedorToolStripMenuItem
            // 
            this.buscarProveedorToolStripMenuItem.Name = "buscarProveedorToolStripMenuItem";
            this.buscarProveedorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buscarProveedorToolStripMenuItem.Text = "Buscar proveedor";
            // 
            // nuevoProveedorToolStripMenuItem
            // 
            this.nuevoProveedorToolStripMenuItem.Name = "nuevoProveedorToolStripMenuItem";
            this.nuevoProveedorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoProveedorToolStripMenuItem.Text = "Nuevo proveedor";
            // 
            // verListaProveedorToolStripMenuItem
            // 
            this.verListaProveedorToolStripMenuItem.Name = "verListaProveedorToolStripMenuItem";
            this.verListaProveedorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verListaProveedorToolStripMenuItem.Text = "Ver lista proveedor";
            // 
            // verListaFarmacoToolStripMenuItem
            // 
            this.verListaFarmacoToolStripMenuItem.Name = "verListaFarmacoToolStripMenuItem";
            this.verListaFarmacoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verListaFarmacoToolStripMenuItem.Text = "Ver lista farmaco";
            // 
            // stockPorFarmacoToolStripMenuItem
            // 
            this.stockPorFarmacoToolStripMenuItem.Name = "stockPorFarmacoToolStripMenuItem";
            this.stockPorFarmacoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stockPorFarmacoToolStripMenuItem.Text = "Stock por farmaco";
            // 
            // FormFarmaceu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormFarmaceu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio - Farmaceutico";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMiPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarMiPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarFarmacoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verListaProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verListaFarmacoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockPorFarmacoToolStripMenuItem;
    }
}