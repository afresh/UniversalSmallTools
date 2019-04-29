using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using UST.Utility;

namespace UST.Winform.Windows
{
    public partial class FrmActivateWin10 : Form
    {
        public FrmActivateWin10()
        {
            InitializeComponent();
        }

        private void BtnActivate_Click(object sender, System.EventArgs e)
        {
            var activationCode = TbActivationCode.Text.Trim();
            var kms = TbKms.Text.Trim();
            if (!Regex.IsMatch(activationCode, RegExpr.Win10ActivationCode))
            {
                MessageBox.Show("请输入正确的win10激活码（如：W269N-WFGWX-YVC9B-4J6C9-T83GX）");
                return;
            }
            if (!Regex.IsMatch(kms, RegExpr.Host))
            {
                MessageBox.Show("请输入正确的kms域名（如：zh.us.to）");
                return;
            }

            var strCmd = @"
                slmgr.vbs -upk
                slmgr.vbs -ipk {ActivationCode}
                slmgr.vbs -skms {Kms}
                slmgr.vbs -ato
                slmgr.vbs -dlv
                ";
            strCmd = strCmd.Replace("{ActivationCode}", activationCode).Replace("{Kms}", kms);

            Process.Start("cmd.exe", strCmd);
        }
    }
}
