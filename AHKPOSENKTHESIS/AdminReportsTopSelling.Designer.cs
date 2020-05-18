namespace AHKPOSENKTHESIS
{
    partial class AdminReportsTopSelling
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminReportsTopSelling));
            this.BtnCustomers = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblGRSI = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.lblDataRowCount = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TopSellingChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnPrintRecords = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnShowRecords = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnDropDown = new Bunifu.Framework.UI.BunifuImageButton();
            this.cmbTerms = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuDatepicker2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.BtnCreate = new MaterialSkin.Controls.MaterialLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalQty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopSellingChart)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPrintRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDropDown)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCustomers
            // 
            this.BtnCustomers.AutoSize = true;
            this.BtnCustomers.Font = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            this.BtnCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(14)))), ((int)(((byte)(99)))));
            this.BtnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCustomers.Location = new System.Drawing.Point(9, 34);
            this.BtnCustomers.Name = "BtnCustomers";
            this.BtnCustomers.Size = new System.Drawing.Size(348, 44);
            this.BtnCustomers.TabIndex = 218;
            this.BtnCustomers.Text = "Your Top Selling Products ";
            this.BtnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(219)))), ((int)(((byte)(223)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.QTY,
            this.Column17});
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(29)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(3, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(119)))), ((int)(((byte)(231)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1189, 318);
            this.dataGridView1.TabIndex = 219;
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
            this.Column1.Width = 43;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "PRODUCT CODE";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "DESCRIPTION ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // QTY
            // 
            this.QTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle26.Format = "N2";
            dataGridViewCellStyle26.NullValue = null;
            this.QTY.DefaultCellStyle = dataGridViewCellStyle26;
            this.QTY.HeaderText = "QTY";
            this.QTY.MinimumWidth = 6;
            this.QTY.Name = "QTY";
            this.QTY.ReadOnly = true;
            this.QTY.Width = 65;
            // 
            // Column17
            // 
            this.Column17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle27.Format = "C2";
            dataGridViewCellStyle27.NullValue = null;
            this.Column17.DefaultCellStyle = dataGridViewCellStyle27;
            this.Column17.HeaderText = "TOTAL SALES";
            this.Column17.MinimumWidth = 6;
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            this.Column17.Width = 131;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.panel9.Controls.Add(this.lblTotalQty);
            this.panel9.Controls.Add(this.lblGRSI);
            this.panel9.Controls.Add(this.lblTotalSales);
            this.panel9.Controls.Add(this.lblDataRowCount);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 700);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1195, 64);
            this.panel9.TabIndex = 220;
            // 
            // lblGRSI
            // 
            this.lblGRSI.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblGRSI.AutoSize = true;
            this.lblGRSI.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Bold);
            this.lblGRSI.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGRSI.Location = new System.Drawing.Point(14, 23);
            this.lblGRSI.Name = "lblGRSI";
            this.lblGRSI.Size = new System.Drawing.Size(266, 17);
            this.lblGRSI.TabIndex = 113;
            this.lblGRSI.Text = "(GRSI)Generated Report Summary Index";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblTotalSales.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTotalSales.Location = new System.Drawing.Point(646, 20);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(138, 19);
            this.lblTotalSales.TabIndex = 109;
            this.lblTotalSales.Text = "₱ 0,000 Total Sales";
            this.lblTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDataRowCount
            // 
            this.lblDataRowCount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDataRowCount.AutoSize = true;
            this.lblDataRowCount.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblDataRowCount.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDataRowCount.Location = new System.Drawing.Point(298, 20);
            this.lblDataRowCount.Name = "lblDataRowCount";
            this.lblDataRowCount.Size = new System.Drawing.Size(111, 19);
            this.lblDataRowCount.TabIndex = 109;
            this.lblDataRowCount.Text = "Top 0 Products";
            this.lblDataRowCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this.dataGridView1;
            // 
            // TopSellingChart
            // 
            this.TopSellingChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopSellingChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(219)))), ((int)(((byte)(223)))));
            this.TopSellingChart.BorderlineColor = System.Drawing.Color.Transparent;
            this.TopSellingChart.BorderlineWidth = 0;
            this.TopSellingChart.BorderSkin.BorderWidth = 0;
            chartArea5.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea5.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.Position;
            chartArea5.Area3DStyle.Inclination = 20;
            chartArea5.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea5.BackColor = System.Drawing.Color.White;
            chartArea5.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea5.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea5.BorderColor = System.Drawing.Color.White;
            chartArea5.BorderWidth = 0;
            chartArea5.Name = "ChartArea1";
            this.TopSellingChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.TopSellingChart.Legends.Add(legend5);
            this.TopSellingChart.Location = new System.Drawing.Point(1, 423);
            this.TopSellingChart.Margin = new System.Windows.Forms.Padding(1);
            this.TopSellingChart.Name = "TopSellingChart";
            this.TopSellingChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series5.CustomProperties = "DrawingStyle=LightToDark";
            series5.Font = new System.Drawing.Font("Roboto", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.IsValueShownAsLabel = true;
            series5.IsVisibleInLegend = false;
            series5.LabelAngle = 10;
            series5.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            series5.YValuesPerPoint = 10;
            this.TopSellingChart.Series.Add(series5);
            this.TopSellingChart.Size = new System.Drawing.Size(1192, 273);
            this.TopSellingChart.TabIndex = 221;
            this.TopSellingChart.Text = "chart1";
            title5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title5.Name = "Title1";
            title5.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.TopSellingChart.Titles.Add(title5);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.TopSellingChart;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.BtnPrintRecords);
            this.panel1.Controls.Add(this.BtnShowRecords);
            this.panel1.Controls.Add(this.BtnDropDown);
            this.panel1.Controls.Add(this.cmbTerms);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bunifuDatepicker2);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.bunifuDatepicker1);
            this.panel1.Controls.Add(this.BtnCreate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(546, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 50);
            this.panel1.TabIndex = 222;
            // 
            // BtnPrintRecords
            // 
            this.BtnPrintRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrintRecords.BackColor = System.Drawing.Color.Transparent;
            this.BtnPrintRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrintRecords.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrintRecords.Image")));
            this.BtnPrintRecords.ImageActive = null;
            this.BtnPrintRecords.Location = new System.Drawing.Point(568, 5);
            this.BtnPrintRecords.Name = "BtnPrintRecords";
            this.BtnPrintRecords.Size = new System.Drawing.Size(48, 48);
            this.BtnPrintRecords.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnPrintRecords.TabIndex = 191;
            this.BtnPrintRecords.TabStop = false;
            this.toolTip1.SetToolTip(this.BtnPrintRecords, "Print Preview");
            this.BtnPrintRecords.Zoom = 10;
            this.BtnPrintRecords.Click += new System.EventHandler(this.BtnPrintRecords_Click);
            // 
            // BtnShowRecords
            // 
            this.BtnShowRecords.ActiveBorderThickness = 1;
            this.BtnShowRecords.ActiveCornerRadius = 1;
            this.BtnShowRecords.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnShowRecords.ActiveForecolor = System.Drawing.Color.White;
            this.BtnShowRecords.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnShowRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnShowRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.BtnShowRecords.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnShowRecords.BackgroundImage")));
            this.BtnShowRecords.ButtonText = "Show Records";
            this.BtnShowRecords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnShowRecords.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.BtnShowRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnShowRecords.IdleBorderThickness = 1;
            this.BtnShowRecords.IdleCornerRadius = 1;
            this.BtnShowRecords.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnShowRecords.IdleForecolor = System.Drawing.Color.White;
            this.BtnShowRecords.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnShowRecords.Location = new System.Drawing.Point(25, 185);
            this.BtnShowRecords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnShowRecords.Name = "BtnShowRecords";
            this.BtnShowRecords.Size = new System.Drawing.Size(591, 60);
            this.BtnShowRecords.TabIndex = 190;
            this.BtnShowRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnShowRecords.Click += new System.EventHandler(this.BtnShowRecords_Click);
            // 
            // BtnDropDown
            // 
            this.BtnDropDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDropDown.BackColor = System.Drawing.Color.Transparent;
            this.BtnDropDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDropDown.Image = ((System.Drawing.Image)(resources.GetObject("BtnDropDown.Image")));
            this.BtnDropDown.ImageActive = null;
            this.BtnDropDown.Location = new System.Drawing.Point(304, 5);
            this.BtnDropDown.Name = "BtnDropDown";
            this.BtnDropDown.Size = new System.Drawing.Size(36, 36);
            this.BtnDropDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnDropDown.TabIndex = 189;
            this.BtnDropDown.TabStop = false;
            this.toolTip1.SetToolTip(this.BtnDropDown, "Click Here to make a first step on creating a report.");
            this.BtnDropDown.Zoom = 10;
            this.BtnDropDown.Click += new System.EventHandler(this.BtnDropDown_Click);
            // 
            // cmbTerms
            // 
            this.cmbTerms.BackColor = System.Drawing.Color.White;
            this.cmbTerms.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTerms.ForeColor = System.Drawing.Color.Black;
            this.cmbTerms.FormattingEnabled = true;
            this.cmbTerms.Items.AddRange(new object[] {
            "Quantity",
            "Amount"});
            this.cmbTerms.Location = new System.Drawing.Point(402, 121);
            this.cmbTerms.Name = "cmbTerms";
            this.cmbTerms.Size = new System.Drawing.Size(154, 33);
            this.cmbTerms.TabIndex = 188;
            this.cmbTerms.Text = "Quantity";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(128, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 1);
            this.panel2.TabIndex = 187;
            // 
            // bunifuDatepicker2
            // 
            this.bunifuDatepicker2.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuDatepicker2.BorderRadius = 5;
            this.bunifuDatepicker2.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bunifuDatepicker2.FormatCustom = "dd-MMM-yyyy";
            this.bunifuDatepicker2.Location = new System.Drawing.Point(269, 95);
            this.bunifuDatepicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDatepicker2.Name = "bunifuDatepicker2";
            this.bunifuDatepicker2.Size = new System.Drawing.Size(95, 50);
            this.bunifuDatepicker2.TabIndex = 186;
            this.bunifuDatepicker2.Value = new System.DateTime(2020, 3, 7, 9, 21, 47, 182);
            this.bunifuDatepicker2.onValueChanged += new System.EventHandler(this.bunifuDatepicker2_onValueChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(272, 149);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(90, 17);
            this.bunifuCustomLabel2.TabIndex = 184;
            this.bunifuCustomLabel2.Text = "09-Mar-2020";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(152, 149);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(90, 17);
            this.bunifuCustomLabel1.TabIndex = 185;
            this.bunifuCustomLabel1.Tag = "";
            this.bunifuCustomLabel1.Text = "09-Mar-2020";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuDatepicker1.BorderRadius = 5;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bunifuDatepicker1.FormatCustom = "dd-MMM-yyyy";
            this.bunifuDatepicker1.Location = new System.Drawing.Point(149, 95);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(95, 50);
            this.bunifuDatepicker1.TabIndex = 183;
            this.bunifuDatepicker1.Value = new System.DateTime(2020, 3, 7, 9, 21, 47, 182);
            this.bunifuDatepicker1.onValueChanged += new System.EventHandler(this.bunifuDatepicker1_onValueChanged);
            // 
            // BtnCreate
            // 
            this.BtnCreate.AutoSize = true;
            this.BtnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCreate.Depth = 0;
            this.BtnCreate.Font = new System.Drawing.Font("Roboto", 11F);
            this.BtnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnCreate.Location = new System.Drawing.Point(7, 11);
            this.BtnCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(291, 23);
            this.BtnCreate.TabIndex = 179;
            this.BtnCreate.Text = "Create a Report for your business";
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(398, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 180;
            this.label6.Text = "Filter By";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(16, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 181;
            this.label7.Text = "Filter By Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.label8.Location = new System.Drawing.Point(16, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 182;
            this.label8.Text = "Specified Date ";
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTotalQty.AutoSize = true;
            this.lblTotalQty.Font = new System.Drawing.Font("Roboto", 9F);
            this.lblTotalQty.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTotalQty.Location = new System.Drawing.Point(455, 20);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(142, 19);
            this.lblTotalQty.TabIndex = 114;
            this.lblTotalQty.Text = "0,000 Total Quantity";
            this.lblTotalQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AdminReportsTopSelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopSellingChart);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnCustomers);
            this.Name = "AdminReportsTopSelling";
            this.Size = new System.Drawing.Size(1195, 764);
            this.Load += new System.EventHandler(this.AdminReportsTopSelling_Load);
            this.Click += new System.EventHandler(this.AdminReportsTopSelling_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopSellingChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPrintRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDropDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BtnCustomers;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lblGRSI;
        public System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblDataRowCount;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataVisualization.Charting.Chart TopSellingChart;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton BtnPrintRecords;
        public Bunifu.Framework.UI.BunifuThinButton2 BtnShowRecords;
        private Bunifu.Framework.UI.BunifuImageButton BtnDropDown;
        public System.Windows.Forms.ComboBox cmbTerms;
        private System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        public Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private MaterialSkin.Controls.MaterialLabel BtnCreate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label lblTotalQty;
    }
}
