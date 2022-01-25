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
            this.CancelledforStorePreparationatWarehouseChecker();
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
    }
}
