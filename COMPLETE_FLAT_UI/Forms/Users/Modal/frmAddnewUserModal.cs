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
using System.IO;
using COMPLETE_FLAT_UI.Models;

namespace ULTRAMAVERICK.Forms.Users.Modal
{
    public partial class frmAddnewUserModal : MaterialForm
    {
        readonly PopupNotifierClass GlobalStatePopup = new PopupNotifierClass();
        readonly myclasses myClass = new myclasses();
        IStoredProcedures g_objStoredProcCollection = null;

        DataSet dSet_temp = new DataSet();
        int temp_id = 0;
        DataSet dSet = new DataSet();
        string mode = "";
        frmUserManagement2 ths;
        readonly UserFile UserFileEntity = new UserFile();

        private readonly String defaultImage = Path.GetDirectoryName(Application.ExecutablePath) + @"\Resources\Employee.png";
        private FileStream fileStream;
        private BinaryReader binaryReader;
        public Byte[] imageByte = null;


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
            this.UserFileEntity.Mode = Mode;
            this.UserFileEntity.Employee_Name = FirstName;
            this.UserFileEntity.Employee_LastName = LastName;
            this.UserFileEntity.User_Rights_Name = UserRightsName;
            this.UserFileEntity.Department = Department;
            this.UserFileEntity.Unit = Unit;
            this.UserFileEntity.Position = Position;
            this.UserFileEntity.UserName = UserName;
            this.UserFileEntity.Password = Password;
            this.UserFileEntity.User_Section = UserLayout;
            this.UserFileEntity.Receiving_Status = ReceivingStatus;
            this.UserFileEntity.Gender = Gender;
        }

  
        private void ConnectionInit()
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
        }


        private void frmAddnewUserModal_Load(object sender, EventArgs e)
        {
            this.ConnectionInit();
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
            this.mode = "add";
            this.matRadioMale.Enabled = true;
            this.matRadioFemale.Enabled = true;
            this.TxtFirstName.Focus();
            this.TxtFirstName.Enabled = true;
            this.CboUnit.Text = String.Empty;

            this.CboUserType.Enabled = true;
            this.CboUserType.Text = String.Empty;

            this.CboUnit.Enabled = true;
            this.TxtPassword.Enabled = true;
            this.TxtPassword.Text = String.Empty;


            this.TxtUserName.Enabled = true;
            this.TxtUserName.Text = String.Empty;


            this.TxtLastName.Enabled = true;
            this.disable_text(false);
            this.CmBLocation.Enabled = true;
            this.cmbNotif.Enabled = true;

            this.cboPosition.Enabled = true;
            this.Cbodepartment.Enabled = true;

            this.EmptyTextField();
            this.TxtFirstName.Text = String.Empty;
            this.TxtFirstName.Focus();
        }

        private void EmptyTextField()
        {
            this.TxtFirstName.Text = String.Empty;
            this.TxtLastName.Text = String.Empty;
            this.CboUserType.Text = String.Empty;
            this.cboPosition.Text = String.Empty;
            this.TxtUserName.Text = String.Empty;
            this.TxtPassword.Text = String.Empty;
            this.CmBLocation.Text = String.Empty;
            this.cmbNotif.Text = String.Empty;
            this.Cbodepartment.Text = string.Empty;
            this.lblGenderSelected.Text = String.Empty;

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
            this.myClass.fillComboBox(CboUserType, "user_type", dSet);
        }

        public void loadDepartment()
        {
            this.myClass.fillComboBoxDepartment(Cbodepartment, "department_dropdown", dSet);
            this.UserFileEntity.Department = this.Cbodepartment.SelectedValue.ToString();
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
            if (CmBLocation.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
               CmBLocation.BackColor = Color.Yellow;
                return;
            }

            if (cmbNotif.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
                cmbNotif.BackColor = Color.Yellow;
                return;
            }

            if (this.lblGenderSelected.Text == String.Empty)
            {
                this.GlobalStatePopup.FillRequiredFields();
           
                return;
            }

            //Combobox Bind Parameters
            this.cboPosition_SelectionChangeCommitted(sender, e);
            this.cboUnit_SelectionChangeCommitted(sender, e);
            this.cbodepartment_SelectedValueChanged(sender, e);
        
           
     
                dSet.Clear();
            dSet = g_objStoredProcCollection.sp_userfile(0, TxtUserName.Text.Trim(), this.TxtFirstName.Text, this.TxtLastName.Text, "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {

                this.GlobalStatePopup.DataAlreadyExist();
                this.TxtUserName.Text = String.Empty;
                this.TxtUserName.Focus();
                return;
            }
            else
            {
                this.SaveFunctionality();
            }
        }

       
        private void SaveFunctionality()
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to save the new user " + TxtFirstName.Text + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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
                    if (pbImage.Image == null)
                    {
                        this.mode = "WithoutImage";
                    }
                    else
                    {
                        this.mode = "WithImage";
                    }

                    if (this.mode == "WithImage")
                    {

                        dSet.Clear();
                        dSet = g_objStoredProcCollection.sp_userfile(0,
                            Convert.ToInt32(this.UserFileEntity.User_Rights_Id),
                            TxtUserName.Text.Trim(),
                            TxtPassword.Text.Trim(),
                            TxtFirstName.Text.Trim(),
                            CmBLocation.Text.Trim(),
                            cmbNotif.Text.Trim(),
                            this.UserFileEntity.Position,
                            TxtLastName.Text.Trim(),
                            this.UserFileEntity.Department,
                            UserFileEntity.Requestor_Type,
                            this.UserFileEntity.Unit,
                            lblGenderSelected.Text.Trim(),
                            imageByte,
                            "add");
                        textBox1.Text = "SaveGerardSingian";
                        this.GlobalStatePopup.SuccessFullySave();


                        this.Close();
                    }

                    else
                    {

                        dSet.Clear();
                        dSet = g_objStoredProcCollection.sp_userfileIncrement(0,
                            Convert.ToInt32(this.UserFileEntity.User_Rights_Id),
                            TxtUserName.Text.Trim(),
                            TxtPassword.Text.Trim(),
                            TxtFirstName.Text.Trim(),
                            CmBLocation.Text.Trim(),
                            cmbNotif.Text.Trim(),
                            this.UserFileEntity.Position,
                            TxtLastName.Text.Trim(),
                            this.UserFileEntity.Department,
                            UserFileEntity.Requestor_Type,
                            this.UserFileEntity.Unit,
                            lblGenderSelected.Text.Trim(),
                            "add");
                        textBox1.Text = "SaveGerardSingian";
                        this.GlobalStatePopup.SuccessFullySave();


                        this.Close();
                    }



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


    


        private void metroButtonSave_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to save the new user " + TxtFirstName.Text + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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
                    dSet = g_objStoredProcCollection.sp_userfile(0,
                        Convert.ToInt32(this.UserFileEntity.User_Rights_Id),
                        TxtUserName.Text.Trim(),
                        TxtPassword.Text.Trim(),
                        TxtFirstName.Text.Trim(),
                        CmBLocation.Text.Trim(),
                        cmbNotif.Text.Trim(),
                        this.UserFileEntity.Position,
                        TxtLastName.Text.Trim(),
                        this.UserFileEntity.Department,
                        UserFileEntity.Requestor_Type,
                        this.UserFileEntity.Unit,
                        lblGenderSelected.Text.Trim(),
                        imageByte,
                        "add");
                    textBox1.Text = "SaveGerardSingian";
                    this.GlobalStatePopup.SuccessFullySave();


                    this.Close();
           
           
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
            this.UserFileEntity.User_Rights_Id = Convert.ToInt32(CboUserType.SelectedValue);
        }

        public void loadUnit()
        {
            this.myClass.fillComboBoxFilter(CboUnit, 
                "filter_section_dropdown", 
                dSet, 
                this.UserFileEntity.Department, 0);
            this.temp_id = showValue(CboUnit);
        }

        public int showValue(ComboBox cbo)
        {
            int ids = 0;
         
                if (cbo.Items.Count > 0)
                {
                    ids = Convert.ToInt32(cbo.SelectedValue.ToString());
                }
         
            return ids;
        }

        public void loadPositionDropDown()
        {
            myClass.fillComboBoxFilter(cboPosition, 
                "filter_position_dropdown", 
                dSet, 
                this.UserFileEntity.Department, 0);
            this.temp_id = showValue(cboPosition);
        }
        private void cbodepartment_SelectedValueChanged(object sender, EventArgs e)
        {
            this.UserFileEntity.Department = this.Cbodepartment.SelectedValue.ToString();
      

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
            this.UserFileEntity.Unit = this.CboUnit.SelectedValue.ToString();
        }

        private void cboPosition_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.UserFileEntity.Position = this.cboPosition.SelectedValue.ToString();
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

        private void btnImage_Click(object sender, EventArgs e)
        {
            this.selectEmployeeImage();
        }


        private Boolean readImageByte(String path)
        {
            try
            {
                imageByte = new byte[Convert.ToInt32(null)];
                fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                binaryReader = new BinaryReader(fileStream);
                imageByte = binaryReader.ReadBytes((Int32)fileStream.Length);
                pbImage.Image = null;
                pbImage.Refresh();
                pbImage.Image = Image.FromFile(path);
                return true;
            }
            catch (Exception exception)
            {
                loadDefaultImage();
                MessageBox.Show("Error  :  Image failed to Read\n\nPlease Try it again!!!\n\n" + exception.Message, "HR Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void loadDefaultImage()
        {
            try
            {

                pbImage.Image = null;
                pbImage.Refresh();
                pbImage.BackgroundImage = new Bitmap(Properties.Resources.Buddy);
                // Image.FromFile(Path.GetDirectoryName(Application.ExecutablePath) + @"\Resources\Buddy.png");
                imageByte = new byte[Convert.ToInt32(null)];
                btnRemove.Enabled = false;
            }
            catch (Exception)
            {

            }
        }


        private void selectEmployeeImage()
        {
            odbEmployeeImage.Filter = "JPEG Images (.JPG)|*.jpg|GIF Images (.GIF)|*.gif|BITMAPS (.BMP)|*.bmp|PNG Images (.PNG)|*.png";
            odbEmployeeImage.Multiselect = false;

            if (odbEmployeeImage.ShowDialog() != DialogResult.Cancel)
            {
                try
                {
                    pbImage.Image = null;
                    pbImage.Refresh();
                    pbImage.Image = Image.FromFile(odbEmployeeImage.FileName);

                    if (readImageByte(odbEmployeeImage.FileName))
                    {
                        btnRemove.Enabled = true;
                    }
                }
                catch (Exception exception)
                {

                    MessageBox.Show("Error  : Image Failed To Load \n\n\n" + exception.Message, "UM Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Remove The Image?", "Remove Image", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                loadDefaultImage();

                frmUserManagement2 sa = new frmUserManagement2();

                sa.ActivitiesLogs(userinfo.emp_name + " Remove Image");
            }
        }
    }
}
