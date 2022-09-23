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

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    public partial class frmPendingOrder : MaterialForm
    {
       
   
        IStoredProcedures g_objStoredProcCollection = null;
        readonly myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();


        DateTime dNow = DateTime.Now;



        DataSet dSet_temp = new DataSet();
        public frmPendingOrder()
        {
            InitializeComponent();
        }

        private void frmPendingOrder_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections


            this.showDryWhPendingOrders();
        }

        private void showDryWhPendingOrders()      //method for loading available_menus
        {
            try
            {

                myClass.fillDataGridView(this.dgvSubCategory, "dry_wh_orders_pending", dSet);

                this.lbltotaldata.Text = this.dgvSubCategory.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.dgvSubCategory.Columns["is_active"].Visible = false;
            this.dgvSubCategory.Columns["added_by"].Visible = false;
            this.dgvSubCategory.Columns["primary_id"].Visible = false;
            this.dgvSubCategory.Columns["is_for_validation"].Visible = false;

        }
    }
    
}
