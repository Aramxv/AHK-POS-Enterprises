namespace AHKPOSENKTHESIS
{
    partial class AdminStockAdjustDatePicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminStockAdjustDatePicker));
            this.CbxAdjustBy = new System.Windows.Forms.ComboBox();
            this.bunifuDatepicker2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BtnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLoadHistory = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // CbxAdjustBy
            // 
            this.CbxAdjustBy.BackColor = System.Drawing.Color.White;
            this.CbxAdjustBy.Font = new System.Drawing.Font("Poppins", 10F);
            this.CbxAdjustBy.ForeColor = System.Drawing.Color.Black;
            this.CbxAdjustBy.FormattingEnabled = true;
            this.CbxAdjustBy.Items.AddRange(new object[] {
            "All"});
            this.CbxAdjustBy.Location = new System.Drawing.Point(162, 29);
            this.CbxAdjustBy.Name = "CbxAdjustBy";
            this.CbxAdjustBy.Size = new System.Drawing.Size(180, 38);
            this.CbxAdjustBy.TabIndex = 180;
            this.CbxAdjustBy.Text = "All";
            // 
            // bunifuDatepicker2
            // 
            this.bunifuDatepicker2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.bunifuDatepicker2.BorderRadius = 0;
            this.bunifuDatepicker2.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker2.FormatCustom = null;
            this.bunifuDatepicker2.Location = new System.Drawing.Point(278, 96);
            this.bunifuDatepicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDatepicker2.Name = "bunifuDatepicker2";
            this.bunifuDatepicker2.Size = new System.Drawing.Size(65, 63);
            this.bunifuDatepicker2.TabIndex = 175;
            this.bunifuDatepicker2.Value = new System.DateTime(2020, 4, 29, 11, 28, 21, 64);
            this.bunifuDatepicker2.onValueChanged += new System.EventHandler(this.bunifuDatepicker2_onValueChanged);
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(162, 96);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(65, 63);
            this.bunifuDatepicker1.TabIndex = 173;
            this.bunifuDatepicker1.Value = new System.DateTime(2020, 4, 29, 11, 28, 21, 64);
            this.bunifuDatepicker1.onValueChanged += new System.EventHandler(this.bunifuDatepicker1_onValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Poppins", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.label3.Location = new System.Drawing.Point(19, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 30);
            this.label3.TabIndex = 183;
            this.label3.Text = "Stock-in by";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Poppins", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.label4.Location = new System.Drawing.Point(19, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 30);
            this.label4.TabIndex = 182;
            this.label4.Text = "Specified Date";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Poppins", 10F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(254, 171);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(121, 30);
            this.bunifuCustomLabel2.TabIndex = 185;
            this.bunifuCustomLabel2.Tag = "";
            this.bunifuCustomLabel2.Text = "09-Mar-2020";
            this.bunifuCustomLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Poppins", 10F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(127, 171);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(121, 30);
            this.bunifuCustomLabel1.TabIndex = 184;
            this.bunifuCustomLabel1.Tag = "";
            this.bunifuCustomLabel1.Text = "09-Mar-2020";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.BtnCancel.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnCancel.IdleForecolor = System.Drawing.Color.White;
            this.BtnCancel.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnCancel.Location = new System.Drawing.Point(204, 229);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(145, 60);
            this.BtnCancel.TabIndex = 188;
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(-97, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 1);
            this.panel1.TabIndex = 187;
            // 
            // BtnLoadHistory
            // 
            this.BtnLoadHistory.ActiveBorderThickness = 1;
            this.BtnLoadHistory.ActiveCornerRadius = 1;
            this.BtnLoadHistory.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnLoadHistory.ActiveForecolor = System.Drawing.Color.White;
            this.BtnLoadHistory.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnLoadHistory.BackColor = System.Drawing.Color.White;
            this.BtnLoadHistory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLoadHistory.BackgroundImage")));
            this.BtnLoadHistory.ButtonText = "Print Now";
            this.BtnLoadHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLoadHistory.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold);
            this.BtnLoadHistory.ForeColor = System.Drawing.Color.White;
            this.BtnLoadHistory.IdleBorderThickness = 1;
            this.BtnLoadHistory.IdleCornerRadius = 1;
            this.BtnLoadHistory.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnLoadHistory.IdleForecolor = System.Drawing.Color.White;
            this.BtnLoadHistory.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(99)))), ((int)(((byte)(246)))));
            this.BtnLoadHistory.Location = new System.Drawing.Point(51, 229);
            this.BtnLoadHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnLoadHistory.Name = "BtnLoadHistory";
            this.BtnLoadHistory.Size = new System.Drawing.Size(145, 60);
            this.BtnLoadHistory.TabIndex = 186;
            this.BtnLoadHistory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnLoadHistory.Click += new System.EventHandler(this.BtnLoadHistory_Click);
            // 
            // AdminStockAdjustDatePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 311);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnLoadHistory);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbxAdjustBy);
            this.Controls.Add(this.bunifuDatepicker2);
            this.Controls.Add(this.bunifuDatepicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminStockAdjustDatePicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStockAdjustDatePicker";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmStockAdjustDatePicker_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox CbxAdjustBy;
        public Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker2;
        public Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        public Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        public Bunifu.Framework.UI.BunifuThinButton2 BtnCancel;
        private System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuThinButton2 BtnLoadHistory;
    }
}