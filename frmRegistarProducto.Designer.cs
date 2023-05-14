namespace pryVelezFunesEmpresa
{
    partial class frmRegistarProducto
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
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.mrcInformacioProducto = new System.Windows.Forms.GroupBox();
            this.mskCostoMayorista = new System.Windows.Forms.MaskedTextBox();
            this.mskCostoMinorista = new System.Windows.Forms.MaskedTextBox();
            this.cbTipoProducto = new System.Windows.Forms.ComboBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.mskIdProducto = new System.Windows.Forms.MaskedTextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCostoMayorista = new System.Windows.Forms.Label();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.lblCostoMinorista = new System.Windows.Forms.Label();
            this.mrcInformacioProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(12, 456);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(123, 39);
            this.cmdSalir.TabIndex = 9;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregar.Location = new System.Drawing.Point(361, 457);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(123, 39);
            this.cmdAgregar.TabIndex = 7;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLimpiar.Location = new System.Drawing.Point(189, 457);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(123, 39);
            this.cmdLimpiar.TabIndex = 8;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // mrcInformacioProducto
            // 
            this.mrcInformacioProducto.Controls.Add(this.mskCostoMayorista);
            this.mrcInformacioProducto.Controls.Add(this.mskCostoMinorista);
            this.mrcInformacioProducto.Controls.Add(this.cbTipoProducto);
            this.mrcInformacioProducto.Controls.Add(this.txtNombreProducto);
            this.mrcInformacioProducto.Controls.Add(this.txtDescripcion);
            this.mrcInformacioProducto.Controls.Add(this.mskIdProducto);
            this.mrcInformacioProducto.Controls.Add(this.lblDescripcion);
            this.mrcInformacioProducto.Controls.Add(this.lblCostoMayorista);
            this.mrcInformacioProducto.Controls.Add(this.lblIdProducto);
            this.mrcInformacioProducto.Controls.Add(this.lblNombre);
            this.mrcInformacioProducto.Controls.Add(this.lblTipoProducto);
            this.mrcInformacioProducto.Controls.Add(this.lblCostoMinorista);
            this.mrcInformacioProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcInformacioProducto.Location = new System.Drawing.Point(13, 2);
            this.mrcInformacioProducto.Name = "mrcInformacioProducto";
            this.mrcInformacioProducto.Size = new System.Drawing.Size(472, 449);
            this.mrcInformacioProducto.TabIndex = 0;
            this.mrcInformacioProducto.TabStop = false;
            this.mrcInformacioProducto.Text = "Información del Producto";
            // 
            // mskCostoMayorista
            // 
            this.mskCostoMayorista.Location = new System.Drawing.Point(196, 395);
            this.mskCostoMayorista.Mask = "000000";
            this.mskCostoMayorista.Name = "mskCostoMayorista";
            this.mskCostoMayorista.Size = new System.Drawing.Size(100, 27);
            this.mskCostoMayorista.TabIndex = 6;
            // 
            // mskCostoMinorista
            // 
            this.mskCostoMinorista.Location = new System.Drawing.Point(196, 339);
            this.mskCostoMinorista.Mask = "0000000";
            this.mskCostoMinorista.Name = "mskCostoMinorista";
            this.mskCostoMinorista.Size = new System.Drawing.Size(100, 27);
            this.mskCostoMinorista.TabIndex = 5;
            // 
            // cbTipoProducto
            // 
            this.cbTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoProducto.FormattingEnabled = true;
            this.cbTipoProducto.Location = new System.Drawing.Point(196, 144);
            this.cbTipoProducto.Name = "cbTipoProducto";
            this.cbTipoProducto.Size = new System.Drawing.Size(218, 28);
            this.cbTipoProducto.TabIndex = 3;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(194, 100);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(220, 27);
            this.txtNombreProducto.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(196, 202);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(220, 110);
            this.txtDescripcion.TabIndex = 4;
            // 
            // mskIdProducto
            // 
            this.mskIdProducto.Location = new System.Drawing.Point(194, 48);
            this.mskIdProducto.Mask = "0000";
            this.mskIdProducto.Name = "mskIdProducto";
            this.mskIdProducto.Size = new System.Drawing.Size(123, 27);
            this.mskIdProducto.TabIndex = 1;
            this.mskIdProducto.Leave += new System.EventHandler(this.mskIdProducto_Leave);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(15, 202);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(99, 20);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblCostoMayorista
            // 
            this.lblCostoMayorista.AutoSize = true;
            this.lblCostoMayorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoMayorista.Location = new System.Drawing.Point(15, 395);
            this.lblCostoMayorista.Name = "lblCostoMayorista";
            this.lblCostoMayorista.Size = new System.Drawing.Size(131, 20);
            this.lblCostoMayorista.TabIndex = 5;
            this.lblCostoMayorista.Text = "Costo Mayorista";
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProducto.Location = new System.Drawing.Point(15, 48);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(121, 20);
            this.lblIdProducto.TabIndex = 1;
            this.lblIdProducto.Text = "Id del Producto";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(15, 100);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProducto.Location = new System.Drawing.Point(15, 152);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(136, 20);
            this.lblTipoProducto.TabIndex = 3;
            this.lblTipoProducto.Text = "Tipo de Producto";
            // 
            // lblCostoMinorista
            // 
            this.lblCostoMinorista.AutoSize = true;
            this.lblCostoMinorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoMinorista.Location = new System.Drawing.Point(15, 339);
            this.lblCostoMinorista.Name = "lblCostoMinorista";
            this.lblCostoMinorista.Size = new System.Drawing.Size(127, 20);
            this.lblCostoMinorista.TabIndex = 4;
            this.lblCostoMinorista.Text = "Costo Minorista";
            // 
            // frmRegistarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 507);
            this.Controls.Add(this.mrcInformacioProducto);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdAgregar);
            this.Name = "frmRegistarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registar de Producto";
            this.Load += new System.EventHandler(this.frmRegistarProducto_Load);
            this.mrcInformacioProducto.ResumeLayout(false);
            this.mrcInformacioProducto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.GroupBox mrcInformacioProducto;
        private System.Windows.Forms.MaskedTextBox mskCostoMayorista;
        private System.Windows.Forms.MaskedTextBox mskCostoMinorista;
        private System.Windows.Forms.ComboBox cbTipoProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.MaskedTextBox mskIdProducto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCostoMayorista;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.Label lblCostoMinorista;
    }
}