namespace AHKPOSENKTHESIS
{
    partial class FrmDiscount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDiscount));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPercentDiscount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAmountDiscount = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.BtnConfirm = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(29)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 50);
            this.panel1.TabIndex = 2;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(282, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(36, 36);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnClose.TabIndex = 23;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 11F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Discount";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 73);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 19);
            this.lblID.TabIndex = 3;
            this.lblID.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.txtPrice.Location = new System.Drawing.Point(183, 68);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(127, 28);
            this.txtPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(19, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Discount (%)";
            // 
            // txtPercentDiscount
            // 
            this.txtPercentDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPercentDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.txtPercentDiscount.Font = new System.Drawing.Font("Roboto", 10F);
            this.txtPercentDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(231)))));
            this.txtPercentDiscount.Location = new System.Drawing.Point(183, 101);
            this.txtPercentDiscount.Name = "txtPercentDiscount";
            this.txtPercentDiscount.Size = new System.Drawing.Size(127, 28);
            this.txtPercentDiscount.TabIndex = 5;
            this.txtPercentDiscount.TextChanged += new System.EventHandler(this.TxtPercentDiscount_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(19, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Discount (Amount)";
            // 
            // txtAmountDiscount
            // 
            this.txtAmountDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmountDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.txtAmountDiscount.Enabled = false;
            this.txtAmountDiscount.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Italic);
            this.txtAmountDiscount.Location = new System.Drawing.Point(183, 134);
            this.txtAmountDiscount.Name = "txtAmountDiscount";
            this.txtAmountDiscount.Size = new System.Drawing.Size(127, 28);
            this.txtAmountDiscount.TabIndex = 5;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.label1;
            this.bunifuDragControl2.Vertical = true;
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
            this.BtnConfirm.ButtonText = "Discount";
            this.BtnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfirm.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.BtnConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnConfirm.IdleBorderThickness = 1;
            this.BtnConfirm.IdleCornerRadius = 20;
            this.BtnConfirm.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnConfirm.IdleForecolor = System.Drawing.Color.White;
            this.BtnConfirm.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnConfirm.Location = new System.Drawing.Point(193, 185);
            this.BtnConfirm.Margin = new System.Windows.Forms.Padding(5);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(107, 44);
            this.BtnConfirm.TabIndex = 8;
            this.BtnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click_1);
            // 
            // FrmDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(329, 243);
            this.ControlBox = false;
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.txtAmountDiscount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPercentDiscount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDiscount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmDiscount_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmDiscount_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.TextBox txtPercentDiscount;
        public System.Windows.Forms.TextBox txtAmountDiscount;
        public System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PictureBox BtnClose;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnConfirm;
    }
}