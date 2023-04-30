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
    public partial class frmRegistroVentas : Form
    {
        public frmRegistroVentas()
        {
            InitializeComponent();
        }
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        clsVentas RegistroVentas = new clsVentas();
        clsProductos objProductos = new clsProductos();
        clsClientes objClientes = new clsClientes();
        private void frmRegistroVentas_Load(object sender, EventArgs e)
        {
            nudCantidad.Value = 1;
            cbFormaPago.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
        }
        public void Limpieza()
        {
            mskIdCliente.Text = "";
            mskIdProducto.Text = "";
            mskVendedor.Text = "";
            nudCantidad.Value = 1;
            cbFormaPago.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
        }
        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            Limpieza();
        }
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            RegistroVentas.BuscarVendedor(Convert.ToInt32(mskVendedor.Text));
            objProductos.Buscar(Convert.ToInt32(mskIdProducto.Text));
            objClientes.Buscar(Convert.ToInt32(mskIdCliente.Text));
            if (RegistroVentas.varBandera == false & objProductos.varBandera == false & objClientes.varBandera == false)
            {
                RegistroVentas.IdProducto = Convert.ToInt32(mskIdProducto.Text);
                RegistroVentas.IdCliente = Convert.ToInt32(mskIdCliente.Text);
                RegistroVentas.IdVendedor = Convert.ToInt32(mskVendedor.Text);
                RegistroVentas.Cantidad = Convert.ToInt32( nudCantidad.Value);
                RegistroVentas.Fecha = dtpFecha.Value.ToString("dd/MM/yyyy");
                RegistroVentas.FormaPago = Convert.ToString( cbFormaPago.SelectedItem);
                RegistroVentas.CalcularTotalVenta(Convert.ToInt32(mskIdProducto.Text));
                RegistroVentas.Agregar();
                Limpieza();
            }
            else
            {
                MessageBox.Show("Revise los datos nuevamente, id no registrado.");
            }
        }
        public void Chequeo()
        {
            if (mskIdProducto.Text != "" & mskIdCliente.Text != "" & cbFormaPago.SelectedIndex != -1 & mskVendedor.Text != "")
            {
                cmdAgregar.Enabled = true;
            }
            else
            {
                cmdAgregar.Enabled = false;
            }
        }
        private void mskVendedor_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void mskIdProducto_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void mskIdCliente_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void cbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void mskVendedor_Leave(object sender, EventArgs e)
        {
            if (mskVendedor.Text != "")
            { RegistroVentas.BuscarVendedor(Convert.ToInt32(mskVendedor.Text));
              if (RegistroVentas.varBandera == true)
              {
                MessageBox.Show("El Id del Vendedor no se encuentra registrado, verifique los datos ingresados.");
                mskVendedor.Focus();
              }
            }
        }
        private void mskIdProducto_Leave(object sender, EventArgs e)
        {
            if (mskIdProducto.Text != "")
            {
                objProductos.Buscar(Convert.ToInt32(mskIdProducto.Text));
                if (objProductos.varBandera == true)
                {
                    MessageBox.Show("El Id del Producto no se encuentra registrado, verifique los datos ingresados.");
                    mskIdProducto.Focus();
                }
            }
        }
        private void mskIdCliente_Leave(object sender, EventArgs e)
        {
            if (mskIdCliente.Text != "")
            {
                objClientes.Buscar(Convert.ToInt32(mskIdCliente.Text));
                if (objClientes.varBandera == true)
                {
                    MessageBox.Show("El Id del Cliente no se encuentra registrado, verifique los datos ingresados.");
                    mskIdCliente.Focus();
                }
            }
        }
    }
}
