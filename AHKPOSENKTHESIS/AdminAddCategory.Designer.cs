namespace AHKPOSENKTHESIS
{
    partial class AdminAddCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAddCategory));
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtCategory = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BtnUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.WarningIndicator = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.WarningIndicator)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Poppins", 15F);
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(54)))), ((int)(((byte)(75)))));
            this.lbl1.Location = new System.Drawing.Point(85, 19);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(340, 41);
            this.lbl1.TabIndex = 20;
            this.lbl1.Text = "New Category";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(522, 209);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 22);
            this.lblID.TabIndex = 14;
            this.lblID.Visible = false;
            // 
            // txtCategory
            // 
            this.txtCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategory.Depth = 0;
            this.txtCategory.Hint = "Enter the Category name here";
            this.txtCategory.Location = new System.Drawing.Point(43, 109);
            this.txtCategory.MaxLength = 32767;
            this.txtCategory.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.PasswordChar = '\0';
            this.txtCategory.SelectedText = "";
            this.txtCategory.SelectionLength = 0;
            this.txtCategory.SelectionStart = 0;
            this.txtCategory.Size = new System.Drawing.Size(398, 28);
            this.txtCategory.TabIndex = 0;
            this.txtCategory.TabStop = false;
            this.toolTip1.SetToolTip(this.txtCategory, "Type the description of the Category in the textbox.");
            this.txtCategory.UseSystemPasswordChar = false;
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
            this.BtnUpdate.Location = new System.Drawing.Point(106, 167);
            this.BtnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(145, 60);
            this.BtnUpdate.TabIndex = 114;
            this.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.BtnUpdate, "Hit to process the making of your Customer\'s Invoice.");
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
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
            this.BtnSave.Location = new System.Drawing.Point(-47, 167);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(145, 60);
            this.BtnSave.TabIndex = 113;
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.BtnSave, "Hit to process the making of your Customer\'s Invoice.");
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
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
            this.BtnCancel.Location = new System.Drawing.Point(259, 167);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(145, 60);
            this.BtnCancel.TabIndex = 112;
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.BtnCancel, "Hit to process the making of your Customer\'s Invoice.");
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 30);
            this.label2.TabIndex = 115;
            this.label2.Text = "Category Description";
            this.toolTip1.SetToolTip(this.label2, "Product\'s Name");
            // 
            // WarningIndicator
            // 
            this.WarningIndicator.Image = ((System.Drawing.Image)(resources.GetObject("WarningIndicator.Image")));
            this.WarningIndicator.Location = new System.Drawing.Point(447, 101);
            this.WarningIndicator.Name = "WarningIndicator";
            this.WarningIndicator.Size = new System.Drawing.Size(36, 36);
            this.WarningIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.WarningIndicator.TabIndex = 117;
            this.WarningIndicator.TabStop = false;
            this.toolTip1.SetToolTip(this.WarningIndicator, "Blank Fields Indicator");
            this.WarningIndicator.Visible = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(-36, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 1);
            this.panel1.TabIndex = 174;
            // 
            // AdminAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(510, 248);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WarningIndicator);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminAddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Click += new System.EventHandler(this.FrmCategory_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCategory_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.WarningIndicator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Label lbl1;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtCategory;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.Framework.UI.BunifuThinButton2 BtnUpdate;
        public Bunifu.Framework.UI.BunifuThinButton2 BtnSave;
        public Bunifu.Framework.UI.BunifuThinButton2 BtnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox WarningIndicator;
        private System.Windows.Forms.Panel panel1;
    }
}