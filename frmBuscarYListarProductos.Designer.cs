namespace pryVelezFunesEmpresa
{
    partial class frmBuscarYListarProductos
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
            this.mrcInformacionProducto = new System.Windows.Forms.GroupBox();
            this.mskCostoMayorista = new System.Windows.Forms.MaskedTextBox();
            this.mskCostoMinorista = new System.Windows.Forms.MaskedTextBox();
            this.cbTipoProducto = new System.Windows.Forms.ComboBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCostoMayorista = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.lblCostoMinorista = new System.Windows.Forms.Label();
            this.mskIdProducto = new System.Windows.Forms.MaskedTextBox();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.mrcListadoProductos = new System.Windows.Forms.GroupBox();
            this.GrillaProductos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.mrcInformacionProducto.SuspendLayout();
            this.mrcListadoProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcInformacionProducto
            // 
            this.mrcInformacionProducto.Controls.Add(this.mskCostoMayorista);
            this.mrcInformacionProducto.Controls.Add(this.mskCostoMinorista);
            this.mrcInformacionProducto.Controls.Add(this.cbTipoProducto);
            this.mrcInformacionProducto.Controls.Add(this.txtNombreProducto);
            this.mrcInformacionProducto.Controls.Add(this.txtDescripcion);
            this.mrcInformacionProducto.Controls.Add(this.lblDescripcion);
            this.mrcInformacionProducto.Controls.Add(this.lblCostoMayorista);
            this.mrcInformacionProducto.Controls.Add(this.lblNombre);
            this.mrcInformacionProducto.Controls.Add(this.lblTipoProducto);
            this.mrcInformacionProducto.Controls.Add(this.lblCostoMinorista);
            this.mrcInformacionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcInformacionProducto.Location = new System.Drawing.Point(12, 49);
            this.mrcInformacionProducto.Name = "mrcInformacionProducto";
            this.mrcInformacionProducto.Size = new System.Drawing.Size(445, 391);
            this.mrcInformacionProducto.TabIndex = 2;
            this.mrcInformacionProducto.TabStop = false;
            this.mrcInformacionProducto.Text = "Información del Producto";
            // 
            // mskCostoMayorista
            // 
            this.mskCostoMayorista.Location = new System.Drawing.Point(195, 331);
            this.mskCostoMayorista.Mask = "000000";
            this.mskCostoMayorista.Name = "mskCostoMayorista";
            this.mskCostoMayorista.Size = new System.Drawing.Size(100, 27);
            this.mskCostoMayorista.TabIndex = 7;
            this.mskCostoMayorista.TextChanged += new System.EventHandler(this.mskCostoMayorista_TextChanged);
            // 
            // mskCostoMinorista
            // 
            this.mskCostoMinorista.Location = new System.Drawing.Point(195, 275);
            this.mskCostoMinorista.Mask = "0000000";
            this.mskCostoMinorista.Name = "mskCostoMinorista";
            this.mskCostoMinorista.Size = new System.Drawing.Size(100, 27);
            this.mskCostoMinorista.TabIndex = 6;
            this.mskCostoMinorista.TextChanged += new System.EventHandler(this.mskCostoMinorista_TextChanged);
            // 
            // cbTipoProducto
            // 
            this.cbTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoProducto.FormattingEnabled = true;
            this.cbTipoProducto.Location = new System.Drawing.Point(195, 80);
            this.cbTipoProducto.Name = "cbTipoProducto";
            this.cbTipoProducto.Size = new System.Drawing.Size(218, 28);
            this.cbTipoProducto.TabIndex = 4;
            this.cbTipoProducto.SelectedIndexChanged += new System.EventHandler(this.cbTipoProducto_SelectedIndexChanged);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(193, 36);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(220, 27);
            this.txtNombreProducto.TabIndex = 3;
            this.txtNombreProducto.TextChanged += new System.EventHandler(this.txtNombreProducto_TextChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(195, 138);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(220, 110);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(14, 138);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(99, 20);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblCostoMayorista
            // 
            this.lblCostoMayorista.AutoSize = true;
            this.lblCostoMayorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoMayorista.Location = new System.Drawing.Point(14, 331);
            this.lblCostoMayorista.Name = "lblCostoMayorista";
            this.lblCostoMayorista.Size = new System.Drawing.Size(131, 20);
            this.lblCostoMayorista.TabIndex = 5;
            this.lblCostoMayorista.Text = "Costo Mayorista";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(14, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoProducto.Location = new System.Drawing.Point(14, 88);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(136, 20);
            this.lblTipoProducto.TabIndex = 3;
            this.lblTipoProducto.Text = "Tipo de Producto";
            // 
            // lblCostoMinorista
            // 
            this.lblCostoMinorista.AutoSize = true;
            this.lblCostoMinorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoMinorista.Location = new System.Drawing.Point(14, 275);
            this.lblCostoMinorista.Name = "lblCostoMinorista";
            this.lblCostoMinorista.Size = new System.Drawing.Size(127, 20);
            this.lblCostoMinorista.TabIndex = 4;
            this.lblCostoMinorista.Text = "Costo Minorista";
            // 
            // mskIdProducto
            // 
            this.mskIdProducto.Location = new System.Drawing.Point(207, 18);
            this.mskIdProducto.Mask = "0000";
            this.mskIdProducto.Name = "mskIdProducto";
            this.mskIdProducto.Size = new System.Drawing.Size(81, 22);
            this.mskIdProducto.TabIndex = 1;
            this.mskIdProducto.TextChanged += new System.EventHandler(this.mskIdProducto_TextChanged);
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProducto.Location = new System.Drawing.Point(39, 18);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(140, 20);
            this.lblIdProducto.TabIndex = 1;
            this.lblIdProducto.Text = "ID del Producto";
            // 
            // mrcListadoProductos
            // 
            this.mrcListadoProductos.BackColor = System.Drawing.Color.LightGray;
            this.mrcListadoProductos.Controls.Add(this.GrillaProductos);
            this.mrcListadoProductos.Controls.Add(this.cmdConsultar);
            this.mrcListadoProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcListadoProductos.Location = new System.Drawing.Point(469, 9);
            this.mrcListadoProductos.Name = "mrcListadoProductos";
            this.mrcListadoProductos.Size = new System.Drawing.Size(697, 492);
            this.mrcListadoProductos.TabIndex = 112;
            this.mrcListadoProductos.TabStop = false;
            this.mrcListadoProductos.Text = "Listado de Productos";
            // 
            // GrillaProductos
            // 
            this.GrillaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5});
            this.GrillaProductos.Location = new System.Drawing.Point(18, 30);
            this.GrillaProductos.Name = "GrillaProductos";
            this.GrillaProductos.RowHeadersVisible = false;
            this.GrillaProductos.RowHeadersWidth = 51;
            this.GrillaProductos.RowTemplate.Height = 24;
            this.GrillaProductos.Size = new System.Drawing.Size(673, 401);
            this.GrillaProductos.TabIndex = 107;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id Producto";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre del Producto";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tipo de Producto";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Descripción";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Costo Minorista";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Costo Mayorista";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultar.Location = new System.Drawing.Point(576, 452);
            this.cmdConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(115, 33);
            this.cmdConsultar.TabIndex = 108;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(12, 461);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(108, 33);
            this.cmdSalir.TabIndex = 117;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(189, 422);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(108, 33);
            this.cmdCancelar.TabIndex = 118;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Location = new System.Drawing.Point(355, 461);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(108, 33);
            this.cmdGuardar.TabIndex = 116;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminar.Location = new System.Drawing.Point(126, 461);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(108, 33);
            this.cmdEliminar.TabIndex = 114;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificar.Location = new System.Drawing.Point(240, 461);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(108, 33);
            this.cmdModificar.TabIndex = 115;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(312, 9);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(132, 39);
            this.cmdBuscar.TabIndex = 113;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // frmBuscarYListarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 510);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.mrcListadoProductos);
            this.Controls.Add(this.mrcInformacionProducto);
            this.Controls.Add(this.lblIdProducto);
            this.Controls.Add(this.mskIdProducto);
            this.Name = "frmBuscarYListarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Productos";
            this.Load += new System.EventHandler(this.frmBuscarYListarProductos_Load);
            this.mrcInformacionProducto.ResumeLayout(false);
            this.mrcInformacionProducto.PerformLayout();
            this.mrcListadoProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcInformacionProducto;
        private System.Windows.Forms.MaskedTextBox mskCostoMayorista;
        private System.Windows.Forms.MaskedTextBox mskCostoMinorista;
        private System.Windows.Forms.ComboBox cbTipoProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCostoMayorista;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipoProducto;
        private System.Windows.Forms.Label lblCostoMinorista;
        private System.Windows.Forms.MaskedTextBox mskIdProducto;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.GroupBox mrcListadoProductos;
        private System.Windows.Forms.DataGridView GrillaProductos;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}