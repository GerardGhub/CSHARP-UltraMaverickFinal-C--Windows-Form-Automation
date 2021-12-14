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
    public partial class frmStoreOrderforApproval : MaterialForm
    {
        myclasses myClass = new myclasses();
        myclasses xClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        public DataSet dset = new DataSet();
        DataSet dset2 = new DataSet();
        DataSet dset3 = new DataSet();

        //ReportDocument rpt = new ReportDocument();
        string Rpt_Path = "";
        DataSet dSet = new DataSet();
        IStoredProcedures objStorProc = null;


        public frmStoreOrderforApproval()
        {
            InitializeComponent();
        }
        public int sp_user_id { get; set; }
        public string mode { get; set; }
        private void frmStoreOrderforApproval_Load(object sender, EventArgs e)
        {

            this.ConnectionInit();

            this.DataRefresher();

            myglobal.global_module = "Active";
            
            this.loadCategoryDropdown();
            this.loadStoreDropdown();
            this.loadDateOrderDropdown();
            //Load The Data With Stored Procedure
            //this.LoadDataWithParamsOrders();
            this.InitiliazeDatePickerMinDate();
            if (this.mode == "start")
            {
                this.ConnectionInit();
                this.load_search();
                this.mode = "";
            }
            else
            {
                this.ConnectionInit();
                this.dset_emp1.Clear();

                this.dset_emp1 = objStorProc.sp_getMajorTables("searchorderForApprovalinDryWH");
                DataView dv = new DataView(this.dset_emp1.Tables[0]);
             
                this.dgvReprinting.DataSource = dv;
                this.lbltotaldata.Text = dgvReprinting.RowCount.ToString();

            }
            this.SaveButtonManipulator();
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


                this.dgvReprinting.Columns[0].Width = 50;// The id column
                this.dgvReprinting.Columns[3].Width = 150;// The id column

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
                    this.dgvReprinting.DataSource = dv;
                    this.lbltotaldata.Text = dgvReprinting.RowCount.ToString();

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
            this.ConnectionInit();
            MessageBox.Show(this.metroCmbStoreCode.Text);
            this.dset = g_objStoredProcCollection.sp_IDGenerator(1, "SearchStoreOrderforApproval", "All", this.matcmbPackaging.Text,0);
                this.dgvReprinting.DataSource = dset.Tables[0];
                for (int i = 0; i <= dgvReprinting.RowCount; i++)
                {
                    try
                    {
                        this.dgvReprinting.Rows[i].Cells["selected"].Value = false;
                    }
                    catch (Exception) { }
                }




                this.lbltotaldata.Text = dgvReprinting.RowCount.ToString();
            //MessageBox.Show(this.metroCmbStoreCode.Text);
        }
        private void matcmbPackaging_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //this.LoadDataWithParamsOrders();
            this.ConnectionInit();
            this.load_search();
        }

        private void metroCmbStoreCode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //this.LoadDataWithParamsOrders();
            this.ConnectionInit();
            this.load_search();
        }

        private void cmbDateOrder_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.ConnectionInit();
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
            bool isChecked = (bool)dgvReprinting.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;
            CheckCount(isChecked);
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
        }

        private void dgvReprinting_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bool isChecked = (bool)dgvReprinting.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue;
            CheckCount(isChecked);
        }

        private void lbltotaldata_Click(object sender, EventArgs e)
        {

        }
        private void ApproveFunctionality()
        {
            //myglobal.Searchcategory = txtSearch.Text;



            for (int i = 0; i <= dgvReprinting.RowCount - 1; i++)
            {
                try
                {
                    if (dgvReprinting.CurrentRow != null)
                    {

                        if (Convert.ToBoolean(dgvReprinting.Rows[i].Cells["selected"].Value) == true)
                        {
                            this.dgvReprinting.CurrentCell = this.dgvReprinting.Rows[i].Cells[this.dgvReprinting.CurrentCell.ColumnIndex];
                            dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["primary_id"].Value.ToString()), "PUTStoreOrderApproval", this.bunifuPrepaDate.Text, this.sp_user_id.ToString(), 1);

                        }
                        else
                        {
                            //dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["id"].Value.ToString()), "updaterepacking", "", "", 1);

                        }
                    }
                }
                catch (Exception ex)
                {

                    this.dgvReprinting.CurrentCell = this.dgvReprinting.Rows[i].Cells[this.dgvReprinting.CurrentCell.ColumnIndex];
                    dset = g_objStoredProcCollection.sp_IDGenerator(int.Parse(dgvReprinting.Rows[i].Cells["primary_id"].Value.ToString()), "PUTStoreOrderApproval", this.bunifuPrepaDate.Text, this.sp_user_id.ToString(), 1);

                    MessageBox.Show(ex.Message);
                }

            }

            this.ApprovedSuccessfully();
            this.materialCheckboxSelectAll.Checked = false;
            this.labelSelectedSum.Visible = false;
            this.mode = "start";
            this.frmStoreOrderforApproval_Load(new object(), new System.EventArgs());
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
        private void matbtnPrint_Click(object sender, EventArgs e)
        {
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

            for (int i = 0; i < this.dgvReprinting.RowCount; i++) { this.dgvReprinting.Rows[i].Cells[0].Value = true; }
            if(this.materialCheckboxSelectAll.Checked ==true)
            {
                this.labelSelectedSum.Visible = true;

                //MessageBox.Show(dgvReprinting.SelectedRows.Count.ToString());
             
                this.labelSelectedSum.Text = "Selected Items: " + this.dgvReprinting.RowCount.ToString();
                this.num = this.dgvReprinting.RowCount;
                this.SaveButtonManipulator();
              
            }
            else
            {
                this.materialCheckboxSelectAll.Text = "Select ALL";
                //this.labelSelectedSum.Visible = false;
                for (int i = 0; i < dgvReprinting.RowCount; i++) { dgvReprinting.Rows[i].Cells[0].Value = false; }
                this.labelSelectedSum.Text = "Selected Items: " + 0;
                this.num = 0;
                this.SaveButtonManipulator();
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
    }
}
