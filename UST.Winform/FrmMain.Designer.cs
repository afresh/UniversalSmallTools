namespace UST.Winform
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.BtnRegularlyShutdown = new System.Windows.Forms.Button();
            this.BtnActivateWin10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnRegularlyShutdown
            // 
            this.BtnRegularlyShutdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRegularlyShutdown.AutoSize = true;
            this.BtnRegularlyShutdown.Location = new System.Drawing.Point(12, 12);
            this.BtnRegularlyShutdown.Name = "BtnRegularlyShutdown";
            this.BtnRegularlyShutdown.Size = new System.Drawing.Size(214, 37);
            this.BtnRegularlyShutdown.TabIndex = 0;
            this.BtnRegularlyShutdown.Text = "定时关机";
            this.BtnRegularlyShutdown.UseVisualStyleBackColor = true;
            this.BtnRegularlyShutdown.Click += new System.EventHandler(this.BtnRegularlyShutdown_Click);
            // 
            // BtnActivateWin10
            // 
            this.BtnActivateWin10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnActivateWin10.AutoSize = true;
            this.BtnActivateWin10.Location = new System.Drawing.Point(12, 55);
            this.BtnActivateWin10.Name = "BtnActivateWin10";
            this.BtnActivateWin10.Size = new System.Drawing.Size(214, 37);
            this.BtnActivateWin10.TabIndex = 1;
            this.BtnActivateWin10.Text = "Kms激活Win10工具";
            this.BtnActivateWin10.UseVisualStyleBackColor = true;
            this.BtnActivateWin10.Click += new System.EventHandler(this.BtnActivateWin10_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 209);
            this.Controls.Add(this.BtnActivateWin10);
            this.Controls.Add(this.BtnRegularlyShutdown);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "万能小工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegularlyShutdown;
        private System.Windows.Forms.Button BtnActivateWin10;
    }
}

