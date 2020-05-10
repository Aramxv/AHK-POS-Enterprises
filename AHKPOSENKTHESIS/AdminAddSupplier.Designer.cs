namespace AHKPOSENKTHESIS
{
    partial class AdminAddSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAddSupplier));
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtSupplierName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSupplierAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSupplierPhone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSupplierTelephone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.WarningIndicator = new System.Windows.Forms.PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.WarningIndicator)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Poppins", 15F);
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.lbl1.Location = new System.Drawing.Point(114, 27);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(295, 46);
            this.lbl1.TabIndex = 65;
            this.lbl1.Text = "New Supplier";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSupplierName.BackColor = System.Drawing.Color.White;
            this.txtSupplierName.Depth = 0;
            this.txtSupplierName.ForeColor = System.Drawing.Color.Black;
            this.txtSupplierName.Hint = "Enter Supplier Name ";
            this.txtSupplierName.Location = new System.Drawing.Point(38, 121);
            this.txtSupplierName.MaxLength = 32767;
            this.txtSupplierName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.PasswordChar = '\0';
            this.txtSupplierName.SelectedText = "";
            this.txtSupplierName.SelectionLength = 0;
            this.txtSupplierName.SelectionStart = 0;
            this.txtSupplierName.Size = new System.Drawing.Size(443, 28);
            this.txtSupplierName.TabIndex = 0;
            this.txtSupplierName.TabStop = false;
            this.toolTip1.SetToolTip(this.txtSupplierName, "Type the Supplier Name in the textbox.");
            this.txtSupplierName.UseSystemPasswordChar = false;
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSupplierAddress.Depth = 0;
            this.txtSupplierAddress.Hint = "Enter Supplier\'s Address";
            this.txtSupplierAddress.Location = new System.Drawing.Point(38, 199);
            this.txtSupplierAddress.MaxLength = 32767;
            this.txtSupplierAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.PasswordChar = '\0';
            this.txtSupplierAddress.SelectedText = "";
            this.txtSupplierAddress.SelectionLength = 0;
            this.txtSupplierAddress.SelectionStart = 0;
            this.txtSupplierAddress.Size = new System.Drawing.Size(443, 28);
            this.txtSupplierAddress.TabIndex = 1;
            this.txtSupplierAddress.TabStop = false;
            this.toolTip1.SetToolTip(this.txtSupplierAddress, "Type the Supplier\'s Name in the textbox.");
            this.txtSupplierAddress.UseSystemPasswordChar = false;
            // 
            // txtSupplierPhone
            // 
            this.txtSupplierPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSupplierPhone.Depth = 0;
            this.txtSupplierPhone.Hint = "Phone 09";
            this.txtSupplierPhone.Location = new System.Drawing.Point(38, 275);
            this.txtSupplierPhone.MaxLength = 11;
            this.txtSupplierPhone.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSupplierPhone.Name = "txtSupplierPhone";
            this.txtSupplierPhone.PasswordChar = '\0';
            this.txtSupplierPhone.SelectedText = "";
            this.txtSupplierPhone.SelectionLength = 0;
            this.txtSupplierPhone.SelectionStart = 0;
            this.txtSupplierPhone.Size = new System.Drawing.Size(268, 28);
            this.txtSupplierPhone.TabIndex = 2;
            this.txtSupplierPhone.TabStop = false;
            this.toolTip1.SetToolTip(this.txtSupplierPhone, "+63 or 09");
            this.txtSupplierPhone.UseSystemPasswordChar = false;
            this.txtSupplierPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupplierPhone_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(35, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 30);
            this.label1.TabIndex = 36;
            this.label1.Text = "Supplier Name";
            this.toolTip1.SetToolTip(this.label1, "Supplier Name");
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 30);
            this.label2.TabIndex = 37;
            this.label2.Text = "Supplier Address";
            this.toolTip1.SetToolTip(this.label2, "Supplier Address");
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 10F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(35, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 30);
            this.label3.TabIndex = 38;
            this.label3.Text = "Phone Number";
            this.toolTip1.SetToolTip(this.label3, "Phone Number");
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 10F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(35, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 30);
            this.label5.TabIndex = 41;
            this.label5.Text = "Telephone Number";
            this.toolTip1.SetToolTip(this.label5, "Telephone Number");
            // 
            // txtSupplierTelephone
            // 
            this.txtSupplierTelephone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSupplierTelephone.Depth = 0;
            this.txtSupplierTelephone.Hint = "Telephone";
            this.txtSupplierTelephone.Location = new System.Drawing.Point(38, 350);
            this.txtSupplierTelephone.MaxLength = 10;
            this.txtSupplierTelephone.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSupplierTelephone.Name = "txtSupplierTelephone";
            this.txtSupplierTelephone.PasswordChar = '\0';
            this.txtSupplierTelephone.SelectedText = "";
            this.txtSupplierTelephone.SelectionLength = 0;
            this.txtSupplierTelephone.SelectionStart = 0;
            this.txtSupplierTelephone.Size = new System.Drawing.Size(268, 28);
            this.txtSupplierTelephone.TabIndex = 3;
            this.txtSupplierTelephone.TabStop = false;
            this.toolTip1.SetToolTip(this.txtSupplierTelephone, "Type the telephone number of the Supplier in the textbox.");
            this.txtSupplierTelephone.UseSystemPasswordChar = false;
            this.txtSupplierTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupplierTelephone_KeyPress);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.ActiveBorderThickness = 1;
            this.BtnUpdate.ActiveCornerRadius = 1;
            this.BtnUpdate.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnUpdate.ActiveForecolor = System.Drawing.Color.White;
            this.BtnUpdate.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.BackColor = System.Drawing.Color.White;
            this.BtnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnUpdate.BackgroundImage")));
            this.BtnUpdate.ButtonText = "Update";
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.BtnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnUpdate.IdleBorderThickness = 1;
            this.BtnUpdate.IdleCornerRadius = 1;
            this.BtnUpdate.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnUpdate.IdleForecolor = System.Drawing.Color.White;
            this.BtnUpdate.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnUpdate.Location = new System.Drawing.Point(112, 413);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(145, 60);
            this.BtnUpdate.TabIndex = 119;
            this.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.BtnUpdate, "Hit to process the making of your Customer\'s Invoice.");
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click_1);
            // 
            // BtnSave
            // 
            this.BtnSave.ActiveBorderThickness = 1;
            this.BtnSave.ActiveCornerRadius = 1;
            this.BtnSave.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnSave.ActiveForecolor = System.Drawing.Color.White;
            this.BtnSave.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.BackColor = System.Drawing.Color.White;
            this.BtnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSave.BackgroundImage")));
            this.BtnSave.ButtonText = "Save";
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.BtnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnSave.IdleBorderThickness = 1;
            this.BtnSave.IdleCornerRadius = 1;
            this.BtnSave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnSave.IdleForecolor = System.Drawing.Color.White;
            this.BtnSave.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnSave.Location = new System.Drawing.Point(-41, 413);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(145, 60);
            this.BtnSave.TabIndex = 118;
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.BtnSave, "Hit to process the making of your Customer\'s Invoice.");
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click_1);
            // 
            // BtnCancel
            // 
            this.BtnCancel.ActiveBorderThickness = 1;
            this.BtnCancel.ActiveCornerRadius = 1;
            this.BtnCancel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.BtnCancel.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnCancel.BackColor = System.Drawing.Color.White;
            this.BtnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCancel.BackgroundImage")));
            this.BtnCancel.ButtonText = "Cancel";
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.BtnCancel.ForeColor = System.Drawing.Color.DimGray;
            this.BtnCancel.IdleBorderThickness = 1;
            this.BtnCancel.IdleCornerRadius = 1;
            this.BtnCancel.IdleFillColor = System.Drawing.Color.White;
            this.BtnCancel.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnCancel.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnCancel.Location = new System.Drawing.Point(265, 413);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(145, 60);
            this.BtnCancel.TabIndex = 117;
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.BtnCancel, "Hit to process the making of your Customer\'s Invoice.");
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(23, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 22);
            this.label8.TabIndex = 63;
            this.label8.Text = "*";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(23, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 22);
            this.label4.TabIndex = 63;
            this.label4.Text = "*";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(23, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 22);
            this.label6.TabIndex = 63;
            this.label6.Text = "*";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // WarningIndicator
            // 
            this.WarningIndicator.Image = ((System.Drawing.Image)(resources.GetObject("WarningIndicator.Image")));
            this.WarningIndicator.Location = new System.Drawing.Point(475, 113);
            this.WarningIndicator.Name = "WarningIndicator";
            this.WarningIndicator.Size = new System.Drawing.Size(36, 36);
            this.WarningIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.WarningIndicator.TabIndex = 117;
            this.WarningIndicator.TabStop = false;
            this.WarningIndicator.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(531, 85);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 17);
            this.lblID.TabIndex = 179;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(-30, 392);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 1);
            this.panel1.TabIndex = 180;
            // 
            // AdminAddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(523, 502);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WarningIndicator);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSupplierTelephone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSupplierPhone);
            this.Controls.Add(this.txtSupplierAddress);
            this.Controls.Add(this.txtSupplierName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminAddSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WarningIndicator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtSupplierName;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtSupplierAddress;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtSupplierPhone;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtSupplierTelephone;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox WarningIndicator;
        public Bunifu.Framework.UI.BunifuThinButton2 BtnUpdate;
        public Bunifu.Framework.UI.BunifuThinButton2 BtnSave;
        public Bunifu.Framework.UI.BunifuThinButton2 BtnCancel;
        public System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Panel panel1;
    }
}