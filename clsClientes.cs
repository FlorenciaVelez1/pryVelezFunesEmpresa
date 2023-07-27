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
    internal class clsClientes
    {
        //Conexion a la base de datos
        private OleDbConnection Conexion = new OleDbConnection();
        private OleDbCommand Comando = new OleDbCommand();
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        //Agrego la ruta
        private string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:BaseDatosTP.accdb";
        private string Tabla = "Clientes";
        //Creo las variables de forma local
        private Int32 varIDCliente;
        private string varNombreApellido;
        private string varDomicilio;
        private double varTelefono;
        //Creo un booleano para verificar informacion
        public bool varBandera;
        public Int32 ClienteID
        {
            get { return varIDCliente; }
            set { varIDCliente = value; }
        }
        public string Nom_Apellido
        {
            get { return varNombreApellido; }
            set { varNombreApellido = value; }
        }
        public string DomicilioCliente
        {
            get { return varDomicilio; }
            set { varDomicilio = value; }
        }
        public double TelefonoCliente
        {
            get { return varTelefono; }
            set { varTelefono = value; }
        }
        public void BuscarPorIdCliente(Int32 IDCLIENTE)
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
                        if (Lector.GetInt32(0) == IDCLIENTE)
                        {
                            ClienteID = Lector.GetInt32(0);
                            Nom_Apellido = Lector.GetString(1);
                            DomicilioCliente = Lector.GetString(2);
                            TelefonoCliente =  Lector.GetDouble(3);
                            varBandera = false;
                        }
                    }
                }
                Conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al buscar el ID Cliente.");
            }
        }
        public void BuscarPorNomCliente(string NomCliente)
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
                        if (Lector.GetString(1) == NomCliente)
                        {
                            ClienteID = Lector.GetInt32(0);
                            Nom_Apellido = Lector.GetString(1);
                            DomicilioCliente = Lector.GetString(2);
                            TelefonoCliente = Lector.GetDouble(3);
                            varBandera = false;
                        }
                    }
                }
                Conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al buscar el ID Cliente.");
            }
        }
        public void Agregar()
        {
            try
            {
                //Instruccion sql, creo variable con la intruccion concatenada y utilizo la variable luego
                string Sql = "INSERT INTO Clientes ([Id_Cliente],[Nombre_Apellido], [Domicilio], [Telefono])" +
                    "VALUES ('" + ClienteID + "','" + Nom_Apellido + "','" + DomicilioCliente + "','" + TelefonoCliente + "')";
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
        public void Eliminar(string CLIENTE)
        {
            BuscarPorNomCliente(CLIENTE);
            try
            {
                string Sql = "DELETE FROM Clientes WHERE (" + ClienteID  + "= [Id_Cliente])";
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
                MessageBox.Show("No se ha podido eliminar la informacion del cliente correctamente");
            }
        }
        public void Modificar(string CLIENTE)
        {
            try
            {
                string Sql = "UPDATE Clientes SET [Nombre_Apellido]= '" + Nom_Apellido + "', [Domicilio]= '" + DomicilioCliente + "', [Telefono]= " + TelefonoCliente +
                    " WHERE [Id_Cliente] = " + ClienteID + "";
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
        public void ListarGrillaClientes(DataGridView GrillaCliente)
        {
            try
            {
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = Tabla;
                GrillaCliente.Rows.Clear();
                OleDbDataReader Lector = Comando.ExecuteReader();
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        GrillaCliente.Rows.Add(Lector.GetInt32(0), Lector.GetString(1), Lector.GetString(2), Lector.GetDouble(3));
                    }
                }
                Conexion.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido cargar la informacion.");
            }
        }
        public void ExportarClientes()
        {
            try
            {
                Conexion.ConnectionString = Ruta;
                Conexion.Open();
                Comando.Connection = Conexion;
                Comando.CommandType = CommandType.TableDirect;
                Comando.CommandText = Tabla;
                OleDbDataReader Lector = Comando.ExecuteReader();
                //Creo el archivo para exportar los datos
                StreamWriter ExportarDatos = new StreamWriter("ExportarClientes.csv", false, Encoding.UTF8);
                ExportarDatos.WriteLine("Listado de Clientes");
                ExportarDatos.WriteLine("Id Cliente;Nombre y Apellido;Domicilio;Telefono");
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        ExportarDatos.Write(Lector.GetInt32(0));
                        ExportarDatos.Write(";");
                        ExportarDatos.Write(Lector.GetString(1));
                        ExportarDatos.Write(";");
                        ExportarDatos.Write(Lector.GetString(2));
                        ExportarDatos.Write(";");
                        ExportarDatos.Write(Lector.GetDouble(3));
                        ExportarDatos.Write("\n");
                    }
                }
                Conexion.Close();
                ExportarDatos.Close();
                MessageBox.Show("Tus datos han sido exportados exitosamente.");
            }
            catch (Exception)
            {
                MessageBox.Show("Tus datos no han podido ser exportados.");
            }
        }
        public void LlenarNomClientes(ComboBox cbNomClientes)
        {
            Conexion.ConnectionString = Ruta;
            Conexion.Open();
            Comando.Connection = Conexion;
            Comando.CommandType = CommandType.TableDirect;
            Comando.CommandText = "Clientes";
            //Adaptador se conecta con la base y trae los datos y se suben los datos a una tabla "virtual"(dataset)
            Adaptador = new OleDbDataAdapter(Comando);
            //Tabla virtual
            DataSet DataConsulta = new DataSet();
            Adaptador.Fill(DataConsulta);
            cbNomClientes.DataSource = DataConsulta.Tables[0];
            //Los datos que queremos que se vean en la lst
            cbNomClientes.DisplayMember = "Nombre_Apellido";
            Conexion.Close();
        }
    }

}
