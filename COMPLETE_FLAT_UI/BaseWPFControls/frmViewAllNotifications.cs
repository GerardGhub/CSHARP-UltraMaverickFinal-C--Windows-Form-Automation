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

namespace ULTRAMAVERICK.BaseWPFControls
{
    public partial class frmViewAllNotifications : MaterialForm
    {
        DataSet dSet = new DataSet();
        myclasses xClass = new myclasses();
        public frmViewAllNotifications()
        {
            InitializeComponent();
        }

        private void frmViewAllNotifications_Load(object sender, EventArgs e)
        {
           
        }


        private void CancelledforStorePreparationatWarehouseChecker()      //method for loading available_menus
        {
            try
            {

                xClass.fillDataGridView(this.DatagridViewGuna1, "Store_Order_Cancelled_by_WH_Checker", dSet);

                this.lbltotalrecords.Text = this.DatagridViewGuna1.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void DispatchingforStorePreparationatWarehouseChecker()      //method for loading available_menus
        {
            try
            {

                xClass.fillDataGridView(this.gunaDgvLogisticCheckerDispatching, "Store_Order_Dispatched_by_Logistic_Checker", dSet);

                this.lbltotalrecords.Text = this.gunaDgvLogisticCheckerDispatching.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                MessageBox.Show("Tab 1");
                this.CancelledforStorePreparationatWarehouseChecker();
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                MessageBox.Show("Tab 2");
                this.DispatchingforStorePreparationatWarehouseChecker();
            }
            else
            {

            }
        }
    }
}
