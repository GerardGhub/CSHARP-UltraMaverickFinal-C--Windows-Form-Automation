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
using ULTRAMAVERICK.API.Entities;
using ULTRAMAVERICK.Forms.Users.Modal;

namespace ULTRAMAVERICK.Forms.Users
{
    public partial class frmPosition : MaterialForm
    {

        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        myglobal pointer_module = new myglobal();
        DateTime dNow = DateTime.Now;
        string mode = "";
        DataSet dSet = new DataSet();
        Boolean ready = false;
        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        int temp_id = 0;
        DataSet dSet_temp = new DataSet();
        Position PositionEntity = new Position();
        public frmPosition()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPosition_Load(object sender, EventArgs e)
        {

            this.ConnectionInit();

            getAllPosition(); // all UserFile Management
            lstPosition_Click(sender, e); // Click Thge ListView
            myglobal.global_module = "Active"; // Mode for Searching
            load_search(); //Bind the Information
            HideDataGrid(); // Hide the DataGrid
            loadDepartment(); // Loading the Depeartment
            this.textBox1.Text = String.Empty;

        }

        private void ConnectionInit()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }


        public void loadDepartment()
        {
            this.myClass.fillComboBoxDepartment(cbodepartment, "department_dropdown", dSet);
            this.lblDepartmentID.Text = cbodepartment.SelectedValue.ToString();
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

                        dv.RowFilter = "position_name like '%" + txtname.Text + "%'";

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
                txtname.Focus();
                return;
            }
            catch (EvaluateException)
            {
                MessageBox.Show("Invalid character found 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtname.Focus();
                return;
            }
        }
        public void load_search()
        {
            dset_emp.Clear();

            if (myglobal.global_module == "EMPLOYEE")
            { dset_emp = g_objStoredProcCollection.sp_getMajorTables("employee"); }
            else if (myglobal.global_module == "MICRO")
            { dset_emp = g_objStoredProcCollection.sp_getMajorTables("micro_raw_materialsnew"); }
            else if (myglobal.global_module == "Active")
            { dset_emp = g_objStoredProcCollection.sp_getMajorTables("positioncurrentcellchanged"); }
            else if (myglobal.global_module == "InActive")
            { dset_emp = g_objStoredProcCollection.sp_getMajorTables("InactiveFeedCode"); }
            else if (myglobal.global_module == "MACRO")
            { dset_emp = g_objStoredProcCollection.sp_getMajorTables("macro_raw_materialsnew"); }
            else if (myglobal.global_module == "RESIGNED EMPLOYEE")
            { dset_emp = g_objStoredProcCollection.sp_getMajorTables("employee_B"); }
            else if (myglobal.global_module == "PHONEBOOK")
            { dset_emp = g_objStoredProcCollection.sp_getMajorTables("phonebook"); }
            else if (myglobal.global_module == "DA")
            { dset_emp = g_objStoredProcCollection.sp_getMajorTables("get_da"); }
            else if (myglobal.global_module == "ATTENDANCE")
            { dset_emp = g_objStoredProcCollection.sp_getMajorTables("attendance_monitoring"); }
            else if (myglobal.global_module == "VISITORS")
            { dset_emp = g_objStoredProcCollection.sp_getMajorTables("visitors"); }

            doSearch();

        }

        public void HideDataGrid()
        {
            dgv_table.Visible = false;
        }
        private void getAllPosition()
        {

            //this.myClass.fillListBox(lstPosition, "position", dSet);
        
            //lbltotalrecords.Text = lstPosition.Items.Count.ToString();

            try
            {

                this.myClass.fillDataGridView(this.DgvPosition, "position", this.dSet);

                this.lbltotalrecords.Text = this.DgvPosition.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }



   
        private void metroButtonSave_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to Save the New Position " + txtname.Text + "", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (txtname.Text.Trim() == "")
                {


                    FillRequiredTextbox();
                    txtname.BackColor = Color.Yellow;
                    txtname.Focus();
                    return;
                }



                else
                {
                    if (saveMode())
                    {
                        getAllPosition();
                        if (lstPosition.Items.Count > 0)
                        {
                            int index = lstPosition.FindString(this.PositionEntity.Modified_Date, 0);
                            if (index == -1) { index = 0; }
                            lstPosition.SelectedIndex = index;
                        }

                        mode = "";
                        SaveSuccessfully();
                        btnUpdateTool.Visible = false;
                        btnAddTool.Visible = true;
                        btnCancelTool.Visible = false;
                        lstPosition.Enabled = true;
                        btnEditTool.Visible = true;
                        btnDeleteTool.Visible = true;
                        cbodepartment.Enabled = false;
                        lstPosition_Click(sender, e);
                    }
                }

                txtname.Enabled = false;

            }
            else
            {

                return;
            }
        }
        public void PositionAlreadyTaken()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Position Already Exist!";
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

        public bool saveMode()
        {
            if (mode == "add")
            {
                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_position(0,
                    txtname.Text.Trim(), "", "", "", "", "", "", "validate");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    PositionAlreadyTaken();
                    txtname.Focus();
                    return false;
                }
                else
                {
                    this.dSet.Clear();
                    this.dSet = g_objStoredProcCollection.sp_position(0,
                    this.txtname.Text.Trim(),
                    this.lblDepartmentID.Text.Trim(),
                    this.PositionEntity.Created_By,
                    this.PositionEntity.Created_At,
                    this.PositionEntity.Modified_Date,
                    this.PositionEntity.Modified_By,
                    this.txtCreatedByAndUserID.Text.Trim(),
                    "add");

                    return true;
                }

            }

            else if (mode == "edit")
            {
                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_position(temp_id,
                    txtname.Text.Trim(), "",
                    txtCreatedByAndUserID.Text.Trim(), "", "", "", "", "getbyname");

                dSet_temp.Clear();
                dSet_temp = g_objStoredProcCollection.sp_position(temp_id, txtname.Text.Trim(), "", "", "", "", "", "", "getbyid");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    int tmpID = Convert.ToInt32(dSet.Tables[0].Rows[0][0].ToString());
                    if (tmpID == temp_id)
                    {
                        dSet.Clear();
                        dSet = g_objStoredProcCollection.sp_position(temp_id,
                            this.txtname.Text.Trim(), 
                            this.lblDepartmentID.Text.Trim(),
                            this.PositionEntity.Created_By,
                            this.PositionEntity.Created_At,
                            this.PositionEntity.Modified_Date,
                            this.PositionEntity.Modified_By,
                            this.txtCreatedByAndUserID.Text.Trim(), "edit");

                        return true;
                    }
                    else
                    {
                        PositionAlreadyTaken();
                        txtname.Focus();
                        return false;
                    }
                }
                else
                {
                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_position(temp_id,
                        this.txtname.Text.Trim(), 
                        this.lblDepartmentID.Text.Trim(),
                        this.PositionEntity.Created_By,
                        this.PositionEntity.Created_At,
                        this.PositionEntity.Modified_Date,
                        this.PositionEntity.Modified_By,
                        txtCreatedByAndUserID.Text.Trim(), "edit");
                    return true;
                }
            }
            else if (mode == "delete")
            {
                dSet.Clear();


                dSet_temp.Clear();
                dSet_temp = g_objStoredProcCollection.sp_position(temp_id, "", "", "", "", "", "", "", "delete");

                return true;
            }

            return false;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            metroButtonSave_Click(sender, e);
        }

        private void lstPosition_Click(object sender, EventArgs e)
        {
            doSearch();
            showvalue();
        }
        private void showvalue()
        {
            if (ready == true)
            {
                if (lstPosition.Items.Count > 0)
                {
                    temp_id = Convert.ToInt32(lstPosition.SelectedValue.ToString());
                    txtname.Text = lstPosition.Text;
                }

            }
        }



        private void metroButtonDelete_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to Delete the User Information ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (lstPosition.Items.Count > 0)
                {

                    mode = "delete";
                    if (saveMode())
                    {
                        getAllPosition();
                        if (lstPosition.Items.Count > 0)
                        {
                            int index = lstPosition.FindString(txtname.Text, 0);
                            if (index == -1) { index = 0; }
                            lstPosition.SelectedIndex = index;
                        }

                        mode = "";
                        lstPosition.Enabled = true;
                  
                        this.GlobalStatePopup.InactiveSuccessfully();
                        load_search();
                        doSearch();

                        btnEditTool.Visible = true;
                        lstPosition_Click(sender, e);
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
  


     

        private void lstPosition_CursorChanged(object sender, EventArgs e)
        {
            doSearch();
            showvalue();
        }

        private void lstPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            doSearch();
            showvalue();
        }

        private void lstPosition_SelectedValueChanged(object sender, EventArgs e)
        {
            doSearch();
            showvalue();
        }

        private void dgv_table_CurrentCellChanged(object sender, EventArgs e)
        {
            showPositionDetails();
        }
        public void showPositionDetails()
        {
            if (dgv_table.RowCount > 0)
            {
                if (dgv_table.CurrentRow != null)
                {
                    if (dgv_table.CurrentRow.Cells["position_name"].Value != null)
                    {


                        this.txtname.Text = dgv_table.CurrentRow.Cells["position_name"].Value.ToString();
                        this.cbodepartment.Text = dgv_table.CurrentRow.Cells["department_id"].Value.ToString();
                        this.PositionEntity.Created_By = this.dgv_table.CurrentRow.Cells["created_by"].Value.ToString();
                        this.PositionEntity.Created_At = this.dgv_table.CurrentRow.Cells["created_at"].Value.ToString();
                        this.PositionEntity.Modified_By = this.dgv_table.CurrentRow.Cells["modified_by"].Value.ToString();
                        this.PositionEntity.Modified_Date = this.dgv_table.CurrentRow.Cells["modified_date"].Value.ToString();

                    }

                }
            }
        }



    



     

        private void metroComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.lblDepartmentID.Text = cbodepartment.SelectedValue.ToString();
        }

   
 


        private void cancel_Click(object sender, EventArgs e)
        {
            lstPosition.Enabled = true;
            btnCancelTool.Visible = false;
            btnAddTool.Visible = true;
            txtname.Enabled = false;
            btnUpdateTool.Visible = false;
            btnEditTool.Visible = true;
            btnDeleteTool.Visible = true;
            cbodepartment.Enabled = false;
            txtname.BackColor = Color.White;
        }

        private void removee_Click(object sender, EventArgs e)
        {
            metroButtonDelete_Click(sender, e);
        }

        private void neww_Click(object sender, EventArgs e)
        {
            mode = "add";
            btnUpdateTool.Visible = true;
            btnAddTool.Visible = false;
            txtname.BackColor = Color.Yellow;
            lstPosition.Enabled = false;

            txtname.Enabled = true;
            txtname.Text = string.Empty;
            btnCancelTool.Visible = true;
       
            txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            btnUpdateTool.Visible = true;
            btnEditTool.Visible = false;
            cbodepartment.Enabled = true;
            loadDepartment();
            txtname.Focus();

            FrmAddNewPosition addNew = new FrmAddNewPosition(this,
            userinfo.user_id,
            "Add"
            );
            addNew.ShowDialog();


        }

        private void editt_Click(object sender, EventArgs e)
        {
            lstPosition.Enabled = false;

            if (lstPosition.Items.Count > 0)
            {
                mode = "edit";
                txtname.Enabled = true;
                txtname.ReadOnly = false;
                btnEditTool.Visible = false;
                btnAddTool.Visible = false;
                btnCancelTool.Visible = true;
                btnDeleteTool.Visible = false;
                btnUpdateTool.Visible = true;
                cbodepartment.Enabled = true;

            }
        }

        private void savee_Click(object sender, EventArgs e)
        {
            metroButtonSave_Click(sender, e);
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {  
          this.cancel_Click(sender, e);
          this.frmPosition_Load(sender, e);
        }
    }
}
