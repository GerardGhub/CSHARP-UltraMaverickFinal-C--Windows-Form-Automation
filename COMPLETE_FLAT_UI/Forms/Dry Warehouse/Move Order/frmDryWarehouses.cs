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
    public partial class frmDryWarehouses : MaterialForm
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


        public frmDryWarehouses()
        {
            InitializeComponent();
        }

        private void frmWarehouses_Load(object sender, EventArgs e)
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
                ready = false;
                xClass.fillDataGridView(dgvitemClass, "Item_Class", dSet);
                ready = true;
                lbltotalrecords.Text = dgvitemClass.RowCount.ToString();
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


    }
}
