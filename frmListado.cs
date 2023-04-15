using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryVelezFunesEmpresa
{
    public partial class frmListado : Form
    {
        public frmListado()
        {
            InitializeComponent();
        }

        private void cmdSalirCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdConsultarCliente_Click(object sender, EventArgs e)
        {
            clsClientes ConsultaClientes = new clsClientes();
            ConsultaClientes.ListarGrillaClientes(GrillaClientes);
        }

        private void cmdExportarCli_Click(object sender, EventArgs e)
        {
            clsClientes ExportarClientes = new clsClientes();
            ExportarClientes.ExportarClientes();
        }
    }
}
