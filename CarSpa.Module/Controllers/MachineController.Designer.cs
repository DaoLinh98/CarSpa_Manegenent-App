
namespace CarSpa.Module.Controllers
{
    partial class MachineController
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
            this.importMachine = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // importMachine
            // 
            this.importMachine.Caption = "import Machine";
            this.importMachine.ConfirmationMessage = null;
            this.importMachine.Id = "importMachine";
            this.importMachine.ToolTip = null;
            this.importMachine.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.importMachine_Execute);
            // 
            // Machine
            // 
            this.Actions.Add(this.importMachine);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction importMachine;
    }
}
