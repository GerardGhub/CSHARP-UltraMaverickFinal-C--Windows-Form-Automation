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
    public partial class frmMajorCategory : MaterialForm
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

        public frmMajorCategory()
        {
            InitializeComponent();
        }

        private void frmMajorCategory_Load(object sender, EventArgs e)
        {
            g_objStoredProcCollection = myClass.g_objStoredProc.GetCollections(); // Main Stored Procedure Collections
            objStorProc = xClass.g_objStoredProc.GetCollections(); //Call the StoreProcedure With Class

            showMajorCategoryData();
        }

        private void showMajorCategoryData()      //method for loading available_menus
        {
            try
            {
                ready = false;
                xClass.fillDataGridView(dgvMajorCategory, "Major_Category", dSet);
                ready = true;
                lbltotalrecords.Text = dgvMajorCategory.RowCount.ToString();
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
            txtmajorCategory.Enabled = true;
            matBtnNew.Visible = false;
            txtmajorCategory.Text = String.Empty;
            txtModifiedAt.Text = String.Empty;
            txtModifiedBy.Text = String.Empty;

            txtCreatedAt.Text = (dNow.ToString("M/d/yyyy"));
            txtCreatedBy.Text = userinfo.emp_name.ToUpper();
            //txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            matBtnSave.Visible = true;
            txtmajorCategory.Select();
            txtmajorCategory.Focus();
        }

        private void matBtnCancel_Click(object sender, EventArgs e)
        {
            matBtnCancel.Visible = false;
            mode = "";
            txtCreatedAt.Text = String.Empty;
            txtCreatedBy.Text = String.Empty;
            matBtnEdit.Visible = true;
            matBtnSave.Visible = false;
            matBtnNew.Visible = true;
            matBtnDelete.Visible = true;
            txtmajorCategory.Enabled = false;
        }

        private void dgvMajorCategory_CurrentCellChanged(object sender, EventArgs e)
        {
            showValueCell();
        }

        private void showValueCell()
        {
            if (dgvMajorCategory.Rows.Count > 0)
            {
                if (dgvMajorCategory.CurrentRow != null)
                {
                    if (dgvMajorCategory.CurrentRow.Cells["major_category_desc"].Value != null)
                    {
                        p_id = Convert.ToInt32(dgvMajorCategory.CurrentRow.Cells["major_category_id"].Value);
                        txtmajorCategory.Text = dgvMajorCategory.CurrentRow.Cells["major_category_desc"].Value.ToString();
                        txtCreatedBy.Text = dgvMajorCategory.CurrentRow.Cells["mc_added_by"].Value.ToString();
                        txtCreatedAt.Text = dgvMajorCategory.CurrentRow.Cells["mc_added_at"].Value.ToString();
                        txtModifiedAt.Text = dgvMajorCategory.CurrentRow.Cells["mc_updated_at"].Value.ToString();
                        txtModifiedBy.Text = dgvMajorCategory.CurrentRow.Cells["mc_updated_by"].Value.ToString();
                    }
                }
            }
        }

        private void matBtnEdit_Click(object sender, EventArgs e)
        {
            mode = "edit";
            txtModifiedAt.Text = (dNow.ToString("M/d/yyyy"));
            txtModifiedBy.Text = userinfo.emp_name.ToUpper();
            matBtnDelete.Visible = false;
            matBtnCancel.Visible = true;
            matBtnNew.Visible = false;
            matBtnEdit.Visible = false;
            matBtnSave.Visible = true;
            txtmajorCategory.Enabled = true;
            txtmajorCategory.Focus();
        }

        public void MajorCategoryAlreadyExist()
        {

            PopupNotifier popup = new PopupNotifier();
            popup.Image = Resources.new_logo;
            popup.TitleText = "Ultra Maverick Notifications";
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(95, 7, 0, 0);
            popup.TitleFont = new Font("Tahoma", 10);
            popup.ContentText = "Major Category Already Exist!";
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
            dSet = objStorProc.sp_Major_Category(0, 
                txtmajorCategory.Text, "", "", "", "", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                MajorCategoryAlreadyExist();


                txtmajorCategory.Focus();
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
            //Start
            if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to update the  Major Category Information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {



                if (txtmajorCategory.Text.Trim() == string.Empty)
                {

                    FillRequiredFields();
                    txtmajorCategory.Focus();
                    return;
                }

                else
                {
                    if (saveMode())
                    {

                        string tmode = mode;

                        if (tmode == "add")
                        {
                            dgvMajorCategory.CurrentCell = dgvMajorCategory[0, dgvMajorCategory.Rows.Count - 1];
                            UpdateNotifications();
                        }
                        else
                        {
                            dgvMajorCategory.CurrentCell = dgvMajorCategory[0, temp_hid];

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
                dSet = objStorProc.sp_Major_Category(0, txtmajorCategory.Text, "", "", "", "", "getbyname");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    MajorCategoryAlreadyExist();

                    txtmajorCategory.Text = string.Empty;
                    txtmajorCategory.Focus();
                    return false;
                }
                else
                {

                    dSet.Clear();
                    dSet = objStorProc.sp_Major_Category(0, txtmajorCategory.Text.Trim(),

                        txtCreatedBy.Text.Trim(),
                        txtCreatedAt.Text.Trim(),
                        txtModifiedAt.Text.Trim(),
                        txtModifiedBy.Text.Trim(), "add");

                    showMajorCategoryData();
               

                    return true;
                }
            }
            else if (mode == "edit")
            {
                dSet.Clear();
                dSet = objStorProc.sp_Major_Category(0, 
                    txtmajorCategory.Text, 
                    "", "", "", "", "getbyname");

                dSet_temp.Clear();
                dSet_temp = objStorProc.sp_Major_Category(p_id, 
                    txtmajorCategory.Text, "", "", "", "", "getbyid");

                if (dSet.Tables[0].Rows.Count > 0)
                {
                    int tmpID = Convert.ToInt32(dSet.Tables[0].Rows[0][0].ToString());
                    if (tmpID == p_id)
                    {
                        dSet.Clear();
                        dSet = objStorProc.sp_Major_Category(p_id, 
                            txtmajorCategory.Text.Trim(),

                            txtCreatedBy.Text.Trim(),
                            txtCreatedAt.Text.Trim(),
                            txtModifiedAt.Text.Trim(),
                            txtModifiedBy.Text.Trim(), "edit");
                        UpdateNotifications();
                        showMajorCategoryData();
                        mode = "";
                        matBtnCancel_Click(new object(), new System.EventArgs());
                        return true;
                    }
                    else
                    {
                      
                        txtmajorCategory.Text = String.Empty;
                        txtmajorCategory.Focus();
                        return false;
                    }
                }
                else
                {
                    dSet.Clear();
                    dSet = objStorProc.sp_Major_Category(p_id, 
                        txtmajorCategory.Text.Trim(),

                          txtCreatedBy.Text.Trim(),
                          txtCreatedAt.Text.Trim(),
                          txtModifiedAt.Text.Trim(),
                          txtModifiedBy.Text.Trim(), "edit");
                    UpdateNotifications();
                    showMajorCategoryData();
                    mode = "";
                    matBtnCancel_Click(new object(), new System.EventArgs());
                }
            }
            else if (mode == "delete")
            {

                dSet_temp.Clear();
                dSet_temp = objStorProc.sp_Major_Category(p_id, 
                    txtmajorCategory.Text, "", "", "", "", "delete");

                return true;
            }
            return false;
        }


        private void metroFinalSaving_Click(object sender, EventArgs e)
        {
            if (txtmajorCategory.Text.Trim() == string.Empty)
            {
                FillRequiredFields();
                txtmajorCategory.Focus();
            }
            else
            {
                if (saveMode())
                {
                    MajorCategoryAlreadyExist();
                    string tmode = mode;

                    if (tmode == "add")
                    {
                        dgvMajorCategory.CurrentCell = dgvMajorCategory[0, dgvMajorCategory.Rows.Count - 1];

                    }
                    else
                    {
                        dgvMajorCategory.CurrentCell = dgvMajorCategory[0, temp_hid];
                    }
                    matBtnCancel_Click(sender, e);
                }
                else

                    return;
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
        private void matBtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMajorCategory.Rows.Count > 0)
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to remove the Major Category", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {


                    mode = "delete";

                    if (saveMode())
                    {
                        DeletedSuccessfully();
                        showMajorCategoryData();

                        matBtnCancel_Click("", e);
                    }
                }

                else
                {
                    return;
                }






            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            mode = "add";
            matBtnEdit.Visible = false;
            matBtnCancel.Visible = true;
            txtmajorCategory.Enabled = true;
            matBtnNew.Visible = false;
            txtmajorCategory.Text = String.Empty;
            txtModifiedAt.Text = String.Empty;
            txtModifiedBy.Text = String.Empty;
            matBtnDelete.Visible = false;
            txtCreatedAt.Text = (dNow.ToString("M/d/yyyy"));
            txtCreatedBy.Text = userinfo.emp_name.ToUpper();
            //txtCreatedByAndUserID.Text = userinfo.user_id.ToString();
            matBtnSave.Visible = true;
            txtmajorCategory.Select();
            txtmajorCategory.Focus();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            matBtnCancel.Visible = false;
            mode = "";
            txtCreatedAt.Text = String.Empty;
            txtCreatedBy.Text = String.Empty;
            matBtnEdit.Visible = true;
            matBtnSave.Visible = false;
            matBtnNew.Visible = true;
            matBtnDelete.Visible = true;
            txtmajorCategory.Enabled = false;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (dgvMajorCategory.Rows.Count > 0)
            {

                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure that you want to remove the Major Category", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {


                    mode = "delete";

                    if (saveMode())
                    {
                        DeletedSuccessfully();
                        showMajorCategoryData();

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
            txtModifiedAt.Text = (dNow.ToString("M/d/yyyy"));
            txtModifiedBy.Text = userinfo.emp_name.ToUpper();
            matBtnDelete.Visible = false;
            matBtnCancel.Visible = true;
            matBtnNew.Visible = false;
            matBtnEdit.Visible = false;
            matBtnSave.Visible = true;
            txtmajorCategory.Enabled = true;
            txtmajorCategory.Focus();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            dSet.Clear();
            dSet = objStorProc.sp_Major_Category(0,
                txtmajorCategory.Text, "", "", "", "", "getbyname");

            if (dSet.Tables[0].Rows.Count > 0)
            {
                MajorCategoryAlreadyExist();


                txtmajorCategory.Focus();
                return;
            }
            else
            {
                metroSave_Click(sender, e);
            }
        }
    }
}
