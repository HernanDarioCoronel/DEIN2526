using System;
using System.Drawing;
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

        public Form1()
        {
            InitializeComponent();
            TboxPaste.Leave += new EventHandler(this.TboxPaste_Leave);
        }

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
            string currText = TboxHex.Text;
            if (e.KeyChar == (char)Keys.Back && TboxHex.SelectionStart > 0)
            {
                int selStart = TboxHex.SelectionStart;
                currText = TboxHex.Text.Remove(selStart - 1, 1);
                val = "";
            }
            if (Regex.IsMatch(currText + val, pHex))
                TboxHex.BackColor = Color.LightGreen;
            else
                TboxHex.BackColor = Color.LightCoral;
        }

        private void TboxPaste_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.V))
            {
                infoProvider.SetError(TboxPaste, "Pegado desde el portapapeles");
            }
        }

        private void TboxPaste_Leave(object sender, EventArgs e)
        {
            infoProvider.SetError(TboxPaste, "");
        }
    }
}
