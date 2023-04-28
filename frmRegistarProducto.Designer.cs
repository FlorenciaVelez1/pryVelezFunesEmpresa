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
            this.mrcInformacionProducto = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // mrcInformacionProducto
            // 
            this.mrcInformacionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcInformacionProducto.Location = new System.Drawing.Point(12, 12);
            this.mrcInformacionProducto.Name = "mrcInformacionProducto";
            this.mrcInformacionProducto.Size = new System.Drawing.Size(472, 426);
            this.mrcInformacionProducto.TabIndex = 0;
            this.mrcInformacionProducto.TabStop = false;
            this.mrcInformacionProducto.Text = "Información del Producto";
            // 
            // frmRegistarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 493);
            this.Controls.Add(this.mrcInformacionProducto);
            this.Name = "frmRegistarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registar de Producto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcInformacionProducto;
    }
}