using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace bd001_Manter01
{
    class clsBD
    {
        OleDbConnection conexion;
        public clsBD(string cadenaConexion)
        {
            conexion = new OleDbConnection(cadenaConexion);
        }

        public void abrirBD()
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                    MessageBox.Show("bd abierta");
                }
            }
            catch (OleDbException erroBD)
            {
                MessageBox.Show(erroBD.Message, "erro abrindo b.d.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void cerrarBD()
        {
            try
            {
                if (conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                    MessageBox.Show("bd cerrada");
                }
            }
            catch (OleDbException erroBD)
            {
                MessageBox.Show(erroBD.Message, "erro pechando b.d.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public void operacionsNonSelect(string cadenaSQL)
        {
            try
            {
                OleDbCommand comando;
                comando = new OleDbCommand(cadenaSQL, conexion);
              int i =  comando.ExecuteNonQuery();
            }
            catch (OleDbException erroBD)
            {
                MessageBox.Show(erroBD.Message, "erro operación non select b.d.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        public DataSet operacionsSelect(string cadenaSQL)
        {
            DataSet ds = new DataSet();
            try
            {
                OleDbDataAdapter da = new OleDbDataAdapter(cadenaSQL, conexion);
                da.Fill(ds);
            }
            catch (OleDbException erroBD)
            {
                MessageBox.Show(erroBD.Message, "erro operacións select", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
            return ds;
        }


    }
}
