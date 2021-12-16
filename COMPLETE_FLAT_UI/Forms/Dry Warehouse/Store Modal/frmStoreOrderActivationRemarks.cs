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

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Store_Modal
{
    public partial class frmStoreOrderActivationRemarks : MaterialForm
    {
        myclasses xClass = new myclasses();
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
        public frmStoreOrderActivationRemarks()
        {
            InitializeComponent();
        }
        public string sp_created_at { get; set; }
        public string sp_created_by { get; set; }
        public string sp_updated_date { get; set; }
        public string sp_updated_by { get; set; }
        public string sp_bind_selected { get; set; }
        public string sp_added_by { get; set; }
        public string sp_date_added { get; set; }
        private void frmStoreOrderCancelRemarks_Load(object sender, EventArgs e)
        {
            this.ShowDataActivated();
            this.ConnetionString();
            myglobal.global_module = "Active"; // Mode for Searching
            this.ShowDataStoreOrderActivationRemarks();
            this.SearchMethodJarVarCallingSP();
        }

        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            dset_emp_SearchEngines.Clear();


            dset_emp_SearchEngines = objStorProc.sp_getMajorTables("avg_order_trend_major");

            this.VisibilityFalseForDataGridColumn();

        }
        private void VisibilityFalseForDataGridColumn()
        {

            this.dgvAVGOrderTrend.Columns["soar_is_active"].Visible = false;
        }

        //method for loading available_menus
        private void ShowDataStoreOrderActivationRemarks()
        {
            try
            {
                ready = false;
                xClass.fillDataGridView(dgvAVGOrderTrend, "store_order_activation_remarks_activated_minor", dSet);
                ready = true;
                lbltotalrecords.Text = dgvAVGOrderTrend.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


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

        private void matBtnNew_Click(object sender, EventArgs e)
        {
            //Mode
            this.mode = "add";
            //Edit
            this.matBtnEdit.Visible = false;
            //Cancel
            this.matBtnCancel.Visible = true;
            //TextBVox Enabled True
            this.txtmatRemarks.Enabled = true;
            this.matcmbType.Enabled = true;
            //Button Visibility
            this.matBtnNew.Visible = false;
            this.matBtnDelete.Visible = false;
            this.matBtnSave.Visible = true;
            //String Textbox Empty
            this.txtmatRemarks.Text = String.Empty;
            this.sp_updated_date = String.Empty;
            this.sp_updated_by = String.Empty;
            this.matcmbType.Text = String.Empty;
            //Binding User Session Date ETC
            this.sp_date_added = (dNow.ToString("M/d/yyyy"));
            this.sp_added_by = userinfo.emp_name.ToUpper();

            //Focus Events 
            this.txtmatRemarks.Select();
            this.txtmatRemarks.Focus();
        }
    }
}
