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
    public partial class frmSubCategory : MaterialForm
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



        DataSet dSet_temp = new DataSet();
        public frmSubCategory()
        {
            InitializeComponent();
        }
        public string sp_created_at { get; set; }
        public string sp_created_by { get; set; }
        public string is_expirables { get; set; }
        public string sp_modified_at { get; set; }
        public string sp_modified_by { get; set; }
        private void frmSubCategory_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class

            this.showSubCategoryData();
        }
        private void showSubCategoryData()      //method for loading available_menus
        {
            try
            {
        
                xClass.fillDataGridView(dgvSubCategory, "Sub_Category", dSet);
         
                lbltotalrecords.Text = dgvSubCategory.RowCount.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            dgvSubCategory.Columns["is_active"].Visible = false;

        }

        private void matBtnNew_Click(object sender, EventArgs e)
        {
            this.mode = "add";
            this.matBtnEdit.Visible = false;
            this.matBtnCancel.Visible = true;
            this.txtSubCategory.Enabled = true;
            this.matBtnNew.Visible = false;
            this.txtSubCategory.Text = String.Empty;
            this.sp_modified_at = String.Empty;
            this.sp_modified_by = String.Empty;

            this.sp_created_at = (dNow.ToString("M/d/yyyy"));
            this.sp_created_by = userinfo.emp_name.ToUpper();
            //txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            this.matBtnSave.Visible = true;
            this.txtSubCategory.Select();
            this.txtSubCategory.Focus();
        }

        private void matBtnCancel_Click(object sender, EventArgs e)
        {
            this.matBtnCancel.Visible = false;
            this.mode = "";
            this.sp_created_by = String.Empty;
            this.sp_created_at = String.Empty;
            this.matBtnEdit.Visible = true;
            this.matBtnSave.Visible = false;
            this.matBtnNew.Visible = true;
            this.matBtnDelete.Visible = true;
            this.txtSubCategory.Enabled = false;
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
        private void matBtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSubCategory.Rows.Count > 0)
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to remove the Sub Category", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {


                    mode = "delete";

                    if (saveMode())
                    {
                        this.DeletedSuccessfully();
                        this.showSubCategoryData();

                        matBtnCancel_Click("", e);
                    }
                }

                else
                {
                    return;
                }






            }
        }

        private void matBtnEdit_Click(object sender, EventArgs e)
        {
            this.mode = "edit";
            this.sp_modified_at = (dNow.ToString("M/d/yyyy"));
            this.sp_modified_by = userinfo.emp_name.ToUpper();
            this.matBtnDelete.Visible = false;
            this.matBtnCancel.Visible = true;
            this.matBtnNew.Visible = false;
            this.matBtnEdit.Visible = false;
            this.matBtnSave.Visible = true;
            this.txtSubCategory.Enabled = true;
            this.txtSubCategory.Focus();
        }

        public void SubCategoryAlreadyExist()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Sub Category Already Exist!";
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
            dSet = objStorProc.sp_Sub_Category(0,
                txtSubCategory.Text, "", "", "","", "", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                this.SubCategoryAlreadyExist();


                this.txtSubCategory.Focus();
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
            this.matRadioExpirable.Enabled = false;
            this.matRadioNotExpirable.Enabled = false; ;

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
        private void metroSave_Click(object sender, EventArgs e)
        {
            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to update the  Sub Category Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {



                if (txtSubCategory.Text.Trim() == string.Empty)
                {

                    FillRequiredFields();
                    txtSubCategory.Focus();
                    return;
                }

                else
                {
                    if (saveMode())
                    {

                        string tmode = mode;

                        if (tmode == "add")
                        {
                            dgvSubCategory.CurrentCell = dgvSubCategory[0, dgvSubCategory.Rows.Count - 1];
                            UpdateNotifications();
                        }
                        else
                        {
                            dgvSubCategory.CurrentCell = dgvSubCategory[0, temp_hid];

                        }
                        matBtnCancel_Click(sender, e);
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
                dSet = objStorProc.sp_Sub_Category(0, 
                    txtSubCategory.Text, "", "", "", "","", "getbyname");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    SubCategoryAlreadyExist();

                    txtSubCategory.Text = string.Empty;
                    txtSubCategory.Focus();
                    return false;
                }
                else
                {

                    dSet.Clear();
                    dSet = objStorProc.sp_Sub_Category(0, 
                        txtSubCategory.Text.Trim(),

                        sp_created_at,
                        sp_created_by,
                        sp_modified_at,
                        sp_modified_by, is_expirables, "add");

                    showSubCategoryData();


                    return true;
                }
            }
            else if (mode == "edit")
            {
                dSet.Clear();
                dSet = objStorProc.sp_Sub_Category(0,
                    txtSubCategory.Text,
                    "", "", "", "","", "getbyname");

                dSet_temp.Clear();
                dSet_temp = objStorProc.sp_Sub_Category(p_id,
                    txtSubCategory.Text, "", "", "", "", "","getbyid");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    int tmpID = Convert.ToInt32(dSet.Tables[0].Rows[0][0].ToString());
                    if (tmpID == p_id)
                    {
                        dSet.Clear();
                        dSet = objStorProc.sp_Sub_Category(p_id,
                            txtSubCategory.Text.Trim(),

                            sp_created_by,
                            sp_created_at,
                            sp_modified_at,
                            sp_modified_by, is_expirables, "edit");
                        UpdateNotifications();
                        showSubCategoryData();
                        mode = "";
                        matBtnCancel_Click(new object(), new System.EventArgs());
                        return true;
                    }
                    else
                    {

                        txtSubCategory.Text = String.Empty;
                        txtSubCategory.Focus();
                        return false;
                    }
                }
                else
                {
                    dSet.Clear();
                    dSet = objStorProc.sp_Sub_Category(p_id,
                        txtSubCategory.Text.Trim(),

                          sp_created_by,
                         sp_created_at,
                          sp_modified_at,
                          sp_modified_by, is_expirables, "edit");
                    UpdateNotifications();
                    showSubCategoryData();
                    mode = "";
                    matBtnCancel_Click(new object(), new System.EventArgs());
                }
            }
            else if (mode == "delete")
            {

                dSet_temp.Clear();
                dSet_temp = objStorProc.sp_Sub_Category(p_id,
                    txtSubCategory.Text, "", "", "", "","", "delete");

                return true;
            }
            return false;
        }


        private void metroFinalSaving_Click(object sender, EventArgs e)
        {
            if (txtSubCategory.Text.Trim() == string.Empty)
            {
                FillRequiredFields();
                txtSubCategory.Focus();
            }
            else
            {
                if (saveMode())
                {
                    SubCategoryAlreadyExist();
                    string tmode = mode;

                    if (tmode == "add")
                    {
                        dgvSubCategory.CurrentCell = dgvSubCategory[0, dgvSubCategory.Rows.Count - 1];

                    }
                    else
                    {
                        dgvSubCategory.CurrentCell = dgvSubCategory[0, temp_hid];
                    }
                    matBtnCancel_Click(sender, e);
                }
                else

                    return;
            }
        }

        private void dgvMajorCategory_CurrentCellChanged(object sender, EventArgs e)
        {
            showValueCell();
        }

        private void showValueCell()
        {
            if (dgvSubCategory.Rows.Count > 0)
            {
                if (dgvSubCategory.CurrentRow != null)
                {
                    if (dgvSubCategory.CurrentRow.Cells["sub_category_desc"].Value != null)
                    {
                        this.p_id = Convert.ToInt32(dgvSubCategory.CurrentRow.Cells["sub_category_id"].Value);
                        this.txtSubCategory.Text = dgvSubCategory.CurrentRow.Cells["sub_category_desc"].Value.ToString();
                        this.sp_created_by = dgvSubCategory.CurrentRow.Cells["sc_added_by"].Value.ToString();
                        this.sp_created_at = dgvSubCategory.CurrentRow.Cells["sc_added_at"].Value.ToString();
                        this.sp_modified_at = dgvSubCategory.CurrentRow.Cells["sc_updated_at"].Value.ToString();
                        this.sp_modified_by = dgvSubCategory.CurrentRow.Cells["sc_updated_by"].Value.ToString();
                        is_expirables = dgvSubCategory.CurrentRow.Cells["is_expirable"].Value.ToString();

                        if (is_expirables == "1")
                        {
                           matRadioExpirable.Checked = true;
                            matRadioNotExpirable.Checked = false;
                        }
                        else if (is_expirables == "0")
                        {
                            matRadioExpirable.Checked = false;
                            matRadioNotExpirable.Checked = true;
                        }
                        else
                        {
                 
                        }
                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.mode = "add";
            this.matBtnEdit.Visible = false;
            this.matBtnCancel.Visible = true;
            this.txtSubCategory.Enabled = true;
            this.matBtnNew.Visible = false;
            this.txtSubCategory.Text = String.Empty;
            this.sp_modified_at = String.Empty;
            this.sp_modified_by = String.Empty;
            this.matRadioExpirable.Enabled = true;
            this.matRadioNotExpirable.Enabled = true;
            this.matBtnDelete.Visible = false;
            this.sp_created_at = (dNow.ToString("M/d/yyyy"));
            this.sp_created_by = userinfo.emp_name.ToUpper();
            //txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            this.matBtnSave.Visible = true;
            this.txtSubCategory.Select();
            this.txtSubCategory.Focus();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.matBtnCancel.Visible = false;
            this.mode = "";
            this.sp_created_at = String.Empty;
            this.sp_created_by = String.Empty;
            this.matBtnEdit.Visible = true;
            this.matBtnSave.Visible = false;
            this.matBtnNew.Visible = true;
            this.matBtnDelete.Visible = true;
            this.txtSubCategory.Enabled = false;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dgvSubCategory.Rows.Count > 0)
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to remove the Sub Category", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {


                    mode = "delete";

                    if (saveMode())
                    {
                        DeletedSuccessfully();
                        showSubCategoryData();

                        matBtnCancel_Click("", e);
                    }
                }

                else
                {
                    return;
                }






            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            mode = "edit";
            this.matRadioExpirable.Enabled = true;
            this.matRadioNotExpirable.Enabled = true;
           this.sp_modified_at = (dNow.ToString("M/d/yyyy"));
            this.sp_modified_by = userinfo.emp_name.ToUpper();
            matBtnDelete.Visible = false;
            matBtnCancel.Visible = true;
            matBtnNew.Visible = false;
            matBtnEdit.Visible = false;
            matBtnSave.Visible = true;
            txtSubCategory.Enabled = true;
            txtSubCategory.Focus();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (mode == "edit")
            {
                metroSave_Click(sender, e);
            }
            else
            {
                dSet.Clear();
                dSet = objStorProc.sp_Sub_Category(0,
                    txtSubCategory.Text, "", "", "", "", "", "getbyname");

                if (dSet.Tables[0].Rows.Count > 0)
                {

                    SubCategoryAlreadyExist();


                    txtSubCategory.Focus();
                    return;
                }
                else
                {
                    metroSave_Click(sender, e);
                }
            }
        }

        private void matRadioExpirable_CheckedChanged(object sender, EventArgs e)
        {
            if (matRadioExpirable.Checked == true)
            {
                this.is_expirables = "1";
            }
            else if (matRadioNotExpirable.Checked == true)
            {
                this.is_expirables = "0";
            }
            else
            {
                
            }
        }

        private void matRadioNotExpirable_CheckedChanged(object sender, EventArgs e)
        {
            if (matRadioExpirable.Checked == true)
            {
                this.is_expirables = "1";
            }
            else if (matRadioNotExpirable.Checked == true)
            {
                this.is_expirables = "0";
            }
            else
            {

            }
        }

        private void txtSubCategory_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        //

    }
}
