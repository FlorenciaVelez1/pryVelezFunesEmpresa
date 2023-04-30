using System;
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
        private Int32 varIdVenta;
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
        public Int32 IdVenta
        {
            get { return varIdVenta; }
            set { varIdVenta = value; }
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
        public void BuscarVenta(Int32 IDVenta)
        {
            varBandera = true;
            try
            {
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = "Ventas";
                //Recibe el contenido de la tabla
                OleDbDataReader Lector = Comando.ExecuteReader();
                //Si hay filas que leer entra en el "si"
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetInt32(0) == IDVenta)
                        {
                            IdVenta = Lector.GetInt32(0);
                            IdCliente = Lector.GetInt32(1);
                            IdProducto = Lector.GetInt32(2);
                            Cantidad = Lector.GetInt32(3);
                            FormaPago = Lector.GetString(4);
                            Fecha = Lector.GetDateTime(5).ToString("dd/MM/yyyy");
                            TotalPago = Lector.GetInt32(6);
                            IdVendedor = Lector.GetInt32(7);
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
        public void Eliminar(Int32 IDVENTA)
        {
            try
            {
                string Sql = "DELETE FROM Ventas WHERE (" + IDVENTA + "= [Id Venta])";
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = Sql;
                Comando.ExecuteNonQuery();
                Conexion.Close();
                MessageBox.Show("Datos borrados con exito");

            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido eliminar la informacion de la venta correctamente");
            }
        }
        public void Modificar(Int32 IDVENTA)
        {
            try
            {
                string Sql = "UPDATE Ventas SET [Id Cliente]= " + IdCliente + ", [Id Producto]= " + IdProducto + ", [Cantidad]= " +
                    Cantidad + ", [Forma de Pago]= '" + FormaPago + "', [Fecha Venta]= "+ Fecha + ", [Total Pago]= " + TotalPago + ", [Vendedor]= " + IdVendedor + " WHERE [Id Venta] = " + IDVENTA + "";
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = Sql;
                Comando.ExecuteNonQuery();
                Conexion.Close();
                MessageBox.Show("La informacion ha sido modificada exitosamente.");
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido modificar la informacion.");
            }
        }
    }
}
