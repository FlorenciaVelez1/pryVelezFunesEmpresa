namespace pryVelezFunesEmpresa
{
    partial class frmListado
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
            this.GrillaClientes = new System.Windows.Forms.DataGridView();
            this.columIDSocioCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columNomApellCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columDireccCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columTelefonoCli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdExportarCli = new System.Windows.Forms.Button();
            this.cmdSalirCliente = new System.Windows.Forms.Button();
            this.cmdConsultarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaClientes
            // 
            this.GrillaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columIDSocioCli,
            this.columNomApellCli,
            this.columDireccCli,
            this.columTelefonoCli});
            this.GrillaClientes.Location = new System.Drawing.Point(2, -1);
            this.GrillaClientes.Margin = new System.Windows.Forms.Padding(4);
            this.GrillaClientes.Name = "GrillaClientes";
            this.GrillaClientes.ReadOnly = true;
            this.GrillaClientes.RowHeadersVisible = false;
            this.GrillaClientes.RowHeadersWidth = 51;
            this.GrillaClientes.Size = new System.Drawing.Size(503, 363);
            this.GrillaClientes.TabIndex = 39;
            // 
            // columIDSocioCli
            // 
            this.columIDSocioCli.HeaderText = "ID Socio";
            this.columIDSocioCli.MinimumWidth = 6;
            this.columIDSocioCli.Name = "columIDSocioCli";
            this.columIDSocioCli.ReadOnly = true;
            this.columIDSocioCli.Width = 125;
            // 
            // columNomApellCli
            // 
            this.columNomApellCli.HeaderText = "Nombre y Apellido";
            this.columNomApellCli.MinimumWidth = 6;
            this.columNomApellCli.Name = "columNomApellCli";
            this.columNomApellCli.ReadOnly = true;
            this.columNomApellCli.Width = 125;
            // 
            // columDireccCli
            // 
            this.columDireccCli.HeaderText = "Domicilio";
            this.columDireccCli.MinimumWidth = 6;
            this.columDireccCli.Name = "columDireccCli";
            this.columDireccCli.ReadOnly = true;
            this.columDireccCli.Width = 125;
            // 
            // columTelefonoCli
            // 
            this.columTelefonoCli.HeaderText = "Telefono";
            this.columTelefonoCli.MinimumWidth = 6;
            this.columTelefonoCli.Name = "columTelefonoCli";
            this.columTelefonoCli.ReadOnly = true;
            this.columTelefonoCli.Width = 125;
            // 
            // cmdExportarCli
            // 
            this.cmdExportarCli.Enabled = false;
            this.cmdExportarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportarCli.Location = new System.Drawing.Point(196, 382);
            this.cmdExportarCli.Name = "cmdExportarCli";
            this.cmdExportarCli.Size = new System.Drawing.Size(115, 33);
            this.cmdExportarCli.TabIndex = 42;
            this.cmdExportarCli.Text = "Exportar";
            this.cmdExportarCli.UseVisualStyleBackColor = true;
            this.cmdExportarCli.Click += new System.EventHandler(this.cmdExportarCli_Click);
            // 
            // cmdSalirCliente
            // 
            this.cmdSalirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalirCliente.Location = new System.Drawing.Point(2, 382);
            this.cmdSalirCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSalirCliente.Name = "cmdSalirCliente";
            this.cmdSalirCliente.Size = new System.Drawing.Size(115, 33);
            this.cmdSalirCliente.TabIndex = 41;
            this.cmdSalirCliente.Text = "Salir";
            this.cmdSalirCliente.UseVisualStyleBackColor = true;
            this.cmdSalirCliente.Click += new System.EventHandler(this.cmdSalirCliente_Click);
            // 
            // cmdConsultarCliente
            // 
            this.cmdConsultarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultarCliente.Location = new System.Drawing.Point(390, 382);
            this.cmdConsultarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cmdConsultarCliente.Name = "cmdConsultarCliente";
            this.cmdConsultarCliente.Size = new System.Drawing.Size(115, 33);
            this.cmdConsultarCliente.TabIndex = 40;
            this.cmdConsultarCliente.Text = "Consultar";
            this.cmdConsultarCliente.UseVisualStyleBackColor = true;
            this.cmdConsultarCliente.Click += new System.EventHandler(this.cmdConsultarCliente_Click);
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 438);
            this.Controls.Add(this.cmdExportarCli);
            this.Controls.Add(this.cmdSalirCliente);
            this.Controls.Add(this.cmdConsultarCliente);
            this.Controls.Add(this.GrillaClientes);
            this.Name = "frmListado";
            this.Text = "Listado";
            ((System.ComponentModel.ISupportInitialize)(this.GrillaClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GrillaClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn columIDSocioCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn columNomApellCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn columDireccCli;
        private System.Windows.Forms.DataGridViewTextBoxColumn columTelefonoCli;
        private System.Windows.Forms.Button cmdExportarCli;
        private System.Windows.Forms.Button cmdSalirCliente;
        private System.Windows.Forms.Button cmdConsultarCliente;
    }
}