
namespace CarSpa.Module.Controllers
{
    partial class ServiceController
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
            this.importService = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // importService
            // 
            this.importService.Caption = "import Service";
            this.importService.ConfirmationMessage = null;
            this.importService.Id = "importService";
            this.importService.ToolTip = null;
            this.importService.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.importService_Execute);
            // 
            // ServiceController
            // 
            this.Actions.Add(this.importService);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction importService;
    }
}
