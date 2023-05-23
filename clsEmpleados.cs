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
    internal class clsEmpleados
    {
        //Conexion a la base de datos
        private OleDbConnection Conexion = new OleDbConnection();
        private OleDbCommand Comando = new OleDbCommand();
        private OleDbDataAdapter Adaptador = new OleDbDataAdapter();
        //Agrego la ruta
        private string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:BaseDatosTP.accdb";
        private string Tabla = "Empleados";
        //Creo las variables de forma local
        private Int32 varIdVendedor;
        private string varnomVendedor;
        public bool varBandera;
        public Int32 IdVendedor
        {
            get { return varIdVendedor; }
            set { varIdVendedor = value; }
        }
        public string nomVendedor
        {
            get { return varnomVendedor; }
            set { varnomVendedor = value; }
        }
        public void LlenarCbNomVendedores(ComboBox cbVendedores)
        {
            Conexion.ConnectionString = Ruta;
            Conexion.Open();
            Comando.Connection = Conexion;
            Comando.CommandType = CommandType.TableDirect;
            Comando.CommandText = Tabla;
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
                Comando.CommandText = Tabla;
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
    }

}
