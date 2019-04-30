using System;
using System.Windows.Forms;
using UST.Winform.Windows;

namespace UST.Winform
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnRegularlyShutdown_Click(object sender, EventArgs e)
        {
            var frmRegularlyShutdown = new FrmRegularlyShutdown();
            frmRegularlyShutdown.Show();
        }

        private void BtnActivateWin10_Click(object sender, EventArgs e)
        {
            var frmActivateWin10 = new FrmActivateWin10();
            frmActivateWin10.Show();
        }

        private void BtnActivateVisio2016_Click(object sender, EventArgs e)
        {
            var frmActivateVisio2016 = new FrmActivateVisio2016();
            frmActivateVisio2016.Show();
        }
    }
}
