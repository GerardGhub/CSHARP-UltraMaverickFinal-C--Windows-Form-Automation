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

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Move_Order
{
    public partial class frmCustomers : MaterialForm
    {
        myclasses xClass = new myclasses();

        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        IStoredProcedures objStorProc = null;
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();

        string mode = "";
        int p_id = 0;
        int temp_hid = 0;
        DateTime dNow = DateTime.Now;
        Boolean ready = false;


        DataSet dSet_temp = new DataSet();


        public frmCustomers()
        {
            InitializeComponent();
        }
        public string sp_created_at { get; set; }
        public string sp_created_by { get; set; }
        public string sp_modified_at { get; set; }
        public string sp_modified_by { get; set; }
        public string sp_bind_selected { get; set; }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            this.ShowDataActivated();
            this.ConnetionString();
            myglobal.global_module = "Active"; // Mode for Searching
            this.showItemClassData();
            this.SearchMethodJarVarCallingSP();
        }

        private void ConnetionString()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
        }
        private void ShowDataActivated()
        {
            this.matRadioActive.Checked = true;
        }


        private void showItemClassData()      //method for loading available_menus
        {
            try
            {
                this.ready = false;
                xClass.fillDataGridView(dgvitemClass, "tblCustomersMinorSpActive", dSet);
                this.ready = true;
                this.lbltotalrecords.Text = this.dgvitemClass.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            dset_emp_SearchEngines.Clear();


            dset_emp_SearchEngines = objStorProc.sp_getMajorTables("Item_Class_Major");

        }

        private void dgvitemClass_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgvitemClass.ClearSelection();
        }


        private void showWarehouseMasterData()      //method for loading available_menus
        {
            try
            {
                this.ready = false;
                this.xClass.fillDataGridView(this.dgvitemClass, "MoveOrder_Customers_Active", dSet);
                this.ready = true;
                this.lbltotalrecords.Text = this.dgvitemClass.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void showWarehouseMasterDataInActive()      //method for loading available_menus
        {
            try
            {
                ready = false;
                xClass.fillDataGridView(dgvitemClass, "MoveOrder_Customers_Inactive", dSet);
                ready = true;
                lbltotalrecords.Text = dgvitemClass.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }


        private void matRadioActive_CheckedChanged(object sender, EventArgs e)
        {
            if (matRadioActive.Checked == true)
            {
                this.sp_bind_selected = "1";
                this.matBtnDelete.Text = "&InActive";

                this.showWarehouseMasterData();

            }
            else if (matRadioNotActive.Checked == true)
            {
                this.sp_bind_selected = "0";
                this.matBtnDelete.Text = "&Activate";
                this.showWarehouseMasterDataInActive();

            }
            else
            {

            }
        }

        private void dgvitemClass_CurrentCellChanged(object sender, EventArgs e)
        {
            if (this.dgvitemClass.Rows.Count > 0)
            {
                if (this.dgvitemClass.CurrentRow != null)
                {
                    if (this.dgvitemClass.CurrentRow.Cells["cust_name"].Value != null)
                    {
                        this.p_id = Convert.ToInt32(this.dgvitemClass.CurrentRow.Cells["cust_id"].Value);
                        this.txtmatItemClass.Text = this.dgvitemClass.CurrentRow.Cells["cust_name"].Value.ToString();
                   
                    }
                }
            }
        }

        private void matRadioNotActive_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
