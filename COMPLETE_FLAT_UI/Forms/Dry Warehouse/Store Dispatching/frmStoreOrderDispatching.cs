using COMPLETE_FLAT_UI.Models;
using CrystalDecisions.CrystalReports.Engine;
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
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;
using ULTRAMAVERICK.Report;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Dispatching
{
    public partial class frmStoreOrderDispatching : MaterialForm
    {
        //Main Classs
        myclasses myClass = new myclasses();
        myclasses xClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        IStoredProcedures objStorProc = null;
        //Data Set Initialization
        public DataSet dset = new DataSet();
        DataSet dset2 = new DataSet();
        DataSet dset3 = new DataSet();
        DataSet dSet = new DataSet();
        //Variable Declaration
        int p_id = 0;
        int counterstrike = 0;
        string Rpt_Path = "";
        ReportDocument rpt = new ReportDocument();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();


        public frmStoreOrderDispatching()
        {
            InitializeComponent();
        }

        public int Sp_user_id { get; set; }
        public string sp_final_id { get; set; }
        public string Sp_Fox { get; set; }
        public string Sp_Selected_Item { get; set; }

        public string Sp_UserName { get; set; }
        private void frmStoreOrderDispatching_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
          


            this.loadPreparationDateDropdown();

       
            this.useStateWindowLoad();
      
            this.ShowDataActivated();
   
            this.matCmbPreparationDate_SelectionChangeCommitted(sender, e);

           if(this.matCmbPreparationDate.Text == String.Empty)
            {
               

                this.dgvGunaMoveItems.DataSource = null;
                this.dgvGunaMoveItems.Rows.Clear();
                this.lbltotaldata.Text = "0";

                this.matCmbPreparationDate.Enabled = false;
                this.matcmbCategory.Enabled = false;
                this.metroCmbStoreName.Enabled = false;

                this.materialButtonPrintPreview.Visible = false;
                this.matbtnEdit.Visible = false;

            }
           else
            {
              
            }
        }

        private void ResetComboBox()
        {
            this.matCmbPreparationDate.SelectedIndex = -1;
            this.matcmbCategory.SelectedIndex = -1;
            this.metroCmbStoreName.SelectedIndex = -1;
           
        }


        // Position Absolute right: 20px;

        private void ShowDataActivated()
        {
   
            this.Sp_user_id = userinfo.user_id;
            this.Sp_UserName = userinfo.emp_name.ToString() + new string(' ', 1) + userinfo.emp_lastname.ToString();

        }

        public void useStateWindowLoad()
        {
            //Visibility
            this.crV1.Visible = false;

            if (this.matCmbPreparationDate.Text == String.Empty)
            {
                this.materialCheckboxSelectAll.Visible = false;
            }
            else
            {
                this.materialCheckboxSelectAll.Visible = true;
                this.loadCategoryDropdown();
           

                if (this.matcmbCategory.Text != String.Empty)
                {
                    this.loadPrepaDate_AND_Category();
                }

                if (this.metroCmbStoreName.Text != String.Empty)
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

                this.dset = objStorProc.sp_getMajorTables("Store_Order_Dispatched_by_Logistic_Checker_Per_Items_RestFull_Major");

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

                this.dset = objStorProc.sp_getMajorTables("Store_Order_Dispatched_by_Logistic_Checker_Per_Items_RestFull_Major_Recent_Logs");

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
                

                myClass.fillComboBoxStoreOrderApprovalSync(this.matCmbPreparationDate, "Store_Order_Dispatched_by_Logistic_Checker_Per_Items_Categories_DropDown", 
                    this.dSet, "BunifuPrepaDate", "cmdDateOrder", this.matcmbCategory.Text, this.metroCmbStoreName.Text);

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


                myClass.fillComboBoxStoreOrderApprovalSync(this.matCmbPreparationDate, "Store_Order_Dispatched_by_Logistic_Checker_Per_Items_Categories_DropDown_Recent_Logs",
                    this.dSet, "BunifuPrepaDate", "cmdDateOrder", this.matcmbCategory.Text, this.metroCmbStoreName.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }



        public void loadCategoryDropdown()
        {
            try
            {


                myClass.fillComboBoxStoreOrderApprovalSync(this.matcmbCategory, "Store_Order_Dispatched_by_Logistic_Checker_Per_Items_Categories_DropDown_Category", this.dSet, this.matCmbPreparationDate.Text, "cmdDateOrder", this.matcmbCategory.Text, this.metroCmbStoreName.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }


        public void loadCategoryDropdownRecentLogs()
        {
            try
            {


                myClass.fillComboBoxStoreOrderApprovalSync(this.matcmbCategory, "Store_Order_Dispatched_by_Logistic_Checker_Per_Items_Categories_DropDown_Category_Recent_Logs", this.dSet, this.matCmbPreparationDate.Text, "cmdDateOrder", this.matcmbCategory.Text, this.metroCmbStoreName.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }





        public void loadCategoryDropdown_Recent_Logs()
        {
            try
            {


                myClass.fillComboBoxStoreOrderApprovalSync(this.matcmbCategory, "Store_Order_Dispatched_by_Logistic_Checker_Per_Items_Categories_DropDown_Category_Recent_Logs", this.dSet, this.matCmbPreparationDate.Text, "cmdDateOrder", this.matcmbCategory.Text, this.metroCmbStoreName.Text);

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


                myClass.fillComboBoxStoreOrderApprovalSync(this.metroCmbStoreName, "Store_Order_Dispatched_by_Logistic_Checker_Per_Items_Categories_DropDown_StoreName", this.dSet, this.matCmbPreparationDate.Text, this.matcmbCategory.Text, this.matcmbCategory.Text, this.metroCmbStoreName.Text);

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


                myClass.fillComboBoxStoreOrderApprovalSync(this.metroCmbStoreName, "Store_Order_Dispatched_by_Logistic_Checker_Per_Items_Categories_DropDown_StoreName_Recent_Logs", this.dSet, this.matCmbPreparationDate.Text, this.matcmbCategory.Text, this.matcmbCategory.Text, this.metroCmbStoreName.Text);

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

                this.dset = objStorProc.sp_getMajorTables("Store_Order_Dispatched_by_Logistic_Checker_Per_Items_RestFull_Major");
       

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

                this.dset = objStorProc.sp_getMajorTables("Store_Order_Dispatched_by_Logistic_Checker_Per_Items_RestFull_Major_Recent_Logs");
                //02/3/2022

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
          

                    //Show Only The Current Active Items
                    if (counterstrike == 0)
                    {
                        

                        if (this.metroCmbStoreName.Text == String.Empty)
                        {
                            dv.RowFilter = " is_wh_approved_date = '" + this.matCmbPreparationDate.Text + "' and   category = '" + this.matcmbCategory.Text + "'   ";

                        }
                        else
                        {
                            dv.RowFilter = " is_wh_approved_date = '" + this.matCmbPreparationDate.Text + "' and   category = '" + this.matcmbCategory.Text + "' and store_name ='" + this.metroCmbStoreName.Text + "'  ";

                        }
                    }

                  

                    this.dgvGunaMoveItems.DataSource = dv;
                    this.lbltotaldata.Text = dgvGunaMoveItems.RowCount.ToString();

                    //gerard
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
                if (this.matcmbCategory.Text != String.Empty)
                {
                    this.loadPrepaDate_AND_Category();
                }
            }

            if(this.counterstrike == 2)
            {
                this.loadCategoryDropdownRecentLogs();
                if (this.matcmbCategory.Text != String.Empty)
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

        private void CountAllQtyOrder()
        {
            int sum = 0;
            for (int i = 0; i < this.dgvGunaMoveItems.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(this.dgvGunaMoveItems.Rows[i].Cells["prepared_allocated_qty"].Value);
            }
            this.lbltotalOrderQty.Text = sum.ToString();
        }

        private void materialCheckboxSelectAll_CheckedChanged(object sender, EventArgs e)
        {


            if (this.materialCheckboxSelectAll.Checked == true)
            {
                this.labelSelectedSum.Visible = true;
                this.materialCheckboxSelectAll.Text = "UnSelect ALL";
                for (int i = 0; i < this.dgvGunaMoveItems.RowCount; i++) { this.dgvGunaMoveItems.Rows[i].Cells[0].Value = true; }
                //MessageBox.Show(dgvReprinting.SelectedRows.Count.ToString());

                this.labelSelectedSum.Text = "Selected Item(s): " + this.dgvGunaMoveItems.RowCount.ToString();
                this.num = this.dgvGunaMoveItems.RowCount;
                this.SaveButtonManipulator();
                if(num != 0)
                {
                    this.matbtnEdit.Visible = true;
                }
          
            }
            else
            {
                this.materialCheckboxSelectAll.Text = "Select ALL";
                //this.labelSelectedSum.Visible = false;
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
                //this.matbtnCancel.Visible = true;
                this.materialLabelNoPrintPages.Visible = true;
                this.metroCMbFilterPrintPages.Visible = true;
                this.materialButtonPrintPreview.Visible = true;
                this.matbtnEdit.Visible = true;
            }
        }

        double num = 0;
        double num_static_value = 0;
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
                //this.matbtnCancel.Visible = true;
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
                //this.CountAllQtyOrder();
            }
            else
            {
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

            if (MetroFramework.MetroMessageBox.Show(this, "Print the move Order Slip? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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
                            //MessageBox.Show(this.dgvGunaMoveItems.Rows[i].Cells["is_approved_prepa_date"].Value.ToString());
                            //Date Conversion
                            DateTime dt = new DateTime();
                            string lstrDate = this.dgvGunaMoveItems.Rows[i].Cells["is_wh_approved_date"].Value.ToString();
                            dt = Convert.ToDateTime(lstrDate);
                            string lstrAdate = dt.ToString("yyyy-MM-dd");

                            //MessageBox.Show(lstrAdate);


                            //return;
                            this.dgvGunaMoveItems.CurrentCell = this.dgvGunaMoveItems.Rows[i].Cells[this.dgvGunaMoveItems.CurrentCell.ColumnIndex];
                            dset = g_objStoredProcCollection.sp_IDGenerator_String(dgvGunaMoveItems.Rows[i].Cells["fox"].Value.ToString(), "PUTStoreOrderMoveDispatching", this.dgvGunaMoveItems.Rows[i].Cells["is_wh_approved_date"].Value.ToString(), 
                                dgvGunaMoveItems.Rows[i].Cells["category"].Value.ToString(), this.Sp_user_id);

                        }
                        else
                        {
                            //dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepacking", "", "", 1);

                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error");
                    //this.dgvGunaMoveItems.CurrentCell = this.dgvGunaMoveItems.Rows[i].Cells[this.dgvGunaMoveItems.CurrentCell.ColumnIndex];
                    //dset = g_objStoredProcCollection.sp_IDGenerator_String(dgvGunaMoveItems.Rows[i].Cells["fox"].Value.ToString(), "PUTStoreOrderMoveDispatching", this.dgvGunaMoveItems.Rows[i].Cells["is_approved_prepa_date"].Value.ToString(),
                    //    dgvGunaMoveItems.Rows[i].Cells["category"].Value.ToString(), this.Sp_user_id);

                   
                    //this.dgvGunaMoveItems.CurrentCell = this.dgvGunaMoveItems.Rows[i].Cells[this.dgvGunaMoveItems.CurrentCell.ColumnIndex];
                    //dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvGunaMoveItems.Rows[i].Cells["fox"].Value.ToString()), "PUTStoreOrderMoveDispatching", this.dgvGunaMoveItems.Rows[i].Cells["is_approved_prepa_date"].Value.ToString(), dgvGunaMoveItems.Rows[i].Cells["category"].Value.ToString(), this.Sp_user_id);

                    //this.dgvGunaMoveItems.CurrentCell = this.dgvGunaMoveItems.Rows[i].Cells[this.dgvGunaMoveItems.CurrentCell.ColumnIndex];
                    //dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvGunaMoveItems.Rows[i].Cells["primary_id"].Value.ToString()), "PUTStoreOrderMoveDispatching", 
                    //    this.matCmbPreparationDate.Text, this.Sp_user_id.ToString(), 1);
                
                    MessageBox.Show(ex.Message);
                }

            }

            //MessageBox.Show("Manok");
   
            this.ForLoopProcessAutoPrint();
            //this.GlobalStatePopup.DispatchedSuccessfully();
       
            //this.materialCheckboxSelectAll.Checked = false;
            //this.labelSelectedSum.Visible = false;
       
            ////Pahinga
            //this.frmStoreOrderDispatching_Load(new object(), new System.EventArgs());
    
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
        private void btnPrintSample_Click(object sender, EventArgs e)
        {
            this.GridResetIntoFirstLine();
      
            this.NextDatainDryStorePreparationEntry();
        }

        private void ForLoopProcessAutoPrint()
        {
            this.GridResetIntoFirstLine();

            this.NextDatainDryStorePreparationEntry();
        }

        private void NextDatainDryStorePreparationEntry()
        {
            //for (int i = 0; i <= this.dgvGunaMoveItems.RowCount - 1; i++)
            //{
            //    if (Convert.ToBoolean(this.dgvGunaMoveItems.Rows[i].Cells["selected"].Value) == true)
            //    {
            //        this.PrintingProcess();
            //    }
            //}
            dgvGunaMoveItems_CurrentCellChanged(new object(), new System.EventArgs());
            //MessageBox.Show("" + this.Sp_Selected_Item);



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
                    this.GlobalStatePopup.DispatchedSuccessfully();
                    matcmbCategory_SelectionChangeCommitted(new object(), new System.EventArgs());
                    this.materialCheckboxSelectAll.Checked = false;
                    this.labelSelectedSum.Visible = false;

                    //Pahinga
                    this.frmStoreOrderDispatching_Load(new object(), new System.EventArgs());


                    return;
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

            //rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");
            //MessageBox.Show(sp_final_id);
            this.sp_final_id = "01/12/2022";
            rpt.Refresh();
            myglobal.DATE_REPORT2 = sp_final_id;
       
            rpt.SetParameterValue("@approved_prepa_date", this.matCmbPreparationDate.Text);
            rpt.SetParameterValue("@category", this.matcmbCategory.Text);
            rpt.SetParameterValue("@fox", this.Sp_Fox);
            rpt.SetParameterValue("@username", this.Sp_UserName);

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
                        if (this.dgvGunaMoveItems.CurrentRow.Cells["fox"].Value != null)
                        {

                            this.Sp_Fox = this.dgvGunaMoveItems.CurrentRow.Cells["fox"].Value.ToString();

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
            //Show Only The Current Active Items
            
                this.dset.Clear();

                this.dset = objStorProc.sp_getMajorTables("Store_Order_Dispatched_by_Logistic_Checker_Per_Items_RestFull_Major_Printed");

                if (this.dset.Tables.Count > 0)
                {
                    DataView dv2 = new DataView(this.dset.Tables[0]);



                    if (this.metroCmbStoreName.SelectedIndex != -1)
                    {
                    //MessageBox.Show("true");
                        dv2.RowFilter = " is_wh_approved_date >= #" + bunifuPrepaDateFrom.Text + "# AND is_wh_approved_date <= #" + bunifuDateTo.Text + "# AND category = '" + this.matcmbCategory.Text + "'";
                    //dv2.RowFilter = " is_approved_prepa_date >= #" + bunifuPrepaDateFrom.Text + "# AND is_approved_prepa_date <= #" + bunifuDateTo.Text + "# AND category = '" + this.matcmbCategory.Text + "' ";
                }
                    else
                    {
                    //dv2.RowFilter = " is_approved_prepa_date = '" + this.matCmbPreparationDate.Text + "' and   category = '" + this.matcmbCategory.Text + "' and store_name ='" + this.metroCmbStoreName.Text + "' or is_approved_prepa_date >= #" + this.bunifuPrepaDateFrom.Text + "# AND is_approved_prepa_date <= #" + this.bunifuDateTo.Text + "#  ";

                    //dv2.RowFilter = " is_approved_prepa_date >= #" + bunifuPrepaDateFrom.Text + "# AND is_approved_prepa_date <= #" + bunifuDateTo.Text + "#  and   category = '" + this.matcmbCategory.Text + "' and store_name ='" + this.metroCmbStoreName.Text + "' or is_approved_prepa_date >= #" + this.bunifuPrepaDateFrom.Text + "# AND is_approved_prepa_date <= #" + this.bunifuDateTo.Text + "#  ";
                    //MessageBox.Show("false");
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
                //MessageBox.Show("External" + counterstrike);
                if (counterstrike == 0)
                {
                this.matCmbPreparationDate.SelectedIndex = -1;
                this.metroCMbFilterPrintPages.Text = "1";
                this.SelectAllDataFunctionality();
                    //MessageBox.Show("Sample Data"+counterstrike);
                    this.lblTextTitle.Text = "Store Order Dispatching Recent Logs";
                    this.materialLabelRecentLogs.Text = "View Current Log(s)";
                    //Preparation Date Load
                    this.loadPreparationDateDropdownRecentLogs();
                    //Load Fucking Category
                    this.loadCategoryDropdown_Recent_Logs();

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
                //MessageBox.Show("Alert sample");
            

                //Initial Page Print
                this.metroCMbFilterPrintPages.Text = "1";
                this.SelectAllDataFunctionality();
                //MessageBox.Show("Sample Data 2" +counterstrike);
                this.lblTextTitle.Text = "Store Order Dispatching";




                    this.materialLabelRecentLogs.Text = "View Recent Log(s)";
                    this.materialLabelFrom.Visible = false;
                    this.materialLabelTo.Visible = false;
                    this.bunifuDateTo.Visible = false;
                    this.bunifuPrepaDateFrom.Visible = false;
                    this.matCmbPreparationDate.Enabled = true;
   
                counterstrike = 0;
                //
              
                    //MessageBox.Show("Buje");
                

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
        }
        private void AutoPrintPreviewLooping()
        {
            this.dgvGunaMoveItems_CurrentCellChanged(new object(), new System.EventArgs());
          


            if (this.Sp_Selected_Item == "selected")
            {
                this.PrintPreview();
            }



                if (this.dgvGunaMoveItems.Rows.Count >= 1)
            {
                int i = this.dgvGunaMoveItems.CurrentRow.Index + 1;
                if (i >= -1 && i < this.dgvGunaMoveItems.Rows.Count)
                    this.dgvGunaMoveItems.CurrentCell = this.dgvGunaMoveItems.Rows[i].Cells[0];

                else
                {
                    //this.LastLineofPreparationSubject();
              


                    return;
                }
            }

            this.Sp_Selected_Item = "";
            this.AutoPrintPreviewLooping();
        }

        private void PrintPreview()
        {
            myglobal.REPORT_NAME = "StoreMoveOrderPickSlip";

            Rpt_Path = ULTRAMAVERICK.Properties.Settings.Default.fdg;

            rpt.Load(Rpt_Path + "\\StoreMoveOrderPickSlip.rpt");
            //rpt.SetDatabaseLogon("sa", "FMf3dor@2o20");

            rpt.Refresh();


            myglobal.DATE_REPORT = this.matCmbPreparationDate.Text;
            myglobal.DATE_REPORT2 = this.matcmbCategory.Text;
            myglobal.DATE_REPORT3 = this.Sp_Fox;
            myglobal.DATE_REPORT4 = this.Sp_UserName;


            crV1.ReportSource = rpt;
            crV1.Refresh();

            frmReport frmReport = new frmReport();
            frmReport.ShowDialog();
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
                this.metroCmbStoreName.SelectedIndex = -1;
                this.loadPrepaDate_AND_Category();
            }
       ;
        }
    }
}
