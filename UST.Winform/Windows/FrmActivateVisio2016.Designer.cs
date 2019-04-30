namespace UST.Winform.Windows
{
    partial class FrmActivateVisio2016
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActivateVisio2016));
            this.BtnActivate = new System.Windows.Forms.Button();
            this.TbKms = new System.Windows.Forms.TextBox();
            this.LblKms = new System.Windows.Forms.Label();
            this.TbActivationCode = new System.Windows.Forms.TextBox();
            this.LblActivationCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnActivate
            // 
            this.BtnActivate.AutoSize = true;
            this.BtnActivate.Location = new System.Drawing.Point(12, 124);
            this.BtnActivate.Name = "BtnActivate";
            this.BtnActivate.Size = new System.Drawing.Size(314, 31);
            this.BtnActivate.TabIndex = 9;
            this.BtnActivate.Text = "在线激活";
            this.BtnActivate.UseVisualStyleBackColor = true;
            this.BtnActivate.Click += new System.EventHandler(this.BtnActivate_Click);
            // 
            // TbKms
            // 
            this.TbKms.Location = new System.Drawing.Point(12, 89);
            this.TbKms.Name = "TbKms";
            this.TbKms.Size = new System.Drawing.Size(314, 29);
            this.TbKms.TabIndex = 8;
            // 
            // LblKms
            // 
            this.LblKms.AutoSize = true;
            this.LblKms.Location = new System.Drawing.Point(12, 65);
            this.LblKms.Name = "LblKms";
            this.LblKms.Size = new System.Drawing.Size(138, 21);
            this.LblKms.TabIndex = 7;
            this.LblKms.Text = "Kms服务器域名：";
            // 
            // TbActivationCode
            // 
            this.TbActivationCode.Location = new System.Drawing.Point(12, 33);
            this.TbActivationCode.Name = "TbActivationCode";
            this.TbActivationCode.Size = new System.Drawing.Size(314, 29);
            this.TbActivationCode.TabIndex = 6;
            // 
            // LblActivationCode
            // 
            this.LblActivationCode.AutoSize = true;
            this.LblActivationCode.Location = new System.Drawing.Point(12, 9);
            this.LblActivationCode.Name = "LblActivationCode";
            this.LblActivationCode.Size = new System.Drawing.Size(314, 21);
            this.LblActivationCode.TabIndex = 5;
            this.LblActivationCode.Text = "激活码：不同系统版本这里的激活码不一样";
            // 
            // FrmActivateVisio2016
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 165);
            this.Controls.Add(this.BtnActivate);
            this.Controls.Add(this.TbKms);
            this.Controls.Add(this.LblKms);
            this.Controls.Add(this.TbActivationCode);
            this.Controls.Add(this.LblActivationCode);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "FrmActivateVisio2016";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visio2016激活工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnActivate;
        private System.Windows.Forms.TextBox TbKms;
        private System.Windows.Forms.Label LblKms;
        private System.Windows.Forms.TextBox TbActivationCode;
        private System.Windows.Forms.Label LblActivationCode;
    }
}