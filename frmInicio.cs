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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        private void tsmRegistrarCliente_Click(object sender, EventArgs e)
        {
            frmRegistroClientes Registrar = new frmRegistroClientes();
            Registrar.ShowDialog();
        }

        private void tsmBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarClientes Buscar = new frmBuscarClientes();
            Buscar.ShowDialog();
        }

        private void tsmClientes_Click(object sender, EventArgs e)
        {
            frmListado ListadoClientes = new frmListado();
            ListadoClientes.ShowDialog();
        }
    }
}
