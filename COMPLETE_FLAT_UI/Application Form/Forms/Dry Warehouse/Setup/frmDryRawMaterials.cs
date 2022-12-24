using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMPLETE_FLAT_UI.Models;
using MaterialSkin;
using MaterialSkin.Controls;
using ULTRAMAVERICK.API.Entities;
using ULTRAMAVERICK.Models;

namespace ULTRAMAVERICK.Forms.Dry_Warehouse
{
    public partial class frmDryMiscellaneouseIssue : MaterialForm
    {
        private IStoredProcedures g_objStoredProcCollection = null;
        readonly myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        DateTime dNow = DateTime.Now;
        readonly Raw_Materials_Dry RawMaterialsDryEntity = new Raw_Materials_Dry();
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        DataSet dSet_temp = new DataSet();
        public frmDryMiscellaneouseIssue()
        {
            InitializeComponent();
        }
   
        public string sp_user_id { get; set; }
     



        private void frmDryRawMaterials_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.sp_user_id = userinfo.user_id.ToString();
            this.showRawMaterialsInDryWH();
            this.IfHaveLoadRecords();
            this.LoadingrefresherOrb();
            this.ShowDataRadioButtonActivated();
        }

        private void ShowDataRadioButtonActivated()
        {
            this.matRadioActive.Checked = true;
        }

        private void ConnectionInit()
        {
            this.g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections

        }

        private void IfHaveLoadRecords()
        {
            if (this.lbltotalrecords.Text == "0")
            {

            }
            else
            {
                this.TsEdit.Visible = true;
            }
        }
        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            this.dset_emp_SearchEngines.Clear();

            if (this.matRadioActive.Checked == true)
            {
                this.dset_emp_SearchEngines = this.g_objStoredProcCollection.sp_getMajorTables("Raw_Materials_Dry_Major");
            }
            else
            {
                this.dset_emp_SearchEngines = this.g_objStoredProcCollection.sp_getMajorTables("Raw_Materials_Dry_Major_InActive");
            }
    

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




                        dv.RowFilter = "item_description like '%" + mattxtSearch.Text + "%' " +
                            "or item_code like '%" + mattxtSearch.Text + "%' " +
                            "or item_class like '%" + mattxtSearch.Text + "%' " +
                            "or major_category like '%" + mattxtSearch.Text + "%'" +
                            "or sub_category like '%" + mattxtSearch.Text + "%'" +
                            "or primary_unit like '%" + mattxtSearch.Text + "%'";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    dgvRawMats.DataSource = dv;
                    lbltotalrecords.Text = dgvRawMats.RowCount.ToString();
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




        }





        private void LoadingrefresherOrb()
        {

            if(textBox1.Text == "data Already Save!")
            {
                this.TsEdit.Visible = false;
            }
            else if(textBox1.Text == "Gerard Singian")
            {
                textBox1.Text = string.Empty;
                this.TsNew.Visible = true;
                this.TsEdit.Visible = true;
            }
            else
            {
         
                
            }


      

            myglobal.global_module = "Active"; // Mode for Searching

        }
        private void showRawMaterialsInDryWH()    //method for loading available_menus
        {
            try
            {
             
                this.myClass.fillDataGridView(this.dgvRawMats, "Raw_Materials_Dry", dSet);
            
                this.lbltotalrecords.Text = this.dgvRawMats.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.dgvRawMats.Columns["item_id"].Visible = false;

        }

        private void showRawMaterialsInDryWHInActive()    //method for loading available_menus
        {
            try
            {

                this.myClass.fillDataGridView(this.dgvRawMats, "Raw_Materials_DryInActive", dSet);

                this.lbltotalrecords.Text = this.dgvRawMats.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            this.dgvRawMats.Columns["item_id"].Visible = false;

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            frmDryRawMaterials_Load(sender, e);
        }

   
        private void DgvRawMats_CurrentCellChanged(object sender, EventArgs e)
        {
            this.ShowValueCell();
        }

        private void ShowValueCell()
        {
            if (this.dgvRawMats.Rows.Count > 0)
            {
                if (this.dgvRawMats.CurrentRow != null)
                {
                    if (this.dgvRawMats.CurrentRow.Cells["item_description"].Value != null)
                    {
      
                        this.RawMaterialsDryEntity.Item_Id = Convert.ToInt32(this.dgvRawMats.CurrentRow.Cells["item_id"].Value);
                        this.RawMaterialsDryEntity.Item_Code = this.dgvRawMats.CurrentRow.Cells["item_code"].Value.ToString();
                        this.RawMaterialsDryEntity.Item_Description = this.dgvRawMats.CurrentRow.Cells["item_description"].Value.ToString();
                        this.RawMaterialsDryEntity.Item_Class = this.dgvRawMats.CurrentRow.Cells["item_class"].Value.ToString();
                        this.RawMaterialsDryEntity.Major_Category = this.dgvRawMats.CurrentRow.Cells["major_category"].Value.ToString();
                        this.RawMaterialsDryEntity.Sub_Category = this.dgvRawMats.CurrentRow.Cells["sub_category"].Value.ToString();
                        this.RawMaterialsDryEntity.Primary_Unit = this.dgvRawMats.CurrentRow.Cells["primary_unit"].Value.ToString();
                        this.RawMaterialsDryEntity.Conversion = this.dgvRawMats.CurrentRow.Cells["conversion"].Value.ToString();
                        this.RawMaterialsDryEntity.Item_Type = this.dgvRawMats.CurrentRow.Cells["item_type"].Value.ToString();
                        this.RawMaterialsDryEntity.Buffer_Stock = Convert.ToDouble(this.dgvRawMats.CurrentRow.Cells["buffer_stock"].Value);
                        this.RawMaterialsDryEntity.Expiration_Prompting = Convert.ToInt32(this.dgvRawMats.CurrentRow.Cells["expiration_prompting"].Value);
                        this.RawMaterialsDryEntity.Active_Pu_Conversion = Convert.ToInt32(this.dgvRawMats.CurrentRow.Cells["active_pu_conversion"].Value);
                    }
                }
            }
        }

        private void MattxtSearch_TextChanged(object sender, EventArgs e)
        {

            this.SearchMethodJarVarCallingSP();
       
            this.doSearchInTextBoxCmb();
        }


  

        private void MattxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            this.TsNew.Visible = false;
            this.TsEdit.Visible = false;
            frmAddNewItemModal addNew = new frmAddNewItemModal(this, sp_user_id);
            addNew.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.TsEdit.Visible = false;
            this.TsNew.Visible = false;
            frmEditItemModal mywipwh = new frmEditItemModal(this,
                this.sp_user_id, 
                this.RawMaterialsDryEntity.Item_Code,
                this.RawMaterialsDryEntity.Item_Description,
                this.RawMaterialsDryEntity.Item_Class,
                this.RawMaterialsDryEntity.Major_Category,
                this.RawMaterialsDryEntity.Sub_Category,
                this.RawMaterialsDryEntity.Primary_Unit,
                this.RawMaterialsDryEntity.Conversion,
                this.RawMaterialsDryEntity.Item_Type,
                this.RawMaterialsDryEntity.Item_Id,
                this.RawMaterialsDryEntity.Buffer_Stock,
                this.RawMaterialsDryEntity.Expiration_Prompting,
                 this.RawMaterialsDryEntity.Active_Pu_Conversion
                );
            mywipwh.ShowDialog();
        }



        private void matRadioNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (matRadioActive.Checked == true)
            {

                this.matBtnDelete.Text = "&InActive";

                this.showRawMaterialsInDryWH();
                this.SearchMethodJarVarCallingSP();
            }
            else if (matRadioNotActive.Checked == true)
            {

                this.matBtnDelete.Text = "&Activate";
                this.showRawMaterialsInDryWHInActive();
                this.SearchMethodJarVarCallingSP();
            }
        }

        private void matBtnDelete_Click(object sender, EventArgs e)
        {
            if (this.matRadioActive.Checked == true)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to deactivate the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {


                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_Raw_Materials_Dry(RawMaterialsDryEntity.Item_Id,
                        "this.txtMatItemCode.Text.Trim()",
                        "this.txtMatItemDesc.Text.Trim()",
                        "this.cboItemClass.Text.Trim()",
                        "this.cboMajorCategory.Text.Trim()",
                       "this.cboPrimaryUnit.Text.Trim()",
                        "this.txtmatConversion.Text.Trim()",
                        "this.cboItemType.Text.Trim()",
                        this.RawMaterialsDryEntity.Created_At,
                        this.RawMaterialsDryEntity.Created_By,
                        "", "",
                        "",
                        Convert.ToInt32(this.RawMaterialsDryEntity.Buffer_Stock),
                        this.RawMaterialsDryEntity.Expiration_Prompting.ToString(),
                        "delete");
                    this.GlobalStatePopup.InactiveSuccessfully();
                    this.frmDryRawMaterials_Load(sender, e);
                }

                else
                {
                    return;
                }
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to activate the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_Raw_Materials_Dry(RawMaterialsDryEntity.Item_Id,
                        "this.txtMatItemCode.Text.Trim()",
                        "this.txtMatItemDesc.Text.Trim()",
                        "this.cboItemClass.Text.Trim()",
                        "this.cboMajorCategory.Text.Trim()",
                       "this.cboPrimaryUnit.Text.Trim()",
                        "this.txtmatConversion.Text.Trim()",
                        "this.cboItemType.Text.Trim()",
                        this.RawMaterialsDryEntity.Created_At,
                        this.RawMaterialsDryEntity.Created_By,
                        "", "",
                        "",
                        Convert.ToInt32(this.RawMaterialsDryEntity.Buffer_Stock),
                        this.RawMaterialsDryEntity.Expiration_Prompting.ToString(),
                        "activate");
                    this.GlobalStatePopup.ActivatedSuccessfully();
                    this.frmDryRawMaterials_Load(sender, e);
                }

                else
                {
                    return;
                }

            }


        }
    }
    }

