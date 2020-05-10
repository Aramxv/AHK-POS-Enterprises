namespace AHKPOSENKTHESIS
{
    partial class AdminProductDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProductDetails));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWhatProduct = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblWhatCategory = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblWhatID = new System.Windows.Forms.Label();
            this.lblWhatPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWhatStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWhatCode = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "General Product");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblWhatProduct
            // 
            this.lblWhatProduct.AutoSize = true;
            this.lblWhatProduct.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.lblWhatProduct.Location = new System.Drawing.Point(223, 63);
            this.lblWhatProduct.Name = "lblWhatProduct";
            this.lblWhatProduct.Size = new System.Drawing.Size(162, 36);
            this.lblWhatProduct.TabIndex = 1;
            this.lblWhatProduct.Text = "Tag Heuer SVE";
            this.toolTip1.SetToolTip(this.lblWhatProduct, "Description of the Product.");
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblWhatCategory
            // 
            this.lblWhatCategory.AutoSize = true;
            this.lblWhatCategory.Font = new System.Drawing.Font("Poppins", 9F);
            this.lblWhatCategory.Location = new System.Drawing.Point(223, 108);
            this.lblWhatCategory.Name = "lblWhatCategory";
            this.lblWhatCategory.Size = new System.Drawing.Size(327, 26);
            this.lblWhatCategory.TabIndex = 2;
            this.lblWhatCategory.Text = "This product is under Shampoo Category.";
            this.toolTip1.SetToolTip(this.lblWhatCategory, "Product Category");
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.lbl.ForeColor = System.Drawing.Color.Gray;
            this.lbl.Location = new System.Drawing.Point(223, 176);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(36, 36);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "ID";
            // 
            // lblWhatID
            // 
            this.lblWhatID.AutoSize = true;
            this.lblWhatID.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.lblWhatID.Location = new System.Drawing.Point(224, 221);
            this.lblWhatID.Name = "lblWhatID";
            this.lblWhatID.Size = new System.Drawing.Size(37, 26);
            this.lblWhatID.TabIndex = 4;
            this.lblWhatID.Text = "100";
            this.toolTip1.SetToolTip(this.lblWhatID, "Product ID generated in the Database.");
            // 
            // lblWhatPrice
            // 
            this.lblWhatPrice.AutoSize = true;
            this.lblWhatPrice.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.lblWhatPrice.Location = new System.Drawing.Point(420, 221);
            this.lblWhatPrice.Name = "lblWhatPrice";
            this.lblWhatPrice.Size = new System.Drawing.Size(49, 26);
            this.lblWhatPrice.TabIndex = 6;
            this.lblWhatPrice.Text = "₱100";
            this.toolTip1.SetToolTip(this.lblWhatPrice, "Price of the Product.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(419, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price";
            // 
            // lblWhatStatus
            // 
            this.lblWhatStatus.AutoSize = true;
            this.lblWhatStatus.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.lblWhatStatus.Location = new System.Drawing.Point(511, 221);
            this.lblWhatStatus.Name = "lblWhatStatus";
            this.lblWhatStatus.Size = new System.Drawing.Size(53, 26);
            this.lblWhatStatus.TabIndex = 8;
            this.lblWhatStatus.Text = "Good";
            this.toolTip1.SetToolTip(this.lblWhatStatus, "Status of the Product");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(510, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status";
            // 
            // lblWhatCode
            // 
            this.lblWhatCode.AutoSize = true;
            this.lblWhatCode.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.lblWhatCode.Location = new System.Drawing.Point(291, 221);
            this.lblWhatCode.Name = "lblWhatCode";
            this.lblWhatCode.Size = new System.Drawing.Size(92, 26);
            this.lblWhatCode.TabIndex = 10;
            this.lblWhatCode.Text = "PCS THSVE";
            this.toolTip1.SetToolTip(this.lblWhatCode, "Product Code");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(290, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "Code";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(626, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "AHK Enterprises");
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.panel1.Location = new System.Drawing.Point(257, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 22);
            this.panel1.TabIndex = 12;
            // 
            // BtnClose
            // 
            this.BtnClose.ActiveBorderThickness = 1;
            this.BtnClose.ActiveCornerRadius = 1;
            this.BtnClose.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnClose.ActiveForecolor = System.Drawing.Color.White;
            this.BtnClose.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.White;
            this.BtnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.BackgroundImage")));
            this.BtnClose.ButtonText = "Close";
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.BtnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnClose.IdleBorderThickness = 1;
            this.BtnClose.IdleCornerRadius = 1;
            this.BtnClose.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnClose.IdleForecolor = System.Drawing.Color.White;
            this.BtnClose.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnClose.Location = new System.Drawing.Point(612, 221);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(89, 54);
            this.BtnClose.TabIndex = 115;
            this.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.BtnClose, "Close Button");
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.panel1;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // AdminProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(714, 288);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblWhatCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblWhatStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblWhatPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWhatID);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblWhatCategory);
            this.Controls.Add(this.lblWhatProduct);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminProductDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminProductDetails";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblWhatProduct;
        public System.Windows.Forms.Label lblWhatCategory;
        public System.Windows.Forms.Label lblWhatID;
        public System.Windows.Forms.Label lblWhatPrice;
        public System.Windows.Forms.Label lblWhatStatus;
        public System.Windows.Forms.Label lblWhatCode;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuThinButton2 BtnClose;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}