namespace FarmaSalud
{
    partial class FrmAdministrador
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVerPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCerrarSesión = new System.Windows.Forms.ToolStripMenuItem();
            this.tstboxBienvenida = new System.Windows.Forms.ToolStripTextBox();
            this.lblBuscarUsuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.tboxBuscarNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblBuscarNombreUsuario = new System.Windows.Forms.Label();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnVisualizarListaUsuarios = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.lblListaDeUsuarios = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnCambiarRol = new System.Windows.Forms.Button();
            this.cboxRol = new System.Windows.Forms.ComboBox();
            this.tboxTelefono = new System.Windows.Forms.TextBox();
            this.tboxEmail = new System.Windows.Forms.TextBox();
            this.tboxCUIL = new System.Windows.Forms.TextBox();
            this.tboxContraseña = new System.Windows.Forms.TextBox();
            this.tboxNombreUsuario = new System.Windows.Forms.TextBox();
            this.tboxApellido = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTeléfono = new System.Windows.Forms.Label();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.lblCUIL = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnConfirmarCambios = new System.Windows.Forms.Button();
            this.btnCancelarCambios = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPerfilToolStripMenuItem,
            this.tstboxBienvenida});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1456, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.tsmiVerPerfil.Size = new System.Drawing.Size(174, 26);
            this.tsmiVerPerfil.Text = "Ver Perfil";
            // 
            // tsmiCerrarSesión
            // 
            this.tsmiCerrarSesión.Name = "tsmiCerrarSesión";
            this.tsmiCerrarSesión.Size = new System.Drawing.Size(174, 26);
            this.tsmiCerrarSesión.Text = "Cerrar Sesión";
            this.tsmiCerrarSesión.Click += new System.EventHandler(this.tsmiCerrarSesión_Click);
            // 
            // tstboxBienvenida
            // 
            this.tstboxBienvenida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstboxBienvenida.Name = "tstboxBienvenida";
            this.tstboxBienvenida.Size = new System.Drawing.Size(250, 29);
            // 
            // lblBuscarUsuario
            // 
            this.lblBuscarUsuario.AutoSize = true;
            this.lblBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarUsuario.Location = new System.Drawing.Point(12, 11);
            this.lblBuscarUsuario.Name = "lblBuscarUsuario";
            this.lblBuscarUsuario.Size = new System.Drawing.Size(156, 25);
            this.lblBuscarUsuario.TabIndex = 3;
            this.lblBuscarUsuario.Text = "Buscar usuario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.btnBuscarUsuario);
            this.panel1.Controls.Add(this.tboxBuscarNombreUsuario);
            this.panel1.Controls.Add(this.lblBuscarNombreUsuario);
            this.panel1.Controls.Add(this.lblBuscarUsuario);
            this.panel1.Location = new System.Drawing.Point(908, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 158);
            this.panel1.TabIndex = 4;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUsuario.Location = new System.Drawing.Point(385, 108);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(131, 29);
            this.btnBuscarUsuario.TabIndex = 5;
            this.btnBuscarUsuario.Text = "Buscar usuario";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // tboxBuscarNombreUsuario
            // 
            this.tboxBuscarNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxBuscarNombreUsuario.Location = new System.Drawing.Point(168, 66);
            this.tboxBuscarNombreUsuario.Name = "tboxBuscarNombreUsuario";
            this.tboxBuscarNombreUsuario.Size = new System.Drawing.Size(192, 22);
            this.tboxBuscarNombreUsuario.TabIndex = 5;
            this.tboxBuscarNombreUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxNombreUsuario_KeyDown);
            // 
            // lblBuscarNombreUsuario
            // 
            this.lblBuscarNombreUsuario.AutoSize = true;
            this.lblBuscarNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarNombreUsuario.Location = new System.Drawing.Point(17, 69);
            this.lblBuscarNombreUsuario.Name = "lblBuscarNombreUsuario";
            this.lblBuscarNombreUsuario.Size = new System.Drawing.Size(122, 16);
            this.lblBuscarNombreUsuario.TabIndex = 4;
            this.lblBuscarNombreUsuario.Text = "Nombre de usuario";
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Location = new System.Drawing.Point(385, 113);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(131, 29);
            this.btnEliminarUsuario.TabIndex = 7;
            this.btnEliminarUsuario.Text = "Eliminar usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Visible = false;
            // 
            // btnVisualizarListaUsuarios
            // 
            this.btnVisualizarListaUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarListaUsuarios.Location = new System.Drawing.Point(649, 451);
            this.btnVisualizarListaUsuarios.Name = "btnVisualizarListaUsuarios";
            this.btnVisualizarListaUsuarios.Size = new System.Drawing.Size(230, 29);
            this.btnVisualizarListaUsuarios.TabIndex = 7;
            this.btnVisualizarListaUsuarios.Text = "Visualizar lista de usuarios";
            this.btnVisualizarListaUsuarios.UseVisualStyleBackColor = true;
            this.btnVisualizarListaUsuarios.Click += new System.EventHandler(this.btnVisualizarListaUsuarios_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(8, 39);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.RowHeadersWidth = 45;
            this.dgvUsuarios.Size = new System.Drawing.Size(871, 406);
            this.dgvUsuarios.TabIndex = 6;
            // 
            // lblListaDeUsuarios
            // 
            this.lblListaDeUsuarios.AutoSize = true;
            this.lblListaDeUsuarios.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblListaDeUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaDeUsuarios.Location = new System.Drawing.Point(3, 11);
            this.lblListaDeUsuarios.Name = "lblListaDeUsuarios";
            this.lblListaDeUsuarios.Size = new System.Drawing.Size(176, 25);
            this.lblListaDeUsuarios.TabIndex = 9;
            this.lblListaDeUsuarios.Text = "Lista de usuarios";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.btnVisualizarListaUsuarios);
            this.panel2.Controls.Add(this.lblListaDeUsuarios);
            this.panel2.Controls.Add(this.dgvUsuarios);
            this.panel2.Location = new System.Drawing.Point(12, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(890, 500);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel3.Controls.Add(this.btnCancelarCambios);
            this.panel3.Controls.Add(this.btnConfirmarCambios);
            this.panel3.Controls.Add(this.btnAgregarUsuario);
            this.panel3.Controls.Add(this.btnLimpiarCampos);
            this.panel3.Controls.Add(this.btnCambiarRol);
            this.panel3.Controls.Add(this.cboxRol);
            this.panel3.Controls.Add(this.tboxTelefono);
            this.panel3.Controls.Add(this.tboxEmail);
            this.panel3.Controls.Add(this.tboxCUIL);
            this.panel3.Controls.Add(this.tboxContraseña);
            this.panel3.Controls.Add(this.tboxNombreUsuario);
            this.panel3.Controls.Add(this.tboxApellido);
            this.panel3.Controls.Add(this.lblRol);
            this.panel3.Controls.Add(this.lblEmail);
            this.panel3.Controls.Add(this.lblTeléfono);
            this.panel3.Controls.Add(this.tboxNombre);
            this.panel3.Controls.Add(this.lblCUIL);
            this.panel3.Controls.Add(this.lblContraseña);
            this.panel3.Controls.Add(this.lblNombreUsuario);
            this.panel3.Controls.Add(this.lblApellido);
            this.panel3.Controls.Add(this.lblNombre);
            this.panel3.Controls.Add(this.btnEliminarUsuario);
            this.panel3.Controls.Add(this.btnEditarUsuario);
            this.panel3.Location = new System.Drawing.Point(908, 196);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(536, 336);
            this.panel3.TabIndex = 10;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarCampos.Location = new System.Drawing.Point(385, 183);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(131, 29);
            this.btnLimpiarCampos.TabIndex = 24;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Visible = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnCambiarRol
            // 
            this.btnCambiarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarRol.Location = new System.Drawing.Point(385, 148);
            this.btnCambiarRol.Name = "btnCambiarRol";
            this.btnCambiarRol.Size = new System.Drawing.Size(131, 29);
            this.btnCambiarRol.TabIndex = 23;
            this.btnCambiarRol.Text = "Cambiar rol";
            this.btnCambiarRol.UseVisualStyleBackColor = true;
            this.btnCambiarRol.Visible = false;
            // 
            // cboxRol
            // 
            this.cboxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxRol.FormattingEnabled = true;
            this.cboxRol.Items.AddRange(new object[] {
            "Administrador",
            "Farmacéutico",
            "Gerente",
            "Vendedor"});
            this.cboxRol.Location = new System.Drawing.Point(168, 236);
            this.cboxRol.Name = "cboxRol";
            this.cboxRol.Size = new System.Drawing.Size(192, 24);
            this.cboxRol.TabIndex = 22;
            // 
            // tboxTelefono
            // 
            this.tboxTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxTelefono.Location = new System.Drawing.Point(168, 208);
            this.tboxTelefono.Name = "tboxTelefono";
            this.tboxTelefono.Size = new System.Drawing.Size(192, 22);
            this.tboxTelefono.TabIndex = 21;
            // 
            // tboxEmail
            // 
            this.tboxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxEmail.Location = new System.Drawing.Point(168, 180);
            this.tboxEmail.Name = "tboxEmail";
            this.tboxEmail.Size = new System.Drawing.Size(192, 22);
            this.tboxEmail.TabIndex = 20;
            // 
            // tboxCUIL
            // 
            this.tboxCUIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCUIL.Location = new System.Drawing.Point(168, 152);
            this.tboxCUIL.Name = "tboxCUIL";
            this.tboxCUIL.Size = new System.Drawing.Size(192, 22);
            this.tboxCUIL.TabIndex = 19;
            // 
            // tboxContraseña
            // 
            this.tboxContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxContraseña.Location = new System.Drawing.Point(168, 124);
            this.tboxContraseña.Name = "tboxContraseña";
            this.tboxContraseña.Size = new System.Drawing.Size(192, 22);
            this.tboxContraseña.TabIndex = 18;
            // 
            // tboxNombreUsuario
            // 
            this.tboxNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNombreUsuario.Location = new System.Drawing.Point(168, 96);
            this.tboxNombreUsuario.Name = "tboxNombreUsuario";
            this.tboxNombreUsuario.Size = new System.Drawing.Size(192, 22);
            this.tboxNombreUsuario.TabIndex = 17;
            // 
            // tboxApellido
            // 
            this.tboxApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxApellido.Location = new System.Drawing.Point(168, 68);
            this.tboxApellido.Name = "tboxApellido";
            this.tboxApellido.Size = new System.Drawing.Size(192, 22);
            this.tboxApellido.TabIndex = 16;
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(17, 239);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(28, 16);
            this.lblRol.TabIndex = 15;
            this.lblRol.Text = "Rol";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(17, 183);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email";
            // 
            // lblTeléfono
            // 
            this.lblTeléfono.AutoSize = true;
            this.lblTeléfono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeléfono.Location = new System.Drawing.Point(17, 211);
            this.lblTeléfono.Name = "lblTeléfono";
            this.lblTeléfono.Size = new System.Drawing.Size(61, 16);
            this.lblTeléfono.TabIndex = 13;
            this.lblTeléfono.Text = "Teléfono";
            // 
            // tboxNombre
            // 
            this.tboxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNombre.Location = new System.Drawing.Point(168, 40);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(192, 22);
            this.tboxNombre.TabIndex = 6;
            // 
            // lblCUIL
            // 
            this.lblCUIL.AutoSize = true;
            this.lblCUIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUIL.Location = new System.Drawing.Point(17, 155);
            this.lblCUIL.Name = "lblCUIL";
            this.lblCUIL.Size = new System.Drawing.Size(36, 16);
            this.lblCUIL.TabIndex = 12;
            this.lblCUIL.Text = "CUIL";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(17, 127);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(76, 16);
            this.lblContraseña.TabIndex = 11;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(17, 99);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(122, 16);
            this.lblNombreUsuario.TabIndex = 10;
            this.lblNombreUsuario.Text = "Nombre de usuario";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(17, 71);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(57, 16);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(17, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarUsuario.Location = new System.Drawing.Point(385, 78);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(131, 29);
            this.btnEditarUsuario.TabIndex = 6;
            this.btnEditarUsuario.Text = "Editar usuario";
            this.btnEditarUsuario.UseVisualStyleBackColor = true;
            this.btnEditarUsuario.Visible = false;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuario.Location = new System.Drawing.Point(385, 43);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(131, 29);
            this.btnAgregarUsuario.TabIndex = 25;
            this.btnAgregarUsuario.Text = "Agregar usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarCambios
            // 
            this.btnConfirmarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarCambios.Location = new System.Drawing.Point(20, 287);
            this.btnConfirmarCambios.Name = "btnConfirmarCambios";
            this.btnConfirmarCambios.Size = new System.Drawing.Size(131, 29);
            this.btnConfirmarCambios.TabIndex = 26;
            this.btnConfirmarCambios.Text = "Confirmar cambios";
            this.btnConfirmarCambios.UseVisualStyleBackColor = true;
            this.btnConfirmarCambios.Visible = false;
            // 
            // btnCancelarCambios
            // 
            this.btnCancelarCambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCambios.Location = new System.Drawing.Point(385, 287);
            this.btnCancelarCambios.Name = "btnCancelarCambios";
            this.btnCancelarCambios.Size = new System.Drawing.Size(131, 29);
            this.btnCancelarCambios.TabIndex = 27;
            this.btnCancelarCambios.Text = "Cancelar cambios";
            this.btnCancelarCambios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarCambios.UseVisualStyleBackColor = true;
            this.btnCancelarCambios.Visible = false;
            // 
            // FrmAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 544);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAdministrador";
            this.Text = "FrmAdministrador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAdministrador_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiVerPerfil;
        private System.Windows.Forms.ToolStripMenuItem tsmiCerrarSesión;
        private System.Windows.Forms.Label lblBuscarUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tboxBuscarNombreUsuario;
        private System.Windows.Forms.Label lblBuscarNombreUsuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnVisualizarListaUsuarios;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lblListaDeUsuarios;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.Label lblCUIL;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.TextBox tboxTelefono;
        private System.Windows.Forms.TextBox tboxEmail;
        private System.Windows.Forms.TextBox tboxCUIL;
        private System.Windows.Forms.TextBox tboxContraseña;
        private System.Windows.Forms.TextBox tboxNombreUsuario;
        private System.Windows.Forms.TextBox tboxApellido;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTeléfono;
        private System.Windows.Forms.ComboBox cboxRol;
        private System.Windows.Forms.Button btnCambiarRol;
        private System.Windows.Forms.ToolStripTextBox tstboxBienvenida;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnCancelarCambios;
        private System.Windows.Forms.Button btnConfirmarCambios;
    }
}