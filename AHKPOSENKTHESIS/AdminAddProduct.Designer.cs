namespace AHKPOSENKTHESIS
{
    partial class AdminAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAddProduct));
            this.lblID = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDesc = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWarnqty = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtQuan = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.WarningIndicator = new System.Windows.Forms.PictureBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.WarningIndicator)).BeginInit();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(596, 527);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 22);
            this.lblID.TabIndex = 6;
            this.lblID.Visible = false;
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Poppins", 15F);
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.lbl1.Location = new System.Drawing.Point(126, 23);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(312, 49);
            this.lbl1.TabIndex = 19;
            this.lbl1.Text = "New Product";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.label3.Location = new System.Drawing.Point(25, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 30);
            this.label3.TabIndex = 48;
            this.label3.Text = "Category";
            this.toolTip1.SetToolTip(this.label3, "Category");
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.label2.Location = new System.Drawing.Point(25, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 30);
            this.label2.TabIndex = 47;
            this.label2.Text = "Product Code";
            this.toolTip1.SetToolTip(this.label2, "Product Code");
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.label1.Location = new System.Drawing.Point(25, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 30);
            this.label1.TabIndex = 46;
            this.label1.Text = "Product Name\r\n";
            this.toolTip1.SetToolTip(this.label1, "Product\'s Name");
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.Depth = 0;
            this.txtCode.Font = new System.Drawing.Font("Poppins", 10F);
            this.txtCode.Hint = "Enter Product Code";
            this.txtCode.Location = new System.Drawing.Point(27, 181);
            this.txtCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCode.MaxLength = 32767;
            this.txtCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.SelectedText = "";
            this.txtCode.SelectionLength = 0;
            this.txtCode.SelectionStart = 0;
            this.txtCode.Size = new System.Drawing.Size(488, 28);
            this.txtCode.TabIndex = 1;
            this.txtCode.TabStop = false;
            this.toolTip1.SetToolTip(this.txtCode, "Type the Product Code in the textbox.");
            this.txtCode.UseSystemPasswordChar = false;
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.txtDesc.Depth = 0;
            this.txtDesc.Font = new System.Drawing.Font("Poppins", 10F);
            this.txtDesc.ForeColor = System.Drawing.Color.Black;
            this.txtDesc.Hint = "Enter Product Name ";
            this.txtDesc.Location = new System.Drawing.Point(27, 108);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesc.MaxLength = 32767;
            this.txtDesc.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.PasswordChar = '\0';
            this.txtDesc.SelectedText = "";
            this.txtDesc.SelectionLength = 0;
            this.txtDesc.SelectionStart = 0;
            this.txtDesc.Size = new System.Drawing.Size(489, 28);
            this.txtDesc.TabIndex = 0;
            this.txtDesc.TabStop = false;
            this.toolTip1.SetToolTip(this.txtDesc, "Type the Product\'s Name in hte textbox.");
            this.txtDesc.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.label4.Location = new System.Drawing.Point(25, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 30);
            this.label4.TabIndex = 53;
            this.label4.Text = "Quantity";
            this.toolTip1.SetToolTip(this.label4, "Quantity");
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.label6.Location = new System.Drawing.Point(25, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 30);
            this.label6.TabIndex = 52;
            this.label6.Text = "Product Price";
            this.toolTip1.SetToolTip(this.label6, "Product Price");
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.txtPrice.Depth = 0;
            this.txtPrice.Font = new System.Drawing.Font("Poppins", 10F);
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.Hint = "₱0.00";
            this.txtPrice.Location = new System.Drawing.Point(28, 326);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.Size = new System.Drawing.Size(285, 28);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TabStop = false;
            this.toolTip1.SetToolTip(this.txtPrice, "Type the Product price in the textbox.");
            this.txtPrice.UseSystemPasswordChar = false;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.label7.Location = new System.Drawing.Point(24, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 30);
            this.label7.TabIndex = 55;
            this.label7.Text = "Warning Stock";
            this.toolTip1.SetToolTip(this.label7, "Warning Stock");
            // 
            // txtWarnqty
            // 
            this.txtWarnqty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWarnqty.Depth = 0;
            this.txtWarnqty.Font = new System.Drawing.Font("Poppins", 10F);
            this.txtWarnqty.Hint = "0";
            this.txtWarnqty.Location = new System.Drawing.Point(27, 466);
            this.txtWarnqty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtWarnqty.MaxLength = 32767;
            this.txtWarnqty.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtWarnqty.Name = "txtWarnqty";
            this.txtWarnqty.PasswordChar = '\0';
            this.txtWarnqty.SelectedText = "";
            this.txtWarnqty.SelectionLength = 0;
            this.txtWarnqty.SelectionStart = 0;
            this.txtWarnqty.Size = new System.Drawing.Size(285, 28);
            this.txtWarnqty.TabIndex = 5;
            this.txtWarnqty.TabStop = false;
            this.toolTip1.SetToolTip(this.txtWarnqty, "Type the Warning Level of the Product, in order to monitor the Product\'s on-hand-" +
        "stock.");
            this.txtWarnqty.UseSystemPasswordChar = false;
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
            this.BtnCancel.Location = new System.Drawing.Point(286, 515);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(145, 60);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.BtnCancel, "Hit to process the making of your Customer\'s Invoice.");
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
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
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.IdleBorderThickness = 1;
            this.BtnSave.IdleCornerRadius = 1;
            this.BtnSave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnSave.IdleForecolor = System.Drawing.Color.White;
            this.BtnSave.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnSave.Location = new System.Drawing.Point(-20, 515);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(145, 60);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.BtnSave, "Hit to process the making of your Customer\'s Invoice.");
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
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
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.IdleBorderThickness = 1;
            this.BtnUpdate.IdleCornerRadius = 1;
            this.BtnUpdate.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnUpdate.IdleForecolor = System.Drawing.Color.White;
            this.BtnUpdate.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnUpdate.Location = new System.Drawing.Point(133, 515);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(145, 60);
            this.BtnUpdate.TabIndex = 7;
            this.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.BtnUpdate, "Hit to process the making of your Customer\'s Invoice.");
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // txtQuan
            // 
            this.txtQuan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuan.Depth = 0;
            this.txtQuan.Font = new System.Drawing.Font("Poppins", 10F);
            this.txtQuan.Hint = "0";
            this.txtQuan.Location = new System.Drawing.Point(29, 397);
            this.txtQuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtQuan.MaxLength = 32767;
            this.txtQuan.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtQuan.Name = "txtQuan";
            this.txtQuan.PasswordChar = '\0';
            this.txtQuan.SelectedText = "";
            this.txtQuan.SelectionLength = 0;
            this.txtQuan.SelectionStart = 0;
            this.txtQuan.Size = new System.Drawing.Size(285, 28);
            this.txtQuan.TabIndex = 4;
            this.txtQuan.TabStop = false;
            this.toolTip1.SetToolTip(this.txtQuan, "Type the Quantity of the Product in the textbox if it is available. (Optional)");
            this.txtQuan.UseSystemPasswordChar = false;
            this.txtQuan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuan_KeyPress_1);
            // 
            // WarningIndicator
            // 
            this.WarningIndicator.Image = ((System.Drawing.Image)(resources.GetObject("WarningIndicator.Image")));
            this.WarningIndicator.Location = new System.Drawing.Point(522, 100);
            this.WarningIndicator.Name = "WarningIndicator";
            this.WarningIndicator.Size = new System.Drawing.Size(36, 36);
            this.WarningIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.WarningIndicator.TabIndex = 118;
            this.WarningIndicator.TabStop = false;
            this.toolTip1.SetToolTip(this.WarningIndicator, "Blank Fields Indicator");
            this.WarningIndicator.Visible = false;
            this.WarningIndicator.Click += new System.EventHandler(this.pnlWarning_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(598, 75);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(116, 29);
            this.dateTimePicker.TabIndex = 59;
            this.dateTimePicker.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 22);
            this.label5.TabIndex = 46;
            this.label5.Text = "*";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(12, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 22);
            this.label8.TabIndex = 46;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(12, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 22);
            this.label9.TabIndex = 46;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(12, 290);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 22);
            this.label10.TabIndex = 46;
            this.label10.Text = "*";
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
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.lbl1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(-9, 506);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 1);
            this.panel1.TabIndex = 119;
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Roboto", 10F);
            this.txtCategory.FormattingEnabled = true;
            this.txtCategory.Location = new System.Drawing.Point(27, 247);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(344, 30);
            this.txtCategory.TabIndex = 120;
            // 
            // AdminAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 598);
            this.ControlBox = false;
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WarningIndicator);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtQuan);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtWarnqty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblID);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(564, 598);
            this.Name = "AdminAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.Click += new System.EventHandler(this.FrmProduct_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmProduct_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.WarningIndicator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtCode;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtPrice;
        private System.Windows.Forms.Label label7;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtWarnqty;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        public Bunifu.Framework.UI.BunifuThinButton2 BtnCancel;
        public Bunifu.Framework.UI.BunifuThinButton2 BtnSave;
        public Bunifu.Framework.UI.BunifuThinButton2 BtnUpdate;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtQuan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox WarningIndicator;
        public System.Windows.Forms.ComboBox txtCategory;
    }
}