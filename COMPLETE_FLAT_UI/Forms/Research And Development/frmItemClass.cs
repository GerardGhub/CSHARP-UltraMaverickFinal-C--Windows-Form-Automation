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
using ULTRAMAVERICK.Models;
using ULTRAMAVERICK.Properties;

namespace ULTRAMAVERICK.Forms.Research_And_Development
{
    public partial class frmItemClass : MaterialForm
    {
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;
        IStoredProcedures g_objStoredProcCollection = null;
        myclasses myClass = new myclasses();
        DataSet dSet = new DataSet();

        string mode = "";
        int p_id = 0;
        int temp_hid = 0;
        DateTime dNow = DateTime.Now;
        Boolean ready = false;


        DataSet dSet_temp = new DataSet();

        public frmItemClass()
        {
            InitializeComponent();
        }
        public string sp_created_at { get; set; }
        public string sp_created_by { get; set; }
        public string sp_modified_at { get; set; }
        public string sp_modified_by { get; set; }
        public string sp_bind_selected { get; set; }
        private void frmItemClass_Load(object sender, EventArgs e)
        {
            this.ShowDataActivated();
            this.ConnetionString();
            myglobal.global_module = "Active"; // Mode for Searching
            this.showItemClassData();
            this.SearchMethodJarVarCallingSP();
        }
        private void ConnetionString()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
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


            dset_emp_SearchEngines = objStorProc.sp_getMajorTables("Item_Class_Major");
            //this.dgvitemClass.Columns["item_class_id"].Visible = false;
        }

        private void SearchMethodJarVarCallingSPInactive()
        {
            myglobal.global_module = "Active"; // Mode for Searching
            dset_emp_SearchEngines.Clear();


            dset_emp_SearchEngines = objStorProc.sp_getMajorTables("Item_Class_Major_Inactive");
            //this.dgvitemClass.Columns["item_class_id"].Visible = false;
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
                ready = false;
                xClass.fillDataGridView(dgvitemClass, "Item_Class", dSet);
                ready = true;
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
                ready = false;
                xClass.fillDataGridView(dgvitemClass, "Item_Class_InActive", dSet);
                ready = true;
                lbltotalrecords.Text = dgvitemClass.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void matBtnNew_Click(object sender, EventArgs e)
        {
            mode = "add";
            matBtnEdit.Visible = false;
            matBtnCancel.Visible = true;
            txtmatItemClass.Enabled = true;
            matBtnNew.Visible = false;
            txtmatItemClass.Text = String.Empty;
           sp_modified_at = String.Empty;
            sp_modified_by = String.Empty;
      
           sp_created_at = (dNow.ToString("M/d/yyyy"));
            sp_created_by = userinfo.emp_name.ToUpper();
            //txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            matBtnSave.Visible = true;
            txtmatItemClass.Select();
            txtmatItemClass.Focus();
        }

        private void matBtnCancel_Click(object sender, EventArgs e)
        {
            matBtnCancel.Visible = false;
            mode = "";
            sp_created_at = String.Empty;
           sp_created_by = String.Empty;
            matBtnEdit.Visible = true;
            matBtnSave.Visible = false;
            matBtnNew.Visible = true;
            matBtnDelete.Visible = true;
            txtmatItemClass.Enabled = false;
        }

        private void matBtnEdit_Click(object sender, EventArgs e)
        {
            mode = "edit";
            sp_modified_at = (dNow.ToString("M/d/yyyy"));
           sp_modified_by = userinfo.emp_name.ToUpper();
            matBtnDelete.Visible = false;
            matBtnCancel.Visible = true;
            matBtnNew.Visible = false;
            matBtnEdit.Visible = false;
            matBtnSave.Visible = true;
            txtmatItemClass.Enabled = true;
            txtmatItemClass.Focus();
        }

        private void dgvitemClass_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvitemClass.Rows.Count > 0)
            {
                if (dgvitemClass.CurrentRow != null)
                {
                    if (dgvitemClass.CurrentRow.Cells["item_class_desc"].Value != null)
                    {
                        p_id = Convert.ToInt32(dgvitemClass.CurrentRow.Cells["item_class_id"].Value);
                        txtmatItemClass.Text = dgvitemClass.CurrentRow.Cells["item_class_desc"].Value.ToString();
                    
                    }
                }
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


        public void ItemClassAlreadyExist()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Data Already Exist!";
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
        private void matBtnSave_Click(object sender, EventArgs e)
        {
            dSet.Clear();
            dSet = objStorProc.sp_Item_Class(0, txtmatItemClass.Text, "", "", "", "", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                ItemClassAlreadyExist();


                txtmatItemClass.Focus();
                return;
            }
            else
            {
                metroSave_Click(sender, e);
            }
        }


        private void UpdateNotifications()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Successfully Save";
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
            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to update the  Item Class Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {

           

                if (txtmatItemClass.Text.Trim() == string.Empty)
                {

                    this.FillRequiredFields();
                    this.txtmatItemClass.Focus();
                    return;
                }

                else
                {
                    if (saveMode())
                    {
                      
                        string tmode = mode;

                        if (tmode == "add")
                        {
                            dgvitemClass.CurrentCell = dgvitemClass[0, dgvitemClass.Rows.Count - 1];
                            this.UpdateNotifications();
                        }
                        else
                        {
                            dgvitemClass.CurrentCell = dgvitemClass[0, temp_hid];

                        }
                        this.matBtnCancel_Click(sender, e);
                        this.UpdateNotifications();
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
                dSet = objStorProc.sp_Item_Class(0, txtmatItemClass.Text, "", "", "", "", "getbyname");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    ItemClassAlreadyExist();

                    txtmatItemClass.Text = string.Empty;
                    txtmatItemClass.Focus();
                    return false;
                }
                else
                {

                    dSet.Clear();
                    dSet = objStorProc.sp_Item_Class(0, txtmatItemClass.Text.Trim(),
                       
                        sp_created_by,
                        sp_created_at,
                        sp_modified_at,
                        sp_modified_by, "add");

                    this.showItemClassData();
         

                    return true;
                }
            }
            else if (mode == "edit")
            {
                dSet.Clear();
                dSet = objStorProc.sp_Item_Class(0, txtmatItemClass.Text, "", "", "", "", "getbyname");

                dSet_temp.Clear();
                dSet_temp = objStorProc.sp_Item_Class(p_id, txtmatItemClass.Text, "", "", "", "", "getbyid");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    int tmpID = Convert.ToInt32(dSet.Tables[0].Rows[0][0].ToString());
                    if (tmpID == p_id)
                    {
                        dSet.Clear();
                        dSet = objStorProc.sp_Item_Class(p_id, txtmatItemClass.Text.Trim(),
                           
                            sp_created_by,
                            sp_created_at,
                           sp_modified_at,
                            sp_modified_by, "edit");
                        UpdateNotifications();
                        showItemClassData();
                        mode = "";
                        matBtnCancel_Click(new object(), new System.EventArgs());
                        return true;
                    }
                    else
                    {
                        //ItemClassAlreadyExist();
                        txtmatItemClass.Text = String.Empty;
                        txtmatItemClass.Focus();
                        return false;
                    }
                }
                else
                {
                    dSet.Clear();
                    dSet = objStorProc.sp_Item_Class(p_id, txtmatItemClass.Text.Trim(),

                          sp_created_by,
                          sp_created_at,
                         sp_modified_at,
                          sp_modified_by, "edit");
                    UpdateNotifications();
                    showItemClassData();
                    mode = "";
                    matBtnCancel_Click(new object(), new System.EventArgs());
                }
            }
            else if (mode == "delete")
            {

                if (this.sp_bind_selected == "1")
                {

                    dSet_temp.Clear();
                    dSet_temp = objStorProc.sp_Item_Class(p_id, txtmatItemClass.Text, "", "", "", "", "delete");
                   
                    return true;
                }
                else
                {
                    dSet_temp.Clear();
                    dSet_temp = objStorProc.sp_Item_Class(p_id, txtmatItemClass.Text, "", "", "", "", "delete_activation");
                    this.matRadioActive.Checked = true;
                    return true;
                }
            }
            return false;
        }





        private void metroFinalSaving_Click(object sender, EventArgs e)
        {


            if (txtmatItemClass.Text.Trim() == string.Empty)
            {
                FillRequiredFields();
                txtmatItemClass.Focus();
            }
            else
            {
                if (saveMode())
                {
                    ItemClassAlreadyExist();
                    string tmode = mode;

                    if (tmode == "add")
                    {
                        dgvitemClass.CurrentCell = dgvitemClass[0, dgvitemClass.Rows.Count - 1];

                    }
                    else
                    {
                        dgvitemClass.CurrentCell = dgvitemClass[0, temp_hid];
                    }
                    matBtnCancel_Click(sender, e);
                }
                else

                    return;
            }
        }

        private void dgvitemClass_CurrentCellChanged_1(object sender, EventArgs e)
        {
            if (dgvitemClass.Rows.Count > 0)
            {
                if (dgvitemClass.CurrentRow != null)
                {
                    if (dgvitemClass.CurrentRow.Cells["item_class_desc"].Value != null)
                    {
                        p_id = Convert.ToInt32(dgvitemClass.CurrentRow.Cells["item_class_id"].Value);
                        txtmatItemClass.Text = dgvitemClass.CurrentRow.Cells["item_class_desc"].Value.ToString();
                        sp_created_by = dgvitemClass.CurrentRow.Cells["item_added_by"].Value.ToString();
                       sp_created_at = dgvitemClass.CurrentRow.Cells["item_added_at"].Value.ToString();
                       sp_modified_at = dgvitemClass.CurrentRow.Cells["item_updated_at"].Value.ToString();
                        sp_modified_by = dgvitemClass.CurrentRow.Cells["item_updated_by"].Value.ToString();
                    }
                }
            }

        }
        public void InactiveSuccessfully()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Successfully Inactive";
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

        public void ActivatedSuccessfully()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Successfully Activated";
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
        private void btnAddTool_Click(object sender, EventArgs e)
        {
            mode = "add";
            matBtnEdit.Visible = false;
            matBtnCancel.Visible = true;
            txtmatItemClass.Enabled = true;
            matBtnNew.Visible = false;
            txtmatItemClass.Text = String.Empty;
            sp_modified_at = String.Empty;
            sp_modified_by = String.Empty;
            matBtnDelete.Visible = false;
            sp_created_at = (dNow.ToString("M/d/yyyy"));
            sp_created_by = userinfo.emp_name.ToUpper();
            //txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            matBtnSave.Visible = true;
            txtmatItemClass.Select();
            txtmatItemClass.Focus();
        }

        private void btnCancelTool_Click(object sender, EventArgs e)
        {
            matBtnCancel.Visible = false;
            mode = "";
            sp_created_at = String.Empty;
            sp_created_by= String.Empty;
            matBtnEdit.Visible = true;
            matBtnSave.Visible = false;
            matBtnNew.Visible = true;
            matBtnDelete.Visible = true;
            txtmatItemClass.Enabled = false;
        }

        private void btnEditTool_Click(object sender, EventArgs e)
        {
            mode = "edit";
           sp_modified_at = (dNow.ToString("M/d/yyyy"));
            sp_modified_by = userinfo.emp_name.ToUpper();
            matBtnDelete.Visible = false;
            matBtnCancel.Visible = true;
            matBtnNew.Visible = false;
            matBtnEdit.Visible = false;
            matBtnSave.Visible = true;
            txtmatItemClass.Enabled = true;
            txtmatItemClass.Focus();
        }

        private void btnDeleteTool_Click(object sender, EventArgs e)
        {
            if (this.sp_bind_selected == "1")
            {

                if (dgvitemClass.Rows.Count > 0)
                {

                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you  to inactive the Item Class", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {





                        mode = "delete";

                        if (saveMode())
                        {
                            InactiveSuccessfully();
                            showItemClassData();

                            matBtnCancel_Click("", e);
                        }
                    }

                    else
                    {
                        return;
                    }






                }

            }
            else
            {
                if (dgvitemClass.Rows.Count > 0)
                {

                    if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you  to activate the Item Class", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {





                        this.mode = "delete";

                        if (this.saveMode())
                        {
                            this.ActivatedSuccessfully();
                            this.showItemClassData();

                            this.matBtnCancel_Click("", e);

                        }
                    }

                    else
                    {
                        return;
                    }






                }
            }
        }

        private void btnUpdateTool_Click(object sender, EventArgs e)
        {
            dSet.Clear();
            dSet = objStorProc.sp_Item_Class(0, txtmatItemClass.Text, "", "", "", "", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                ItemClassAlreadyExist();


                txtmatItemClass.Focus();
                return;
            }
            else
            {
                metroSave_Click(sender, e);
            }
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
                this.sp_bind_selected = "1";
                this.matBtnDelete.Text = "&InActive";

                this.showItemClassData();
                this.SearchMethodJarVarCallingSP();
            }
            else if (matRadioNotActive.Checked == true)
            {
                this.sp_bind_selected = "0";
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
                this.sp_bind_selected = "1";
                this.matBtnDelete.Text = "&InActive";
     
                this.showItemClassData();
                //this.SearchMethodJarVarCallingSP();
            }
            else if (matRadioNotActive.Checked == true)
            {
                this.sp_bind_selected = "0";
                this.matBtnDelete.Text = "&Activate";
                this.showItemClassDataInActive();
                //this.SearchMethodJarVarCallingSP();
            }
            else
            {

            }
        }

        private void mattxtSearch_TextChanged_1(object sender, EventArgs e)
        {
            this.ConnetionString();
            if(sp_bind_selected == "1")
            {
                this.SearchMethodJarVarCallingSP();
            }
            else
            {
                this.SearchMethodJarVarCallingSPInactive();
            }

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
    }
}
