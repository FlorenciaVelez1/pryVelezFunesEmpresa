namespace pryVelezFunesEmpresa
{
    partial class frmBuscarClientes
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
            this.cmdCancelar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdBuscar = new System.Windows.Forms.Button();
            this.mrcInformacion = new System.Windows.Forms.GroupBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtNombreApellido = new System.Windows.Forms.TextBox();
            this.lblNombreYApellido = new System.Windows.Forms.Label();
            this.mskTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            this.cmdExportarCli = new System.Windows.Forms.Button();
            this.cmdConsultarCliente = new System.Windows.Forms.Button();
            this.GrillaClientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrcListadoClientes = new System.Windows.Forms.GroupBox();
            this.cbClientes = new System.Windows.Forms.ComboBox();
            this.mrcInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaClientes)).BeginInit();
            this.mrcListadoClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdSalir
            // 
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.Location = new System.Drawing.Point(12, 282);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(108, 39);
            this.cmdSalir.TabIndex = 104;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Location = new System.Drawing.Point(194, 237);
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(110, 39);
            this.cmdCancelar.TabIndex = 106;
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.UseVisualStyleBackColor = true;
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Location = new System.Drawing.Point(366, 282);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(108, 39);
            this.cmdGuardar.TabIndex = 103;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminar.Location = new System.Drawing.Point(130, 282);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(108, 39);
            this.cmdEliminar.TabIndex = 101;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificar.Location = new System.Drawing.Point(248, 282);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(108, 39);
            this.cmdModificar.TabIndex = 102;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(334, 16);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(132, 39);
            this.cmdBuscar.TabIndex = 99;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.UseVisualStyleBackColor = true;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // mrcInformacion
            // 
            this.mrcInformacion.BackColor = System.Drawing.Color.LightGray;
            this.mrcInformacion.Controls.Add(this.txtDomicilio);
            this.mrcInformacion.Controls.Add(this.txtNombreApellido);
            this.mrcInformacion.Controls.Add(this.lblNombreYApellido);
            this.mrcInformacion.Controls.Add(this.mskTelefono);
            this.mrcInformacion.Controls.Add(this.lblTelefono);
            this.mrcInformacion.Controls.Add(this.lblDireccion);
            this.mrcInformacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcInformacion.Location = new System.Drawing.Point(12, 80);
            this.mrcInformacion.Name = "mrcInformacion";
            this.mrcInformacion.Size = new System.Drawing.Size(464, 181);
            this.mrcInformacion.TabIndex = 100;
            this.mrcInformacion.TabStop = false;
            this.mrcInformacion.Text = "Informacion Cliente";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDomicilio.Location = new System.Drawing.Point(182, 85);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.txtDomicilio.MaxLength = 60;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.ShortcutsEnabled = false;
            this.txtDomicilio.Size = new System.Drawing.Size(265, 27);
            this.txtDomicilio.TabIndex = 3;
            this.txtDomicilio.TextChanged += new System.EventHandler(this.txtDomicilio_TextChanged);
            // 
            // txtNombreApellido
            // 
            this.txtNombreApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreApellido.Location = new System.Drawing.Point(182, 42);
            this.txtNombreApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreApellido.MaxLength = 60;
            this.txtNombreApellido.Name = "txtNombreApellido";
            this.txtNombreApellido.ShortcutsEnabled = false;
            this.txtNombreApellido.Size = new System.Drawing.Size(265, 27);
            this.txtNombreApellido.TabIndex = 2;
            this.txtNombreApellido.TextChanged += new System.EventHandler(this.txtNombreApellido_TextChanged);
            this.txtNombreApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreApellido_KeyPress);
            // 
            // lblNombreYApellido
            // 
            this.lblNombreYApellido.AutoSize = true;
            this.lblNombreYApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreYApellido.Location = new System.Drawing.Point(8, 45);
            this.lblNombreYApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreYApellido.Name = "lblNombreYApellido";
            this.lblNombreYApellido.Size = new System.Drawing.Size(150, 20);
            this.lblNombreYApellido.TabIndex = 82;
            this.lblNombreYApellido.Text = "Nombre y Apellido:";
            // 
            // mskTelefono
            // 
            this.mskTelefono.Location = new System.Drawing.Point(182, 125);
            this.mskTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.mskTelefono.Mask = "000000000";
            this.mskTelefono.Name = "mskTelefono";
            this.mskTelefono.Size = new System.Drawing.Size(171, 27);
            this.mskTelefono.TabIndex = 6;
            this.mskTelefono.ValidatingType = typeof(int);
            this.mskTelefono.TextChanged += new System.EventHandler(this.mskTelefono_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(9, 126);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(78, 20);
            this.lblTelefono.TabIndex = 84;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(9, 87);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(84, 20);
            this.lblDireccion.TabIndex = 83;
            this.lblDireccion.Text = "Domicilio:";
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCliente.Location = new System.Drawing.Point(18, 23);
            this.lbCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(145, 20);
            this.lbCliente.TabIndex = 105;
            this.lbCliente.Text = "Nombre Cliente:";
            // 
            // cmdExportarCli
            // 
            this.cmdExportarCli.Enabled = false;
            this.cmdExportarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportarCli.Location = new System.Drawing.Point(314, 266);
            this.cmdExportarCli.Name = "cmdExportarCli";
            this.cmdExportarCli.Size = new System.Drawing.Size(115, 33);
            this.cmdExportarCli.TabIndex = 110;
            this.cmdExportarCli.Text = "Exportar";
            this.cmdExportarCli.UseVisualStyleBackColor = true;
            this.cmdExportarCli.Click += new System.EventHandler(this.cmdExportarCli_Click);
            // 
            // cmdConsultarCliente
            // 
            this.cmdConsultarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultarCliente.Location = new System.Drawing.Point(436, 266);
            this.cmdConsultarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cmdConsultarCliente.Name = "cmdConsultarCliente";
            this.cmdConsultarCliente.Size = new System.Drawing.Size(115, 33);
            this.cmdConsultarCliente.TabIndex = 108;
            this.cmdConsultarCliente.Text = "Consultar";
            this.cmdConsultarCliente.UseVisualStyleBackColor = true;
            this.cmdConsultarCliente.Click += new System.EventHandler(this.cmdConsultarCliente_Click);
            // 
            // GrillaClientes
            // 
            this.GrillaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.GrillaClientes.Location = new System.Drawing.Point(18, 30);
            this.GrillaClientes.Name = "GrillaClientes";
            this.GrillaClientes.ReadOnly = true;
            this.GrillaClientes.RowHeadersVisible = false;
            this.GrillaClientes.RowHeadersWidth = 51;
            this.GrillaClientes.RowTemplate.Height = 24;
            this.GrillaClientes.Size = new System.Drawing.Size(533, 219);
            this.GrillaClientes.TabIndex = 107;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id Cliente";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre y Apellido";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Domicilio";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Teléfono";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // mrcListadoClientes
            // 
            this.mrcListadoClientes.BackColor = System.Drawing.Color.LightGray;
            this.mrcListadoClientes.Controls.Add(this.GrillaClientes);
            this.mrcListadoClientes.Controls.Add(this.cmdConsultarCliente);
            this.mrcListadoClientes.Controls.Add(this.cmdExportarCli);
            this.mrcListadoClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcListadoClientes.Location = new System.Drawing.Point(482, 16);
            this.mrcListadoClientes.Name = "mrcListadoClientes";
            this.mrcListadoClientes.Size = new System.Drawing.Size(562, 305);
            this.mrcListadoClientes.TabIndex = 111;
            this.mrcListadoClientes.TabStop = false;
            this.mrcListadoClientes.Text = "Listado de Clientes";
            // 
            // cbClientes
            // 
            this.cbClientes.FormattingEnabled = true;
            this.cbClientes.Location = new System.Drawing.Point(181, 23);
            this.cbClientes.Name = "cbClientes";
            this.cbClientes.Size = new System.Drawing.Size(147, 24);
            this.cbClientes.TabIndex = 1;
            this.cbClientes.SelectedIndexChanged += new System.EventHandler(this.cbClientes_SelectedIndexChanged);
            // 
            // frmBuscarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1046, 330);
            this.Controls.Add(this.cbClientes);
            this.Controls.Add(this.mrcListadoClientes);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdCancelar);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.mrcInformacion);
            this.Controls.Add(this.lbCliente);
            this.Name = "frmBuscarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Clientes";
            this.Load += new System.EventHandler(this.frmBuscarClientes_Load);
            this.mrcInformacion.ResumeLayout(false);
            this.mrcInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaClientes)).EndInit();
            this.mrcListadoClientes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdCancelar;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdBuscar;
        private System.Windows.Forms.GroupBox mrcInformacion;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtNombreApellido;
        private System.Windows.Forms.Label lblNombreYApellido;
        private System.Windows.Forms.MaskedTextBox mskTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Button cmdExportarCli;
        private System.Windows.Forms.Button cmdConsultarCliente;
        private System.Windows.Forms.DataGridView GrillaClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox mrcListadoClientes;
        private System.Windows.Forms.ComboBox cbClientes;
    }
}