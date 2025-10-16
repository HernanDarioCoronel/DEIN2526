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
    public partial class LoginForm : Form
    {
        private int intentos;
        public LoginForm()
        {
            InitializeComponent();
            intentos = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool couldLogIn = Properties.Resources.pws != pswTbox.Text || Properties.Resources.user != usrTbox.Text;
            if (couldLogIn)
            {
                intentos--;
            }

            LoginDialog loginDialog = new LoginDialog(intentos, couldLogIn);
            loginDialog.ShowDialog();

        }
    }
}
