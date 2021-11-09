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
    public partial class frmAddnewUserModal : MaterialForm
    {
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
        frmUserManagement2 ths;
        public Byte[] imageByte = null;
        public frmAddnewUserModal(frmUserManagement2 frm)
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            //this.created_by = created_by;
        }

        public string requestor_id { get; set; }
        public string department_id { get; set; }

        public string sp_user_rights_id { get; set; }
        public string sp_position_id { get; set; }

        public string sp_unit_id { get; set; }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }

        private void frmAddnewUserModal_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class
            this.loadUser_type(); // Load the UserType at User Rights
      

  
   
     

            this.loadDepartment(); // Loading the Depeartment
            this.loadRequestorType(); //Load Requestor Types
 
            this.RefresherOnLoadingThePage();
            this.NewData();
        }


        private void NewData()
        {
            mode = "add";
            matRadioMale.Enabled = true;
            matRadioFemale.Enabled = true;
            txtname.Focus();
            txtname.Enabled = true;
            cboUnit.Text = String.Empty;

            cbousertype.Enabled = true;
            cbousertype.Text = String.Empty;

            cboUnit.Enabled = true;
            txtpassword.Enabled = true;
            txtpassword.Text = String.Empty;

 
            txtuser.Enabled = true;
            txtuser.Text = String.Empty;


            txtLastName.Enabled = true;
            disable_text(false);
            cmbLocation.Enabled = true;
            cmbNotif.Enabled = true;
      
            cboPosition.Enabled = true;
            cbodepartment.Enabled = true;
            cboRequestorType.Enabled = true;
            EmptyTextField();
            txtname.Text = String.Empty;
            txtname.Focus();
        }

        private void EmptyTextField()
        {
            txtname.Text = String.Empty;
            txtLastName.Text = String.Empty;
            cbousertype.Text = String.Empty;
            cboPosition.Text = String.Empty;
            txtuser.Text = String.Empty;
            txtpassword.Text = String.Empty;
            cmbLocation.Text = String.Empty;
            cmbNotif.Text = String.Empty;
            cbodepartment.Text = string.Empty;
            cboRequestorType.Text = string.Empty;
        }

        private void disable_text(Boolean e)
        {

            txtname.ReadOnly = e;
            txtuser.ReadOnly = e;
            txtpassword.ReadOnly = e;
            txtLastName.ReadOnly = e;
            cboPosition.Enabled = false;
            cbousertype.Enabled = !e;

        }

        private void RefresherOnLoadingThePage()
        {

        }
        public void loadUser_type()
        {
            ready = false;
            myClass.fillComboBox(cbousertype, "user_type", dSet);
            ready = true;
        }
        public void loadRequestorType()
        {
            ready = false;
            myClass.fillComboBoxDepartment(cboRequestorType, "TypeofApprover_dropdown", dSet);
            ready = true;

            requestor_id = cboRequestorType.SelectedValue.ToString();
        }

        public void loadDepartment()
        {
            ready = false;
            myClass.fillComboBoxDepartment(cbodepartment, "department_dropdown", dSet);
            ready = true;

            department_id = cbodepartment.SelectedValue.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void frmAddnewUserModal_FormClosing(object sender, FormClosingEventArgs e)
        {
            textBox1.Text = "Save Gerard Singian";
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

        private void btnUpdateTool_Click(object sender, EventArgs e)
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

            metroButtonSave_Click(sender, e);
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
                    dSet = g_objStoredProcCollection.sp_userfileIncrement(0,
                        Convert.ToInt32(sp_user_rights_id),
                        txtuser.Text.Trim(),
                        txtpassword.Text.Trim(),
                        txtname.Text.Trim(),
                        cmbLocation.Text.Trim(),
                        cmbNotif.Text.Trim(),
                         sp_position_id,
                        txtLastName.Text.Trim(),
                        department_id,
                        requestor_id,
                        sp_unit_id,
                        lblGenderSelected.Text.Trim(),
                        "add");
                    textBox1.Text = "Save Gerard Singian";
                    SaveSuccessfully();
                    this.Close();
                    //return true;
                }

            }
            else if (mode == "edit")
            {
                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_userfile(temp_id,
                    txtuser.Text.Trim(), "",
                    cmbLocation.Text.Trim(), "getbyname");

                dSet_temp.Clear();
                dSet_temp = g_objStoredProcCollection.sp_userfile(temp_id,
                    txtuser.Text.Trim(), "", "", "getbyid");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    int tmpID = Convert.ToInt32(dSet.Tables[0].Rows[0][0].ToString());
                    if (tmpID == temp_id)
                    {
                        dSet.Clear();
                        dSet = g_objStoredProcCollection.sp_userfile(temp_id,
                            Convert.ToInt32(cbousertype.SelectedValue.ToString()),
                            txtuser.Text.Trim(),
                            txtpassword.Text.Trim(),
                            txtname.Text.Trim(),
                            cmbLocation.Text.Trim(),
                            cmbNotif.Text.Trim(),
                            sp_position_id,
                            txtLastName.Text.Trim(),
                            department_id,
                            requestor_id,
                            sp_unit_id,
                            lblGenderSelected.Text.Trim(), imageByte,
                            "edit");
                        matRadioMale.Enabled = false;
                        matRadioFemale.Enabled = false;
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
                    dSet = g_objStoredProcCollection.sp_userfile(temp_id,
                        Convert.ToInt32(cbousertype.SelectedValue.ToString()),
                        txtuser.Text.Trim(),
                        txtpassword.Text.Trim(),
                        txtname.Text.Trim(),
                        cmbLocation.Text.Trim(),
                        cmbNotif.Text.Trim(),
                        sp_position_id,
                        txtLastName.Text.Trim(),
                        department_id,
                       requestor_id,
                        sp_unit_id,
                        lblGenderSelected.Text.Trim(), imageByte,
                        "edit");

                    matRadioMale.Enabled = false;
                    matRadioFemale.Enabled = false;
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

                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_userfileIncrement(0,
                        Convert.ToInt32(sp_user_rights_id),
                        txtuser.Text.Trim(),
                        txtpassword.Text.Trim(),
                        txtname.Text.Trim(),
                        cmbLocation.Text.Trim(),
                        cmbNotif.Text.Trim(),
                         sp_position_id,
                        txtLastName.Text.Trim(),
                        department_id,
                        requestor_id,
                        sp_unit_id,
                        lblGenderSelected.Text.Trim(),
                        "add");
                    textBox1.Text = "SaveGerardSingian";
                    SaveSuccessfully();
                    //this.Close();

                    frmAddnewUserModal_Load(sender, e);
                    //saveMode();
                    //if (saveMode())
                    //{


                    //    //mode = "";
                    //    SaveSuccessfully();

                    //    //disable_text(true);



                    //}
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

        private void cbousertype_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sp_user_rights_id = cbousertype.SelectedValue.ToString();
        }

        public void loadUnit()
        {


            ready = false;
            xClass.fillComboBoxFilter(cboUnit, "filter_section_dropdown", dSet, department_id, 0);
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
            xClass.fillComboBoxFilter(cboPosition, "filter_position_dropdown", dSet, department_id, 0);
            ready = true;
            s_id = showValue(cboPosition);


        }
        private void cbodepartment_SelectedValueChanged(object sender, EventArgs e)
        {
            department_id = cbodepartment.SelectedValue.ToString();
            //loadUnit();

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
            sp_unit_id = cboUnit.SelectedValue.ToString();
        }

        private void cboPosition_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sp_position_id = cboPosition.SelectedValue.ToString();
        }

        private void cboRequestorType_SelectionChangeCommitted(object sender, EventArgs e)
        {
           requestor_id = cboRequestorType.SelectedValue.ToString();
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

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void matChkQAUserAccount_CheckedChanged(object sender, EventArgs e)
        {
            if(matChkQAUserAccount.Checked == true)
            {
                cmbQAUserType.Visible = true;
                lblUserType.Visible = true;
            }
            else
            {
                cmbQAUserType.Visible = false;
                lblUserType.Visible = false;

            }
        }
    }
}
