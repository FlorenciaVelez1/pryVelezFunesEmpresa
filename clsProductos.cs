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
    internal class clsProductos
    {
        //Conexion a la base de datos
        private OleDbConnection Conexion = new OleDbConnection();
        private OleDbCommand Comando = new OleDbCommand();
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        //Agrego la ruta
        private string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:BaseDatosTP.accdb";
        private string Tabla = "Productos";
        //Creo las variables de forma local
        private Int32 varIDProducto;
        private string varNombreProducto;
        private string varTipoProducto;
        private Int32 varCodTipoProducto;
        private decimal varCostoMinorista;
        private decimal varCostoMayorista;
        private string varDescripcion;
        //Creo un booleano para verificar informacion
        public bool varBandera;
        public Int32 IdProducto
        {
            get { return varIDProducto; }
            set { varIDProducto = value; }
        }
        public string NombreProducto
        {
            get { return varNombreProducto; }
            set { varNombreProducto = value; }
        }
        public string TipoProducto
        {
            get { return varTipoProducto; }
            set { varTipoProducto = value; }
        }
        public decimal CostoMinorista
        {
            get { return varCostoMinorista; }
            set { varCostoMinorista = value; }
        }
        public decimal CostoMayorista
        {
            get { return varCostoMayorista; }
            set { varCostoMayorista = value; }
        }
        public string Descripcion
        {
            get { return varDescripcion; }
            set { varDescripcion = value; }
        }
        public Int32 CodTipoProducto
        {
            get { return varCodTipoProducto; }
            set { varCodTipoProducto= value; }
        }
        public void LlenarCbNomProductos(ComboBox cbNomProductos)
        {
            Conexion.ConnectionString = Ruta;
            Conexion.Open();
            Comando.Connection = Conexion;
            Comando.CommandType = CommandType.TableDirect;
            Comando.CommandText = "Productos";
            //Adaptador se conecta con la base y trae los datos y se suben los datos a una tabla "virtual"(dataset)
            Adaptador = new OleDbDataAdapter(Comando);
            //Tabla virtual
            DataSet DataConsulta = new DataSet();
            Adaptador.Fill(DataConsulta);
            cbNomProductos.DataSource = DataConsulta.Tables[0];
            //Los datos que queremos que se vean en la lst
            cbNomProductos.DisplayMember = "Nombre";
            Conexion.Close();
        }
        public void LlenarCbTipoProducto(ComboBox cbTipoProducto)
        {
            Conexion.ConnectionString = Ruta;
            Conexion.Open();
            Comando.Connection = Conexion;
            Comando.CommandType = CommandType.TableDirect;
            Comando.CommandText = "Tipo de Producto";
            //Adaptador se conecta con la base y trae los datos y se suben los datos a una tabla "virtual"(dataset)
            Adaptador = new OleDbDataAdapter(Comando);
            //Tabla virtual
            DataSet DataConsulta = new DataSet();
            Adaptador.Fill(DataConsulta);
            cbTipoProducto.DataSource = DataConsulta.Tables[0];
            //Los datos que queremos que se vean en la lst
            cbTipoProducto.DisplayMember = "Tipo de Producto";
            //Dato que no se veria
            cbTipoProducto.ValueMember = "Codigo";
            Conexion.Close();
        }
        public void Agregar()
        {
            try
            {
                //Instruccion sql, creo variable con la intruccion concatenada y utilizo la variable luego
                string Sql = "INSERT INTO Productos ([Id Producto],[Nombre], [Tipo de Producto], [Costo Minorista], [Costo Mayorista], [Descripcion])" +
                    "VALUES ('" + IdProducto + "','" + NombreProducto + "','" + CodTipoProducto + "','" + CostoMinorista + "','" + CostoMayorista + "','" + Descripcion + "')";
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
        public void BuscarTipoDeProducto(Int32 CodTipoProducto)
        {
            Conexion.ConnectionString = Ruta;
            Conexion.Open();
            Comando.Connection = Conexion;
            Comando.CommandType = CommandType.TableDirect;
            Comando.CommandText = "Tipo de Producto";
            //Recibe el contenido de la tabla
            OleDbDataReader Lector = Comando.ExecuteReader();
            //Si hay filas que leer entra en el "si"
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    if (Lector.GetInt32(0) == CodTipoProducto)
                    {
                        TipoProducto = Lector.GetString(1);
                    }
                }
            }
            Conexion.Close();
        }
        public void Buscar(Int32 IdProducto)
        {
            varBandera = true;
            try
            {
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = Tabla;
                //Recibe el contenido de la tabla
                OleDbDataReader Lector = Comando.ExecuteReader();
                //Si hay filas que leer entra en el "si"
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetInt32(0) == IdProducto)
                        {
                            varIDProducto = Lector.GetInt32(0);
                            varNombreProducto = Lector.GetString(1);
                            varCodTipoProducto = Lector.GetInt32(2);
                            varCostoMinorista = Lector.GetDecimal(3);
                            varCostoMayorista = Lector.GetDecimal(4);
                            varDescripcion = Lector.GetString(5);
                            varBandera = false;
                        }
                    }
                }
                Conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al buscar el ID del Producto.");
            }
        }
        public void BuscarProducto(string NomProducto)
        {
            varBandera = true;
            try
            {
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = Tabla;
                //Recibe el contenido de la tabla
                OleDbDataReader Lector = Comando.ExecuteReader();
                //Si hay filas que leer entra en el "si"
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetString(1) == NomProducto)
                        {
                            varIDProducto = Lector.GetInt32(0);
                            varBandera = false;
                        }
                    }
                }
                Conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al buscar el ID del Producto.");
            }
        }
        public void Eliminar(Int32 IDPRODUCTO)
        {
            try
            {
                string Sql = "DELETE FROM Productos WHERE (" + IDPRODUCTO + "= [Id Producto])";
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
                MessageBox.Show("No se ha podido eliminar la informacion del producto correctamente");
            }
        }
        public void Modificar(Int32 IDPRODUCTO)
        {
            try
            {
                string Sql = "UPDATE Productos SET [Nombre]= '" + NombreProducto + "', [Tipo de Producto]= " + CodTipoProducto + ", [Costo Minorista]= " + CostoMinorista + ", [Costo Mayorista]= " +
                    CostoMayorista + ", [Descripcion]= '"+ Descripcion + "' WHERE [Id Producto] = " + IDPRODUCTO + "";
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
        public void ListarGrillaProductos(DataGridView GrillaProductos)
        {
            try
            {
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = Tabla;
                GrillaProductos.Rows.Clear();
                OleDbDataReader Lector = Comando.ExecuteReader();
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        Int32 CodTipoProducto = Lector.GetInt32(2);
                        clsProductos BuscarCodTipoProducto = new clsProductos();
                        BuscarCodTipoProducto.BuscarTipoDeProducto(CodTipoProducto);
                        GrillaProductos.Rows.Add(Lector.GetInt32(0), Lector.GetString(1),BuscarCodTipoProducto.TipoProducto, Lector.GetString(5), Lector.GetDecimal(3), Lector.GetDecimal(4));
                    }
                }
                Conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido cargar la informacion.");
            }
        }
    }
}
