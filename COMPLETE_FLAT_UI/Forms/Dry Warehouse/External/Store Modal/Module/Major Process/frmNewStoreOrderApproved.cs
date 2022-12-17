using COMPLETE_FLAT_UI.Models;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    public partial class frmNewStoreOrderApproved : MaterialForm
    {
        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        int MyCurrentRowIndex = 0;
        public DataSet dset = new DataSet();
         DataSet dset2 = new DataSet();
         DataSet dset3 = new DataSet();
         DataSet dSet = new DataSet();
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        int p_id = 0;
        string Rpt_Path = "";
        double stackQuantity = 0;
        int TotalPreparedItemsSummary = 0;
        public frmNewStoreOrderApproved()
        {
            InitializeComponent();
        }
        public int Sp_user_id { get; set; }
        public string Mode { get; set; }
        public string Sp_bind_selected { get; set; }
        public int Sp_order_id { get; set; }
        public string Sp_date_ordered { get; set; }
        public string Sp_fox { get; set; }
        public string Sp_store_name { get; set; }
        public string Sp_route { get; set; }
        public string Sp_area { get; set; }
        public string Sp_category { get; set; }
        public string Sp_item_code { get; set; }
        public string Sp_description { get; set; }
        public string Sp_uom { get; set; }
        public string Sp_qty { get; set; }
        public string Sp_cancel_remarks { get; set; }
        public string sp_prepa_date_update { get; set; }
        public string Sp_Allocated_Qty { get; set; }

        private void frmAddNewStoreOrderApproved_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.ShowDataActivated();
            this.DataRefresher();
            this.ClearTextboxesStateMObX();
            myglobal.global_module = "Active";

            if (this.Mode == "start")
            {
                this.ConnectionInit();
                this.load_search();
                this.Mode = "";
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
            this.dgvStoreOrderApproval.Columns["qty_original"].Visible = false;
        }
        private void LoadDataActivatedforPreparation()
        {
            this.ConnectionInit();
            this.dset_emp1.Clear();

            this.dset_emp1 = g_objStoredProcCollection.sp_getMajorTables("searchorderForApprovalinDryWH_isApproved");
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
            this.dset_emp1 = g_objStoredProcCollection.sp_getMajorTables("searchorderForApprovalinDryWH_isCancelled");
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
                if (this.TotalPreparedItemsSummary == 0)
                {
                    this.matbtnCancel.Visible = true;
                }
            }
        }

        public void loadAreaDropdown()
        {
            try
            {
                myClass.fillComboBoxStoreOrderApprovalSync(this.cmbArea, "tblStoreOrderDryWH_dropdown_Area", this.dSet, this.bunifuPrepaDate.Text, this.matcmbCategory.Text, this.matcmbCategory.Text, this.metroCmbStoreCode.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //this.lblMajorCatId.Text = cboMajorCategory.SelectedValue.ToString();
        }

        double num = 0;
        double num_static_value = 0;
     

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
            double currentcellqty = Convert.ToDouble(this.Sp_qty);

            stackQuantity -= currentcellqty;
            sum = stackQuantity;

            this.lbltotalOrderQty.Text = sum.ToString();
        }

        private void SelectedDataTotalOrderQuantity()
        {     
            double sum = 0;
            double currentcellqty = Convert.ToDouble(this.Sp_qty);
   
            if(num_static_value <= num)
            {
                //MessageBox.Show("Top"  + num);
                stackQuantity += currentcellqty;
                sum = stackQuantity;
            }
            else
            {
                stackQuantity -= currentcellqty;
                sum = stackQuantity;
            }
            this.lbltotalOrderQty.Text = sum.ToString();
        }

        private void EditManipulator()
        {
            if (this.num == 1)
            {
                if(this.TotalPreparedItemsSummary == 0 )
                {
                    this.matbtnCancel.Visible = true;
                    this.matbtnEdit.Visible = true;
                }
    
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
            this.dset_emp1 = g_objStoredProcCollection.sp_getMajorTables("searchorderForApprovalinDryWH_isApproved");
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
                        if (this.Mode == "Search1")
                        {
                            dv.RowFilter = "is_approved_prepa_date = '" + this.bunifuPrepaDate.Text + "' and category = '" + this.matcmbCategory.Text + "'     ";
                        }
                         else if(this.Mode == "Search2") // for Fucking Category dv.RowFilter = " is_approved_prepa_date = '" + this.bunifuPrepaDate.Text + "' and   date_ordered = '" + this.cmbDateOrder.Text + "'  ";
                        {
                            dv.RowFilter = " is_approved_prepa_date = '" + this.bunifuPrepaDate.Text + "'  ";
                        }
                        else if (this.Mode == "Search3")
                        {
                            dv.RowFilter = " is_approved_prepa_date = '" + this.bunifuPrepaDate.Text + "' and   area = '" + this.cmbArea.Text + "' and   category = '" + this.matcmbCategory.Text + "'  ";
                        }
                        else if (this.Mode == "Search4")
                        {
                            dv.RowFilter = " is_approved_prepa_date = '" + this.bunifuPrepaDate.Text + "' and area = '" + this.cmbArea.Text + "' and   category = '" + this.matcmbCategory.Text + "' and  store_name = '" + this.metroCmbStoreCode.Text + "'  ";
                        }
                        else
                        {
                            //dv.RowFilter = "is_approved_prepa_date = '" + this.bunifuPrepaDate.Text + "'     ";
                        }
                    }
                    this.dgvStoreOrderApproval.DataSource = dv;
                    this.lbltotaldata.Text = dgvStoreOrderApproval.RowCount.ToString();
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
            this.dset = g_objStoredProcCollection.sp_IDGenerator(0, "resetreceivingreprint", "", "", 6, 0);
            Sp_user_id = userinfo.user_id;
        }

        private void ConnectionInit()
        {
   
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
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
                myClass.fillComboBoxStoreOrderApprovalSync(this.matcmbCategory, "tblStoreOrderDryWH_dropdown_Approval_isApproved", this.dSet, this.bunifuPrepaDate.Text, this.cmbArea.Text, this.matcmbCategory.Text, this.metroCmbStoreCode.Text);
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
                myClass.fillComboBoxStoreOrderApprovalSyncStore(this.metroCmbStoreCode, "tblStore_dropdown_isApproved", this.dSet, this.bunifuPrepaDate.Text, this.cmbArea.Text, this.matcmbCategory.Text, this.metroCmbStoreCode.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvStoreOrderApproval_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvStoreOrderApproval.Rows)
            {
                if (1 == Convert.ToDouble(row.Cells["DateDiff"].Value) || 0 == Convert.ToDouble(row.Cells["DateDiff"].Value))
                {
                    row.Cells["DateDiff"].Style.BackColor = Color.Green;
                    row.Cells["selected"].Style.BackColor = Color.Green;
                }
                else if (2 == Convert.ToDouble(row.Cells["DateDiff"].Value) || 3 == Convert.ToDouble(row.Cells["DateDiff"].Value) || 4 == Convert.ToDouble(row.Cells["DateDiff"].Value) || 5 == Convert.ToDouble(row.Cells["DateDiff"].Value))
                {
                    row.Cells["DateDiff"].Style.BackColor = Color.Yellow;
                    row.Cells["selected"].Style.BackColor = Color.Yellow;                
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
            this.loadStoreDropdown();
            this.Mode = "Search3";

            if (this.metroCmbStoreCode.Text != String.Empty)
            {
                this.metroCmbStoreCode.SelectedIndex = -1;
            }
            this.load_search();
            this.checkIfAlreadyPrepared();

        }

        private void matcmbPackaging_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.Mode = "Search1";
            this.ConnectionInit();
            this.loadAreaDropdown(); //Puke
            if (this.metroCmbStoreCode.Text != String.Empty)
            {
                this.metroCmbStoreCode.SelectedIndex = -1;
            }

            if (this.cmbArea.Text != String.Empty)
            {
                this.cmbArea.SelectedIndex = -1;
            }


            this.load_search();
            this.checkIfAlreadyPrepared();
        }

        private void metroCmbStoreCode_SelectionChangeCommitted(object sender, EventArgs e)
        {          
            this.Mode = "Search4";
            this.ConnectionInit();
            this.load_search();
            this.checkIfAlreadyPrepared();
        }

        private void bunifuPrepaDate_ValueChanged(object sender, EventArgs e)
        {
 
            this.ConnectionInit();
            this.loadCategoryDropdown();
            this.Mode = "Search2";

            if (this.matcmbCategory.Text != String.Empty)
            {
                this.matcmbCategory.SelectedIndex = -1;

            }

            if (this.metroCmbStoreCode.Text != String.Empty)
            {
                this.metroCmbStoreCode.SelectedIndex = -1;

            }

            if (this.cmbArea.Text != String.Empty)
            {


                this.cmbArea.SelectedIndex = -1;
            }


            this.load_search();
            this.checkIfAlreadyPrepared();
            this.ValidateReadonlyDataGridView();
            


        }


        private void ValidateReadonlyDataGridView()
        {
            this.TotalPreparedItemsSummary = 0;




            for (int i = 0; i < this.dgvStoreOrderApproval.RowCount; i++)
            {

                if (this.dgvStoreOrderApproval.Rows[i].Cells["TotalPreparedItems"].Value.ToString() == "0")
                {

                }
                else
                {
                    this.TotalPreparedItemsSummary++;
       
                }


            }

            this.lblSummaryPrepared.Text = TotalPreparedItemsSummary.ToString();
            if(this.TotalPreparedItemsSummary > 0)
            {
              
                    this.matbtnCancel.Visible = false;
                    this.matbtnEdit.Visible = false;

            }

            if (this.dgvStoreOrderApproval.RowCount == 0)
            {
                this.TotalPreparedItemsSummary = 0;
                lblSummaryPrepared.Text = TotalPreparedItemsSummary.ToString();
            }
            num = 0;
            this.labelSelectedSum.Text = "Selected Items: " + num;
        }


        private void dgvStoreOrderApproval_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            

                bool isChecked = (bool)dgvStoreOrderApproval.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;
                CheckCount(isChecked);
                if(num == 0)
                {
                  this.materialCheckboxSelectAll.Checked = false;
                }
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
                        this.MyCurrentRowIndex = this.dgvStoreOrderApproval.CurrentCell.RowIndex;
                        p_id = Convert.ToInt32(this.dgvStoreOrderApproval.CurrentRow.Cells["primary_id"].Value);
                        this.Sp_order_id = Convert.ToInt32(this.dgvStoreOrderApproval.CurrentRow.Cells["order_id"].Value);
                        this.Sp_date_ordered = this.dgvStoreOrderApproval.CurrentRow.Cells["date_ordered"].Value.ToString();
                        this.Sp_fox = this.dgvStoreOrderApproval.CurrentRow.Cells["fox"].Value.ToString();
                        this.Sp_store_name = this.dgvStoreOrderApproval.CurrentRow.Cells["store_name"].Value.ToString();
                        this.Sp_route = this.dgvStoreOrderApproval.CurrentRow.Cells["route"].Value.ToString();
                        this.Sp_area = this.dgvStoreOrderApproval.CurrentRow.Cells["area"].Value.ToString();
                        this.Sp_category = this.dgvStoreOrderApproval.CurrentRow.Cells["category"].Value.ToString();
                        this.Sp_item_code = this.dgvStoreOrderApproval.CurrentRow.Cells["item_code"].Value.ToString();
                        this.Sp_description = this.dgvStoreOrderApproval.CurrentRow.Cells["description"].Value.ToString();
                        this.Sp_uom = this.dgvStoreOrderApproval.CurrentRow.Cells["uom"].Value.ToString();
                        this.Sp_qty = this.dgvStoreOrderApproval.CurrentRow.Cells["qty"].Value.ToString();
                        this.Sp_Allocated_Qty = this.dgvStoreOrderApproval.CurrentRow.Cells["ALLOCATION_QTY"].Value.ToString();
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
                sum += Convert.ToInt32(this.dgvStoreOrderApproval.Rows[i].Cells["qty_original"].Value);
            }
            //MessageBox.Show(sum.ToString());
            this.lbltotalOrderQty.Text = sum.ToString();
        }

        private void materialCheckboxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //Start of the code block




                if (this.materialCheckboxSelectAll.Checked == true)
                {
                   
                    this.labelSelectedSum.Visible = true;
                    this.materialCheckboxSelectAll.Text = "UnSelect ALL";
                    for (int i = 0; i < this.dgvStoreOrderApproval.RowCount; i++) { this.dgvStoreOrderApproval.Rows[i].Cells[0].Value = true; }
          
                    if (this.lbltotaldata.Text != "0")
                    {
                        this.matbtnEdit.Visible = true;
                    }

                    this.labelSelectedSum.Text = "Selected Items: " + this.dgvStoreOrderApproval.RowCount.ToString();
                    this.num = this.dgvStoreOrderApproval.RowCount;
                
                    this.SaveButtonManipulator();
               
                    this.CountAllQtyOrder();
                    
                }
                else
               


                {
                    this.materialCheckboxSelectAll.Text = "Select ALL";


                    for (int i = 0; i < dgvStoreOrderApproval.RowCount; i++) { dgvStoreOrderApproval.Rows[i].Cells[0].Value = false; }
                    this.labelSelectedSum.Text = "Selected Items: " + 0;
                    this.num = 0;
                    this.SaveButtonManipulator();
                    this.lbltotalOrderQty.Text = "0";
                    if (this.num == 0)
                    {
                        this.matbtnEdit.Visible = false;
                    }
                }


                //End of the code block
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
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
                                dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvStoreOrderApproval.Rows[i].Cells["primary_id"].Value.ToString()),
                                    "PUTReturnedStoreOrderApproved", 
                                    this.Sp_cancel_remarks, 
                                    this.Sp_user_id.ToString(), 1, 0);

                            }
                            else
                            {

                            }
                        }
                    }

                    catch (Exception ex)
                    {

                        this.dgvStoreOrderApproval.CurrentCell = this.dgvStoreOrderApproval.Rows[i].Cells[this.dgvStoreOrderApproval.CurrentCell.ColumnIndex];
                        dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvStoreOrderApproval.Rows[i].Cells["primary_id"].Value.ToString()), 
                            "PUTReturnedStoreOrderApproved", 
                            this.Sp_cancel_remarks, 
                            this.Sp_user_id.ToString(), 1, 0);

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
                                this.dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvStoreOrderApproval.Rows[i].Cells["primary_id"].Value.ToString()), 
                                    "PUTStoreOrderApprovedCancel", 
                                    this.Sp_cancel_remarks, 
                                    this.Sp_user_id.ToString(), 1, 0);

                            }
                            else
                            {

                            }
                        }
                    }
                    catch (Exception ex)
                    {

                        this.dgvStoreOrderApproval.CurrentCell = this.dgvStoreOrderApproval.Rows[i].Cells[this.dgvStoreOrderApproval.CurrentCell.ColumnIndex];
                        dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvStoreOrderApproval.Rows[i].Cells["primary_id"].Value.ToString()), 
                            "PUTStoreOrderApprovedCancel", 
                            this.Sp_cancel_remarks, 
                            this.Sp_user_id.ToString(), 1, 0);

                        MessageBox.Show(ex.Message);
                    }

                }

                //End
            }

            this.GlobalStatePopup.CancelledSuccessfully();
            this.materialCheckboxSelectAll.Checked = false;
            this.labelSelectedSum.Visible = false;
            //this.mode = "start";
           
            this.frmAddNewStoreOrderApproved_Load(new object(), new System.EventArgs());
        }


        private void matRadioActive_CheckedChanged(object sender, EventArgs e)
        {
            if (matRadioActive.Checked == true)
            {
                this.Sp_bind_selected = "1";

                this.matbtnCancel.Text = "CANCEL";
                this.frmAddNewStoreOrderApproved_Load(sender, e);
         
            }
            else if (matRadioNotActive.Checked == true)
            {
                this.Sp_bind_selected = "0";

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
                this.Sp_bind_selected = "1";


                this.frmAddNewStoreOrderApproved_Load(sender, e);

            }
            else if (matRadioNotActive.Checked == true)
            {
                this.Sp_bind_selected = "0";

                this.LoadDataCancelledforPreparation();
                this.lbltotalOrderQty.Text = "0";
                this.matbtnCancel.Text = "RETURN";
    
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
                            dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvStoreOrderApproval.Rows[i].Cells["primary_id"].Value.ToString()), "PUTPreparationStoreOrderApproved", 
                                this.sp_prepa_date_update, this.Sp_user_id.ToString(), 1, 0);

                        }
                        else
                        {

                        }
                    }
                }

                catch (Exception ex)
                {

                    this.dgvStoreOrderApproval.CurrentCell = this.dgvStoreOrderApproval.Rows[i].Cells[this.dgvStoreOrderApproval.CurrentCell.ColumnIndex];
                    dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvStoreOrderApproval.Rows[i].Cells["primary_id"].Value.ToString()), 
                        "PUTPreparationStoreOrderApproved", 
                        this.sp_prepa_date_update, 
                        this.Sp_user_id.ToString(), 1, 0);

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

                else
                {
                    if (this.TotalPreparedItemsSummary == 0)
                    {
                        this.matbtnEdit.Visible = true;
                        this.matbtnCancel.Visible = true;
                    }
                }
            }
            else
            {
                this.Sp_cancel_remarks = this.textBox1.Text;
                this.CancelFunctionality();
            }
        }

        private void matbtnEdit_Click(object sender, EventArgs e)
        {
            this.matbtnEdit.Visible = false;
            this.matbtnCancel.Visible = false;
        
            frmStoreApprovedOrderUpdatePreparationDate updatePrepaDate = 
                new frmStoreApprovedOrderUpdatePreparationDate(this, 
                this.bunifuPrepaDate.Text, 
                this.Sp_category);
            updatePrepaDate.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(this.textBox2.Text =="resetform")
            {
                this.num = 0;
                this.labelSelectedSum.Text = "Selected Items:0";
                this.frmAddNewStoreOrderApproved_Load(sender, e);
            }
            else
            {
                //IS For Preparation POPUP
                this.sp_prepa_date_update = this.textBox2.Text;
                //MessageBox.Show(this.sp_prepa_date_update);
                this.UpdatePreparationDate();

                this.num = 0;
                this.labelSelectedSum.Text = "Selected Items:0";
                this.frmAddNewStoreOrderApproved_Load(sender, e);
            }

        }



        private void checkIfAlreadyPrepared()
        {
            //Update Status Already Repack
            this.dSet.Clear();
            this.dSet = g_objStoredProcCollection.sp_Store_Preparation_Logs(0,
            "",
            this.bunifuPrepaDate.Text,
            "",
            "",
            "",
            "",
            "",
            "",
            0,
              this.matcmbCategory.Text,
              "",
              this.metroCmbStoreCode.Text, 
              0,
            "check_if_already_prepared");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                this.GlobalStatePopup.UnabledToCancelItemAlreadyPrepared();
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
             
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            dSet.Clear();
            dSet = g_objStoredProcCollection.sp_Store_Preparation_Logs(0,
            "",
            this.bunifuPrepaDate.Text,
            "",
            "",
            "",
            "",
            "",
            "",
            0,
            this.matcmbCategory.Text, "", 
            this.metroCmbStoreCode.Text,
            0,
            "check_if_already_prepared");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                this.GlobalStatePopup.UnabledToCancelItemAlreadyPrepared();
            }
            else
            {
                //MessageBox.Show("B");
            }
        }

        private void dgvStoreOrderApproval_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvStoreOrderApproval.ClearSelection();
        }
    }
}
