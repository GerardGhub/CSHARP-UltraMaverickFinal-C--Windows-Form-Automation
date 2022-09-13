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
    public partial class frmAVGOrderTrendSetup : MaterialForm
    {

        IStoredProcedures g_objStoredProcCollection = null;
        readonly myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        readonly Avg_Order_Trend AvgOrderTrendEntity = new Avg_Order_Trend();
        string mode = "";
        int temp_hid = 0;
        DateTime dNow = DateTime.Now;
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();


        DataSet dSet_temp = new DataSet();

        public frmAVGOrderTrendSetup()
        {
            InitializeComponent();
        }

        public string Sp_bind_selected { get; set; }
   
        public DataSet DSet { get => dSet; set => dSet = value; }

        private void frmAVGOrderTrendSetup_Load(object sender, EventArgs e)
        {
            this.CheckRadionActive();
            this.ConnetionString();
            myglobal.global_module = "Active"; // Mode for Searching
            this.showAVGTrendData();
            this.SearchMethodJarVarCallingSP();
            this.textBox1.Text = String.Empty;
        }
        //method for loading available_menus
        private void showAVGTrendData()     
        {
            try
            {
     
                myClass.fillDataGridView(dgvAVGOrderTrend, "avg_order_trend", DSet);
 
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
        private void CheckRadionActive()
        {
            this.matRadioActive.Checked = true;
        }

        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            dset_emp_SearchEngines.Clear();


            dset_emp_SearchEngines = g_objStoredProcCollection.sp_getMajorTables("avg_order_trend_major");


            this.dgvAVGOrderTrend.Columns["is_active"].Visible = false;
        }

        private void SearchMethodJarVarCallingSPInactive()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            dset_emp_SearchEngines.Clear();


            dset_emp_SearchEngines = g_objStoredProcCollection.sp_getMajorTables("avg_order_trend_inactive_major");
        
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

        



            this.AvgOrderTrendEntity.Mode = "ADD";
            FrmAddNewOrderTrend addNew =
            new FrmAddNewOrderTrend(this,
            userinfo.user_id,
            this.AvgOrderTrendEntity.Avg_Desc,
            this.AvgOrderTrendEntity.Avg_Days,
            this.AvgOrderTrendEntity.Mode,
            this.AvgOrderTrendEntity.Avg_Id);
            addNew.ShowDialog();

        }

        private void matBtnCancel_Click(object sender, EventArgs e)
        {
            
            //Mode of System
            this.mode = "";



            //Button Visibility
            this.matBtnEdit.Visible = true;
            this.matBtnSave.Visible = false;
            this.matBtnNew.Visible = true;

            this.matBtnCancel.Visible = false;


        }



        private void matBtnSave_Click(object sender, EventArgs e)
        {



        }






        private void matBtnEdit_Click(object sender, EventArgs e)
        {
            //Mode
            mode = "edit";

            //Button Controls Visibility
            matBtnDelete.Visible = false;
            matBtnCancel.Visible = true;
            matBtnNew.Visible = false;
            matBtnEdit.Visible = false;
            matBtnSave.Visible = true;



            this.AvgOrderTrendEntity.Mode = "EDIT";
            FrmAddNewOrderTrend addNew =
            new FrmAddNewOrderTrend(this,
            userinfo.user_id,
            this.AvgOrderTrendEntity.Avg_Desc,
            this.AvgOrderTrendEntity.Avg_Days,
            this.AvgOrderTrendEntity.Mode,
            this.AvgOrderTrendEntity.Avg_Id);
            addNew.ShowDialog();

        }

        private void dgvitemClass_CurrentCellChanged(object sender, EventArgs e)
        {
            this.showDataGridDataValueChanged();
        }
        private void showDataGridDataValueChanged()
        {
            if (this.dgvAVGOrderTrend.Rows.Count > 0)
            {
                if (this.dgvAVGOrderTrend.CurrentRow != null)
                {
                    if (this.dgvAVGOrderTrend.CurrentRow.Cells["avg_desc"].Value != null)
                    {
                        this.AvgOrderTrendEntity.Avg_Id = Convert.ToInt32(this.dgvAVGOrderTrend.CurrentRow.Cells["avg_id"].Value);
                        this.AvgOrderTrendEntity.Avg_Desc = this.dgvAVGOrderTrend.CurrentRow.Cells["avg_desc"].Value.ToString();
                        this.AvgOrderTrendEntity.Avg_Days = Convert.ToInt32(this.dgvAVGOrderTrend.CurrentRow.Cells["avg_days"].Value);
                        this.AvgOrderTrendEntity.Added_By = this.dgvAVGOrderTrend.CurrentRow.Cells["added_by"].Value.ToString();
                        this.AvgOrderTrendEntity.Date_Added = this.dgvAVGOrderTrend.CurrentRow.Cells["date_added"].Value.ToString();
                        this.AvgOrderTrendEntity.Updated_Date = this.dgvAVGOrderTrend.CurrentRow.Cells["updated_date"].Value.ToString();
                        this.AvgOrderTrendEntity.Updated_By = this.dgvAVGOrderTrend.CurrentRow.Cells["updated_by"].Value.ToString();
                
                    }
                }
            }
        }


        private void doSearchInTextBox()
        {
            try
            {
     
                if (this.dset_emp_SearchEngines.Tables.Count > 0)
                {
                    DataView dv = new DataView(this.dset_emp_SearchEngines.Tables[0]);
               

                        //Gerard Singian Developer Man
       
                


                    dv.RowFilter = "avg_desc like '%" + mattxtSearch.Text + "%'";

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
            if (this.Sp_bind_selected == "1")
            {
                this.SearchMethodJarVarCallingSP();
            }
            else
            {
                this.SearchMethodJarVarCallingSPInactive();
            }

            if (this.mattxtSearch.Text == String.Empty)
            {
                this.showAVGTrendData();
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
             
                    doSearchInTextBox();
           
                }

            }
            //End of Method of Searching
        }

        private void matRadioNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (matRadioActive.Checked == true)
            {
                this.Sp_bind_selected = "1";
                this.matBtnDelete.Text = "&InActive";

                this.showAVGTrendData();
                this.SearchMethodJarVarCallingSP();
            }
            else if (matRadioNotActive.Checked == true)
            {
                this.Sp_bind_selected = "0";
                this.matBtnDelete.Text = "&Activate";
                this.showAVGDataInActive();
                this.SearchMethodJarVarCallingSP();
            }
            else
            {

            }
        }

        private void showAVGDataInActive()      //method for loading available_menus
        {
            try
            {
            
                myClass.fillDataGridView(this.dgvAVGOrderTrend, "avg_order_trend_inactive_minor", DSet);

                this.lbltotalrecords.Text = this.dgvAVGOrderTrend.RowCount.ToString();
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
                this.Sp_bind_selected = "1";
                this.matBtnDelete.Text = "&InActive";

                this.showAVGTrendData();
 
            }
            else if (matRadioNotActive.Checked == true)
            {
                this.Sp_bind_selected = "0";
                this.matBtnDelete.Text = "&Activate";
                this.showAVGDataInActive();
     
            }
            else
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void matBtnDelete_Click(object sender, EventArgs e)
        {
            if (this.Sp_bind_selected == "1")
            {
                if (this.dgvAVGOrderTrend.Rows.Count > 0)
                {

                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you  to inactive the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                        mode = "delete";

                        dSet_temp.Clear();
                        dSet_temp = g_objStoredProcCollection
                            .sp_avg_order_trend(this.AvgOrderTrendEntity.Avg_Id,
                            "",
                            0,
                            "",
                            "",
                            this.AvgOrderTrendEntity.Updated_By,
                            this.AvgOrderTrendEntity.Updated_Date,
                            "delete");
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

                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you  to activate the Average Order", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        //Start of Forced Activated
                        DSet.Clear();
                        DSet = g_objStoredProcCollection.sp_avg_order_trend(0, 
                            this.AvgOrderTrendEntity.Avg_Desc,
                            this.AvgOrderTrendEntity.Avg_Days,
                            "", "", "", "", "check_if_already_have_activated_data");

                        if (DSet.Tables[0].Rows.Count > 0)
                        {
                            this.GlobalStatePopup.DataAlreadyExist();
                            //Buje Malakas
                            DSet.Clear();
                            DSet = g_objStoredProcCollection.sp_avg_order_trend(this.AvgOrderTrendEntity.Avg_Id, this.AvgOrderTrendEntity.Avg_Desc,
                                this.AvgOrderTrendEntity.Avg_Days,
                                "", "", "", "", "force_deactivated_the_actual_used");

                            //return;
                        }

                        //End of forced Activated

                        this.GlobalStatePopup.ActivatedSuccessfully();
                        this.frmAVGOrderTrendSetup_Load(sender, e);
                    }

                    else
                    {
                        return;
                    }






                }
            }
        }

        private void txtmatavgdescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void mattxtSearch_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.matBtnCancel_Click(sender, e);
            this.frmAVGOrderTrendSetup_Load(sender, e);
        }

        private void lbltotalrecords_TextChanged(object sender, EventArgs e)
        {
            if (this.matBtnDelete.Text == "&InActive")
            {
                this.matBtnDelete.Visible = false;
            }
            else
            {
                this.matBtnDelete.Visible = true;
            }
        }
    }
}
