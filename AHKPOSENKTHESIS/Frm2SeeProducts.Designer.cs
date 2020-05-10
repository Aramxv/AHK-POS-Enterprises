namespace AHKPOSENKTHESIS
{
    partial class Frm2SeeProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm2SeeProducts));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BtnSearchCustomer = new System.Windows.Forms.PictureBox();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtnShowAllProducts = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCriticalProducts = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnGoodProducts = new Bunifu.Framework.UI.BunifuThinButton2();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProductRowCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSearchCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 45;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column5,
            this.ProductCode,
            this.Description,
            this.Price,
            this.Category,
            this.Quantity,
            this.Column3,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(29)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(231)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1506, 630);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 51;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.Width = 6;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ID";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            this.Column5.Width = 125;
            // 
            // ProductCode
            // 
            this.ProductCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProductCode.HeaderText = "PRODUCT CODE";
            this.ProductCode.MinimumWidth = 6;
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            this.ProductCode.Width = 185;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "DESCRIPTION";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Price.HeaderText = "PRICE";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 93;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Category.HeaderText = "CATEGORY";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 140;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Quantity.HeaderText = "QTY";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 77;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "WARNING QTY";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            this.Column3.Width = 125;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "STATUS";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 113;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(1538, 12);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(112, 22);
            this.dateTimePicker.TabIndex = 14;
            this.dateTimePicker.Visible = false;
            // 
            // BtnSearchCustomer
            // 
            this.BtnSearchCustomer.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearchCustomer.Image")));
            this.BtnSearchCustomer.Location = new System.Drawing.Point(12, 14);
            this.BtnSearchCustomer.Name = "BtnSearchCustomer";
            this.BtnSearchCustomer.Size = new System.Drawing.Size(32, 32);
            this.BtnSearchCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnSearchCustomer.TabIndex = 91;
            this.BtnSearchCustomer.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Depth = 0;
            this.txtSearch.Font = new System.Drawing.Font("Roboto", 9F);
            this.txtSearch.Hint = "Search product description here";
            this.txtSearch.Location = new System.Drawing.Point(50, 18);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(850, 28);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TabStop = false;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1063, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 98;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1074, 16);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 97;
            this.pictureBox3.TabStop = false;
            // 
            // BtnShowAllProducts
            // 
            this.BtnShowAllProducts.ActiveBorderThickness = 1;
            this.BtnShowAllProducts.ActiveCornerRadius = 20;
            this.BtnShowAllProducts.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnShowAllProducts.ActiveForecolor = System.Drawing.Color.White;
            this.BtnShowAllProducts.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnShowAllProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.BtnShowAllProducts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnShowAllProducts.BackgroundImage")));
            this.BtnShowAllProducts.ButtonText = "All";
            this.BtnShowAllProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnShowAllProducts.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.BtnShowAllProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnShowAllProducts.IdleBorderThickness = 1;
            this.BtnShowAllProducts.IdleCornerRadius = 20;
            this.BtnShowAllProducts.IdleFillColor = System.Drawing.Color.White;
            this.BtnShowAllProducts.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnShowAllProducts.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnShowAllProducts.Location = new System.Drawing.Point(1103, 5);
            this.BtnShowAllProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnShowAllProducts.Name = "BtnShowAllProducts";
            this.BtnShowAllProducts.Size = new System.Drawing.Size(107, 45);
            this.BtnShowAllProducts.TabIndex = 96;
            this.BtnShowAllProducts.TabStop = false;
            this.BtnShowAllProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.BtnShowAllProducts, "Show All Products. ");
            this.BtnShowAllProducts.Click += new System.EventHandler(this.BtnShowAllProducts_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1372, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 95;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1226, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCriticalProducts
            // 
            this.BtnCriticalProducts.ActiveBorderThickness = 1;
            this.BtnCriticalProducts.ActiveCornerRadius = 20;
            this.BtnCriticalProducts.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(49)))), ((int)(((byte)(30)))));
            this.BtnCriticalProducts.ActiveForecolor = System.Drawing.Color.White;
            this.BtnCriticalProducts.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(49)))), ((int)(((byte)(30)))));
            this.BtnCriticalProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.BtnCriticalProducts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCriticalProducts.BackgroundImage")));
            this.BtnCriticalProducts.ButtonText = "Critical";
            this.BtnCriticalProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCriticalProducts.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.BtnCriticalProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(49)))), ((int)(((byte)(30)))));
            this.BtnCriticalProducts.IdleBorderThickness = 1;
            this.BtnCriticalProducts.IdleCornerRadius = 20;
            this.BtnCriticalProducts.IdleFillColor = System.Drawing.Color.White;
            this.BtnCriticalProducts.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(49)))), ((int)(((byte)(30)))));
            this.BtnCriticalProducts.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(49)))), ((int)(((byte)(30)))));
            this.BtnCriticalProducts.Location = new System.Drawing.Point(1401, 5);
            this.BtnCriticalProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCriticalProducts.Name = "BtnCriticalProducts";
            this.BtnCriticalProducts.Size = new System.Drawing.Size(107, 45);
            this.BtnCriticalProducts.TabIndex = 93;
            this.BtnCriticalProducts.TabStop = false;
            this.BtnCriticalProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.BtnCriticalProducts, "Show All On Critical Products.");
            this.BtnCriticalProducts.Click += new System.EventHandler(this.BtnCriticalProducts_Click);
            // 
            // BtnGoodProducts
            // 
            this.BtnGoodProducts.ActiveBorderThickness = 1;
            this.BtnGoodProducts.ActiveCornerRadius = 20;
            this.BtnGoodProducts.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.BtnGoodProducts.ActiveForecolor = System.Drawing.Color.White;
            this.BtnGoodProducts.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.BtnGoodProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.BtnGoodProducts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGoodProducts.BackgroundImage")));
            this.BtnGoodProducts.ButtonText = "Good";
            this.BtnGoodProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGoodProducts.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.BtnGoodProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.BtnGoodProducts.IdleBorderThickness = 1;
            this.BtnGoodProducts.IdleCornerRadius = 20;
            this.BtnGoodProducts.IdleFillColor = System.Drawing.Color.White;
            this.BtnGoodProducts.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.BtnGoodProducts.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(163)))), ((int)(((byte)(26)))));
            this.BtnGoodProducts.Location = new System.Drawing.Point(1255, 5);
            this.BtnGoodProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnGoodProducts.Name = "BtnGoodProducts";
            this.BtnGoodProducts.Size = new System.Drawing.Size(107, 45);
            this.BtnGoodProducts.TabIndex = 92;
            this.BtnGoodProducts.TabStop = false;
            this.BtnGoodProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.BtnGoodProducts, "Show All Good base on Quantity Products.");
            this.BtnGoodProducts.Click += new System.EventHandler(this.BtnGoodProducts_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            this.panel1.Controls.Add(this.lblProductRowCount);
            this.panel1.Location = new System.Drawing.Point(12, 686);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1506, 23);
            this.panel1.TabIndex = 99;
            // 
            // lblProductRowCount
            // 
            this.lblProductRowCount.AutoSize = true;
            this.lblProductRowCount.Font = new System.Drawing.Font("Roboto", 8F);
            this.lblProductRowCount.ForeColor = System.Drawing.Color.White;
            this.lblProductRowCount.Location = new System.Drawing.Point(14, 2);
            this.lblProductRowCount.Name = "lblProductRowCount";
            this.lblProductRowCount.Size = new System.Drawing.Size(80, 18);
            this.lblProductRowCount.TabIndex = 0;
            this.lblProductRowCount.Text = "0 Customer";
            // 
            // Frm2SeeProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1530, 721);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BtnShowAllProducts);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnCriticalProducts);
            this.Controls.Add(this.BtnGoodProducts);
            this.Controls.Add(this.BtnSearchCustomer);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm2SeeProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm2SeeProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSearchCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.PictureBox BtnSearchCustomer;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnShowAllProducts;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnCriticalProducts;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnGoodProducts;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProductRowCount;
    }
}