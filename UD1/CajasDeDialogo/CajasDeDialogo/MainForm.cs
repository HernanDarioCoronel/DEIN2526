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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DlgLogin loginForm = new DlgLogin();
            DialogResult dl = loginForm.ShowDialog();
            if (dl != DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
