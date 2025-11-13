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
        ClsBD dbHandler;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dbHandler = new ClsBD(@"..\..\..\Negocio.mdb");
                this.RefreshList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inicializar o cargar la lista: " + ex.Message);
            }
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
            this.listBox1.Items.Clear();
            try
            {
                string query = "SELECT * FROM Clientes ORDER BY Apelido1, Apelido2;";
                DataSet dSet = dbHandler.OperacionSelect(query);

                if (dSet != null && dSet.Tables.Count > 0)
                {
                    dataTable = dSet.Tables[0];
                    foreach (DataRow row in dataTable.Rows)
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append(row["id"]?.ToString() ?? "N/A");
                        sb.Append(" - ");
                        sb.Append(row["Apelido1"]?.ToString() ?? "");
                        sb.Append(" - ");
                        sb.Append(row["Apelido2"]?.ToString() ?? "");
                        sb.Append(" - ");
                        sb.Append(row["Nome"]?.ToString() ?? "");
                        sb.Append(" - ");
                        sb.Append(row["codigoProvincia"]?.ToString() ?? "N/A");

                        this.listBox1.Items.Add(sb.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbHandler.CerrarBD();
            }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un cliente de la lista para modificar.");
                return;
            }

            try
            {
                string selecteditem = this.listBox1.SelectedItem.ToString();
                if (int.TryParse(selecteditem.Substring(0, selecteditem.IndexOf(" - ")), out int selectedId))
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (row["id"] != DBNull.Value && Convert.ToInt32(row["id"]) == selectedId)
                        {
                            this.ctIdCliente.Text = row["id"].ToString();
                            this.ctApel1.Text = row["Apelido1"]?.ToString() ?? "";
                            this.ctApel2.Text = row["Apelido2"]?.ToString() ?? "";
                            this.ctNome.Text = row["Nome"]?.ToString() ?? "";
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error al obtener el ID del elemento seleccionado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos para modificar: " + ex.Message);
            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            try
            {
                dbHandler.CerrarBD();
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la conexión: " + ex.Message);
                Application.Exit();
            }
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btInsertar_Click(object sender, EventArgs e)
        {
            string sqlString;

            // Se usa .Replace("'", "''") como una sanitización básica contra inyección SQL, 
            // aunque el uso de parámetros es la solución recomendada.
            string apel1 = ctApel1.Text.Replace("'", "''");
            string apel2 = ctApel2.Text.Replace("'", "''");
            string nome = ctNome.Text.Replace("'", "''");

            if (ctIdCliente.Text == "")
                sqlString = String.Format("INSERT INTO Clientes (Apelido1, Apelido2, Nome) VALUES ('{0}', '{1}', '{2}');",
                    apel1,
                    apel2,
                    nome);
            else
                sqlString = String.Format("UPDATE Clientes SET Apelido1 = '{0}', Apelido2 = '{1}', Nome = '{2}' WHERE id = {3};",
                    apel1,
                    apel2,
                    nome,
                    ctIdCliente.Text);

            try
            {
                if (dbHandler.OperacionNoSelect(sqlString))
                {
                    this.ClearFields();
                    this.RefreshList();
                }
                else
                    MessageBox.Show("Ha ocurrido un problema.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la operación: " + ex.Message);
            }
            finally
            {
                dbHandler.CerrarBD();
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona un cliente de la lista para eliminar.");
                return;
            }

            try
            {
                string selecteditem = this.listBox1.SelectedItem.ToString();
                if (int.TryParse(selecteditem.Substring(0, selecteditem.IndexOf(" - ")), out int selectedId))
                {
                    string sqlString = String.Format("DELETE FROM Clientes WHERE id = {0}", selectedId);

                    if (dbHandler.OperacionNoSelect(sqlString))
                        this.RefreshList();
                    else
                        MessageBox.Show("Ha ocurrido un problema.");
                }
                else
                {
                    MessageBox.Show("No se pudo obtener el ID del cliente seleccionado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la eliminación: " + ex.Message);
            }
            finally
            {
                dbHandler.CerrarBD();
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