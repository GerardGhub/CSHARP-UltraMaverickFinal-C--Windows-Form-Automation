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
    public partial class FrmItemClass : MaterialForm
    {


        PopupNotifierClass  GlobalStatePopup = new PopupNotifierClass();

        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();
        Item_Class Item_ClassEntity = new Item_Class();
        string mode = "";

        int temp_hid = 0;
        DateTime dNow = DateTime.Now;
        Boolean ready = false;


        DataSet dSet_temp = new DataSet();

        public FrmItemClass()
        {
            InitializeComponent();
        }


   
        private void frmItemClass_Load(object sender, EventArgs e)
        {
            this.ShowDataActivated();
            this.ConnetionString();
            myglobal.global_module = "Active"; // Mode for Searching
            this.showItemClassData();
            this.SearchMethodJarVarCallingSP();
            this.textBox1.Text = String.Empty;
        }
        private void ConnetionString()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
 
        }
        private void ShowDataActivated()
        {
            this.matRadioActive.Checked = true;
        }

        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            dset_emp_SearchEngines.Clear();


            dset_emp_SearchEngines = g_objStoredProcCollection.sp_getMajorTables("Item_Class_Major");

        }


        private void SearchMethodJarVarCallingSPInactive()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            dset_emp_SearchEngines.Clear();


            dset_emp_SearchEngines = g_objStoredProcCollection.sp_getMajorTables("Item_Class_Major_Inactive");

        }


        private void doSearchInTextBox()
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




                        dv.RowFilter = "item_class_desc like '%" + mattxtSearch.Text + "%'";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    dgvitemClass.DataSource = dv;
                    lbltotalrecords.Text = dgvitemClass.RowCount.ToString();
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


        private void showItemClassData()      //method for loading available_menus
        {
            try
            {

                myClass.fillDataGridView(dgvitemClass, "Item_Class", dSet);

                lbltotalrecords.Text = dgvitemClass.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void showItemClassDataInActive()      //method for loading available_menus
        {
            try
            {

                myClass.fillDataGridView(dgvitemClass, "Item_Class_InActive", dSet);
  
                lbltotalrecords.Text = dgvitemClass.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }



        private void matBtnCancel_Click(object sender, EventArgs e)
        {
            matBtnCancel.Visible = false;
            mode = "";

            matBtnEdit.Visible = true;
            matBtnSave.Visible = false;
            matBtnNew.Visible = true;
            matBtnDelete.Visible = true;

        }



    






  

        private void metroSave_Click(object sender, EventArgs e)
        {
            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to update the  Item Class Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

           

            }

            else
            {
                return;
            }

        }






        private void metroFinalSaving_Click(object sender, EventArgs e)
        {


      
        }

        private void dgvitemClass_CurrentCellChanged_1(object sender, EventArgs e)
        {
            if (dgvitemClass.Rows.Count > 0)
            {
                if (dgvitemClass.CurrentRow != null)
                {
                    if (dgvitemClass.CurrentRow.Cells["item_class_desc"].Value != null)
                    {
                        this.Item_ClassEntity.Item_Class_Id = Convert.ToInt32(dgvitemClass.CurrentRow.Cells["item_class_id"].Value);
                     this.Item_ClassEntity.Item_Class_Desc = dgvitemClass.CurrentRow.Cells["item_class_desc"].Value.ToString();
                        this.Item_ClassEntity.Item_Added_By = dgvitemClass.CurrentRow.Cells["item_added_by"].Value.ToString();
                       this.Item_ClassEntity.Item_Added_At = dgvitemClass.CurrentRow.Cells["item_added_at"].Value.ToString();
                       this.Item_ClassEntity.Item_Updated_At = dgvitemClass.CurrentRow.Cells["item_updated_at"].Value.ToString();
                        this.Item_ClassEntity.Item_Updated_By = dgvitemClass.CurrentRow.Cells["item_updated_by"].Value.ToString();
                  
                    }
                }
            }

        }


  
        private void btnAddTool_Click(object sender, EventArgs e)
        {
            mode = "add";
            matBtnEdit.Visible = false;
            matBtnCancel.Visible = true;

            matBtnNew.Visible = false;

  
            matBtnDelete.Visible = false;
 

            matBtnSave.Visible = true;
    

            this.Item_ClassEntity.Mode = "ADD";
            FrmAddNewItemClass addNew = 
            new FrmAddNewItemClass(this,
            userinfo.user_id,
            this.Item_ClassEntity.Item_Class_Desc,
            this.Item_ClassEntity.Mode,
            this.Item_ClassEntity.Item_Class_Id);
            addNew.ShowDialog();


        }

        private void btnCancelTool_Click(object sender, EventArgs e)
        {
            matBtnCancel.Visible = false;
            mode = "";

            matBtnEdit.Visible = true;
            matBtnSave.Visible = false;
            matBtnNew.Visible = true;
            matBtnDelete.Visible = true;
       
        }

        private void btnEditTool_Click(object sender, EventArgs e)
        {
            mode = "edit";


            matBtnDelete.Visible = false;
            matBtnCancel.Visible = true;
            matBtnNew.Visible = false;
            matBtnEdit.Visible = false;
            matBtnSave.Visible = true;
  

            this.Item_ClassEntity.Mode = "EDIT";
            FrmAddNewItemClass addNew =
            new FrmAddNewItemClass(this,
            userinfo.user_id,
            this.Item_ClassEntity.Item_Class_Desc,
            this.Item_ClassEntity.Mode,
            this.Item_ClassEntity.Item_Class_Id);
            addNew.ShowDialog();
        }

        private void btnDeleteTool_Click(object sender, EventArgs e)
        {
            if (this.matRadioActive.Checked == true)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to deactivate the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    mode = "delete";

                    this.dSet_temp.Clear();
                    this.dSet_temp = this.g_objStoredProcCollection.sp_Item_Class(this.Item_ClassEntity.Item_Class_Id, "", "", "", "", "", "delete");
                    this.GlobalStatePopup.InactiveSuccessfully();
                    this.frmItemClass_Load(sender, e);
                }

                else
                {
                    return;
                }
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to activate the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    mode = "activate";

                    this.dSet_temp.Clear();
                    this.dSet_temp = this.g_objStoredProcCollection.sp_Item_Class(this.Item_ClassEntity.Item_Class_Id, "", "", "", "", "", "activate");
                    this.GlobalStatePopup.ActivatedSuccessfully();
                    this.frmItemClass_Load(sender, e);
                }

                else
                {
                    return;
                }
            }

      
        }



        private void btnUpdateTool_Click(object sender, EventArgs e)
        {

        
        }

        private void mattxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (mattxtSearch.Text == "")
            {
                showItemClassData();
            }
            if (lbltotalrecords.Text == "0")
            {

            }
            else
            {
                if (mode == "add")
                {

                }
                else
                {
                    doSearchInTextBox();
                }

            }
        }

        private void matRadioNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (matRadioActive.Checked == true)
            {

                this.matBtnDelete.Text = "&InActive";

                this.showItemClassData();
                this.SearchMethodJarVarCallingSP();
            }
            else if (matRadioNotActive.Checked == true)
            {
      
                this.matBtnDelete.Text = "&Activate";
                this.showItemClassDataInActive();
                this.SearchMethodJarVarCallingSP();
            }
            else
            {

            }
        }

        private void matRadioActive_CheckedChanged(object sender, EventArgs e)
        {
            if (matRadioActive.Checked == true)
            {

                this.matBtnDelete.Text = "&InActive";
     
                this.showItemClassData();
    
            }
            else if (matRadioNotActive.Checked == true)
            {
       
                this.matBtnDelete.Text = "&Activate";
                this.showItemClassDataInActive();
        
            }
            else
            {

            }
        }

        private void mattxtSearch_TextChanged_1(object sender, EventArgs e)
        {
    
            if (this.matRadioActive.Checked == true)
            {
            
            this.SearchMethodJarVarCallingSP();
            }
            else
            {
            this.SearchMethodJarVarCallingSPInactive();
            }
            this.doSearchInTextBox();
        }

        private void mattxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtmatItemClass_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtmatItemClass_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.btnCancelTool_Click(sender, e);
            this.frmItemClass_Load(sender, e);
        }

        private void FrmItemClass_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.textBox1.Text = "Gerard Singian";
        }
    }
}
