namespace pryVelezFunesEmpresa
{
    partial class frmRegistroVentas
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
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.mrcVentas = new System.Windows.Forms.GroupBox();
            this.lblNomCliente = new System.Windows.Forms.Label();
            this.lblNomProducto = new System.Windows.Forms.Label();
            this.cbNomClientes = new System.Windows.Forms.ComboBox();
            this.cbProducto = new System.Windows.Forms.ComboBox();
            this.cbFormaPago = new System.Windows.Forms.ComboBox();
            this.lblFormaDePago = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.mskVendedor = new System.Windows.Forms.MaskedTextBox();
            this.mskIdCliente = new System.Windows.Forms.MaskedTextBox();
            this.mskIdProducto = new System.Windows.Forms.MaskedTextBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.mrcVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLimpiar.Location = new System.Drawing.Point(377, 265);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(123, 39);
            this.cmdLimpiar.TabIndex = 9;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(12, 265);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(123, 39);
            this.cmdSalir.TabIndex = 10;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Enabled = false;
            this.cmdAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregar.Location = new System.Drawing.Point(732, 265);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(123, 39);
            this.cmdAgregar.TabIndex = 8;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // mrcVentas
            // 
            this.mrcVentas.Controls.Add(this.lblNomCliente);
            this.mrcVentas.Controls.Add(this.lblNomProducto);
            this.mrcVentas.Controls.Add(this.cbNomClientes);
            this.mrcVentas.Controls.Add(this.cbProducto);
            this.mrcVentas.Controls.Add(this.cbFormaPago);
            this.mrcVentas.Controls.Add(this.lblFormaDePago);
            this.mrcVentas.Controls.Add(this.nudCantidad);
            this.mrcVentas.Controls.Add(this.dtpFecha);
            this.mrcVentas.Controls.Add(this.mskVendedor);
            this.mrcVentas.Controls.Add(this.mskIdCliente);
            this.mrcVentas.Controls.Add(this.mskIdProducto);
            this.mrcVentas.Controls.Add(this.lblVendedor);
            this.mrcVentas.Controls.Add(this.lblIdProducto);
            this.mrcVentas.Controls.Add(this.lblIdCliente);
            this.mrcVentas.Controls.Add(this.lblCantidad);
            this.mrcVentas.Controls.Add(this.lblFechaVenta);
            this.mrcVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcVentas.Location = new System.Drawing.Point(12, 12);
            this.mrcVentas.Name = "mrcVentas";
            this.mrcVentas.Size = new System.Drawing.Size(844, 247);
            this.mrcVentas.TabIndex = 0;
            this.mrcVentas.TabStop = false;
            this.mrcVentas.Text = "Información Venta";
            // 
            // lblNomCliente
            // 
            this.lblNomCliente.AutoSize = true;
            this.lblNomCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomCliente.Location = new System.Drawing.Point(16, 92);
            this.lblNomCliente.Name = "lblNomCliente";
            this.lblNomCliente.Size = new System.Drawing.Size(125, 20);
            this.lblNomCliente.TabIndex = 10;
            this.lblNomCliente.Text = "Nombre Cliente";
            // 
            // lblNomProducto
            // 
            this.lblNomProducto.AutoSize = true;
            this.lblNomProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomProducto.Location = new System.Drawing.Point(18, 147);
            this.lblNomProducto.Name = "lblNomProducto";
            this.lblNomProducto.Size = new System.Drawing.Size(167, 20);
            this.lblNomProducto.TabIndex = 9;
            this.lblNomProducto.Text = "Nombre del Producto";
            // 
            // cbNomClientes
            // 
            this.cbNomClientes.FormattingEnabled = true;
            this.cbNomClientes.Location = new System.Drawing.Point(214, 92);
            this.cbNomClientes.Name = "cbNomClientes";
            this.cbNomClientes.Size = new System.Drawing.Size(199, 28);
            this.cbNomClientes.TabIndex = 2;
            this.cbNomClientes.SelectedIndexChanged += new System.EventHandler(this.cbNomClientes_SelectedIndexChanged);
            // 
            // cbProducto
            // 
            this.cbProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbProducto.FormattingEnabled = true;
            this.cbProducto.Location = new System.Drawing.Point(216, 139);
            this.cbProducto.Name = "cbProducto";
            this.cbProducto.Size = new System.Drawing.Size(199, 28);
            this.cbProducto.TabIndex = 3;
            this.cbProducto.SelectedIndexChanged += new System.EventHandler(this.cbProducto_SelectedIndexChanged);
            // 
            // cbFormaPago
            // 
            this.cbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPago.FormattingEnabled = true;
            this.cbFormaPago.Items.AddRange(new object[] {
            "EFECTIVO",
            "TARJETA"});
            this.cbFormaPago.Location = new System.Drawing.Point(582, 186);
            this.cbFormaPago.Name = "cbFormaPago";
            this.cbFormaPago.Size = new System.Drawing.Size(129, 28);
            this.cbFormaPago.TabIndex = 7;
            this.cbFormaPago.SelectedIndexChanged += new System.EventHandler(this.cbFormaPago_SelectedIndexChanged);
            // 
            // lblFormaDePago
            // 
            this.lblFormaDePago.AutoSize = true;
            this.lblFormaDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaDePago.Location = new System.Drawing.Point(440, 194);
            this.lblFormaDePago.Name = "lblFormaDePago";
            this.lblFormaDePago.Size = new System.Drawing.Size(123, 20);
            this.lblFormaDePago.TabIndex = 6;
            this.lblFormaDePago.Text = "Forma de Pago";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(214, 192);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.ReadOnly = true;
            this.nudCantidad.Size = new System.Drawing.Size(73, 27);
            this.nudCantidad.TabIndex = 5;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(582, 39);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(236, 27);
            this.dtpFecha.TabIndex = 6;
            // 
            // mskVendedor
            // 
            this.mskVendedor.Location = new System.Drawing.Point(216, 48);
            this.mskVendedor.Mask = "0000";
            this.mskVendedor.Name = "mskVendedor";
            this.mskVendedor.Size = new System.Drawing.Size(129, 27);
            this.mskVendedor.TabIndex = 1;
            this.mskVendedor.TextChanged += new System.EventHandler(this.mskVendedor_TextChanged);
            this.mskVendedor.Leave += new System.EventHandler(this.mskVendedor_Leave);
            // 
            // mskIdCliente
            // 
            this.mskIdCliente.Location = new System.Drawing.Point(582, 90);
            this.mskIdCliente.Mask = "00000";
            this.mskIdCliente.Name = "mskIdCliente";
            this.mskIdCliente.ReadOnly = true;
            this.mskIdCliente.Size = new System.Drawing.Size(129, 27);
            this.mskIdCliente.TabIndex = 22;
            // 
            // mskIdProducto
            // 
            this.mskIdProducto.Location = new System.Drawing.Point(584, 140);
            this.mskIdProducto.Mask = "0000";
            this.mskIdProducto.Name = "mskIdProducto";
            this.mskIdProducto.ReadOnly = true;
            this.mskIdProducto.Size = new System.Drawing.Size(129, 27);
            this.mskIdProducto.TabIndex = 23;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(18, 45);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(80, 20);
            this.lblVendedor.TabIndex = 5;
            this.lblVendedor.Text = "Vendedor";
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProducto.Location = new System.Drawing.Point(444, 143);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(121, 20);
            this.lblIdProducto.TabIndex = 1;
            this.lblIdProducto.Text = "Id del Producto";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.Location = new System.Drawing.Point(442, 97);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(79, 20);
            this.lblIdCliente.TabIndex = 2;
            this.lblIdCliente.Text = "Id Cliente";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(24, 194);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(75, 20);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVenta.Location = new System.Drawing.Point(440, 44);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(126, 20);
            this.lblFechaVenta.TabIndex = 4;
            this.lblFechaVenta.Text = "Fecha de Venta";
            // 
            // frmRegistroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 324);
            this.Controls.Add(this.mrcVentas);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdAgregar);
            this.Name = "frmRegistroVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Ventas";
            this.Load += new System.EventHandler(this.frmRegistroVentas_Load);
            this.mrcVentas.ResumeLayout(false);
            this.mrcVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.GroupBox mrcVentas;
        private System.Windows.Forms.ComboBox cbFormaPago;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.MaskedTextBox mskVendedor;
        private System.Windows.Forms.MaskedTextBox mskIdCliente;
        private System.Windows.Forms.MaskedTextBox mskIdProducto;
        private System.Windows.Forms.Label lblFormaDePago;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.ComboBox cbProducto;
        private System.Windows.Forms.ComboBox cbNomClientes;
        private System.Windows.Forms.Label lblNomCliente;
        private System.Windows.Forms.Label lblNomProducto;
    }
}