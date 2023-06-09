﻿using System;
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
            NoEditarTXT();
            clsClientes LlenarCBClientes = new clsClientes();
            LlenarCBClientes.LlenarNomClientes(cbClientes);
            cbClientes.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbClientes.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbClientes.SelectedIndex = -1;
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
            txtNombreApellido.Text = "";
            txtDomicilio.Text = "";
            mskTelefono.Text = "";
            //Deshabilito los botones
            cmdEliminar.Enabled = false;
            cmdModificar.Enabled = false;
            cmdGuardar.Enabled = false;
            NoEditarTXT();
        }
        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            string CLIENTE = cbClientes.Text;
            //Llamo la clase para poder llenar los txt y msk con la informacion correspondiente
            clsClientes BuscarCliente = new clsClientes();
            BuscarCliente.BuscarPorNomCliente(CLIENTE);
            txtNombreApellido.Text = BuscarCliente.Nom_Apellido;
            txtDomicilio.Text = BuscarCliente.DomicilioCliente;
            mskTelefono.Text = Convert.ToString(BuscarCliente.TelefonoCliente);
            //habilito los botones
            cmdEliminar.Enabled = true;
            cmdModificar.Enabled = true;
            NoEditarTXT();

        }
        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            string CLIENTE = cbClientes.Text;
            clsClientes EliminarCliente = new clsClientes();
            EliminarCliente.Eliminar(CLIENTE);
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
        }
        private void cmdModificar_Click(object sender, EventArgs e)
        {
            //Deshabilito los botones que no uso
            cmdEliminar.Enabled = false;
            cmdModificar.Enabled = false;
            cmdBuscar.Enabled = false;
            cmdGuardar.Enabled = true;
            cmdCancelar.Visible = true;
            //Habilito los txt, msk y lst
            txtNombreApellido.ReadOnly = false;
            txtDomicilio.ReadOnly = false;
            mskTelefono.ReadOnly = false;
        }
        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            string CLIENTE = cbClientes.Text;
            clsClientes ModificarCliente = new clsClientes();
            ModificarCliente.BuscarPorNomCliente(CLIENTE);
            ModificarCliente.Nom_Apellido = txtNombreApellido.Text;
            ModificarCliente.DomicilioCliente = txtDomicilio.Text;
            ModificarCliente.TelefonoCliente = Convert.ToInt32(mskTelefono.Text);
            ModificarCliente.Modificar(CLIENTE);
            Limpiar();
        }
        private void Chequeo()
        {
            if (cbClientes.SelectedIndex != -1 & txtNombreApellido.Text != "" & txtDomicilio.Text != "" & mskTelefono.Text != "")
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
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cmdConsultarCliente_Click(object sender, EventArgs e)
        {
            cmdExportarCli.Enabled = true;
            clsClientes ConsultaCli = new clsClientes();
            ConsultaCli.ListarGrillaClientes(GrillaClientes);
        }
        private void cmdExportarCli_Click(object sender, EventArgs e)
        {
            clsClientes ExportarClientes = new clsClientes();
            ExportarClientes.ExportarClientes();
        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClientes.SelectedIndex != -1)
            {
                cmdBuscar.Enabled = true;
            }
            else
            {
                cmdBuscar.Enabled = false;
            }
        }
    }
}
