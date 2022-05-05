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

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Move_Order
{
    public partial class frmDryWarehouses : MaterialForm
    {
        myclasses xClass = new myclasses();

        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        IStoredProcedures objStorProc = null;
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();

        string mode = "";
        int p_id = 0;
        int temp_hid = 0;
        DateTime dNow = DateTime.Now;
        Boolean ready = false;


        DataSet dSet_temp = new DataSet();


        public frmDryWarehouses()
        {
            InitializeComponent();
        }

        public string sp_created_at { get; set; }
        public string sp_created_by { get; set; }
        public string sp_modified_at { get; set; }
        public string sp_modified_by { get; set; }
        public string sp_bind_selected { get; set; }

        private void frmWarehouses_Load(object sender, EventArgs e)
        {
            this.ShowDataActivated();
            this.ConnetionString();
            myglobal.global_module = "Active"; // Mode for Searching
            this.showWarehouseMasterData();
            this.SearchMethodJarVarCallingSP();
        }

        private void ConnetionString()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
        }
        private void ShowDataActivated()
        {
            this.matRadioActive.Checked = true;
        }


        private void showWarehouseMasterData()      //method for loading available_menus
        {
            try
            {
                ready = false;
                xClass.fillDataGridView(dgvWarehousing, "MoveOrder_Tblwarehouses", dSet);
                ready = true;
                lbltotalrecords.Text = dgvWarehousing.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            dset_emp_SearchEngines.Clear();


            dset_emp_SearchEngines = objStorProc.sp_getMajorTables("MoveOrder_Tblwarehouses_Active_Major");

        }

        private void matBtnNew_Click(object sender, EventArgs e)
        {
            this.mode = "add";
            this.matBtnEdit.Visible = false;
            this.matBtnCancel.Visible = true;
            this.txtmatDescription.Enabled = true;
            this.txtmatAccountTitle.Enabled = true;
            this.matBtnNew.Visible = false;
            this.txtmatDescription.Text = String.Empty;
            this.txtmatAccountTitle.Text = String.Empty;
            this.sp_modified_at = String.Empty;
            this.sp_modified_by = String.Empty;
            this.matBtnDelete.Visible = false;
            this.sp_created_at = (dNow.ToString("M/d/yyyy"));
            this.sp_created_by = userinfo.emp_name.ToUpper();

            this.matBtnSave.Visible = true;
            this.txtmatDescription.Select();
            this.txtmatDescription.Focus();
        }

        private void matBtnEdit_Click(object sender, EventArgs e)
        {
            this.mode = "edit";
            this.sp_modified_at = (dNow.ToString("M/d/yyyy"));
            this.sp_modified_by = userinfo.emp_name.ToUpper();
            this.matBtnDelete.Visible = false;
            this.matBtnCancel.Visible = true;
            this.matBtnNew.Visible = false;
            this.matBtnEdit.Visible = false;
            this.matBtnSave.Visible = true;
            this.txtmatDescription.Enabled = true;
            this.txtmatAccountTitle.Enabled = true;
            this.txtmatDescription.Focus();
        }

        private void matBtnSave_Click(object sender, EventArgs e)
        {
            if (this.txtmatDescription.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                return;
            }

            dSet.Clear();
            dSet = objStorProc.sp_Item_Class(0, txtmatDescription.Text, "", "", "", "", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                this.GlobalStatePopup.DataAlreadyExist();
                this.txtmatDescription.Focus();
                return;
            }
            else
            {
                this.metroSave_Click(sender, e);
            }
        }

        private void metroSave_Click(object sender, EventArgs e)
        {
            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to update the Information?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {



                if (txtmatDescription.Text.Trim() == string.Empty)
                {


                    this.GlobalStatePopup.FillRequiredFields();
                    this.txtmatDescription.Focus();
                    return;
                }

                if (txtmatAccountTitle.Text.Trim() == string.Empty)
                {


                    this.GlobalStatePopup.FillRequiredFields();
                    this.txtmatAccountTitle.Focus();
                    return;
                }

                else
                {
                    if (saveMode())
                    {

                        string tmode = mode;

                        if (tmode == "add")
                        {
                            dgvWarehousing.CurrentCell = dgvWarehousing[0, dgvWarehousing.Rows.Count - 1];
                            this.GlobalStatePopup.CommittedSuccessFully();
                        }
                        else
                        {
                            this.dgvWarehousing.CurrentCell = this.dgvWarehousing[0, temp_hid];

                        }
                        this.matBtnCancel_Click(sender, e);
                        this.GlobalStatePopup.CommittedSuccessFully();
                    }
                    else

                        metroFinalSaving_Click(sender, e);
                    return;
                }
            }

            else
            {
                return;
            }
        }


        public bool saveMode()      //method for saving of data base on mode (add,edit,delete)
        {

            if (mode == "add")
            {
                dSet.Clear();
                dSet = objStorProc.sp_Tblwarehouses(0, 
                    this.txtmatDescription.Text, 
                    this.txtmatAccountTitle.Text.Trim(), 
                    "", 
                    "", 
                    "getbyname");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    this.GlobalStatePopup.DataAlreadyExist();

                    this.txtmatDescription.Text = string.Empty;
                    this.txtmatDescription.Focus();

                    this.txtmatAccountTitle.Text = string.Empty;
                    this.txtmatAccountTitle.Focus();
                    return false;
                }
                else
                {

                    dSet.Clear();
                    dSet = objStorProc.sp_Tblwarehouses(0,
                    this.txtmatDescription.Text.Trim(),                        
                    this.txtmatAccountTitle.Text.Trim(),
                    this.sp_created_by,
                    this.sp_modified_at,
                    "add");

                    this.showWarehouseMasterData();


                    return true;
                }
            }
            else if (mode == "edit")
            {
                dSet.Clear();
                dSet = objStorProc.sp_Tblwarehouses(0, 
                    this.txtmatDescription.Text, 
                    this.txtmatAccountTitle.Text, 
                    "", "", "getbyname");

                dSet_temp.Clear();
                dSet_temp = objStorProc.sp_Tblwarehouses(p_id, 
                    this.txtmatDescription.Text, 
                    this.txtmatAccountTitle.Text.Trim(), 
                    "", 
                    "", 
                    "getbyid");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    int tmpID = Convert.ToInt32(dSet.Tables[0].Rows[0][0].ToString());
                    if (tmpID == p_id)
                    {
                        dSet.Clear();
                        dSet = objStorProc.sp_Tblwarehouses(p_id, 
                            this.txtmatDescription.Text.Trim(),
                            this.txtmatAccountTitle.Text.Trim(),                  
                           this.sp_modified_by,
                            this.sp_modified_at,
                            "edit");


                        this.GlobalStatePopup.CommittedSuccessFully();
                        this.showWarehouseMasterData();
                        mode = "";
                        matBtnCancel_Click(new object(), new System.EventArgs());
                        return true;
                    }
                    else
                    {
                       
                        this.txtmatDescription.Text = String.Empty;
                        this.txtmatDescription.Focus();

                        this.txtmatAccountTitle.Text = String.Empty;
                        this.txtmatAccountTitle.Focus();
                        return false;
                    }
                }
                else
                {

                dSet.Clear();
                dSet = objStorProc.sp_Tblwarehouses(p_id, 
                this.txtmatDescription.Text.Trim(),
                this.txtmatAccountTitle.Text.Trim(),                     
                this.sp_modified_by,
                this.sp_modified_at,
                "edit");

                this.GlobalStatePopup.CommittedSuccessFully();
                this.showWarehouseMasterData();
                mode = "";
                matBtnCancel_Click(new object(), new System.EventArgs());

                }
            }
            else if (mode == "delete")
            {

                if (this.sp_bind_selected == "1")
                {

                    dSet_temp.Clear();
                    dSet_temp = objStorProc.sp_Tblwarehouses(p_id, 
                        this.txtmatDescription.Text, 
                        this.txtmatAccountTitle.Text.Trim(), 
                        "", 
                        "", "delete");

                    return true;
                }
                else
                {
                    dSet_temp.Clear();
                    dSet_temp = objStorProc.sp_Tblwarehouses(p_id, 
                    this.txtmatDescription.Text, 
                    this.txtmatAccountTitle.Text.Trim(), 
                    "", 
                    "", 
                    "delete_activation");
                    this.matRadioActive.Checked = true;
                    return true;
                }
            }
            return false;
        }



        private void metroFinalSaving_Click(object sender, EventArgs e)
        {
            if (txtmatDescription.Text.Trim() == string.Empty)
            {

                this.GlobalStatePopup.FillRequiredFields();
                txtmatDescription.Focus();

                return;
            }
            else
            {
                if (this.saveMode())
                {
                    this.GlobalStatePopup.DataAlreadyExist();
                    string tmode = mode;

                    if (tmode == "add")
                    {
                        this.dgvWarehousing.CurrentCell = this.dgvWarehousing[0, dgvWarehousing.Rows.Count - 1];

                    }
                    else
                    {
                        this.dgvWarehousing.CurrentCell = this.dgvWarehousing[0, temp_hid];
                    }
                    matBtnCancel_Click(sender, e);
                }
                else

                    return;
            }
        }

        private void matBtnCancel_Click(object sender, EventArgs e)
        {
            this.matBtnCancel.Visible = false;
            this.mode = "";
            this.sp_created_at = String.Empty;
            this.sp_created_by = String.Empty;
            this.matBtnEdit.Visible = true;
            this.matBtnSave.Visible = false;
            this.matBtnNew.Visible = true;
            this.matBtnDelete.Visible = true;
            this.txtmatDescription.Enabled = false;
            this.txtmatAccountTitle.Enabled = false;
        }

        private void dgvitemClass_CurrentCellChanged(object sender, EventArgs e)
        {
            if (this.dgvWarehousing.Rows.Count > 0)
            {
                if (this.dgvWarehousing.CurrentRow != null)
                {
                    if (this.dgvWarehousing.CurrentRow.Cells["wh_description"].Value != null)
                    {
                        this.p_id = Convert.ToInt32(this.dgvWarehousing.CurrentRow.Cells["wh_id"].Value);
                        this.txtmatDescription.Text = this.dgvWarehousing.CurrentRow.Cells["wh_description"].Value.ToString();
                        this.txtmatAccountTitle.Text = this.dgvWarehousing.CurrentRow.Cells["wh_account_title"].Value.ToString();
                        this.sp_created_by = this.dgvWarehousing.CurrentRow.Cells["wh_added_by"].Value.ToString();
                        this.sp_created_at = this.dgvWarehousing.CurrentRow.Cells["wh_date_added"].Value.ToString();
       
                    }
                }
            }
        }

        private void SearchMethodJarVarCallingSPInactive()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            this.dset_emp_SearchEngines.Clear();
            this.dset_emp_SearchEngines = objStorProc.sp_getMajorTables("MoveOrder_Tblwarehouses_Inactive");
        }


        private void doSearchInTextBox()
        {
            try
            {


                if (dset_emp_SearchEngines.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp_SearchEngines.Tables[0]);
                 
                    if (myglobal.global_module == "Active")
                    {
                        dv.RowFilter = "wh_description like '%" + mattxtSearch.Text + "%' or wh_account_title like '%" + mattxtSearch.Text + "%' ";
                    }
               
                    dgvWarehousing.DataSource = dv;
                    lbltotalrecords.Text = dgvWarehousing.RowCount.ToString();
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



        private void mattxtSearch_TextChanged(object sender, EventArgs e)
        {
            this.ConnetionString();
            if (sp_bind_selected == "1")
            {
                this.SearchMethodJarVarCallingSP();
            }
            else
            {
                this.SearchMethodJarVarCallingSPInactive();
            }

            if (this.mattxtSearch.Text == "")
            {
                this.showWarehouseMasterData();
            }
            if (this.lbltotalrecords.Text == "0")
            {

            }
            else
            {
                if (mode == "add")
                {

                }
                else
                {
                    doSearchInTextBox();
                }

            }
        }

        private void showWarehouseMasterDataInActive()      //method for loading available_menus
        {
            try
            {
                ready = false;
                xClass.fillDataGridView(dgvWarehousing, "MoveOrder_Tblwarehouses_Inactive_MinorSP", dSet);
                ready = true;
                lbltotalrecords.Text = dgvWarehousing.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }   


        private void matRadioActive_CheckedChanged(object sender, EventArgs e)
        {
            if (matRadioActive.Checked == true)
            {
                this.sp_bind_selected = "1";
                this.matBtnDelete.Text = "&InActive";

                this.showWarehouseMasterData();

            }
            else if (matRadioNotActive.Checked == true)
            {
                this.sp_bind_selected = "0";
                this.matBtnDelete.Text = "&Activate";
                this.showWarehouseMasterDataInActive();

            }
            else
            {

            }
        }

        private void matRadioNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (matRadioActive.Checked == true)
            {
                this.sp_bind_selected = "1";
                this.matBtnDelete.Text = "&InActive";

                this.showWarehouseMasterData();
                this.SearchMethodJarVarCallingSP();
            }
            else if (matRadioNotActive.Checked == true)
            {
                this.sp_bind_selected = "0";
                this.matBtnDelete.Text = "&Activate";
                this.showWarehouseMasterDataInActive();
                this.SearchMethodJarVarCallingSP();
            }
            else
            {

            }
        }

        private void matBtnDelete_Click(object sender, EventArgs e)
        {
            if (this.sp_bind_selected == "1")
            {

                if (this.dgvWarehousing.Rows.Count > 0)
                {

                    if (MetroFramework.MetroMessageBox.Show(this, "Inactive the masterlist", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                        mode = "delete";

                        if (this.saveMode())
                        {
                            this.GlobalStatePopup.InactiveSuccessfully();
                            this.showWarehouseMasterData();

                            this.matBtnCancel_Click("", e);
                        }
                    }

                    else
                    {
                        return;
                    }






                }

            }
            else
            {
                if (dgvWarehousing.Rows.Count > 0)
                {

                    if (MetroFramework.MetroMessageBox.Show(this, "Activate the masterlist?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                        this.mode = "delete";

                        if (this.saveMode())
                        {
                            this.GlobalStatePopup.ActivatedSuccessfully();
                            this.showWarehouseMasterData();

                            this.matBtnCancel_Click("", e);

                        }
                    }

                    else
                    {
                        return;
                    }



                }
            }
        }

        private void dgvitemClass_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvWarehousing.ClearSelection();
        }
    }
}
