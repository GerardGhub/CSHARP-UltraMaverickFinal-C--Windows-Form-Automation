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
using ULTRAMAVERICK.API.Entities;
using ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Add_Modals;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Module
{
    public partial class frmSyncConsolidatedOrderSetUp : MaterialForm
    {

        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        int p_id = 0;
        DateTime dNow = DateTime.Now;
        TblStoreOrderManageSyncing TblStoreOrderManageSyncingEntity = new TblStoreOrderManageSyncing();
        public frmSyncConsolidatedOrderSetUp()
        {
            InitializeComponent();
        }

        public string Sp_user_id { get; set; }
    

        private void ConnectionInit()
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections

        }
        private void FrmSyncConsolidatedOrder_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
   
            this.Sp_user_id = userinfo.user_id.ToString();
            this.ShowStoreRoute();
            this.LoadRecords();
            this.LoadingrefresherOrb();

        }

        private void ShowStoreRoute()    //method for loading available_menus
        {
            try
            {

                this.myClass.fillDataGridView(this.DgvSyncConsoLidatedOrder, "TblStoreOrderManageSyncingSpMinor", dSet);

                this.lbltotalrecords.Text = this.DgvSyncConsoLidatedOrder.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.DgvSyncConsoLidatedOrder.Columns["id"].Visible = false;
            this.DgvSyncConsoLidatedOrder.Columns["is_active"].Visible = false;
        }

        private void LoadingrefresherOrb()
        {
            this.TblStoreOrderManageSyncingEntity.Mode = "";
            if (this.TextBox1.Text == "data Already Save!")
            {
                this.btnEditTool.Visible = false;
          
            }
            else if (TextBox1.Text == "Gerard Singian")
            {
                this.TextBox1.Text = string.Empty;
                this.btnNewTool.Visible = true;
                this.btnEditTool.Visible = true;
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
                this.btnEditTool.Visible = true;
            }
        }



  

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

            this.FrmSyncConsolidatedOrder_Load(sender, e);
        }



        private void Lbltotalrecords_TextChanged(object sender, EventArgs e)
        {
            if (this.lbltotalrecords.Text != "0")
            {
                this.btnNewTool.Enabled = false;
            }
            else
            {
                this.btnNewTool.Enabled = true;
            }
        }

        private void DgvRegion_CurrentCellChanged(object sender, EventArgs e)
        {
            this.DgvCurrentCellChangeMapper();
        }

        private void DgvCurrentCellChangeMapper()
        {

            if (this.DgvSyncConsoLidatedOrder.Rows.Count > 0)
            {
                if (this.DgvSyncConsoLidatedOrder.CurrentRow != null)
                {
                    if (this.DgvSyncConsoLidatedOrder.CurrentRow.Cells["time_from_desc"].Value != null)
                    {
                        this.p_id = Convert.ToInt32(this.DgvSyncConsoLidatedOrder.CurrentRow.Cells["id"].Value);
                        this.TblStoreOrderManageSyncingEntity.Time_From_Desc = this.DgvSyncConsoLidatedOrder.CurrentRow.Cells["time_from_desc"].Value.ToString();
                        this.TblStoreOrderManageSyncingEntity.Time_From_To = this.DgvSyncConsoLidatedOrder.CurrentRow.Cells["time_from_to"].Value.ToString();
                    }
                }
            }


        }

        private void BtnNewTool_Click(object sender, EventArgs e)
        {
            this.TblStoreOrderManageSyncingEntity.Mode = "add";

            this.btnNewTool.Visible = false;
            this.btnEditTool.Visible = false;
            AddNewConsolidatedOrderSync addNew = 
            new AddNewConsolidatedOrderSync(this, 
            Sp_user_id,
            this.TblStoreOrderManageSyncingEntity.Time_From_Desc,
            this.TblStoreOrderManageSyncingEntity.Mode,
            p_id);
            addNew.ShowDialog();
        }

        private void BtnEditTool_Click(object sender, EventArgs e)
        {
            this.TblStoreOrderManageSyncingEntity.Mode = "edit";
            this.btnNewTool.Visible = false;
            this.btnEditTool.Visible = false;
            AddNewConsolidatedOrderSync UpdateModal = 
                new AddNewConsolidatedOrderSync(this,
                Sp_user_id,
                TblStoreOrderManageSyncingEntity.Time_From_Desc,
                TblStoreOrderManageSyncingEntity.Mode,
                p_id);
            UpdateModal.ShowDialog();
        }
    }
}
