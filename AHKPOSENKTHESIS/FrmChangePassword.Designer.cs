namespace AHKPOSENKTHESIS
{
    partial class FrmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChangePassword));
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.BtnConfirm = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Roboto", 9F);
            this.lbl1.Location = new System.Drawing.Point(33, 71);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(109, 19);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "New Password";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Roboto", 9F);
            this.lbl2.Location = new System.Drawing.Point(9, 101);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(133, 19);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Confirm Password";
            // 
            // txtNewPass
            // 
            this.txtNewPass.BackColor = System.Drawing.Color.White;
            this.txtNewPass.Font = new System.Drawing.Font("Roboto", 9F);
            this.txtNewPass.Location = new System.Drawing.Point(148, 68);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '●';
            this.txtNewPass.Size = new System.Drawing.Size(207, 26);
            this.txtNewPass.TabIndex = 1;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.BackColor = System.Drawing.Color.White;
            this.txtConfirmPass.Font = new System.Drawing.Font("Roboto", 9F);
            this.txtConfirmPass.Location = new System.Drawing.Point(148, 98);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '●';
            this.txtConfirmPass.Size = new System.Drawing.Size(207, 26);
            this.txtConfirmPass.TabIndex = 2;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Roboto", 9F);
            this.lbl3.Location = new System.Drawing.Point(41, 43);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(101, 19);
            this.lbl3.TabIndex = 1;
            this.lbl3.Text = "Old Password";
            // 
            // txtOldPass
            // 
            this.txtOldPass.BackColor = System.Drawing.Color.White;
            this.txtOldPass.Font = new System.Drawing.Font("Roboto", 9F);
            this.txtOldPass.Location = new System.Drawing.Point(148, 40);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.PasswordChar = '●';
            this.txtOldPass.Size = new System.Drawing.Size(207, 26);
            this.txtOldPass.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(384, 156);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(49, 22);
            this.dateTimePicker.TabIndex = 20;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(15, 44);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(0, 17);
            this.lblpass.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(379, 12);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 22);
            this.txtUsername.TabIndex = 21;
            this.txtUsername.Visible = false;
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.ActiveBorderThickness = 1;
            this.BtnConfirm.ActiveCornerRadius = 20;
            this.BtnConfirm.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnConfirm.ActiveForecolor = System.Drawing.Color.White;
            this.BtnConfirm.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.BtnConfirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnConfirm.BackgroundImage")));
            this.BtnConfirm.ButtonText = "Confirm";
            this.BtnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfirm.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.BtnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnConfirm.IdleBorderThickness = 1;
            this.BtnConfirm.IdleCornerRadius = 20;
            this.BtnConfirm.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.BtnConfirm.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnConfirm.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnConfirm.Location = new System.Drawing.Point(216, 131);
            this.BtnConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(138, 45);
            this.BtnConfirm.TabIndex = 23;
            this.BtnConfirm.TabStop = false;
            this.BtnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(376, 199);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txtOldPass);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(385, 246);
            this.Name = "FrmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Changing Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        public System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtUsername;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnConfirm;
    }
}