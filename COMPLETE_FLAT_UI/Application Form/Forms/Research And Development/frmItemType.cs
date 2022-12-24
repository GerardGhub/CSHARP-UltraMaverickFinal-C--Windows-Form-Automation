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
using Tulpep.NotificationWindow;
using ULTRAMAVERICK.API.Entities;
using ULTRAMAVERICK.Forms.Research_And_Development.Modal;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Research_And_Development
{
    public partial class frmItemType : MaterialForm
    {

        IStoredProcedures g_objStoredProcCollection = null;
        readonly myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        readonly Item_Type ItemTypeEntity = new Item_Type();
        string mode = "";
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();



        public frmItemType()
        {
            InitializeComponent();
        }

        private void frmItemType_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            myglobal.global_module = "Active"; // Mode for Searching
            this.ShowItemTypeData();
            this.ShowDataRadioButtonActivated();

            this.TextBox1.Text = String.Empty;
        }
        private void ShowDataRadioButtonActivated()
        {
            this.matRadioActive.Checked = true;
        }
        private void ConnectionInit()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections

        }

        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
        
            this.dset_emp_SearchEngines.Clear();

            if (this.matRadioActive.Checked == true)
            {
                this.dset_emp_SearchEngines = g_objStoredProcCollection.sp_getMajorTables("ItemTypeMajor");
            }
            else
            {
                this.dset_emp_SearchEngines = g_objStoredProcCollection.sp_getMajorTables("ItemTypeMajorInActive");
            }


        }

        private void doSearchInTextBox()
        {
            try
            {


                if (dset_emp_SearchEngines.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp_SearchEngines.Tables[0]);
            


                        //Gerard Singian Developer Man



                        dv.RowFilter = "item_type_desc like '%" + this.MatTxtSearchBox.Text + "%'";
               

                
                    this.DgvItemType.DataSource = dv;
                    this.lbltotalrecords.Text = this.DgvItemType.RowCount.ToString();
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

        private void ShowItemTypeData()     //method for loading available_menus
        {
            try
            {
     
                myClass.fillDataGridView(DgvItemType, "Item_Type", dSet);
 
                lbltotalrecords.Text = DgvItemType.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void ShowItemTypeDataInActive()     //method for loading available_menus
        {
            try
            {

                myClass.fillDataGridView(DgvItemType, "Item_TypeInActive", dSet);

                lbltotalrecords.Text = DgvItemType.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }







        private void dgvItemType_CurrentCellChanged(object sender, EventArgs e)
        {
            ShowValueCell();
        }

        private void ShowValueCell()
        {
            if (DgvItemType.Rows.Count > 0)
            {
                if (DgvItemType.CurrentRow != null)
                {
                    if (DgvItemType.CurrentRow.Cells["item_type_desc"].Value != null)
                    {
                        this.ItemTypeEntity.Item_Type_Id = Convert.ToInt32(DgvItemType.CurrentRow.Cells["item_type_id"].Value);
                        this.ItemTypeEntity.Item_Type_Desc = DgvItemType.CurrentRow.Cells["item_type_desc"].Value.ToString();
                        this.ItemTypeEntity.It_Added_By = DgvItemType.CurrentRow.Cells["it_added_by"].Value.ToString();
                        this.ItemTypeEntity.It_Added_At = DgvItemType.CurrentRow.Cells["it_added_at"].Value.ToString();
                        this.ItemTypeEntity.It_Updated_At = DgvItemType.CurrentRow.Cells["it_updated_at"].Value.ToString();
                        this.ItemTypeEntity.It_Updated_By = DgvItemType.CurrentRow.Cells["it_updated_by"].Value.ToString();
                    }
                }
            }
        }

        private void New_Click(object sender, EventArgs e)
        {
            mode = "add";
            matBtnEdit.Visible = false;
            matBtnCancel.Visible = true;

            matBtnNew.Visible = false;


            matBtnDelete.Visible = false;
      

       

            this.ItemTypeEntity.Mode = "ADD";
            FrmAddNewItemType addNew =
            new FrmAddNewItemType(this,
            userinfo.user_id,
            this.ItemTypeEntity.Item_Type_Desc,
            this.ItemTypeEntity.Mode,
            this.ItemTypeEntity.Item_Type_Id);
            addNew.ShowDialog();


        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            matBtnCancel.Visible = false;
            mode = "";
        
            matBtnEdit.Visible = true;
            matBtnSave.Visible = false;
            matBtnNew.Visible = true;
            matBtnDelete.Visible = true;

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            mode = "edit";

            matBtnDelete.Visible = false;
            matBtnCancel.Visible = true;
            matBtnNew.Visible = false;
            matBtnEdit.Visible = false;
       



            this.ItemTypeEntity.Mode = "EDIT";
            FrmAddNewItemType addNew =
            new FrmAddNewItemType(this,
            userinfo.user_id,
            this.ItemTypeEntity.Item_Type_Desc,
            this.ItemTypeEntity.Mode,
            this.ItemTypeEntity.Item_Type_Id);
            addNew.ShowDialog();


        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (DgvItemType.Rows.Count > 0)
            {
                if (this.matRadioActive.Checked == true)
                {

                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to deactivate the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {


                        this.mode = "delete";
                        this.dSet.Clear();
                        this.dSet =
                            this.g_objStoredProcCollection
                            .sp_Item_Type(this.ItemTypeEntity.Item_Type_Id,
                            "",
                            "",
                            "",
                            "",
                            userinfo.user_id.ToString(),
                            "delete");
                        this.GlobalStatePopup.InactiveSuccessfully();
                        this.frmItemType_Load(sender, e);


                    }

                    else
                    {
                        return;
                    }
                }
                else
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to activate the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {


                        this.mode = "activate";
                        this.dSet.Clear();
                        this.dSet =
                            this.g_objStoredProcCollection.
                            sp_Item_Type(this.ItemTypeEntity.Item_Type_Id,
                            "",
                            "",
                            "",
                            "",
                            userinfo.user_id.ToString(),
                            "activate");
                        this.GlobalStatePopup.ActivatedSuccessfully();
                        this.frmItemType_Load(sender, e);


                    }

                    else
                    {
                        return;
                    }


                }




            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void mattxtSearch_TextChanged(object sender, EventArgs e)
        {
         
            this.doSearchInTextBox();
        }

        private void txtmatItemType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.toolStripButton5_Click(sender, e);
            this.frmItemType_Load(sender, e);
        }

        private void matRadioNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (matRadioActive.Checked == true)
            {

                this.matBtnDelete.Text = "&InActive";

                this.ShowItemTypeData();

            }
            else if (matRadioNotActive.Checked == true)
            {

                this.matBtnDelete.Text = "&Activate";
                this.ShowItemTypeDataInActive();

            }
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.SearchMethodJarVarCallingSP();
            this.doSearchInTextBox();
        }

        private void MatTxtSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
