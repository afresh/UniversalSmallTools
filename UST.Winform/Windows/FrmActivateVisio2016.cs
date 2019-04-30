using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using UST.Utility;

namespace UST.Winform.Windows
{
    public partial class FrmActivateVisio2016 : Form
    {
        public FrmActivateVisio2016()
        {
            InitializeComponent();
        }

        private void BtnActivate_Click(object sender, EventArgs e)
        {
            var activationCode = TbActivationCode.Text.Trim();
            var kms = TbKms.Text.Trim();
            if (!Regex.IsMatch(activationCode, RegExpr.Win10ActivationCode))
            {
                MessageBox.Show("请输入正确的visio2016激活码（如：W9WC2-JN9W2-H4CBV-24QR7-M4HB8，请自行百度）");
                return;
            }
            if (!Regex.IsMatch(kms, RegExpr.Host))
            {
                MessageBox.Show("请输入正确的kms域名（如：zh.us.to，请自行百度）");
                return;
            }

            var strCmd = @"
                cscript ospp.vbs /inpkey:{ActivationCode}
                cscript ospp.vbs /sethst:{Kms}
                cscript ospp.vbs /act
                ";
            strCmd = strCmd.Replace("{ActivationCode}", activationCode).Replace("{Kms}", kms);

            Process.Start("cmd.exe", strCmd);
        }
    }
}
