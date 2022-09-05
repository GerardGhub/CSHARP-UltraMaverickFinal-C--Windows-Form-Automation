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
using ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    public partial class frmAreaManagement : MaterialForm
    {
        myclasses xClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        string mode = "";
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        int p_id = 0;
        TblArea TblAreaEntity = new TblArea();
        DateTime dNow = DateTime.Now;



        DataSet dSet_temp = new DataSet();
        public frmAreaManagement()
        {
            InitializeComponent();
        }

        public string sp_user_id { get; set; }


        private void frmAreaManagement_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.sp_user_id = userinfo.user_id.ToString();
            this.showStoreArea();
            this.LoadRecords();
            this.LoadingrefresherOrb();
            this.GetRadionDataChanged();

        }

        private void GetRadionDataChanged()
        {
            this.matRadioActive.Checked = true;

        }

        private void ConnectionInit()
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }

        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            this.dset_emp_SearchEngines.Clear();

            if (this.matRadioActive.Checked == true)
            {
                this.dset_emp_SearchEngines = this.g_objStoredProcCollection.sp_getMajorTables("tblAreaSpMajor");
            }
            else
            {
                this.dset_emp_SearchEngines = this.g_objStoredProcCollection.sp_getMajorTables("tblAreaSpMajorInActive");
            }
   

        }


        private void LoadingrefresherOrb()
        {
            this.TblAreaEntity.Mode = "";
        if (this.textBox1.Text == "data Already Save!")
        {
                this.toolStripbtnEdit.Visible = false;
        }
        else if (textBox1.Text == "Gerard Singian")
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



        private void showStoreArea()    
        {
            try
            {

                this.xClass.fillDataGridView(this.dgvRawMats, "tblAreaSpMinor", this.dSet);

                this.lbltotalrecords.Text = this.dgvRawMats.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.dgvRawMats.Columns["area_id"].Visible = false;
            this.dgvRawMats.Columns["is_active"].Visible = false;


        }

        private void showStoreAreaInActive()
        {
            try
            {

                this.xClass.fillDataGridView(this.dgvRawMats, "tblAreaSpMinor_InActive", this.dSet);

                this.lbltotalrecords.Text = this.dgvRawMats.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.dgvRawMats.Columns["area_id"].Visible = false;
            this.dgvRawMats.Columns["is_active"].Visible = false;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            frmAreaManagement_Load(sender, e);
        }

        private void matBtnNew_Click(object sender, EventArgs e)
        {
            this.TblAreaEntity.Mode = "add";

            this.materialBtnNew.Visible = false;
            this.toolStripbtnEdit.Visible = false;
            frmAddNewArea addNew = new frmAddNewArea(this, 
            this.sp_user_id, 
            this.TblAreaEntity.Area_Name,
            this.TblAreaEntity.Mode,
            this.p_id);
            addNew.ShowDialog();
        }

        private void dgvRawMats_CurrentCellChanged(object sender, EventArgs e)
        {
            this.showValueCell();
        }

        private void showValueCell()
        {
            if (this.dgvRawMats.Rows.Count > 0)
            {
                if (this.dgvRawMats.CurrentRow != null)
                {
                    if (this.dgvRawMats.CurrentRow.Cells["area_name"].Value != null)
                    {
                        p_id = Convert.ToInt32(this.dgvRawMats.CurrentRow.Cells["area_id"].Value);
                        this.TblAreaEntity.Aread_Id = Convert.ToInt32(this.dgvRawMats.CurrentRow.Cells["area_id"].Value);
                        this.TblAreaEntity.Area_Name = this.dgvRawMats.CurrentRow.Cells["area_name"].Value.ToString();


                    }
                }
            }
        }

        private void matBtnEdit_Click(object sender, EventArgs e)
        {
            this.TblAreaEntity.Mode = "edit";
            this.materialBtnNew.Visible = false;
            this.toolStripbtnEdit.Visible = false;
            frmAddNewArea addNew = new frmAddNewArea(this, 
                sp_user_id, 
                this.TblAreaEntity.Area_Name,
                 this.TblAreaEntity.Mode,
                p_id);
            addNew.ShowDialog();
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

                        dv.RowFilter = "area_name like '%" + txtSearch.Text + "%'";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    dgvRawMats.DataSource = dv;
                    lbltotalrecords.Text = dgvRawMats.RowCount.ToString();
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





        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.SearchMethodJarVarCallingSP();

            if (this.lbltotalrecords.Text == "0")
            {

            }
            else
            {
                this.doSearchInTextBoxCmb();
            }
            if (this.txtSearch.Text == "")
            {
                this.doSearchInTextBoxCmb();
            }
        }

  

        private void materialBtnNew_Click_1(object sender, EventArgs e)
        {
            this.TblAreaEntity.Mode = "ADD";

            this.materialBtnNew.Visible = false;
            this.toolStripbtnEdit.Visible = false;
            frmAddNewArea addNew = 
            new frmAddNewArea(this, 
            this.sp_user_id,
            this.TblAreaEntity.Area_Name,
            this.TblAreaEntity.Mode,
            this.p_id);
            addNew.ShowDialog();
        }

        private void toolStripbtnEdit_Click(object sender, EventArgs e)
        {
            this.TblAreaEntity.Mode = "EDIT";
            this.materialBtnNew.Visible = false;
            this.toolStripbtnEdit.Visible = false;
            frmAddNewArea addNew = new frmAddNewArea(this, 
            this.sp_user_id,
            this.TblAreaEntity.Area_Name,
            this.TblAreaEntity.Mode,
            this.p_id);
            addNew.ShowDialog();
        }

        private void matBtnDelete_Click(object sender, EventArgs e)
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
                        this.dSet = this.g_objStoredProcCollection
                            .sp_tblArea(
                            this.TblAreaEntity.Aread_Id,
                            this.TblAreaEntity.Area_Name,
                            this.TblAreaEntity.Added_By,
                            "",
                            "",
                            "",
                            "delete");

                        this.GlobalStatePopup.InactiveSuccessfully();
                        this.frmAreaManagement_Load(new object(), new System.EventArgs());

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

                        mode = "activate";

                        mode = "";


                        this.dSet.Clear();
                        this.dSet = this.g_objStoredProcCollection
                            .sp_tblArea(
                            this.TblAreaEntity.Aread_Id,
                            this.TblAreaEntity.Area_Name,
                            this.TblAreaEntity.Added_By,
                            "",
                            "",
                            "",
                            "activate");

                        this.GlobalStatePopup.ActivatedSuccessfully();
                        this.frmAreaManagement_Load(new object(), new System.EventArgs());

                    }


                }
                else
                {

                    this.toolStripbtnEdit.Visible = true;
                    return;
                }

            }

        }

        private void matRadioNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matRadioActive.Checked == true)
            {
                this.ConnectionInit();
                this.showStoreArea();
            }
            else
            {
                this.matBtnDelete.Text = "&Activate";
                this.ConnectionInit();
                this.showStoreAreaInActive();
            }


        }

        private void matRadioActive_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matRadioActive.Checked == true)
            {
                this.matBtnDelete.Text = "&InActive";
                this.ConnectionInit();
                this.showStoreArea();
            }
            else
            {
                this.ConnectionInit();
                this.showStoreAreaInActive();
            }


        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void matBtnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
