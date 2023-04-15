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
    public partial class frmBuscarClientes : Form
    {
        public frmBuscarClientes()
        {
            InitializeComponent();
        }
        private void frmBuscarClientes_Load(object sender, EventArgs e)
        {
            //Deshabilito los botones
            cmdEliminar.Enabled = false;
            cmdModificar.Enabled = false;
            cmdGuardar.Enabled = false;
            cmdBuscar.Enabled = false;
            cmdCancelar.Visible = false;
        }
        private void NoEditarTXT()
        {
            txtNombreApellido.ReadOnly = true;
            txtDomicilio.ReadOnly = true;
            mskTelefono.ReadOnly = true;
        }
        private void Limpiar()
        {
            //Limpio los txt y lst
            mskIdCliente.Text = "";
            txtNombreApellido.Text = "";
            txtDomicilio.Text = "";
            mskTelefono.Text = "";
            //Deshabilito los botones
            cmdEliminar.Enabled = false;
            cmdModificar.Enabled = false;
            cmdGuardar.Enabled = false;
            NoEditarTXT();
            mskIdCliente.Focus();
        }
        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            Int32 IDCLIENTE = Convert.ToInt32(mskIdCliente.Text);
            //Llamo la clase para poder llenar los txt y msk con la informacion correspondiente
            clsClientes BuscarCliente = new clsClientes();
            BuscarCliente.Buscar(IDCLIENTE);
            if (BuscarCliente.ClienteID != IDCLIENTE)
            {
                MessageBox.Show("El ID de Socio ingresado no se encuentra en la base de datos.");
            }
            else
            {
                txtNombreApellido.Text = BuscarCliente.Nom_Apellido;
                txtDomicilio.Text = BuscarCliente.DomicilioCliente;
                mskTelefono.Text = Convert.ToString(BuscarCliente.TelefonoCliente);
                //habilito los botones
                cmdEliminar.Enabled = true;
                cmdModificar.Enabled = true;
                NoEditarTXT();
            }
        }
        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            Int32 IDCLIENTE = Convert.ToInt32(mskIdCliente.Text);
            clsClientes EliminarCliente = new clsClientes();
            EliminarCliente.Eliminar(IDCLIENTE);
            Limpiar();
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
            mskIdCliente.ReadOnly = false;
        }
        private void cmdModificar_Click(object sender, EventArgs e)
        {
            //Deshabilito los botones que no uso
            cmdEliminar.Enabled = false;
            cmdModificar.Enabled = false;
            cmdBuscar.Enabled = false;
            cmdGuardar.Enabled = true;
            cmdCancelar.Visible = true;
            //Desabilito mskIdSocio
            mskIdCliente.ReadOnly = true;
            //Habilito los txt, msk y lst
            txtNombreApellido.ReadOnly = false;
            txtDomicilio.ReadOnly = false;
            mskTelefono.ReadOnly = false;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            int IDCLIENTE = Convert.ToInt32(mskIdCliente.Text);
            clsClientes ModificarCliente = new clsClientes();
            ModificarCliente.Nom_Apellido = txtNombreApellido.Text;
            ModificarCliente.DomicilioCliente = txtDomicilio.Text;
            ModificarCliente.TelefonoCliente = Convert.ToInt32(mskTelefono.Text);
            ModificarCliente.Modificar(IDCLIENTE);
            Limpiar();
        }
        private void mskIdCliente_TextChanged(object sender, EventArgs e)
        {
            if (mskIdCliente.Text != "")
            {
                cmdBuscar.Enabled = true;
            }
            else
            {
                cmdBuscar.Enabled = false;
            }
        }
        private void Chequeo()
        {
            if (mskIdCliente.Text != "" & txtNombreApellido.Text != "" & txtDomicilio.Text != "" & mskTelefono.Text != "")
            {
                cmdBuscar.Enabled = true;
            }
            else
            {
                cmdBuscar.Enabled = false;
            }
        }

        private void txtNombreApellido_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void txtDomicilio_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void mskTelefono_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
        }
        private void txtNombreApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan letras");
            }
        }
    }
}
