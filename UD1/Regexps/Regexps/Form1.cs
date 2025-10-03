using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegExps
{
    public partial class Form1 : Form
    {
        string pUrl = @"https?:\/\/[^\s/$.?#].[^\s]*";
        string pIp = @"^((25[0-5]|(2[0-4]|1\d|[1-9]|)\d)\.?\b){4}$";
        string pMatr = @"^\d{4}[ \-]?[B-DF-HJ-NP-TV-Z]{3}|[A-Z]{1,2}[ \-]?\d{4}[ \-]?[A-Z]{0,2}$";
        string pHex = @"^[0-9A-Fa-f]+$";
        string pPaste = @"";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void BtnUrl_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(TboxUrl.Text, pUrl))
                TboxUrl.BackColor = Color.LightGreen;
            else
                TboxUrl.BackColor = Color.LightCoral;
        }

        private void BtnIp_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(TboxIp.Text, pIp))
                TboxIp.BackColor = Color.LightGreen;
            else
                TboxIp.BackColor = Color.LightCoral;
        }

        private void BtnMattr_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(TboxMattr.Text, pMatr))
                TboxMattr.BackColor = Color.LightGreen;
            else
                TboxMattr.BackColor = Color.LightCoral;
        }

        private void TboxHex_KeyPress(object sender, KeyPressEventArgs e)
        {
            string val = e.KeyChar.ToString();
            if (char.IsControl(e.KeyChar))
                val = "";

            if (Regex.IsMatch(TboxHex.Text + e.KeyChar, pHex))
                TboxHex.BackColor = Color.LightGreen;
            else
                TboxHex.BackColor = Color.LightCoral;
        }
    }
}
