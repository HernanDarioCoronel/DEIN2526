using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DatabaseConnection
{
    public partial class Form1 : Form
    {
        DataTable dataTable;
        OleDbConnection connection;
        string dbPath;
        string connectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Negocio.mdb");
            this.connectionString = $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={dbPath};";

            this.connection = new OleDbConnection(connectionString);
            this.RefreshList();
        }

        /// <summary>
        /// Función para refrescar la lista de Clientes utilizando <see cref="OleDbDataAdapter"/> para hacerlo.
        /// <see cref="OleDbDataAdapter"/> es más útil para relaciones entre tablas mientras que <see cref="OleDbDataReader"/>
        /// es mejor para consultas a una sola tabla ya que es más rápido y es de sólo lectura.
        /// </summary>
        /// <exception cref="System.Exception">
        /// Se lanza si hay un error al intentar abrir la conexión a la base de datos o ejecutar la consulta. 
        /// (Por ejemplo, si la base de datos está inaccesible o si el comando SQL falla).
        /// </exception>
        private void RefreshList()
        {
            try
            {
                string query = "SELECT * FROM Clientes ORDER BY Apelido1, Apelido2;";
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
                DataSet dSet = new DataSet();
                dataAdapter.Fill(dSet);
                dataTable = dSet.Tables[0];
                foreach (DataRow row in dSet.Tables[0].Rows)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(row["id"]);
                    sb.Append(" - ");
                    sb.Append(row["Apelido1"]);
                    sb.Append(" - ");
                    sb.Append(row["Apelido2"]);
                    sb.Append(" - ");
                    sb.Append(row["Nome"]);
                    sb.Append(" - ");
                    sb.Append(row["codigoProvincia"]);

                    listBox1.Items.Add(sb.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }


        /// <summary>
        /// Función para refrescar la lista de Clientes utilizando <see cref="OleDbDataReader"/> para hacerlo.
        /// <see cref="OleDbDataAdapter"/> es más útil para relaciones entre tablas mientras que <see cref="OleDbDataReader"/>
        /// es mejor para consultas a una sola tabla ya que es más rápido y es de sólo lectura.
        /// </summary>
        /// <exception cref="System.Exception">
        /// Se lanza si hay un error al intentar abrir la conexión a la base de datos o ejecutar la consulta. 
        /// (Por ejemplo, si la base de datos está inaccesible o si el comando SQL falla).
        /// </exception>
        private void RefreshListOle()
        {
            try
            {
                listBox1.Items.Clear();
                string query = "SELECT * FROM Clientes ORDER BY Apelido1, Apelido2;";
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);

                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    dataTable = new DataTable("Clientes");
                    dataTable.Load(reader);
                }
                foreach (DataRow row in dataTable.Rows)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append(row["id"]);
                    sb.Append(" - ");
                    sb.Append(row["Apelido1"]);
                    sb.Append(" - ");
                    sb.Append(row["Apelido2"]);
                    sb.Append(" - ");
                    sb.Append(row["Nome"]);
                    sb.Append(" - ");
                    sb.Append(row["codigoProvincia"]);

                    listBox1.Items.Add(sb.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.ClearFields();
                this.connection.Close();
            }

        }


        private void btModificar_Click(object sender, EventArgs e)
        {
            string selecteditem = this.listBox1.SelectedItem.ToString();
            int selectedId = int.Parse(selecteditem.Substring(0, selecteditem.IndexOf(" - ")));
            foreach (DataRow row in dataTable.Rows)
            {
                if (row["id"].Equals(selectedId))
                {
                    this.ctIdCliente.Text = row["id"].ToString();
                    this.ctApel1.Text = row["Apelido1"].ToString();
                    this.ctApel2.Text = row["Apelido2"].ToString();
                    this.ctNome.Text = row["Nome"].ToString();
                    break;
                }
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            RefreshListOle();
        }

        private void btInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand command;
                this.connection.Open();
                string sqlString;
                if (ctIdCliente.Text == "")
                    sqlString = String.Format("INSERT INTO Clientes (Apelido1, Apelido2, Nome) VALUES ('{0}', '{1}', '{2}');",
                        ctApel1.Text,
                        ctApel2.Text,
                        ctNome.Text);
                else
                    sqlString = String.Format("UPDATE Clientes SET Apelido1 = '{0}', Apelido2 = '{1}', Nome = '{2}' WHERE id = {3};",
                        ctApel1.Text,
                        ctApel2.Text,
                        ctNome.Text,
                        ctIdCliente.Text);

                command = new OleDbCommand(sqlString, this.connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.connection.Close();
                this.ClearFields();
                this.RefreshListOle();
            }

        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand command;
                this.connection.Open();

                string selecteditem = this.listBox1.SelectedItem.ToString();
                int selectedId = int.Parse(selecteditem.Substring(0, selecteditem.IndexOf(" - ")));

                string sqlString = String.Format("DELETE FROM Clientes WHERE id = {0}", selectedId);

                command = new OleDbCommand(sqlString, this.connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.connection.Close();
                this.ClearFields();
                this.RefreshListOle();
            }
        }

        private void ClearFields()
        {
            this.ctIdCliente.Text = "";
            this.ctApel1.Text = "";
            this.ctApel2.Text = "";
            this.ctNome.Text = "";
        }
    }
}
