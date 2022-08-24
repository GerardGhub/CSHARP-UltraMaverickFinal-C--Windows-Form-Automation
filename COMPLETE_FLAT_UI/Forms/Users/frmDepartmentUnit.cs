using COMPLETE_FLAT_UI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;
using MaterialSkin;
using MaterialSkin.Controls;
using ULTRAMAVERICK.Forms.Users.Modal;
using ULTRAMAVERICK.API.Entities;

namespace ULTRAMAVERICK.Forms.Users
{
    public partial class frmDepartmentUnit : MaterialForm
    {
    


        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();

        string mode = "";
        int p_id = 0;
        int temp_hid = 0;
        DateTime dNow = DateTime.Now;
        Boolean ready = false;
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();

        DepartmentUnit DeptUnit = new DepartmentUnit();



        IStoredProcedures g_objStoredProcCollection = null;
        DataSet dSet_temp = new DataSet();

        public frmDepartmentUnit()
        {
            InitializeComponent();
        }

        public string sp_department_id { get; set; }

        private void ConnectionInit()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }
        private void frmDepartmentUnit_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
            this.getRadionDataChanged();
            this.DisplayDepartmentUnits();
            this.textBox1.Text = String.Empty;
            
        }
        private void getRadionDataChanged()
        {
            this.matRadioActive.Checked = true;

        }
        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            myglobal.global_module = "Active"; // Mode for Searching


            dset_emp_SearchEngines.Clear();

            if (this.matRadioActive.Checked == true)
            {
                dset_emp_SearchEngines = g_objStoredProcCollection.sp_getMajorTables("DepartmentUnitMajor");
            }
            else
            {
                dset_emp_SearchEngines = g_objStoredProcCollection.sp_getMajorTables("DepartmentUnitMajorInActive");
            }
 

        }

        private void doSearchInTextBoxCmb()
        {
            try
            {


                if (dset_emp_SearchEngines.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp_SearchEngines.Tables[0]);
         

                        dv.RowFilter = "unit_description like '%" + TxtSearch.Text + "%'";

                    
             
                    this.dgvUnits.DataSource = dv;
                    this.lbltotalrecords.Text = this.dgvUnits.RowCount.ToString();
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




                        dv.RowFilter = "unit_description like '%" + mattxtSearch.Text + "%'";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    dgvUnits.DataSource = dv;
                    lbltotalrecords.Text = dgvUnits.RowCount.ToString();
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


        private void DisplayDepartmentUnits()      //method for loading available_menus
        {
     
            myClass.fillDataGridView(dgvUnits, "DepartmentUnit", dSet);
     
            this.lbltotalrecords.Text = dgvUnits.RowCount.ToString();
        }


        private void DisplayDepartmentUnitsInactive()      //method for loading available_menus
        {

            myClass.fillDataGridView(dgvUnits, "DepartmentUnitInActive", dSet);

            this.lbltotalrecords.Text = dgvUnits.RowCount.ToString();
        }



        //public void loadDepartment()
        //{
        //    ready = false;
        //    myClass.fillComboBoxDepartment(cbodepartment, "department_dropdown", dSet);
        //    ready = true;

        //   this.sp_department_id = cbodepartment.SelectedValue.ToString();
        //}

        private void btnAddTool_Click(object sender, EventArgs e)
        {
            this.mode = "add";
            this.btn_visible(false);
   

            //this.sp_department_id = cbodepartment.SelectedValue.ToString(); //Binding First Meet

            this.txtCreatedByAndUserID.Text = userinfo.user_id.ToString();

        }
        private void btn_visible(Boolean val)
        {
            this.btnAddTool.Visible = val;
            this.btnEditTool.Visible = val;
            this.btnDeleteTool.Visible = val;


            this.btnUpdateTool.Visible = !val;
            this.btnCancelTool.Visible = !val;
        }


        private void btnCancelTool_Click(object sender, EventArgs e)
        {
            mode = "";

            btn_visible(true);
            dgvUnits_CurrentCellChanged(sender, e);
   
        }

        private void dgvUnits_CurrentCellChanged(object sender, EventArgs e)
        {
            showValue();
        }

        private void showValue()
        {
            if (dgvUnits.Rows.Count > 0)
            {
                if (dgvUnits.CurrentRow != null)
                {
                    if (dgvUnits.CurrentRow.Cells["unit_description"].Value != null)
                    {
                        this.DeptUnit.Unit_Id = Convert.ToInt32(dgvUnits.CurrentRow.Cells["unit_id"].Value);
                        this.DeptUnit.Unit_Description = dgvUnits.CurrentRow.Cells["unit_description"].Value.ToString();
                        this.DeptUnit.Department = dgvUnits.CurrentRow.Cells["department"].Value.ToString();
                        this.DeptUnit.Updated_At = dgvUnits.CurrentRow.Cells["updated_at"].Value.ToString();
                        this.DeptUnit.Updated_By = dgvUnits.CurrentRow.Cells["updated_by"].Value.ToString();
                        this.DeptUnit.Created_At = dgvUnits.CurrentRow.Cells["created_at"].Value.ToString();
                        this.DeptUnit.Created_By = dgvUnits.CurrentRow.Cells["created_by"].Value.ToString();
  
                    }
                }
            }
        }

        public void SectionAlreadyExist()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Child Menu Already Exist!";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Red;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }

        private void btnUpdateTool_Click(object sender, EventArgs e)
        {

            //dSet.Clear();
            //dSet = objStorProc.sp_DepartmentUnit(0, TxtDepartmentUnit.Text, "", "", "", "", "", "getbyname");

            //if (dSet.Tables[0].Rows.Count > 0)
            //{
            //    SectionAlreadyExist();


            //    TxtDepartmentUnit.Focus();
            //    return;
            //}
            //else
            //{
            //    metroSave_Click(sender, e);
            //}


        }


        public void FillRequiredFields()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Fill up the required fields!";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Red;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }

        private void UpdateNotifications()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "SUCCESSFULLY UPDATE FORM INFORMATION";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Green;
            popup.Popup();
            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);
            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }

        private void metroSave_Click(object sender, EventArgs e)
        {
            //if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to update the Department Section", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            //{

            //    if (cbodepartment.Text.Trim() == string.Empty)
            //    {
            //        FillRequiredFields();
            //        cbodepartment.Focus();


            //        return;
            //    }


            //    if (TxtDepartmentUnit.Text.Trim() == string.Empty)
            //    {
            //        FillRequiredFields();
            //        TxtDepartmentUnit.Focus();


            //        return;
            //    }

      

            //    else
            //    {
            //        //if (saveMode())
            //        //{
            //        //    displayDepartmentUnits();
            //        //    string tmode = mode;

            //        //    if (tmode == "add")
            //        //    {
            //        //        dgvUnits.CurrentCell = dgvUnits[0, dgvUnits.Rows.Count - 1];
            //        //        UpdateNotifications();
            //        //    }
            //        //    else
            //        //    {
            //        //        dgvUnits.CurrentCell = dgvUnits[0, temp_hid];

            //        //    }
            //        //    btnCancelTool_Click(sender, e);
            //        //    UpdateNotifications();
            //        //}
            //        //else

            //        //    metroFinalSaving_Click(sender, e);
            //        //return;
            //    }
            //}

            //else
            //{
            //    return;
            //}

        }





        private void metroFinalSaving_Click(object sender, EventArgs e)
        {
         
        }

    

        private void BtnModuleClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public void DeletedSuccessfully()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Deleted Successfully";
            popup.ContentColor = Color.White;
            popup.ContentFont = new System.Drawing.Font("Tahoma", 8F);
            popup.Size = new Size(350, 100);
            popup.ImageSize = new Size(70, 80);
            popup.BodyColor = Color.Green;
            popup.Popup();

            popup.BorderColor = System.Drawing.Color.FromArgb(0, 0, 0);

            popup.Delay = 500;
            popup.AnimationInterval = 10;
            popup.AnimationDuration = 1000;


            popup.ShowOptionsButton = true;


        }



        private void btnDeleteTool_Click(object sender, EventArgs e)
        {
            //START
            if (dgvUnits.Rows.Count > 0)
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to delete the ChildForm Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {





                    mode = "delete";

                    //if (this.saveMode())
                    //{
                    //    this.DeletedSuccessfully();
                    //    this.displayDepartmentUnits();

                    //    this.btnCancelTool_Click("", e);
                    //}
                }

                else
                {
                    return;
                }






            }



            //END
        }

        private void metroComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //sp_department_id = cbodepartment.SelectedValue.ToString();
            //if(mode =="add")
            //{
            //    doSearchInTextBoxCmb();
            //}
        
        }

        private void dgvUnits_CurrentCellChanged_1(object sender, EventArgs e)
        {
            showValue();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.mode = "add";
            this.btn_visible(false);

            AddNewDepartmentUnit addNew = new AddNewDepartmentUnit(this,
            userinfo.user_id,
            "Add", this.DeptUnit.Unit_Id, this.DeptUnit.Department, this.DeptUnit.Unit_Description
            );
            addNew.ShowDialog();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
                AddNewDepartmentUnit addNew = new AddNewDepartmentUnit(this,
                userinfo.user_id,
                "Edit", this.DeptUnit.Unit_Id, this.DeptUnit.Department, this.DeptUnit.Unit_Description
                );
                addNew.ShowDialog();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            mode = "";
    
            btn_visible(true);
            dgvUnits_CurrentCellChanged(sender, e);

            DisplayDepartmentUnits();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //START


            if (dgvUnits.Rows.Count > 0)
            {
                if (this.matRadioActive.Checked == true)
                {

                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to deactivate?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                        mode = "delete";

                        dSet_temp.Clear();
                        dSet_temp = g_objStoredProcCollection.sp_DepartmentUnit(this.DeptUnit.Unit_Id, "", "", "", "", "", "", "delete");
                        this.GlobalStatePopup.InactiveSuccessfully();
                        this.frmDepartmentUnit_Load(sender, e);
                    }

                    else
                    {
                        return;
                    }
                }
                else
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to activate?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {

                        mode = "activate";

                        dSet_temp.Clear();
                        dSet_temp = g_objStoredProcCollection.sp_DepartmentUnit(this.DeptUnit.Unit_Id,
                            "", "", "", "", "", "", "activate");
                        this.GlobalStatePopup.ActivatedSuccessfully();
                        this.frmDepartmentUnit_Load(sender, e);
                    }

                    else
                    {
                        return;
                    }

                }
            }

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            //dSet.Clear();
            //dSet = g_objStoredProcCollection.sp_DepartmentUnit(0, TxtDepartmentUnit.Text, "", "", "", "", "", "getbyname");

            //if (dSet.Tables[0].Rows.Count > 0)
            //{
            //    SectionAlreadyExist();


            //    TxtDepartmentUnit.Focus();
            //    return;
            //}
            //else
            //{
            //    metroSave_Click(sender, e);
            //}



        }

        private void txtsection_TextChanged(object sender, EventArgs e)
        {


        }

        private void mattxtSearch_TextChanged(object sender, EventArgs e)
        {
            if(mattxtSearch.Text == "")
            {
                DisplayDepartmentUnits();
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

        private void txtsection_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void dgvUnits_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check the value of the e.ColumnIndex property if you want to apply this formatting only so some rcolumns.
            if (e.Value != null)
            {
                e.Value = e.Value.ToString().ToUpper();
                e.FormattingApplied = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.toolStripButton1_Click(sender, e);
            this.frmDepartmentUnit_Load(sender, e);
        }

        private void matRadioActive_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matRadioActive.Checked == true)
            {
                this.btnDeleteTool.Text = "&InActive";
                this.ConnectionInit();
                this.DisplayDepartmentUnits();
            }
            else
            {
                this.ConnectionInit();
                this.DisplayDepartmentUnitsInactive();
            }
        }

        private void matRadioNotActive_CheckedChanged(object sender, EventArgs e)
        {
            if (this.matRadioActive.Checked == true)
            {
                this.ConnectionInit();
                this.DisplayDepartmentUnits();
            }
            else
            {
                this.btnDeleteTool.Text = "&Activate";
                this.ConnectionInit();
                this.DisplayDepartmentUnitsInactive();
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            this.SearchMethodJarVarCallingSP();
            this.doSearchInTextBoxCmb();
        }
    }
}
