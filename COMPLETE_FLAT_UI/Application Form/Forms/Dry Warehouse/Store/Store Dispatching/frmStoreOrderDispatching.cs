﻿using COMPLETE_FLAT_UI.Models;
using CrystalDecisions.CrystalReports.Engine;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Windows.Forms;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Report;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Dispatching
{
    public partial class frmStoreOrderDispatching : MaterialForm
    {
        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        public DataSet dset = new DataSet();
        DataSet dset2 = new DataSet();
        DataSet dset3 = new DataSet();
        DataSet dSet = new DataSet();
        int counterstrike = 0;
        string Rpt_Path = "";
        ReportDocument rpt = new ReportDocument();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        public frmStoreOrderDispatching()
        {
            InitializeComponent();
        }

        public string ConvertedDateToString { get; set; }
        public int Sp_user_id { get; set; }
        public string sp_final_id { get; set; }
        public string Sp_Fox { get; set; }
        public string Sp_Selected_Item { get; set; }
        public string Sp_Category { get; set; }
        public string Sp_UserName { get; set; }
        public int Sp_ParentId { get; set; }
        public string Sp_PreparationDate { get; set; }

        private void ConnectionInit()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections();
        }



        private void frmStoreOrderDispatching_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();         
            this.loadPreparationDateDropdown();
            this.useStateWindowLoad();
            this.ShowDataActivated();
            if (this.matCmbPreparationDate.Text != String.Empty)
            {
                this.matCmbPreparationDate_SelectionChangeCommitted(sender, e);
            }
            if (this.matCmbPreparationDate.Text == String.Empty)
            {
           
                this.lbltotaldata.Text = "0";
                this.matCmbPreparationDate.Enabled = false;
                this.MatcmbCategory.Enabled = false;
                this.MetroCmbStoreName.Enabled = false;
                this.materialButtonPrintPreview.Visible = false;
                this.matbtnEdit.Visible = false;
            }
           else
            {
              
            }

            if (this.materialLabelRecentLogs.Text == "View Current Log(s)")
            {
                this.matCmbPreparationDate.Enabled = false;
            }
     
        }


        private void ShowDataActivated()
        {   
            this.Sp_user_id = userinfo.user_id;
            this.Sp_UserName = userinfo.emp_name.ToString() + new string(' ', 1) + userinfo.emp_lastname.ToString();
        }

        public void useStateWindowLoad()
        {
            this.crV1.Visible = false;

            if (this.matCmbPreparationDate.Text == String.Empty)
            {
                this.materialCheckboxSelectAll.Visible = false;
            }
            else
            {
                this.materialCheckboxSelectAll.Visible = true;
                this.loadCategoryDropdown();
                  
                if (this.MatcmbCategory.Text != String.Empty)
                {
                    this.loadPrepaDate_AND_Category();
                }


                if (this.MetroCmbStoreName.Text != String.Empty)
                {
                    this.loadPrepaDate_Category_StoreName_Dropdown();
                }
            }

            if(this.lbltotaldata.Text != "0")
            {
                this.metroCMbFilterPrintPages.Text = "1";
            }
        }



        public void loadPrepaDate_AND_Category()
        {
            try
            {
                this.dset.Clear();
                this.dset = g_objStoredProcCollection.sp_getMajorTables("Store_Order_Dispatched_by_Logistic_Checker_Per_Items_RestFull_Major");
                this.doSearch();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }


        public void loadPrepaDate_AND_CategoryRecentLogs()
        {
            try
            {
                this.dset.Clear();
                this.dset = g_objStoredProcCollection.sp_getMajorTables("Store_Order_Dispatched_by_Logistic_Checker_Per_Items_RestFull_Major_Recent_Logs");
                this.RecentLogsSearch();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }

        public void loadPreparationDateDropdown()
        {
            try
            {
                myClass.fillComboBoxStoreOrderApprovalSync(this.matCmbPreparationDate,
                    "Store_Order_Dispatched_by_Logistic_Checker_Per_Items_Categories_DropDown", 
                    this.dSet, "BunifuPrepaDate", "cmdDateOrder", this.MatcmbCategory.Text, this.MetroCmbStoreName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }


        public void loadPreparationDateDropdownRecentLogs()
        {
            try
            {
                myClass.fillComboBoxStoreOrderApprovalSync(
              this.matCmbPreparationDate, 
              "Store_Order_Dispatched_by_Logistic_Checker_Per_Items_Categories_DropDown_Recent_Logs",
               this.dSet, 
               "BunifuPrepaDate", 
               "cmdDateOrder", 
               this.MatcmbCategory.Text,
               this.MetroCmbStoreName.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }



        public void loadCategoryDropdown()
        {
            if (this.matCmbPreparationDate.Text != String.Empty)
            {
                try
                {
                    myClass.fillComboBoxStoreOrderApprovalSync(this.MatcmbCategory,
                        "Store_Order_Dispatched_by_Logistic_Checker_Per_Items_Categories_DropDown_Category",
                        this.dSet,
                        this.matCmbPreparationDate.Text,
                        "cmdDateOrder",
                        this.MatcmbCategory.Text,
                        this.MetroCmbStoreName.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }


        public void loadCategoryDropdownRecentLogs()
        {
            try
            {
                myClass.fillComboBoxStoreOrderApprovalSync(this.MatcmbCategory, 
                "Store_Order_Dispatched_by_Logistic_Checker_Per_Items_Categories_DropDown_Category_Recent_Logs", 
                this.dSet, 
                this.matCmbPreparationDate.Text, 
                "cmdDateOrder", 
                this.MatcmbCategory.Text, 
                this.MetroCmbStoreName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }



        public void loadStoreNameDropdown()
        {
            try
            {
                myClass.fillComboBoxStoreOrderApprovalSync(
                    this.MetroCmbStoreName, 
                    "Store_Order_Dispatched_by_Logistic_Checker_Per_Items_Categories_DropDown_StoreName", 
                    this.dSet, 
                    this.matCmbPreparationDate.Text, 
                    this.MatcmbCategory.Text, 
                    this.MatcmbCategory.Text, 
                    this.MetroCmbStoreName.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }


        public void loadStoreNameDropdownRecent_Logs()
        {
            try
            {
                    this.myClass.fillComboBoxStoreOrderApprovalSync(this.MetroCmbStoreName, 
                    "Store_Order_Dispatched_by_Logistic_Checker_Per_Items_Categories_DropDown_StoreName_Recent_Logs", 
                    this.dSet, 
                    this.matCmbPreparationDate.Text, 
                    this.MatcmbCategory.Text, 
                    this.MatcmbCategory.Text, 
                    this.MetroCmbStoreName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }


        public void loadPrepaDate_Category_StoreName_Dropdown()
        {
            try
            {
                this.dset.Clear();
                this.dset = g_objStoredProcCollection
                .sp_getMajorTables("Store_Order_Dispatched_by_Logistic_Checker_Per_Items_RestFull_Major");
                this.doSearch();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }



        public void loadPrepaDate_Category_StoreName_Dropdown_Recent_Logs()
        {
            try
            {
                this.dset.Clear();
                this.dset = g_objStoredProcCollection.sp_getMajorTables("Store_Order_Dispatched_by_Logistic_Checker_Per_Items_RestFull_Major_Recent_Logs");
               this.RecentLogsSearch();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }



        private void doSearch()
        {
            try
            {
                if (this.dset.Tables.Count > 0)
                {
                    DataView dv = new DataView(this.dset.Tables[0]);
         
                    if (counterstrike == 0)
                    {                    
                        if (this.MetroCmbStoreName.Text == String.Empty)
                        {
                            //Date Conversion
                            DateTime dt = new DateTime();
                            string lstrDate = this.matCmbPreparationDate.Text;
                            dt = Convert.ToDateTime(lstrDate);
                            string Prepadate = dt.ToString("yyyy-MM-dd");              
                            dv.RowFilter = " is_wh_approved_date = '" + Prepadate  + "' and   category = '" + this.MatcmbCategory.Text + "'   ";
                        }
                        else
                        {
                            DateTime dt = new DateTime();
                            string lstrDate = this.matCmbPreparationDate.Text;
                            dt = Convert.ToDateTime(lstrDate);
                            string Prepadate = dt.ToString("yyyy-MM-dd");

                            dv.RowFilter = " is_wh_approved_date = '" + Prepadate + "' and   category = '" + this.MatcmbCategory.Text + "' and store_name ='" + this.MetroCmbStoreName.Text + "'  ";
                        }
                    }
                    this.dgvGunaMoveItems.DataSource = dv;
                    this.lbltotaldata.Text = dgvGunaMoveItems.RowCount.ToString();
                }
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Invalid character found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found 20.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            //END
        }




        private void matCmbPreparationDate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.materialCheckboxSelectAll.Checked == true)
            {
                this.materialCheckboxSelectAll.Checked = false;
                this.materialCheckboxSelectAll_CheckedChanged(sender, e);
            }


            if (this.counterstrike == 0)
            {
                this.loadCategoryDropdown();
                if (this.MatcmbCategory.Text != String.Empty)
                {
                    this.loadPrepaDate_AND_Category();
                }
            }

            if(this.counterstrike == 2)
            {
                this.loadCategoryDropdownRecentLogs();
                if (this.MatcmbCategory.Text != String.Empty)
                {
                    this.loadPrepaDate_AND_CategoryRecentLogs();
                }
            }
        }

        private void matcmbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(this.counterstrike == 0)
            {
                this.loadStoreNameDropdown();
            }

            if(this.counterstrike == 2)
            {
                this.loadStoreNameDropdownRecent_Logs();
            }

            this.metroCmbStoreName_SelectionChangeCommitted(sender, e);
        }



        private void SelectedTrue()
        {
            this.labelSelectedSum.Visible = true;
            this.materialCheckboxSelectAll.Text = "UnSelect ALL";
            for (int i = 0; i < this.dgvGunaMoveItems.RowCount; i++) { this.dgvGunaMoveItems.Rows[i].Cells[0].Value = true; }

            this.labelSelectedSum.Text = "Selected Item(s): " + this.dgvGunaMoveItems.RowCount.ToString();
            this.num = this.dgvGunaMoveItems.RowCount;
            this.SaveButtonManipulator();
            if (num != 0)
            {
                this.matbtnEdit.Visible = true;
            }
        }
        private void materialCheckboxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (this.materialCheckboxSelectAll.Checked == true)
            {
                this.SelectedTrue(); 
            }
            else
            {
                this.SelectedFalse();
            }
        }

        private void SelectedFalse()
        {
            this.materialCheckboxSelectAll.Text = "Select ALL";
            for (int i = 0; i < dgvGunaMoveItems.RowCount; i++) { dgvGunaMoveItems.Rows[i].Cells[0].Value = false; }
            this.labelSelectedSum.Text = "Selected Item(s): " + 0;
            this.num = 0;
            this.SaveButtonManipulator();
            this.lbltotalOrderQty.Text = "0";
            if (num == 0)
            {
                this.matbtnEdit.Visible = false;
            }
        }

        private void SaveButtonManipulator()
        {
            if (this.labelSelectedSum.Text == "0")
            {
                this.matbtnCancel.Visible = false;
            }
            else if (num == 0)
            {
                this.matbtnCancel.Visible = false;
                this.materialLabelNoPrintPages.Visible = false;
                this.metroCMbFilterPrintPages.Visible = false;
                this.materialButtonPrintPreview.Visible = false;
                this.matbtnEdit.Visible = false;
            }
            else
            {              
                this.materialLabelNoPrintPages.Visible = true;
                this.metroCMbFilterPrintPages.Visible = true;
                this.materialButtonPrintPreview.Visible = true;
                this.matbtnEdit.Visible = true;
            }
        }


        double num = 0;
        double num_static_value = 0;
        double printpreview_num_count = 0;
        private void dgvGunaMoveItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bool isChecked = (bool)dgvGunaMoveItems.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;
                CheckCount(isChecked);  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void CheckCount(bool isChecked)
        {
            if (isChecked)
            {
                double totalRecords = Convert.ToInt32(this.lbltotaldata.Text.ToString());
                if (num == totalRecords)
                {

                }
                else
                {
                    num++;
                    num_static_value = num;
                }
            }
            else
            {
                num--;

            }
            //Store in Static Value Integer Type of Variable

            this.labelSelectedSum.Text = "Selected Item(s): " + num;
            this.labelSelectedSum.Visible = true;
            this.SaveButtonManipulator();
            this.EditManipulator();

        }

        private void EditManipulator()
        {
            if (this.num == 1)
            {
                this.matbtnEdit.Visible = true;
            }
            else
            {
                //this.matbtnEdit.Visible = false;
            }
        }

        private void lbltotaldata_TextChanged(object sender, EventArgs e)
        {
            if(this.lbltotaldata.Text != "0")
            {
                this.dgvGunaMoveItems.Enabled = true;
                this.dgvGunaMoveItems.Visible = true;
                this.matCmbPreparationDate.Enabled = true;
                this.MatcmbCategory.Enabled = true;
                if(this.MatcmbCategory.Text != String.Empty)
                {
                    this.MetroCmbStoreName.Enabled = true;
                }                
            }
            else
            {
                this.dgvGunaMoveItems.Visible= false;
                this.MatcmbCategory.SelectedIndex = -1;
                this.materialLabelNoPrintPages.Visible = false;
                this.metroCMbFilterPrintPages.Visible = false;
                this.dgvGunaMoveItems.Enabled = false;
            }
        }


        private void matbtnEdit_Click(object sender, EventArgs e)
        {
            if(this.metroCMbFilterPrintPages.Text == String.Empty)
            {
                this.GlobalStatePopup.NoOfPagesforPrintingMoveOrder();
                return;
            }

            if (MetroFramework.MetroMessageBox.Show(this, "Print the move Order Slip? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.ApproveFunctionality();
            }
            else
            {
                return;
            }
        }

        private void ApproveFunctionality()
        {
            for (int i = 0; i <= this.dgvGunaMoveItems.RowCount - 1; i++)
            {
                try
                {
                    if (this.dgvGunaMoveItems.CurrentRow != null)
                    {
                        if (Convert.ToBoolean(this.dgvGunaMoveItems.Rows[i].Cells["selected"].Value) == true)
                        {

                            if (this.materialLabelRecentLogs.Text == "View Recent Log(s)")
                            {
                                //Date Conversion
                                DateTime dt = new DateTime();
                                string lstrDate = this.dgvGunaMoveItems.Rows[i].Cells["is_wh_approved_date"].Value.ToString();
                                dt = Convert.ToDateTime(lstrDate);
                                string lstrAdate = dt.ToString("yyyy-MM-dd");


                                this.dgvGunaMoveItems.CurrentCell = this.dgvGunaMoveItems.Rows[i].Cells[this.dgvGunaMoveItems.CurrentCell.ColumnIndex];
                                this.dset = g_objStoredProcCollection
                                .sp_IDGenerator_String(dgvGunaMoveItems.Rows[i].Cells["fox"].Value.ToString(),
                                "PUTStoreOrderMoveDispatching",
                                this.dgvGunaMoveItems.Rows[i].Cells["is_wh_approved_date"].Value.ToString(),
                                dgvGunaMoveItems.Rows[i].Cells["category"].Value.ToString(),
                                this.Sp_user_id,
                                this.Sp_ParentId);
                            }
                            if (this.dgvGunaMoveItems.Rows[i].Cells["print_count"].Value.ToString() == null)
                            {
                                dset2.Clear();
                                dset2 = g_objStoredProcCollection.sp_IDGenerator_String(this.dgvGunaMoveItems.Rows[i].Cells["Id"].Value.ToString(), "UpdateStoreMoveOrderReprintCount1", "", "", 1, this.Sp_ParentId);
                            }
                            else if (this.dgvGunaMoveItems.Rows[i].Cells["print_count"].Value.ToString() == "9")
                            {
                                dset2.Clear();
                                dset2 = g_objStoredProcCollection.sp_IDGenerator_String(this.dgvGunaMoveItems.Rows[i].Cells["Id"].Value.ToString(), "UpdateStoreMoveOrderReprintCount10", "", "", 10, this.Sp_ParentId);
                            }
                            else if (this.dgvGunaMoveItems.Rows[i].Cells["print_count"].Value.ToString() == "8")
                            {
                                dset2.Clear();
                                dset2 = g_objStoredProcCollection.sp_IDGenerator_String(this.dgvGunaMoveItems.Rows[i].Cells["Id"].Value.ToString(), "UpdateStoreMoveOrderReprintCount9", "", "", 9, this.Sp_ParentId);
                            }
                            else if (this.dgvGunaMoveItems.Rows[i].Cells["print_count"].Value.ToString() == "7")
                            {
                                dset2.Clear();
                                dset2 = g_objStoredProcCollection.sp_IDGenerator_String(this.dgvGunaMoveItems.Rows[i].Cells["Id"].Value.ToString(), "UpdateStoreMoveOrderReprintCount8", "", "", 8, this.Sp_ParentId);
                            }
                            else if (this.dgvGunaMoveItems.Rows[i].Cells["print_count"].Value.ToString() == "6")
                            {
                                dset2.Clear();
                                dset2 = g_objStoredProcCollection.sp_IDGenerator_String(this.dgvGunaMoveItems.Rows[i].Cells["Id"].Value.ToString(), "UpdateStoreMoveOrderReprintCount7", "", "", 7, this.Sp_ParentId);
                            }
                            else if (this.dgvGunaMoveItems.Rows[i].Cells["print_count"].Value.ToString() == "5")
                            {
                                dset2.Clear();
                                dset2 = g_objStoredProcCollection.sp_IDGenerator_String(this.dgvGunaMoveItems.Rows[i].Cells["Id"].Value.ToString(), "UpdateStoreMoveOrderReprintCount6", "", "", 6, this.Sp_ParentId);
                            }
                            else if (this.dgvGunaMoveItems.Rows[i].Cells["print_count"].Value.ToString() == "4")
                            {
                                dset2.Clear();
                                dset2 = g_objStoredProcCollection.sp_IDGenerator_String(this.dgvGunaMoveItems.Rows[i].Cells["Id"].Value.ToString(), "UpdateStoreMoveOrderReprintCount5", "", "", 5, this.Sp_ParentId);
                            }
                            else if (this.dgvGunaMoveItems.Rows[i].Cells["print_count"].Value.ToString() == "3")
                            {
                                dset2.Clear();
                                dset2 = g_objStoredProcCollection.sp_IDGenerator_String(this.dgvGunaMoveItems.Rows[i].Cells["Id"].Value.ToString(), "UpdateStoreMoveOrderReprintCount4", "", "", 4, this.Sp_ParentId);
                            }
                            else if (this.dgvGunaMoveItems.Rows[i].Cells["print_count"].Value.ToString() == "2")
                            {
                                dset2.Clear();
                                dset2 = g_objStoredProcCollection.sp_IDGenerator_String(this.dgvGunaMoveItems.Rows[i].Cells["Id"].Value.ToString(), "UpdateStoreMoveOrderReprintCount3", "", "", 3, this.Sp_ParentId);
                            }
                            else if (this.dgvGunaMoveItems.Rows[i].Cells["print_count"].Value.ToString() == "1")
                            {
                                dset2.Clear();
                                dset2 = g_objStoredProcCollection.sp_IDGenerator_String(this.dgvGunaMoveItems.Rows[i].Cells["Id"].Value.ToString(), "UpdateStoreMoveOrderReprintCount2", "", "", 2, this.Sp_ParentId);
                            }
                        }             
                    }
                }
                catch (Exception ex)
                {                        
                    MessageBox.Show(ex.Message);
                }
            }
            this.ForLoopProcessAutoPrint();    
        }


        private void labelSelectedSum_TextChanged(object sender, EventArgs e)
        {
            if (num == 0)
            {
                if (this.materialCheckboxSelectAll.Checked == true)
                {

                }
                else
                {
                    this.frmStoreOrderDispatching_Load(sender, e);
                }
            }
            else
            {
                this.materialCheckboxSelectAll.Visible = true;
            }
        }






        private void metroCmbStoreName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(this.counterstrike == 0)
            {
                this.loadPrepaDate_Category_StoreName_Dropdown();
            }

            if(this.counterstrike == 2)
            {
                this.loadPrepaDate_Category_StoreName_Dropdown_Recent_Logs();
            }
        }

        private void GridResetIntoFirstLine()
        {
            this.dgvGunaMoveItems.CurrentCell = this.dgvGunaMoveItems.Rows[0].Cells[this.dgvGunaMoveItems.CurrentCell.ColumnIndex];
          
        }

        private void ForLoopProcessAutoPrint()
        {
            this.GridResetIntoFirstLine();
            this.NextDatainDryStorePreparationEntry();
        }

        private void NextDatainDryStorePreparationEntry()
        {         
            dgvGunaMoveItems_CurrentCellChanged(new object(), new System.EventArgs());
            if (this.Sp_Selected_Item == "selected")
            {
                if(this.metroCMbFilterPrintPages.Text == "2")
                {
                    this.PrintingProcess();
                    this.PrintingProcess();
                }
                else if(this.metroCMbFilterPrintPages.Text == "1")
                {
                    this.PrintingProcess();
                }
                else if (this.metroCMbFilterPrintPages.Text == "3")
                {
                    this.PrintingProcess();
                    this.PrintingProcess();
                    this.PrintingProcess();
                }
                else
                {
  
                }
            }
                

            if (this.dgvGunaMoveItems.Rows.Count >= 1)
            {
                int i = this.dgvGunaMoveItems.CurrentRow.Index + 1;
                if (i >= -1 && i < this.dgvGunaMoveItems.Rows.Count)
                    this.dgvGunaMoveItems.CurrentCell = this.dgvGunaMoveItems.Rows[i].Cells[0];
              
                else
                {

                    if (this.materialLabelRecentLogs.Text == "View Current Log(s)")
                    {
                        this.SelectedFalse();
                        num = 0;
                        this.bunifuPrepaDateFrom_ValueChanged(new object(), new System.EventArgs());
                        this.bunifuDateTo_ValueChanged(new object(), new System.EventArgs());               
                        this.GlobalStatePopup.ReprintSuccessFully();
                        return;
                    }
                    else
                    {
                        if (this.matCmbPreparationDate.Text != String.Empty)
                        {
                            matcmbCategory_SelectionChangeCommitted(new object(), new System.EventArgs());
                        }
                        this.GlobalStatePopup.DispatchedSuccessfully();
                        this.materialCheckboxSelectAll.Checked = false;
                        this.labelSelectedSum.Visible = false;
                        this.frmStoreOrderDispatching_Load(new object(), new System.EventArgs());
                        return;
                    }
                }
            }

            this.Sp_Selected_Item = "";
            this.NextDatainDryStorePreparationEntry();
        }

        private void PrintingProcess()
        {
            Rpt_Path = ULTRAMAVERICK.Properties.Settings.Default.fdg;

            PrintDialog printDialog = new PrintDialog();
            rpt.Load(Rpt_Path + "\\StoreMoveOrderPickSlip.rpt");

            //rpt.SetDatabaseLogon("sa", "ULtR@MaVD3p0t2o22");
        


            rpt.Refresh();
            myglobal.DATE_REPORT2 = sp_final_id;

            //Date Conversion BUje
            this.DateConversion(this.Sp_PreparationDate);
            rpt.SetParameterValue("@approved_prepa_date", this.ConvertedDateToString);
            //rpt.SetParameterValue("@category", this.MatcmbCategory.Text);
            rpt.SetParameterValue("@category", this.Sp_Category);
            rpt.SetParameterValue("@fox", this.Sp_Fox);
            rpt.SetParameterValue("@username", this.Sp_UserName);
            rpt.SetParameterValue("@parentIdentity", this.Sp_ParentId);
            crV1.ReportSource = rpt;
            crV1.Refresh();
            rpt.PrintOptions.PrinterName = printDialog.PrinterSettings.PrinterName;
            rpt.PrintToPrinter(printDialog.PrinterSettings.Copies, printDialog.PrinterSettings.Collate, printDialog.PrinterSettings.ToPage, printDialog.PrinterSettings.ToPage);

        }

        private void dgvGunaMoveItems_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvGunaMoveItems.Rows.Count > 0)
                {
                    if (this.dgvGunaMoveItems.CurrentRow != null)
                    {
                        if (this.dgvGunaMoveItems.CurrentRow.Cells["wh_checker_move_order_no"].Value != null)
                        {

                            this.Sp_Fox = this.dgvGunaMoveItems.CurrentRow.Cells["fox"].Value.ToString();
                            this.Sp_ParentId = Convert.ToInt32(this.dgvGunaMoveItems.CurrentRow.Cells["Id"].Value);
                            this.Sp_Category = this.dgvGunaMoveItems.CurrentRow.Cells["category"].Value.ToString();
                            this.Sp_PreparationDate = this.dgvGunaMoveItems.CurrentRow.Cells["is_approved_prepa_date"].Value.ToString();

                            if (Convert.ToBoolean(this.dgvGunaMoveItems.CurrentRow.Cells["selected"].Value) == true)
                            {
                                this.Sp_Selected_Item = "selected";
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }

        private void RecentLogsSearch()
        {            
                this.dset.Clear();

                this.dset = g_objStoredProcCollection.sp_getMajorTables("Store_Order_Dispatched_by_Logistic_Checker_Per_Items_RestFull_Major_Printed");

                if (this.dset.Tables.Count > 0)
                {
                    DataView dv2 = new DataView(this.dset.Tables[0]);
                    if (this.MetroCmbStoreName.SelectedIndex != -1)
                    {               
                        dv2.RowFilter = " is_wh_approved_date >= #" + bunifuPrepaDateFrom.Text + "# AND is_wh_approved_date <= #" + bunifuDateTo.Text + "# AND category = '" + this.MatcmbCategory.Text + "'";

                    }
                    else
                    {
        
                    dv2.RowFilter = " is_wh_approved_date >= #" + bunifuPrepaDateFrom.Text + "# AND is_wh_approved_date <= #" + bunifuDateTo.Text + "# ";

                    }
                this.dgvGunaMoveItems.DataSource = dv2;
                this.lbltotaldata.Text = dgvGunaMoveItems.RowCount.ToString();
            }                  
        }



        private void SelectAllDataFunctionality() {
            if (this.lbltotaldata.Text != "0")
            {
                this.materialCheckboxSelectAll.Visible = true;
            }
        }

        private void materialCard3_Click(object sender, EventArgs e)
        {                
                if (counterstrike == 0)
                {
                this.matCmbPreparationDate.SelectedIndex = -1;
                this.metroCMbFilterPrintPages.Text = "1";
                this.SelectAllDataFunctionality();
             
                    this.lblTextTitle.Text = "Store Order Dispatching Recent Logs";
                    this.materialLabelRecentLogs.Text = "View Current Log(s)";
                    //Preparation Date Load
                    this.loadPreparationDateDropdownRecentLogs();
                    this.materialLabelFrom.Visible = true;
                    this.materialLabelTo.Visible = true;
                    this.bunifuPrepaDateFrom.Visible = true;
                    this.bunifuDateTo.Visible = true;
                    this.matCmbPreparationDate.Enabled = false;
                    //Do Searching Method
                    this.RecentLogsSearch();
                    counterstrike = 1;
                }
                if (counterstrike == 2)
                {
                //Initial Page Print
                num = 0;
                this.metroCMbFilterPrintPages.Text = "1";
                this.SelectAllDataFunctionality();

                this.lblTextTitle.Text = "Store Order Dispatching";
                this.materialLabelRecentLogs.Text = "View Recent Log(s)";
                this.materialLabelFrom.Visible = false;
                this.materialLabelTo.Visible = false;
                this.bunifuDateTo.Visible = false;
                this.bunifuPrepaDateFrom.Visible = false;      
                counterstrike = 0;
                    this.frmStoreOrderDispatching_Load(sender, e);
                    return;

                }
                if (counterstrike == 1)
                {
                    counterstrike = 2;

                }


      
        }

        private void materialButtonPrintPreview_Click(object sender, EventArgs e)
        { 
            this.GridResetIntoFirstLine();
            this.AutoPrintPreviewLooping();

            if (this.materialLabelRecentLogs.Text == "View Current Log(s)")
            {
                //this.materialButtonPrintPreview.Visible = false;
            }
        }
        private void AutoPrintPreviewLooping()
        {
            this.dgvGunaMoveItems_CurrentCellChanged(new object(), new System.EventArgs());
            if (this.num == this.printpreview_num_count)
            {
                return;
            }
            else
            {
                if (this.Sp_Selected_Item == "selected")
                {
                    this.PrintPreview();
                }
                this.printpreview_num_count++;
            }
            if (this.dgvGunaMoveItems.Rows.Count >= 1)
            {
            int i = this.dgvGunaMoveItems.CurrentRow.Index + 1;
            if (i >= -1 && i < this.dgvGunaMoveItems.Rows.Count)
            this.dgvGunaMoveItems.CurrentCell = this.dgvGunaMoveItems.Rows[i].Cells[0];
            }
            else
                {
                    return;
                }
            this.Sp_Selected_Item = "";
            this.AutoPrintPreviewLooping();
        }

        private void PrintPreview()
        {
            if (this.materialLabelRecentLogs.Text == "View Recent Log(s)")
            {
                myglobal.REPORT_NAME = "StoreMoveOrderPickSlipPreview";

                Rpt_Path = ULTRAMAVERICK.Properties.Settings.Default.fdg;

                rpt.Load(Rpt_Path + "\\StoreMoveOrderPickSlipPreview.rpt");
                //rpt.SetDatabaseLogon("sa", "ULtR@MaVD3p0t2o22");
                rpt.Refresh();
                //Date Conversion
                this.DateConversion(this.Sp_PreparationDate);
                myglobal.DATE_REPORT = this.ConvertedDateToString;
                myglobal.DATE_REPORT2 = this.Sp_Category;
                myglobal.DATE_REPORT3 = this.Sp_Fox;
                myglobal.DATE_REPORT4 = this.Sp_UserName;
                myglobal.DATE_REPORT5 = this.Sp_ParentId.ToString();
                crV1.ReportSource = rpt;
                crV1.Refresh();
                frmReport frmReport = new frmReport();
                frmReport.ShowDialog();
            }
            else
            {
                myglobal.REPORT_NAME = "StoreMoveOrderPickSlip";

                Rpt_Path = ULTRAMAVERICK.Properties.Settings.Default.fdg;

                rpt.Load(Rpt_Path + "\\StoreMoveOrderPickSlip.rpt");
                //rpt.SetDatabaseLogon("sa", "ULtR@MaVD3p0t2o22");
                //Date Conversion
                this.DateConversion(this.Sp_PreparationDate);

                rpt.Refresh();

                myglobal.DATE_REPORT = this.ConvertedDateToString;
                myglobal.DATE_REPORT2 = this.Sp_Category;
                myglobal.DATE_REPORT3 = this.Sp_Fox;
                myglobal.DATE_REPORT4 = this.Sp_UserName;
                myglobal.DATE_REPORT5 = this.Sp_ParentId.ToString();
                crV1.ReportSource = rpt;
                crV1.Refresh();
                frmReport frmReport = new frmReport();
                frmReport.ShowDialog();
            }
        }

        void DateConversion (string Date)
        {
            //Date Conversion
            DateTime dt = new DateTime();
            string lstrDate = Date;
            dt = Convert.ToDateTime(lstrDate);
            this.ConvertedDateToString = dt.ToString("MM-dd-yyyy");
        }

        private void materialCard3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuPrepaDateFrom_ValueChanged(object sender, EventArgs e)
        {
            if (counterstrike == 2)
            {
                this.RecentLogsSearch();
            }
        }

        private void bunifuDateTo_ValueChanged(object sender, EventArgs e)
        {
            if (counterstrike == 2)
            {
                this.RecentLogsSearch();
            }
        }

        private void materialLabelRecentLogs_Click(object sender, EventArgs e)
        {
            this.materialCard3_Click(sender, e);
        }

        private void matIncludeStoreName_CheckedChanged(object sender, EventArgs e)
        {
            if(matIncludeStoreName.Checked == true)
            {
                this.matcmbCategory_SelectionChangeCommitted(sender, e);
            }
            else
            {
                this.MetroCmbStoreName.SelectedIndex = -1;
                this.loadPrepaDate_AND_Category();
            }
       ;
        }
    }
}
