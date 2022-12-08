using MaterialSkin.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    public partial class frmDryWHInventory : MaterialForm
    {
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        DateTime dNow = DateTime.Now;
        DataSet dSet_temp = new DataSet();
        public frmDryWHInventory()
        {
            InitializeComponent();
        }

        private void frmDryWHInventory_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.showRawMaterialsInDryWH();
        }

        private void ConnectionInit()
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }

        private void showRawMaterialsInDryWH()    //method for loading available_menus
        {
            try
            {
                this.myClass.fillDataGridView(this.dgvRawMats, "Raw_Materials_Dry_Inventory", dSet);
                this.lbltotalrecords.Text = this.dgvRawMats.RowCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.dgvRawMats.Columns["item_id"].Visible = false;
        }

        private void txtItemCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void dgvRawMats_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check the value of the e.ColumnIndex property if you want to apply this formatting only so some rcolumns.
            if (e.Value != null)
            {
                e.Value = e.Value.ToString().ToUpper();
                e.FormattingApplied = true;
            }



            foreach (DataGridViewRow row in dgvRawMats.Rows)
            {
                if (Convert.ToDouble(row.Cells["buffer_stock"].Value) > Convert.ToDouble(row.Cells["RESERVED"].Value))
                {

                    row.Cells["buffer_stock"].Style.BackColor = Color.LightSalmon;
                }
                else if (Convert.ToDouble(row.Cells["buffer_stock"].Value) < Convert.ToDouble(row.Cells["RESERVED"].Value))
                {

                }

            }


        }

        private void dgvRawMats_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvRawMats.ClearSelection();
        }

        private void txtItemCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
