
namespace CarSpa.Module.Report
{
    partial class ReportMachine
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ToDate_dtb = new System.Windows.Forms.DateTimePicker();
            this.FromDate_dtb = new System.Windows.Forms.DateTimePicker();
            this.btn_report = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lb_toDate = new System.Windows.Forms.Label();
            this.lb_fromDate = new System.Windows.Forms.Label();
            this.lb_type = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ToDate_dtb);
            this.groupBox1.Controls.Add(this.FromDate_dtb);
            this.groupBox1.Controls.Add(this.btn_report);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lb_toDate);
            this.groupBox1.Controls.Add(this.lb_fromDate);
            this.groupBox1.Controls.Add(this.lb_type);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 115);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // ToDate_dtb
            // 
            this.ToDate_dtb.CustomFormat = "dd MMM yyyy";
            this.ToDate_dtb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDate_dtb.Location = new System.Drawing.Point(333, 24);
            this.ToDate_dtb.Name = "ToDate_dtb";
            this.ToDate_dtb.Size = new System.Drawing.Size(214, 22);
            this.ToDate_dtb.TabIndex = 5;
            // 
            // FromDate_dtb
            // 
            this.FromDate_dtb.CustomFormat = "dd MMM yyyy";
            this.FromDate_dtb.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDate_dtb.Location = new System.Drawing.Point(56, 24);
            this.FromDate_dtb.Name = "FromDate_dtb";
            this.FromDate_dtb.Size = new System.Drawing.Size(202, 22);
            this.FromDate_dtb.TabIndex = 4;
            // 
            // btn_report
            // 
            this.btn_report.Location = new System.Drawing.Point(305, 71);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(75, 23);
            this.btn_report.TabIndex = 3;
            this.btn_report.Text = "Report";
            this.btn_report.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(58, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // lb_toDate
            // 
            this.lb_toDate.AutoSize = true;
            this.lb_toDate.Location = new System.Drawing.Point(302, 29);
            this.lb_toDate.Name = "lb_toDate";
            this.lb_toDate.Size = new System.Drawing.Size(25, 17);
            this.lb_toDate.TabIndex = 0;
            this.lb_toDate.Text = "To";
            // 
            // lb_fromDate
            // 
            this.lb_fromDate.AutoSize = true;
            this.lb_fromDate.Location = new System.Drawing.Point(6, 29);
            this.lb_fromDate.Name = "lb_fromDate";
            this.lb_fromDate.Size = new System.Drawing.Size(40, 17);
            this.lb_fromDate.TabIndex = 0;
            this.lb_fromDate.Text = "From";
            // 
            // lb_type
            // 
            this.lb_type.AutoSize = true;
            this.lb_type.Location = new System.Drawing.Point(6, 78);
            this.lb_type.Name = "lb_type";
            this.lb_type.Size = new System.Drawing.Size(40, 17);
            this.lb_type.TabIndex = 0;
            this.lb_type.Text = "Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gridControl1);
            this.groupBox2.Location = new System.Drawing.Point(12, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 326);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(0, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(776, 318);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // ReportMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReportMachine";
            this.Text = "ReportMachine";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label lb_toDate;
        private System.Windows.Forms.Label lb_fromDate;
        private System.Windows.Forms.Label lb_type;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker FromDate_dtb;
        private System.Windows.Forms.DateTimePicker ToDate_dtb;
    }
}