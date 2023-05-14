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
            dtpFechaHasta.Value = DateTime.Now;
            dtpFechaDesde.Value = DateTime.Now;
            cbTipoProducto.SelectedIndex = -1;
            cbVendedor.SelectedIndex = -1;
            //Lleno los cb con la informacion de la base
            clsVentas LlenarCbVendedores = new clsVentas();
            LlenarCbVendedores.LlenarCbNomVendedores(cbVendedor);
            cbVendedor.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbVendedor.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbVendedor.SelectedIndex = -1;
            clsProductos CompletarCb = new clsProductos();
            CompletarCb.LlenarCbTipoProducto(cbTipoProducto);
            cbTipoProducto.SelectedIndex = -1;
        }
        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            clsVentas objVentas = new clsVentas();
            string TipoProducto = cbTipoProducto.Text;
            string NomVendedor = cbVendedor.Text;
            if(bvVendedor.Checked == true & bvTipoProducto.Checked == true)
            {
                objVentas.ListarGrilla(GrillaVentas, NomVendedor, TipoProducto);
            }
            else if(bvVendedor.Checked == true)
            {

            }
            else if(bvTipoProducto.Checked == true)
            {

            }
        }
        private void dtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            if ( dtpFechaDesde.Value > dtpFechaHasta.Value )
            {
                MessageBox.Show("La fecha ingresada debe en hasta no puede ser anterior a la fecha ingreada en desde");
                dtpFechaHasta.Value = DateTime.Now;
            }
        }
    }
}
