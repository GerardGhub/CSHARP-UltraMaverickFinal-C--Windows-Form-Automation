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
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    public partial class frmNewStoreOrderApproved : MaterialForm
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
        double stackQuantity = 0;
        public frmNewStoreOrderApproved()
        {
            InitializeComponent();
        }
        public int sp_user_id { get; set; }
        public string mode { get; set; }


        //Class Binding to oTher window
        public string sp_bind_selected { get; set; }
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
        public string sp_cancel_remarks { get; set; }
        public string sp_prepa_date_update { get; set; }
 
   

        private void frmAddNewStoreOrderApproved_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.ShowDataActivated();
            this.DataRefresher();
            this.ClearTextboxesStateMObX();
            myglobal.global_module = "Active";

     

      
            //Load The Data With Stored Procedure
            //this.LoadDataWithParamsOrders();
    
            if (this.mode == "start")
            {
                this.ConnectionInit();
                this.load_search();
                this.mode = "";
            }
            else
            {
                this.LoadDataActivatedforPreparation();

            }
            this.SaveButtonManipulator();
            this.DesignerSerializationVisibilityOninit();


            this.DataGridColumnDisabledEditing();
            this.DataGridHideColumn();
            if(this.lbltotaldata.Text != "0")
            {
                this.bunifuPrepaDate_ValueChanged(sender, e);
                this.dgvStoreOrderApproval.Columns["selected"].ReadOnly = false;
                this.dgvStoreOrderApproval.Enabled = true;

            }
        }
        private void ClearTextboxesStateMObX()
        {
            this.textBox1.Text = String.Empty;
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
            this.dgvStoreOrderApproval.Columns["DateDiff"].ReadOnly = true;
            this.dgvStoreOrderApproval.Columns["date_ordered"].ReadOnly = true;
        }
        private void DataGridHideColumn()
        {
            this.dgvStoreOrderApproval.Columns["route"].Visible = false;
            this.dgvStoreOrderApproval.Columns["area"].Visible = false;
            this.dgvStoreOrderApproval.Columns["date_added"].Visible = false;
            this.dgvStoreOrderApproval.Columns["is_approved_by"].Visible = false;
            this.dgvStoreOrderApproval.Columns["is_approved_date"].Visible = false;
        }
        private void LoadDataActivatedforPreparation()
        {
            this.ConnectionInit();
            this.dset_emp1.Clear();

            this.dset_emp1 = objStorProc.sp_getMajorTables("searchorderForApprovalinDryWH_isApproved");
            DataView dv = new DataView(this.dset_emp1.Tables[0]);

            this.dgvStoreOrderApproval.DataSource = dv;
            this.lbltotaldata.Text = dgvStoreOrderApproval.RowCount.ToString();
            this.lbltotalOrderQty.Text = "0";

            if (this.lbltotaldata.Text =="0")
            {
                this.groupBoxColorGuide.Visible = false;
            }
            else
            {
                this.groupBoxColorGuide.Visible = true;
            }
        }
        private void LoadDataCancelledforPreparation()
        {
            this.ConnectionInit();
            this.dset_emp1.Clear();

            this.dset_emp1 = objStorProc.sp_getMajorTables("searchorderForApprovalinDryWH_isCancelled");
            DataView dv = new DataView(this.dset_emp1.Tables[0]);

            this.dgvStoreOrderApproval.DataSource = dv;
            this.lbltotaldata.Text = dgvStoreOrderApproval.RowCount.ToString();
        }
        private void ShowDataActivated()
        {
            this.matRadioActive.Checked = true;
        }

        private void  DesignerSerializationVisibilityOninit()
        {
            //Order ID for Genus System
            this.dgvStoreOrderApproval.Columns["order_id"].Visible = false;
            //Order Primary KEy
            this.dgvStoreOrderApproval.Columns["primary_id"].Visible = false;
            this.matbtnCancel.Visible = false;
            this.matbtnEdit.Visible = false;
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
            }
            else
            {
                this.matbtnCancel.Visible = true;
            }
        }

        public void loadDateOrderDropdown()
        {
            try
            {


                myClass.fillComboBoxStoreOrderApprovalSync(this.cmbDateOrder, "tblStoreOrderDryWH_dropdown_Approval_Order_Date_isApproved", this.dSet, this.bunifuPrepaDate.Text, this.cmbDateOrder.Text, this.matcmbCategory.Text,this.metroCmbStoreCode.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }

        double num = 0;
        double num_static_value = 0;
     
        private void dgvReprinting_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool isChecked = (bool)dgvStoreOrderApproval.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;
            CheckCount(isChecked);

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
       
            this.labelSelectedSum.Text = "Selected Items: " + num;
            this.labelSelectedSum.Visible = true;
            this.SaveButtonManipulator();
            this.EditManipulator();
       
        }
        private void DeSelectedDataTotalOrderQuantity()
        {

            double sum = 0;
            double currentcellqty = Convert.ToDouble(this.sp_qty);

            stackQuantity -= currentcellqty;
            sum = stackQuantity;

            this.lbltotalOrderQty.Text = sum.ToString();
        }



        private void SelectedDataTotalOrderQuantity()
        {
      
            double sum = 0;
            double currentcellqty = Convert.ToDouble(this.sp_qty);
          

            if(num_static_value <= num)
            {
                //MessageBox.Show("Top"  + num);
                stackQuantity += currentcellqty;
                sum = stackQuantity;
            }
            else
            {
                //MessageBox.Show("Bottom" + num_static_value);
                stackQuantity -= currentcellqty;
                sum = stackQuantity;
            }
   

            this.lbltotalOrderQty.Text = sum.ToString();
        }

        private void EditManipulator()
        {
            if (this.num == 1)
            {
                this.matbtnCancel.Visible = true;
                this.matbtnEdit.Visible = true;
            }
            else
            {
                //this.matbtnEdit.Visible = false;

            }
        }

        DataSet dset_emp1 = new DataSet();
        private void load_search()
        {

            this.dset_emp1.Clear();

            this.dset_emp1 = objStorProc.sp_getMajorTables("searchorderForApprovalinDryWH_isApproved");

            this.doSearch();


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
                        if (this.mode == "Search1")
                        {
                            dv.RowFilter = "is_approved_prepa_date = '" + this.bunifuPrepaDate.Text + "'     ";
                        }
                         else if(this.mode == "Search2")
                        {
                            dv.RowFilter = " is_approved_prepa_date = '" + this.bunifuPrepaDate.Text + "' and   date_ordered = '" + this.cmbDateOrder.Text + "'  ";
                        }
                        else if (this.mode == "Search3")
                        {
                            dv.RowFilter = " is_approved_prepa_date = '" + this.bunifuPrepaDate.Text + "' and   date_ordered = '" + this.cmbDateOrder.Text + "' and   category = '" + this.matcmbCategory.Text + "'  ";
                        }
                        else if (this.mode == "Search4")
                        {
                            dv.RowFilter = " is_approved_prepa_date = '" + this.bunifuPrepaDate.Text + "' and   date_ordered = '" + this.cmbDateOrder.Text + "' and   category = '" + this.matcmbCategory.Text + "' and  store_name = '" + this.metroCmbStoreCode.Text + "'  ";
                        }
                        else
                        {
                            //dv.RowFilter = "is_approved_prepa_date = '" + this.bunifuPrepaDate.Text + "'     ";
                        }




                        //dv.RowFilter = "  category = '" + this.matcmbPackaging.Text + "' and  store_name = '" + this.metroCmbStoreCode.Text + "'  and is_approved_prepa_date = '" + this.bunifuPrepaDate.Text + "'     ";


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
        private void DataRefresher()
        {
            this.dset = g_objStoredProcCollection.sp_IDGenerator(0, "resetreceivingreprint", "", "", 6);
            sp_user_id = userinfo.user_id;
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


                myClass.fillComboBoxStoreOrderApprovalSync(this.matcmbCategory, "tblStoreOrderDryWH_dropdown_Approval_isApproved", this.dSet, this.bunifuPrepaDate.Text, this.cmbDateOrder.Text, this.matcmbCategory.Text, this.metroCmbStoreCode.Text);

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


                myClass.fillComboBoxStoreOrderApprovalSyncStore(this.metroCmbStoreCode, "tblStore_dropdown_isApproved", this.dSet, this.bunifuPrepaDate.Text, this.cmbDateOrder.Text, this.matcmbCategory.Text, this.metroCmbStoreCode.Text);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }

        private void dgvStoreOrderApproval_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvStoreOrderApproval.Rows)
            {
                if (1 == Convert.ToDouble(row.Cells["DateDiff"].Value) || 0 == Convert.ToDouble(row.Cells["DateDiff"].Value))
                {

                    row.Cells["DateDiff"].Style.BackColor = Color.Green;
                    row.Cells["selected"].Style.BackColor = Color.Green;

                    //dgvStoreOrderApproval.Rows[Convert.ToInt32(row.Cells["DateDiff"].Value)].DefaultCellStyle.BackColor = Color.Green;
                }
                else if (2 == Convert.ToDouble(row.Cells["DateDiff"].Value) || 3 == Convert.ToDouble(row.Cells["DateDiff"].Value) || 4 == Convert.ToDouble(row.Cells["DateDiff"].Value) || 5 == Convert.ToDouble(row.Cells["DateDiff"].Value))
                {
                    row.Cells["DateDiff"].Style.BackColor = Color.Yellow;
                    row.Cells["selected"].Style.BackColor = Color.Yellow;
                    //this.dgvStoreOrderApproval.Rows[Convert.ToInt32(row.Cells["DateDiff"].Value)].DefaultCellStyle.BackColor = Color.Yellow;

                }
     
            else
                {

                    // Use it in order to colorize all cells of the row
                    row.Cells["DateDiff"].Style.BackColor = Color.White;
                    row.Cells["selected"].Style.BackColor = Color.White;
                    //this.dgvStoreOrderApproval.Rows[Convert.ToInt32(row.Cells["DateDiff"].Value)].DefaultCellStyle.BackColor = Color.White;
                }
            }
        }

        private void cmbDateOrder_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.loadCategoryDropdown();
            this.mode = "Search2";

            this.load_search();
            this.checkIfAlreadyPrepared();
        }

        private void matcmbPackaging_SelectionChangeCommitted(object sender, EventArgs e)
        {
          
            this.ConnectionInit();
            this.loadStoreDropdown();
            this.mode = "Search3";

            this.load_search();
            this.checkIfAlreadyPrepared();



        }

        private void metroCmbStoreCode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //this.ConnectionInit();
            //this.load_search();
            this.mode = "Search4";
            this.ConnectionInit();
            this.load_search();
            this.checkIfAlreadyPrepared();
        }

        private void bunifuPrepaDate_ValueChanged(object sender, EventArgs e)
        {
            this.mode = "Search1";
            this.ConnectionInit();
            this.loadDateOrderDropdown();
            this.load_search();
            this.checkIfAlreadyPrepared();


        }

        private void dgvStoreOrderApproval_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void labelSelectedSum_TextChanged(object sender, EventArgs e)
        {
            if(num == 0)
            {
                if(this.materialCheckboxSelectAll.Checked == true)
                {

                }
                else
                {
                    this.frmAddNewStoreOrderApproved_Load(sender, e);
                }
         



             }
            else
            {
                this.SelectedDataTotalOrderQuantity();
            }
            //
          
        }

        private void dgvStoreOrderApproval_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
   
        }

        private void metroCmbStoreCode_Validated(object sender, EventArgs e)
        {
            
        }

        private void dgvStoreOrderApproval_CurrentCellChanged(object sender, EventArgs e)
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
                    }
                }
            }
        }

        private void labelSelectedSum_Click(object sender, EventArgs e)
        {

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

        private void CountAllQtyOrder()
        {
            int sum = 0;
            for (int i = 0; i < this.dgvStoreOrderApproval.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(this.dgvStoreOrderApproval.Rows[i].Cells["qty"].Value);
            }
            this.lbltotalOrderQty.Text = sum.ToString();
        }

        private void materialCheckboxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
       


            if (this.materialCheckboxSelectAll.Checked == true)
            {
                this.labelSelectedSum.Visible = true;
                this.materialCheckboxSelectAll.Text = "UnSelect ALL";
                for (int i = 0; i < this.dgvStoreOrderApproval.RowCount; i++) { this.dgvStoreOrderApproval.Rows[i].Cells[0].Value = true; }
                //MessageBox.Show(dgvReprinting.SelectedRows.Count.ToString());

                this.labelSelectedSum.Text = "Selected Items: " + this.dgvStoreOrderApproval.RowCount.ToString();
                this.num = this.dgvStoreOrderApproval.RowCount;
                this.SaveButtonManipulator();
                this.CountAllQtyOrder();
            }
            else
            {
                this.materialCheckboxSelectAll.Text = "Select ALL";
                //this.labelSelectedSum.Visible = false;
                for (int i = 0; i < dgvStoreOrderApproval.RowCount; i++) { dgvStoreOrderApproval.Rows[i].Cells[0].Value = false; }
                this.labelSelectedSum.Text = "Selected Items: " + 0;
                this.num = 0;
                this.SaveButtonManipulator();
                this.lbltotalOrderQty.Text = "0";
            }
        }

        private void matbtnCancel_Click(object sender, EventArgs e)
        {
            this.matbtnCancel.Visible = false;
            this.matbtnEdit.Visible = false;
            if (this.matbtnCancel.Text == "CANCEL")
            {
                frmCancelApprovedOrder FormCancelOrderRemarks = new frmCancelApprovedOrder(this);
                FormCancelOrderRemarks.ShowDialog();
            }
            else
            {
               frmReturnApprovedOrder ReturnedOrderRemarks = new frmReturnApprovedOrder(this);
                ReturnedOrderRemarks.ShowDialog();
            }

        }
        private void CancelFunctionality()
        {

            if (this.matRadioNotActive.Checked == true)
            {
                for (int i = 0; i <= dgvStoreOrderApproval.RowCount - 1; i++)
                {
                    try
                    {
                        if (dgvStoreOrderApproval.CurrentRow != null)
                        {

                            if (Convert.ToBoolean(dgvStoreOrderApproval.Rows[i].Cells["selected"].Value) == true)
                            {
                                this.dgvStoreOrderApproval.CurrentCell = this.dgvStoreOrderApproval.Rows[i].Cells[this.dgvStoreOrderApproval.CurrentCell.ColumnIndex];
                                dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvStoreOrderApproval.Rows[i].Cells["primary_id"].Value.ToString()), "PUTReturnedStoreOrderApproved", this.sp_cancel_remarks, this.sp_user_id.ToString(), 1);

                            }
                            else
                            {

                            }
                        }
                    }

                    catch (Exception ex)
                    {

                        this.dgvStoreOrderApproval.CurrentCell = this.dgvStoreOrderApproval.Rows[i].Cells[this.dgvStoreOrderApproval.CurrentCell.ColumnIndex];
                        dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvStoreOrderApproval.Rows[i].Cells["primary_id"].Value.ToString()), "PUTReturnedStoreOrderApproved", this.sp_cancel_remarks, this.sp_user_id.ToString(), 1);

                        MessageBox.Show(ex.Message);
                    }

                }
            }
            else
            {

                for (int i = 0; i <= dgvStoreOrderApproval.RowCount - 1; i++)
                {
                    try
                    {
                        if (dgvStoreOrderApproval.CurrentRow != null)
                        {

                            if (Convert.ToBoolean(dgvStoreOrderApproval.Rows[i].Cells["selected"].Value) == true)
                            {
                                this.dgvStoreOrderApproval.CurrentCell = this.dgvStoreOrderApproval.Rows[i].Cells[this.dgvStoreOrderApproval.CurrentCell.ColumnIndex];
                                dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvStoreOrderApproval.Rows[i].Cells["primary_id"].Value.ToString()), "PUTStoreOrderApprovedCancel", this.sp_cancel_remarks, this.sp_user_id.ToString(), 1);

                            }
                            else
                            {

                            }
                        }
                    }
                    catch (Exception ex)
                    {

                        this.dgvStoreOrderApproval.CurrentCell = this.dgvStoreOrderApproval.Rows[i].Cells[this.dgvStoreOrderApproval.CurrentCell.ColumnIndex];
                        dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvStoreOrderApproval.Rows[i].Cells["primary_id"].Value.ToString()), "PUTStoreOrderApprovedCancel", this.sp_cancel_remarks, this.sp_user_id.ToString(), 1);

                        MessageBox.Show(ex.Message);
                    }

                }

                //End
            }

            this.CancelledSuccessfully();
            this.materialCheckboxSelectAll.Checked = false;
            this.labelSelectedSum.Visible = false;
            //this.mode = "start";
           
            this.frmAddNewStoreOrderApproved_Load(new object(), new System.EventArgs());
        }

        public void CancelledSuccessfully()
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

        private void matRadioActive_CheckedChanged(object sender, EventArgs e)
        {
            if (matRadioActive.Checked == true)
            {
                this.sp_bind_selected = "1";

                this.matbtnCancel.Text = "CANCEL";
                this.frmAddNewStoreOrderApproved_Load(sender, e);
         
            }
            else if (matRadioNotActive.Checked == true)
            {
                this.sp_bind_selected = "0";

                this.LoadDataCancelledforPreparation();
                //this.SearchMethodJarVarCallingSP();
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


                this.frmAddNewStoreOrderApproved_Load(sender, e);

            }
            else if (matRadioNotActive.Checked == true)
            {
                this.sp_bind_selected = "0";

                this.LoadDataCancelledforPreparation();
                this.lbltotalOrderQty.Text = "0";
                this.matbtnCancel.Text = "RETURN";
                //this.SearchMethodJarVarCallingSP();
            }
            else
            {

            }
        }

        private void UpdatePreparationDate()
        {
            for (int i = 0; i <= dgvStoreOrderApproval.RowCount - 1; i++)
            {
                try
                {
                    if (dgvStoreOrderApproval.CurrentRow != null)
                    {

                        if (Convert.ToBoolean(dgvStoreOrderApproval.Rows[i].Cells["selected"].Value) == true)
                        {
                            this.dgvStoreOrderApproval.CurrentCell = this.dgvStoreOrderApproval.Rows[i].Cells[this.dgvStoreOrderApproval.CurrentCell.ColumnIndex];
                            dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvStoreOrderApproval.Rows[i].Cells["primary_id"].Value.ToString()), "PUTPreparationStoreOrderApproved", this.sp_prepa_date_update, this.sp_user_id.ToString(), 1);

                        }
                        else
                        {

                        }
                    }
                }

                catch (Exception ex)
                {

                    this.dgvStoreOrderApproval.CurrentCell = this.dgvStoreOrderApproval.Rows[i].Cells[this.dgvStoreOrderApproval.CurrentCell.ColumnIndex];
                    dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvStoreOrderApproval.Rows[i].Cells["primary_id"].Value.ToString()), "PUTPreparationStoreOrderApproved", this.sp_prepa_date_update, this.sp_user_id.ToString(), 1);

                    MessageBox.Show(ex.Message);
                }

            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(this.textBox1.Text == String.Empty)
            {
            
            }
    
    
            else if(this.textBox1.Text == "Disconnect")
            {
                if(num == 0)
                {

                }
                //else if(num == 1)
                //{
                //    this.matbtnEdit.Visible = true;
                //}
                else
                {
                    this.matbtnEdit.Visible = true;
                    this.matbtnCancel.Visible = true;
                }
            }
            else
            {
                this.sp_cancel_remarks = this.textBox1.Text;
                this.CancelFunctionality();
            }
        }

        private void matbtnEdit_Click(object sender, EventArgs e)
        {
            this.matbtnEdit.Visible = false;
            this.matbtnCancel.Visible = false;
        
            frmStoreApprovedOrderUpdatePreparationDate updatePrepaDate = 
                new frmStoreApprovedOrderUpdatePreparationDate(this, this.bunifuPrepaDate.Text, this.sp_category);
            updatePrepaDate.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //IS For Preparation POPUP
            this.sp_prepa_date_update = this.textBox2.Text;
            //MessageBox.Show(this.sp_prepa_date_update);
            this.UpdatePreparationDate();


            this.frmAddNewStoreOrderApproved_Load(sender, e);
        }


        public void UnabledToCancelItemAlreadyPrepared()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Unable to modify item already prepared!";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Crimson;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }

        private void checkIfAlreadyPrepared()
        {
            //Update Status Already Repack
            dSet.Clear();
            dSet = objStorProc.sp_Store_Preparation_Logs(0,
            "",
            this.bunifuPrepaDate.Text,
            "", "", "", "", "", "", 0,
              this.matcmbCategory.Text, "", this.metroCmbStoreCode.Text,
            "check_if_already_prepared");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                this.UnabledToCancelItemAlreadyPrepared();
                this.dgvStoreOrderApproval.Enabled = false;
            }
            else
            {
                if(this.bunifuPrepaDate.Text == String.Empty)
                {
                    return;
                }

                if (this.matcmbCategory.Text == String.Empty)
                {
                    return;
                }

                if (this.metroCmbStoreCode.Text == String.Empty)
                {
                    return;
                }

                this.dgvStoreOrderApproval.Enabled = true;
                //MessageBox.Show("B");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Update Status Already Repack
            dSet.Clear();
            dSet = objStorProc.sp_Store_Preparation_Logs(0,
            "",
            this.bunifuPrepaDate.Text,
            "","","","","","",0,
              this.matcmbCategory.Text, "", this.metroCmbStoreCode.Text,
            "check_if_already_prepared");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                this.UnabledToCancelItemAlreadyPrepared();
            }
            else
            {
                //MessageBox.Show("B");
            }
        }
    }
}
