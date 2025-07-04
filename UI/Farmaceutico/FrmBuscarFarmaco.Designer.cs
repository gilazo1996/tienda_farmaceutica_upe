namespace UI
{
    partial class FrmBuscarFarmaco
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCodigoBusqueda = new System.Windows.Forms.Label();
            this.txtCodigoBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panelDatosFarmaco = new System.Windows.Forms.Panel();
            this.lblDatosFarmaco = new System.Windows.Forms.Label();
            this.lblCodigoInventario = new System.Windows.Forms.Label();
            this.txtCodigoInventario = new System.Windows.Forms.TextBox();
            this.lblNombreComercial = new System.Windows.Forms.Label();
            this.txtNombreComercial = new System.Windows.Forms.TextBox();
            this.lblPrecioUnidad = new System.Windows.Forms.Label();
            this.txtPrecioUnidad = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.txtFechaVencimiento = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.chkRequiereReceta = new System.Windows.Forms.CheckBox();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelDatosFarmaco.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(187, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Buscar Fármaco";
            // 
            // lblCodigoBusqueda
            // 
            this.lblCodigoBusqueda.AutoSize = true;
            this.lblCodigoBusqueda.Location = new System.Drawing.Point(14, 56);
            this.lblCodigoBusqueda.Name = "lblCodigoBusqueda";
            this.lblCodigoBusqueda.Size = new System.Drawing.Size(108, 13);
            this.lblCodigoBusqueda.TabIndex = 1;
            this.lblCodigoBusqueda.Text = "Código del fármaco:";
            // 
            // txtCodigoBusqueda
            // 
            this.txtCodigoBusqueda.Location = new System.Drawing.Point(128, 53);
            this.txtCodigoBusqueda.Name = "txtCodigoBusqueda";
            this.txtCodigoBusqueda.Size = new System.Drawing.Size(200, 20);
            this.txtCodigoBusqueda.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(334, 51);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(415, 51);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panelDatosFarmaco
            // 
            this.panelDatosFarmaco.Controls.Add(this.chkRequiereReceta);
            this.panelDatosFarmaco.Controls.Add(this.txtProveedor);
            this.panelDatosFarmaco.Controls.Add(this.lblProveedor);
            this.panelDatosFarmaco.Controls.Add(this.txtFechaVencimiento);
            this.panelDatosFarmaco.Controls.Add(this.lblFechaVencimiento);
            this.panelDatosFarmaco.Controls.Add(this.txtStock);
            this.panelDatosFarmaco.Controls.Add(this.lblStock);
            this.panelDatosFarmaco.Controls.Add(this.txtPrecioUnidad);
            this.panelDatosFarmaco.Controls.Add(this.lblPrecioUnidad);
            this.panelDatosFarmaco.Controls.Add(this.txtNombreComercial);
            this.panelDatosFarmaco.Controls.Add(this.lblNombreComercial);
            this.panelDatosFarmaco.Controls.Add(this.txtCodigoInventario);
            this.panelDatosFarmaco.Controls.Add(this.lblCodigoInventario);
            this.panelDatosFarmaco.Controls.Add(this.lblDatosFarmaco);
            this.panelDatosFarmaco.Location = new System.Drawing.Point(17, 95);
            this.panelDatosFarmaco.Name = "panelDatosFarmaco";
            this.panelDatosFarmaco.Size = new System.Drawing.Size(555, 250);
            this.panelDatosFarmaco.TabIndex = 5;
            // 
            // lblDatosFarmaco
            // 
            this.lblDatosFarmaco.AutoSize = true;
            this.lblDatosFarmaco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosFarmaco.Location = new System.Drawing.Point(3, 0);
            this.lblDatosFarmaco.Name = "lblDatosFarmaco";
            this.lblDatosFarmaco.Size = new System.Drawing.Size(156, 20);
            this.lblDatosFarmaco.TabIndex = 0;
            this.lblDatosFarmaco.Text = "Datos del Fármaco";
            // 
            // lblCodigoInventario
            // 
            this.lblCodigoInventario.AutoSize = true;
            this.lblCodigoInventario.Location = new System.Drawing.Point(7, 35);
            this.lblCodigoInventario.Name = "lblCodigoInventario";
            this.lblCodigoInventario.Size = new System.Drawing.Size(103, 13);
            this.lblCodigoInventario.TabIndex = 1;
            this.lblCodigoInventario.Text = "Código Inventario:";
            // 
            // txtCodigoInventario
            // 
            this.txtCodigoInventario.Location = new System.Drawing.Point(116, 32);
            this.txtCodigoInventario.Name = "txtCodigoInventario";
            this.txtCodigoInventario.Size = new System.Drawing.Size(150, 20);
            this.txtCodigoInventario.TabIndex = 2;
            // 
            // lblNombreComercial
            // 
            this.lblNombreComercial.AutoSize = true;
            this.lblNombreComercial.Location = new System.Drawing.Point(7, 65);
            this.lblNombreComercial.Name = "lblNombreComercial";
            this.lblNombreComercial.Size = new System.Drawing.Size(99, 13);
            this.lblNombreComercial.TabIndex = 3;
            this.lblNombreComercial.Text = "Nombre Comercial:";
            // 
            // txtNombreComercial
            // 
            this.txtNombreComercial.Location = new System.Drawing.Point(116, 62);
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.Size = new System.Drawing.Size(300, 20);
            this.txtNombreComercial.TabIndex = 4;
            // 
            // lblPrecioUnidad
            // 
            this.lblPrecioUnidad.AutoSize = true;
            this.lblPrecioUnidad.Location = new System.Drawing.Point(7, 95);
            this.lblPrecioUnidad.Name = "lblPrecioUnidad";
            this.lblPrecioUnidad.Size = new System.Drawing.Size(80, 13);
            this.lblPrecioUnidad.TabIndex = 5;
            this.lblPrecioUnidad.Text = "Precio Unidad:";
            // 
            // txtPrecioUnidad
            // 
            this.txtPrecioUnidad.Location = new System.Drawing.Point(116, 92);
            this.txtPrecioUnidad.Name = "txtPrecioUnidad";
            this.txtPrecioUnidad.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioUnidad.TabIndex = 6;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(280, 95);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(38, 13);
            this.lblStock.TabIndex = 7;
            this.lblStock.Text = "Stock:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(324, 92);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(80, 20);
            this.txtStock.TabIndex = 8;
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(7, 125);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(103, 13);
            this.lblFechaVencimiento.TabIndex = 9;
            this.lblFechaVencimiento.Text = "Fecha Vencimiento:";
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.Location = new System.Drawing.Point(116, 122);
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.Size = new System.Drawing.Size(100, 20);
            this.txtFechaVencimiento.TabIndex = 10;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(7, 155);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(59, 13);
            this.lblProveedor.TabIndex = 11;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(116, 152);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(300, 20);
            this.txtProveedor.TabIndex = 12;
            // 
            // chkRequiereReceta
            // 
            this.chkRequiereReceta.AutoSize = true;
            this.chkRequiereReceta.Location = new System.Drawing.Point(116, 185);
            this.chkRequiereReceta.Name = "chkRequiereReceta";
            this.chkRequiereReceta.Size = new System.Drawing.Size(108, 17);
            this.chkRequiereReceta.TabIndex = 13;
            this.chkRequiereReceta.Text = "Requiere Receta";
            this.chkRequiereReceta.UseVisualStyleBackColor = true;
            // 
            // panelBotones
            // 
            this.panelBotones.Controls.Add(this.btnSalir);
            this.panelBotones.Controls.Add(this.btnEliminar);
            this.panelBotones.Controls.Add(this.btnEditar);
            this.panelBotones.Location = new System.Drawing.Point(17, 360);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(555, 50);
            this.panelBotones.TabIndex = 6;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Orange;
            this.btnEditar.Location = new System.Drawing.Point(150, 15);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 30);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(270, 15);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(450, 15);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 30);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmBuscarFarmaco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 422);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.panelDatosFarmaco);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodigoBusqueda);
            this.Controls.Add(this.lblCodigoBusqueda);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmBuscarFarmaco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Fármaco - FarmaSalud";
            this.panelDatosFarmaco.ResumeLayout(false);
            this.panelDatosFarmaco.PerformLayout();
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigoBusqueda;
        private System.Windows.Forms.TextBox txtCodigoBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel panelDatosFarmaco;
        private System.Windows.Forms.CheckBox chkRequiereReceta;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtFechaVencimiento;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtPrecioUnidad;
        private System.Windows.Forms.Label lblPrecioUnidad;
        private System.Windows.Forms.TextBox txtNombreComercial;
        private System.Windows.Forms.Label lblNombreComercial;
        private System.Windows.Forms.TextBox txtCodigoInventario;
        private System.Windows.Forms.Label lblCodigoInventario;
        private System.Windows.Forms.Label lblDatosFarmaco;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
    }
}
