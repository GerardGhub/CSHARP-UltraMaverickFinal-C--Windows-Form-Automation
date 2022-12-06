using Guna.UI2.WinForms.Suite;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Report;

namespace ULTRAMAVERICK.Application.Report
{
    public partial class frmRMReceivingReportDryWarehouse : MaterialForm
    {
        public frmRMReceivingReportDryWarehouse()
        {
            InitializeComponent();
        }

        private void frmRMReceivingReportDryWarehouse_Load(object sender, EventArgs e)
        {
        }

        private void MatBtnGenerate_Click(object sender, EventArgs e)
        {
            myglobal.DATE_REPORT = this.dtpFrom.Text;
            myglobal.DATE_REPORT2 = this.dtpTo.Text;
            myglobal.REPORT_NAME = "DryMaterialHistoryTracking";

            frmReport fr = new frmReport();
            fr.WindowState = FormWindowState.Maximized;
            fr.Show();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
