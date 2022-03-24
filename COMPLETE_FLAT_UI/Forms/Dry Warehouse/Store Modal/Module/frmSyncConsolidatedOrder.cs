using COMPLETE_FLAT_UI.Models;
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
using ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Add_Modals;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Module
{
    public partial class frmSyncConsolidatedOrder : MaterialForm
    {
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        int p_id = 0;
        DateTime dNow = DateTime.Now;
        DataSet dSet_temp = new DataSet();

        public frmSyncConsolidatedOrder()
        {
            InitializeComponent();
        }

        public string sp_user_id { get; set; }
        public string sp_time_from_desc { get; set; }
        public string sp_time_from_to_desc { get; set; }
        public string sp_typeof_mode { get; set; }

        private void frmSyncConsolidatedOrder_Load(object sender, EventArgs e)
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            this.objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            this.sp_user_id = userinfo.user_id.ToString();
            this.showStoreRoute();
            this.LoadRecords();
            this.LoadingrefresherOrb();

            //this.SearchMethodJarVarCallingSP();
        }

        private void showStoreRoute()    //method for loading available_menus
        {
            try
            {

                xClass.fillDataGridView(this.dgvRegion, "TblStoreOrderManageSyncingSpMinor", dSet);

                this.lbltotalrecords.Text = this.dgvRegion.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            this.dgvRegion.Columns["is_active"].Visible = false;
        }

        private void LoadingrefresherOrb()
        {
            this.sp_typeof_mode = "";
            if (textBox1.Text == "data Already Save!")
            {
                matBtnEdit.Visible = false;
          
            }
            else if (textBox1.Text == "Gerard Singian")
            {
                textBox1.Text = string.Empty;
                matBtnNew.Visible = true;
                matBtnEdit.Visible = true;
            }
            else
            {
            }
            myglobal.global_module = "Active"; // Mode for Searching

        }
        private void LoadRecords()
        {
            if (lbltotalrecords.Text == "0")
            {

            }
            else
            {
                this.matBtnEdit.Visible = true;
            }
        }



        private void matBtnNew_Click(object sender, EventArgs e)
        {
            this.sp_typeof_mode = "add";

            this.matBtnNew.Visible = false;
            this.matBtnEdit.Visible = false;
            AddNewConsolidatedOrderSync addNew = new AddNewConsolidatedOrderSync(this, sp_user_id, sp_time_from_desc, sp_typeof_mode, p_id);
            addNew.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            this.frmSyncConsolidatedOrder_Load(sender, e);
        }

        private void matBtnEdit_Click(object sender, EventArgs e)
        {
            this.sp_typeof_mode = "edit";
            this.matBtnNew.Visible = false;
            this.matBtnEdit.Visible = false;
            AddNewConsolidatedOrderSync UpdateModal = new AddNewConsolidatedOrderSync(this, sp_user_id, sp_time_from_desc, sp_typeof_mode, p_id);
            UpdateModal.ShowDialog();
        }

        private void lbltotalrecords_TextChanged(object sender, EventArgs e)
        {
            if (this.lbltotalrecords.Text != "0")
            {
                this.matBtnNew.Enabled = false;
            }
            else
            {
                this.matBtnNew.Enabled = true;
            }
        }

        private void dgvRegion_CurrentCellChanged(object sender, EventArgs e)
        {
            this.DgvCurrentCellChangeMapper();
        }

        private void DgvCurrentCellChangeMapper()
        {

            if (this.dgvRegion.Rows.Count > 0)
            {
                if (this.dgvRegion.CurrentRow != null)
                {
                    if (this.dgvRegion.CurrentRow.Cells["time_from_desc"].Value != null)
                    {
                        this.p_id = Convert.ToInt32(this.dgvRegion.CurrentRow.Cells["id"].Value);
                        this.sp_time_from_desc = this.dgvRegion.CurrentRow.Cells["time_from_desc"].Value.ToString();
                        this.sp_time_from_to_desc = this.dgvRegion.CurrentRow.Cells["time_from_to"].Value.ToString();
                    }
                }
            }


        }
    }
}
