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
            //Lleno los cb con la informacion de la base
            clsProductos LlenarCb = new clsProductos();
            LlenarCb.LlenarCbNomProductos(cbProducto);
            cbProducto.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbProducto.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbProducto.SelectedIndex = -1;
            mskIdProducto.Text = "";
            clsClientes LlenarCBClientes = new clsClientes();
            LlenarCBClientes.LlenarNomClientes(cbNomClientes);
            cbNomClientes.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbNomClientes.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbNomClientes.SelectedIndex = -1;
            mskIdCliente.Text = "";
        }
        public void Limpieza()
        {
            cbProducto.SelectedIndex = -1;
            cbNomClientes.SelectedIndex = -1;
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
            objProductos.BuscarPorIdProducto(Convert.ToInt32(mskIdProducto.Text));
            objClientes.BuscarPorIdCliente(Convert.ToInt32(mskIdCliente.Text));
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
        private void cbNomClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsClientes BuscarIDCliente = new clsClientes();
            BuscarIDCliente.BuscarPorNomCliente(cbNomClientes.Text);
            if (BuscarIDCliente.varBandera == false)
            {
                mskIdCliente.Text = Convert.ToString(BuscarIDCliente.ClienteID);
            }
        }
        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsProductos BuscarIDProducto = new clsProductos();
            BuscarIDProducto.BuscarPorNomProducto(cbProducto.Text);
            if (BuscarIDProducto.varBandera == false)
            {
                mskIdProducto.Text = Convert.ToString(BuscarIDProducto.IdProducto);
            }
        }
    }
}
