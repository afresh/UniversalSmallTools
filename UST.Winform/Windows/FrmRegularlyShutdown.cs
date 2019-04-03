using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace UST.Winform.Windows
{
    public partial class FrmRegularlyShutdown : Form
    {
        public FrmRegularlyShutdown()
        {
            InitializeComponent();

            DtpTime.Value = DateTime.Now;
        }

        private void BtnSetShutdown_Click(object sender, EventArgs e)
        {
            if (BtnSetShutdown.Text == @"设置关机")
            {
                if (DateTime.Now >= DtpTime.Value)
                {
                    MessageBox.Show(@"设置时间须大于当前时间");
                    return;
                }

                var timeSpan = DtpTime.Value - DateTime.Now;
                //Process.Start("c:/windows/system32/shutdown.exe", "-s -t " + Math.Ceiling(timeSpan.TotalSeconds));
                Process.Start("cmd.exe", "/cshutdown -s -t " + Math.Ceiling(timeSpan.TotalSeconds));
                TmrCountDown.Enabled = true;
                BtnSetShutdown.Text = @"取消关机";
            }
            else
            {
                //Process.Start("c:/windows/system32/shutdown.exe", "-a");
                Process.Start("cmd.exe", "/cshutdown -a");
                TmrCountDown.Enabled = false;
                LblCountDown.Text = @"倒计时：0天0小时0分0秒";
                BtnSetShutdown.Text = @"设置关机";
            }
        }

        private void TmrCountDown_Tick(object sender, EventArgs e)
        {
            var timeSpan = DtpTime.Value - DateTime.Now;
            if (timeSpan.TotalSeconds < 0)
            {
                TmrCountDown.Enabled = false;
                LblCountDown.Text = @"倒计时：0天0小时0分0秒";
            }
            LblCountDown.Text = @"倒计时：" + timeSpan.Days + @"天" + timeSpan.Hours + @"小时" + timeSpan.Minutes + @"分" + timeSpan.Seconds + @"秒";
        }
    }
}
