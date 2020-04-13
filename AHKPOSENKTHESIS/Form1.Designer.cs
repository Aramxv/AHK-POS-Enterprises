namespace AHKPOSENKTHESIS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsern = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnDashboard = new MaterialSkin.Controls.MaterialFlatButton();
            this.BtnStockIn = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnUserSettings = new System.Windows.Forms.Button();
            this.BtnSysSettings = new System.Windows.Forms.Button();
            this.BtnCustomer = new System.Windows.Forms.Button();
            this.BtnRecords = new System.Windows.Forms.Button();
            this.BtnCategory = new System.Windows.Forms.Button();
            this.BtnProducts = new System.Windows.Forms.Button();
            this.BtnPOS = new System.Windows.Forms.Button();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Container = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.lblUsern);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 865);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 25);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // lblUsern
            // 
            this.lblUsern.AutoSize = true;
            this.lblUsern.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsern.ForeColor = System.Drawing.Color.White;
            this.lblUsern.Location = new System.Drawing.Point(146, 4);
            this.lblUsern.Name = "lblUsern";
            this.lblUsern.Size = new System.Drawing.Size(70, 18);
            this.lblUsern.TabIndex = 15;
            this.lblUsern.Text = "Username";
            this.lblUsern.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 17);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "System Ready     |";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(555, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "AHK ENTERPRISES Point of Sales and Inventory Management";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Controls.Add(this.BtnDashboard);
            this.panel2.Controls.Add(this.BtnStockIn);
            this.panel2.Controls.Add(this.BtnLogout);
            this.panel2.Controls.Add(this.BtnUserSettings);
            this.panel2.Controls.Add(this.BtnSysSettings);
            this.panel2.Controls.Add(this.BtnCustomer);
            this.panel2.Controls.Add(this.BtnRecords);
            this.panel2.Controls.Add(this.BtnCategory);
            this.panel2.Controls.Add(this.BtnProducts);
            this.panel2.Controls.Add(this.BtnPOS);
            this.panel2.Controls.Add(this.lblAccount);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 802);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.AutoSize = true;
            this.BtnDashboard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnDashboard.Depth = 0;
            this.BtnDashboard.Icon = null;
            this.BtnDashboard.Location = new System.Drawing.Point(4, 185);
            this.BtnDashboard.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnDashboard.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Primary = false;
            this.BtnDashboard.Size = new System.Drawing.Size(123, 36);
            this.BtnDashboard.TabIndex = 12;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashboard.UseVisualStyleBackColor = true;
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click_1);
            // 
            // BtnStockIn
            // 
            this.BtnStockIn.FlatAppearance.BorderSize = 0;
            this.BtnStockIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.BtnStockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStockIn.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStockIn.ForeColor = System.Drawing.Color.White;
            this.BtnStockIn.Image = ((System.Drawing.Image)(resources.GetObject("BtnStockIn.Image")));
            this.BtnStockIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnStockIn.Location = new System.Drawing.Point(0, 347);
            this.BtnStockIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnStockIn.Name = "BtnStockIn";
            this.BtnStockIn.Size = new System.Drawing.Size(342, 42);
            this.BtnStockIn.TabIndex = 11;
            this.BtnStockIn.Text = "  Stock In";
            this.BtnStockIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnStockIn.UseVisualStyleBackColor = true;
            this.BtnStockIn.Click += new System.EventHandler(this.BtnStockIn_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.FlatAppearance.BorderSize = 0;
            this.BtnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.ForeColor = System.Drawing.Color.White;
            this.BtnLogout.Image = ((System.Drawing.Image)(resources.GetObject("BtnLogout.Image")));
            this.BtnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLogout.Location = new System.Drawing.Point(3, 755);
            this.BtnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(342, 42);
            this.BtnLogout.TabIndex = 10;
            this.BtnLogout.Text = "  Logout";
            this.BtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnUserSettings
            // 
            this.BtnUserSettings.FlatAppearance.BorderSize = 0;
            this.BtnUserSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.BtnUserSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUserSettings.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUserSettings.ForeColor = System.Drawing.Color.White;
            this.BtnUserSettings.Image = ((System.Drawing.Image)(resources.GetObject("BtnUserSettings.Image")));
            this.BtnUserSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUserSettings.Location = new System.Drawing.Point(0, 587);
            this.BtnUserSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnUserSettings.Name = "BtnUserSettings";
            this.BtnUserSettings.Size = new System.Drawing.Size(342, 42);
            this.BtnUserSettings.TabIndex = 9;
            this.BtnUserSettings.Text = "  Users Settings";
            this.BtnUserSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUserSettings.UseVisualStyleBackColor = true;
            this.BtnUserSettings.Click += new System.EventHandler(this.BtnUserSettings_Click);
            // 
            // BtnSysSettings
            // 
            this.BtnSysSettings.FlatAppearance.BorderSize = 0;
            this.BtnSysSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.BtnSysSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSysSettings.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSysSettings.ForeColor = System.Drawing.Color.White;
            this.BtnSysSettings.Image = ((System.Drawing.Image)(resources.GetObject("BtnSysSettings.Image")));
            this.BtnSysSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSysSettings.Location = new System.Drawing.Point(0, 539);
            this.BtnSysSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSysSettings.Name = "BtnSysSettings";
            this.BtnSysSettings.Size = new System.Drawing.Size(342, 42);
            this.BtnSysSettings.TabIndex = 8;
            this.BtnSysSettings.Text = "  System Settings";
            this.BtnSysSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSysSettings.UseVisualStyleBackColor = true;
            // 
            // BtnCustomer
            // 
            this.BtnCustomer.FlatAppearance.BorderSize = 0;
            this.BtnCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.BtnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCustomer.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomer.ForeColor = System.Drawing.Color.White;
            this.BtnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("BtnCustomer.Image")));
            this.BtnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCustomer.Location = new System.Drawing.Point(0, 491);
            this.BtnCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCustomer.Name = "BtnCustomer";
            this.BtnCustomer.Size = new System.Drawing.Size(342, 42);
            this.BtnCustomer.TabIndex = 7;
            this.BtnCustomer.Text = "  Manage Customers";
            this.BtnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCustomer.UseVisualStyleBackColor = true;
            this.BtnCustomer.Click += new System.EventHandler(this.BtnCustomer_Click);
            // 
            // BtnRecords
            // 
            this.BtnRecords.FlatAppearance.BorderSize = 0;
            this.BtnRecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.BtnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecords.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecords.ForeColor = System.Drawing.Color.White;
            this.BtnRecords.Image = ((System.Drawing.Image)(resources.GetObject("BtnRecords.Image")));
            this.BtnRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRecords.Location = new System.Drawing.Point(0, 443);
            this.BtnRecords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnRecords.Name = "BtnRecords";
            this.BtnRecords.Size = new System.Drawing.Size(342, 42);
            this.BtnRecords.TabIndex = 6;
            this.BtnRecords.Text = "  Sales Records";
            this.BtnRecords.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRecords.UseVisualStyleBackColor = true;
            // 
            // BtnCategory
            // 
            this.BtnCategory.FlatAppearance.BorderSize = 0;
            this.BtnCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.BtnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCategory.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCategory.ForeColor = System.Drawing.Color.White;
            this.BtnCategory.Image = ((System.Drawing.Image)(resources.GetObject("BtnCategory.Image")));
            this.BtnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCategory.Location = new System.Drawing.Point(0, 395);
            this.BtnCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCategory.Name = "BtnCategory";
            this.BtnCategory.Size = new System.Drawing.Size(342, 42);
            this.BtnCategory.TabIndex = 5;
            this.BtnCategory.Text = "  Manage Category";
            this.BtnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCategory.UseVisualStyleBackColor = true;
            this.BtnCategory.Click += new System.EventHandler(this.BtnCategory_Click);
            // 
            // BtnProducts
            // 
            this.BtnProducts.FlatAppearance.BorderSize = 0;
            this.BtnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.BtnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProducts.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProducts.ForeColor = System.Drawing.Color.White;
            this.BtnProducts.Image = ((System.Drawing.Image)(resources.GetObject("BtnProducts.Image")));
            this.BtnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProducts.Location = new System.Drawing.Point(0, 299);
            this.BtnProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnProducts.Name = "BtnProducts";
            this.BtnProducts.Size = new System.Drawing.Size(342, 42);
            this.BtnProducts.TabIndex = 4;
            this.BtnProducts.Text = "  Manage Products";
            this.BtnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProducts.UseVisualStyleBackColor = true;
            this.BtnProducts.Click += new System.EventHandler(this.BtnProducts_Click);
            // 
            // BtnPOS
            // 
            this.BtnPOS.FlatAppearance.BorderSize = 0;
            this.BtnPOS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.BtnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPOS.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPOS.ForeColor = System.Drawing.Color.White;
            this.BtnPOS.Image = ((System.Drawing.Image)(resources.GetObject("BtnPOS.Image")));
            this.BtnPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPOS.Location = new System.Drawing.Point(0, 251);
            this.BtnPOS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnPOS.Name = "BtnPOS";
            this.BtnPOS.Size = new System.Drawing.Size(342, 42);
            this.BtnPOS.TabIndex = 3;
            this.BtnPOS.Text = "  POS";
            this.BtnPOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPOS.UseVisualStyleBackColor = true;
            this.BtnPOS.Click += new System.EventHandler(this.BtnInvoice_Click);
            // 
            // lblAccount
            // 
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.ForeColor = System.Drawing.Color.White;
            this.lblAccount.Location = new System.Drawing.Point(47, 153);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(250, 47);
            this.lblAccount.TabIndex = 1;
            this.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Teal;
            this.lblName.Location = new System.Drawing.Point(47, 121);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(250, 47);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Username";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(122, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Container
            // 
            this.Container.BackColor = System.Drawing.Color.White;
            this.Container.Location = new System.Drawing.Point(344, 64);
            this.Container.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(1150, 800);
            this.Container.TabIndex = 2;
            this.Container.Paint += new System.Windows.Forms.PaintEventHandler(this.Container_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1500, 890);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AHK ENTERPRISES POSIM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnUserSettings;
        private System.Windows.Forms.Button BtnSysSettings;
        private System.Windows.Forms.Button BtnCustomer;
        private System.Windows.Forms.Button BtnRecords;
        private System.Windows.Forms.Button BtnCategory;
        private System.Windows.Forms.Button BtnProducts;
        private System.Windows.Forms.Button BtnPOS;
        private System.Windows.Forms.Button BtnStockIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblUsern;
        public System.Windows.Forms.Label lblAccount;
        private MaterialSkin.Controls.MaterialFlatButton BtnDashboard;
    }
}

