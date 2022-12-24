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
using ULTRAMAVERICK.API.Data;
using ULTRAMAVERICK.API.Entities;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse.Move_Order
{
    public partial class frmDryWhMiscellaneousReceipts : MaterialForm
    {
        myclasses xClass = new myclasses();
        frmDryWhMiscellaneousReceipts ths;

        TblCustomersRepository TblCustomerRepo = new TblCustomersRepository();
        DryWHReceipt DryWHReceiptEntity = new DryWHReceipt();
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();


        DateTime dNow = DateTime.Now;

        int Useridentity = 0;
        int p_id = 0;
        DataSet dSet_temp = new DataSet();

        public frmDryWhMiscellaneousReceipts()
        {
            InitializeComponent();
        }

        private void frmDryWhMiscellaneousReceipts_Load(object sender, EventArgs e)
        {
            this.ConnetionString();
            this.Useridentity = userinfo.user_id;
            this.SearchMethodJarVarCallingSP();
            this.doSearchInTextBox();
            this.LoadItemCodeDropdown();
            this.LoadParentReceiptCmb();
            if (this.LblTotalRecords.Text =="0" )
            {
                this.MatBtnNew.Enabled = true;
            }
            else
            {
                this.MatBtnSave.Enabled = true;
            }
        }


        public void LoadItemCodeDropdown()
        {
            myClass.fillComboBoxRMDryItemCode(MatCmbSupplierCode, "Suppliers_dropdown", dSet);
            this.MatCmbSupplierCode_SelectionChangeCommitted(new object(), new System.EventArgs());
        }

        public void LoadParentReceiptCmb()
        {

            myClass.fillCmbTransactionNo(MatTxTTransactNo, "DryWHReceiptParents_dropdown", dSet, Useridentity);
            this.MatTxTTransactNo_SelectionChangeCommitted(new object(), new System.EventArgs());
        }

        private void ConnetionString()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections();

        }

        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            myglobal.global_module = "Active";
            dset_emp_SearchEngines.Clear();


            dset_emp_SearchEngines = g_objStoredProcCollection.sp_getMajorTables("DryWHReceipt_Major");

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
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (this.MatTxtParentDescription.Text == String.Empty)
            {
                this.MatTxtParentDescription.Focus();
                return;
            }
            this.MatBtnNew.Enabled = false;
            FrmAddNewMiscellaneousReceipt AddReceipt = new FrmAddNewMiscellaneousReceipt(this);
            AddReceipt.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text != String.Empty)
            {
                this.MatBtnNew.Enabled = true;
                this.textBox1.Text = String.Empty;
                this.frmDryWhMiscellaneousReceipts_Load(sender, e);
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
                        DryWHReceiptEntity.LotNumber = Convert.ToInt32(this.guna2DgvMaterialPreparation.CurrentRow.Cells["LotNumber"].Value);
                        DryWHReceiptEntity.LotDescription = this.guna2DgvMaterialPreparation.CurrentRow.Cells["LotDescription"].Value.ToString();
                        DryWHReceiptEntity.Quantity = Convert.ToInt32(this.guna2DgvMaterialPreparation.CurrentRow.Cells["Quantity"].Value);
                        DryWHReceiptEntity.Category  = this.guna2DgvMaterialPreparation.CurrentRow.Cells["Category"].Value.ToString();
                        DryWHReceiptEntity.ExpiryDays = this.guna2DgvMaterialPreparation.CurrentRow.Cells["ExpiryDays"].Value.ToString();

                    }
                }
            }


        }

        private void MatCmbSupplierCode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int IndexOf = 0;
            this.MatTxtSupploer.Text = MatCmbSupplierCode.SelectedValue.ToString();


            IndexOf = MatCmbSupplierCode.SelectedIndex;
            xClass.DataSetRMMoverOrderReceipt = g_objStoredProcCollection.sp_getMinorTables("Suppliers_dropdown", null, null, null, null, null);
            //this.MatTxtSupploer.Text = xClass.DataSetRMMoverOrderReceipt.Tables[0].Rows[IndexOf]["SupplierName"].ToString();


        }

        private void lbltotalrecords_TextChanged(object sender, EventArgs e)
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

        private void MatBtnSave_Click(object sender, EventArgs e)
        {
            if (this.MatTxtSupploer.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.MatTxtSupploer.Focus();
                return;
            }

            if (this.MatTxtParentDescription.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.MatTxtParentDescription.Focus();
                return;
            }

            if (this.matCmbRemarks.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                this.matCmbRemarks.Focus();
                return;
            }
            if (this.LblTotalRecords.Text == "0")
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to save? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dSet.Clear();
                    dSet = g_objStoredProcCollection
                    .sp_DryWHReceiptParents(0,
                    this.MatTxtParentDescription.Text.Trim(),
                    this.matCmbRemarks.Text.Trim(),
                    true,
                    Convert.ToString(this.Useridentity),
                    DateTime.Now,
                    "add");
                    this.ConnetionString();
                    this.LoadParentReceiptCmb();
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


                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to save? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    dSet.Clear();
                    dSet = g_objStoredProcCollection
                    .sp_DryWHReceiptParents(0,
                    this.MatTxtParentDescription.Text.Trim(),
                    this.matCmbRemarks.Text.Trim(),
                    true,
                    Convert.ToString(this.Useridentity),
                    DateTime.Now,
                    "add");
                    this.ConnetionString();
                    this.LoadParentReceiptCmb();
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
                            .Sp_DryWHReceipt(Convert.ToInt32(row.Cells["Id"].Value.ToString()),
                            this.MatTxtParentDescription.Text.Trim(),
                            Convert.ToInt32(this.MatTxTTransactNo.Text.Trim()),
                            0,
                            "",
                            "",
                            "",
                            "",
                            "",
                            "",
                           DryWHReceiptEntity.Category,
                             this.MatTxtSupploer.Text.Trim(),
                            0,
                           this.matCmbRemarks.Text.Trim(),
                            "",
                            "",
                            false,
                            "edit");


                            this.dSet.Clear();
                            this.dSet = g_objStoredProcCollection.sp_tblDryWHReceiving(0,
                                p_id,
                                row.Cells["ItemCode"].Value.ToString(),
                                row.Cells["ItemDescription"].Value.ToString(),
                                row.Cells["Quantity"].Value.ToString(),
                                "",
                                this.Useridentity.ToString(),
                                user_info.firstname,
                                "",
                                row.Cells["Supplier"].Value.ToString(),
                                row.Cells["LotNumber"].Value.ToString(),
                                row.Cells["LotDescription"].Value.ToString(),
                                row.Cells["ManufacturingDate"].Value.ToString(),
                                row.Cells["ExpirationDate"].Value.ToString(),
                                row.Cells["Category"].Value.ToString(),
                                row.Cells["UnitOfMeasure"].Value.ToString(),
                                "0",
                                0,
                                this.Useridentity,
                                row.Cells["ExpiryDays"].Value.ToString(),
                                "",
                                "",
                                "",
                                "",
                                1, //Expiry Bobo
                                "",
                                "",
                                "AddDryWhReceipt");



           



                        }
                        this.GlobalStatePopup.SuccessfullyReceived();
                        this.ClearTextBox();
                        this.frmDryWhMiscellaneousReceipts_Load(sender, e);

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


        private void ClearTextBox()
        {
            this.MatTxtParentDescription.Text = String.Empty;
            this.MatTxTTransactNo.Text = String.Empty;
            DryWHReceiptEntity.LotNumber = 0;
            DryWHReceiptEntity.LotDescription = String.Empty;
            DryWHReceiptEntity.Quantity = 0;
            DryWHReceiptEntity.Category = String.Empty;
            DryWHReceiptEntity.ExpiryDays = String.Empty;
            this.MatTxtSupploer.Text = String.Empty;
            this.MatTxtParentDescription.Text = String.Empty;
            this.matCmbRemarks.Text = String.Empty;
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
                        .Sp_DryWHReceipt(p_id,
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
                        "delete");

                        this.frmDryWhMiscellaneousReceipts_Load(sender, e);
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

        private void MatTxTTransactNo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(this.MatTxTTransactNo.Text != String.Empty)
            {
                this.MatTxtParentDescription.Text = this.MatTxTTransactNo.SelectedValue.ToString();
            }


        }



        private void MatTxtSupploer_TextChanged(object sender, EventArgs e)
        {
            if (this.MatTxtSupploer.Text != String.Empty && this.matCmbRemarks.Text != String.Empty)
            {
                this.MatBtnNew.Enabled = true;
            }
        }

        private void matCmbRemarks_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (this.MatTxtSupploer.Text != String.Empty && this.matCmbRemarks.Text != String.Empty)
            {
                if (this.LblTotalRecords.Text != "0")
                {
                    this.MatBtnSave.Visible = true;
                }
            }
        }

        private void MatTxtParentDescription_TextChanged(object sender, EventArgs e)
        {
            if (this.MatTxtSupploer.Text != String.Empty && this.matCmbRemarks.Text != String.Empty)
            {
                this.MatBtnNew.Enabled = true;
            }
        }
    }
}
