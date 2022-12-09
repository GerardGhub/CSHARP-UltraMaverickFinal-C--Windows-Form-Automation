using MaterialSkin.Controls;
using System;
using System.Data;
using System.Windows.Forms;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Move_Order
{
    public partial class FrmChooseLotNumberMoveOrder : MaterialForm
    {
        FrmAddNewMiscellaneousReceipt ths;
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        DateTime dNow = DateTime.Now;
        string mode = "";
        DataSet dSet_temp = new DataSet();
        public FrmChooseLotNumberMoveOrder(FrmAddNewMiscellaneousReceipt frm, string major_category)
        {
            InitializeComponent();
            ths = frm;
            this.Sp_major_category = major_category;
        }


        public string Sp_major_category { get; set; }
        public string Sp_lot_number { get; set; }
        public string Sp_lot_description { get; set; }

        private void FrmChooseLotNumberMoveOrder_Load(object sender, EventArgs e)
        {
            this.WindowsLoadingBinder();
            this.ConnectionInit();
            this.SearchMethodJarVarCallingSP();
            this.doSearchInTextBoxCmb();
        }
        private void ConnectionInit()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }

        private void WindowsLoadingBinder()
        {
            this.mode = "false";
            this.mattxtCategory.Text = Sp_major_category;
        }


        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            dset_emp_SearchEngines.Clear();
            dset_emp_SearchEngines = g_objStoredProcCollection.sp_getMajorTables("lot_management_major");
        }

        private void doSearchInTextBoxCmb()
        {
            try
            {
                if (dset_emp_SearchEngines.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp_SearchEngines.Tables[0]);
                    if (myglobal.global_module == "EMPLOYEE")
                    {

                    }
                    else if (myglobal.global_module == "Active")
                    {
                        //Gerard Singian Developer Man
                        dv.RowFilter = "category = '" + mattxtCategory.Text + "' and lot_number like '%" + mattxtLotnumber.Text + "%'  ";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    dgvLotData.DataSource = dv;
                    lbltotalrecords.Text = dgvLotData.RowCount.ToString();
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
            this.dgvLotData.Columns["id"].Visible = false;
            this.dgvLotData.Columns["category"].Visible = false;
            this.dgvLotData.Columns["added_by"].Visible = false;
            this.dgvLotData.Columns["date_added"].Visible = false;
            this.dgvLotData.Columns[1].Width = 128;

        }

        private void dgvLotData_CurrentCellChanged(object sender, EventArgs e)
        {
            this.showValueCell();
        }

        private void showValueCell()
        {
            if (dgvLotData.Rows.Count > 0)
            {
                if (dgvLotData.CurrentRow != null)
                {
                    if (dgvLotData.CurrentRow.Cells["lot_number"].Value != null)
                    {
                        Sp_lot_number = dgvLotData.CurrentRow.Cells["lot_number"].Value.ToString();
                        Sp_lot_description = dgvLotData.CurrentRow.Cells["description"].Value.ToString();
                        ths.MatTxtLotNo.Text = Sp_lot_number;
                        ths.MatTxtLotDesc.Text = Sp_lot_description;
                    }
                }
            }
        }

        private void mattxtCategory_TextChanged_1(object sender, EventArgs e)
        {
            this.doSearchInTextBoxCmb();
        }

        private void mattxtLotnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mattxtLotnumber_TextChanged(object sender, EventArgs e)
        {
            this.doSearchInTextBoxCmb();
        }

        private void matbtnSelect_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to select the lot area?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mode = "true";
                this.Close();
            }
            else
            {
                return;
            }

        }
    }
}
