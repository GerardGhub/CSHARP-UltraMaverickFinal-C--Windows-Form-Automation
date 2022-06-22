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
    public partial class frmInternalApprovedOrder : MaterialForm
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
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        //Variable Declaration
        int p_id = 0;

        string Rpt_Path = "";
        double stackQuantity = 0;


        public frmInternalApprovedOrder()
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

        public string Sp_department_id { get; set; }
        public string Sp_mrs_req_desc { get; set; }
        public string Sp_mrs_requested_by { get; set; }
        public string Sp_mrs_requested_date { get; set; }
        public string Sp_total_items { get; set; }


        private void frmInternalApprovedOrder_Load(object sender, EventArgs e)
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


            //this.DataGridColumnDisabledEditing();

            this.DataGridHideColumn();
            if (this.lbltotaldata.Text != "0")
            {
                this.bunifuPrepaDate_ValueChanged(sender, e);
                this.dgvStoreOrderApproval.Columns["selected"].ReadOnly = false;
                this.dgvStoreOrderApproval.Enabled = true;

            }
        }

        private void DataGridHideColumn()
        {
            if (this.dgvStoreOrderApproval.Rows.Count > 0)
            {

                this.dgvStoreOrderApproval.Columns["route"].Visible = false;
                this.dgvStoreOrderApproval.Columns["area"].Visible = false;
                this.dgvStoreOrderApproval.Columns["date_added"].Visible = false;
                this.dgvStoreOrderApproval.Columns["is_approved_by"].Visible = false;
                this.dgvStoreOrderApproval.Columns["is_approved_date"].Visible = false;
                this.dgvStoreOrderApproval.Columns["qty_original"].Visible = false;
            }
        }

        private void DataGridColumnDisabledEditing()
        {
            if (this.dgvStoreOrderApproval.Rows.Count > 0)
            {

                this.dgvStoreOrderApproval.Columns["mris_id"].ReadOnly = true;
                this.dgvStoreOrderApproval.Columns["department_id"].ReadOnly = true;
                this.dgvStoreOrderApproval.Columns["mrs_req_desc"].ReadOnly = true;
                this.dgvStoreOrderApproval.Columns["mrs_requested_by"].ReadOnly = true;
                this.dgvStoreOrderApproval.Columns["TOTAL_ITEMS"].ReadOnly = true;
                this.dgvStoreOrderApproval.Columns["mrs_requested_date"].ReadOnly = true;
            }
        }


        private void DesignerSerializationVisibilityOninit()
        {
            //Order ID for Genus System
            this.dgvStoreOrderApproval.Columns["order_id"].Visible = false;
            //Order Primary KEy
            this.dgvStoreOrderApproval.Columns["primary_id"].Visible = false;
            this.matbtnCancel.Visible = false;
            this.matbtnEdit.Visible = false;
        }



        double num = 0;
        double num_static_value = 0;

        private void SaveButtonManipulator()
        {
           
            if (num == 0)
            {
                this.matbtnCancel.Visible = false;
            }
            else
            {
                this.matbtnCancel.Visible = true;
            }
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

            if (this.lbltotaldata.Text == "0")
            {
                this.groupBoxColorGuide.Visible = false;
            }
            else
            {
                this.groupBoxColorGuide.Visible = true;
            }
        }


        DataSet dset_emp1 = new DataSet();
        private void load_search()
        {

            this.dset_emp1.Clear();

            this.dset_emp1 = objStorProc.sp_getMajorTables("searchMRSInternalPreparationDateSync");

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
                            dv.RowFilter = "is_wh_preparation_date = '" + this.bunifuPrepaDate.Text + "'    ";
                        }
                        //else if (this.mode == "Search2") // for Fucking Category dv.RowFilter = " is_approved_prepa_date = '" + this.bunifuPrepaDate.Text + "' and   date_ordered = '" + this.cmbDateOrder.Text + "'  ";
                        //{
                        //    dv.RowFilter = " is_approved_prepa_date = '" + this.bunifuPrepaDate.Text + "'  ";
                        //}
                        //else if (this.mode == "Search3")
                        //{
                        //    dv.RowFilter = " is_approved_prepa_date = '" + this.bunifuPrepaDate.Text + "'   ";
                        //}
                        //else if (this.mode == "Search4")
                        //{
                        //    dv.RowFilter = " is_approved_prepa_date = '" + this.bunifuPrepaDate.Text + "'  ";
                        //}
                        else
                        {
                            //dv.RowFilter = "is_approved_prepa_date = '" + this.bunifuPrepaDate.Text + "'     ";
                        }

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


        private void ClearTextboxesStateMObX()
        {
            this.textBox1.Text = String.Empty;
        }


        //Radion Selection Button Enabled in the Fucking SHit
        private void ShowDataActivated()
        {
            this.matRadioActive.Checked = true;
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





        private void bunifuPrepaDate_ValueChanged(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.mode = "Search1";
            this.load_search();
 

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
                    if (this.dgvStoreOrderApproval.CurrentRow.Cells["department_id"].Value != null)
                    {
                        p_id = Convert.ToInt32(this.dgvStoreOrderApproval.CurrentRow.Cells["mrs_id"].Value);

                        this.Sp_department_id = this.dgvStoreOrderApproval.CurrentRow.Cells["department_id"].Value.ToString();
                        this.Sp_mrs_req_desc = this.dgvStoreOrderApproval.CurrentRow.Cells["mrs_req_desc"].Value.ToString();
                        this.Sp_mrs_requested_by = this.dgvStoreOrderApproval.CurrentRow.Cells["mrs_requested_by"].Value.ToString();
                        this.Sp_mrs_requested_date = this.dgvStoreOrderApproval.CurrentRow.Cells["mrs_requested_date"].Value.ToString();
                        this.Sp_total_items = this.dgvStoreOrderApproval.CurrentRow.Cells["TOTAL_ITEMS"].Value.ToString();
                    }
                }
            
            }
        }

        private void SelectedDataTotalOrderQuantity()
        {

          
            int sum = 0;
            for (int i = 0; i < this.dgvStoreOrderApproval.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(this.dgvStoreOrderApproval.Rows[i].Cells["TOTAL_ITEMS"].Value);
            }

            this.lbltotalOrderQty.Text = sum.ToString();
        }

        

        private void lbltotaldata_TextChanged(object sender, EventArgs e)
        {
        
            this.SelectedDataTotalOrderQuantity();
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

                    row.Cells["DateDiff"].Style.BackColor = Color.White;
                    row.Cells["selected"].Style.BackColor = Color.White;

                }
            }
        }



    }
    }
