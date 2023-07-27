using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

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
            BusquedaCosto.BuscarPorIdProducto(IdProducto);
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
                string Sql = "INSERT INTO Ventas ([Id_Producto],[Id_Cliente], [Cantidad], [Forma_de_Pago], [Fecha_Venta], [Total_Pago], [Vendedor])" +
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
        public void BuscarNomVendedor(string NomVendedor)
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
                        if (Lector.GetString(1) == NomVendedor)
                        {
                            IdVendedor = Lector.GetInt32(0);
                            varBandera = false;
                        }
                    }
                }
                Conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al buscar el nombre del Vendedor.");
            }
        }
        public void ListarGrillaPorVend(DataGridView GrillaVentas, string NOMBREVENDEDOR, DateTime FechaDesde, DateTime FechaHasta)
        {
            try
            {   BuscarNomVendedor(NOMBREVENDEDOR);
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = "SELECT Clientes.Nombre_Apellido, Ventas.Cantidad, Ventas.Forma_de_Pago, Ventas.Fecha_Venta, Ventas.Total_Pago, Productos.Nombre, Tipo_de_Producto.Tipo_de_Producto, Empleados.Nombre_Apellido AS Vendedor FROM((((Clientes INNER JOIN Ventas ON Clientes.Id_Cliente = Ventas.Id_Cliente) INNER JOIN Productos ON Ventas.Id_Producto = Productos.Id_Producto) INNER JOIN Tipo_de_Producto ON Productos.Tipo_de_producto = Tipo_de_Producto.Codigo) INNER JOIN Empleados ON Ventas.Vendedor = Empleados.Id_Empleado) WHERE (Ventas.Fecha_Venta >= #" + FechaDesde.ToString("dd/MMM/yyyy") +  "#) AND (Empleados.Nombre_Apellido = " + NOMBREVENDEDOR + ")";
                Adaptador = new OleDbDataAdapter(Comando);
                DataTable ventasPorNombre = new DataTable();
                Adaptador.Fill(ventasPorNombre);
                if (ventasPorNombre.Rows.Count > 0)
                {
                    foreach (DataRow row in ventasPorNombre.Rows)
                    {
                        GrillaVentas.DataSource = ventasPorNombre;
                    }
                }
                Conexion.Close();
                //Conexion.ConnectionString = Ruta;
                //Conexion.Open();
                //Comando.Connection = Conexion;
                //Comando.CommandType = CommandType.TableDirect;
                //Comando.CommandText = Tabla;
                //GrillaVentas.Rows.Clear();
                //OleDbDataReader Lector = Comando.ExecuteReader();
                //if (Lector.HasRows)
                //{
                //    while (Lector.Read())
                //    {
                //        if (Lector.GetInt32(7) == IdVendedor & Lector.GetDateTime(5) >= FechaDesde & Lector.GetDateTime(5) <= FechaHasta)
                //        {
                //            //llamo las cls para cambiar los numeros por los nombres correspondientes
                //            Int32 IDCLIENTE = Lector.GetInt32(1);
                //            Int32 IDPRODUCTO = Lector.GetInt32(2);
                //            clsClientes objCliente = new clsClientes();
                //            objCliente.BuscarPorIdCliente(IDCLIENTE);
                //            clsProductos objProducto = new clsProductos();
                //            objProducto.BuscarPorIdProducto(IDPRODUCTO);
                //            objProducto.BuscarTipoDeProducto(objProducto.CodTipoProducto);
                //            GrillaVentas.Rows.Add(objCliente.Nom_Apellido, objProducto.NombreProducto, objProducto.TipoProducto, Lector.GetInt32(3), Lector.GetString(4), Lector.GetInt32(6), Lector.GetDateTime(5).ToString("dd/MMM/yyyy"), NOMBREVENDEDOR);

                //        }
                //    }
                //}
                //Conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido cargar la informacion.");
            }
        }
        public void ListarGrillaPorFecha(DataGridView GrillaVentas, DateTime FechaDesde, DateTime FechaHasta, Chart Grafico)
        {
            try
            {
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = "SELECT Clientes.Nombre_Apellido, Ventas.Cantidad, Ventas.Forma_de_Pago, Ventas.Fecha_Venta, Ventas.Total_Pago, Productos.Nombre, Tipo_de_Producto.Tipo_de_Producto, Empleados.Nombre_Apellido AS Vendedor FROM((((Clientes INNER JOIN Ventas ON Clientes.Id_Cliente = Ventas.Id_Cliente) INNER JOIN Productos ON Ventas.Id_Producto = Productos.Id_Producto) INNER JOIN Tipo_de_Producto ON Productos.Tipo_de_producto = Tipo_de_Producto.Codigo) INNER JOIN Empleados ON Ventas.Vendedor = Empleados.Id_Empleado) WHERE (Ventas.Fecha_Venta >= #" + FechaDesde.ToString("dd/MMM/yyyy") + "# AND Ventas.Fecha_Venta <=  #" + FechaHasta.ToString("dd/MMM/yyyy") +"#)";
                Adaptador = new OleDbDataAdapter(Comando);
                DataTable ventasPorFecha = new DataTable();
                Adaptador.Fill(ventasPorFecha);
                if (ventasPorFecha.Rows.Count > 0)
                {
                    foreach (DataRow row in ventasPorFecha.Rows)
                    {
                        GrillaVentas.DataSource = ventasPorFecha;
                    }
                }
                Conexion.Close();
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = "SELECT Fecha_Venta,Count(*) AS CantVentas FROM Ventas WHERE (Ventas.Fecha_Venta >= #" + FechaDesde.ToString("dd/MMM/yyyy") + "# AND Ventas.Fecha_Venta <=  #" + FechaHasta.ToString("dd/MMM/yyyy") + "#) GROUP BY Fecha_Venta";
                Adaptador = new OleDbDataAdapter(Comando);
                DataTable cantventasPorFecha = new DataTable();
                Adaptador.Fill(cantventasPorFecha);
                Series Gra = new Series();
                Gra.ChartType = SeriesChartType.Column;
                Grafico.Series.Clear();
                if (cantventasPorFecha.Rows.Count > 0)
                {
                    foreach (DataRow row in cantventasPorFecha.Rows)
                    {
                        DateTime FechaVenta = (DateTime)row["Fecha_Venta"];
                        int TotalVentas = (int)row["CantVentas"];
                        Gra.Points.AddXY(FechaVenta.ToShortDateString(), TotalVentas);
                    }
                    Grafico.Series.Add(Gra);
                    Grafico.ChartAreas[0].AxisY.Interval = 1;
                    Grafico.Series[0].LegendText = "Cantidad de Ventas";
                }
                Conexion.Close();
                cantventasPorFecha.Clear();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se ha podido cargar la informacion.");
            }
        }



    }
}
