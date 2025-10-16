using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CajasDeDialogo
{
    public partial class LoginDialog : Form
    {
        private int intentos;
        private bool couldLogIn;
        public LoginDialog(int intentos, bool couldLogIn)
        {
            InitializeComponent();
            this.intentos = intentos;
            this.couldLogIn = couldLogIn;
        }

        private void LoginDialog_Load(object sender, EventArgs e)
        {
            if (couldLogIn)
            {
                this.couldLogLabel.Text = "Bienvenido";
            }
            else
            {
                this.couldLogLabel.Text = "Error al iniciar sesión";
                this.intentosLabel.Text = "Intentos Restantes: " + this.intentos;
            }
        }

        private void aceptarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
