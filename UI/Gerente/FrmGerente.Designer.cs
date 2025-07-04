namespace FarmaSalud
{
    partial class FrmGerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGerente));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.msMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.gestionarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVisualizarVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGenerarReporte = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVisualizarSolicitudes = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarVendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarVendedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarVendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVerMiPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBienvenida = new System.Windows.Forms.Panel();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.pnlVisualizarVentas = new System.Windows.Forms.Panel();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.lblDetallesFactura = new System.Windows.Forms.Label();
            this.lblListadeFacturas = new System.Windows.Forms.Label();
            this.lblListaDeUsuarios = new System.Windows.Forms.Label();
            this.dgvDetalleFactura = new System.Windows.Forms.DataGridView();
            this.pnlVisualizarSolicitudes = new System.Windows.Forms.Panel();
            this.btnRechazarSolicitud = new System.Windows.Forms.Button();
            this.btnAceptarSolicitud = new System.Windows.Forms.Button();
            this.dgvSolicitudes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVisualizarSolicitudes = new System.Windows.Forms.Label();
            this.dgvDetalleSolicitud = new System.Windows.Forms.DataGridView();
            this.pnlGenerarReporte = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.btnBuscarFacturas = new System.Windows.Forms.Button();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblGenerarReporte = new System.Windows.Forms.Label();
            this.lblFacturasEncontradas = new System.Windows.Forms.Label();
            this.dgvFacturasEncontradas = new System.Windows.Forms.DataGridView();
            this.msMenuPrincipal.SuspendLayout();
            this.pnlBienvenida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.pnlVisualizarVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).BeginInit();
            this.pnlVisualizarSolicitudes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleSolicitud)).BeginInit();
            this.pnlGenerarReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturasEncontradas)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenuPrincipal
            // 
            this.msMenuPrincipal.BackColor = System.Drawing.Color.LightGray;
            this.msMenuPrincipal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarVentasToolStripMenuItem,
            this.gestionarVendedoresToolStripMenuItem,
            this.tsmiSesion});
            this.msMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msMenuPrincipal.Name = "msMenuPrincipal";
            this.msMenuPrincipal.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.msMenuPrincipal.Size = new System.Drawing.Size(961, 29);
            this.msMenuPrincipal.TabIndex = 0;
            // 
            // gestionarVentasToolStripMenuItem
            // 
            this.gestionarVentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVisualizarVentas,
            this.tsmiGenerarReporte,
            this.tsmiVisualizarSolicitudes});
            this.gestionarVentasToolStripMenuItem.Name = "gestionarVentasToolStripMenuItem";
            this.gestionarVentasToolStripMenuItem.Size = new System.Drawing.Size(117, 21);
            this.gestionarVentasToolStripMenuItem.Text = "Gestionar ventas";
            // 
            // tsmiVisualizarVentas
            // 
            this.tsmiVisualizarVentas.Name = "tsmiVisualizarVentas";
            this.tsmiVisualizarVentas.Size = new System.Drawing.Size(250, 22);
            this.tsmiVisualizarVentas.Text = "Visualizar ventas";
            this.tsmiVisualizarVentas.Click += new System.EventHandler(this.tsmiVisualizarVentas_Click);
            // 
            // tsmiGenerarReporte
            // 
            this.tsmiGenerarReporte.Name = "tsmiGenerarReporte";
            this.tsmiGenerarReporte.Size = new System.Drawing.Size(250, 22);
            this.tsmiGenerarReporte.Text = "Generar reporte de ventas";
            this.tsmiGenerarReporte.Click += new System.EventHandler(this.tsmiGenerarReporte_Click);
            // 
            // tsmiVisualizarSolicitudes
            // 
            this.tsmiVisualizarSolicitudes.Name = "tsmiVisualizarSolicitudes";
            this.tsmiVisualizarSolicitudes.Size = new System.Drawing.Size(250, 22);
            this.tsmiVisualizarSolicitudes.Text = "Visualizar solicitudes de venta";
            this.tsmiVisualizarSolicitudes.Click += new System.EventHandler(this.tsmiVisualizarSolicitudes_Click);
            // 
            // gestionarVendedoresToolStripMenuItem
            // 
            this.gestionarVendedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarVendedorToolStripMenuItem,
            this.visualizarVendedoresToolStripMenuItem});
            this.gestionarVendedoresToolStripMenuItem.Name = "gestionarVendedoresToolStripMenuItem";
            this.gestionarVendedoresToolStripMenuItem.Size = new System.Drawing.Size(149, 21);
            this.gestionarVendedoresToolStripMenuItem.Text = "Gestionar vendedores";
            // 
            // buscarVendedorToolStripMenuItem
            // 
            this.buscarVendedorToolStripMenuItem.Name = "buscarVendedorToolStripMenuItem";
            this.buscarVendedorToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.buscarVendedorToolStripMenuItem.Text = "Buscar vendedor";
            // 
            // visualizarVendedoresToolStripMenuItem
            // 
            this.visualizarVendedoresToolStripMenuItem.Name = "visualizarVendedoresToolStripMenuItem";
            this.visualizarVendedoresToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.visualizarVendedoresToolStripMenuItem.Text = "Visualizar vendedores";
            // 
            // tsmiSesion
            // 
            this.tsmiSesion.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiSesion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVerMiPerfil,
            this.tsmiCerrarSesion});
            this.tsmiSesion.Name = "tsmiSesion";
            this.tsmiSesion.Size = new System.Drawing.Size(58, 21);
            this.tsmiSesion.Text = "Sesión";
            // 
            // tsmiVerMiPerfil
            // 
            this.tsmiVerMiPerfil.Name = "tsmiVerMiPerfil";
            this.tsmiVerMiPerfil.Size = new System.Drawing.Size(154, 22);
            this.tsmiVerMiPerfil.Text = "Ver mi perfil";
            // 
            // tsmiCerrarSesion
            // 
            this.tsmiCerrarSesion.Name = "tsmiCerrarSesion";
            this.tsmiCerrarSesion.Size = new System.Drawing.Size(154, 22);
            this.tsmiCerrarSesion.Text = "Cerrar sesión";
            this.tsmiCerrarSesion.Click += new System.EventHandler(this.tsmiCerrarSesion_Click);
            // 
            // pnlBienvenida
            // 
            this.pnlBienvenida.AutoSize = true;
            this.pnlBienvenida.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnlBienvenida.Controls.Add(this.lblBienvenida);
            this.pnlBienvenida.Controls.Add(this.lblTitulo);
            this.pnlBienvenida.Controls.Add(this.pboxLogo);
            this.pnlBienvenida.Location = new System.Drawing.Point(0, 0);
            this.pnlBienvenida.Name = "pnlBienvenida";
            this.pnlBienvenida.Size = new System.Drawing.Size(264, 331);
            this.pnlBienvenida.TabIndex = 1;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(21, 260);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(0, 31);
            this.lblBienvenida.TabIndex = 21;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitulo.Font = new System.Drawing.Font("Myanmar Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblTitulo.Location = new System.Drawing.Point(39, 200);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(184, 51);
            this.lblTitulo.TabIndex = 23;
            this.lblTitulo.Text = "FarmaSalud";
            // 
            // pboxLogo
            // 
            this.pboxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pboxLogo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pboxLogo.Image")));
            this.pboxLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pboxLogo.InitialImage")));
            this.pboxLogo.Location = new System.Drawing.Point(57, 51);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(147, 141);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxLogo.TabIndex = 22;
            this.pboxLogo.TabStop = false;
            // 
            // pnlVisualizarVentas
            // 
            this.pnlVisualizarVentas.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnlVisualizarVentas.Controls.Add(this.dgvFacturas);
            this.pnlVisualizarVentas.Controls.Add(this.lblDetallesFactura);
            this.pnlVisualizarVentas.Controls.Add(this.lblListadeFacturas);
            this.pnlVisualizarVentas.Controls.Add(this.lblListaDeUsuarios);
            this.pnlVisualizarVentas.Controls.Add(this.dgvDetalleFactura);
            this.pnlVisualizarVentas.Location = new System.Drawing.Point(0, 0);
            this.pnlVisualizarVentas.Name = "pnlVisualizarVentas";
            this.pnlVisualizarVentas.Size = new System.Drawing.Size(954, 525);
            this.pnlVisualizarVentas.TabIndex = 3;
            this.pnlVisualizarVentas.Visible = false;
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.AllowUserToResizeColumns = false;
            this.dgvFacturas.AllowUserToResizeRows = false;
            this.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvFacturas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Location = new System.Drawing.Point(12, 69);
            this.dgvFacturas.MultiSelect = false;
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturas.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvFacturas.RowHeadersWidth = 45;
            this.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturas.Size = new System.Drawing.Size(930, 241);
            this.dgvFacturas.TabIndex = 16;
            this.dgvFacturas.SelectionChanged += new System.EventHandler(this.dgvFacturas_SelectionChanged);
            // 
            // lblDetallesFactura
            // 
            this.lblDetallesFactura.AutoSize = true;
            this.lblDetallesFactura.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblDetallesFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetallesFactura.Location = new System.Drawing.Point(12, 325);
            this.lblDetallesFactura.Name = "lblDetallesFactura";
            this.lblDetallesFactura.Size = new System.Drawing.Size(191, 25);
            this.lblDetallesFactura.TabIndex = 15;
            this.lblDetallesFactura.Text = "Detalle de la venta";
            // 
            // lblListadeFacturas
            // 
            this.lblListadeFacturas.AutoSize = true;
            this.lblListadeFacturas.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblListadeFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadeFacturas.Location = new System.Drawing.Point(12, 41);
            this.lblListadeFacturas.Name = "lblListadeFacturas";
            this.lblListadeFacturas.Size = new System.Drawing.Size(158, 25);
            this.lblListadeFacturas.TabIndex = 13;
            this.lblListadeFacturas.Text = "Lista de ventas";
            // 
            // lblListaDeUsuarios
            // 
            this.lblListaDeUsuarios.AutoSize = true;
            this.lblListaDeUsuarios.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblListaDeUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaDeUsuarios.Location = new System.Drawing.Point(-109, -2);
            this.lblListaDeUsuarios.Name = "lblListaDeUsuarios";
            this.lblListaDeUsuarios.Size = new System.Drawing.Size(176, 25);
            this.lblListaDeUsuarios.TabIndex = 12;
            this.lblListaDeUsuarios.Text = "Lista de usuarios";
            // 
            // dgvDetalleFactura
            // 
            this.dgvDetalleFactura.AllowUserToAddRows = false;
            this.dgvDetalleFactura.AllowUserToDeleteRows = false;
            this.dgvDetalleFactura.AllowUserToResizeColumns = false;
            this.dgvDetalleFactura.AllowUserToResizeRows = false;
            this.dgvDetalleFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleFactura.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvDetalleFactura.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleFactura.Location = new System.Drawing.Point(12, 353);
            this.dgvDetalleFactura.MultiSelect = false;
            this.dgvDetalleFactura.Name = "dgvDetalleFactura";
            this.dgvDetalleFactura.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleFactura.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDetalleFactura.RowHeadersWidth = 45;
            this.dgvDetalleFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleFactura.Size = new System.Drawing.Size(930, 148);
            this.dgvDetalleFactura.TabIndex = 14;
            // 
            // pnlVisualizarSolicitudes
            // 
            this.pnlVisualizarSolicitudes.AutoSize = true;
            this.pnlVisualizarSolicitudes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlVisualizarSolicitudes.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnlVisualizarSolicitudes.Controls.Add(this.btnRechazarSolicitud);
            this.pnlVisualizarSolicitudes.Controls.Add(this.btnAceptarSolicitud);
            this.pnlVisualizarSolicitudes.Controls.Add(this.dgvSolicitudes);
            this.pnlVisualizarSolicitudes.Controls.Add(this.label1);
            this.pnlVisualizarSolicitudes.Controls.Add(this.lblVisualizarSolicitudes);
            this.pnlVisualizarSolicitudes.Controls.Add(this.dgvDetalleSolicitud);
            this.pnlVisualizarSolicitudes.Location = new System.Drawing.Point(0, 0);
            this.pnlVisualizarSolicitudes.Name = "pnlVisualizarSolicitudes";
            this.pnlVisualizarSolicitudes.Size = new System.Drawing.Size(945, 539);
            this.pnlVisualizarSolicitudes.TabIndex = 4;
            this.pnlVisualizarSolicitudes.Visible = false;
            // 
            // btnRechazarSolicitud
            // 
            this.btnRechazarSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechazarSolicitud.Location = new System.Drawing.Point(12, 507);
            this.btnRechazarSolicitud.Name = "btnRechazarSolicitud";
            this.btnRechazarSolicitud.Size = new System.Drawing.Size(149, 29);
            this.btnRechazarSolicitud.TabIndex = 22;
            this.btnRechazarSolicitud.Text = "Rechazar solicitud";
            this.btnRechazarSolicitud.UseVisualStyleBackColor = true;
            // 
            // btnAceptarSolicitud
            // 
            this.btnAceptarSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarSolicitud.Location = new System.Drawing.Point(793, 507);
            this.btnAceptarSolicitud.Name = "btnAceptarSolicitud";
            this.btnAceptarSolicitud.Size = new System.Drawing.Size(149, 29);
            this.btnAceptarSolicitud.TabIndex = 21;
            this.btnAceptarSolicitud.Text = "Aceptar solicitud";
            this.btnAceptarSolicitud.UseVisualStyleBackColor = true;
            // 
            // dgvSolicitudes
            // 
            this.dgvSolicitudes.AllowUserToAddRows = false;
            this.dgvSolicitudes.AllowUserToDeleteRows = false;
            this.dgvSolicitudes.AllowUserToResizeColumns = false;
            this.dgvSolicitudes.AllowUserToResizeRows = false;
            this.dgvSolicitudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSolicitudes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvSolicitudes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSolicitudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudes.Location = new System.Drawing.Point(12, 69);
            this.dgvSolicitudes.MultiSelect = false;
            this.dgvSolicitudes.Name = "dgvSolicitudes";
            this.dgvSolicitudes.ReadOnly = true;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSolicitudes.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvSolicitudes.RowHeadersWidth = 45;
            this.dgvSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSolicitudes.Size = new System.Drawing.Size(930, 241);
            this.dgvSolicitudes.TabIndex = 20;
            this.dgvSolicitudes.SelectionChanged += new System.EventHandler(this.dgvSolicitudes_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Detalle de la solicitud";
            // 
            // lblVisualizarSolicitudes
            // 
            this.lblVisualizarSolicitudes.AutoSize = true;
            this.lblVisualizarSolicitudes.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblVisualizarSolicitudes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualizarSolicitudes.Location = new System.Drawing.Point(12, 41);
            this.lblVisualizarSolicitudes.Name = "lblVisualizarSolicitudes";
            this.lblVisualizarSolicitudes.Size = new System.Drawing.Size(196, 25);
            this.lblVisualizarSolicitudes.TabIndex = 17;
            this.lblVisualizarSolicitudes.Text = "Lista de solicitudes";
            // 
            // dgvDetalleSolicitud
            // 
            this.dgvDetalleSolicitud.AllowUserToAddRows = false;
            this.dgvDetalleSolicitud.AllowUserToDeleteRows = false;
            this.dgvDetalleSolicitud.AllowUserToResizeColumns = false;
            this.dgvDetalleSolicitud.AllowUserToResizeRows = false;
            this.dgvDetalleSolicitud.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalleSolicitud.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvDetalleSolicitud.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDetalleSolicitud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleSolicitud.Location = new System.Drawing.Point(12, 353);
            this.dgvDetalleSolicitud.MultiSelect = false;
            this.dgvDetalleSolicitud.Name = "dgvDetalleSolicitud";
            this.dgvDetalleSolicitud.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleSolicitud.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvDetalleSolicitud.RowHeadersWidth = 45;
            this.dgvDetalleSolicitud.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleSolicitud.Size = new System.Drawing.Size(930, 145);
            this.dgvDetalleSolicitud.TabIndex = 18;
            // 
            // pnlGenerarReporte
            // 
            this.pnlGenerarReporte.AutoSize = true;
            this.pnlGenerarReporte.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlGenerarReporte.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnlGenerarReporte.Controls.Add(this.btnCancelar);
            this.pnlGenerarReporte.Controls.Add(this.dtpFechaFin);
            this.pnlGenerarReporte.Controls.Add(this.dtpFechaInicio);
            this.pnlGenerarReporte.Controls.Add(this.btnGenerarReporte);
            this.pnlGenerarReporte.Controls.Add(this.btnBuscarFacturas);
            this.pnlGenerarReporte.Controls.Add(this.lblFechaFin);
            this.pnlGenerarReporte.Controls.Add(this.lblFechaInicio);
            this.pnlGenerarReporte.Controls.Add(this.lblGenerarReporte);
            this.pnlGenerarReporte.Controls.Add(this.lblFacturasEncontradas);
            this.pnlGenerarReporte.Controls.Add(this.dgvFacturasEncontradas);
            this.pnlGenerarReporte.Location = new System.Drawing.Point(0, 0);
            this.pnlGenerarReporte.Name = "pnlGenerarReporte";
            this.pnlGenerarReporte.Size = new System.Drawing.Size(566, 424);
            this.pnlGenerarReporte.TabIndex = 5;
            this.pnlGenerarReporte.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(12, 389);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 29);
            this.btnCancelar.TabIndex = 66;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CustomFormat = "";
            this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Location = new System.Drawing.Point(122, 120);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(257, 22);
            this.dtpFechaFin.TabIndex = 65;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Location = new System.Drawing.Point(122, 91);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(257, 22);
            this.dtpFechaInicio.TabIndex = 64;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReporte.Location = new System.Drawing.Point(432, 392);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(131, 29);
            this.btnGenerarReporte.TabIndex = 63;
            this.btnGenerarReporte.Text = "Generar reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Visible = false;
            // 
            // btnBuscarFacturas
            // 
            this.btnBuscarFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFacturas.Location = new System.Drawing.Point(312, 163);
            this.btnBuscarFacturas.Name = "btnBuscarFacturas";
            this.btnBuscarFacturas.Size = new System.Drawing.Size(131, 29);
            this.btnBuscarFacturas.TabIndex = 62;
            this.btnBuscarFacturas.Text = "Buscar facturas";
            this.btnBuscarFacturas.UseVisualStyleBackColor = true;
            this.btnBuscarFacturas.Click += new System.EventHandler(this.btnBuscarFacturas_Click);
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.Location = new System.Drawing.Point(24, 124);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(61, 16);
            this.lblFechaFin.TabIndex = 60;
            this.lblFechaFin.Text = "Fecha fin";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.Location = new System.Drawing.Point(24, 96);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(79, 16);
            this.lblFechaInicio.TabIndex = 58;
            this.lblFechaInicio.Text = "Fecha inicio";
            // 
            // lblGenerarReporte
            // 
            this.lblGenerarReporte.AutoSize = true;
            this.lblGenerarReporte.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblGenerarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerarReporte.Location = new System.Drawing.Point(12, 51);
            this.lblGenerarReporte.Name = "lblGenerarReporte";
            this.lblGenerarReporte.Size = new System.Drawing.Size(164, 25);
            this.lblGenerarReporte.TabIndex = 22;
            this.lblGenerarReporte.Text = "Generar reporte";
            // 
            // lblFacturasEncontradas
            // 
            this.lblFacturasEncontradas.AutoSize = true;
            this.lblFacturasEncontradas.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblFacturasEncontradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacturasEncontradas.Location = new System.Drawing.Point(12, 210);
            this.lblFacturasEncontradas.Name = "lblFacturasEncontradas";
            this.lblFacturasEncontradas.Size = new System.Drawing.Size(221, 25);
            this.lblFacturasEncontradas.TabIndex = 21;
            this.lblFacturasEncontradas.Text = "Facturas encontradas";
            this.lblFacturasEncontradas.Visible = false;
            // 
            // dgvFacturasEncontradas
            // 
            this.dgvFacturasEncontradas.AllowUserToAddRows = false;
            this.dgvFacturasEncontradas.AllowUserToDeleteRows = false;
            this.dgvFacturasEncontradas.AllowUserToResizeColumns = false;
            this.dgvFacturasEncontradas.AllowUserToResizeRows = false;
            this.dgvFacturasEncontradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturasEncontradas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvFacturasEncontradas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvFacturasEncontradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturasEncontradas.Location = new System.Drawing.Point(12, 238);
            this.dgvFacturasEncontradas.MultiSelect = false;
            this.dgvFacturasEncontradas.Name = "dgvFacturasEncontradas";
            this.dgvFacturasEncontradas.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturasEncontradas.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvFacturasEncontradas.RowHeadersWidth = 45;
            this.dgvFacturasEncontradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturasEncontradas.Size = new System.Drawing.Size(551, 145);
            this.dgvFacturasEncontradas.TabIndex = 20;
            this.dgvFacturasEncontradas.Visible = false;
            // 
            // FrmGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(961, 547);
            this.Controls.Add(this.msMenuPrincipal);
            this.Controls.Add(this.pnlGenerarReporte);
            this.Controls.Add(this.pnlVisualizarSolicitudes);
            this.Controls.Add(this.pnlVisualizarVentas);
            this.Controls.Add(this.pnlBienvenida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenuPrincipal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGerente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGerente_FormClosed);
            this.msMenuPrincipal.ResumeLayout(false);
            this.msMenuPrincipal.PerformLayout();
            this.pnlBienvenida.ResumeLayout(false);
            this.pnlBienvenida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.pnlVisualizarVentas.ResumeLayout(false);
            this.pnlVisualizarVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).EndInit();
            this.pnlVisualizarSolicitudes.ResumeLayout(false);
            this.pnlVisualizarSolicitudes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleSolicitud)).EndInit();
            this.pnlGenerarReporte.ResumeLayout(false);
            this.pnlGenerarReporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturasEncontradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem gestionarVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarVendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiVisualizarVentas;
        private System.Windows.Forms.ToolStripMenuItem tsmiGenerarReporte;
        private System.Windows.Forms.ToolStripMenuItem tsmiVisualizarSolicitudes;
        private System.Windows.Forms.ToolStripMenuItem buscarVendedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarVendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSesion;
        private System.Windows.Forms.ToolStripMenuItem tsmiVerMiPerfil;
        private System.Windows.Forms.ToolStripMenuItem tsmiCerrarSesion;
        private System.Windows.Forms.Panel pnlBienvenida;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.Panel pnlVisualizarVentas;
        private System.Windows.Forms.Label lblListaDeUsuarios;
        private System.Windows.Forms.Label lblListadeFacturas;
        private System.Windows.Forms.Label lblDetallesFactura;
        private System.Windows.Forms.DataGridView dgvDetalleFactura;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Panel pnlVisualizarSolicitudes;
        private System.Windows.Forms.DataGridView dgvSolicitudes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVisualizarSolicitudes;
        private System.Windows.Forms.DataGridView dgvDetalleSolicitud;
        private System.Windows.Forms.Button btnRechazarSolicitud;
        private System.Windows.Forms.Button btnAceptarSolicitud;
        private System.Windows.Forms.Panel pnlGenerarReporte;
        private System.Windows.Forms.Label lblGenerarReporte;
        private System.Windows.Forms.Label lblFacturasEncontradas;
        private System.Windows.Forms.DataGridView dgvFacturasEncontradas;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.Button btnBuscarFacturas;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Button btnCancelar;
    }
}