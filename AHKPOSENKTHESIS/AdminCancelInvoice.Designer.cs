namespace AHKPOSENKTHESIS
{
    partial class AdminCancelInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCancelInvoice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnCancelInvoices = new System.Windows.Forms.Label();
            this.txtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblDataRowCount = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnOverdueInvoices = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnPaidInvoices = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnCancelledInvoices = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnFilterByDate = new Bunifu.Framework.UI.BunifuImageButton();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.BtnClearFilters = new Bunifu.Framework.UI.BunifuImageButton();
            this.cmbShown = new System.Windows.Forms.ComboBox();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.PnlFilter = new System.Windows.Forms.Panel();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.BtnFilter = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuDatepicker2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteCancel = new System.Windows.Forms.DataGridViewImageColumn();
            this.BtnInvoices = new System.Windows.Forms.Label();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnOverdueInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPaidInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelledInvoices)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFilterByDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClearFilters)).BeginInit();
            this.PnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelInvoices
            // 
            this.BtnCancelInvoices.AutoSize = true;
            this.BtnCancelInvoices.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelInvoices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(3)))));
            this.BtnCancelInvoices.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelInvoices.Location = new System.Drawing.Point(152, 14);
            this.BtnCancelInvoices.Name = "BtnCancelInvoices";
            this.BtnCancelInvoices.Size = new System.Drawing.Size(271, 37);
            this.BtnCancelInvoices.TabIndex = 175;
            this.BtnCancelInvoices.Text = "Cancelled Invoices";
            this.BtnCancelInvoices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            this.txtSearch.Depth = 0;
            this.txtSearch.Hint = "Search customer name here";
            this.txtSearch.Location = new System.Drawing.Point(16, 65);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.Size = new System.Drawing.Size(424, 28);
            this.txtSearch.TabIndex = 177;
            this.txtSearch.TabStop = false;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            this.panel9.Controls.Add(this.lblDataRowCount);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 741);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1195, 23);
            this.panel9.TabIndex = 179;
            // 
            // lblDataRowCount
            // 
            this.lblDataRowCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDataRowCount.AutoSize = true;
            this.lblDataRowCount.Font = new System.Drawing.Font("Roboto", 8F);
            this.lblDataRowCount.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDataRowCount.Location = new System.Drawing.Point(13, 2);
            this.lblDataRowCount.Name = "lblDataRowCount";
            this.lblDataRowCount.Size = new System.Drawing.Size(179, 18);
            this.lblDataRowCount.TabIndex = 109;
            this.lblDataRowCount.Text = "0 Cancelled Invoices Shown";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(686, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 48);
            this.panel3.TabIndex = 191;
            // 
            // BtnOverdueInvoices
            // 
            this.BtnOverdueInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOverdueInvoices.BackColor = System.Drawing.Color.Transparent;
            this.BtnOverdueInvoices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOverdueInvoices.Image = ((System.Drawing.Image)(resources.GetObject("BtnOverdueInvoices.Image")));
            this.BtnOverdueInvoices.ImageActive = null;
            this.BtnOverdueInvoices.Location = new System.Drawing.Point(576, 43);
            this.BtnOverdueInvoices.Name = "BtnOverdueInvoices";
            this.BtnOverdueInvoices.Size = new System.Drawing.Size(48, 48);
            this.BtnOverdueInvoices.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnOverdueInvoices.TabIndex = 190;
            this.BtnOverdueInvoices.TabStop = false;
            this.BtnOverdueInvoices.Zoom = 10;
            this.BtnOverdueInvoices.Click += new System.EventHandler(this.BtnOverdueInvoices_Click);
            // 
            // BtnPaidInvoices
            // 
            this.BtnPaidInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPaidInvoices.BackColor = System.Drawing.Color.Transparent;
            this.BtnPaidInvoices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPaidInvoices.Image = ((System.Drawing.Image)(resources.GetObject("BtnPaidInvoices.Image")));
            this.BtnPaidInvoices.ImageActive = null;
            this.BtnPaidInvoices.Location = new System.Drawing.Point(522, 43);
            this.BtnPaidInvoices.Name = "BtnPaidInvoices";
            this.BtnPaidInvoices.Size = new System.Drawing.Size(48, 48);
            this.BtnPaidInvoices.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnPaidInvoices.TabIndex = 189;
            this.BtnPaidInvoices.TabStop = false;
            this.BtnPaidInvoices.Zoom = 10;
            this.BtnPaidInvoices.Click += new System.EventHandler(this.BtnPaidInvoices_Click);
            // 
            // BtnCancelledInvoices
            // 
            this.BtnCancelledInvoices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelledInvoices.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelledInvoices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelledInvoices.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelledInvoices.Image")));
            this.BtnCancelledInvoices.ImageActive = null;
            this.BtnCancelledInvoices.Location = new System.Drawing.Point(630, 43);
            this.BtnCancelledInvoices.Name = "BtnCancelledInvoices";
            this.BtnCancelledInvoices.Size = new System.Drawing.Size(48, 48);
            this.BtnCancelledInvoices.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnCancelledInvoices.TabIndex = 186;
            this.BtnCancelledInvoices.TabStop = false;
            this.BtnCancelledInvoices.Zoom = 10;
            this.BtnCancelledInvoices.Click += new System.EventHandler(this.BtnCancelledInvoices_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label1.Location = new System.Drawing.Point(518, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 187;
            this.label1.Text = "See also";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.BtnFilterByDate);
            this.panel1.Controls.Add(this.cmbSort);
            this.panel1.Controls.Add(this.BtnClearFilters);
            this.panel1.Controls.Add(this.cmbShown);
            this.panel1.Controls.Add(this.cmbCustomer);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(694, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 70);
            this.panel1.TabIndex = 188;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label10.Location = new System.Drawing.Point(11, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 44;
            this.label10.Text = "Entries";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label9.Location = new System.Drawing.Point(84, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 44;
            this.label9.Text = "Sort by Terms";
            // 
            // BtnFilterByDate
            // 
            this.BtnFilterByDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFilterByDate.BackColor = System.Drawing.Color.Transparent;
            this.BtnFilterByDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFilterByDate.Image = ((System.Drawing.Image)(resources.GetObject("BtnFilterByDate.Image")));
            this.BtnFilterByDate.ImageActive = null;
            this.BtnFilterByDate.Location = new System.Drawing.Point(460, 34);
            this.BtnFilterByDate.Name = "BtnFilterByDate";
            this.BtnFilterByDate.Size = new System.Drawing.Size(24, 24);
            this.BtnFilterByDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnFilterByDate.TabIndex = 180;
            this.BtnFilterByDate.TabStop = false;
            this.BtnFilterByDate.Zoom = 10;
            this.BtnFilterByDate.Click += new System.EventHandler(this.BtnFilterByDate_Click);
            // 
            // cmbSort
            // 
            this.cmbSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSort.BackColor = System.Drawing.Color.White;
            this.cmbSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(45)))), ((int)(((byte)(143)))));
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Items.AddRange(new object[] {
            "All",
            "Cash",
            "Cheque"});
            this.cmbSort.Location = new System.Drawing.Point(86, 34);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(113, 24);
            this.cmbSort.TabIndex = 25;
            this.cmbSort.Text = "All";
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);
            // 
            // BtnClearFilters
            // 
            this.BtnClearFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClearFilters.BackColor = System.Drawing.Color.Transparent;
            this.BtnClearFilters.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClearFilters.Image = ((System.Drawing.Image)(resources.GetObject("BtnClearFilters.Image")));
            this.BtnClearFilters.ImageActive = null;
            this.BtnClearFilters.Location = new System.Drawing.Point(430, 34);
            this.BtnClearFilters.Name = "BtnClearFilters";
            this.BtnClearFilters.Size = new System.Drawing.Size(24, 24);
            this.BtnClearFilters.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnClearFilters.TabIndex = 179;
            this.BtnClearFilters.TabStop = false;
            this.BtnClearFilters.Zoom = 10;
            this.BtnClearFilters.Click += new System.EventHandler(this.BtnClearFilters_Click);
            // 
            // cmbShown
            // 
            this.cmbShown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbShown.BackColor = System.Drawing.Color.White;
            this.cmbShown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(45)))), ((int)(((byte)(143)))));
            this.cmbShown.FormattingEnabled = true;
            this.cmbShown.Items.AddRange(new object[] {
            "25",
            "50",
            "75",
            "100",
            "All"});
            this.cmbShown.Location = new System.Drawing.Point(15, 34);
            this.cmbShown.Name = "cmbShown";
            this.cmbShown.Size = new System.Drawing.Size(65, 24);
            this.cmbShown.TabIndex = 23;
            this.cmbShown.Text = "All";
            this.cmbShown.SelectedIndexChanged += new System.EventHandler(this.cmbShown_SelectedIndexChanged);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCustomer.BackColor = System.Drawing.Color.White;
            this.cmbCustomer.DropDownHeight = 80;
            this.cmbCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(45)))), ((int)(((byte)(143)))));
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.IntegralHeight = false;
            this.cmbCustomer.ItemHeight = 16;
            this.cmbCustomer.Location = new System.Drawing.Point(205, 34);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(219, 24);
            this.cmbCustomer.TabIndex = 50;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label12.Location = new System.Drawing.Point(205, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 20);
            this.label12.TabIndex = 51;
            this.label12.Text = "Customer Name";
            // 
            // PnlFilter
            // 
            this.PnlFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.PnlFilter.Controls.Add(this.bunifuDatepicker1);
            this.PnlFilter.Controls.Add(this.BtnFilter);
            this.PnlFilter.Controls.Add(this.panel2);
            this.PnlFilter.Controls.Add(this.bunifuDatepicker2);
            this.PnlFilter.Controls.Add(this.bunifuCustomLabel2);
            this.PnlFilter.Controls.Add(this.bunifuCustomLabel1);
            this.PnlFilter.Controls.Add(this.label11);
            this.PnlFilter.Location = new System.Drawing.Point(963, 98);
            this.PnlFilter.Name = "PnlFilter";
            this.PnlFilter.Size = new System.Drawing.Size(232, 207);
            this.PnlFilter.TabIndex = 192;
            this.PnlFilter.Visible = false;
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuDatepicker1.BorderRadius = 5;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bunifuDatepicker1.FormatCustom = "dd-MMM-yyyy";
            this.bunifuDatepicker1.Location = new System.Drawing.Point(28, 57);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(72, 69);
            this.bunifuDatepicker1.TabIndex = 183;
            this.bunifuDatepicker1.Value = new System.DateTime(2020, 3, 7, 9, 21, 47, 182);
            this.bunifuDatepicker1.onValueChanged += new System.EventHandler(this.bunifuDatepicker1_onValueChanged);
            // 
            // BtnFilter
            // 
            this.BtnFilter.ActiveBorderThickness = 1;
            this.BtnFilter.ActiveCornerRadius = 20;
            this.BtnFilter.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnFilter.ActiveForecolor = System.Drawing.Color.White;
            this.BtnFilter.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.BtnFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnFilter.BackgroundImage")));
            this.BtnFilter.ButtonText = "Filter";
            this.BtnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFilter.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.BtnFilter.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnFilter.IdleBorderThickness = 1;
            this.BtnFilter.IdleCornerRadius = 20;
            this.BtnFilter.IdleFillColor = System.Drawing.Color.White;
            this.BtnFilter.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BtnFilter.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnFilter.Location = new System.Drawing.Point(52, 161);
            this.BtnFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(130, 40);
            this.BtnFilter.TabIndex = 182;
            this.BtnFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel2.Location = new System.Drawing.Point(111, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(114, 1);
            this.panel2.TabIndex = 49;
            // 
            // bunifuDatepicker2
            // 
            this.bunifuDatepicker2.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuDatepicker2.BorderRadius = 5;
            this.bunifuDatepicker2.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bunifuDatepicker2.FormatCustom = "dd-MMM-yyyy";
            this.bunifuDatepicker2.Location = new System.Drawing.Point(133, 57);
            this.bunifuDatepicker2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuDatepicker2.Name = "bunifuDatepicker2";
            this.bunifuDatepicker2.Size = new System.Drawing.Size(72, 69);
            this.bunifuDatepicker2.TabIndex = 48;
            this.bunifuDatepicker2.Value = new System.DateTime(2020, 3, 7, 9, 21, 47, 182);
            this.bunifuDatepicker2.onValueChanged += new System.EventHandler(this.bunifuDatepicker2_onValueChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(113, 130);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(114, 22);
            this.bunifuCustomLabel2.TabIndex = 46;
            this.bunifuCustomLabel2.Text = "09-Mar-2020";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(8, 130);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(115, 22);
            this.bunifuCustomLabel1.TabIndex = 47;
            this.bunifuCustomLabel1.Tag = "";
            this.bunifuCustomLabel1.Text = "09-Mar-2020";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label11.Location = new System.Drawing.Point(7, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "Filter by date";
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
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn10,
            this.Column12,
            this.Column13,
            this.dataGridViewTextBoxColumn14,
            this.DeleteCancel});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(29)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.Location = new System.Drawing.Point(3, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(231)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1189, 641);
            this.dataGridView1.TabIndex = 193;
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
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 6;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "INVOICE";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 103;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "CUSTOMER";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.HeaderText = "ADDRESS";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 110;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn11.HeaderText = "PAYMENT";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 116;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn12.HeaderText = "DAYS";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            this.dataGridViewTextBoxColumn12.Width = 81;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn13.HeaderText = "BILL ADDRESS";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Visible = false;
            this.dataGridViewTextBoxColumn13.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.HeaderText = "VAT";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            this.dataGridViewTextBoxColumn8.Width = 71;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn9.HeaderText = "VATABLE";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 112;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.HeaderText = "DISCOUNT";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 121;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.HeaderText = "TOTAL";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            this.dataGridViewTextBoxColumn10.Width = 91;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column12.HeaderText = "EXECUTE";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 110;
            // 
            // Column13
            // 
            this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column13.HeaderText = "REASON";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn14.HeaderText = "DATE";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 79;
            // 
            // DeleteCancel
            // 
            this.DeleteCancel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DeleteCancel.HeaderText = "";
            this.DeleteCancel.Image = ((System.Drawing.Image)(resources.GetObject("DeleteCancel.Image")));
            this.DeleteCancel.MinimumWidth = 6;
            this.DeleteCancel.Name = "DeleteCancel";
            this.DeleteCancel.ReadOnly = true;
            this.DeleteCancel.Width = 6;
            // 
            // BtnInvoices
            // 
            this.BtnInvoices.AutoSize = true;
            this.BtnInvoices.Font = new System.Drawing.Font("Roboto Light", 15F);
            this.BtnInvoices.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnInvoices.Location = new System.Drawing.Point(9, 14);
            this.BtnInvoices.Name = "BtnInvoices";
            this.BtnInvoices.Size = new System.Drawing.Size(137, 30);
            this.BtnInvoices.TabIndex = 194;
            this.BtnInvoices.Text = "Invoices ＞";
            this.BtnInvoices.Click += new System.EventHandler(this.BtnInvoices_Click);
            // 
            // AdminCancelInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.BtnInvoices);
            this.Controls.Add(this.PnlFilter);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BtnOverdueInvoices);
            this.Controls.Add(this.BtnPaidInvoices);
            this.Controls.Add(this.BtnCancelledInvoices);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.BtnCancelInvoices);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminCancelInvoice";
            this.Size = new System.Drawing.Size(1195, 764);
            this.Load += new System.EventHandler(this.AdminCancelInvoice_Load);
            this.Click += new System.EventHandler(this.AdminCancelInvoice_Click);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnOverdueInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPaidInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelledInvoices)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFilterByDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClearFilters)).EndInit();
            this.PnlFilter.ResumeLayout(false);
            this.PnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label BtnCancelInvoices;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtSearch;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblDataRowCount;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuImageButton BtnOverdueInvoices;
        private Bunifu.Framework.UI.BunifuImageButton BtnPaidInvoices;
        private Bunifu.Framework.UI.BunifuImageButton BtnCancelledInvoices;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuImageButton BtnFilterByDate;
        private System.Windows.Forms.ComboBox cmbSort;
        private Bunifu.Framework.UI.BunifuImageButton BtnClearFilters;
        private System.Windows.Forms.ComboBox cmbShown;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel PnlFilter;
        public Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        public Bunifu.Framework.UI.BunifuThinButton2 BtnFilter;
        private System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker2;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label BtnInvoices;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewImageColumn DeleteCancel;
    }
}
