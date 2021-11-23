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

namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    public partial class frmListofReceiving : MaterialForm
    {
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();



        DateTime dNow = DateTime.Now;
      

        DataSet dSet_temp = new DataSet();
        public frmListofReceiving()
        {
            InitializeComponent();
        }

        private void frmListofReceiving_Load(object sender, EventArgs e)
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            this.objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class

            this.showReceivingData();
        }

        private void showReceivingData()      //method for loading available_menus
        {
            try
            {
           
                this.xClass.fillDataGridView(dgvSubCategory, "Po_Receiving_Warehouse", dSet);
             
                this.lblgrandtotaldata.Text = dgvSubCategory.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

    }
}
