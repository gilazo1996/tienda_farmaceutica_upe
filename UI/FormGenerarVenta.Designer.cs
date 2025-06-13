namespace UI
{
    partial class FormGenerarVenta
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
            this.txtCodigoFarmaco = new System.Windows.Forms.TextBox();
            this.btnBuscarFarmaco = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarFarmaco = new System.Windows.Forms.Button();
            this.dgvFarmacos = new System.Windows.Forms.DataGridView();
            this.btnConfirmarVenta = new System.Windows.Forms.Button();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoProductoEncontrado = new System.Windows.Forms.TextBox();
            this.txtNombreProductoEncontrado = new System.Windows.Forms.TextBox();
            this.txtPrecioProductoEncontrado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudCantidadProductoEncontrado = new System.Windows.Forms.NumericUpDown();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFarmacos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadProductoEncontrado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigoFarmaco
            // 
            this.txtCodigoFarmaco.Location = new System.Drawing.Point(54, 61);
            this.txtCodigoFarmaco.Name = "txtCodigoFarmaco";
            this.txtCodigoFarmaco.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoFarmaco.TabIndex = 0;
            // 
            // btnBuscarFarmaco
            // 
            this.btnBuscarFarmaco.Location = new System.Drawing.Point(54, 126);
            this.btnBuscarFarmaco.Name = "btnBuscarFarmaco";
            this.btnBuscarFarmaco.Size = new System.Drawing.Size(100, 23);
            this.btnBuscarFarmaco.TabIndex = 1;
            this.btnBuscarFarmaco.Text = "Buscar";
            this.btnBuscarFarmaco.UseVisualStyleBackColor = true;
            this.btnBuscarFarmaco.Click += new System.EventHandler(this.btnBuscarFarmaco_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código del fármaco:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(54, 100);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // btnAgregarFarmaco
            // 
            this.btnAgregarFarmaco.Location = new System.Drawing.Point(57, 369);
            this.btnAgregarFarmaco.Name = "btnAgregarFarmaco";
            this.btnAgregarFarmaco.Size = new System.Drawing.Size(113, 23);
            this.btnAgregarFarmaco.TabIndex = 5;
            this.btnAgregarFarmaco.Text = "+Agregar fármaco";
            this.btnAgregarFarmaco.UseVisualStyleBackColor = true;
            this.btnAgregarFarmaco.Click += new System.EventHandler(this.btnAgregarFarmaco_Click);
            // 
            // dgvFarmacos
            // 
            this.dgvFarmacos.BackgroundColor = System.Drawing.Color.White;
            this.dgvFarmacos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFarmacos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFarmacos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Cantidad,
            this.PrecioUnitario,
            this.Subtotal});
            this.dgvFarmacos.Location = new System.Drawing.Point(300, 71);
            this.dgvFarmacos.Name = "dgvFarmacos";
            this.dgvFarmacos.Size = new System.Drawing.Size(679, 305);
            this.dgvFarmacos.TabIndex = 6;
            this.dgvFarmacos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFarmacos_CellContentClick);
            // 
            // btnConfirmarVenta
            // 
            this.btnConfirmarVenta.Location = new System.Drawing.Point(392, 397);
            this.btnConfirmarVenta.Name = "btnConfirmarVenta";
            this.btnConfirmarVenta.Size = new System.Drawing.Size(94, 23);
            this.btnConfirmarVenta.TabIndex = 7;
            this.btnConfirmarVenta.Text = "Confirmar";
            this.btnConfirmarVenta.UseVisualStyleBackColor = true;
            this.btnConfirmarVenta.Click += new System.EventHandler(this.btnConfirmarVenta_Click);
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.Location = new System.Drawing.Point(541, 397);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(89, 23);
            this.btnCancelarVenta.TabIndex = 8;
            this.btnCancelarVenta.Text = "Cancelar";
            this.btnCancelarVenta.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(50, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Buscar fármaco:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(39, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Datos del fármaco:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCodigoProductoEncontrado
            // 
            this.txtCodigoProductoEncontrado.Location = new System.Drawing.Point(96, 230);
            this.txtCodigoProductoEncontrado.Name = "txtCodigoProductoEncontrado";
            this.txtCodigoProductoEncontrado.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoProductoEncontrado.TabIndex = 11;
            // 
            // txtNombreProductoEncontrado
            // 
            this.txtNombreProductoEncontrado.Location = new System.Drawing.Point(96, 257);
            this.txtNombreProductoEncontrado.Name = "txtNombreProductoEncontrado";
            this.txtNombreProductoEncontrado.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProductoEncontrado.TabIndex = 12;
            // 
            // txtPrecioProductoEncontrado
            // 
            this.txtPrecioProductoEncontrado.Location = new System.Drawing.Point(96, 284);
            this.txtPrecioProductoEncontrado.Name = "txtPrecioProductoEncontrado";
            this.txtPrecioProductoEncontrado.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioProductoEncontrado.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "código";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "precio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "cantidad";
            // 
            // nudCantidadProductoEncontrado
            // 
            this.nudCantidadProductoEncontrado.Location = new System.Drawing.Point(96, 311);
            this.nudCantidadProductoEncontrado.Name = "nudCantidadProductoEncontrado";
            this.nudCantidadProductoEncontrado.Size = new System.Drawing.Size(120, 20);
            this.nudCantidadProductoEncontrado.TabIndex = 19;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "PrecioUnitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(96, 337);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 20;
            this.txtStock.TextChanged += new System.EventHandler(this.txtStock_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Stock";
            // 
            // FormGenerarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.nudCantidadProductoEncontrado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrecioProductoEncontrado);
            this.Controls.Add(this.txtNombreProductoEncontrado);
            this.Controls.Add(this.txtCodigoProductoEncontrado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.btnConfirmarVenta);
            this.Controls.Add(this.dgvFarmacos);
            this.Controls.Add(this.btnAgregarFarmaco);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarFarmaco);
            this.Controls.Add(this.txtCodigoFarmaco);
            this.Name = "FormGenerarVenta";
            this.Text = "FormGenerarVenta";
            this.Load += new System.EventHandler(this.FormGenerarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFarmacos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadProductoEncontrado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoFarmaco;
        private System.Windows.Forms.Button btnBuscarFarmaco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnAgregarFarmaco;
        private System.Windows.Forms.DataGridView dgvFarmacos;
        private System.Windows.Forms.Button btnConfirmarVenta;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoProductoEncontrado;
        private System.Windows.Forms.TextBox txtNombreProductoEncontrado;
        private System.Windows.Forms.TextBox txtPrecioProductoEncontrado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudCantidadProductoEncontrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label9;
    }
}