namespace AHKPOSENKTHESIS
{
    partial class AdminStockAdjustment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminStockAdjustment));
            this.BtnStockAdjustment = new System.Windows.Forms.Label();
            this.BtnInventory = new System.Windows.Forms.Label();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adjust = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblDataRowCount = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtReferenceNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.Label();
            this.WarningIndicator = new System.Windows.Forms.PictureBox();
            this.BtnSaveAdjustment = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cmbCommand = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtremcount = new System.Windows.Forms.Label();
            this.txtAdjustBy = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnPrint = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarningIndicator)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnStockAdjustment
            // 
            this.BtnStockAdjustment.AutoSize = true;
            this.BtnStockAdjustment.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.BtnStockAdjustment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.BtnStockAdjustment.Location = new System.Drawing.Point(169, 14);
            this.BtnStockAdjustment.Name = "BtnStockAdjustment";
            this.BtnStockAdjustment.Size = new System.Drawing.Size(247, 44);
            this.BtnStockAdjustment.TabIndex = 133;
            this.BtnStockAdjustment.Text = "Stock Adjustment";
            // 
            // BtnInventory
            // 
            this.BtnInventory.AutoSize = true;
            this.BtnInventory.Font = new System.Drawing.Font("Poppins", 15F);
            this.BtnInventory.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnInventory.Location = new System.Drawing.Point(9, 14);
            this.BtnInventory.Name = "BtnInventory";
            this.BtnInventory.Size = new System.Drawing.Size(154, 44);
            this.BtnInventory.TabIndex = 137;
            this.BtnInventory.Text = "Inventory >";
            this.BtnInventory.Click += new System.EventHandler(this.BtnInventory_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Depth = 0;
            this.txtSearch.Hint = "Search product description here";
            this.txtSearch.Location = new System.Drawing.Point(16, 65);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(578, 28);
            this.txtSearch.TabIndex = 138;
            this.txtSearch.TabStop = false;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(219)))), ((int)(((byte)(223)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Adjust});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(3, 96);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(231)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(699, 644);
            this.dataGridView1.TabIndex = 139;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 21;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 56;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "CODE";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 85;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "DESCRIPTION";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "CATEGORY";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 132;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "PRICE";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 89;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "SOH";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 75;
            // 
            // Adjust
            // 
            this.Adjust.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Adjust.HeaderText = "";
            this.Adjust.Image = ((System.Drawing.Image)(resources.GetObject("Adjust.Image")));
            this.Adjust.MinimumWidth = 6;
            this.Adjust.Name = "Adjust";
            this.Adjust.Width = 6;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.panel9.Controls.Add(this.lblDataRowCount);
            this.panel9.Location = new System.Drawing.Point(0, 741);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(702, 23);
            this.panel9.TabIndex = 146;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(459, 42);
            this.panel3.TabIndex = 151;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 30);
            this.label4.TabIndex = 155;
            this.label4.Text = "Product Details";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtReferenceNo);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtProductCode);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Location = new System.Drawing.Point(722, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 248);
            this.panel2.TabIndex = 150;
            // 
            // txtReferenceNo
            // 
            this.txtReferenceNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtReferenceNo.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.txtReferenceNo.ForeColor = System.Drawing.Color.Black;
            this.txtReferenceNo.Location = new System.Drawing.Point(40, 96);
            this.txtReferenceNo.Name = "txtReferenceNo";
            this.txtReferenceNo.Size = new System.Drawing.Size(392, 19);
            this.txtReferenceNo.TabIndex = 162;
            this.txtReferenceNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(19, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 26);
            this.label3.TabIndex = 55;
            this.label3.Text = "Reference No.";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtProductCode.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.txtProductCode.ForeColor = System.Drawing.Color.Black;
            this.txtProductCode.Location = new System.Drawing.Point(41, 150);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(391, 19);
            this.txtProductCode.TabIndex = 153;
            this.txtProductCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 26);
            this.label2.TabIndex = 55;
            this.label2.Text = "Product Description";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 26);
            this.label1.TabIndex = 55;
            this.label1.Text = "Product Code";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDescription.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(41, 199);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(400, 39);
            this.txtDescription.TabIndex = 154;
            // 
            // WarningIndicator
            // 
            this.WarningIndicator.Image = ((System.Drawing.Image)(resources.GetObject("WarningIndicator.Image")));
            this.WarningIndicator.Location = new System.Drawing.Point(418, 60);
            this.WarningIndicator.Name = "WarningIndicator";
            this.WarningIndicator.Size = new System.Drawing.Size(36, 36);
            this.WarningIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.WarningIndicator.TabIndex = 117;
            this.WarningIndicator.TabStop = false;
            this.WarningIndicator.Visible = false;
            this.WarningIndicator.Click += new System.EventHandler(this.WarningIndicator_Click);
            // 
            // BtnSaveAdjustment
            // 
            this.BtnSaveAdjustment.ActiveBorderThickness = 1;
            this.BtnSaveAdjustment.ActiveCornerRadius = 1;
            this.BtnSaveAdjustment.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnSaveAdjustment.ActiveForecolor = System.Drawing.Color.White;
            this.BtnSaveAdjustment.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnSaveAdjustment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSaveAdjustment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.BtnSaveAdjustment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSaveAdjustment.BackgroundImage")));
            this.BtnSaveAdjustment.ButtonText = "Adjust now";
            this.BtnSaveAdjustment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveAdjustment.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.BtnSaveAdjustment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnSaveAdjustment.IdleBorderThickness = 1;
            this.BtnSaveAdjustment.IdleCornerRadius = 1;
            this.BtnSaveAdjustment.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnSaveAdjustment.IdleForecolor = System.Drawing.Color.White;
            this.BtnSaveAdjustment.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnSaveAdjustment.Location = new System.Drawing.Point(967, 684);
            this.BtnSaveAdjustment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSaveAdjustment.Name = "BtnSaveAdjustment";
            this.BtnSaveAdjustment.Size = new System.Drawing.Size(145, 60);
            this.BtnSaveAdjustment.TabIndex = 158;
            this.BtnSaveAdjustment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSaveAdjustment.Click += new System.EventHandler(this.BtnSaveAdjustment_Click);
            // 
            // cmbCommand
            // 
            this.cmbCommand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCommand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCommand.BackColor = System.Drawing.Color.White;
            this.cmbCommand.Font = new System.Drawing.Font("Poppins", 9F);
            this.cmbCommand.FormattingEnabled = true;
            this.cmbCommand.Items.AddRange(new object[] {
            "Add to Inventory",
            "Remove from Inventory"});
            this.cmbCommand.Location = new System.Drawing.Point(164, 103);
            this.cmbCommand.MaxLength = 32000;
            this.cmbCommand.Name = "cmbCommand";
            this.cmbCommand.Size = new System.Drawing.Size(254, 34);
            this.cmbCommand.TabIndex = 157;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 9F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(19, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 26);
            this.label7.TabIndex = 154;
            this.label7.Text = "Stock Adjust By:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(19, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 26);
            this.label5.TabIndex = 155;
            this.label5.Text = "Remarks:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 9F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(17, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 26);
            this.label8.TabIndex = 156;
            this.label8.Text = "Command:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 42);
            this.panel1.TabIndex = 157;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 10F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(10, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 30);
            this.label9.TabIndex = 155;
            this.label9.Text = "Adjustment Details";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.WarningIndicator);
            this.panel4.Controls.Add(this.txtQuantity);
            this.panel4.Controls.Add(this.txtremcount);
            this.panel4.Controls.Add(this.txtAdjustBy);
            this.panel4.Controls.Add(this.txtRemarks);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.cmbCommand);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(722, 350);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(461, 325);
            this.panel4.TabIndex = 156;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Poppins", 9F);
            this.txtQuantity.Location = new System.Drawing.Point(164, 66);
            this.txtQuantity.MaxLength = 120;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(253, 30);
            this.txtQuantity.TabIndex = 168;
            // 
            // txtremcount
            // 
            this.txtremcount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtremcount.Font = new System.Drawing.Font("Roboto", 9F);
            this.txtremcount.ForeColor = System.Drawing.Color.Black;
            this.txtremcount.Location = new System.Drawing.Point(350, 244);
            this.txtremcount.Name = "txtremcount";
            this.txtremcount.Size = new System.Drawing.Size(66, 19);
            this.txtremcount.TabIndex = 163;
            this.txtremcount.Text = "0/120";
            this.txtremcount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAdjustBy
            // 
            this.txtAdjustBy.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold);
            this.txtAdjustBy.ForeColor = System.Drawing.Color.Black;
            this.txtAdjustBy.Location = new System.Drawing.Point(160, 270);
            this.txtAdjustBy.Name = "txtAdjustBy";
            this.txtAdjustBy.Size = new System.Drawing.Size(270, 23);
            this.txtAdjustBy.TabIndex = 167;
            this.txtAdjustBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Poppins", 9F);
            this.txtRemarks.Location = new System.Drawing.Point(165, 143);
            this.txtRemarks.MaxLength = 120;
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(253, 95);
            this.txtRemarks.TabIndex = 166;
            this.txtRemarks.TextChanged += new System.EventHandler(this.txtRemarks_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(17, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 26);
            this.label6.TabIndex = 163;
            this.label6.Text = "Qty (Adjusted):";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(1209, 3);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 17);
            this.lblID.TabIndex = 161;
            this.lblID.Visible = false;
            // 
            // BtnPrint
            // 
            this.BtnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrint.BackColor = System.Drawing.Color.Transparent;
            this.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrint.Image")));
            this.BtnPrint.ImageActive = null;
            this.BtnPrint.Location = new System.Drawing.Point(1135, 42);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(48, 48);
            this.BtnPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnPrint.TabIndex = 165;
            this.BtnPrint.TabStop = false;
            this.toolTip1.SetToolTip(this.BtnPrint, "Print Preview");
            this.BtnPrint.Zoom = 10;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.ActiveBorderThickness = 1;
            this.BtnCancel.ActiveCornerRadius = 1;
            this.BtnCancel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.BtnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.BtnCancel.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.BtnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCancel.BackgroundImage")));
            this.BtnCancel.ButtonText = "Cancel";
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.BtnCancel.ForeColor = System.Drawing.Color.DimGray;
            this.BtnCancel.IdleBorderThickness = 1;
            this.BtnCancel.IdleCornerRadius = 1;
            this.BtnCancel.IdleFillColor = System.Drawing.Color.White;
            this.BtnCancel.IdleForecolor = System.Drawing.Color.Empty;
            this.BtnCancel.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.BtnCancel.Location = new System.Drawing.Point(814, 684);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(145, 60);
            this.BtnCancel.TabIndex = 168;
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.BtnCancel, "Hit to process the making of your Customer\'s Invoice.");
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.dataGridView1;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(711, 106);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 664);
            this.panel5.TabIndex = 166;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.panel2;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this.panel4;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 10;
            this.bunifuElipse4.TargetControl = this;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel6.Location = new System.Drawing.Point(1124, 42);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 48);
            this.panel6.TabIndex = 167;
            // 
            // AdminStockAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.BtnSaveAdjustment);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.BtnInventory);
            this.Controls.Add(this.BtnStockAdjustment);
            this.Name = "AdminStockAdjustment";
            this.Size = new System.Drawing.Size(1195, 764);
            this.Load += new System.EventHandler(this.AdminStockAdjustment_Load);
            this.Click += new System.EventHandler(this.AdminStockAdjustment_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarningIndicator)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPrint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BtnStockAdjustment;
        private System.Windows.Forms.Label BtnInventory;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblDataRowCount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtDescription;
        private System.Windows.Forms.Label txtProductCode;
        private System.Windows.Forms.PictureBox WarningIndicator;
        public Bunifu.Framework.UI.BunifuThinButton2 BtnSaveAdjustment;
        public System.Windows.Forms.ComboBox cmbCommand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label txtReferenceNo;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuImageButton BtnPrint;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Adjust;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        public System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label txtremcount;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.TextBox txtQuantity;
        public Bunifu.Framework.UI.BunifuThinButton2 BtnCancel;
        public System.Windows.Forms.Label txtAdjustBy;
    }
}
