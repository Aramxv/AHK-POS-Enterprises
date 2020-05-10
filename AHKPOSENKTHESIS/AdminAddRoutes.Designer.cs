namespace AHKPOSENKTHESIS
{
    partial class AdminAddRoutes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAddRoutes));
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtRoute = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lbl1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.WarningIndicator = new System.Windows.Forms.PictureBox();
            this.BtnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.WarningIndicator)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 30);
            this.label1.TabIndex = 55;
            this.label1.Text = "Route";
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(543, 159);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 22);
            this.lblID.TabIndex = 54;
            this.lblID.Visible = false;
            // 
            // txtRoute
            // 
            this.txtRoute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRoute.Depth = 0;
            this.txtRoute.Hint = "Enter Route here";
            this.txtRoute.Location = new System.Drawing.Point(30, 117);
            this.txtRoute.MaxLength = 32767;
            this.txtRoute.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRoute.Name = "txtRoute";
            this.txtRoute.PasswordChar = '\0';
            this.txtRoute.SelectedText = "";
            this.txtRoute.SelectionLength = 0;
            this.txtRoute.SelectionStart = 0;
            this.txtRoute.Size = new System.Drawing.Size(433, 28);
            this.txtRoute.TabIndex = 50;
            this.txtRoute.TabStop = false;
            this.txtRoute.UseSystemPasswordChar = false;
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Poppins", 15F);
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.lbl1.Location = new System.Drawing.Point(126, 21);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(290, 43);
            this.lbl1.TabIndex = 24;
            this.lbl1.Text = "New Route";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // WarningIndicator
            // 
            this.WarningIndicator.Image = ((System.Drawing.Image)(resources.GetObject("WarningIndicator.Image")));
            this.WarningIndicator.Location = new System.Drawing.Point(469, 109);
            this.WarningIndicator.Name = "WarningIndicator";
            this.WarningIndicator.Size = new System.Drawing.Size(36, 36);
            this.WarningIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.WarningIndicator.TabIndex = 117;
            this.WarningIndicator.TabStop = false;
            this.toolTip1.SetToolTip(this.WarningIndicator, "Blank Fields Indicator");
            this.WarningIndicator.Visible = false;
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
            this.BtnUpdate.Location = new System.Drawing.Point(116, 181);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(145, 60);
            this.BtnUpdate.TabIndex = 119;
            this.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.BtnSave.Location = new System.Drawing.Point(-37, 181);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(145, 60);
            this.BtnSave.TabIndex = 118;
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.BtnCancel.Location = new System.Drawing.Point(269, 181);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(145, 60);
            this.BtnCancel.TabIndex = 117;
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(-26, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 1);
            this.panel1.TabIndex = 123;
            // 
            // AdminAddRoutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(530, 259);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WarningIndicator);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtRoute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminAddRoutes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmRoute_Load);
            this.Click += new System.EventHandler(this.FrmRoute_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmRoute_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.WarningIndicator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblID;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtRoute;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox WarningIndicator;
        public Bunifu.Framework.UI.BunifuThinButton2 BtnUpdate;
        public Bunifu.Framework.UI.BunifuThinButton2 BtnSave;
        public Bunifu.Framework.UI.BunifuThinButton2 BtnCancel;
        public System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}