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
    public partial class frmMoveOrderReports : MaterialForm
    {
        public frmMoveOrderReports()
        {
            InitializeComponent();
        }

        private void frmMoveOrderReports_Load(object sender, EventArgs e)
        {

        }

        private void MatBtnGenerate_Click(object sender, EventArgs e)
        {
            myglobal.DATE_REPORT = this.dtpFrom.Text;
            myglobal.DATE_REPORT2 = this.dtpTo.Text;
            myglobal.REPORT_NAME = "StoreMoveOrderPickSlipDateRange";

            frmReport fr = new frmReport();
            fr.WindowState = FormWindowState.Maximized;
            fr.Show();


        }
    }
}
