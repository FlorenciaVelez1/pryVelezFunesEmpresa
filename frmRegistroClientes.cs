using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryVelezFunesEmpresa
{
    public partial class frmRegistroClientes : Form
    {
        public frmRegistroClientes()
        {
            InitializeComponent();
        }

        private void frmRegistroClientes_Load(object sender, EventArgs e)
        {
            cmdRegistrar.Enabled = false;
            try
            {
                OleDbConnection Conexion = new OleDbConnection();
                OleDbCommand Comando = new OleDbCommand();
                OleDbDataAdapter Adaptador = new OleDbDataAdapter();
                string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:BaseDatosTP.accdb";
                Conexion = new OleDbConnection(Ruta);
                Conexion.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido conectar a la base de datos.");
            }
        }
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Limpieza()
        {
            txtNombreApellido.Text = "";
            txtDomicilio.Text = "";
            mskIDCliente.Text = "";
            mskTelefono.Text = "";
        }
        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            Limpieza();
        }
        private void Chequeo()
        {
            if (mskIDCliente.Text != "" & txtNombreApellido.Text != "" & txtDomicilio.Text != "" & mskTelefono.Text != "" )
            {
                cmdRegistrar.Enabled = true;
            }
            else
            {
                cmdRegistrar.Enabled = false;
            }
        }
        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            clsClientes RegistroClientes = new clsClientes();
            RegistroClientes.Buscar(Convert.ToInt32(mskIDCliente.Text));
            if (RegistroClientes.varBandera == true)
            {
                RegistroClientes.ClienteID = Convert.ToInt32(mskIDCliente.Text);
                RegistroClientes.Nom_Apellido = txtNombreApellido.Text;
                RegistroClientes.DomicilioCliente = txtDomicilio.Text;
                RegistroClientes.TelefonoCliente = Convert.ToInt32(mskTelefono.Text);
                RegistroClientes.Agregar();
                Limpieza();
            }
            else
            {
                MessageBox.Show("El ID Socio ya se encuentra registrado, verifique los datos.");
            }
        }
        private void mskIDCliente_TextChanged(object sender, EventArgs e)
        {
            Chequeo();
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
