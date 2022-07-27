
namespace CarSpa.Module.Report
{
    partial class ReportGui
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_type = new System.Windows.Forms.Label();
            this.btn_report = new System.Windows.Forms.Button();
            this.typeCustomer_cbb = new System.Windows.Forms.ComboBox();
            this.lb_to = new System.Windows.Forms.Label();
            this.lb_from = new System.Windows.Forms.Label();
            this.ToDate_dtb = new System.Windows.Forms.DateTimePicker();
            this.FromDate_dtb = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.detailServiceRequestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carSpaDataSet = new CarSpa.Module.CarSpaDataSet();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.detailServiceRequestsTableAdapter = new CarSpa.Module.CarSpaDataSetTableAdapters.DetailServiceRequestsTableAdapter();
            this.carSpaDataSet1 = new CarSpa.Module.CarSpaDataSet1();
            this.carSpaDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new CarSpa.Module.CarSpaDataSet1TableAdapters.CustomersTableAdapter();
            this.detailServiceRequestsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.detailServiceRequestsTableAdapter1 = new CarSpa.Module.CarSpaDataSet1TableAdapters.DetailServiceRequestsTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailServiceRequestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carSpaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carSpaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carSpaDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailServiceRequestsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lb_type);
            this.groupBox1.Controls.Add(this.btn_report);
            this.groupBox1.Controls.Add(this.typeCustomer_cbb);
            this.groupBox1.Controls.Add(this.lb_to);
            this.groupBox1.Controls.Add(this.lb_from);
            this.groupBox1.Controls.Add(this.ToDate_dtb);
            this.groupBox1.Controls.Add(this.FromDate_dtb);
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Location = new System.Drawing.Point(10, 77);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(40, 17);
            this.lb_type.TabIndex = 4;
            this.lb_type.Text = "Type";
            // 
            // btn_report
            // 
            this.btn_report.Location = new System.Drawing.Point(307, 70);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(75, 23);
            this.btn_report.TabIndex = 3;
            this.btn_report.Text = "Report";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // typeCustomer_cbb
            // 
            this.typeCustomer_cbb.FormattingEnabled = true;
            this.typeCustomer_cbb.Items.AddRange(new object[] {
            "---select type---",
            "Customer",
            "Machine",
            "------------------"});
            this.typeCustomer_cbb.Location = new System.Drawing.Point(62, 70);
            this.typeCustomer_cbb.Name = "typeCustomer_cbb";
            this.typeCustomer_cbb.Size = new System.Drawing.Size(202, 24);
            this.typeCustomer_cbb.TabIndex = 2;
            // 
            // lb_to
            // 
            this.lb_to.AutoSize = true;
            this.lb_to.Location = new System.Drawing.Point(304, 26);
            this.lb_to.Name = "lb_to";
            this.lb_to.Size = new System.Drawing.Size(25, 17);
            this.lb_to.TabIndex = 1;
            this.lb_to.Text = "To";
            // 
            // lb_from
            // 
            this.lb_from.AutoSize = true;
            this.lb_from.Location = new System.Drawing.Point(10, 26);
            this.lb_from.Name = "lb_from";
            this.lb_from.Size = new System.Drawing.Size(40, 17);
            this.lb_from.TabIndex = 1;
            this.lb_from.Text = "From";
            // 
            // ToDate_dtb
            // 
            this.ToDate_dtb.CustomFormat = "dd MMM yyyy";
            this.ToDate_dtb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDate_dtb.Location = new System.Drawing.Point(372, 21);
            this.ToDate_dtb.Name = "ToDate_dtb";
            this.ToDate_dtb.Size = new System.Drawing.Size(214, 22);
            this.ToDate_dtb.TabIndex = 0;
            // 
            // FromDate_dtb
            // 
            this.FromDate_dtb.CustomFormat = "dd MMM yyyy";
            this.FromDate_dtb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDate_dtb.Location = new System.Drawing.Point(62, 21);
            this.FromDate_dtb.Name = "FromDate_dtb";
            this.FromDate_dtb.Size = new System.Drawing.Size(202, 22);
            this.FromDate_dtb.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gridControl1);
            this.groupBox2.Location = new System.Drawing.Point(2, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(786, 369);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(0, 13);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(786, 356);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // detailServiceRequestsBindingSource
            // 
            this.detailServiceRequestsBindingSource.DataMember = "DetailServiceRequests";
            this.detailServiceRequestsBindingSource.DataSource = this.carSpaDataSet;
            // 
            // carSpaDataSet
            // 
            this.carSpaDataSet.DataSetName = "CarSpaDataSet";
            this.carSpaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detailServiceRequestsTableAdapter
            // 
            this.detailServiceRequestsTableAdapter.ClearBeforeFill = true;
            // 
            // carSpaDataSet1
            // 
            this.carSpaDataSet1.DataSetName = "CarSpaDataSet1";
            this.carSpaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carSpaDataSet1BindingSource
            // 
            this.carSpaDataSet1BindingSource.DataSource = this.carSpaDataSet1;
            this.carSpaDataSet1BindingSource.Position = 0;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.carSpaDataSet1BindingSource;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // detailServiceRequestsBindingSource1
            // 
            this.detailServiceRequestsBindingSource1.DataMember = "DetailServiceRequests";
            this.detailServiceRequestsBindingSource1.DataSource = this.carSpaDataSet1BindingSource;
            // 
            // detailServiceRequestsTableAdapter1
            // 
            this.detailServiceRequestsTableAdapter1.ClearBeforeFill = true;
            // 
            // ReportGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReportGui";
            this.Text = "ReportGui";
            this.Load += new System.EventHandler(this.ReportGui_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailServiceRequestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carSpaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carSpaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carSpaDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailServiceRequestsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker ToDate_dtb;
        private System.Windows.Forms.DateTimePicker FromDate_dtb;
        private System.Windows.Forms.Label lb_to;
        private System.Windows.Forms.Label lb_from;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.ComboBox typeCustomer_cbb;
        private System.Windows.Forms.Label lb_type;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private CarSpaDataSet carSpaDataSet;
        private System.Windows.Forms.BindingSource detailServiceRequestsBindingSource;
        private CarSpaDataSetTableAdapters.DetailServiceRequestsTableAdapter detailServiceRequestsTableAdapter;
        private CarSpaDataSet1 carSpaDataSet1;
        private System.Windows.Forms.BindingSource carSpaDataSet1BindingSource;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private CarSpaDataSet1TableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource detailServiceRequestsBindingSource1;
        private CarSpaDataSet1TableAdapters.DetailServiceRequestsTableAdapter detailServiceRequestsTableAdapter1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}