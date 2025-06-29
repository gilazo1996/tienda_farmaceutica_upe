
namespace FarmaSalud
{
    partial class FrmFarmaceutico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFarmaceutico));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.miPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVerPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCerrarSesión = new System.Windows.Forms.ToolStripMenuItem();
            this.tstboxBienvenida = new System.Windows.Forms.ToolStripTextBox();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farmacosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarFarmacoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarFarmacoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verListaDeFarmacosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verListaDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPerfilToolStripMenuItem,
            this.tstboxBienvenida,
            this.proveedoresToolStripMenuItem,
            this.farmacosToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 33);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // miPerfilToolStripMenuItem
            // 
            this.miPerfilToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.miPerfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVerPerfil,
            this.tsmiCerrarSesión});
            this.miPerfilToolStripMenuItem.Name = "miPerfilToolStripMenuItem";
            this.miPerfilToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.miPerfilToolStripMenuItem.Text = "Mi Perfil";
            // 
            // tsmiVerPerfil
            // 
            this.tsmiVerPerfil.Name = "tsmiVerPerfil";
            this.tsmiVerPerfil.Size = new System.Drawing.Size(180, 26);
            this.tsmiVerPerfil.Text = "Ver Perfil";
            // 
            // tsmiCerrarSesión
            // 
            this.tsmiCerrarSesión.Name = "tsmiCerrarSesión";
            this.tsmiCerrarSesión.Size = new System.Drawing.Size(180, 26);
            this.tsmiCerrarSesión.Text = "Cerrar Sesión";
            this.tsmiCerrarSesión.Click += new System.EventHandler(this.tsmiCerrarSesión_Click);
            // 
            // tstboxBienvenida
            // 
            this.tstboxBienvenida.BackColor = System.Drawing.SystemColors.Control;
            this.tstboxBienvenida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstboxBienvenida.Name = "tstboxBienvenida";
            this.tstboxBienvenida.Size = new System.Drawing.Size(250, 29);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarProveedorToolStripMenuItem,
            this.agregarProveedorToolStripMenuItem,
            this.verListaDeProveedoresToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // farmacosToolStripMenuItem
            // 
            this.farmacosToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.farmacosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarFarmacoToolStripMenuItem,
            this.agregarFarmacoToolStripMenuItem,
            this.verListaDeFarmacosToolStripMenuItem});
            this.farmacosToolStripMenuItem.Name = "farmacosToolStripMenuItem";
            this.farmacosToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.farmacosToolStripMenuItem.Text = "Farmacos";
            // 
            // buscarFarmacoToolStripMenuItem
            // 
            this.buscarFarmacoToolStripMenuItem.Name = "buscarFarmacoToolStripMenuItem";
            this.buscarFarmacoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.buscarFarmacoToolStripMenuItem.Text = "Buscar farmaco";
            // 
            // agregarFarmacoToolStripMenuItem
            // 
            this.agregarFarmacoToolStripMenuItem.Name = "agregarFarmacoToolStripMenuItem";
            this.agregarFarmacoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.agregarFarmacoToolStripMenuItem.Text = "Agregar farmaco";
            this.agregarFarmacoToolStripMenuItem.Click += new System.EventHandler(this.agregarFarmacoToolStripMenuItem_Click);
            // 
            // verListaDeFarmacosToolStripMenuItem
            // 
            this.verListaDeFarmacosToolStripMenuItem.Name = "verListaDeFarmacosToolStripMenuItem";
            this.verListaDeFarmacosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.verListaDeFarmacosToolStripMenuItem.Text = "Ver lista de farmacos";
            // 
            // buscarProveedorToolStripMenuItem
            // 
            this.buscarProveedorToolStripMenuItem.Name = "buscarProveedorToolStripMenuItem";
            this.buscarProveedorToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.buscarProveedorToolStripMenuItem.Text = "Buscar proveedor";
            // 
            // agregarProveedorToolStripMenuItem
            // 
            this.agregarProveedorToolStripMenuItem.Name = "agregarProveedorToolStripMenuItem";
            this.agregarProveedorToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.agregarProveedorToolStripMenuItem.Text = "Agregar proveedor";
            // 
            // verListaDeProveedoresToolStripMenuItem
            // 
            this.verListaDeProveedoresToolStripMenuItem.Name = "verListaDeProveedoresToolStripMenuItem";
            this.verListaDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.verListaDeProveedoresToolStripMenuItem.Text = "Ver lista de proveedores";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 292);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmFarmaceutico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmFarmaceutico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFarmaceutico";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmFarmaceutico_FormClosed);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem miPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiVerPerfil;
        private System.Windows.Forms.ToolStripMenuItem tsmiCerrarSesión;
        private System.Windows.Forms.ToolStripTextBox tstboxBienvenida;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farmacosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verListaDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarFarmacoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarFarmacoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verListaDeFarmacosToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}