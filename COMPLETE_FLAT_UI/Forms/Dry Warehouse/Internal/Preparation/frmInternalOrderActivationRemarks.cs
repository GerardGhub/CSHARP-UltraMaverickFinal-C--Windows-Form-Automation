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
using ULTRAMAVERICK.Forms.Dry_Warehouse.External.Store_Modal.Module.Setup.Modal;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Internal.Preparation
{
    public partial class frmInternalOrderActivationRemarks : MaterialForm
    {

        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        readonly Internal_Order_Activation_Remarks InternalOrderActivationRemarksEntity = new Internal_Order_Activation_Remarks();
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        string mode = "";

        DateTime dNow = DateTime.Now;

        DataSet dSet_temp = new DataSet();

        public frmInternalOrderActivationRemarks()
        {
            InitializeComponent();
        }

        public string sp_bind_selected { get; set; }


        private void frmInternalOrderActivationRemarks_Load(object sender, EventArgs e)
        {
            this.ShowDataActivated();
            this.ConnetionString();
            myglobal.global_module = "Active"; // Mode for Searching
            this.ShowDataStoreOrderActivationRemarks();
            this.SearchMethodJarVarCallingSP();
            this.TextBox1.Text = String.Empty;
        }


        private void ShowDataStoreOrderActivationRemarks()
        {
            try
            {

                myClass.fillDataGridView(this.dgvAVGOrderTrend, "internal_order_activation_remarks_activated_minor", dSet);

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


            dset_emp_SearchEngines = g_objStoredProcCollection.sp_getMajorTables("internal_order_activation_remarks_activated_major");

            this.VisibilityFalseForDataGridColumn();

        }

        private void VisibilityFalseForDataGridColumn()
        {

            this.dgvAVGOrderTrend.Columns["soar_is_active"].Visible = false;
        }


        private void ConnetionString()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections

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
          
            }
            else if (matRadioNotActive.Checked == true)
            {
                this.sp_bind_selected = "0";
                this.matBtnDelete.Text = "&Activate";
                this.ShowDataStoreOrderDeactivatedRemarks();
               
            }
            else
            {

            }
        }



        private void ShowDataStoreOrderDeactivatedRemarks()
        {
            try
            {
                myClass.fillDataGridView(this.dgvAVGOrderTrend, "internal_order_activation_remarks_deactivated_minor", dSet);       
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
                        this.InternalOrderActivationRemarksEntity.Soar_id = Convert.ToInt32(this.dgvAVGOrderTrend.CurrentRow.Cells["soar_id"].Value);
                        this.InternalOrderActivationRemarksEntity.Soar_Desc = this.dgvAVGOrderTrend.CurrentRow.Cells["soar_desc"].Value.ToString();
                        this.InternalOrderActivationRemarksEntity.Soar_Type = this.dgvAVGOrderTrend.CurrentRow.Cells["soar_type"].Value.ToString();
                        this.InternalOrderActivationRemarksEntity.Soar_Added_By = this.dgvAVGOrderTrend.CurrentRow.Cells["soar_added_by"].Value.ToString();
                        this.InternalOrderActivationRemarksEntity.Soar_Date_Added = this.dgvAVGOrderTrend.CurrentRow.Cells["soar_date_added"].Value.ToString();
                        this.InternalOrderActivationRemarksEntity.Soar_Updated_Date = this.dgvAVGOrderTrend.CurrentRow.Cells["soar_updated_date"].Value.ToString();
                        this.InternalOrderActivationRemarksEntity.Soar_Updated_By = this.dgvAVGOrderTrend.CurrentRow.Cells["soar_updated_by"].Value.ToString();

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

            //Button Visibility
            this.matBtnNew.Visible = false;
            this.matBtnDelete.Visible = false;
            this.matBtnSave.Visible = true;

            this.InternalOrderActivationRemarksEntity.Mode = "ADD";
            FrmMrsActivationRemarks addNew =
            new FrmMrsActivationRemarks(this,
            userinfo.user_id,
            this.InternalOrderActivationRemarksEntity.Soar_Desc,
            this.InternalOrderActivationRemarksEntity.Soar_Type,
            this.InternalOrderActivationRemarksEntity.Mode,
            this.InternalOrderActivationRemarksEntity.Soar_id);
            addNew.ShowDialog();

        }

        private void matBtnSave_Click(object sender, EventArgs e)
        {
      
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



            this.InternalOrderActivationRemarksEntity.Mode = "EDIT";
            FrmMrsActivationRemarks addNew =
            new FrmMrsActivationRemarks(this,
            userinfo.user_id,
            this.InternalOrderActivationRemarksEntity.Soar_Desc,
            this.InternalOrderActivationRemarksEntity.Soar_Type,
            this.InternalOrderActivationRemarksEntity.Mode,
            this.InternalOrderActivationRemarksEntity.Soar_id);
            addNew.ShowDialog();

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
                        dSet_temp.Clear();
                        dSet_temp = g_objStoredProcCollection
                            .sp_internal_order_activation_remarks(this.InternalOrderActivationRemarksEntity.Soar_id,
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "delete");

                        this.GlobalStatePopup.InactiveSuccessfully();
                     
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

                        //this.mode = "delete";

                        //if (this.saveMode())
                        //{
                        //    this.GlobalStatePopup.ActivatedSuccessfully();
                        //    this.ShowDataStoreOrderActivationRemarks();

                        //    this.matBtnCancel_Click("", e);

                        //}
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


            this.dset_emp_SearchEngines = g_objStoredProcCollection.sp_getMajorTables("internal_order_activation_remarks_deactivated_major");

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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            this.matBtnCancel_Click(sender, e);
            this.frmInternalOrderActivationRemarks_Load(sender, e);
        }
    }
}
