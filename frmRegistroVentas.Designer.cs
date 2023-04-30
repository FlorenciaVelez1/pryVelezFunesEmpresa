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
            this.cbFormaPago = new System.Windows.Forms.ComboBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.mskVendedor = new System.Windows.Forms.MaskedTextBox();
            this.mskIdCliente = new System.Windows.Forms.MaskedTextBox();
            this.mskIdProducto = new System.Windows.Forms.MaskedTextBox();
            this.lblFormaDePago = new System.Windows.Forms.Label();
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
            this.cmdLimpiar.Location = new System.Drawing.Point(159, 396);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(123, 39);
            this.cmdLimpiar.TabIndex = 8;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(12, 396);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(123, 39);
            this.cmdSalir.TabIndex = 9;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Enabled = false;
            this.cmdAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregar.Location = new System.Drawing.Point(306, 396);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(123, 39);
            this.cmdAgregar.TabIndex = 7;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // mrcVentas
            // 
            this.mrcVentas.Controls.Add(this.cbFormaPago);
            this.mrcVentas.Controls.Add(this.nudCantidad);
            this.mrcVentas.Controls.Add(this.dtpFecha);
            this.mrcVentas.Controls.Add(this.mskVendedor);
            this.mrcVentas.Controls.Add(this.mskIdCliente);
            this.mrcVentas.Controls.Add(this.mskIdProducto);
            this.mrcVentas.Controls.Add(this.lblFormaDePago);
            this.mrcVentas.Controls.Add(this.lblVendedor);
            this.mrcVentas.Controls.Add(this.lblIdProducto);
            this.mrcVentas.Controls.Add(this.lblIdCliente);
            this.mrcVentas.Controls.Add(this.lblCantidad);
            this.mrcVentas.Controls.Add(this.lblFechaVenta);
            this.mrcVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcVentas.Location = new System.Drawing.Point(12, 12);
            this.mrcVentas.Name = "mrcVentas";
            this.mrcVentas.Size = new System.Drawing.Size(417, 378);
            this.mrcVentas.TabIndex = 0;
            this.mrcVentas.TabStop = false;
            this.mrcVentas.Text = "Información Venta";
            // 
            // cbFormaPago
            // 
            this.cbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPago.FormattingEnabled = true;
            this.cbFormaPago.Items.AddRange(new object[] {
            "EFECTIVO",
            "TARJETA"});
            this.cbFormaPago.Location = new System.Drawing.Point(196, 269);
            this.cbFormaPago.Name = "cbFormaPago";
            this.cbFormaPago.Size = new System.Drawing.Size(129, 28);
            this.cbFormaPago.TabIndex = 5;
            this.cbFormaPago.SelectedIndexChanged += new System.EventHandler(this.cbFormaPago_SelectedIndexChanged);
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(196, 217);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.ReadOnly = true;
            this.nudCantidad.Size = new System.Drawing.Size(73, 27);
            this.nudCantidad.TabIndex = 4;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(196, 328);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 27);
            this.dtpFecha.TabIndex = 6;
            // 
            // mskVendedor
            // 
            this.mskVendedor.Location = new System.Drawing.Point(197, 45);
            this.mskVendedor.Mask = "0000";
            this.mskVendedor.Name = "mskVendedor";
            this.mskVendedor.Size = new System.Drawing.Size(129, 27);
            this.mskVendedor.TabIndex = 1;
            this.mskVendedor.TextChanged += new System.EventHandler(this.mskVendedor_TextChanged);
            this.mskVendedor.Leave += new System.EventHandler(this.mskVendedor_Leave);
            // 
            // mskIdCliente
            // 
            this.mskIdCliente.Location = new System.Drawing.Point(196, 154);
            this.mskIdCliente.Mask = "00000";
            this.mskIdCliente.Name = "mskIdCliente";
            this.mskIdCliente.Size = new System.Drawing.Size(129, 27);
            this.mskIdCliente.TabIndex = 3;
            this.mskIdCliente.TextChanged += new System.EventHandler(this.mskIdCliente_TextChanged);
            this.mskIdCliente.Leave += new System.EventHandler(this.mskIdCliente_Leave);
            // 
            // mskIdProducto
            // 
            this.mskIdProducto.Location = new System.Drawing.Point(196, 96);
            this.mskIdProducto.Mask = "0000";
            this.mskIdProducto.Name = "mskIdProducto";
            this.mskIdProducto.Size = new System.Drawing.Size(129, 27);
            this.mskIdProducto.TabIndex = 2;
            this.mskIdProducto.TextChanged += new System.EventHandler(this.mskIdProducto_TextChanged);
            this.mskIdProducto.Leave += new System.EventHandler(this.mskIdProducto_Leave);
            // 
            // lblFormaDePago
            // 
            this.lblFormaDePago.AutoSize = true;
            this.lblFormaDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaDePago.Location = new System.Drawing.Point(18, 277);
            this.lblFormaDePago.Name = "lblFormaDePago";
            this.lblFormaDePago.Size = new System.Drawing.Size(123, 20);
            this.lblFormaDePago.TabIndex = 6;
            this.lblFormaDePago.Text = "Forma de Pago";
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
            this.lblIdProducto.Location = new System.Drawing.Point(18, 103);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(121, 20);
            this.lblIdProducto.TabIndex = 1;
            this.lblIdProducto.Text = "Id del Producto";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.Location = new System.Drawing.Point(18, 161);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(79, 20);
            this.lblIdCliente.TabIndex = 2;
            this.lblIdCliente.Text = "Id Cliente";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(18, 219);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(75, 20);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaVenta.Location = new System.Drawing.Point(15, 335);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(126, 20);
            this.lblFechaVenta.TabIndex = 4;
            this.lblFechaVenta.Text = "Fecha de Venta";
            // 
            // frmRegistroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 449);
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
    }
}