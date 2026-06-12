using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SecurePasswordGenerator
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern bool SetWindowDisplayAffinity(IntPtr hwnd, uint dwAffinity);
        private const uint WDA_EXCLUDEFROMCAPTURE = 0x00000011;

        public Form1()
        {
            InitializeComponent();
            SetWindowDisplayAffinity(this.Handle, WDA_EXCLUDEFROMCAPTURE);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtOutput.Text = PasswordEngine.Generate(
                (int)numBlocks.Value,
                (int)numCharsPerBlock.Value,
                txtSeparator.Text,
                chkUpper.Checked,
                chkLower.Checked,
                chkDigits.Checked,
                chkSpecial.Checked,
                chkUmlauts.Checked
            );
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}