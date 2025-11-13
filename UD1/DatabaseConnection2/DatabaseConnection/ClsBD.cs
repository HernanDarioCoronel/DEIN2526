using System;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace DatabaseConnection
{
    class ClsBD
    {
        string connectionString;
        OleDbConnection connection;

        /// <summary>
        /// Crea el objeto de conexión a la Base de Datos Access
        /// </summary>
        /// <param name="dbName">Ruta relativa</param>
        public ClsBD(string dbName)
        {
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dbName);
            this.connectionString = $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={dbPath};";
        }

        public void AbrirBD()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CerrarBD()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public bool OperacionNoSelect(string consulta)
        {
            try
            {
                AbrirBD();
                OleDbCommand command = new OleDbCommand(consulta, connection);
                command.ExecuteNonQuery();
            }
            catch (InvalidOperationException)
            {
                return false;
            }
            finally
            {
                CerrarBD();
            }
            return true;
        }

        public DataSet OperacionSelect(string consulta)
        {
            try
            {
                AbrirBD();
                OleDbCommand command = new OleDbCommand(consulta, connection);
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
                DataSet dSet = new DataSet();
                dataAdapter.Fill(dSet);
                return dSet;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                CerrarBD();
            }
        }
    }
}
