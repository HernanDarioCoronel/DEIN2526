using System;
using System.Data;
using System.Data.SQLite;
using System.Windows;

namespace DbConnection.Classes.Utils
{
    class ClsBD
    {
        SQLiteConnection conexion;

        public ClsBD(string nomeBD)
        {
            string cadenaConexion = string.Format("Data Source={0};Version=3;", nomeBD);
            conexion = new SQLiteConnection(cadenaConexion);
        }

        public void abrirBD()
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                    MessageBox.Show("BD abierta correctamente (SQLite)");
                }
            }
            catch (SQLiteException erroBD)
            {
                MessageBox.Show(erroBD.Message, "Error abriendo SQLite", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void cerrarBD()
        {
            try
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                    MessageBox.Show("BD cerrada");
                }
            }
            catch (SQLiteException erroBD)
            {
                MessageBox.Show(erroBD.Message, "Error cerrando SQLite", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void operacionsNonSelect(string cadenaSQL)
        {
            try
            {
                using (SQLiteCommand comando = new SQLiteCommand(cadenaSQL, conexion))
                {
                    comando.ExecuteNonQuery();
                }
            }
            catch (SQLiteException erroBD)
            {
                MessageBox.Show(erroBD.Message, "Error en operación Non-Select", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
        }

        public DataSet operacionsSelect(string cadenaSQL)
        {
            DataSet ds = new DataSet();
            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter(cadenaSQL, conexion);
                da.Fill(ds);
            }
            catch (SQLiteException erroBD)
            {
                MessageBox.Show(erroBD.Message, "Error en operación Select", MessageBoxButton.OK, MessageBoxImage.Stop);
            }

            return ds;
        }
    }
}