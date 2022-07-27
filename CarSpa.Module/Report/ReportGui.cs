using CarSpa.Module.BusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSpa.Module.Report
{
    public partial class ReportGui : Form
    {
        public ReportGui()
        {
            InitializeComponent();
        }

        private void ReportGui_Load(object sender, EventArgs e)
        {
         

        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            CarSpaDbContext reportcustomer = new CarSpaDbContext(Add_Config.connectStr);
            if (typeCustomer_cbb.Text == "Customer")

            {
               // gridControl1.Refresh();

                var listData = reportcustomer.DetailServiceRequests.Where(x => x.RequestDate >= FromDate_dtb.Value && x.RequestDate <= ToDate_dtb.Value).Select
                              (
                              x => new
                              {
                                  NO = x.DetailRequsetId,
                                  CustomerID = x.CustomerId,
                                  CustomerName = x.Customer.CustomerName,
                                  RequestDate = x.RequestDate,
                                  TotalCost = x.TotalCost,
                              }
                              ).ToList();
                gridControl1.DataSource = listData;
                gridView1.PopulateColumns();
            }
            else if(typeCustomer_cbb.Text == "Machine")
            {

               
                var listData = reportcustomer.DetailServiceRequests.Where(x => x.RequestDate >= FromDate_dtb.Value && x.RequestDate <= ToDate_dtb.Value).Select(
                    x=> new
                    {
                        NO = x.DetailRequsetId,
                        MachineID = x.MachineId,
                        MachineName = x.Machine.MachineName,
                        RequestDate = x.RequestDate,
                        TotalCost = x.Service.Price + x.Inventory.Pricce,
                    }
                    ).ToList();
                gridControl1.DataSource = listData;
                gridView1.PopulateColumns();


            }





        }
    }
}
