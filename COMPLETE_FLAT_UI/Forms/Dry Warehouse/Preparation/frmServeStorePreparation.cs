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

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Preparation
{
    public partial class frmServeStorePreparation : MaterialForm
    {
        frmDryPreparationStore ths;
        //Main Classs
        myclasses myClass = new myclasses();
        myclasses xClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        IStoredProcedures objStorProc = null;
        //Data Set Initialization
        public DataSet dset = new DataSet();
        DataSet dset2 = new DataSet();
        DataSet dset3 = new DataSet();
        DataSet dSet = new DataSet();
        //Variable Declaration
        int p_id = 0;

        public frmServeStorePreparation(frmDryPreparationStore frm)
        {
            InitializeComponent();
        }

        public string receiving_identity { get; set; }
        public string sp_item_code { get; set; }
        public string sp_item_description { get; set; }
        public string sp_quantity_serve { get; set; }
        public string sp_receiving_id { get; set; }
        public string sp_qty_order { get; set; }
        public string sp_uom { get; set; }

        private void frmServeStorePreparation_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class

            myglobal.global_module = "Active"; // Mode for Searching

            this.SearchMethodJarVarCallingSP();
            this.doSearchInTextBoxCmb();
        }


 

            DataSet dset_emp_SearchEngines = new DataSet();
            private void SearchMethodJarVarCallingSP()
            {
                this.dset_emp_SearchEngines.Clear();


                this.dset_emp_SearchEngines = objStorProc.sp_getMajorTables("searchorderForApprovalinDryWH_isApprovedforPreparation_PerItems");

            }

        
        private void doSearchInTextBoxCmb()
        {
            try
            {


                if (dset_emp_SearchEngines.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp_SearchEngines.Tables[0]);
                    if (myglobal.global_module == "EMPLOYEE")
                    {

                    }
                    else if (myglobal.global_module == "Active")
                    {
                        //Gerard Singian Developer Man

                        dv.RowFilter = "primary_id like '%" + this.receiving_identity + "%'";

                    }
                
                    this.dgvStoreOrderApproval.DataSource = dv;
                    //lbltotalrecords.Text = dgvRawMats.RowCount.ToString();
                }
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Invalid character found xxx!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

        }


        private void SearchMethodReceivingEntry()
        {
            this.dset.Clear();

            this.dset = objStorProc.sp_getMajorTables("searchorderForApprovalinDryWH_isApprovedforPreparation");
            DataView dv = new DataView(this.dset.Tables[0]);

            this.dgvStoreOrderApproval.DataSource = dv;
            //this.lbltotalStoreforPreparation.Text = dgvStoreOrderApproval.RowCount.ToString();
        }

    }
}
