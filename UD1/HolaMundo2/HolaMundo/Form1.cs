using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void RedBtn_Click(object sender, EventArgs e)
        {
            this.SaludoLbl.BackColor = Color.FromArgb(255, 255, 128, 128);
        }

        private void YellowBtn_Click(object sender, EventArgs e)
        {
            this.SaludoLbl.BackColor = Color.FromArgb(255, 255, 255, 128);
        }

        private void GreenBtn_Click(object sender, EventArgs e)
        {
            this.SaludoLbl.BackColor = Color.FromArgb(255, 128, 255, 128);
        }
    }
}
