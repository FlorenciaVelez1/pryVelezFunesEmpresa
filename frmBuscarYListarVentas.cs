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
    public partial class frmBuscarYListarVentas : Form
    {
        public frmBuscarYListarVentas()
        {
            InitializeComponent();
        }
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmBuscarYListarVentas_Load(object sender, EventArgs e)
        {
            //Deshabilito los botones
            cmdEliminar.Enabled = false;
            cmdModificar.Enabled = false;
            cmdGuardar.Enabled = false;
            cmdBuscar.Enabled = false;
            cmdCancelar.Visible = false;
            NoEditarTXT();
            cbFormaPago.SelectedIndex = -1;
        }
        public void NoEditarTXT()
        {
            mskIdCliente.ReadOnly = true;
            mskIdProducto.ReadOnly = true;
            mskVendedor.ReadOnly = true;
            nudCantidad.Enabled = false;
            cbFormaPago.Enabled = false;
            dtpFecha.Enabled = false;
        }
        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            Int32 IDVENTA = Convert.ToInt32(mskIdVenta.Text);
            clsVentas BuscarVenta = new clsVentas();
            BuscarVenta.BuscarVenta(IDVENTA);
            if (BuscarVenta.IdVenta != IDVENTA)
            {
                MessageBox.Show("El ID de la Venta ingresado no se encuentra en la base de datos.");
            }
            else
            {
                mskIdCliente.Text = BuscarVenta.IdCliente.ToString(); 
                mskIdProducto.Text = BuscarVenta.IdProducto.ToString();
                mskVendedor.Text = BuscarVenta.IdVendedor.ToString();
                nudCantidad.Value = Convert.ToInt32( BuscarVenta.Cantidad);
                cbFormaPago.Text = BuscarVenta.FormaPago;
                dtpFecha.Value = Convert.ToDateTime( BuscarVenta.Fecha.ToString()); 
                //habilito los botones
                cmdEliminar.Enabled = true;
                cmdModificar.Enabled = true;
                NoEditarTXT();
            }
        }
        private void mskIdVenta_TextChanged(object sender, EventArgs e)
        {
            if (mskIdVenta.Text != "")
            {
                cmdBuscar.Enabled = true;
            }
            else
            {
                cmdBuscar.Enabled = false;
            }
        }
        public void Limpieza()
        {
            mskIdProducto.Text = "";
            mskIdCliente.Text = "";
            cbFormaPago.SelectedIndex = -1;
            nudCantidad.Value = 0;
            mskVendedor.Text = "";
            dtpFecha.Text = Convert.ToString( DateTime.Now);
            //Deshabilito los botones
            cmdEliminar.Enabled = false;
            cmdModificar.Enabled = false;
            cmdGuardar.Enabled = false;
            NoEditarTXT();
            mskIdVenta.Focus();
            mskIdVenta.ReadOnly = false;
            mskIdVenta.Text = "";
        }
        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            Int32 IDVENTA = Convert.ToInt32(mskIdVenta.Text);
            clsVentas EliminarVenta = new clsVentas();
            EliminarVenta.Eliminar(IDVENTA);
            Limpieza();
        }
        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            NoEditarTXT();
            //habilito  o no los botones
            cmdEliminar.Enabled = true;
            cmdModificar.Enabled = true;
            cmdBuscar.Enabled = true;
            cmdGuardar.Enabled = false;
            cmdCancelar.Visible = false;
            mskIdProducto.ReadOnly = false;
        }
        private void cmdModificar_Click(object sender, EventArgs e)
        {
            //Deshabilito los botones que no uso
            cmdEliminar.Enabled = false;
            cmdModificar.Enabled = false;
            cmdBuscar.Enabled = false;
            cmdGuardar.Enabled = true;
            cmdCancelar.Visible = true;
            //Deshabilito mskId
            mskIdProducto.ReadOnly = true;
            //Habilito los txt, msk y cb
            mskIdCliente.ReadOnly = false;
            mskIdProducto.ReadOnly = false;
            mskVendedor.ReadOnly = false;
            nudCantidad.Enabled = true;
            cbFormaPago.Enabled = true;
            dtpFecha.Enabled = true;
        }
        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            int IDVENTA = Convert.ToInt32(mskIdVenta.Text);
            clsVentas ModificarVenta = new clsVentas();
            ModificarVenta.IdCliente = Convert.ToInt32(mskIdCliente.Text);
            ModificarVenta.IdProducto = Convert.ToInt32(mskIdProducto.Text);
            ModificarVenta.IdVendedor = Convert.ToInt32(mskVendedor.Text);
            ModificarVenta.Cantidad = Convert.ToInt32(nudCantidad.Text);
            ModificarVenta.FormaPago = Convert.ToString( cbFormaPago.SelectedItem);
            ModificarVenta.Fecha = dtpFecha.Value.ToString("dd/MM/yyyy");
            ModificarVenta.Modificar(IDVENTA);
            Limpieza();
        }
    }
}
