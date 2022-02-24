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

namespace ULTRAMAVERICK.Forms.Lab_Test
{
    public partial class frmDryWarehouseNearlyExpiryItems : MaterialForm
    {
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();


        int p_id = 0;

        DateTime dNow = DateTime.Now;

        DataSet dSet_temp = new DataSet();
        public frmDryWarehouseNearlyExpiryItems()
        {
            InitializeComponent();
        }

        private void frmDryWarehouseNearlyExpiryItems_Load(object sender, EventArgs e)
        {
            this.ConnectionInitialization();
            this.showRawMaterialsNearlyExpiry();
        }

        private void ConnectionInitialization ()
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            this.objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
        }


        private void showRawMaterialsNearlyExpiry()    //method for loading available_menus
        {
            try
            {

                xClass.fillDataGridView(this.dgvRawMats, "DryWarehouseNearlyExpiry", dSet);

                this.lbltotalrecords.Text = this.dgvRawMats.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            //this.dgvRawMats.Columns["area_id"].Visible = false;
            //this.dgvRawMats.Columns["is_active"].Visible = false;
            //this.dgvRawMats.Columns["modified_at"].Visible = false;

        }
    }
}
