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

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Internal.Preparation
{
    public partial class frmInternalOrderActivationRemarks : MaterialForm
    {
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();

        string mode = "";
        int p_id = 0;
        int temp_hid = 0;
        DateTime dNow = DateTime.Now;
        Boolean ready = false;
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();

        DataSet dSet_temp = new DataSet();

        public frmInternalOrderActivationRemarks()
        {
            InitializeComponent();
        }
        public string sp_created_at { get; set; }
        public string sp_created_by { get; set; }
        public string sp_updated_date { get; set; }
        public string sp_updated_by { get; set; }
        public string sp_bind_selected { get; set; }
        public string sp_added_by { get; set; }
        public string sp_date_added { get; set; }

        private void frmInternalOrderActivationRemarks_Load(object sender, EventArgs e)
        {
            this.ShowDataActivated();
            this.ConnetionString();
            myglobal.global_module = "Active"; // Mode for Searching
            this.ShowDataStoreOrderActivationRemarks();
            this.SearchMethodJarVarCallingSP();

        }

        //method for loading available_menus
        private void ShowDataStoreOrderActivationRemarks()
        {
            try
            {
                this.ready = false;
                xClass.fillDataGridView(this.dgvAVGOrderTrend, "internal_order_activation_remarks_activated_minor", dSet);
                this.ready = true;
                this.lbltotalrecords.Text = this.dgvAVGOrderTrend.RowCount.ToString();
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


            dset_emp_SearchEngines = objStorProc.sp_getMajorTables("internal_order_activation_remarks_activated_major");

            this.VisibilityFalseForDataGridColumn();

        }

        private void VisibilityFalseForDataGridColumn()
        {

            this.dgvAVGOrderTrend.Columns["soar_is_active"].Visible = false;
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

        private void matRadioActive_CheckedChanged(object sender, EventArgs e)
        {
            if (matRadioActive.Checked == true)
            {
                this.sp_bind_selected = "1";
                this.matBtnDelete.Text = "&InActive";
                this.matBtnEdit.Visible = true;
                this.ShowDataStoreOrderActivationRemarks();
                //this.SearchMethodJarVarCallingSP();
            }
            else if (matRadioNotActive.Checked == true)
            {
                this.sp_bind_selected = "0";
                this.matBtnDelete.Text = "&Activate";
                this.ShowDataStoreOrderDeactivatedRemarks();
                //this.SearchMethodJarVarCallingSP();
            }
            else
            {

            }
        }



        private void ShowDataStoreOrderDeactivatedRemarks()
        {
            try
            {
                xClass.fillDataGridView(this.dgvAVGOrderTrend, "internal_order_activation_remarks_deactivated_minor", dSet);       
                this.lbltotalrecords.Text = this.dgvAVGOrderTrend.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void matRadioNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (matRadioActive.Checked == true)
            {
                this.sp_bind_selected = "1";
                this.matBtnDelete.Text = "&InActive";

                this.ShowDataStoreOrderActivationRemarks();
            
            }
            else if (matRadioNotActive.Checked == true)
            {
                this.sp_bind_selected = "0";
                this.matBtnDelete.Text = "&Activate";
                this.matBtnEdit.Visible = false;
                this.ShowDataStoreOrderDeactivatedRemarks();
           
            }
            else
            {

            }
        }

        private void dgvAVGOrderTrend_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                e.Value = e.Value.ToString().ToUpper();
                e.FormattingApplied = true;
            }
        }

        private void dgvAVGOrderTrend_CurrentCellChanged(object sender, EventArgs e)
        {
            this.showDataGridDataValueChanged();
        }

        private void showDataGridDataValueChanged()
        {
            if (this.dgvAVGOrderTrend.Rows.Count > 0)
            {
                if (this.dgvAVGOrderTrend.CurrentRow != null)
                {
                    if (this.dgvAVGOrderTrend.CurrentRow.Cells["soar_desc"].Value != null)
                    {
                        p_id = Convert.ToInt32(this.dgvAVGOrderTrend.CurrentRow.Cells["soar_id"].Value);
                        this.txtmatRemarks.Text = this.dgvAVGOrderTrend.CurrentRow.Cells["soar_desc"].Value.ToString();
                        this.matcmbType.Text = this.dgvAVGOrderTrend.CurrentRow.Cells["soar_type"].Value.ToString();
                        this.sp_added_by = this.dgvAVGOrderTrend.CurrentRow.Cells["soar_added_by"].Value.ToString();
                        this.sp_date_added = this.dgvAVGOrderTrend.CurrentRow.Cells["soar_date_added"].Value.ToString();
                        this.sp_updated_date = this.dgvAVGOrderTrend.CurrentRow.Cells["soar_updated_date"].Value.ToString();
                        this.sp_updated_by = this.dgvAVGOrderTrend.CurrentRow.Cells["soar_updated_by"].Value.ToString();

                    }
                }
            }
        }

        private void matBtnNew_Click(object sender, EventArgs e)
        {
            //Mode
            this.mode = "add";
            //Edit
            this.matBtnEdit.Visible = false;
            //Cancel
            this.matBtnCancel.Visible = true;
            //TextBVox Enabled True
            this.txtmatRemarks.Enabled = true;
            this.matcmbType.Enabled = true;
            //Button Visibility
            this.matBtnNew.Visible = false;
            this.matBtnDelete.Visible = false;
            this.matBtnSave.Visible = true;
            //String Textbox Empty
            this.txtmatRemarks.Text = String.Empty;
            this.sp_updated_date = String.Empty;
            this.sp_updated_by = String.Empty;
            this.matcmbType.Text = String.Empty;
            //Binding User Session Date ETC
            this.sp_date_added = (dNow.ToString("M/d/yyyy"));
            this.sp_added_by = userinfo.emp_name.ToUpper();

            //Focus Events 
            this.txtmatRemarks.Select();
            this.txtmatRemarks.Focus();
        }

        private void matBtnSave_Click(object sender, EventArgs e)
        {
            if (this.txtmatRemarks.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.txtmatRemarks.Focus();
                return;
            }
            else if (this.matcmbType.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.matcmbType.Focus();
                return;
            }

            dSet.Clear();
            dSet = objStorProc.sp_internal_order_activation_remarks(0,
                this.txtmatRemarks.Text.Trim(),
               this.matcmbType.Text.Trim(), "", "", "", "", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                this.GlobalStatePopup.DataAlreadyExist();

                this.txtmatRemarks.Text = String.Empty;
                this.matcmbType.Text = String.Empty;
                this.txtmatRemarks.Focus();
                this.matBtnCancel_Click(sender, e);
                return;
            }
            else
            {
                this.SaveProcessClicker();
            }
        }

        public bool saveMode()      //method for saving of data base on mode (add,edit,delete)
        {

            if (mode == "add")
            {
                dSet.Clear();
                dSet = objStorProc.sp_internal_order_activation_remarks(0,
                    this.txtmatRemarks.Text.Trim(),
                    this.matcmbType.Text.Trim(),
                    "",
                    "",
                    "",
                    "",
                    "getbyname");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    this.GlobalStatePopup.DataAlreadyExist();

                    this.txtmatRemarks.Text = string.Empty;
                    this.txtmatRemarks.Focus();
                    return false;
                }
                else
                {

                    dSet.Clear();
                    dSet = objStorProc.sp_internal_order_activation_remarks(0,
                        this.txtmatRemarks.Text.Trim(),
                        this.matcmbType.Text.Trim(),
                        this.sp_added_by,
                        this.sp_date_added,
                        "",
                        "",
                        "add");

                    this.ShowDataStoreOrderActivationRemarks();


                    return true;
                }
            }
            else if (this.mode == "edit")
            {
                this.dSet.Clear();
                this.dSet = objStorProc.sp_internal_order_activation_remarks(0,
                this.txtmatRemarks.Text.Trim(),
                this.matcmbType.Text.Trim(),
                this.sp_added_by,
                this.sp_date_added,
                this.sp_updated_by,
                this.sp_updated_date,
                "getbyname");

                this.dSet_temp.Clear();
                this.dSet_temp = objStorProc.sp_internal_order_activation_remarks(
                p_id,
                this.txtmatRemarks.Text.Trim(),
                this.matcmbType.Text.Trim(),
                "", 
                "",
                "",
                "",
                "getbyid");

                if (this.dSet.Tables[0].Rows.Count > 0)
                {
                    int tmpID = Convert.ToInt32(dSet.Tables[0].Rows[0][0].ToString());
                    if (tmpID == p_id)
                    {
                        dSet.Clear();
                        dSet = objStorProc.sp_internal_order_activation_remarks(p_id,
                        this.txtmatRemarks.Text.Trim(),
                        this.matcmbType.Text.Trim(),
                        this.sp_added_by,
                        this.sp_date_added,
                        this.sp_updated_by,
                        this.sp_updated_date,
                        "edit");
                        this.GlobalStatePopup.CommittedSuccessFully();
                        this.ShowDataStoreOrderActivationRemarks();
                        this.mode = "";
                        matBtnCancel_Click(new object(), new System.EventArgs());
                        return true;
                    }
                    else
                    {

                        this.txtmatRemarks.Text = String.Empty;
                        this.txtmatRemarks.Focus();
                        return false;
                    }
                }
                else
                {
                    dSet.Clear();
                    dSet = objStorProc.sp_internal_order_activation_remarks(
                    this.p_id,
                    this.txtmatRemarks.Text.Trim(),
                    this.matcmbType.Text.Trim(),
                    this.sp_added_by,
                    this.sp_date_added,
                    this.sp_updated_by,
                    this.sp_updated_date, "edit");
                    this.GlobalStatePopup.UpdatedSuccessfully();
                    this.ShowDataStoreOrderActivationRemarks();
                    this.mode = "";
                    matBtnCancel_Click(new object(), new System.EventArgs());
                }
            }
            else if (this.mode == "delete")
            {
                this.sp_updated_date = (dNow.ToString("M/d/yyyy"));
                this.sp_updated_by = userinfo.emp_name.ToUpper();

                if (this.sp_bind_selected == "1")
                {

                    dSet_temp.Clear();
                    dSet_temp = objStorProc.sp_internal_order_activation_remarks(p_id,
                    this.txtmatRemarks.Text.Trim(),
                    this.matcmbType.Text.Trim(),
                    "",
                    "",
                    this.sp_updated_by,
                    this.sp_updated_date,
                    "delete");

                    return true;
                }
                else
                {
                    this.dSet_temp.Clear();
                    this.dSet_temp = objStorProc.sp_internal_order_activation_remarks(
                    this.p_id,
                    this.txtmatRemarks.Text.Trim(),
                    this.matcmbType.Text.Trim(), "", "",
                    this.sp_updated_by,
                    this.sp_updated_date,
                    "delete_activation");
                    this.matRadioActive.Checked = true;
                    return true;
                }
            }
            return false;
        }



        private void SaveProcessClicker()
        {
            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to commit the Information?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (this.txtmatRemarks.Text.Trim() == string.Empty)
                {
                    this.GlobalStatePopup.FillRequiredFields();
                    this.txtmatRemarks.Focus();
                    return;
                }

                else
                {
                    if (this.saveMode())
                    {
                        string tmode = mode;

                        if (tmode == "add")
                        {
                            this.dgvAVGOrderTrend.CurrentCell = this.dgvAVGOrderTrend[0, this.dgvAVGOrderTrend.Rows.Count - 1];
                            this.GlobalStatePopup.CommittedSuccessFully();
                        }
                        else
                        {
                            this.dgvAVGOrderTrend.CurrentCell = this.dgvAVGOrderTrend[0, temp_hid];

                        }
                        this.matBtnCancel_Click(new object(), new System.EventArgs());
                        this.GlobalStatePopup.CommittedSuccessFully();
                    }
                    else

                        this.MetroFinalSavingEntry();
                    return;
                }
            }

            else
            {
                return;
            }
        }



        private void MetroFinalSavingEntry()
        {
            if (this.txtmatRemarks.Text.Trim() == string.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.txtmatRemarks.Focus();
            }
            else
            {
                if (this.saveMode())
                {
                    this.GlobalStatePopup.DataAlreadyExist();
                    string tmode = mode;

                    if (tmode == "add")
                    {
                        this.dgvAVGOrderTrend.CurrentCell = this.dgvAVGOrderTrend[0, this.dgvAVGOrderTrend.Rows.Count - 1];

                    }
                    else
                    {
                        this.dgvAVGOrderTrend.CurrentCell = this.dgvAVGOrderTrend[0, temp_hid];
                    }
                    this.matBtnCancel_Click(new object(), new System.EventArgs());
                }
                else

                    return;
            }
        }


        private void matBtnCancel_Click(object sender, EventArgs e)
        {
            //Mode of System
            this.mode = "";

            //String Empty
            this.sp_created_at = String.Empty;
            this.sp_created_by = String.Empty;

            //Button Visibility
            this.matBtnEdit.Visible = true;
            this.matBtnSave.Visible = false;
            this.matBtnNew.Visible = true;
            this.matBtnDelete.Visible = true;
            this.matBtnCancel.Visible = false;

            //Textbox Enabled Conditional Statement
            this.txtmatRemarks.Enabled = false;
            this.matcmbType.Enabled = false;
        }

        private void matBtnEdit_Click(object sender, EventArgs e)
        {
            //Mode
            mode = "edit";
            //System Binding
            this.sp_updated_date = (dNow.ToString("M/d/yyyy"));
            this.sp_updated_by = userinfo.emp_name.ToUpper();
            //Button Controls Visibility
            this.matBtnDelete.Visible = false;
            this.matBtnCancel.Visible = true;
            this.matBtnNew.Visible = false;
            this.matBtnEdit.Visible = false;
            this.matBtnSave.Visible = true;
            //Button Enabled and TextBox
            this.txtmatRemarks.Enabled = true;
            this.matcmbType.Enabled = true;
            this.txtmatRemarks.Focus();
        }

        private void matBtnDelete_Click(object sender, EventArgs e)
        {
            //Start
            if (this.sp_bind_selected == "1")
            {
                if (this.dgvAVGOrderTrend.Rows.Count > 0)
                {

                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you  to inactive the information?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                        mode = "delete";

                        if (this.saveMode())
                        {
                            this.GlobalStatePopup.InactiveSuccessfully();
                            this.ShowDataStoreOrderActivationRemarks();
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
                if (this.dgvAVGOrderTrend.Rows.Count > 0)
                {

                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you  to activate the information", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                        this.mode = "delete";

                        if (this.saveMode())
                        {
                            this.GlobalStatePopup.ActivatedSuccessfully();
                            this.ShowDataStoreOrderActivationRemarks();

                            this.matBtnCancel_Click("", e);

                        }
                    }

                    else
                    {
                        return;
                    }






                }
            }
            //End
        }

        private void SearchMethodJarVarCallingSPInactive()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            this.dset_emp_SearchEngines.Clear();


            this.dset_emp_SearchEngines = objStorProc.sp_getMajorTables("internal_order_activation_remarks_deactivated_major");

        }

        private void doSearchInTextBox()
        {
            try
            {

                if (this.dset_emp_SearchEngines.Tables.Count > 0)
                {
                    DataView dv = new DataView(this.dset_emp_SearchEngines.Tables[0]);

                    //Gerard Singian Developer Man
                    dv.RowFilter = "soar_desc like '%" + mattxtSearch.Text + "%'";

                    this.dgvAVGOrderTrend.DataSource = dv;
                    this.lbltotalrecords.Text = this.dgvAVGOrderTrend.RowCount.ToString();
                }
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Invalid character found xxx!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found 2 s.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
        }


        private void mattxtSearch_TextChanged(object sender, EventArgs e)
        {
            this.ConnetionString();
            if (this.sp_bind_selected == "1")
            {
                this.SearchMethodJarVarCallingSP();
            }
            else
            {
                this.SearchMethodJarVarCallingSPInactive();
            }

            if (this.mattxtSearch.Text == String.Empty)
            {
                this.ShowDataStoreOrderActivationRemarks();
                return;
            }
            if (this.lbltotalrecords.Text == "0")
            {

            }
            else
            {

                if (this.mode == "add")
                {

                }
                else
                {

                    this.doSearchInTextBox();

                }

            }
        }
    }
}
