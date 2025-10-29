using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace DatabaseConnection
{
    public partial class Form1 : Form
    {
        DataSet ds;
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

            connection = new OleDbConnection(connectionString);


            this.RefreshList();
        }

        private void RefreshList()
        {
            try
            {
                listBox1.Items.Clear();
                
                string query = "SELECT * FROM Clientes ORDER BY Apelido1, Apelido2;";
                connection.Open();
                OleDbCommand command = new OleDbCommand(query, connection);
                
                DataTable table = new DataTable("Clientes");
                
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    table.Load(reader);
                }
                
                foreach (DataRow row in table.Rows)
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
                connection.Close();
            }
        }


        private void btModificar_Click(object sender, EventArgs e)
        {
            DataTable table = ds.Tables["Clientes"];

            String[] selectedData = listBox1.SelectedItem.ToString().Split('-');
            DataRow foudRow = null;
            foreach (DataRow row in table.Rows)
            {
                if (row["id"].ToString().Equals(selectedData[0]))
                {
                    foudRow = row;
                    break;
                }
            }
            if (foudRow != null)
            {
                this.ctIdCliente.Text = foudRow["id"].ToString();
                this.ctNome.Text = foudRow["Nome"].ToString();
                this.ctApel1.Text = foudRow["Apelido1"].ToString();
                this.ctApel2.Text = foudRow["Apelido2"].ToString();
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            connection.Close();
            this.Close();
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btInsertar_Click(object sender, EventArgs e)
        {
            OleDbCommand command;
            if (ctIdCliente.Text == "")
            {
                string sqlString = $"INSERT INTO Clientes (Apelido1, Apelido2, Nome) VALUES ('{ ctApel1.Text }', '{ctApel2.Text}', '{ctNome.Text}');";
                this.connection.Open();
                command = new OleDbCommand(sqlString, this.connection);
                try
                {
                    command.ExecuteNonQuery();
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
        }
    }
}
