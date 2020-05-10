namespace AHKPOSENKTHESIS
{
    partial class AdminInventory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInventory));
            this.BtnInventory = new System.Windows.Forms.Label();
            this.BtnSuppliers = new System.Windows.Forms.Label();
            this.BtnStockIn = new System.Windows.Forms.Label();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblDataRowCount = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnCritical = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnShowAll = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnNormal = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnStockAdjust = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnReload = new Bunifu.Framework.UI.BunifuImageButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BtnStockOut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCritical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnShowAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnStockAdjust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnReload)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnInventory
            // 
            this.BtnInventory.AutoSize = true;
            this.BtnInventory.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.BtnInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.BtnInventory.Location = new System.Drawing.Point(9, 14);
            this.BtnInventory.Name = "BtnInventory";
            this.BtnInventory.Size = new System.Drawing.Size(162, 44);
            this.BtnInventory.TabIndex = 132;
            this.BtnInventory.Text = "Inventory >";
            this.BtnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnInventory.Click += new System.EventHandler(this.BtnInventory_Click);
            // 
            // BtnSuppliers
            // 
            this.BtnSuppliers.AutoSize = true;
            this.BtnSuppliers.Font = new System.Drawing.Font("Poppins", 15F);
            this.BtnSuppliers.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnSuppliers.Location = new System.Drawing.Point(476, 14);
            this.BtnSuppliers.Name = "BtnSuppliers";
            this.BtnSuppliers.Size = new System.Drawing.Size(135, 44);
            this.BtnSuppliers.TabIndex = 139;
            this.BtnSuppliers.Text = "Suppliers";
            this.BtnSuppliers.Click += new System.EventHandler(this.BtnSuppliers_Click);
            // 
            // BtnStockIn
            // 
            this.BtnStockIn.AutoSize = true;
            this.BtnStockIn.Font = new System.Drawing.Font("Poppins", 15F);
            this.BtnStockIn.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnStockIn.Location = new System.Drawing.Point(177, 14);
            this.BtnStockIn.Name = "BtnStockIn";
            this.BtnStockIn.Size = new System.Drawing.Size(138, 44);
            this.BtnStockIn.TabIndex = 137;
            this.BtnStockIn.Text = "Stock-In >";
            this.BtnStockIn.Click += new System.EventHandler(this.BtnStockIn_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Depth = 0;
            this.txtSearch.Hint = "   Search product description here";
            this.txtSearch.Location = new System.Drawing.Point(16, 65);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(578, 28);
            this.txtSearch.TabIndex = 141;
            this.txtSearch.TabStop = false;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(219)))), ((int)(((byte)(223)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dataGridView1.ColumnHeadersHeight = 35;
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
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(29)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle38;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.Location = new System.Drawing.Point(3, 98);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(231)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle40;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1189, 641);
            this.dataGridView1.TabIndex = 140;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 21;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
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
            this.ProductCode.Width = 174;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.HeaderText = "PRODUCT DESCRIPTION";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Price.DefaultCellStyle = dataGridViewCellStyle34;
            this.Price.HeaderText = "PRICE";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 89;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Category.HeaderText = "CATEGORY";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 132;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle35;
            this.Quantity.HeaderText = "QTY";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 72;
            // 
            // Column3
            // 
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle36;
            this.Column3.HeaderText = "WARNING";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.SeaGreen;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle37;
            this.Column2.HeaderText = "STATUS";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 105;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.panel9.Controls.Add(this.lblDataRowCount);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 741);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1195, 23);
            this.panel9.TabIndex = 144;
            // 
            // lblDataRowCount
            // 
            this.lblDataRowCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDataRowCount.AutoSize = true;
            this.lblDataRowCount.Font = new System.Drawing.Font("Roboto", 8F);
            this.lblDataRowCount.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDataRowCount.Location = new System.Drawing.Point(13, 2);
            this.lblDataRowCount.Name = "lblDataRowCount";
            this.lblDataRowCount.Size = new System.Drawing.Size(184, 18);
            this.lblDataRowCount.TabIndex = 109;
            this.lblDataRowCount.Text = "0 Products Inventory Shown";
            // 
            // BtnCritical
            // 
            this.BtnCritical.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCritical.BackColor = System.Drawing.Color.Transparent;
            this.BtnCritical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCritical.Image = ((System.Drawing.Image)(resources.GetObject("BtnCritical.Image")));
            this.BtnCritical.ImageActive = null;
            this.BtnCritical.Location = new System.Drawing.Point(999, 54);
            this.BtnCritical.Name = "BtnCritical";
            this.BtnCritical.Size = new System.Drawing.Size(41, 37);
            this.BtnCritical.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnCritical.TabIndex = 151;
            this.BtnCritical.TabStop = false;
            this.toolTip1.SetToolTip(this.BtnCritical, "View Critical State Products");
            this.BtnCritical.Zoom = 10;
            this.BtnCritical.Click += new System.EventHandler(this.BtnCritical_Click_1);
            // 
            // BtnShowAll
            // 
            this.BtnShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnShowAll.BackColor = System.Drawing.Color.Transparent;
            this.BtnShowAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnShowAll.Image = ((System.Drawing.Image)(resources.GetObject("BtnShowAll.Image")));
            this.BtnShowAll.ImageActive = null;
            this.BtnShowAll.Location = new System.Drawing.Point(905, 54);
            this.BtnShowAll.Name = "BtnShowAll";
            this.BtnShowAll.Size = new System.Drawing.Size(41, 37);
            this.BtnShowAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnShowAll.TabIndex = 152;
            this.BtnShowAll.TabStop = false;
            this.toolTip1.SetToolTip(this.BtnShowAll, "View All Inventory Products");
            this.BtnShowAll.Zoom = 10;
            this.BtnShowAll.Click += new System.EventHandler(this.BtnShowAll_Click_1);
            // 
            // BtnNormal
            // 
            this.BtnNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNormal.BackColor = System.Drawing.Color.Transparent;
            this.BtnNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNormal.Image = ((System.Drawing.Image)(resources.GetObject("BtnNormal.Image")));
            this.BtnNormal.ImageActive = null;
            this.BtnNormal.Location = new System.Drawing.Point(952, 54);
            this.BtnNormal.Name = "BtnNormal";
            this.BtnNormal.Size = new System.Drawing.Size(41, 37);
            this.BtnNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnNormal.TabIndex = 153;
            this.BtnNormal.TabStop = false;
            this.toolTip1.SetToolTip(this.BtnNormal, "View Good State Products");
            this.BtnNormal.Zoom = 10;
            this.BtnNormal.Click += new System.EventHandler(this.BtnNormal_Click_1);
            // 
            // BtnStockAdjust
            // 
            this.BtnStockAdjust.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnStockAdjust.BackColor = System.Drawing.Color.Transparent;
            this.BtnStockAdjust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStockAdjust.Image = ((System.Drawing.Image)(resources.GetObject("BtnStockAdjust.Image")));
            this.BtnStockAdjust.ImageActive = null;
            this.BtnStockAdjust.Location = new System.Drawing.Point(1076, 44);
            this.BtnStockAdjust.Name = "BtnStockAdjust";
            this.BtnStockAdjust.Size = new System.Drawing.Size(48, 48);
            this.BtnStockAdjust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnStockAdjust.TabIndex = 154;
            this.BtnStockAdjust.TabStop = false;
            this.toolTip1.SetToolTip(this.BtnStockAdjust, "Stock Adjustment");
            this.BtnStockAdjust.Zoom = 10;
            this.BtnStockAdjust.Click += new System.EventHandler(this.BtnStockAdjust_Click_1);
            // 
            // BtnReload
            // 
            this.BtnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReload.BackColor = System.Drawing.Color.Transparent;
            this.BtnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReload.Image = ((System.Drawing.Image)(resources.GetObject("BtnReload.Image")));
            this.BtnReload.ImageActive = null;
            this.BtnReload.Location = new System.Drawing.Point(1130, 45);
            this.BtnReload.Name = "BtnReload";
            this.BtnReload.Size = new System.Drawing.Size(48, 48);
            this.BtnReload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnReload.TabIndex = 155;
            this.BtnReload.TabStop = false;
            this.toolTip1.SetToolTip(this.BtnReload, "Refresh");
            this.BtnReload.Zoom = 10;
            this.BtnReload.Click += new System.EventHandler(this.BtnReload_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(1297, 65);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(112, 22);
            this.dateTimePicker.TabIndex = 145;
            this.dateTimePicker.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(901, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 24);
            this.label1.TabIndex = 148;
            this.label1.Text = "Sort by";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(1058, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 48);
            this.panel1.TabIndex = 149;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.dataGridView1;
            // 
            // BtnStockOut
            // 
            this.BtnStockOut.AutoSize = true;
            this.BtnStockOut.Font = new System.Drawing.Font("Poppins", 15F);
            this.BtnStockOut.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnStockOut.Location = new System.Drawing.Point(321, 14);
            this.BtnStockOut.Name = "BtnStockOut";
            this.BtnStockOut.Size = new System.Drawing.Size(149, 44);
            this.BtnStockOut.TabIndex = 156;
            this.BtnStockOut.Text = "StockOut >";
            this.BtnStockOut.Click += new System.EventHandler(this.BtnStockOut_Click);
            // 
            // AdminInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.BtnStockOut);
            this.Controls.Add(this.BtnReload);
            this.Controls.Add(this.BtnStockAdjust);
            this.Controls.Add(this.BtnNormal);
            this.Controls.Add(this.BtnShowAll);
            this.Controls.Add(this.BtnCritical);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnSuppliers);
            this.Controls.Add(this.BtnStockIn);
            this.Controls.Add(this.BtnInventory);
            this.Name = "AdminInventory";
            this.Size = new System.Drawing.Size(1195, 764);
            this.Load += new System.EventHandler(this.AdminInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCritical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnShowAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnStockAdjust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnReload)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label BtnInventory;
        private System.Windows.Forms.Label BtnSuppliers;
        private System.Windows.Forms.Label BtnStockIn;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblDataRowCount;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
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
        private Bunifu.Framework.UI.BunifuImageButton BtnCritical;
        private Bunifu.Framework.UI.BunifuImageButton BtnShowAll;
        private Bunifu.Framework.UI.BunifuImageButton BtnNormal;
        private Bunifu.Framework.UI.BunifuImageButton BtnStockAdjust;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton BtnReload;
        private System.Windows.Forms.Label BtnStockOut;
    }
}
