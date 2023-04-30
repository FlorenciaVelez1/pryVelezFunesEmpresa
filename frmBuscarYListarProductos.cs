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
    public partial class frmBuscarYListarProductos : Form
    {
        public frmBuscarYListarProductos()
        {
            InitializeComponent();
        }
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void NoEditarTXT()
        {
            txtNombreProducto.ReadOnly = true;
            txtDescripcion.ReadOnly = true;
            cbTipoProducto.Enabled = false;
            mskCostoMayorista.ReadOnly = true;
            mskCostoMinorista.ReadOnly = true;
        }
        private void frmBuscarYListarProductos_Load(object sender, EventArgs e)
        {
            //Deshabilito los botones
            cmdEliminar.Enabled = false;
            cmdModificar.Enabled = false;
            cmdGuardar.Enabled = false;
            cmdBuscar.Enabled = false;
            cmdCancelar.Visible = false;
            NoEditarTXT();
            clsProductos CompletarComboBox = new clsProductos();
            CompletarComboBox.LlenarCb(cbTipoProducto);
            cbTipoProducto.SelectedIndex = -1;
        }
        public void Limpieza()
        {
            mskIdProducto.Text = "";
            txtNombreProducto.Text = "";
            txtDescripcion.Text = "";
            cbTipoProducto.SelectedIndex = -1;
            mskCostoMayorista.Text = "";
            mskCostoMinorista.Text = "";
            //Deshabilito los botones
            cmdEliminar.Enabled = false;
            cmdModificar.Enabled = false;
            cmdGuardar.Enabled = false;
            NoEditarTXT();
            mskIdProducto.Focus();
            mskIdProducto.ReadOnly = false;
        }
        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            Int32 IDPRODUCTO = Convert.ToInt32(mskIdProducto.Text);
            clsProductos BuscarProducto = new clsProductos();
            BuscarProducto.Buscar(IDPRODUCTO);
            if (BuscarProducto.IdProducto != IDPRODUCTO)
            {
                MessageBox.Show("El ID del Producto ingresado no se encuentra en la base de datos.");
            }
            else
            {
                BuscarProducto.BuscarTipoDeProducto(BuscarProducto.CodTipoProducto);
                txtNombreProducto.Text = BuscarProducto.NombreProducto;
                txtDescripcion.Text = BuscarProducto.Descripcion;
                mskCostoMinorista.Text = Convert.ToString(BuscarProducto.CostoMinorista);
                mskCostoMayorista.Text = Convert.ToString(BuscarProducto.CostoMayorista);
                cbTipoProducto.Text =  BuscarProducto.TipoProducto;
                //habilito los botones
                cmdEliminar.Enabled = true;
                cmdModificar.Enabled = true;
                NoEditarTXT();
            }
        }
        private void mskIdProducto_TextChanged(object sender, EventArgs e)
        {
            if (mskIdProducto.Text != "")
            {
                cmdBuscar.Enabled = true;
            }
            else
            {
                cmdBuscar.Enabled = false;
            }
        }
        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            int IDPRODUCTO = Convert.ToInt32(mskIdProducto.Text);
            clsProductos ModificarProducto = new clsProductos();
            ModificarProducto.NombreProducto = txtNombreProducto.Text;
            ModificarProducto.CodTipoProducto = Convert.ToInt32( cbTipoProducto.SelectedValue);
            ModificarProducto.CostoMinorista = Convert.ToDecimal(mskCostoMinorista.Text);
            ModificarProducto.CostoMayorista = Convert.ToDecimal(mskCostoMayorista.Text);
            ModificarProducto.Descripcion = txtDescripcion.Text;
            ModificarProducto.Modificar(IDPRODUCTO);
            Limpieza();
        }
        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            clsProductos ConsultarProductos = new clsProductos();
            ConsultarProductos.ListarGrillaProductos(GrillaProductos);
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
            txtNombreProducto.ReadOnly = false;
            txtDescripcion.ReadOnly = false;
            mskCostoMinorista.ReadOnly = false;
            mskCostoMayorista.ReadOnly = false;
            cbTipoProducto.Enabled = true;
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            Int32 IDPRODUCTO = Convert.ToInt32(mskIdProducto.Text);
            clsProductos EliminarCliente = new clsProductos();
            EliminarCliente.Eliminar(IDPRODUCTO);
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
        public void Chequeo()
        {
            if (txtNombreProducto.Text != "" & txtDescripcion.Text != "" & mskCostoMayorista.Text != "" & mskCostoMinorista.Text != "" & cbTipoProducto.SelectedIndex != -1)
            {
                cmdGuardar.Enabled = true;
            }
            else
            {
                cmdGuardar.Enabled=false;
            }
        }
        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void cbTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void mskCostoMinorista_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
            if (mskCostoMinorista.Text != "" & mskCostoMayorista.Text != "")
            {
                if (Convert.ToDecimal(mskCostoMayorista.Text) > Convert.ToDecimal(mskCostoMinorista.Text))
                {
                    MessageBox.Show("El costo mayorista no puede ser mayor al costo minorista, verifique los datos nuevamente.");
                }
            }
        }
        private void mskCostoMayorista_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
            if (mskCostoMinorista.Text != "" & mskCostoMayorista.Text != "")
            {
                if (Convert.ToDecimal(mskCostoMayorista.Text) > Convert.ToDecimal(mskCostoMinorista.Text))
                {
                    MessageBox.Show("El costo mayorista no puede ser mayor al costo minorista, verifique los datos nuevamente.");
                }
            }
        }
    }
}
