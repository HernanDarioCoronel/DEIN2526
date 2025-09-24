using System;
using System.Drawing;
using System.Windows.Forms;

namespace GroupBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void AplicarBtn_Click(object sender, EventArgs e)
        {
            if (this.RojoRbtn.Checked)
            {
                this.SaludoLbl.BackColor = Color.FromArgb(255, 255, 128, 128);
            }
            else if (this.AmarilloRbtn.Checked)
            {
                this.SaludoLbl.BackColor = Color.FromArgb(255, 255, 255, 128);
            }
            else if (this.VerdeRbtn.Checked)
            {
                this.SaludoLbl.BackColor = Color.FromArgb(255, 128, 255, 128);
            }
        }
    }
}
