﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;

namespace pryVelezFunesEmpresa
{
    internal class clsVentas
    {
        //Conexion a la base de datos
        private OleDbConnection Conexion = new OleDbConnection();
        private OleDbCommand Comando = new OleDbCommand();
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        //Agrego la ruta
        private string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:BaseDatosTP.accdb";
        private string Tabla = "Ventas";
        //Creo las variables de forma local
        private Int32 varIdVendedor;
        private Int32 varIdProducto;
        private Int32 varIdCliente;
        private Int32 varCantidad;
        private string varFormaPago;
        private string varFechaVenta;
        private decimal varTotalPago;
        private string varnomVendedor;
        //Creo un booleano para verificar informacion
        public bool varBandera;
        public Int32 IdProducto
        {
            get { return varIdProducto; }
            set { varIdProducto = value; }
        }
        public Int32 IdVendedor
        {
            get { return varIdVendedor; }
            set { varIdVendedor = value; }
        }
        public Int32 IdCliente
        {
            get { return varIdCliente; }
            set { varIdCliente = value; }
        }
        public Int32 Cantidad
        {
            get { return varCantidad; }
            set { varCantidad = value; }
        }
        public string FormaPago
        {
            get { return varFormaPago; }
            set { varFormaPago = value; }
        }
        public string Fecha
        {
            get { return varFechaVenta; }
            set { varFechaVenta = value; }
        }
        public decimal TotalPago
        {
            get { return varTotalPago; }
            set { varTotalPago = value; }
        }
        public string nomVendedor
        {
            get { return varnomVendedor; }
            set { varnomVendedor = value; }
        }
        public void CalcularTotalVenta( Int32 IdProducto)
        {
            clsProductos BusquedaCosto = new clsProductos();
            BusquedaCosto.Buscar(IdProducto);
            if ( Cantidad > 5)
            {
                TotalPago = Cantidad * BusquedaCosto.CostoMayorista;
            }
            else
            {
                TotalPago = Cantidad * BusquedaCosto.CostoMinorista;
            }
        }
        public void Agregar()
        {
            try
            {
                //Instruccion sql, creo variable con la intruccion concatenada y utilizo la variable luego
                string Sql = "INSERT INTO Ventas ([Id Producto],[Id Cliente], [Cantidad], [Forma de Pago], [Fecha Venta], [Total Pago], [Vendedor])" +
                    "VALUES ('" + IdProducto + "','" + IdCliente + "','" + Cantidad + "','" + FormaPago + "','" + Fecha + "','" + TotalPago + "','" + IdVendedor + "')";
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = Sql;
                Comando.ExecuteNonQuery();
                Conexion.Close();
                MessageBox.Show("Se han registrado los datos correctamente.");
            }
            catch (Exception)
            {
                MessageBox.Show("No se han podido registrar los datos.");
            }
        }
        public void LlenarCbNomVendedores(ComboBox cbVendedores)
        {
            Conexion.ConnectionString = Ruta;
            Conexion.Open();
            Comando.Connection = Conexion;
            Comando.CommandType = CommandType.TableDirect;
            Comando.CommandText = "Empleados";
            //Adaptador se conecta con la base y trae los datos y se suben los datos a una tabla "virtual"(dataset)
            Adaptador = new OleDbDataAdapter(Comando);
            //Tabla virtual
            DataSet DataConsulta = new DataSet();
            Adaptador.Fill(DataConsulta);
            cbVendedores.DataSource = DataConsulta.Tables[0];
            //Los datos que queremos que se vean en la lst
            cbVendedores.DisplayMember = "Nombre y Apellido";
            Conexion.Close();
        }
        public void BuscarVendedor(Int32 IdVendedor)
        {
            varBandera = true;
            try
            {
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = "Empleados";
                //Recibe el contenido de la tabla
                OleDbDataReader Lector = Comando.ExecuteReader();
                //Si hay filas que leer entra en el "si"
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetInt32(0) == IdVendedor)
                        {
                            nomVendedor = Lector.GetString(1);
                            varBandera = false;
                        }
                    }
                }
                Conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al buscar el ID del Vendedor.");
            }
        }

        public void ListarGrilla(DataGridView GrillaVentas, string NOMBREVENDEDOR, string TIPOPRODUCTO)
        {
             
        }
    }
}
