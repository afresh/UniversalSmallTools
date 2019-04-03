namespace UST.Winform.Windows
{
    partial class FrmRegularlyShutdown
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegularlyShutdown));
            this.DtpTime = new System.Windows.Forms.DateTimePicker();
            this.BtnSetShutdown = new System.Windows.Forms.Button();
            this.LblCountDown = new System.Windows.Forms.Label();
            this.TmrCountDown = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // DtpTime
            // 
            this.DtpTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.DtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpTime.Location = new System.Drawing.Point(12, 14);
            this.DtpTime.Name = "DtpTime";
            this.DtpTime.Size = new System.Drawing.Size(247, 34);
            this.DtpTime.TabIndex = 0;
            this.DtpTime.Value = new System.DateTime(1989, 4, 24, 0, 0, 0, 0);
            // 
            // BtnSetShutdown
            // 
            this.BtnSetShutdown.AutoSize = true;
            this.BtnSetShutdown.Location = new System.Drawing.Point(265, 12);
            this.BtnSetShutdown.Name = "BtnSetShutdown";
            this.BtnSetShutdown.Size = new System.Drawing.Size(102, 37);
            this.BtnSetShutdown.TabIndex = 1;
            this.BtnSetShutdown.Text = "设置关机";
            this.BtnSetShutdown.UseVisualStyleBackColor = true;
            this.BtnSetShutdown.Click += new System.EventHandler(this.BtnSetShutdown_Click);
            // 
            // LblCountDown
            // 
            this.LblCountDown.BackColor = System.Drawing.Color.LightGreen;
            this.LblCountDown.ForeColor = System.Drawing.Color.DarkRed;
            this.LblCountDown.Location = new System.Drawing.Point(12, 56);
            this.LblCountDown.Name = "LblCountDown";
            this.LblCountDown.Size = new System.Drawing.Size(355, 27);
            this.LblCountDown.TabIndex = 2;
            this.LblCountDown.Text = "倒计时：0天0小时0分0秒";
            this.LblCountDown.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TmrCountDown
            // 
            this.TmrCountDown.Interval = 500;
            this.TmrCountDown.Tick += new System.EventHandler(this.TmrCountDown_Tick);
            // 
            // FrmRegularlyShutdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 93);
            this.Controls.Add(this.LblCountDown);
            this.Controls.Add(this.BtnSetShutdown);
            this.Controls.Add(this.DtpTime);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmRegularlyShutdown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "定时关机";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DtpTime;
        private System.Windows.Forms.Button BtnSetShutdown;
        private System.Windows.Forms.Label LblCountDown;
        private System.Windows.Forms.Timer TmrCountDown;
    }
}