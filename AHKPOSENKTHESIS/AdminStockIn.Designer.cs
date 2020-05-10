namespace AHKPOSENKTHESIS
{
    partial class AdminStockIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminStockIn));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnSuppliers = new System.Windows.Forms.Label();
            this.BtnStockIn = new System.Windows.Forms.Label();
            this.BtnInventory = new System.Windows.Forms.Label();
            this.txtStockby = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtReference = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.BtnStocks = new Bunifu.Framework.UI.BunifuImageButton();
            this.dateTimePicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblDataRowCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WarningIndicator = new System.Windows.Forms.PictureBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnActivityHistory = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BtnSaveStockIn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnStockOut = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BtnStocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarningIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnActivityHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSaveStockIn)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSuppliers
            // 
            this.BtnSuppliers.AutoSize = true;
            this.BtnSuppliers.Font = new System.Drawing.Font("Poppins", 15F);
            this.BtnSuppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.BtnSuppliers.Location = new System.Drawing.Point(476, 14);
            this.BtnSuppliers.Name = "BtnSuppliers";
            this.BtnSuppliers.Size = new System.Drawing.Size(135, 44);
            this.BtnSuppliers.TabIndex = 144;
            this.BtnSuppliers.Text = "Suppliers";
            this.BtnSuppliers.Click += new System.EventHandler(this.BtnSuppliers_Click);
            // 
            // BtnStockIn
            // 
            this.BtnStockIn.AutoSize = true;
            this.BtnStockIn.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.BtnStockIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.BtnStockIn.Location = new System.Drawing.Point(169, 14);
            this.BtnStockIn.Name = "BtnStockIn";
            this.BtnStockIn.Size = new System.Drawing.Size(146, 44);
            this.BtnStockIn.TabIndex = 140;
            this.BtnStockIn.Text = "Stock-In >";
            this.BtnStockIn.Click += new System.EventHandler(this.BtnStockIn_Click);
            // 
            // BtnInventory
            // 
            this.BtnInventory.AutoSize = true;
            this.BtnInventory.Font = new System.Drawing.Font("Poppins", 15F);
            this.BtnInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(208)))));
            this.BtnInventory.Location = new System.Drawing.Point(9, 14);
            this.BtnInventory.Name = "BtnInventory";
            this.BtnInventory.Size = new System.Drawing.Size(154, 44);
            this.BtnInventory.TabIndex = 145;
            this.BtnInventory.Text = "Inventory >";
            this.BtnInventory.Click += new System.EventHandler(this.BtnInventory_Click);
            // 
            // txtStockby
            // 
            this.txtStockby.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtStockby.Depth = 0;
            this.txtStockby.Hint = "";
            this.txtStockby.Location = new System.Drawing.Point(164, 78);
            this.txtStockby.MaxLength = 32767;
            this.txtStockby.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtStockby.Name = "txtStockby";
            this.txtStockby.PasswordChar = '\0';
            this.txtStockby.SelectedText = "";
            this.txtStockby.SelectionLength = 0;
            this.txtStockby.SelectionStart = 0;
            this.txtStockby.Size = new System.Drawing.Size(315, 28);
            this.txtStockby.TabIndex = 147;
            this.txtStockby.TabStop = false;
            this.txtStockby.UseSystemPasswordChar = false;
            // 
            // txtReference
            // 
            this.txtReference.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtReference.Depth = 0;
            this.txtReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReference.Hint = "";
            this.txtReference.Location = new System.Drawing.Point(164, 41);
            this.txtReference.MaxLength = 9;
            this.txtReference.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtReference.Name = "txtReference";
            this.txtReference.PasswordChar = '\0';
            this.txtReference.SelectedText = "";
            this.txtReference.SelectionLength = 0;
            this.txtReference.SelectionStart = 0;
            this.txtReference.Size = new System.Drawing.Size(315, 28);
            this.txtReference.TabIndex = 146;
            this.txtReference.TabStop = false;
            this.txtReference.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(25, 126);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(130, 24);
            this.materialLabel3.TabIndex = 149;
            this.materialLabel3.Text = "Stock- In date:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(26, 78);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(113, 24);
            this.materialLabel2.TabIndex = 150;
            this.materialLabel2.Text = "Stock- In by:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(26, 43);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(135, 24);
            this.materialLabel1.TabIndex = 151;
            this.materialLabel1.Text = "Reference No.:";
            // 
            // BtnStocks
            // 
            this.BtnStocks.BackColor = System.Drawing.Color.Transparent;
            this.BtnStocks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStocks.Image = ((System.Drawing.Image)(resources.GetObject("BtnStocks.Image")));
            this.BtnStocks.ImageActive = null;
            this.BtnStocks.Location = new System.Drawing.Point(529, 195);
            this.BtnStocks.Name = "BtnStocks";
            this.BtnStocks.Size = new System.Drawing.Size(48, 48);
            this.BtnStocks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnStocks.TabIndex = 155;
            this.BtnStocks.TabStop = false;
            this.toolTip1.SetToolTip(this.BtnStocks, "Click to select products you wish to add stocks.");
            this.BtnStocks.Zoom = 10;
            this.BtnStocks.Click += new System.EventHandler(this.BtnStocks_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.dateTimePicker1.BorderRadius = 0;
            this.dateTimePicker1.ForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.FormatCustom = null;
            this.dateTimePicker1.Location = new System.Drawing.Point(164, 120);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(315, 44);
            this.dateTimePicker1.TabIndex = 156;
            this.dateTimePicker1.Value = new System.DateTime(2020, 4, 28, 9, 33, 54, 585);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(219)))), ((int)(((byte)(223)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridView2.ColumnHeadersHeight = 35;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.RE,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column2,
            this.Column3,
            this.Delete});
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle31;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView2.Location = new System.Drawing.Point(3, 249);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(231)))));
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1189, 486);
            this.dataGridView2.TabIndex = 157;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
            // RE
            // 
            this.RE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.RE.DefaultCellStyle = dataGridViewCellStyle26;
            this.RE.HeaderText = "REFERENCE NO.";
            this.RE.MinimumWidth = 6;
            this.RE.Name = "RE";
            this.RE.ReadOnly = true;
            this.RE.Width = 179;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewTextBoxColumn3.HeaderText = "PRODUCT CODE";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 174;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "PRODUCT DESCRIPTION";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridViewTextBoxColumn5.HeaderText = "QTY";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 72;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle29;
            this.Column2.HeaderText = "STOCK IN DATE";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 171;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle30;
            this.Column3.HeaderText = "STOCK IN BY";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 148;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 6;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.panel9.Controls.Add(this.lblDataRowCount);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 741);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1195, 23);
            this.panel9.TabIndex = 158;
            // 
            // lblDataRowCount
            // 
            this.lblDataRowCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDataRowCount.AutoSize = true;
            this.lblDataRowCount.Font = new System.Drawing.Font("Roboto", 8F);
            this.lblDataRowCount.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDataRowCount.Location = new System.Drawing.Point(13, 2);
            this.lblDataRowCount.Name = "lblDataRowCount";
            this.lblDataRowCount.Size = new System.Drawing.Size(199, 18);
            this.lblDataRowCount.TabIndex = 109;
            this.lblDataRowCount.Text = "0 Products stocks to be added ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.WarningIndicator);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.txtReference);
            this.panel1.Controls.Add(this.txtStockby);
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 175);
            this.panel1.TabIndex = 159;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // WarningIndicator
            // 
            this.WarningIndicator.Image = ((System.Drawing.Image)(resources.GetObject("WarningIndicator.Image")));
            this.WarningIndicator.Location = new System.Drawing.Point(456, 33);
            this.WarningIndicator.Name = "WarningIndicator";
            this.WarningIndicator.Size = new System.Drawing.Size(36, 36);
            this.WarningIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.WarningIndicator.TabIndex = 169;
            this.WarningIndicator.TabStop = false;
            this.toolTip1.SetToolTip(this.WarningIndicator, "Blank Fields Indicator");
            this.WarningIndicator.Visible = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(11, 9);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(141, 24);
            this.materialLabel4.TabIndex = 157;
            this.materialLabel4.Text = "Stock-In Details";
            // 
            // BtnActivityHistory
            // 
            this.BtnActivityHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnActivityHistory.BackColor = System.Drawing.Color.Transparent;
            this.BtnActivityHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnActivityHistory.Image = ((System.Drawing.Image)(resources.GetObject("BtnActivityHistory.Image")));
            this.BtnActivityHistory.ImageActive = null;
            this.BtnActivityHistory.Location = new System.Drawing.Point(1130, 195);
            this.BtnActivityHistory.Name = "BtnActivityHistory";
            this.BtnActivityHistory.Size = new System.Drawing.Size(48, 48);
            this.BtnActivityHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnActivityHistory.TabIndex = 161;
            this.BtnActivityHistory.TabStop = false;
            this.toolTip1.SetToolTip(this.BtnActivityHistory, "Activity History");
            this.BtnActivityHistory.Zoom = 10;
            this.BtnActivityHistory.Click += new System.EventHandler(this.BtnActivityHistory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.label1.Location = new System.Drawing.Point(583, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 162;
            this.label1.Text = "[Click here to view Products]";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.dataGridView2;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.panel1;
            // 
            // BtnSaveStockIn
            // 
            this.BtnSaveStockIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSaveStockIn.BackColor = System.Drawing.Color.Transparent;
            this.BtnSaveStockIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveStockIn.Image = ((System.Drawing.Image)(resources.GetObject("BtnSaveStockIn.Image")));
            this.BtnSaveStockIn.ImageActive = null;
            this.BtnSaveStockIn.Location = new System.Drawing.Point(1055, 195);
            this.BtnSaveStockIn.Name = "BtnSaveStockIn";
            this.BtnSaveStockIn.Size = new System.Drawing.Size(48, 48);
            this.BtnSaveStockIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnSaveStockIn.TabIndex = 163;
            this.BtnSaveStockIn.TabStop = false;
            this.toolTip1.SetToolTip(this.BtnSaveStockIn, "Save Stock-In");
            this.BtnSaveStockIn.Zoom = 10;
            this.BtnSaveStockIn.Click += new System.EventHandler(this.BtnSaveStockIn_Click_1);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(1116, 195);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 48);
            this.panel2.TabIndex = 164;
            // 
            // BtnStockOut
            // 
            this.BtnStockOut.AutoSize = true;
            this.BtnStockOut.Font = new System.Drawing.Font("Poppins", 15F);
            this.BtnStockOut.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnStockOut.Location = new System.Drawing.Point(321, 14);
            this.BtnStockOut.Name = "BtnStockOut";
            this.BtnStockOut.Size = new System.Drawing.Size(149, 44);
            this.BtnStockOut.TabIndex = 165;
            this.BtnStockOut.Text = "StockOut >";
            this.BtnStockOut.Click += new System.EventHandler(this.BtnStockOut_Click);
            // 
            // AdminStockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.BtnStockOut);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BtnSaveStockIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnActivityHistory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.BtnStocks);
            this.Controls.Add(this.BtnInventory);
            this.Controls.Add(this.BtnSuppliers);
            this.Controls.Add(this.BtnStockIn);
            this.Name = "AdminStockIn";
            this.Size = new System.Drawing.Size(1195, 764);
            this.Load += new System.EventHandler(this.AdminStockIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnStocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WarningIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnActivityHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSaveStockIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BtnSuppliers;
        private System.Windows.Forms.Label BtnStockIn;
        private System.Windows.Forms.Label BtnInventory;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtStockby;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtReference;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Bunifu.Framework.UI.BunifuImageButton BtnStocks;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblDataRowCount;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuImageButton BtnActivityHistory;
        public Bunifu.Framework.UI.BunifuDatepicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RE;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.PictureBox WarningIndicator;
        private Bunifu.Framework.UI.BunifuImageButton BtnSaveStockIn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label BtnStockOut;
    }
}
