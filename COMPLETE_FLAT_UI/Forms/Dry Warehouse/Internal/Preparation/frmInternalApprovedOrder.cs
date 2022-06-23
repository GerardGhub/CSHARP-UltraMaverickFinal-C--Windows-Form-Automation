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
        public string Sp_preparation_date { get; set; }

        private void frmInternalApprovedOrder_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.ShowDataActivated();
            //this.DataRefresher();
            //this.ClearTextboxesStateMObX();
            myglobal.global_module = "Active";




            //Load The Data With Stored Procedure
            //this.LoadDataWithParamsOrders();

            //if (this.mode == "start")
            //{
            //    this.ConnectionInit();
            //    this.load_search();
            //    this.mode = "";
            //}
            //else
            //{
            //    this.LoadDataActivatedforPreparation();

            //}
     
            //this.DesignerSerializationVisibilityOninit();


            //this.DataGridColumnDisabledEditing();

       
            if (this.lbltotaldata.Text != "0")
            {
                this.bunifuPrepaDate_ValueChanged(sender, e);
                this.dgvStoreOrderApproval.Columns["selected"].ReadOnly = false;
                this.dgvStoreOrderApproval.Enabled = true;

            }
            this.InitiliazeDatePickerMinDate();
        }


        private void InitiliazeDatePickerMinDate()
        {
            this.bunifuPrepaDate.MinDate = DateTime.Now;
            //this.bunifuPrepaDate.MaxDate = DateTime.Now.AddDays(30);
        }

        private void DataGridHideColumn()
        {
            if (this.dgvStoreOrderApproval.Rows.Count > 0)
            {

                this.dgvStoreOrderApproval.Columns["selected"].Visible = false;
                this.dgvStoreOrderApproval.Columns["DateDiff"].Visible = false;
                this.dgvStoreOrderApproval.Columns["is_cancel_reason"].Visible = false;
            }
        }

  


        private void DesignerSerializationVisibilityOninit()
        {
            //Order ID for Genus System
            this.dgvStoreOrderApproval.Columns["order_id"].Visible = false;
            //Order Primary KEy
            this.dgvStoreOrderApproval.Columns["primary_id"].Visible = false;
    
            this.matbtnEdit.Visible = false;
        }



        double num = 0;
        double num_static_value = 0;

 



   


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
                    
                        else
                        {
              
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


        //BujeSingian
        private void LoadDataCancelledforPreparation()
        {
            this.ConnectionInit();
            this.dset_emp1.Clear();

            this.dset_emp1 = objStorProc.sp_getMajorTables("searchMRSInternalPreparationDateSyncInactive");
            DataView dv = new DataView(this.dset_emp1.Tables[0]);

            this.dgvStoreOrderApproval.DataSource = dv;
            this.SelectedDataTotalOrderQuantity();
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
            if (matRadioNotActive.Checked == true)
            {

            }
            else if (this.matRadioActive.Checked == true)
            {
         
                this.ConnectionInit();
                this.mode = "Search1";
                this.load_search();
                this.DataGridHideColumn();
                this.textBox1.Text = String.Empty;
            }
            else
            {
              
            }

        

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
                        this.Sp_mrs_requested_date = this.dgvStoreOrderApproval.CurrentRow.Cells["mrs_requested_date"].Value.ToString();
                        this.Sp_preparation_date = this.dgvStoreOrderApproval.CurrentRow.Cells["is_wh_preparation_date"].Value.ToString();
                        this.lblReasonofCancellation.Text = this.dgvStoreOrderApproval.CurrentRow.Cells["is_cancel_reason"].Value.ToString();

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

                    row.Cells["is_wh_preparation_date"].Style.BackColor = Color.Green;
                    row.Cells["is_wh_preparation_date"].Style.SelectionBackColor = Color.Green;
               

                }
                else if (2 == Convert.ToDouble(row.Cells["DateDiff"].Value) || 3 == Convert.ToDouble(row.Cells["DateDiff"].Value) || 4 == Convert.ToDouble(row.Cells["DateDiff"].Value) || 5 == Convert.ToDouble(row.Cells["DateDiff"].Value))
                {
                    row.Cells["is_wh_preparation_date"].Style.BackColor = Color.Yellow;
                    row.Cells["is_wh_preparation_date"].Style.SelectionBackColor = Color.Yellow;
                    row.Cells["is_wh_preparation_date"].Style.SelectionForeColor = Color.Black;

                }

                else
                {

                    row.Cells["is_wh_preparation_date"].Style.BackColor = Color.White;
                    row.Cells["is_wh_preparation_date"].Style.SelectionBackColor = Color.White;
                    row.Cells["is_wh_preparation_date"].Style.SelectionForeColor = Color.Black;

                }
            }
        }

        private void dgvStoreOrderApproval_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Start
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
 
                this.dgvStoreOrderApproval.Enabled = false;
           
                ViewApprovedItemsInternalOrder addNew =
            new ViewApprovedItemsInternalOrder(this,
             this.p_id,
             this.Sp_department_id,
             this.Sp_mrs_req_desc,
             this.Sp_mrs_requested_by,
             this.Sp_mrs_requested_date,
             this.Sp_total_items,
             this.Sp_preparation_date
             );
                addNew.ShowDialog();

            }

            //End



        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text == String.Empty)
            {

            }
            else
            {




                if (this.textBox1.Text == "TouchedScreen")
                {
                    this.dgvStoreOrderApproval.Enabled = true;
                    this.textBox1.Text = String.Empty;
                    this.ConnectionInit();
                    this.bunifuPrepaDate_ValueChanged(sender, e);
                }
                else
                {
                    this.ConnectionInit();
           
                    this.bunifuPrepaDate.Text = this.textBox1.Text;

                }
            }
        }

        private void matRadioNotActive_CheckedChanged(object sender, EventArgs e)
        {
          
           if (matRadioNotActive.Checked == true)
            {
                this.sp_bind_selected = "0";

                this.LoadDataCancelledforPreparation();
                this.DataGridHideColumn();
                this.lblReasonofCancellation.Visible = false;
                this.lbltotalOrderQty.Text = "0";
              
            }
            else
            {

            }

        }

       

        private void matRadioActive_CheckedChanged(object sender, EventArgs e)
        {
            if(this.matRadioNotActive.Checked == true)
            {
                this.matRadioNotActive.Checked = false;
            }
            this.lblReasonofCancellation.Visible = false;


                this.bunifuPrepaDate_ValueChanged(sender, e);
            
      

        }
    }
    }
