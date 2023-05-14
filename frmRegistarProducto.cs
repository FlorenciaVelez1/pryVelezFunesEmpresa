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
    public partial class frmRegistarProducto : Form
    {
        public frmRegistarProducto()
        {
            InitializeComponent();
        }
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmRegistarProducto_Load(object sender, EventArgs e)
        {
            clsProductos CompletarCb = new clsProductos();
            CompletarCb.LlenarCbTipoProducto(cbTipoProducto);
            //Cancelo el cmdRegistrar
            cmdAgregar.Enabled = false;
            cbTipoProducto.SelectedIndex = -1;
        }
        private void Limpieza()
        {
            mskIdProducto.Text = "";
            txtNombreProducto.Text = "";
            txtDescripcion.Text = "";
            cbTipoProducto.SelectedIndex = -1;
            mskCostoMayorista.Text = "";
            mskCostoMinorista.Text = "";
            mskIdProducto.Focus();
        }
        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            Limpieza();
        }
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsProductos RegistroProducto = new clsProductos();
            RegistroProducto.Buscar(Convert.ToInt32(mskIdProducto.Text));
            if (RegistroProducto.varBandera == true)
            {
                RegistroProducto.IdProducto = Convert.ToInt32(mskIdProducto.Text);
                RegistroProducto.NombreProducto = txtNombreProducto.Text;
                RegistroProducto.CodTipoProducto = Convert.ToInt32( cbTipoProducto.SelectedValue);
                RegistroProducto.CostoMinorista = Convert.ToDecimal(mskCostoMinorista.Text);
                RegistroProducto.CostoMayorista = Convert.ToDecimal(mskCostoMayorista.Text);
                RegistroProducto.Descripcion = txtDescripcion.Text;
                RegistroProducto.Agregar();
                Limpieza();
            }
            else
            {
                MessageBox.Show("El ID Socio ya se encuentra registrado, verifique los datos.");
            }
        }
        public void Chequeo()
        {
            if (mskIdProducto.Text != "" & txtDescripcion.Text != "" & cbTipoProducto.SelectedIndex != -1 & mskCostoMinorista.Text != "" & mskCostoMayorista.Text != "" & txtDescripcion.Text != "")
            {
                cmdAgregar.Enabled = true;
            }
            else
            {
                cmdAgregar.Enabled = false;
            }
        }
        private void mskIdProducto_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void cbTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void mskCostoMinorista_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void mskCostoMayorista_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
            if (mskCostoMinorista.Text != "" & mskCostoMayorista.Text != "")
            {   
                if (Convert.ToDecimal( mskCostoMayorista.Text) > Convert.ToDecimal( mskCostoMinorista.Text))
                {
                MessageBox.Show("El costo mayorista no puede ser mayor al costo minorista, verifique los datos nuevamente.");
                }
            }
        }
        private void mskIdProducto_Leave(object sender, EventArgs e)
        {
            if (mskIdProducto.Text != "")
            {
                clsProductos RegistroProducto = new clsProductos();
                RegistroProducto.Buscar(Convert.ToInt32(mskIdProducto.Text));
                if (RegistroProducto.varBandera == false)
                {
                    MessageBox.Show("El Id del Producto ya se encuentra registrado, verifique los datos ingresados.");
                    mskIdProducto.Focus();
                }
            }
        }
    }
}
