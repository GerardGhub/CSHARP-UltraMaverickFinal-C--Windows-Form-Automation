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
    public partial class frmListofStore : MaterialForm
    {
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();



        DateTime dNow = DateTime.Now;


        DataSet dSet_temp = new DataSet();
        public frmListofStore()
        {
            InitializeComponent();
        }

        private void frmListofStore_Load(object sender, EventArgs e)
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            this.objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class

            this.showReceivingData();
            this.WindowsRefresher();
        }
        private void WindowsRefresher()
        {
            if (textBox1.Text == "data Already Save!")
            {
                toolStripMain.Visible = false;
            }
            else if (textBox1.Text == "Gerard Singian")
            {
                textBox1.Text = string.Empty;
                toolStripMain.Visible = true;
   
            }
            else
            {


            }
        }
        private void showReceivingData()      //method for loading available_menus
        {
            try
            {

                this.xClass.fillDataGridView(dgvSubCategory, "tbl_stores_major", dSet);

                this.lbltotaldata.Text = dgvSubCategory.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.dgvSubCategory.Columns["stored_id"].Visible = false;
            this.dgvSubCategory.Columns["is_active"].Visible = false;
        }

        private void btnNewTool_Click(object sender, EventArgs e)
        {
            toolStripMain.Visible = false;
           frmAddNewStore addNew = new frmAddNewStore(this);
            addNew.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.frmListofStore_Load(sender, e);
        }

        private void btnEditTool_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For Development And Clarifications");
        }
    }
}
