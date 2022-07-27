
namespace CarSpa.Module.Controllers
{
    partial class reportGuiController
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
            this.ReportGui = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // ReportGui
            // 
            this.ReportGui.Caption = "Report Gui";
            this.ReportGui.ConfirmationMessage = null;
            this.ReportGui.Id = "ReportGui";
            this.ReportGui.ToolTip = null;
            this.ReportGui.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ReportGui_Execute);
            // 
            // reportGuiController
            // 
            this.Actions.Add(this.ReportGui);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction ReportGui;
    }
}
