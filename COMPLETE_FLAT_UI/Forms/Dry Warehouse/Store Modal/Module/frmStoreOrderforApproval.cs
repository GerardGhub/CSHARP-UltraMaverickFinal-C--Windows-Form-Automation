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
using ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal.Module;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    public partial class frmStoreOrderforApproval : MaterialForm
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
        string Rpt_Path = "";
     



        public frmStoreOrderforApproval()
        {
            InitializeComponent();
        }
        public int sp_user_id { get; set; }
        public string mode { get; set; }


        //Class Binding to oTher window

        public int sp_order_id { get; set; }
        public string sp_date_ordered { get; set; }
        public string sp_fox { get; set; }
        public string sp_store_name { get; set; }
        public string sp_route { get; set; }
        public string sp_area { get; set; }
        public string sp_category { get; set; }
        public string sp_item_code { get; set; }
        public string sp_description { get; set; }
        public string sp_uom { get; set; }
        public string sp_qty { get; set; }
        public string total_item_for_allocation { get; set; }
        public string is_issue_for_approval { get; set; }
        public string sp_StockOnHand { get; set; }
        public string  sp_Allocated_Qty { get; set; }

        private void frmStoreOrderforApproval_Load(object sender, EventArgs e)
        {

            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            if (myClass.g_objStoredProc.getConnected() == true)
            {
                g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections();


                this.Rpt_Path = ULTRAMAVERICK.Properties.Settings.Default.fdg;


                this.dgvStoreOrderApproval.Columns[0].Width = 50;// The id column
                this.dgvStoreOrderApproval.Columns[3].Width = 150;// The id column

            }
            else
            {
                MessageBox.Show("Unable to connect in sql server", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            this.DataRefresher();


            this.showRawMaterialforApproval();

            //this.ReturnFunctionality();

            this.ValidatedItemforApproval();
            this.VisibilityFalseDataGrid();
        }

        private void VisibilityFalseDataGrid()
        {
            this.dgvStoreOrderApproval.Columns["order_id"].Visible = false;
            this.dgvStoreOrderApproval.Columns["primary_id"].Visible = false;
            this.dgvStoreOrderApproval.Columns["AVERAGE_ORDER_DAY_SET_UP"].Visible = false;
            this.dgvStoreOrderApproval.Columns["StockOnHand"].Visible = false;
            this.dgvStoreOrderApproval.Columns["ALLOCATION_QTY"].Visible = false;
            this.dgvStoreOrderApproval.Columns["ORDERS"].Visible = false;
            this.dgvStoreOrderApproval.Columns["QTY_RECEIVED_ORDER"].Visible = false;
            this.dgvStoreOrderApproval.Columns["TOTAL_COLUMN_ALLOCATED_QTY"].Visible = false;
        }

        private void ValidatedItemforApproval()
        {
            if (this.total_item_for_allocation == "0")
            {
                this.ReturnFunctionality();
            }
            else
            {

                //Start
                if (MetroFramework.MetroMessageBox.Show(this, "You have " + total_item_for_allocation + " item for Allocation? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    frmAllocationModule fm = new frmAllocationModule();
                    fm.ShowDialog();

                }
                else
                {
                    this.ReturnFunctionality();
                    return;
                }


            }
        }
        private void DataGridColumnDisabledEditing()
        {
            this.dgvStoreOrderApproval.Columns["primary_id"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["order_id"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["fox"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["store_name"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["route"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["area"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["category"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["item_code"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["description"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["uom"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["qty"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["date_added"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["StockOnHand"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["ALLOCATION_QTY"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["ORDERS"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["date_ordered"].ReadOnly = true;
        }
        private void ReturnFunctionality()
        {

            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class

            this.DataRefresher();
            myglobal.global_module = "Active";

            this.loadCategoryDropdown();
            this.loadStoreDropdown();
            this.loadDateOrderDropdown();
        

            this.InitiliazeDatePickerMinDate();
            this.mode = "";
       



                //this.ConnectionInit();
                this.dset_emp1.Clear();

                this.dset_emp1 = objStorProc.sp_getMajorTables("searchorderForApprovalinDryWH");
                DataView dv = new DataView(this.dset_emp1.Tables[0]);

                this.dgvStoreOrderApproval.DataSource = dv;
                this.lbltotaldata.Text = dgvStoreOrderApproval.RowCount.ToString();
            if(this.lbltotaldata.Text == "0")
            {
                this.groupColorCoding.Visible = false;
            }
            else
            {
                this.groupColorCoding.Visible = true;
            }
          
            this.SaveButtonManipulator();
            this.DataGridColumnDisabledEditing();
     
        }


        private void showRawMaterialforApproval()    //method for loading available_menus
        {
            try
            {

                xClass.fillDataGridView(this.dgvFindDataForAlocation, "Raw_Materials_Dry_Allocation", dSet);

                this.total_item_for_allocation = this.dgvFindDataForAlocation.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            //this.dgvRawMats.Columns["item_id"].Visible = false;

        }


        private void InitiliazeDatePickerMinDate()
        {
            this.bunifuPrepaDate.MinDate = DateTime.Now;
        }
        public void loadDateOrderDropdown()
        {
            try
            {


                myClass.fillComboBoxStoreOrderApproval(this.cmbDateOrder, "tblStoreOrderDryWH_dropdown_Approval_Order_Date", this.dSet);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }

        private void ConnectionInit()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            if (myClass.g_objStoredProc.getConnected() == true)
            {
                g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections();


                this.Rpt_Path = ULTRAMAVERICK.Properties.Settings.Default.fdg;


                this.dgvStoreOrderApproval.Columns[0].Width = 50;// The id column
                this.dgvStoreOrderApproval.Columns[3].Width = 150;// The id column

            }
            else
            {
                MessageBox.Show("Unable to connect in sql server", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }


        public void loadCategoryDropdown()
        {
            try
            {

        
            myClass.fillComboBoxStoreOrderApproval(this.matcmbPackaging, "tblStoreOrderDryWH_dropdown_Approval", this.dSet);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }

        public void loadStoreDropdown()
        {
            try
            {


                myClass.fillComboBoxDepartment(this.metroCmbStoreCode, "tblStore_dropdown", this.dSet);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }

        DataSet dset_emp1 = new DataSet();
        private void load_search()
        {
         
                this.dset_emp1.Clear();

                this.dset_emp1 = objStorProc.sp_getMajorTables("searchorderForApprovalinDryWH");

                this.doSearch();
          

        }

        private void DataRefresher()
        {
            this.dset = g_objStoredProcCollection.sp_IDGenerator(0, "resetreceivingreprint", "", "", 6);
            sp_user_id = userinfo.user_id;
        }


        private void doSearch()
        {
            try
            {
                if (this.dset_emp1.Tables.Count > 0)
                {
                    DataView dv = new DataView(this.dset_emp1.Tables[0]);
                    if (myglobal.global_module == "EMPLOYEE")
                    {

                    }
                    else if (myglobal.global_module == "Active")
                    {

                        dv.RowFilter = "  category = '" + this.matcmbPackaging.Text + "' and  store_name = '" + this.metroCmbStoreCode.Text + "'  and  date_ordered = '" + this.cmbDateOrder.Text + "'      ";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {
                        //dv.RowFilter = "visitors_lastname like '%" + txtsearch.Text + "%' or visitors_firstname like '%" + txtsearch.Text + "%'";
                    }
                    this.dgvStoreOrderApproval.DataSource = dv;
                    this.lbltotaldata.Text = dgvStoreOrderApproval.RowCount.ToString();

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
        private void LoadDataWithParamsOrders()
        {
            //this.ConnectionInit();
            //MessageBox.Show(this.metroCmbStoreCode.Text);
            this.dset = g_objStoredProcCollection.sp_IDGenerator(1, "SearchStoreOrderforApproval", "All", this.matcmbPackaging.Text,0);
                this.dgvStoreOrderApproval.DataSource = dset.Tables[0];
                for (int i = 0; i <= dgvStoreOrderApproval.RowCount; i++)
                {
                    try
                    {
                        this.dgvStoreOrderApproval.Rows[i].Cells["selected"].Value = false;
                    }
                    catch (Exception) { }
                }




                this.lbltotaldata.Text = dgvStoreOrderApproval.RowCount.ToString();
            //MessageBox.Show(this.metroCmbStoreCode.Text);
        }
        private void matcmbPackaging_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //this.LoadDataWithParamsOrders();
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            this.load_search();
        }

        private void metroCmbStoreCode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //this.LoadDataWithParamsOrders();
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            this.load_search();
        }

        private void cmbDateOrder_SelectionChangeCommitted(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            this.load_search();
        }

        private void lbltotaldata_TextChanged(object sender, EventArgs e)
        {
            if (this.lbltotaldata.Text == "0")
            {
                this.materialCheckboxSelectAll.Visible = false;
                this.labelSelectedSum.Visible = false;

            }
            else
            {
                this.materialCheckboxSelectAll.Visible = true;
            }
        }
        int num = 0;
        private void dgvReprinting_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bool isChecked = (bool)dgvStoreOrderApproval.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;
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
                num++;
            }
            else
            {
                num--;
            }
            this.labelSelectedSum.Text = "Selected Items: " + num;
            this.labelSelectedSum.Visible = true;
            this.SaveButtonManipulator();
            this.EditManipulator();
        }
        private void EditManipulator()
        {
            if(this.num == 1)
            {
                this.matbtnPrint.Visible = true;
                this.matbtnEdit.Visible = true;
            }
            else
            {
                this.matbtnEdit.Visible = false;

            }
        }

        private void dgvReprinting_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bool isChecked = (bool)dgvStoreOrderApproval.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;
            CheckCount(isChecked);
        }

        private void lbltotaldata_Click(object sender, EventArgs e)
        {

        }
        private void ApproveFunctionality()
        {
            //myglobal.Searchcategory = txtSearch.Text;



            for (int i = 0; i <= dgvStoreOrderApproval.RowCount - 1; i++)
            {
                try
                {
                    if (dgvStoreOrderApproval.CurrentRow != null)
                    {

                        if (Convert.ToBoolean(dgvStoreOrderApproval.Rows[i].Cells["selected"].Value) == true)
                        {
                            this.dgvStoreOrderApproval.CurrentCell = this.dgvStoreOrderApproval.Rows[i].Cells[this.dgvStoreOrderApproval.CurrentCell.ColumnIndex];
                            dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvStoreOrderApproval.Rows[i].Cells["primary_id"].Value.ToString()), "PUTStoreOrderApproval", this.bunifuPrepaDate.Text, this.sp_user_id.ToString(), 1);

                        }
                        else
                        {
                            //dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepacking", "", "", 1);

                        }
                    }
                }
                catch (Exception ex)
                {

                    this.dgvStoreOrderApproval.CurrentCell = this.dgvStoreOrderApproval.Rows[i].Cells[this.dgvStoreOrderApproval.CurrentCell.ColumnIndex];
                    dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvStoreOrderApproval.Rows[i].Cells["primary_id"].Value.ToString()), "PUTStoreOrderApproval", this.bunifuPrepaDate.Text, this.sp_user_id.ToString(), 1);

                    MessageBox.Show(ex.Message);
                }

            }

            this.ApprovedSuccessfully();
            this.materialCheckboxSelectAll.Checked = false;
            this.labelSelectedSum.Visible = false;
            //this.mode = "start";
            //this.frmStoreOrderforApproval_Load(new object(), new System.EventArgs());
            this.ReturnFunctionality();
        }

        public void ApprovedSuccessfully()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Approved Successfully";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Green;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }

        private void AllocationiSRequiredNotify()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Allocation is required for " + this.total_item_for_allocation +  "record(s)";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Red;
            popup.Popup();

            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);

            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }
        private void matbtnPrint_Click(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            this.showRawMaterialforApproval();
            if (this.total_item_for_allocation == "0")
            {
           
            }
            else
            {
                AllocationiSRequiredNotify();
                return;
            }

            if (MetroFramework.MetroMessageBox.Show(this, "Approve the consolidated order ? ", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.ApproveFunctionality();
            }
            else
            {

                return;
            }
        }

        private void materialCheckboxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            this.materialCheckboxSelectAll.Text = "UnSelect ALL";

            for (int i = 0; i < this.dgvStoreOrderApproval.RowCount; i++) { this.dgvStoreOrderApproval.Rows[i].Cells[0].Value = true; }
            if(this.materialCheckboxSelectAll.Checked ==true)
            {
                this.labelSelectedSum.Visible = true;

                //MessageBox.Show(dgvReprinting.SelectedRows.Count.ToString());
             
                this.labelSelectedSum.Text = "Selected Items: " + this.dgvStoreOrderApproval.RowCount.ToString();
                this.num = this.dgvStoreOrderApproval.RowCount;
                this.SaveButtonManipulator();
              
            }
            else
            {
           
                this.materialCheckboxSelectAll.Text = "Select ALL";
                //this.labelSelectedSum.Visible = false;
                for (int i = 0; i < dgvStoreOrderApproval.RowCount; i++) { dgvStoreOrderApproval.Rows[i].Cells[0].Value = false; }
                this.labelSelectedSum.Text = "Selected Items: " + 0;
                this.num = 0;
                this.SaveButtonManipulator();
                this.frmStoreOrderforApproval_Load(sender, e);

            }
        }

        private void SaveButtonManipulator()
        {
            if (this.labelSelectedSum.Text == "0")
            {
                this.matbtnPrint.Visible = false;
            }
            else if(num == 0)
            {
                this.matbtnPrint.Visible = false;
            }
            else
            {
                this.matbtnPrint.Visible = true;
            }
        }
        private void labelSelectedSum_TextChanged(object sender, EventArgs e)
        {
            this.SaveButtonManipulator();
        }

        private void matbtnEdit_Click(object sender, EventArgs e)
        {
            //Visibility Controls
            this.matbtnEdit.Visible = false;
            this.matbtnPrint.Visible = false;
         


            frmEditConsolidatedOrder mywipwh = new frmEditConsolidatedOrder(this, 
                p_id,
                sp_order_id,
                sp_date_ordered,
                sp_fox,
                sp_store_name,
                sp_route,
                sp_area,
                sp_category,
                sp_item_code,
                sp_description,
                sp_uom,
                sp_qty,
                sp_StockOnHand,
                sp_Allocated_Qty
                );
            mywipwh.ShowDialog();
        }

        private void dgvReprinting_CurrentCellChanged(object sender, EventArgs e)
        {
            this.showDataGridDataValueChanged();
        }

        private void showDataGridDataValueChanged()
        {
            if (this.dgvStoreOrderApproval.Rows.Count > 0)
            {
                if (this.dgvStoreOrderApproval.CurrentRow != null)
                {
                    if (this.dgvStoreOrderApproval.CurrentRow.Cells["fox"].Value != null)
                    {
                        p_id = Convert.ToInt32(this.dgvStoreOrderApproval.CurrentRow.Cells["primary_id"].Value);
                       this.sp_order_id = Convert.ToInt32(this.dgvStoreOrderApproval.CurrentRow.Cells["order_id"].Value);
                        this.sp_date_ordered = this.dgvStoreOrderApproval.CurrentRow.Cells["date_ordered"].Value.ToString();
                        this.sp_fox = this.dgvStoreOrderApproval.CurrentRow.Cells["fox"].Value.ToString();
                        this.sp_store_name = this.dgvStoreOrderApproval.CurrentRow.Cells["store_name"].Value.ToString();
                        this.sp_route = this.dgvStoreOrderApproval.CurrentRow.Cells["route"].Value.ToString();
                        this.sp_area = this.dgvStoreOrderApproval.CurrentRow.Cells["area"].Value.ToString();
                        this.sp_category = this.dgvStoreOrderApproval.CurrentRow.Cells["category"].Value.ToString();
                        this.sp_item_code = this.dgvStoreOrderApproval.CurrentRow.Cells["item_code"].Value.ToString();
                        this.sp_description = this.dgvStoreOrderApproval.CurrentRow.Cells["description"].Value.ToString();
                        this.sp_uom = this.dgvStoreOrderApproval.CurrentRow.Cells["uom"].Value.ToString();
                        this.sp_qty = this.dgvStoreOrderApproval.CurrentRow.Cells["qty"].Value.ToString();
                        this.sp_StockOnHand = this.dgvStoreOrderApproval.CurrentRow.Cells["StockOnHand"].Value.ToString();
                        this.sp_Allocated_Qty = this.dgvStoreOrderApproval.CurrentRow.Cells["ALLOCATION_QTY"].Value.ToString();
                        
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Kupal");
            this.materialCheckboxSelectAll.Text = "Select All";
            //Reset the NUmber 
            this.textBox1.Text = String.Empty;
            this.num = 0;
            //Label Bugok
        
            this.labelSelectedSum.Visible = false;
            //this.frmStoreOrderforApproval_Load(sender, e);
            this.ReturnFunctionality();
        }

        private void cmbDateOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvStoreOrderApproval_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in dgvStoreOrderApproval.Rows)
            {
                if (Convert.ToDouble(row.Cells["ORDERS"].Value) >= Convert.ToDouble(row.Cells["StockOnHand"].Value))
                {
                    //row.Cells["buffer_of_stocks"].Style.BackColor = Color.LightGreen;
                    row.Cells["qty"].Style.BackColor = Color.DarkOrange;
                }
                else
                {
                    row.Cells["qty"].Style.BackColor = Color.White;
                }


                if (Convert.ToDouble(row.Cells["qty"].Value) < Convert.ToDouble(row.Cells["AVERAGE_ORDER"].Value))
                {
                    //row.Cells["buffer_of_stocks"].Style.BackColor = Color.LightGreen;
                    row.Cells["qty"].Style.BackColor = Color.Crimson;
                }


                if (Convert.ToDouble(row.Cells["StockOnHand"].Value) == Convert.ToDouble(row.Cells["ALLOCATION_QTY"].Value))
                {
                    //row.Cells["buffer_of_stocks"].Style.BackColor = Color.LightGreen;
                    row.Cells["qty"].Style.BackColor = Color.White;
                }

                if (Convert.ToDouble(row.Cells["StockOnHand"].Value) == 0)
                {
                    // row.DefaultCellStyle.BackColor = Color.LightSalmon; // Use it in order to colorize all cells of the row

                    row.Cells["qty"].Style.BackColor = Color.Crimson;
                }


                if (Convert.ToDouble(row.Cells["ALLOCATION_QTY"].Value) != 0)
                {
                    // row.DefaultCellStyle.BackColor = Color.LightSalmon; // Use it in order to colorize all cells of the row


                    if (Convert.ToDouble(row.Cells["ORDERS"].Value) == Convert.ToDouble(row.Cells["TOTAL_COLUMN_ALLOCATED_QTY"].Value))
                    {
                        //row.Cells["buffer_of_stocks"].Style.BackColor = Color.LightGreen;
                        row.Cells["qty"].Style.BackColor = Color.White;
                    }
                    else
                    {
                        row.Cells["qty"].Style.BackColor = Color.DarkOrange;
                    }

                }

                //else if (Convert.ToDouble(row.Cells["StockOnHand"].Value) == Convert.ToDouble(row.Cells["ALLOCATION_QTY"].Value))
                //{
                //    // row.DefaultCellStyle.BackColor = Color.LightSalmon; // Use it in order to colorize all cells of the row

                //    row.Cells["qty"].Style.BackColor = Color.White;
                //}


            }

        }
    }
}
