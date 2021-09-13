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
    public partial class frmTypeofApprover : MaterialForm
    {
        myclasses xClass = new myclasses();
        IStoredProcedures objStorProc = null;

        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        myglobal pointer_module = new myglobal();
        DateTime dNow = DateTime.Now;
        string mode = "";
        DataSet dSet = new DataSet();
        Boolean ready = false;
        int temp_id = 0;
        DataSet dSet_temp = new DataSet();
        public frmTypeofApprover()
        {
            InitializeComponent();
        }

        private void frmTypeofApprover_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class

            myglobal.global_module = "Active"; // Mode for Searching

            load_search(); //Bind the Information
            getAllApproverSets(); // all Type of Approver

        }

        private void getAllApproverSets()
        {
            ready = false;
            myClass.fillListBox(lstTypeofApprovers, "TypeofApprover", dSet);
            ready = true;
            lbltotalrecords.Text = lstTypeofApprovers.Items.Count.ToString();
        }


        private void btnCancelTool_Click(object sender, EventArgs e)
        {
            lstTypeofApprovers.Enabled = true;
            btnCancelTool.Visible = false;
            btnAddTool.Visible = true;
            txtnewusertype.Enabled = false;
            btnUpdateTool.Visible = false;
            btnEditTool.Visible = true;
            btnDeleteTool.Visible = true;
        
        }

        private void btnUpdateTool_Click(object sender, EventArgs e)
        {
            metroButtonSave_Click(sender, e);
        }


        public void FillRequiredTextbox()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "FILL UP THE REQUIRED FIELDS";
            popup.ContentColor = Color.Black;
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


        public void SaveSuccessfully()
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

        public void TypeofApproverAlreadyTaken()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Type of Approver Already Exist!";
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


        public bool saveMode()
        {
            if (mode == "add")
            {
                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_TypeofApprover(0,
                    txtnewusertype.Text.Trim(), "", "", "", "", "validate");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    TypeofApproverAlreadyTaken();
                    txtnewusertype.Focus();
                    return false;
                }
                else
                {
                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_TypeofApprover(0,
                    txtnewusertype.Text.Trim(),
                    txtCreatedAt.Text.Trim(),
                    txtCreatedBy.Text.Trim(),
                    txtModifiedAt.Text.Trim(),
                    txtModifiedBy.Text.Trim(),
        
                    "add");

                    return true;
                }

            }

            else if (mode == "edit")
            {
                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_TypeofApprover(temp_id,
                    txtnewusertype.Text.Trim(), "",
                    txtCreatedByAndUserID.Text.Trim(), "", "", "getbyname");

                dSet_temp.Clear();
                dSet_temp = g_objStoredProcCollection.sp_TypeofApprover(temp_id, txtnewusertype.Text.Trim(),  "", "", "", "", "getbyid");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    int tmpID = Convert.ToInt32(dSet.Tables[0].Rows[0][0].ToString());
                    if (tmpID == temp_id)
                    {
                        dSet.Clear();
                        dSet = g_objStoredProcCollection.sp_TypeofApprover(temp_id,
                            txtnewusertype.Text.Trim(),
                            txtCreatedAt.Text.Trim(),
                            txtCreatedBy.Text.Trim(),
                            txtModifiedAt.Text.Trim(),
                            txtModifiedBy.Text.Trim(),
                          
                            "edit");

                        return true;
                    }
                    else
                    {
                        TypeofApproverAlreadyTaken();
                        txtnewusertype.Focus();
                        return false;
                    }
                }
                else
                {
                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_TypeofApprover(temp_id,
                        txtnewusertype.Text.Trim(),
                        txtCreatedAt.Text.Trim(),
                        txtCreatedBy.Text.Trim(),
                        txtModifiedAt.Text.Trim(),
                        txtModifiedBy.Text.Trim(),
              
                        "edit");

                    return true;
                }
            }
            else if (mode == "delete")
            {
                dSet.Clear();


                dSet_temp.Clear();
                dSet_temp = g_objStoredProcCollection.sp_TypeofApprover(temp_id, "", "", "", "", "", "delete");

                return true;
            }

            return false;
        }


        private void metroButtonSave_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to Save the New Type of User " + txtnewusertype.Text + "", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (txtnewusertype.Text.Trim() == "")
                {


                    FillRequiredTextbox();
                    txtnewusertype.BackColor = Color.Yellow;
                    txtnewusertype.Focus();
                    return;
                }



                else
                {
                    if (saveMode())
                    {
                        getAllApproverSets();
                        if (lstTypeofApprovers.Items.Count > 0)
                        {
                            int index = lstTypeofApprovers.FindString(txtModifiedAt.Text, 0);
                            if (index == -1) { index = 0; }
                            lstTypeofApprovers.SelectedIndex = index;
                        }

                        mode = "";
                        SaveSuccessfully();
                       frmTypeofApprover_Load(sender, e);
                        btnUpdateTool.Visible = false;
                        btnAddTool.Visible = true;
                        btnCancelTool.Visible = false;
                        lstTypeofApprovers.Enabled = true;
                        btnEditTool.Visible = true;
                        btnDeleteTool.Visible = true;

                        lstTypeofApprovers_Click(sender, e);
                    }
                }

                txtnewusertype.Enabled = false;

            }
            else
            {

                return;
            }
        }

        private void lstTypeofApprovers_Click(object sender, EventArgs e)
        {
            doSearch();
            showvalue();
        }

        private void showvalue()
        {
            if (ready == true)
            {
                if (lstTypeofApprovers.Items.Count > 0)
                {
                    temp_id = Convert.ToInt32(lstTypeofApprovers.SelectedValue.ToString());
                    txtnewusertype.Text = lstTypeofApprovers.Text;
                }

            }
        }


        DataSet dset_emp = new DataSet();
        void doSearch()
        {
            try
            {
                if (dset_emp.Tables.Count > 0)
                {
                    DataView dv = new DataView(dset_emp.Tables[0]);
                    if (myglobal.global_module == "EMPLOYEE")
                    {

                    }
                    else if (myglobal.global_module == "Active")
                    {

                        dv.RowFilter = "type_of_approver like '%" + txtnewusertype.Text + "%'";

                    }
                    else if (myglobal.global_module == "VISITORS")
                    {

                    }
                    dgv_table.DataSource = dv;
                    //lblrecords.Text = dgv_table.RowCount.ToString();
                }
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Invalid character found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnewusertype.Focus();
                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnewusertype.Focus();
                return;
            }
        }
        public void load_search()
        {
            dset_emp.Clear();

            if (myglobal.global_module == "EMPLOYEE")
            { dset_emp = objStorProc.sp_getMajorTables("employee"); }
            else if (myglobal.global_module == "MICRO")
            { dset_emp = objStorProc.sp_getMajorTables("micro_raw_materialsnew"); }
            else if (myglobal.global_module == "Active")
            { dset_emp = objStorProc.sp_getMajorTables("TypeofApprovercurrentcellchanged"); }
            else if (myglobal.global_module == "InActive")
            { dset_emp = objStorProc.sp_getMajorTables("InactiveFeedCode"); }
            else if (myglobal.global_module == "MACRO")
            { dset_emp = objStorProc.sp_getMajorTables("macro_raw_materialsnew"); }
            else if (myglobal.global_module == "RESIGNED EMPLOYEE")
            { dset_emp = objStorProc.sp_getMajorTables("employee_B"); }
            else if (myglobal.global_module == "PHONEBOOK")
            { dset_emp = objStorProc.sp_getMajorTables("phonebook"); }
            else if (myglobal.global_module == "DA")
            { dset_emp = objStorProc.sp_getMajorTables("get_da"); }
            else if (myglobal.global_module == "ATTENDANCE")
            { dset_emp = objStorProc.sp_getMajorTables("attendance_monitoring"); }
            else if (myglobal.global_module == "VISITORS")
            { dset_emp = objStorProc.sp_getMajorTables("visitors"); }

            doSearch();

        }

        private void btnEditTool_Click(object sender, EventArgs e)
        {
            lstTypeofApprovers.Enabled = false;

            if (lstTypeofApprovers.Items.Count > 0)
            {
                mode = "edit";
               txtnewusertype.Enabled = true;
                txtnewusertype.ReadOnly = false;





                btnEditTool.Visible = false;
                btnAddTool.Visible = false;
                btnCancelTool.Visible = true;
                btnDeleteTool.Visible = false;
                btnUpdateTool.Visible = true;
           
                txtModifiedAt.Text = (dNow.ToString("M/d/yyyy"));
                txtModifiedBy.Text = userinfo.emp_name.ToUpper();
            }
        }

        private void btnDeleteTool_Click(object sender, EventArgs e)
        {

            metroButtonDelete_Click(sender, e);
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

        private void metroButtonDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to Delete the User Type Information ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (lstTypeofApprovers.Items.Count > 0)
                {

                    mode = "delete";
                    if (saveMode())
                    {
                        getAllApproverSets();
                        if (lstTypeofApprovers.Items.Count > 0)
                        {
                            int index = lstTypeofApprovers.FindString(txtnewusertype.Text, 0);
                            if (index == -1) { index = 0; }
                            lstTypeofApprovers.SelectedIndex = index;
                        }

                        mode = "";
                       lstTypeofApprovers.Enabled = true;
                        DeletedSuccessfully();
                        load_search();
                        doSearch();

                        btnEditTool.Visible = true;
                        lstTypeofApprovers_Click(sender, e);
                    }
                }
                //}

            }
            else
            {

                btnEditTool.Visible = true;
                return;
            }
        }

        private void lstTypeofApprovers_CursorChanged(object sender, EventArgs e)
        {
            doSearch();
            showvalue();
        }

        private void lstTypeofApprovers_SelectedIndexChanged(object sender, EventArgs e)
        {
            doSearch();
            showvalue();
        }

        private void lstTypeofApprovers_SelectedValueChanged(object sender, EventArgs e)
        {
            doSearch();
            showvalue();
        }

        private void dgv_table_CurrentCellChanged(object sender, EventArgs e)
        {
            showTypeofUserDetails();
        }

        private void showTypeofUserDetails()
        {

            if (dgv_table.RowCount > 0)
            {
                if (dgv_table.CurrentRow != null)
                {
                    if (dgv_table.CurrentRow.Cells["type_of_approver"].Value != null)
                    {


                       txtnewusertype.Text = dgv_table.CurrentRow.Cells["type_of_approver"].Value.ToString();
                    
                        txtCreatedBy.Text = dgv_table.CurrentRow.Cells["created_by"].Value.ToString();
                        txtCreatedAt.Text = dgv_table.CurrentRow.Cells["created_at"].Value.ToString();

                        txtModifiedBy.Text = dgv_table.CurrentRow.Cells["updated_by"].Value.ToString();

                        txtModifiedAt.Text = dgv_table.CurrentRow.Cells["updated_at"].Value.ToString();



                    }

                }
            }


        }

        private void BtnModuleClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddTool_Click_1(object sender, EventArgs e)
        {
            mode = "add";
            btnUpdateTool.Visible = true;
            btnAddTool.Visible = false;
            btnDeleteTool.Visible = false;
            lstTypeofApprovers.Enabled = false;

            txtnewusertype.Enabled = true;
            txtnewusertype.Text = string.Empty;
            btnCancelTool.Visible = true;


            txtCreatedAt.Text = (dNow.ToString("M/d/yyyy"));
            txtCreatedBy.Text = userinfo.emp_name.ToUpper();
            txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            btnUpdateTool.Visible = true;
            btnEditTool.Visible = false;
            txtModifiedAt.Text = String.Empty;
            txtModifiedBy.Text = String.Empty;

            txtnewusertype.Focus();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            lstTypeofApprovers.Enabled = false;

            if (lstTypeofApprovers.Items.Count > 0)
            {
                mode = "edit";
                txtnewusertype.Enabled = true;
                txtnewusertype.ReadOnly = false;





                btnEditTool.Visible = false;
                btnAddTool.Visible = false;
                btnCancelTool.Visible = true;
                btnDeleteTool.Visible = false;
                btnUpdateTool.Visible = true;

                txtModifiedAt.Text = (dNow.ToString("M/d/yyyy"));
                txtModifiedBy.Text = userinfo.emp_name.ToUpper();
            }
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            metroButtonSave_Click(sender, e);
        }

        private void materialButton1_Click_2(object sender, EventArgs e)
        {
            lstTypeofApprovers.Enabled = true;
            btnCancelTool.Visible = false;
            btnAddTool.Visible = true;
            txtnewusertype.Enabled = false;
            btnUpdateTool.Visible = false;
            btnEditTool.Visible = true;
            btnDeleteTool.Visible = true;
            btnDeleteTool.Visible = true;
        }

        private void materialButton1_Click_3(object sender, EventArgs e)
        {
            metroButtonDelete_Click(sender, e);
        }

        private void add_Click(object sender, EventArgs e)
        {
            mode = "add";
            btnUpdateTool.Visible = true;
            btnAddTool.Visible = false;
            btnDeleteTool.Visible = false;
            lstTypeofApprovers.Enabled = false;

            txtnewusertype.Enabled = true;
            txtnewusertype.Text = string.Empty;
            btnCancelTool.Visible = true;


            txtCreatedAt.Text = (dNow.ToString("M/d/yyyy"));
            txtCreatedBy.Text = userinfo.emp_name.ToUpper();
            txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            btnUpdateTool.Visible = true;
            btnEditTool.Visible = false;
            txtModifiedAt.Text = String.Empty;
            txtModifiedBy.Text = String.Empty;

            txtnewusertype.Focus();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            lstTypeofApprovers.Enabled = false;

            if (lstTypeofApprovers.Items.Count > 0)
            {
                mode = "edit";
                txtnewusertype.Enabled = true;
                txtnewusertype.ReadOnly = false;





                btnEditTool.Visible = false;
                btnAddTool.Visible = false;
                btnCancelTool.Visible = true;
                btnDeleteTool.Visible = false;
                btnUpdateTool.Visible = true;

                txtModifiedAt.Text = (dNow.ToString("M/d/yyyy"));
                txtModifiedBy.Text = userinfo.emp_name.ToUpper();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            metroButtonSave_Click(sender, e);
        }

        private void remove_Click(object sender, EventArgs e)
        {
            metroButtonDelete_Click(sender, e);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            lstTypeofApprovers.Enabled = true;
            btnCancelTool.Visible = false;
            btnAddTool.Visible = true;
            txtnewusertype.Enabled = false;
            btnUpdateTool.Visible = false;
            btnEditTool.Visible = true;
            btnDeleteTool.Visible = true;
            btnDeleteTool.Visible = true;
        }

        private void lstTypeofApprovers_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            //if the item state is selected them change the back color 
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          e.ForeColor,
                                          Color.Yellow);//Choose the color
           
            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Draw the current item text
            e.Graphics.DrawString(lstTypeofApprovers.Items[e.Index].ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault);
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }
    }
}
