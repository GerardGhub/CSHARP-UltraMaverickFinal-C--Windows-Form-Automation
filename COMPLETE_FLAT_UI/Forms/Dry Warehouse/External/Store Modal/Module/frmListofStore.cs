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
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    public partial class frmListofStore : MaterialForm
    {

        IStoredProcedures g_objStoredProcCollection = null;
        readonly myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        readonly Tbl_Stores Tbl_StoresEntity = new Tbl_Stores();
        DateTime dNow = DateTime.Now;
        DataSet dSet_temp = new DataSet();
        public frmListofStore()
        {
            InitializeComponent();
        }


        public string sp_user_id { get; set; }
      

        private void frmListofStore_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();

            this.showStores();
            this.WindowsRefresher();
            this.GetRadionDataChanged();
            this.textBox1.Text = String.Empty;
        }


        private void ConnectionInit()
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections

        }

        private void GetRadionDataChanged()
        {
            this.matRadioActive.Checked = true;
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
        private void showStores()      //method for loading available_menus
        {
            try
            {

                this.myClass.fillDataGridView(this.dgvStores, "tbl_stores_major", dSet);

                this.lbltotaldata.Text = this.dgvStores.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.dgvStores.Columns["stored_id"].Visible = false;
            this.dgvStores.Columns["is_active"].Visible = false;
        }

        private void showStoresInActive()      //method for loading available_menus
        {
            try
            {

                this.myClass.fillDataGridView(this.dgvStores, "tbl_stores_majorInActive", dSet);

                this.lbltotaldata.Text = this.dgvStores.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.dgvStores.Columns["stored_id"].Visible = false;
            this.dgvStores.Columns["is_active"].Visible = false;
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
          
                toolStripMain.Visible = false;
                FrmEditStore addNew = new FrmEditStore(
                this, 
                this.Tbl_StoresEntity.Stored_Id,
                this.Tbl_StoresEntity.Store_Name,
                this.Tbl_StoresEntity.Store_Area,
                this.Tbl_StoresEntity.Store_Code,
                this.Tbl_StoresEntity.Store_Route,
                this.Tbl_StoresEntity.Region);
                addNew.ShowDialog();

        }

        private void dgvSubCategory_CurrentCellChanged(object sender, EventArgs e)
        {
            this.showValueCell();
        }

        private void showValueCell()
        {
            if (this.dgvStores.Rows.Count > 0)
            {
                if (this.dgvStores.CurrentRow != null)
                {
                    if (this.dgvStores.CurrentRow.Cells["store_code"].Value != null)
                    {
                        this.Tbl_StoresEntity.Stored_Id = Convert.ToInt32(this.dgvStores.CurrentRow.Cells["stored_id"].Value);
                        this.Tbl_StoresEntity.Store_Code = this.dgvStores.CurrentRow.Cells["store_code"].Value.ToString();
                        this.Tbl_StoresEntity.Store_Name = this.dgvStores.CurrentRow.Cells["store_name"].Value.ToString();
                        this.Tbl_StoresEntity.Store_Route = this.dgvStores.CurrentRow.Cells["store_route"].Value.ToString();
                        this.Tbl_StoresEntity.Store_Area = this.dgvStores.CurrentRow.Cells["store_area"].Value.ToString();
                        this.Tbl_StoresEntity.Region = this.dgvStores.CurrentRow.Cells["region"].Value.ToString();

                    }
                }
            }
        }

        private void btnRemoveTool_Click(object sender, EventArgs e)
        {
            if (this.matRadioActive.Checked == true)
            {

                //Start
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to inactive?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    dSet.Clear();
                    dSet = g_objStoredProcCollection
                        .sp_tbl_stores(Convert.ToInt32(this.Tbl_StoresEntity.Stored_Id),
                        this.Tbl_StoresEntity.Store_Name,
                        this.Tbl_StoresEntity.Store_Area,
                        this.Tbl_StoresEntity.Store_Code,
                        this.Tbl_StoresEntity.Store_Route,
                        Convert.ToString(sp_user_id), 
                        "", 
                        Convert.ToString(sp_user_id), 
                        userinfo.user_id.ToString(),
                        "", 
                        "delete");
                    this.GlobalStatePopup.InactiveSuccessfully();
                    this.frmListofStore_Load(sender, e);
                }
                else
                {
                    return;
                }
            }

            else
            {
                

                //Start
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to activate?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    dSet.Clear();
                    dSet = g_objStoredProcCollection
                        .sp_tbl_stores(Convert.ToInt32(this.Tbl_StoresEntity.Stored_Id),
                        this.Tbl_StoresEntity.Store_Name,
                        this.Tbl_StoresEntity.Store_Area,
                        this.Tbl_StoresEntity.Store_Code,
                        this.Tbl_StoresEntity.Store_Route,
                        Convert.ToString(sp_user_id),
                        "",
                        Convert.ToString(sp_user_id),
                        userinfo.user_id.ToString(),
                        "",
                        "activate");
                    this.GlobalStatePopup.InactiveSuccessfully();
                    this.frmListofStore_Load(sender, e);
                }
                else
                {
                    return;
                }

            }
        }

        private void matRadioNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matRadioActive.Checked == true)
            {
                this.ConnectionInit();
                this.showStores();
            }
            else
            {
                this.btnRemoveTool.Text = "&Activate";
                this.ConnectionInit();
                this.showStoresInActive();
            }
        }

        private void matRadioActive_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matRadioActive.Checked == true)
            {
                this.btnRemoveTool.Text = "&InActive";
                this.ConnectionInit();
                this.showStores();
            }
            else
            {
                this.ConnectionInit();
                this.showStoresInActive();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.SearchMethodJarVarCallingSP();

            
            if (this.txtSearch.Text == "")
            {
                this.doSearchInTextBoxCmb();
            }
        }

        private void doSearchInTextBoxCmb()
        {
            try
            {


                if (this.dset_emp_SearchEngines.Tables.Count > 0)
                {
                    DataView dv = new DataView(this.dset_emp_SearchEngines.Tables[0]);
                 
                        //Gerard Singian Developer Man

                        dv.RowFilter = "store_name like '%" + this.txtSearch.Text + "%' " +
                        "or store_area like '%" + this.txtSearch.Text + "%' " +
                        "or store_code like '%" + this.txtSearch.Text + "%' " +
                        "or store_route like '%" + this.txtSearch.Text + "%'    ";

                    this.dgvStores.DataSource = dv;
                    this.lbltotalrecords.Text = this.dgvStores.RowCount.ToString();
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


        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            this.dset_emp_SearchEngines.Clear();

            if (this.matRadioActive.Checked == true)
            {
                this.dset_emp_SearchEngines = this.g_objStoredProcCollection.sp_getMajorTables("tblStoreSpMajor");
            }
            else
            {
                this.dset_emp_SearchEngines = this.g_objStoredProcCollection.sp_getMajorTables("tblStoreSpMajorInActive");
            }
            this.doSearchInTextBoxCmb();

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
