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
            cbVendedor.SelectedIndex = -1;
            //Lleno los cb con la informacion de la base
            clsEmpleados objEmpleados = new clsEmpleados();
            objEmpleados.LlenarCbNomVendedores(cbVendedor);
            cbVendedor.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbVendedor.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbVendedor.SelectedIndex = -1;
        }
        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            clsVentas objVentas = new clsVentas();
            string NomVendedor = cbVendedor.Text;
            DateTime FechaDesde = dtpFechaDesde.Value.Date;
            DateTime FechaHasta = dtpFechaHasta.Value.Date;
            if (bvVendedor.Checked == true)
            {
                objVentas.ListarGrillaPorVend(GrillaVentas, NomVendedor, FechaDesde, FechaHasta, chartPastel);
            }
            else 
            {
                objVentas.ListarGrillaPorFecha(GrillaVentas, FechaDesde, FechaHasta, chartPastel);
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
