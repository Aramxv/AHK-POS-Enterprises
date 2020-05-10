namespace AHKPOSENKTHESIS
{
    partial class FrmUserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserProfile));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnOpLogOut = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(45, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 181);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 15F);
            this.label1.Location = new System.Drawing.Point(270, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 15F);
            this.label2.Location = new System.Drawing.Point(270, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 15F);
            this.label3.Location = new System.Drawing.Point(270, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // BtnOpLogOut
            // 
            this.BtnOpLogOut.ActiveBorderThickness = 1;
            this.BtnOpLogOut.ActiveCornerRadius = 20;
            this.BtnOpLogOut.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnOpLogOut.ActiveForecolor = System.Drawing.Color.White;
            this.BtnOpLogOut.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnOpLogOut.BackColor = System.Drawing.SystemColors.Control;
            this.BtnOpLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnOpLogOut.BackgroundImage")));
            this.BtnOpLogOut.ButtonText = "Logout";
            this.BtnOpLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOpLogOut.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.BtnOpLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnOpLogOut.IdleBorderThickness = 1;
            this.BtnOpLogOut.IdleCornerRadius = 20;
            this.BtnOpLogOut.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.BtnOpLogOut.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnOpLogOut.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnOpLogOut.Location = new System.Drawing.Point(59, 211);
            this.BtnOpLogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnOpLogOut.Name = "BtnOpLogOut";
            this.BtnOpLogOut.Size = new System.Drawing.Size(154, 43);
            this.BtnOpLogOut.TabIndex = 65;
            this.BtnOpLogOut.TabStop = false;
            this.BtnOpLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 315);
            this.Controls.Add(this.BtnOpLogOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUserProfile";
            this.Text = "User Profile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnOpLogOut;
    }
}