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
        private IStoredProcedures g_objStoredProcCollection = null;
        readonly myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        DateTime dNow = DateTime.Now;
        DataSet dSet_temp = new DataSet();
        public frmListofReceiving()
        {
            InitializeComponent();
        }

        private void OpenConnection()
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections

        }
        private void frmListofReceiving_Load(object sender, EventArgs e)
        {
            this.OpenConnection();

            this.matRadioActive.Checked = true;

            if (this.matRadioActive.Checked == true)
            {
                this.showReceivingData();
            }
      
    
        

            }



        private void showReceivingData()      //method for loading available_menus
        {
            try
            {
           
                this.myClass.fillDataGridView(this.dgvSubCategory, "Po_Receiving_Warehouse", dSet);
             
                this.lblgrandtotaldata.Text = this.dgvSubCategory.RowCount.ToString();
                this.dgvSubCategory.Columns["PrimaryID"].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void showReceivingDataNearlyExpiry()      //method for loading available_menus
        {
            try
            {

                this.myClass.fillDataGridView(this.dgvSubCategory, "Po_Receiving_Warehouse_Nearly_Expiry", dSet);

                this.lblgrandtotaldata.Text = this.dgvSubCategory.RowCount.ToString();
                this.dgvSubCategory.Columns["PrimaryID"].Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void matRadioActive_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matRadioNotActive.Checked == true)
            {
                this.matRadioNotActive.Checked = false;
                this.matRadioActive.Checked = true;
                this.OpenConnection();
                this.showReceivingData();
                this.dgvSubCategory.Columns["is_expirable"].Visible = false;
            }

        }

        private void matRadioNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matRadioActive.Checked == true)
            {
                this.matRadioActive.Checked = false;
                this.matRadioNotActive.Checked = true;
                this.OpenConnection();
                this.showReceivingDataNearlyExpiry();
            }

        }
    }
}
