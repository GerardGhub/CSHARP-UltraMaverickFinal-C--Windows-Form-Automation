using COMPLETE_FLAT_UI.Models;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Windows.Forms;
using ULTRAMAVERICK.API.Data;
using ULTRAMAVERICK.API.Entities;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Move_Order
{
    public partial class FrmDryWhMiscellaneouseIssue : MaterialForm
    {
        myclasses xClass = new myclasses();
        TblCustomersRepository TblCustomerRepo = new TblCustomersRepository();
        DryWHReceipt DryWHIssueEntity = new DryWHReceipt();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();


        DateTime dNow = DateTime.Now;

        int Useridentity = 0;
        int p_id = 0;
        DataSet dSet_temp = new DataSet();

        public FrmDryWhMiscellaneouseIssue()
        {
            InitializeComponent();
        }

        private void FrmDryWhMiscellaneouseIssue_Load(object sender, EventArgs e)
        {
            this.Text = "Miscellaneous Issue";
            this.ConnetionString();
            this.Useridentity = userinfo.user_id;
            this.SearchMethodJarVarCallingSP();
            this.doSearchInTextBox();
            this.LoadWarehouseDropdown();
            this.LoadCustomerDropdown();
            this.LoadParentIssueCmb();
            //if (this.MatTxTTransactNo.Text != String.Empty)
            //{
            //    this.MatBtnNew.Enabled = true;
            //}

            if (this.LblTotalRecords.Text == "0")
            {
                this.MatBtnNew.Enabled = true;
            }
            else
            {
                this.MatBtnSave.Enabled = true;
            }
        }

        private void DataGridVisibilityHidden()
        {
            this.guna2DgvMaterialPreparation.Columns["ParentDescription"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["TransactionNo"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["AddedBy"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["DateAdded"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["IsActive"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["Supplier"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["Id"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["Remarks"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["UnitOfMeasure"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["ExpiryDays"].Visible = false;
            this.guna2DgvMaterialPreparation.Columns["Quantity"].Visible = false;
        }



        private void doSearchInTextBox()
        {
            try
            {


                if (dset_emp_SearchEngines.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp_SearchEngines.Tables[0]);

                    if (myglobal.global_module == "Active")
                    {
                        dv.RowFilter = "AddedBy = '" + this.Useridentity + "' ";
                    }

                    this.guna2DgvMaterialPreparation.DataSource = dv;
                    LblTotalRecords.Text = this.guna2DgvMaterialPreparation.RowCount.ToString();
                }
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Invalid Character Found xxx!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid Character Found 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            this.DataGridVisibilityHidden();


        }




        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            myglobal.global_module = "Active";
            dset_emp_SearchEngines.Clear();
            dset_emp_SearchEngines = g_objStoredProcCollection.sp_getMajorTables("DryWHIssue_Major");
        }


        public void LoadParentIssueCmb()
        {

            myClass.fillCmbTransactionNo(MatTxTTransactNo, "DryWHIssueParents_dropdown", dSet, Useridentity);
            this.MatTxTTransactNo_SelectionChangeCommitted(new object(), new System.EventArgs());
        }

        public void LoadWarehouseDropdown()
        {
            myClass.fillComboBoxRMDryItemCode(MatCmbWarehouses, "Tblwarehouses_dropdown", dSet);
            this.MatCmbWarehouses_SelectionChangeCommitted(new object(), new System.EventArgs());
        }

        public void LoadCustomerDropdown()
        {
            myClass.fillComboBoxRMDryItemCode(MatCmbCustomer, "tblCustomers_dropdown", dSet);
            this.MatCmbCustomer_SelectionChangeCommitted(new object(), new System.EventArgs());
        }

        private void ConnetionString()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections();
        }

        private void MatCmbWarehouses_SelectionChangeCommitted(object sender, EventArgs e)
        {
         
            this.MatTxtAccountTitle.Text = MatCmbWarehouses.SelectedValue.ToString();

        }

        private void MatCmbCustomer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.MatTxtAddress.Text = MatCmbCustomer.SelectedValue.ToString();

        }

        private void LblTotalRecords_TextChanged(object sender, EventArgs e)
        {
            if (this.LblTotalRecords.Text == "0")
            {
                this.MatBtnSave.Visible = false;
                this.guna2DgvMaterialPreparation.Enabled = false;
            }
            else
            {
                this.MatBtnSave.Visible = true;
                this.MatBtnSave.Enabled = true;
                this.guna2DgvMaterialPreparation.Enabled = true;
            }
        }

        private void MatTxtAccountTitle_TextChanged(object sender, EventArgs e)
        {
            if (this.MatTxtAccountTitle.Text != String.Empty
               && this.MatTxtAddress.Text != String.Empty
               && this.MatCmbRemarks.Text != String.Empty
               && this.MatTxtParentDescription.Text != String.Empty)
            {
                this.MatBtnSave.Visible = true;
            }
        }

        private void MatTxtAddress_TextChanged(object sender, EventArgs e)
        {
            if (this.MatTxtAccountTitle.Text != String.Empty
             && this.MatTxtAddress.Text != String.Empty
             && this.MatCmbRemarks.Text != String.Empty
             && this.MatTxtParentDescription.Text != String.Empty)
            {
                this.MatBtnSave.Visible = true;
            }
        }

        private void MatCmbRemarks_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.MatTxtAccountTitle.Text != String.Empty
               && this.MatTxtAddress.Text != String.Empty
               && this.MatCmbRemarks.Text != String.Empty
               && this.MatTxtParentDescription.Text != String.Empty)
            {
                if (this.LblTotalRecords.Text != "0")
                {
                    this.MatBtnSave.Visible = true;
                }
            }
        }




        private void ClearTextBox()
        {
            this.MatTxTTransactNo.Text = String.Empty;
            this.MatCmbRemarks.Text = String.Empty;
            this.MatTxtParentDescription.Text = String.Empty;
        }


        private void MatBtnSave_Click(object sender, EventArgs e)
        {
            if (this.LblTotalRecords.Text == "0")
            {
                return;
            }
            if (this.MatTxtParentDescription.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.MatTxtParentDescription.Focus();
                return;
            }

            if (this.MatTxtAccountTitle.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.MatTxtAccountTitle.Focus();
                return;
            }

            if (this.MatTxtAddress.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.MatTxtAddress.Focus();
                return;
            }


            if (this.MatCmbRemarks.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.MatCmbRemarks.Focus();
                return;
            }

            if (this.LblTotalRecords.Text == "0")
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to save? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    dSet.Clear();
                    dSet = g_objStoredProcCollection
                    .sp_DryWHIssueParents(0,
                    this.MatTxtParentDescription.Text.Trim(),
                    this.MatCmbRemarks.Text.Trim(),
                    true,
                    Convert.ToString(this.Useridentity),
                    DateTime.Now,
                    "add");

                    this.ConnetionString();

                    this.LoadParentIssueCmb();

                    if (this.MatTxtParentDescription.Text != String.Empty)
                    {
                        this.MatBtnNew.Enabled = true;
                        if (this.LblTotalRecords.Text == "0")
                        {
                            this.MatBtnSave.Enabled = false;
                        }

                    }
                }
                else
                {
                    return;
                }
            }

            else
            {

                if (this.MatTxTTransactNo.Text == String.Empty)
                {
                    this.MatTxTTransactNo.Text = "0";
                }


                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to save? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    dSet.Clear();
                    dSet = g_objStoredProcCollection
                    .sp_DryWHIssueParents(0,
                    this.MatTxtParentDescription.Text.Trim(),
                    this.MatCmbRemarks.Text.Trim(),
                    true,
                    Convert.ToString(this.Useridentity),
                    DateTime.Now,
                    "add");

                    this.ConnetionString();

                    this.LoadParentIssueCmb();

                    if (this.MatTxtParentDescription.Text != String.Empty)
                    {
                        this.MatBtnNew.Enabled = true;
                        if (this.LblTotalRecords.Text == "0")
                        {
                            this.MatBtnSave.Enabled = false;
                        }

                    }




                    try
                    {



                        foreach (DataGridViewRow row in guna2DgvMaterialPreparation.Rows)
                        {

                            dSet.Clear();
                            dSet = g_objStoredProcCollection
                            .Sp_DryWHIssue(Convert.ToInt32(row.Cells["Id"].Value.ToString()),
                            this.MatTxtParentDescription.Text.Trim(),
                            Convert.ToInt32(this.MatTxTTransactNo.Text.Trim()),
                            0,
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                           DryWHIssueEntity.Category,
                             "this.MatTxtSupploer.Text.Trim()",
                            0,
                           "this.matCmbRemarks.Text.Trim()",
                            "",
                            "",
                            false,
                            0,
                            0,
                            "edit");
                        }
                        this.GlobalStatePopup.SuccessfullyReceived();
                        this.ClearTextBox();
                        this.FrmDryWhMiscellaneouseIssue_Load(sender, e);

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    return;
                }
            }

        }

        private void MatTxTTransactNo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.MatTxTTransactNo.Text != String.Empty)
            {
                this.MatTxtParentDescription.Text = this.MatTxTTransactNo.SelectedValue.ToString();
            }
        }

        private void MatBtnNew_Click(object sender, EventArgs e)
        {

            if(this.MatTxtParentDescription.Text == String.Empty )
            {
                this.MatTxtParentDescription.Focus();
                this.GlobalStatePopup.FillRequiredFields();
                return;
            }

            if (this.MatCmbRemarks.Text == String.Empty)
            {
                this.MatCmbRemarks.Focus();
                this.GlobalStatePopup.FillRequiredFields();
                return;
            }

            this.MatBtnNew.Enabled = false;
            FrmAddNewMiscellaneousIssue AddIssue = new FrmAddNewMiscellaneousIssue(this);
            AddIssue.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text != String.Empty)
            {
                this.MatBtnNew.Enabled = true;
                this.textBox1.Text = String.Empty;
                this.FrmDryWhMiscellaneouseIssue_Load(sender, e);
            }
        }

        private void guna2DgvMaterialPreparation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DgvMaterialPreparation.Columns[e.ColumnIndex].Name == "CANCEL")
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to cancel? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    try
                    {
                        dSet.Clear();
                        dSet = g_objStoredProcCollection
                        .Sp_DryWHIssue(p_id,
                        "",
                        0,
                        0,
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        0,
                        "",
                        "",
                        "",
                        false,
                        0,
                        0,
                        "delete");

                        this.FrmDryWhMiscellaneouseIssue_Load(sender, e);
                        this.GlobalStatePopup.CancelledSuccessfully();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }


                }

                else
                {
                    return;
                }



            }



        }

        private void guna2DgvMaterialPreparation_CurrentCellChanged(object sender, EventArgs e)
        {

            if (this.guna2DgvMaterialPreparation.Rows.Count > 0)
            {
                if (this.guna2DgvMaterialPreparation.CurrentRow != null)
                {
                    if (this.guna2DgvMaterialPreparation.CurrentRow.Cells["ItemCode"].Value != null)
                    {
                        this.p_id = Convert.ToInt32(this.guna2DgvMaterialPreparation.CurrentRow.Cells["Id"].Value);
                        DryWHIssueEntity.LotNumber = Convert.ToInt32(this.guna2DgvMaterialPreparation.CurrentRow.Cells["LotNumber"].Value);
                        DryWHIssueEntity.LotDescription = this.guna2DgvMaterialPreparation.CurrentRow.Cells["LotDescription"].Value.ToString();
                        DryWHIssueEntity.Quantity = Convert.ToInt32(this.guna2DgvMaterialPreparation.CurrentRow.Cells["Quantity"].Value);
                        DryWHIssueEntity.Category = this.guna2DgvMaterialPreparation.CurrentRow.Cells["Category"].Value.ToString();
                        DryWHIssueEntity.ExpiryDays = this.guna2DgvMaterialPreparation.CurrentRow.Cells["ExpiryDays"].Value.ToString();

                    }
                }
            }



        }
    }
}
