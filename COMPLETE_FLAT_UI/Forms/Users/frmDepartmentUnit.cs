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

namespace ULTRAMAVERICK.Forms.Users
{
    public partial class frmDepartmentUnit : MaterialForm
    {
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;

        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();

        string mode = "";
        int p_id = 0;
        int temp_hid = 0;
        DateTime dNow = DateTime.Now;
        Boolean ready = false;

        IStoredProcedures g_objStoredProcCollection = null;
        DataSet dSet_temp = new DataSet();

        public frmDepartmentUnit()
        {
            InitializeComponent();
        }

        public string sp_department_id { get; set; }
        private void frmDepartmentUnit_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            this.loadDepartment();
            this.SearchMethodJarVarCallingSP();
            this.displayDepartmentUnits();
            
        }

        DataSet dset_emp_SearchEngines = new DataSet();
        private void SearchMethodJarVarCallingSP()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            dset_emp_SearchEngines.Clear();


            dset_emp_SearchEngines = objStorProc.sp_getMajorTables("DepartmentUnitMajor");

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




                        dv.RowFilter = "department = '" + cbodepartment.Text + "'";

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


        private void displayDepartmentUnits()      //method for loading available_menus
        {
            ready = false;
            xClass.fillDataGridView(dgvUnits, "DepartmentUnit", dSet);
            ready = true;
            lbltotalrecords.Text = dgvUnits.RowCount.ToString();
        }


        public void loadDepartment()
        {
            ready = false;
            myClass.fillComboBoxDepartment(cbodepartment, "department_dropdown", dSet);
            ready = true;

           this.sp_department_id = cbodepartment.SelectedValue.ToString();
        }

        private void btnAddTool_Click(object sender, EventArgs e)
        {
            this.mode = "add";
            this.btn_visible(false);
            this.txt_read_only(false);

            this.txtsection.Enabled = true;
            this.cbodepartment.Text = String.Empty;
            this.txtModifiedAt.Text = String.Empty;
            this.txtModifiedBy.Text = String.Empty;
            this.cbodepartment.Enabled = true;
            this.sp_department_id = cbodepartment.SelectedValue.ToString(); //Binding First Meet
            this.txtCreatedAt.Text = (dNow.ToString("M/d/yyyy"));
            this.txtCreatedBy.Text = userinfo.emp_name.ToUpper();
            this.txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            this.cbodepartment.Select();
            this.cbodepartment.Focus();
        }
        private void btn_visible(Boolean val)
        {
            this.btnAddTool.Visible = val;
            this.btnEditTool.Visible = val;
            this.btnDeleteTool.Visible = val;


            this.btnUpdateTool.Visible = !val;
            this.btnCancelTool.Visible = !val;
        }
        private void txt_read_only(Boolean val)
        {
    
            txtsection.ReadOnly = val;
        

            if (val == false)
            {
                if (mode == "add")
                {
                    txtsection.Text = String.Empty;
               
                  
                    txtsection.Focus();
                }
                else
                {
                    txtsection.Focus();
                }
            }

        }

        private void btnCancelTool_Click(object sender, EventArgs e)
        {
            mode = "";
            txt_read_only(true);
            btn_visible(true);
            dgvUnits_CurrentCellChanged(sender, e);
            txtsection.Enabled = false;
         
            cbodepartment.Enabled = false;
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
                        p_id = Convert.ToInt32(dgvUnits.CurrentRow.Cells["unit_id"].Value);
                        txtsection.Text = dgvUnits.CurrentRow.Cells["unit_description"].Value.ToString();
                        cbodepartment.Text = dgvUnits.CurrentRow.Cells["department"].Value.ToString();
                        txtModifiedAt.Text = dgvUnits.CurrentRow.Cells["updated_at"].Value.ToString();
                        txtModifiedBy.Text = dgvUnits.CurrentRow.Cells["updated_by"].Value.ToString();
                        txtCreatedAt.Text = dgvUnits.CurrentRow.Cells["created_at"].Value.ToString();
                        txtCreatedBy.Text = dgvUnits.CurrentRow.Cells["created_by"].Value.ToString();
  
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

            dSet.Clear();
            dSet = objStorProc.sp_DepartmentUnit(0, txtsection.Text, "", "", "", "", "", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                SectionAlreadyExist();


                txtsection.Focus();
                return;
            }
            else
            {
                metroSave_Click(sender, e);
            }


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
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to update the Department Section", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

                if (cbodepartment.Text.Trim() == string.Empty)
                {
                    FillRequiredFields();
                    cbodepartment.Focus();


                    return;
                }


                if (txtsection.Text.Trim() == string.Empty)
                {
                    FillRequiredFields();
                    txtsection.Focus();


                    return;
                }

      

                else
                {
                    if (saveMode())
                    {
                        displayDepartmentUnits();
                        string tmode = mode;

                        if (tmode == "add")
                        {
                            dgvUnits.CurrentCell = dgvUnits[0, dgvUnits.Rows.Count - 1];
                            UpdateNotifications();
                        }
                        else
                        {
                            dgvUnits.CurrentCell = dgvUnits[0, temp_hid];

                        }
                        btnCancelTool_Click(sender, e);
                        UpdateNotifications();
                    }
                    else

                        metroFinalSaving_Click(sender, e);
                    return;
                }
            }

            else
            {
                return;
            }

        }


        public bool saveMode()      //method for saving of data base on mode (add,edit,delete)
        {

            if (mode == "add")
            {
                dSet.Clear();
                dSet = objStorProc.sp_DepartmentUnit(0, txtsection.Text, "", "", "", "", "", "getbyname");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    SectionAlreadyExist();

                    txtsection.Text = string.Empty;
                    txtsection.Focus();
                    return false;
                }
                else
                {
                    dSet.Clear();
                    dSet = objStorProc.sp_DepartmentUnit(0, 
                        txtsection.Text.Trim(),
                        sp_department_id,             
                        txtModifiedAt.Text.Trim(),
                        txtModifiedBy.Text.Trim(),
                        txtCreatedAt.Text.Trim(),
                        txtCreatedBy.Text.Trim(),
                        "add");

                    return true;
                }
            }
            else if (mode == "edit")
            {
                dSet.Clear();
                dSet = objStorProc.sp_DepartmentUnit(0, txtsection.Text, "", "", "", "", "", "getbyname");

                dSet_temp.Clear();
                dSet_temp = objStorProc.sp_DepartmentUnit(p_id, txtsection.Text, "", "", "", "", "", "getbyid");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    int tmpID = Convert.ToInt32(dSet.Tables[0].Rows[0][0].ToString());
                    if (tmpID == p_id)
                    {
                        dSet.Clear();
                        dSet = objStorProc.sp_DepartmentUnit(p_id, 
                            txtsection.Text.Trim(),
                            sp_department_id,
                            txtModifiedAt.Text.Trim(),
                            txtModifiedBy.Text.Trim(),
                            txtCreatedAt.Text.Trim(),
                            txtCreatedBy.Text.Trim(),
                             "edit");
                        UpdateNotifications();

                        return true;
                    }
                    else
                    {
                        SectionAlreadyExist();
                        txtsection.Text = String.Empty;
                        txtsection.Focus();
                        return false;
                    }
                }
                else
                {
                    dSet.Clear();
                    dSet = objStorProc.sp_DepartmentUnit(p_id,
                        txtsection.Text.Trim(),
                        sp_department_id,
                        txtModifiedAt.Text.Trim(),
                        txtModifiedBy.Text.Trim(),
                        txtCreatedAt.Text.Trim(),
                        txtCreatedBy.Text.Trim(),
                         "edit");


                }
            }
            else if (mode == "delete")
            {

                dSet_temp.Clear();
                dSet_temp = objStorProc.sp_DepartmentUnit(p_id, txtsection.Text, "", "", "", "", "", "delete");

                return true;
            }
            return false;
        }


        private void metroFinalSaving_Click(object sender, EventArgs e)
        {
            if (cbodepartment.Text.Trim() == string.Empty)
            {
                FillRequiredFields();
                cbodepartment.Focus();
                return;
            }

            if (txtsection.Text.Trim() == string.Empty)
            {
                this.FillRequiredFields();
                this.txtsection.Focus();
            }
            else
            {
                if (this.saveMode())
                {
                    this.displayDepartmentUnits();
                    string tmode = mode;

                    if (tmode == "add")
                    {
                        dgvUnits.CurrentCell = dgvUnits[0, dgvUnits.Rows.Count - 1];
                    }
                    else
                    {
                        dgvUnits.CurrentCell = dgvUnits[0, temp_hid];
                    }
                    btnCancelTool_Click(sender, e);
                }
                else

                    return;
            }
        }

        private void cbodepartment_SelectedValueChanged(object sender, EventArgs e)
        {

           sp_department_id= cbodepartment.SelectedValue.ToString();
        }

        private void BtnModuleClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditTool_Click(object sender, EventArgs e)
        {
            txtModifiedAt.Text = (dNow.ToString("M/d/yyyy"));
            txtModifiedBy.Text = userinfo.emp_name.ToUpper();
            if (dgvUnits.RowCount > 0)
            {
                temp_hid = dgvUnits.CurrentRow.Index;
                cbodepartment.Enabled = true;
                txtsection.Enabled = true;
               
            
                mode = "edit";

                btn_visible(false);
                txt_read_only(false);
            }



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

                    if (this.saveMode())
                    {
                        this.DeletedSuccessfully();
                        this.displayDepartmentUnits();

                        this.btnCancelTool_Click("", e);
                    }
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
            sp_department_id = cbodepartment.SelectedValue.ToString();
            if(mode =="add")
            {
                doSearchInTextBoxCmb();
            }
        
        }

        private void dgvUnits_CurrentCellChanged_1(object sender, EventArgs e)
        {
            showValue();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.mode = "add";
            this.btn_visible(false);
            this.txt_read_only(false);

            this.txtsection.Enabled = true;
            this.cbodepartment.Text = String.Empty;
            this.txtModifiedAt.Text = String.Empty;
            this.txtModifiedBy.Text = String.Empty;
            this.cbodepartment.Enabled = true;
            this.sp_department_id = cbodepartment.SelectedValue.ToString(); //Binding First Meet
            this.txtCreatedAt.Text = (dNow.ToString("M/d/yyyy"));
            this.txtCreatedBy.Text = userinfo.emp_name.ToUpper();
            this.txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            this.cbodepartment.Select();
            this.cbodepartment.Focus();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            txtModifiedAt.Text = (dNow.ToString("M/d/yyyy"));
            txtModifiedBy.Text = userinfo.emp_name.ToUpper();
            if (dgvUnits.RowCount > 0)
            {
                temp_hid = dgvUnits.CurrentRow.Index;
                cbodepartment.Enabled = true;
                txtsection.Enabled = true;


                mode = "edit";

                btn_visible(false);
                txt_read_only(false);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            mode = "";
            txt_read_only(true);
            btn_visible(true);
            dgvUnits_CurrentCellChanged(sender, e);
            txtsection.Enabled = false;

            cbodepartment.Enabled = false;
            displayDepartmentUnits();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //START
            if (dgvUnits.Rows.Count > 0)
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to delete the ChildForm Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {





                    mode = "delete";

                    if (saveMode())
                    {
                        DeletedSuccessfully();
                        displayDepartmentUnits();

                        btnCancelTool_Click("", e);
                    }
                }

                else
                {
                    return;
                }






            }



            //END
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            dSet.Clear();
            dSet = objStorProc.sp_DepartmentUnit(0, txtsection.Text, "", "", "", "", "", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                SectionAlreadyExist();


                txtsection.Focus();
                return;
            }
            else
            {
                metroSave_Click(sender, e);
            }
        }

        private void txtsection_TextChanged(object sender, EventArgs e)
        {


        }

        private void mattxtSearch_TextChanged(object sender, EventArgs e)
        {
            if(mattxtSearch.Text == "")
            {
                displayDepartmentUnits();
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
    }
}
