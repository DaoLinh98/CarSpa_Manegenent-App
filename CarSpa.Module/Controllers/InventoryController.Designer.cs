
namespace CarSpa.Module.Controllers
{
    partial class InventoryController
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
            this.importInventory = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // importInventory
            // 
            this.importInventory.Caption = "import Inventory";
            this.importInventory.ConfirmationMessage = null;
            this.importInventory.Id = "importInventory";
            this.importInventory.ToolTip = null;
            this.importInventory.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.importInventory_Execute);
            // 
            // InventoryController
            // 
            this.Actions.Add(this.importInventory);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction importInventory;
    }
}
