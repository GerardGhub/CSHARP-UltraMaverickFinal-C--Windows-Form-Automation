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

namespace ULTRAMAVERICK.Forms.Users.Modal
{
    public partial class frmEditUser : MaterialForm
    {
        frmUserManagement2 ths;
        //Main Constructor Bugok
        myclasses xClass = new myclasses();

        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        IStoredProcedures objStorProc = null;
        DataSet dSet_temp = new DataSet();
        int temp_id = 0;
        int s_id = 0;
        Boolean ready = false;
        DataSet dSet = new DataSet();
        string mode = "";
        public frmEditUser(frmUserManagement2 frm, string first_name, string last_name, string user_rights, 
            string username, string password, string department, string position, string unit, string user_layout,
            string requestor_type, string receiving_status, string gender, int  primary_key)
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            this.first_name = first_name;
            this.last_name = last_name;
            this.user_rights = user_rights;
            this.username = username;
            this.password = password;
            this.department = department;
            this.position = position;
            this.unit = unit;
            this.user_layout = user_layout;
            this.requestor_type = requestor_type;
            this.receiving_status = receiving_status;
            this.gender = gender;
            this.primary_key = primary_key;
        }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string user_rights { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string department { get; set; }
        public string position { get; set; }
        public string unit { get; set; }
        public string user_layout { get; set; }
        public string requestor_type { get; set; }
        public string receiving_status { get; set; }
        public string gender { get; set; }
        public string sp_drop_department_id { get; set; }
        public string sp_requestor_type_id { get; set; }
        public string sp_user_rights_id { get; set; }
        public string sp_dept_unit_id { get; set; }
        public string sp_position_id { get; set; }
        public int primary_key { get; set; }

        private void frmEditUser_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            loadUser_type(); // Load the UserType at User Rights
            loadDepartment();
            loadRequestorType();
            callDataBinding();
            textBox1.Text = String.Empty;

        }

        private void CallMotherNatureExternalControlls()
        {
            //Bind Start to eliminate the error in converting using Left Joins
           sp_position_id = cboPosition.SelectedValue.ToString();
          sp_dept_unit_id= cboUnit.SelectedValue.ToString();
            mode = "edit";
            //End animal ka1
        }
        public void loadUser_type()
        {

            myClass.fillComboBox(cbousertype, "user_type", dSet);
     
        }
        public void loadDepartment()
        {
            ready = false;
            myClass.fillComboBoxDepartment(cbodepartment, "department_dropdown", dSet);
            ready = true;

           sp_drop_department_id = cbodepartment.SelectedValue.ToString();
        }



        public void loadRequestorType()
        {
    
            myClass.fillComboBoxDepartment(cboRequestorType, "TypeofApprover_dropdown", dSet);
        

           sp_requestor_type_id = cboRequestorType.SelectedValue.ToString();
        }

        private void callDataBinding()
        {
            txtname.Text = first_name;
            txtLastName.Text = last_name;
            cbousertype.Text = user_rights;
            txtuser.Text = username;
            txtpassword.Text = password;
            cbodepartment.Text = department;
            cboPosition.Text = position;
            cboUnit.Text = unit;
            cmbLocation.Text = user_layout;
            cboRequestorType.Text = requestor_type;
            cmbNotif.Text = receiving_status;
            lblGenderSelected.Text = gender;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void frmEditUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            textBox1.Text = "Save Gerard Singian";
        }

        private void matRadioMale_CheckedChanged(object sender, EventArgs e)
        {
            if (matRadioMale.Checked == true)
            {
                lblGenderSelected.Text = "Male";
                lblgenderLabel.BackColor = Color.Transparent;
            }
            else if (matRadioFemale.Checked == true)
            {
                lblGenderSelected.Text = "Female";
                lblgenderLabel.BackColor = Color.Transparent;
            }
            else
            {
                lblGenderSelected.Text = String.Empty;
            }
        }

        private void matRadioFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (matRadioMale.Checked == true)
            {
                lblGenderSelected.Text = "Male";
            }
            else if (matRadioFemale.Checked == true)
            {
                lblGenderSelected.Text = "Female";
            }
            else
            {
                lblGenderSelected.Text = String.Empty;
            }
        }

        private void cbousertype_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sp_user_rights_id = cbousertype.SelectedValue.ToString();
        }
        public void loadUnit()
        {


            ready = false;
            xClass.fillComboBoxFilter(cboUnit, "filter_section_dropdown", dSet, sp_drop_department_id, 0);
            ready = true;
            s_id = showValue(cboUnit);


        }
        public int showValue(ComboBox cbo)
        {
            int ids = 0;
            if (ready == true)
            {
                if (cbo.Items.Count > 0)
                {
                    ids = Convert.ToInt32(cbo.SelectedValue.ToString());
                }
            }
            return ids;
        }
        public void loadPositionDropDown()
        {


            ready = false;
            xClass.fillComboBoxFilter(cboPosition, "filter_position_dropdown", dSet, sp_drop_department_id, 0);
            ready = true;
            s_id = showValue(cboPosition);


        }
        private void cbodepartment_SelectedValueChanged(object sender, EventArgs e)
        {
           sp_drop_department_id = cbodepartment.SelectedValue.ToString();
    

            if (cbodepartment.Text.Trim() != "")
            {
                loadUnit();
                cboUnit.Text = String.Empty;
            }


            if (cbodepartment.Text.Trim() != "")
            {
                loadPositionDropDown();
                cboPosition.Text = String.Empty;
            }
        }

        private void cboUnit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sp_dept_unit_id = cboUnit.SelectedValue.ToString();
        }

        private void cboPosition_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sp_position_id = cboPosition.SelectedValue.ToString();
        }

        private void cboRequestorType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sp_requestor_type_id = cboRequestorType.SelectedValue.ToString();
        }

        private void btnUpdateTool_Click(object sender, EventArgs e)
        {
            CallMotherNatureExternalControlls();
            if (txtname.Text.Trim() == "")
            {


                FillRequiredTextbox();
                txtname.BackColor = Color.Yellow;
                txtname.Focus();
                return;
            }
            if (txtLastName.Text.Trim() == "")
            {


                FillRequiredTextbox();
                txtLastName.BackColor = Color.Yellow;
                txtLastName.Focus();
                return;
            }
            if (cbousertype.Text.Trim() == "")
            {

                FillRequiredTextbox();
                cbousertype.BackColor = Color.Yellow;
                cbousertype.Focus();
                return;
            }
            if (cboPosition.Text.Trim() == "")
            {

                FillRequiredTextbox();
                cboPosition.BackColor = Color.Yellow;
                cboPosition.Focus();
                return;
            }
            if (cboRequestorType.Text.Trim() == "")
            {

                FillRequiredTextbox();
                cboRequestorType.BackColor = Color.Yellow;
                cboRequestorType.Focus();
                return;
            }
            if (txtuser.Text.Trim() == "")
            {

                FillRequiredTextbox();
                txtuser.BackColor = Color.Yellow;
                txtuser.Focus();
                return;
            }
            if (txtpassword.Text.Trim() == "")
            {

                FillRequiredTextbox();
                txtpassword.BackColor = Color.Yellow;
                txtpassword.Focus();
                return;
            }
            if (lblGenderSelected.Text.Trim() == "")
            {
                FillRequiredTextbox();
                lblgenderLabel.BackColor = Color.Yellow;
                return;
            }

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
        public void UserNameAlreadyTaken()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Username Already Taken!";
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
        public bool saveMode()
        {
            if (mode == "add")
            {
                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_userfile(0, txtuser.Text.Trim(), "", "", "validate");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    UserNameAlreadyTaken();
                    txtuser.Focus();
                    return false;
                }
                else
                {
                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_userfile(0,
                        Convert.ToInt32(sp_user_rights_id),
                        txtuser.Text.Trim(),
                        txtpassword.Text.Trim(),
                        txtname.Text.Trim(),
                        cmbLocation.Text.Trim(),
                        cmbNotif.Text.Trim(),
                         sp_position_id,
                        txtLastName.Text.Trim(),
                        sp_drop_department_id,
                        sp_requestor_type_id,
                        sp_dept_unit_id,
                        lblGenderSelected.Text.Trim(),
                        "add");
                    textBox1.Text = "Save Gerard Singian";
                    SaveSuccessfully();
                    this.Close();
                    return true;
                }

            }
            else if (mode == "edit")
            {
                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_userfile(primary_key,
                    txtuser.Text.Trim(), "",
                    cmbLocation.Text.Trim(), "getbyname");

                dSet_temp.Clear();
                dSet_temp = g_objStoredProcCollection.sp_userfile(primary_key,
                    txtuser.Text.Trim(), "", "", "getbyid");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    int tmpID = Convert.ToInt32(dSet.Tables[0].Rows[0][0].ToString());
                    if (tmpID == primary_key)
                    {
                        dSet.Clear();
                        dSet = g_objStoredProcCollection.sp_userfile(primary_key,
                            Convert.ToInt32(cbousertype.SelectedValue.ToString()),
                            txtuser.Text.Trim(),
                            txtpassword.Text.Trim(),
                            txtname.Text.Trim(),
                            cmbLocation.Text.Trim(),
                            cmbNotif.Text.Trim(),
                            sp_position_id,
                            txtLastName.Text.Trim(),
                            sp_drop_department_id,
                            sp_requestor_type_id,
                            sp_dept_unit_id,
                            lblGenderSelected.Text.Trim(),
                            "edit");
                        SaveSuccessfully();
                        textBox1.Text = "Save Gerard Singian";
                        this.Close();
                        return true;
                    }
                    else
                    {
                        UserNameAlreadyTaken();
                        txtuser.Focus();
                        return false;
                    }
                }
                else
                {
                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_userfile(primary_key,
                        Convert.ToInt32(cbousertype.SelectedValue.ToString()),
                        txtuser.Text.Trim(),
                        txtpassword.Text.Trim(),
                        txtname.Text.Trim(),
                        cmbLocation.Text.Trim(),
                        cmbNotif.Text.Trim(),
                        sp_position_id,
                        txtLastName.Text.Trim(),
                        sp_drop_department_id,
                       sp_requestor_type_id,
                        sp_dept_unit_id,
                        lblGenderSelected.Text.Trim(),
                        "edit");
                    SaveSuccessfully();
                    textBox1.Text = "Save Gerard Singian";

                    this.Close();
                    return true;
                }
            }
            else if (mode == "delete")
            {
                dSet.Clear();


                dSet_temp.Clear();
                dSet_temp = g_objStoredProcCollection.sp_userfile(temp_id, "", "", "", "delete");

                return true;
            }

            return false;
        }

        private void metroButtonSave_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to Save the New User " + txtname.Text + "", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (txtname.Text.Trim() == "")
                {


                    FillRequiredTextbox();
                    txtname.BackColor = Color.Yellow;
                    txtname.Focus();
                    return;
                }
                if (txtLastName.Text.Trim() == "")
                {


                    FillRequiredTextbox();
                    txtLastName.BackColor = Color.Yellow;
                    txtLastName.Focus();
                    return;
                }
                if (cbousertype.Text.Trim() == "")
                {

                    FillRequiredTextbox();
                    cbousertype.BackColor = Color.Yellow;
                    cbousertype.Focus();
                    return;
                }
                if (cboPosition.Text.Trim() == "")
                {

                    FillRequiredTextbox();
                    cboPosition.BackColor = Color.Yellow;
                    cboPosition.Focus();
                    return;
                }
                if (cboRequestorType.Text.Trim() == "")
                {

                    FillRequiredTextbox();
                    cboRequestorType.BackColor = Color.Yellow;
                    cboRequestorType.Focus();
                    return;
                }
                if (txtuser.Text.Trim() == "")
                {

                    FillRequiredTextbox();
                    txtuser.BackColor = Color.Yellow;
                    txtuser.Focus();
                    return;
                }
                if (txtpassword.Text.Trim() == "")
                {

                    FillRequiredTextbox();
                    txtpassword.BackColor = Color.Yellow;
                    txtpassword.Focus();
                    return;
                }
                if (lblGenderSelected.Text.Trim() == "")
                {
                    FillRequiredTextbox();
                    lblgenderLabel.BackColor = Color.Yellow;
                    return;
                }
                else
                {
                    if (saveMode())
                    {


                        mode = "";
                        SaveSuccessfully();

                    



                    }
                }
                cmbLocation.Enabled = false;
                cmbNotif.Enabled = false;
                txtname.Enabled = false;

            }
            else
            {

                return;
            }
        }
    }
}
