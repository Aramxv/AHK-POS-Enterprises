namespace AHKPOSENKTHESIS
{
    partial class FrmInvoiceEditPrintPreview
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInvoiceEditPrintPreview));
            this.OrderbyInvoiceNoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AHKENTPOSDATABASEDataSet = new AHKPOSENKTHESIS.AHKENTPOSDATABASEDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OrderbyInvoiceNoTableAdapter = new AHKPOSENKTHESIS.AHKENTPOSDATABASEDataSetTableAdapters.OrderbyInvoiceNoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.OrderbyInvoiceNoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AHKENTPOSDATABASEDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderbyInvoiceNoBindingSource
            // 
            this.OrderbyInvoiceNoBindingSource.DataMember = "OrderbyInvoiceNo";
            this.OrderbyInvoiceNoBindingSource.DataSource = this.AHKENTPOSDATABASEDataSet;
            // 
            // AHKENTPOSDATABASEDataSet
            // 
            this.AHKENTPOSDATABASEDataSet.DataSetName = "AHKENTPOSDATABASEDataSet";
            this.AHKENTPOSDATABASEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OrderbyInvoiceNoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AHKPOSENKTHESIS.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1142, 739);
            this.reportViewer1.TabIndex = 0;
            // 
            // OrderbyInvoiceNoTableAdapter
            // 
            this.OrderbyInvoiceNoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmInvoiceEditPrintPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 739);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInvoiceEditPrintPreview";
            this.Text = "Invoice Print Preview";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmInvoiceEditPrintPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderbyInvoiceNoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AHKENTPOSDATABASEDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OrderbyInvoiceNoBindingSource;
        private AHKENTPOSDATABASEDataSet AHKENTPOSDATABASEDataSet;
        private AHKENTPOSDATABASEDataSetTableAdapters.OrderbyInvoiceNoTableAdapter OrderbyInvoiceNoTableAdapter;
    }
}