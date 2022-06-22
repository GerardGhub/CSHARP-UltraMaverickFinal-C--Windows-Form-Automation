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
    public partial class ViewApprovedItemsInternalOrder : MaterialForm
    {
        frmInternalApprovedOrder ths;

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
        private bool dateChanged = false;
        public ViewApprovedItemsInternalOrder(frmInternalApprovedOrder frm,
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

        private void ViewApprovedItemsInternalOrder_Load(object sender, EventArgs e)
        {
            this.StaticWindowState();
            this.InitiliazeDatePickerMinDate();
            this.ConnectionState();
            //Additional Information
            this.SearchMethodJarVarCallingSP();
            this.doSearchInTextBoxCmb();
            //SideLine
            this.DataGridColumnDisabledEditing();
            this.SelectAllRecords();
            this.bunifuPrepaDate.ValueChanged += new System.EventHandler(bunifuPrepaDate_ValueChanged);
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
                this.dgvStoreOrderApproval.Columns["mrs_id"].ReadOnly = true;
                this.dgvStoreOrderApproval.Columns["mrs_transact_no"].ReadOnly = true;
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
            this.dset_emp_SearchEngines = objStorProc.sp_getMajorTables("SearchInternalPreparationLogs");

        }

        private void doSearchInTextBoxCmb()
        {

            try
            {


                if (dset_emp_SearchEngines.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp_SearchEngines.Tables[0]);
                    dv.RowFilter = "mrs_transact_no = '" + this.ctrl_bind_mrs + "' ";
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
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
        }

        private void InitiliazeDatePickerMinDate()
        {
            this.bunifuPrepaDate.MinDate = DateTime.Now;
            //this.bunifuPrepaDate.MaxDate = DateTime.Now.AddDays(30);
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
            this.textBox1.Text = "TouchedScreen";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //this.bunifuPrepaDate.Text = "2022-06-28";
            MessageBox.Show(ctrl_bind_is_preparation_date);
            this.bunifuPrepaDate.Value.ToString(ctrl_bind_is_preparation_date);
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
                    MessageBox.Show("Sure Ka? ");
                    this.matBtnAction.Text = "UPDATE";
                }

            }
           

        }

        private void bunifuPrepaDate_Validated(object sender, EventArgs e)
        {
            MessageBox.Show("Sure Ka? ");
        }

        private void bunifuPrepaDate_Validating(object sender, CancelEventArgs e)
        {
            MessageBox.Show("Sure Ka? ");
        }
    }
}
