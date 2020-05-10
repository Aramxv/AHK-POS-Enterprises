namespace AHKPOSENKTHESIS
{
    partial class Alert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alert));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.icon = new System.Windows.Forms.PictureBox();
            this.messages = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timeout = new System.Windows.Forms.Timer(this.components);
            this.show = new System.Windows.Forms.Timer(this.components);
            this.closealert = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "alertproduct_64px.png");
            this.imageList1.Images.SetKeyName(1, "alerthigh_importance_64px.png");
            this.imageList1.Images.SetKeyName(2, "alerttask_completed_64px.png");
            this.imageList1.Images.SetKeyName(3, "alertcancel_64px.png");
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.Transparent;
            this.icon.Location = new System.Drawing.Point(12, 22);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(64, 64);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // messages
            // 
            this.messages.BackColor = System.Drawing.Color.Transparent;
            this.messages.Font = new System.Drawing.Font("Poppins", 8F);
            this.messages.ForeColor = System.Drawing.Color.White;
            this.messages.Location = new System.Drawing.Point(82, 22);
            this.messages.Name = "messages";
            this.messages.Size = new System.Drawing.Size(284, 64);
            this.messages.TabIndex = 1;
            this.messages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(368, 4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(36, 36);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtnClose.TabIndex = 2;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // timeout
            // 
            this.timeout.Enabled = true;
            this.timeout.Interval = 5000;
            this.timeout.Tick += new System.EventHandler(this.timeout_Tick);
            // 
            // show
            // 
            this.show.Tick += new System.EventHandler(this.show_Tick);
            // 
            // closealert
            // 
            this.closealert.Tick += new System.EventHandler(this.close_Tick);
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(413, 109);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.messages);
            this.Controls.Add(this.icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alert";
            this.Opacity = 0.95D;
            this.Text = "Alert";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Alert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox BtnClose;
        private System.Windows.Forms.Label messages;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.ImageList imageList1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Timer timeout;
        private System.Windows.Forms.Timer show;
        private System.Windows.Forms.Timer closealert;
    }
}