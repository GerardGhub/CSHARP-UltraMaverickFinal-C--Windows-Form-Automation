using COMPLETE_FLAT_UI.Models;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Windows.Forms;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Internal.Preparation
{
    public partial class frmViewApprovedItemsInternalOrder : MaterialForm
    {
        frmInternalApprovedOrder ths;
        myclasses xClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        public DataSet dset = new DataSet();
        DataSet dset2 = new DataSet();
        DataSet dset3 = new DataSet();
        DataSet dSet = new DataSet();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        private bool dateChanged = false;
        public frmViewApprovedItemsInternalOrder(frmInternalApprovedOrder frm,
            int sp_mrs_id,
            string sp_department_id,
            string sp_mrs_req_desc,
            string sp_mrs_requested_by,
            string sp_mrs_requested_date,
            string sp_total_items,
            string sp_preparation_date)
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            ctrl_bind_mrs = sp_mrs_id;
            ctrl_bind_department_id = sp_department_id;
            ctrl_bind_mrs_req_desc = sp_mrs_req_desc;
            ctrl_bind_mrs_req_by = sp_mrs_requested_by;
            ctrl_bind_mrs_req_date = sp_mrs_requested_date;
            ctrl_bind_total_items = sp_total_items;
            ctrl_bind_is_preparation_date = sp_preparation_date;
        }


        public int ctrl_bind_mrs { get; set; }
        public string ctrl_bind_department_id { get; set; }
        public string ctrl_bind_mrs_req_desc { get; set; }
        public string ctrl_bind_mrs_req_by { get; set; }
        public string ctrl_bind_mrs_req_date { get; set; }
        public string ctrl_bind_total_items { get; set; }
        public string ctrl_bind_is_preparation_date { get; set; }
        public string ctrl_bind_is_cancel_by { get; set; }
        public bool ctrl_bind_is_active { get; set; }
        public bool ctrl_bind_is_prepared { get; set; }

        private void ViewApprovedItemsInternalOrder_Load(object sender, EventArgs e)
        {
            this.StaticWindowState();
            this.InitiliazeDatePickerMinDate();
            this.ConnectionState();
    
            this.SearchMethodJarVarCallingSP();
            this.doSearchInTextBoxCmb();
  
            this.DataGridColumnDisabledEditing();
            this.SelectAllRecords();
            this.bunifuPrepaDate.ValueChanged += new System.EventHandler(bunifuPrepaDate_ValueChanged);
            if (this.ctrl_bind_is_active == false)
            {
                this.matBtnAction.Text = "RETURN";
                this.lblcancelby.Visible = true;
                this.lblcanceltitle.Visible = true;
            }
            this.DataGridHideColumn();
            this.CheckIfTheRequestIsAlreadyPrepared();
        }


        private void CheckIfTheRequestIsAlreadyPrepared()
        {
            if (this.ctrl_bind_is_prepared == true)
            {
                this.matBtnAction.Enabled = false;
                this.bunifuPrepaDate.Enabled = false;
            }
        }


        private void DataGridHideColumn()
        {
            if (this.dgvStoreOrderApproval.Rows.Count > 0)
            {

                this.dgvStoreOrderApproval.Columns["is_cancel_by"].Visible = false;
                this.dgvStoreOrderApproval.Columns["Allocation_Precense"].Visible = false;
                this.dgvStoreOrderApproval.Columns["is_active"].Visible = false;
                this.dgvStoreOrderApproval.Columns["is_prepared"].Visible = false;
            }
        }


        private void SelectAllRecords()
        {
            for (int i = 0; i < this.dgvStoreOrderApproval.RowCount; i++) { this.dgvStoreOrderApproval.Rows[i].Cells[0].Value = true; }
        }


        private void DataGridColumnDisabledEditing()
        {
            if (this.dgvStoreOrderApproval.Rows.Count > 0)
            {

                this.dgvStoreOrderApproval.Columns["selected"].ReadOnly = true;
                this.dgvStoreOrderApproval.Columns["StockOnHand"].ReadOnly = true;
                this.dgvStoreOrderApproval.Columns["mrs_id"].ReadOnly = true;
                this.dgvStoreOrderApproval.Columns["mrs_item_code"].ReadOnly = true;
                this.dgvStoreOrderApproval.Columns["mrs_item_description"].ReadOnly = true;
                this.dgvStoreOrderApproval.Columns["mrs_uom"].ReadOnly = true;
                this.dgvStoreOrderApproval.Columns["mrs_order_qty"].ReadOnly = true;
            }
        }



        //@ 1st Generation
        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            this.dset_emp_SearchEngines.Clear();
            this.dset_emp_SearchEngines = g_objStoredProcCollection.sp_getMajorTables("SearchInternalPreparationLogs");

        }

        private void doSearchInTextBoxCmb()
        {
            try
            {
                if (dset_emp_SearchEngines.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp_SearchEngines.Tables[0]);
                    dv.RowFilter = "mrs_id = '" + this.ctrl_bind_mrs + "' ";
                    this.dgvStoreOrderApproval.DataSource = dv;
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



        private void ConnectionState()
        {
            g_objStoredProcCollection = xClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }

        private void InitiliazeDatePickerMinDate()
        {
            if (this.bunifuPrepaDate.Text != String.Empty)
            {
                this.bunifuPrepaDate.MinDate = DateTime.Now;
                this.bunifuPrepaDate.MaxDate = DateTime.Now.AddDays(7);
            }
        }

        private void StaticWindowState()
        {
            this.txtDescription.Text = ctrl_bind_mrs_req_desc;
            this.txtRequestedDate.Text = ctrl_bind_mrs_req_date;
            this.txtTotalItems.Text = ctrl_bind_total_items;
            this.bunifuPrepaDate.Text = ctrl_bind_is_preparation_date;
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void ViewApprovedItemsInternalOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(matBtnAction.Text== "UPDATE")
            {
                this.textBox1.Text = this.bunifuPrepaDate.Text;
            }
            else if (matBtnAction.Text == "RETURN")
            {
                this.textBox1.Text = "ReturnRecord";
            }
            else
            {
                this.textBox1.Text = "TouchedScreen";
            }
        }


        private void bunifuPrepaDate_ValueChanged(object sender, EventArgs e)
        {
            dateChanged = true;
            //Here you can do stuff that needs to be done when the value changes
            //Example: Here you can check if the value has changed since you opened the form:
            if (dateChanged)
            {
                //The date has been changed - do what I need to do
                if(this.bunifuPrepaDate.Text == ctrl_bind_is_preparation_date)
                {
                    this.matBtnAction.Text = "CANCEL";     
                }
                else
                {
                    this.matBtnAction.Text = "UPDATE";       
                }

            }
           

        }



        private void CancelFunctionality()
        {
            this.ConnectionState();

            for (int i = 0; i <= dgvStoreOrderApproval.RowCount - 1; i++)
            {
                try
                {
                    if (dgvStoreOrderApproval.CurrentRow != null)
                    {
                        if (Convert.ToBoolean(dgvStoreOrderApproval.Rows[i].Cells["selected"].Value) == true)
                        {
                            this.dgvStoreOrderApproval.CurrentCell = this.dgvStoreOrderApproval.Rows[i].Cells[this.dgvStoreOrderApproval.CurrentCell.ColumnIndex];
                            dset = g_objStoredProcCollection.sp_IDGenerator(
                                int.Parse(dgvStoreOrderApproval.Rows[i].Cells["mrs_id"].Value.ToString()),
                                "DryWhSupervisorCancelInternalApprovedMRS", 
                                this.textBox1.Text,
                              userinfo.user_id.ToString(), 1, 0);
                        }
                        else
                        {
                            //dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepacking", "", "", 1);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            this.GlobalStatePopup.CancelledSuccessfully();
            this.Close();
        }



        private void ReturnFunctionality()
        {
            this.ConnectionState();

            for (int i = 0; i <= dgvStoreOrderApproval.RowCount - 1; i++)
            {
                try
                {
                    if (dgvStoreOrderApproval.CurrentRow != null)
                    {

                        if (Convert.ToBoolean(dgvStoreOrderApproval.Rows[i].Cells["selected"].Value) == true)
                        {
                            this.dgvStoreOrderApproval.CurrentCell = this.dgvStoreOrderApproval.Rows[i].Cells[this.dgvStoreOrderApproval.CurrentCell.ColumnIndex];
                            dset = g_objStoredProcCollection.sp_IDGenerator(
                                int.Parse(dgvStoreOrderApproval.Rows[i].Cells["mrs_id"].Value.ToString()),
                                "DryWhSupervisorReturnInternalApprovedMRS",
                                this.textBox2.Text,
                                userinfo.user_id.ToString(), 1, 0);

                        }
                        else
                        {
                            //dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepacking", "", "", 1);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            this.GlobalStatePopup.UpdatedSuccessfully();
            this.Close();
        }


        private void UpdateFunctionality()
        {
            this.ConnectionState();

            for (int i = 0; i <= dgvStoreOrderApproval.RowCount - 1; i++)
            {
                try
                {
                    if (dgvStoreOrderApproval.CurrentRow != null)
                    {

                        if (Convert.ToBoolean(dgvStoreOrderApproval.Rows[i].Cells["selected"].Value) == true)
                        {
                            this.dgvStoreOrderApproval.CurrentCell = this.dgvStoreOrderApproval.Rows[i].Cells[this.dgvStoreOrderApproval.CurrentCell.ColumnIndex];
                            dset = g_objStoredProcCollection.sp_IDGenerator(
                                int.Parse(dgvStoreOrderApproval.Rows[i].Cells["mrs_id"].Value.ToString()),
                                "DryWhSupervisorUpdateInternalApprovedMRS", 
                                this.bunifuPrepaDate.Text, 
                                userinfo.user_id.ToString(), 1, 0);

                        }
                        else
                        {


                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            this.GlobalStatePopup.ApprovedSuccessfully();   
            this.Close();
        }





        private void matBtnAction_Click(object sender, EventArgs e)
        {
            if(this.matBtnAction.Text == "CANCEL")
            {
                if (this.textBox2.Text == String.Empty)
                {
                    frmCancelInternalApprovedOrder FormCancelOrderRemarks = new frmCancelInternalApprovedOrder(this, this.matBtnAction.Text);
                    FormCancelOrderRemarks.ShowDialog();
                }
            }

            if (this.matBtnAction.Text == "RETURN")
            {
                if (this.textBox2.Text == String.Empty)
                {
                    frmCancelInternalApprovedOrder FormCancelOrderRemarks = new frmCancelInternalApprovedOrder(this, this.matBtnAction.Text);
                    FormCancelOrderRemarks.ShowDialog();
                }
            }



            if (this.matBtnAction.Text =="UPDATE")
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Update the consolidated order? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

            
                    this.UpdateFunctionality();
                }
                else
                {

                    return;
                }
            }
            else if (this.matBtnAction.Text == "CANCEL")
            {

                if (this.textBox2.Text != String.Empty)
                {
                }
                else
                {
                    this.CancelFunctionality();



                }
            }

            else if (this.matBtnAction.Text == "RETURN")
            {     
                    this.ReturnFunctionality();
            }

            else
            {

            }

            this.textBox2.Text = String.Empty;    
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
                    if (this.dgvStoreOrderApproval.CurrentRow.Cells["is_active"].Value != null)
                    {            
                        this.ctrl_bind_is_cancel_by = this.dgvStoreOrderApproval.CurrentRow.Cells["is_cancel_by"].Value.ToString();
                        this.lblcancelby.Text = this.ctrl_bind_is_cancel_by;
                        this.ctrl_bind_is_active = Convert.ToBoolean(this.dgvStoreOrderApproval.CurrentRow.Cells["is_active"].Value);
                        this.ctrl_bind_is_prepared = Convert.ToBoolean(this.dgvStoreOrderApproval.CurrentRow.Cells["is_prepared"].Value);
                    }
                }

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox2.Text == String.Empty)
            {

            }
            else
            {
                this.matBtnAction_Click(sender, e);
            }

        }
    }
}
