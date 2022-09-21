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
using Tulpep.NotificationWindow;
using ULTRAMAVERICK.API.Entities;
using ULTRAMAVERICK.Forms.Dry_Warehouse.External.Store_Modal.Module.Setup.Modal;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    public partial class frmStoreOrderActivationRemarks : MaterialForm
    {

        IStoredProcedures g_objStoredProcCollection = null;
        readonly myclasses myClass = new myclasses();
        private DataSet dSet = new DataSet();
        readonly Store_Order_Activation_Remarks StoreOrderActivationRemarksEntity = new Store_Order_Activation_Remarks();

        string mode = "";


        DateTime dNow = DateTime.Now;
        Boolean ready = false;
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();

        DataSet dSet_temp = new DataSet();
        public frmStoreOrderActivationRemarks()
        {
            InitializeComponent();
        }


        public string sp_bind_selected { get; set; }
 
        private void frmStoreOrderCancelRemarks_Load(object sender, EventArgs e)
        {
            this.ShowDataActivated();
            this.ConnetionString();
            myglobal.global_module = "Active"; // Mode for Searching
            this.ShowDataStoreOrderActivationRemarks();
            this.SearchMethodJarVarCallingSP();
            this.TextBox1.Text = String.Empty;
        }

        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            dset_emp_SearchEngines.Clear();


            dset_emp_SearchEngines = this.g_objStoredProcCollection
                .sp_getMajorTables("store_order_activation_remarks_activated_major");

            this.VisibilityFalseForDataGridColumn();

        }
        private void VisibilityFalseForDataGridColumn()
        {

            this.dgvAVGOrderTrend.Columns["soar_is_active"].Visible = false;
        }

        //method for loading available_menus
        private void ShowDataStoreOrderActivationRemarks()
        {
            try
            {
             
                myClass.fillDataGridView(dgvAVGOrderTrend, "store_order_activation_remarks_activated_minor", dSet);
     
                lbltotalrecords.Text = dgvAVGOrderTrend.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void ShowDataStoreOrderDeactivatedRemarks()
        {
            try
            {
     
                myClass.fillDataGridView(dgvAVGOrderTrend, "store_order_activation_remarks_deactivated_minor", dSet);
       
                lbltotalrecords.Text = dgvAVGOrderTrend.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }


        private void ConnetionString()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections

        }
        private void ShowDataActivated()
        {
            this.matRadioActive.Checked = true;
        }

        private void matBtnNew_Click(object sender, EventArgs e)
        {
            //Mode
            this.mode = "add";
            //Edit
            this.matBtnEdit.Visible = false;
            //Cancel
            this.matBtnCancel.Visible = true;

            //Button Visibility
            this.matBtnNew.Visible = false;
            this.matBtnDelete.Visible = false;
            this.matBtnSave.Visible = true;
   



            this.StoreOrderActivationRemarksEntity.Mode = "ADD";
            FrmOrderActivationRemarks addNew =
            new FrmOrderActivationRemarks(this,
            userinfo.user_id,
            this.StoreOrderActivationRemarksEntity.Soar_Desc,
            this.StoreOrderActivationRemarksEntity.Soar_type,
            this.StoreOrderActivationRemarksEntity.Mode,
            this.StoreOrderActivationRemarksEntity.Soar_Id);
            addNew.ShowDialog();

        }
      
        

        private void matBtnSave_Click(object sender, EventArgs e)
        {



        }

        private void SaveProcessClicker()
        {
            ////Start
            //if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to commit the Information?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            //{
            //    if (this.txtmatRemarks.Text.Trim() == string.Empty)
            //    {
            //        this.GlobalStatePopup.FillRequiredFields();
            //        this.txtmatRemarks.Focus();
            //        return;
            //    }

            //    else
            //    {
            //        if (saveMode())
            //        {
            //            string tmode = mode;

            //            if (tmode == "add")
            //            {
            //                dgvAVGOrderTrend.CurrentCell = dgvAVGOrderTrend[0, dgvAVGOrderTrend.Rows.Count - 1];
            //                this.GlobalStatePopup.CommittedSuccessFully();
            //            }
            //            else
            //            {
            //                dgvAVGOrderTrend.CurrentCell = dgvAVGOrderTrend[0, temp_hid];

            //            }
            //            this.matBtnCancel_Click(new object(), new System.EventArgs());
            //            this.GlobalStatePopup.CommittedSuccessFully();
            //        }
            //        else

            //            this.MetroFinalSavingEntry();
            //        return;
            //    }
            //}

            //else
            //{
            //    return;
            //}
        }



  

        private void matBtnCancel_Click(object sender, EventArgs e)
        {
            //Mode of System
            this.mode = "";



            //Button Visibility
            this.matBtnEdit.Visible = true;
            this.matBtnSave.Visible = false;
            this.matBtnNew.Visible = true;
            this.matBtnDelete.Visible = true;
            this.matBtnCancel.Visible = false;


        }

        private void matBtnEdit_Click(object sender, EventArgs e)
        {
            //Mode
            mode = "edit";
       

            //Button Controls Visibility
            this.matBtnDelete.Visible = false;
            this.matBtnCancel.Visible = true;
            this.matBtnNew.Visible = false;
            this.matBtnEdit.Visible = false;
            this.matBtnSave.Visible = true;


            this.StoreOrderActivationRemarksEntity.Mode = "EDIT";
            FrmOrderActivationRemarks addNew =
            new FrmOrderActivationRemarks(this,
            userinfo.user_id,
            this.StoreOrderActivationRemarksEntity.Soar_Desc,
            this.StoreOrderActivationRemarksEntity.Soar_type,
            this.StoreOrderActivationRemarksEntity.Mode,
            this.StoreOrderActivationRemarksEntity.Soar_Id);
            addNew.ShowDialog();

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
                        this.StoreOrderActivationRemarksEntity.Soar_Id = Convert.ToInt32(this.dgvAVGOrderTrend.CurrentRow.Cells["soar_id"].Value);
                        this.StoreOrderActivationRemarksEntity.Soar_Desc = this.dgvAVGOrderTrend.CurrentRow.Cells["soar_desc"].Value.ToString();
                        this.StoreOrderActivationRemarksEntity.Soar_type = this.dgvAVGOrderTrend.CurrentRow.Cells["soar_type"].Value.ToString();
                        this.StoreOrderActivationRemarksEntity.Soar_Added_By = this.dgvAVGOrderTrend.CurrentRow.Cells["soar_added_by"].Value.ToString();
                        this.StoreOrderActivationRemarksEntity.Soar_Date_Added = this.dgvAVGOrderTrend.CurrentRow.Cells["soar_date_added"].Value.ToString();
                        this.StoreOrderActivationRemarksEntity.Soar_Updated_Date = this.dgvAVGOrderTrend.CurrentRow.Cells["soar_updated_date"].Value.ToString();
                        this.StoreOrderActivationRemarksEntity.Soar_Updated_By = this.dgvAVGOrderTrend.CurrentRow.Cells["soar_updated_by"].Value.ToString();

                    }
                }
            }
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
      



     
        private void matBtnDelete_Click(object sender, EventArgs e)
        {
            //Start
            if (this.sp_bind_selected == "1")
            {
                if (this.dgvAVGOrderTrend.Rows.Count > 0)
                {

                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you  to deactivate the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {

                        mode = "delete";
                        dSet_temp.Clear();
                        dSet_temp = g_objStoredProcCollection
                        .sp_store_order_activation_remarks(this.StoreOrderActivationRemarksEntity.Soar_Id,
                        "this.txtmatRemarks.Text.Trim()",
                        "this.matcmbType.Text.Trim()",
                        "",
                        "",
                        userinfo.user_id.ToString(),
                        "",
                        "delete");
                        this.GlobalStatePopup.InactiveSuccessfully();
                        this.frmStoreOrderCancelRemarks_Load(sender, e);
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

                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you  to activate the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        mode = "delete_activation";
                        dSet_temp.Clear();
                        dSet_temp = g_objStoredProcCollection
                        .sp_store_order_activation_remarks(this.StoreOrderActivationRemarksEntity.Soar_Id,
                        "this.txtmatRemarks.Text.Trim()",
                        "this.matcmbType.Text.Trim()",
                        "",
                        "",
                        userinfo.user_id.ToString(),
                        "",
                        "delete_activation");
                        this.GlobalStatePopup.ActivatedSuccessfully();
                        this.frmStoreOrderCancelRemarks_Load(sender, e);
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


            this.dset_emp_SearchEngines = g_objStoredProcCollection.sp_getMajorTables("store_order_activation_remarks_deactivated_major");

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
       
            if (this.matRadioActive.Checked == true)
            {
                this.SearchMethodJarVarCallingSP();
            }
            else
            {
                this.SearchMethodJarVarCallingSPInactive();
            }
            this.doSearchInTextBox();
      
       
        }

        private void matRadioNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (matRadioActive.Checked == true)
            {
                this.sp_bind_selected = "1";
                this.matBtnDelete.Text = "&InActive";

                this.ShowDataStoreOrderActivationRemarks();
                //this.SearchMethodJarVarCallingSP();
            }
            else if (matRadioNotActive.Checked == true)
            {
                this.sp_bind_selected = "0";
                this.matBtnDelete.Text = "&Activate";
                this.matBtnEdit.Visible = false;
                this.ShowDataStoreOrderDeactivatedRemarks();
                //this.SearchMethodJarVarCallingSP();
            }
            else
            {

            }
        }

        private void txtmatRemarks_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void dgvAVGOrderTrend_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check the value of the e.ColumnIndex property if you want to apply this formatting only so some rcolumns.
            if (e.Value != null)
            {
                e.Value = e.Value.ToString().ToUpper();
                e.FormattingApplied = true;
            }
        }

        private void mattxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            this.matBtnCancel_Click(sender,e);

            this.frmStoreOrderCancelRemarks_Load(sender, e);
        }
    }
}
