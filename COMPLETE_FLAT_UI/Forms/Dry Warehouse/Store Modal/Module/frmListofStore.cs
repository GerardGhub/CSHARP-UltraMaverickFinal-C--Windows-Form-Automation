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
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    public partial class frmListofStore : MaterialForm
    {
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();


        DateTime dNow = DateTime.Now;


        DataSet dSet_temp = new DataSet();
        public frmListofStore()
        {
            InitializeComponent();
        }

        public string SpStoreCode { get; set; }
        public string SpStoreName { get; set; }
        public string SpStoreRoute { get; set; }
        public string SpStoreArea { get; set; }
        public string StoreId { get; set; }
        public string sp_user_id { get; set; }
        public string SpRegion { get; set; }

        private void frmListofStore_Load(object sender, EventArgs e)
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            this.objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class

            this.showReceivingData();
            this.WindowsRefresher();
        }
        
        private void WindowsRefresher()
        {
            if (this.textBox1.Text == "data Already Save!")
            {
                this.toolStripMain.Visible = false;
            }
            else if (this.textBox1.Text == "Gerard Singian")
            {
                this.textBox1.Text = string.Empty;
                this.toolStripMain.Visible = true;
   
            }
            else
            {


            }

            this.sp_user_id = userinfo.user_id.ToString();
        }
        private void showReceivingData()      //method for loading available_menus
        {
            try
            {

                this.xClass.fillDataGridView(this.dgvSubCategory, "tbl_stores_major", dSet);

                this.lbltotaldata.Text = this.dgvSubCategory.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.dgvSubCategory.Columns["stored_id"].Visible = false;
            this.dgvSubCategory.Columns["is_active"].Visible = false;
        }

        private void btnNewTool_Click(object sender, EventArgs e)
        {
            toolStripMain.Visible = false;
           frmAddNewStore addNew = new frmAddNewStore(this);
            addNew.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.frmListofStore_Load(sender, e);
        }

        private void btnEditTool_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("For Development And Clarifications");
            toolStripMain.Visible = false;
            frmEditStore addNew = new frmEditStore(this, this.SpStoreCode, this.SpStoreName, this.SpStoreRoute, this.SpStoreArea, this.StoreId, this.SpRegion);
            addNew.ShowDialog();

        }

        private void dgvSubCategory_CurrentCellChanged(object sender, EventArgs e)
        {
            this.showValueCell();
        }

        private void showValueCell()
        {
            if (this.dgvSubCategory.Rows.Count > 0)
            {
                if (this.dgvSubCategory.CurrentRow != null)
                {
                    if (this.dgvSubCategory.CurrentRow.Cells["store_code"].Value != null)
                    {
                        this.StoreId = this.dgvSubCategory.CurrentRow.Cells["stored_id"].Value.ToString();
                        this.SpStoreCode = this.dgvSubCategory.CurrentRow.Cells["store_code"].Value.ToString();
                        this.SpStoreName = this.dgvSubCategory.CurrentRow.Cells["store_name"].Value.ToString();
                        this.SpStoreRoute = this.dgvSubCategory.CurrentRow.Cells["store_route"].Value.ToString();
                        this.SpStoreArea = this.dgvSubCategory.CurrentRow.Cells["store_area"].Value.ToString();
                        this.SpRegion = this.dgvSubCategory.CurrentRow.Cells["region"].Value.ToString();

                    }
                }
            }
        }

        private void btnRemoveTool_Click(object sender, EventArgs e)
        {
            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to inactive?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                dSet.Clear();
                dSet = objStorProc.sp_tbl_stores(Convert.ToInt32(this.StoreId),
                    this.SpStoreName,
                    this.SpStoreArea,
                    this.SpStoreCode,
                    this.SpStoreRoute,
                    Convert.ToString(sp_user_id), "", Convert.ToString(sp_user_id), "", "", "delete");
                this.GlobalStatePopup.InactiveSuccessfully();
                this.frmListofStore_Load(sender, e);
            }
            else
            {
                return;
            }
        }
    }
}
