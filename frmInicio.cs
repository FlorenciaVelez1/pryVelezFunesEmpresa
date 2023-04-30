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
        private void registarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistarProducto RegistrarProducto = new frmRegistarProducto();
            RegistrarProducto.ShowDialog();
        }
        private void buscarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarYListarProductos BuscarProducto = new frmBuscarYListarProductos();
            BuscarProducto.ShowDialog();
        }
        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroVentas RegistrarVentas = new frmRegistroVentas();
            RegistrarVentas.ShowDialog();
        }
        private void buscarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarYListarVentas buscarYListarVentas = new frmBuscarYListarVentas();
            buscarYListarVentas.ShowDialog();
        }
    }
}
