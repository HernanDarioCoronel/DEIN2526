using System;
using System.Windows.Forms;

namespace CajasDeDialogo
{
    public partial class DlgLogin : Form
    {
        private int intentos = 3;
        public DlgLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool couldLogIn = Properties.Resources.pws == ctPalabraDePaso.Text;
            if (couldLogIn)
            {
                MessageBox.Show("Bienvenido");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                intentos--;
            }
            if (intentos <= 0)
            {
                MessageBox.Show("Demasiados intentos", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
