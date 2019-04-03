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
    }
}
