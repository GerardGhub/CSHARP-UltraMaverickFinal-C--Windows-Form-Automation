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

namespace ULTRAMAVERICK.Forms.Users.Modal
{
    public partial class frmAddnewUserModal : MaterialForm
    {

        PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;
        DataSet dSet_temp = new DataSet();
        int temp_id = 0;
        int s_id = 0;
        Boolean ready = false;
        DataSet dSet = new DataSet();
        string mode = "";
        frmUserManagement2 ths;
        public Byte[] imageByte = null;
        UserFile User = new UserFile();



        public frmAddnewUserModal(
            frmUserManagement2 frm,
            string Mode,
            string FirstName,
            string LastName,
            string UserRightsName,
            string UserName,
            string Password,
            string Department,
            string Position,
            string Unit,
            string UserLayout,
            string ReceivingStatus,
            string Gender,
            int temp_id
            )
        {
            InitializeComponent();
            ths = frm;
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);
            this.User.Mode = Mode;
            this.User.Employee_Name = FirstName;
            this.User.Employee_LastName = LastName;
            this.User.User_Rights_Name = UserRightsName;
            this.User.Department = Department;
            this.User.Unit = Unit;
            this.User.Position = Position;
            this.User.UserName = UserName;
            this.User.Password = Password;
            this.User.User_Section = UserLayout;
            this.User.Receiving_Status = ReceivingStatus;
            this.User.Gender = Gender;
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
            this.loadUser_type(); // Load the UserType at User Rights
     
            this.loadDepartment(); // Loading the Depeartment


            this.NewData();


            //if (this.User.Mode =="Edit")
            //{
   
            //    this.TxtFirstName.Text = this.User.Employee_Name;   this.TxtFirstName.Enabled = false;
            //    this.TxtLastName.Text = this.User.Employee_LastName; this.TxtLastName.Enabled = false;
            //    this.CboUserType.Text = this.User.User_Rights_Name;
            //    this.Cbodepartment.Text = this.User.Department;
            //    this.CboUnit.Text = this.User.Unit;
            //    this.cboPosition.Text = this.User.Position;
            //    this.TxtUserName.Text = this.User.UserName;
            //    this.TxtPassword.Text = this.User.Password;
            //    this.CmBLocation.Text = this.User.User_Section;
            //    this.cmbNotif.Text = this.User.Receiving_Status;
                
            //    if (this.User.Gender == "Male")
            //    {
            //        this.matRadioMale.Checked = true;
            //    }
            //    else
            //    {
            //        this.matRadioFemale.Checked = true;
            //    }
            //}
            //else
            //{

        
            //}
        }


        private void NewData()
        {
            mode = "add";
            matRadioMale.Enabled = true;
            matRadioFemale.Enabled = true;
            TxtFirstName.Focus();
            TxtFirstName.Enabled = true;
            CboUnit.Text = String.Empty;

            CboUserType.Enabled = true;
            CboUserType.Text = String.Empty;

            CboUnit.Enabled = true;
            TxtPassword.Enabled = true;
            TxtPassword.Text = String.Empty;

 
            TxtUserName.Enabled = true;
            TxtUserName.Text = String.Empty;


            TxtLastName.Enabled = true;
            disable_text(false);
            CmBLocation.Enabled = true;
            cmbNotif.Enabled = true;
      
            cboPosition.Enabled = true;
            Cbodepartment.Enabled = true;

            EmptyTextField();
            TxtFirstName.Text = String.Empty;
            TxtFirstName.Focus();
        }

        private void EmptyTextField()
        {
            TxtFirstName.Text = String.Empty;
            TxtLastName.Text = String.Empty;
            CboUserType.Text = String.Empty;
            cboPosition.Text = String.Empty;
            TxtUserName.Text = String.Empty;
            TxtPassword.Text = String.Empty;
            CmBLocation.Text = String.Empty;
            cmbNotif.Text = String.Empty;
            Cbodepartment.Text = string.Empty;

        }

        private void disable_text(Boolean e)
        {

            TxtFirstName.ReadOnly = e;
            TxtUserName.ReadOnly = e;
            TxtPassword.ReadOnly = e;
            TxtLastName.ReadOnly = e;
            cboPosition.Enabled = false;
            CboUserType.Enabled = !e;

        }

   
        public void loadUser_type()
        {
            ready = false;
            myClass.fillComboBox(CboUserType, "user_type", dSet);
            ready = true;
        }

        public void loadDepartment()
        {
 
            myClass.fillComboBoxDepartment(Cbodepartment, "department_dropdown", dSet);


            department_id = Cbodepartment.SelectedValue.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ths.textBox1.Text = textBox1.Text;
        }

        private void frmAddnewUserModal_FormClosing(object sender, FormClosingEventArgs e)
        {
            textBox1.Text = "SaveGerardSingian";
        }



        private void btnUpdateTool_Click(object sender, EventArgs e)
        {
            if (TxtFirstName.Text.Trim() == "")
            {


                this.GlobalStatePopup.FillRequiredFields();
                TxtFirstName.BackColor = Color.Yellow;
                TxtFirstName.Focus();
                return;
            }
            if (TxtLastName.Text.Trim() == "")
            {


                this.GlobalStatePopup.FillRequiredFields();
                TxtLastName.BackColor = Color.Yellow;
                TxtLastName.Focus();
                return;
            }
            if (CboUserType.Text.Trim() == "")
            {

                this.GlobalStatePopup.FillRequiredFields();
                CboUserType.BackColor = Color.Yellow;
                CboUserType.Focus();
                return;
            }
            if (cboPosition.Text.Trim() == "")
            {

                this.GlobalStatePopup.FillRequiredFields();
                cboPosition.BackColor = Color.Yellow;
                cboPosition.Focus();
                return;
            }
    
            if (TxtUserName.Text.Trim() == "")
            {

                this.GlobalStatePopup.FillRequiredFields();
                TxtUserName.BackColor = Color.Yellow;
                TxtUserName.Focus();
                return;
            }
            if (TxtPassword.Text.Trim() == "")
            {

                this.GlobalStatePopup.FillRequiredFields();
                TxtPassword.BackColor = Color.Yellow;
                TxtPassword.Focus();
                return;
            }
            if (lblGenderSelected.Text.Trim() == "")
            {
                this.GlobalStatePopup.FillRequiredFields();
                lblgenderLabel.BackColor = Color.Yellow;
                return;
            }

            metroButtonSave_Click(sender, e);
        }

       

        public bool saveMode()
        {
            if (mode == "add")
            {
                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_userfile(0, TxtUserName.Text.Trim(), "", "", "validate");

                if (dSet.Tables[0].Rows.Count > 0)
                {
             
                    this.GlobalStatePopup.DataAlreadyExist();
                    TxtUserName.Focus();
                    return false;
                }
                else
                {
                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_userfileIncrement(0,
                        Convert.ToInt32(sp_user_rights_id),
                        TxtUserName.Text.Trim(),
                        TxtPassword.Text.Trim(),
                        TxtFirstName.Text.Trim(),
                        CmBLocation.Text.Trim(),
                        cmbNotif.Text.Trim(),
                         sp_position_id,
                        TxtLastName.Text.Trim(),
                        department_id,
                        requestor_id,
                        sp_unit_id,
                        lblGenderSelected.Text.Trim(),
                        "add");
                    textBox1.Text = "Save Gerard Singian";
           
                       this.GlobalStatePopup.SuccessFullySave();
                    //return true;
                }

            }
            else if (mode == "edit")
            {
                dSet.Clear();
                dSet = g_objStoredProcCollection.sp_userfile(temp_id,
                    TxtUserName.Text.Trim(), "",
                    CmBLocation.Text.Trim(), "getbyname");

                dSet_temp.Clear();
                dSet_temp = g_objStoredProcCollection.sp_userfile(temp_id,
                    TxtUserName.Text.Trim(), "", "", "getbyid");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    int tmpID = Convert.ToInt32(dSet.Tables[0].Rows[0][0].ToString());
                    if (tmpID == temp_id)
                    {
                        dSet.Clear();
                        dSet = g_objStoredProcCollection.sp_userfile(temp_id,
                            Convert.ToInt32(CboUserType.SelectedValue.ToString()),
                            TxtUserName.Text.Trim(),
                            TxtPassword.Text.Trim(),
                            TxtFirstName.Text.Trim(),
                            CmBLocation.Text.Trim(),
                            cmbNotif.Text.Trim(),
                            sp_position_id,
                            TxtLastName.Text.Trim(),
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
                        this.GlobalStatePopup.DataAlreadyExist();
                        this.TxtUserName.Focus();
                        return false;
                    }
                }
                else
                {
                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_userfile(temp_id,
                        Convert.ToInt32(CboUserType.SelectedValue.ToString()),
                        TxtUserName.Text.Trim(),
                        TxtPassword.Text.Trim(),
                        TxtFirstName.Text.Trim(),
                        CmBLocation.Text.Trim(),
                        cmbNotif.Text.Trim(),
                        sp_position_id,
                        TxtLastName.Text.Trim(),
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
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to Save the New User " + TxtFirstName.Text + "", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (TxtFirstName.Text.Trim() == "")
                {


                    this.GlobalStatePopup.FillRequiredFields();
                    TxtFirstName.BackColor = Color.Yellow;
                    TxtFirstName.Focus();
                    return;
                }
                if (TxtLastName.Text.Trim() == "")
                {


                    this.GlobalStatePopup.FillRequiredFields();
                    TxtLastName.BackColor = Color.Yellow;
                    TxtLastName.Focus();
                    return;
                }
                if (CboUserType.Text.Trim() == "")
                {

                    this.GlobalStatePopup.FillRequiredFields();
                    CboUserType.BackColor = Color.Yellow;
                    CboUserType.Focus();
                    return;
                }
                if (cboPosition.Text.Trim() == "")
                {

                    this.GlobalStatePopup.FillRequiredFields();
                    cboPosition.BackColor = Color.Yellow;
                    cboPosition.Focus();
                    return;
                }
   
                if (TxtUserName.Text.Trim() == "")
                {

                    this.GlobalStatePopup.FillRequiredFields();
                    TxtUserName.BackColor = Color.Yellow;
                    TxtUserName.Focus();
                    return;
                }
                if (TxtPassword.Text.Trim() == "")
                {
                    this.GlobalStatePopup.FillRequiredFields();
                    TxtPassword.BackColor = Color.Yellow;
                    TxtPassword.Focus();
                    return;
                }
                if (lblGenderSelected.Text.Trim() == "")
                {
                    this.GlobalStatePopup.FillRequiredFields();
                    lblgenderLabel.BackColor = Color.Yellow;
                    return;
                }
                else
                {

                    dSet.Clear();
                    dSet = g_objStoredProcCollection.sp_userfileIncrement(0,
                        Convert.ToInt32(sp_user_rights_id),
                        TxtUserName.Text.Trim(),
                        TxtPassword.Text.Trim(),
                        TxtFirstName.Text.Trim(),
                        CmBLocation.Text.Trim(),
                        cmbNotif.Text.Trim(),
                         sp_position_id,
                        TxtLastName.Text.Trim(),
                        department_id,
                        requestor_id,
                        sp_unit_id,
                        lblGenderSelected.Text.Trim(),
                        "add");
                    textBox1.Text = "SaveGerardSingian";
                    this.GlobalStatePopup.SuccessFullySave();
              

                    frmAddnewUserModal_Load(sender, e);
           
           
                }
                CmBLocation.Enabled = false;
                cmbNotif.Enabled = false;
                TxtFirstName.Enabled = false;

            }
            else
            {

                return;
            }
        }

        private void cbousertype_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sp_user_rights_id = CboUserType.SelectedValue.ToString();
        }

        public void loadUnit()
        {
            myClass.fillComboBoxFilter(CboUnit, "filter_section_dropdown", dSet, department_id, 0);
            s_id = showValue(CboUnit);
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
            myClass.fillComboBoxFilter(cboPosition, "filter_position_dropdown", dSet, department_id, 0);
            s_id = showValue(cboPosition);
        }
        private void cbodepartment_SelectedValueChanged(object sender, EventArgs e)
        {
            department_id = Cbodepartment.SelectedValue.ToString();
            //loadUnit();

            if (Cbodepartment.Text.Trim() != "")
            {
                loadUnit();
                CboUnit.Text = String.Empty;
            }


            if (Cbodepartment.Text.Trim() != "")
            {
                loadPositionDropDown();
                cboPosition.Text = String.Empty;
            }
        }

        private void cboUnit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sp_unit_id = CboUnit.SelectedValue.ToString();
        }

        private void cboPosition_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sp_position_id = cboPosition.SelectedValue.ToString();
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
     
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }
    }
}
