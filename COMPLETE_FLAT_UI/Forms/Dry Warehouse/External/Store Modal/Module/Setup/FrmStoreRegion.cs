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
    public partial class frmRegion : MaterialForm
    {

        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        TblRegion TblRegionEntity = new TblRegion();
        DateTime dNow = DateTime.Now;
        DataSet dSet_temp = new DataSet();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        string mode = "";
        public frmRegion()
        {
            InitializeComponent();
        }

        public string Sp_user_id { get; set; }

 

        private void frmRegion_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.Sp_user_id = userinfo.user_id.ToString();
            this.ShowStoreRegion();
            this.LoadRecords();
            this.LoadingrefresherOrb();

            this.GetRadionDataChanged();
        }

        private void GetRadionDataChanged()
        {
            this.matRadioActive.Checked = true;

        }

        public void ConnectionInit()
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections

        }


        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            this.dset_emp_SearchEngines.Clear();

            if (this.TblRegionEntity.Mode == "Add")
            {
                this.dset_emp_SearchEngines = this.g_objStoredProcCollection.sp_getMajorTables("tblRegionSpMajor");
            }
            else
            {
                this.dset_emp_SearchEngines = this.g_objStoredProcCollection.sp_getMajorTables("tblRegionSpMajorInActive");
            }
     

        }

        private void ShowStoreRegion()    //method for loading available_menus
        {
            try
            {

                myClass.fillDataGridView(this.dgvRegion, "tblRegionSpMinor", dSet);

                this.lbltotalrecords.Text = this.dgvRegion.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }


        private void ShowStoreRegionInActive()    //method for loading available_menus
        {
            try
            {

                myClass.fillDataGridView(this.dgvRegion, "tblRegionSpMinorInActive", dSet);

                this.lbltotalrecords.Text = this.dgvRegion.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }




        private void LoadingrefresherOrb()
        {
            this.TblRegionEntity.Mode = "";
            if (this.textBox1.Text == "data Already Save!")
            {
                this.toolStripbtnEdit.Visible = false;
            }
            else if (this.textBox1.Text == "Gerard Singian")
            {
                this.textBox1.Text = string.Empty;
                this.materialBtnNew.Visible = true;
                this.toolStripbtnEdit.Visible = true;
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
                this.toolStripbtnEdit.Visible = true;
            }
        }





        private void DoSearchInTextBoxCmb()
        {
            try
            {


                if (this.dset_emp_SearchEngines.Tables.Count > 0)
                {
                    DataView dv = new DataView(this.dset_emp_SearchEngines.Tables[0]);
                 
                    if (myglobal.global_module == "Active")
                    {
          
                        dv.RowFilter = "region_description  like '%" + this.txtSearch.Text + "%'";

                    }
    
                    this.dgvRegion.DataSource = dv;
                    this.lbltotalrecords.Text = this.dgvRegion.RowCount.ToString();
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

        private void ShowValueCell()
        {
            if (this.dgvRegion.Rows.Count > 0)
            {
                if (this.dgvRegion.CurrentRow != null)
                {
                    if (this.dgvRegion.CurrentRow.Cells["region_description"].Value != null)
                    {
                        this.TblRegionEntity.Region_Id = Convert.ToInt32(dgvRegion.CurrentRow.Cells["region_id"].Value);
                       this.TblRegionEntity.Region_Description = this.dgvRegion.CurrentRow.Cells["region_description"].Value.ToString();
                    }
                }
            }
        }

        private void DgvRawMats_CurrentCellChanged_1(object sender, EventArgs e)
        {
            this.ShowValueCell();
        }



        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            this.SearchMethodJarVarCallingSP();

            if (this.lbltotalrecords.Text == "0")
            {

            }
            else
            {
                DoSearchInTextBoxCmb();
            }
            if (this.txtSearch.Text == "")
            {
                DoSearchInTextBoxCmb();
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            this.frmRegion_Load(sender, e);
        }



        private void MaterialBtnNew_Click(object sender, EventArgs e)
        {
            this.TblRegionEntity.Mode = "add";

            this.materialBtnNew.Visible = false;
            this.toolStripbtnEdit.Visible = false;
            frmAddNewRegion addNew = new frmAddNewRegion(this,
            Sp_user_id,
            this.TblRegionEntity.Region_Description,
            this.TblRegionEntity.Mode,
            this.TblRegionEntity.Region_Id);
            addNew.ShowDialog();
        }

        private void ToolStripbtnEdit_Click(object sender, EventArgs e)
        {
            this.TblRegionEntity.Mode = "edit";
            this.materialBtnNew.Visible = false;
            this.toolStripbtnEdit.Visible = false;
            frmAddNewRegion UpdateModal = new frmAddNewRegion(this,
            Sp_user_id,
            this.TblRegionEntity.Region_Description,
            this.TblRegionEntity.Mode,
            this.TblRegionEntity.Region_Id);
            UpdateModal.ShowDialog();
        }

        private void MatRadioNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matRadioActive.Checked == true)
            {
                this.ConnectionInit();
                this.ShowStoreRegion();
            }
            else
            {
                this.matBtnDelete.Text = "&Activate";
                this.ConnectionInit();
                this.ShowStoreRegionInActive();
            }
        }

        private void MatRadioActive_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matRadioActive.Checked == true)
            {
                this.matBtnDelete.Text = "&InActive";
                this.ConnectionInit();
                this.ShowStoreRegion();
            }
            else
            {
                this.ConnectionInit();
                this.ShowStoreRegionInActive();
            }
        }

        private void MatBtnDelete_Click(object sender, EventArgs e)
        {
            this.PutInactiveData();
        }
        private void PutInactiveData()
        {
            if (this.matRadioActive.Checked == true)
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to deactivate?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (Convert.ToInt32(this.lbltotalrecords.Text) > 0)
                    {

                        mode = "delete";

                        mode = "";

                        this.dSet.Clear();
                        this.dSet = g_objStoredProcCollection.sp_tblRegion(
                        this.TblRegionEntity.Region_Id,
                        this.TblRegionEntity.Region_Description,
                        "1",
                        this.TblRegionEntity.Added_By,
                        "",
                        userinfo.user_id.ToString(),
                        "",
                        "delete");


                        this.GlobalStatePopup.InactiveSuccessfully();
                        this.frmRegion_Load(new object(), new System.EventArgs());

                    }


                }
                else
                {

                    this.toolStripbtnEdit.Visible = true;
                    return;
                }

            }

            else
            {
                //
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to activate?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (Convert.ToInt32(this.lbltotalrecords.Text) > 0)
                    {

                        this.mode = "activate";

                        this.dSet.Clear();
                        this.dSet = g_objStoredProcCollection.sp_tblRegion(
                        this.TblRegionEntity.Region_Id,
                        this.TblRegionEntity.Region_Description,
                        "1",
                        this.TblRegionEntity.Added_By,
                        "",
                         userinfo.user_id.ToString(),
                        "",
                        "activate");

                        this.GlobalStatePopup.ActivatedSuccessfully();
                        this.frmRegion_Load(new object(), new System.EventArgs());

                    }


                }
                else
                {

                    this.toolStripbtnEdit.Visible = true;
                    return;
                }

            }

        }


    }
}
