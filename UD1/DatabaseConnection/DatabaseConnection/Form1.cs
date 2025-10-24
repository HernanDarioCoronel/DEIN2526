using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseConnection
{
    public partial class Form1 : Form
    {
        DataSet ds;
        OleDbConnection connection;
        OleDbDataAdapter adapter;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Negocio.mdb");
            string connectionString = $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={dbPath};";

            connection = new OleDbConnection(connectionString);


            adapter = new OleDbDataAdapter("SELECT * FROM Clientes ORDER BY Apelido1, Apelido2;", connection);            ds = new DataSet();            adapter.Fill(ds, "Clientes");
            this.RefreshList();
        }

        private void RefreshList()
        {
            listBox1.Items.Clear();

            DataTable table = ds.Tables["Clientes"];

            foreach (DataRow row in table.Rows)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(row["id"]);
                sb.Append("-");
                sb.Append(row["Apelido1"]);
                sb.Append("-");
                sb.Append(row["Apelido2"]);
                sb.Append("-");
                sb.Append(row["Nome"]);
                sb.Append("-");
                sb.Append(row["codigoProvincia"]);

                listBox1.Items.Add(sb.ToString());
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
    }
}
