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

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Module
{
    public partial class frmAllocationModule : MaterialForm
    {
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();


        int p_id = 0;

        DateTime dNow = DateTime.Now;
        //Boolean ready = false;


        DataSet dSet_temp = new DataSet();
        public frmAllocationModule()
        {
            InitializeComponent();
        }

        private void frmAllocationModule_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.showRawMaterialsInDryWH();
        }



        private void ConnectionInit()
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            this.objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
        }

        private void showRawMaterialsInDryWH()    //method for loading available_menus
        {
            try
            {

                xClass.fillDataGridView(this.dgvStoreOrderApproval, "Raw_Materials_Dry_Allocation", dSet);

               this.lbltotaldata.Text = this.dgvStoreOrderApproval.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            //this.dgvRawMats.Columns["item_id"].Visible = false;

        }
    }
}
